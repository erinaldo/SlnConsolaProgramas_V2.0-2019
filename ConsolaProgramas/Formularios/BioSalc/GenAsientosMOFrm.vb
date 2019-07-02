﻿Imports System.Data.SqlClient
Imports DevExpress.XtraSplashScreen

Public Class GenAsientosMOFrm
    Dim cnx As New SqlConnection
    Dim f As New Funciones

    Dim emp As String
    Dim adp As New SqlDataAdapter
    Dim dt As New DataTable
    Dim time As Integer
    Public Sub New(user As String, pwd As String, empresa As String, tiempo As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        cnx = New SqlConnection("Persist Security Info=False;User ID=" & user & ";Password=" & pwd & ";Initial Catalog=Biosalc;Server=AMIGODB\AMIGODB")
        f.Conexion = cnx
        emp = empresa
        time = tiempo
    End Sub
    Private Sub GenAsientosMOFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.NewTable("select * from REGIAO_AGR where case codigo when 'SM' then '01' when 'RL' then '20' end ='" & emp & "'", "sitio")
        f.NewTable("SELECT CODIGO AS ZafraID,UPPER(NOME) AS Descripcion FROM SAFRAS WHERE CODIGO >= 2018", "zafra")
        f.NewTable("SELECT ZafraID AS Año,SemanaID,NOME AS RangoFecha FROM VW_SEMANAS WHERE ZafraID in (SELECT CODIGO  FROM SAFRAS WHERE CODIGO >= 2018)", "semana")

        f.SetGridLookUpEdit(cmbSitio, f.dsDesarrollo.Tables("sitio"), "CODIGO", "NOME", "CODIGO")
        f.SetGridLookUpEdit(cmbZafra, f.dsDesarrollo.Tables("zafra"), "ZafraID", "Descripcion", "ZafraID")
        f.SetGridLookUpEdit(cmbSemana, f.dsDesarrollo.Tables("semana"), "SemanaID", "RangoFecha")

        'cmbSemana.Properties.View.OptionsView.ShowAutoFilterRow = True
        'cmbSemana.Properties.DataSource = f.dsDesarrollo.Tables("semana")
        'cmbSemana.Properties.ValueMember = "SemanaID"
        'cmbSemana.Properties.DisplayMember = "RangoFecha"
        'cmbSemana.Properties.View.Columns("Año").Visible = False
    End Sub

    Private Sub rbGenerar_CheckedChanged(sender As Object, e As EventArgs) Handles rbGenerar.CheckedChanged
        btnMostrar.Text = "Generar Asientos"
        If Not IsNothing(cmbSemana.EditValue) And Not IsNothing(cmbSitio.EditValue) And Not IsNothing(cmbZafra.EditValue) And (rbAnular.Checked Or rbGenerar.Checked) Then
            btnMostrar.Enabled = True
        End If
    End Sub
    Private Sub rbAnular_CheckedChanged(sender As Object, e As EventArgs) Handles rbAnular.CheckedChanged
        btnMostrar.Text = "Mostrar Asientos a anular"
        If Not IsNothing(cmbSemana.EditValue) And Not IsNothing(cmbSitio.EditValue) And Not IsNothing(cmbZafra.EditValue) And (rbAnular.Checked Or rbGenerar.Checked) Then
            btnMostrar.Enabled = True
        End If
    End Sub
    Private Sub cmbZafra_EditValueChanged(sender As Object, e As EventArgs) Handles cmbZafra.EditValueChanged
        f.dsDesarrollo.Tables("semana").DefaultView.RowFilter = "Año = " & cmbZafra.EditValue
        If Not IsNothing(cmbSemana.EditValue) And Not IsNothing(cmbSitio.EditValue) And Not IsNothing(cmbZafra.EditValue) And (rbAnular.Checked Or rbGenerar.Checked) Then
            btnMostrar.Enabled = True
        End If
    End Sub
    Private Sub cmbSitio_EditValueChanged(sender As Object, e As EventArgs) Handles cmbSitio.EditValueChanged
        If Not IsNothing(cmbSemana.EditValue) And Not IsNothing(cmbSitio.EditValue) And Not IsNothing(cmbZafra.EditValue) And (rbAnular.Checked Or rbGenerar.Checked) Then
            btnMostrar.Enabled = True
        End If
    End Sub
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        If rbGenerar.Checked Then
            If MsgBox("Desea generar asientos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Generar Asiento") = MsgBoxResult.Yes Then
                EjecutarProceso(True)
            End If
        Else
            EjecutarProceso(False)
        End If

    End Sub
    Public Sub EjecutarProceso(generar As Boolean)

        Dim opcion As Integer
        Dim editar As Boolean = True
        Dim sql As String

        If generar Then 'rbGenerar.Checked 
            opcion = 1
            editar = False
            sql = "spMTP_AsientosContable_MO @SitioID, @ZafraID, @SemanaID, @TipoTransaccion, @SelectorReg"
        Else
            opcion = 2
            sql = "spMTP_ObtenerAsientos_MO @SitioID, @ZafraID, @SemanaID, @TipoTransaccion, @SelectorReg"
        End If

        cnx.Open()
        Dim trsql = cnx.BeginTransaction()

        Try
            SplashScreenManager.ShowForm(GetType(WaitForm1))
            adp.SelectCommand = New SqlCommand(sql, cnx, trsql) ' & cmbSitio.EditValue & "', " & cmbZafra.EditValue & ", " & cmbSemana.EditValue & ", 1 , '*'"
            adp.SelectCommand.CommandTimeout = time
            adp.SelectCommand.Parameters.AddWithValue("@SitioID", cmbSitio.EditValue)
            adp.SelectCommand.Parameters.AddWithValue("@ZafraID", cmbZafra.EditValue)
            adp.SelectCommand.Parameters.AddWithValue("@SemanaID", cmbSemana.EditValue)
            adp.SelectCommand.Parameters.AddWithValue("@TipoTransaccion", opcion)
            adp.SelectCommand.Parameters.AddWithValue("@SelectorReg", "*")

            dt.Clear()
            adp.Fill(dt)
            If dt.Rows.Count = 0 Then
                MsgBox("No existen registros para la semana seleccionada!", MsgBoxStyle.Exclamation, "Información")
            Else
                f.InitGridControl(gcMostrar, gvMostrar, dt, "POR_INTERFAZ", True)


                f.FormatColumnGridControl(gvMostrar, "Selector", "Seleccionar", 50, DevExpress.Utils.FormatType.Custom, True)
                f.FormatColumnGridControl(gvMostrar, "Fecha", "Fecha", 60, DevExpress.Utils.FormatType.DateTime, False)
                f.FormatColumnGridControl(gvMostrar, "LIBRO_D", "Libro", 50, DevExpress.Utils.FormatType.Custom, False)
                f.FormatColumnGridControl(gvMostrar, "MONTO", "Monto", 60, DevExpress.Utils.FormatType.Numeric, "{0:0,0.00}", False)
                f.FormatColumnGridControl(gvMostrar, "Contratista", "Contratista", 50, DevExpress.Utils.FormatType.Custom, False)
                f.FormatColumnGridControl(gvMostrar, "#Asiento", "#Asiento", 70, DevExpress.Utils.FormatType.Custom, False)
                f.FormatColumnGridControl(gvMostrar, "Descripcion", "Descripción", 70, DevExpress.Utils.FormatType.Custom, False)

                If rbAnular.Checked And dt.Rows.Count Then
                    btnAceptar.Enabled = True
                End If

                trsql.Commit()
            End If
        Catch ex As SqlException
            trsql.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")

        Finally
            cnx.Close()

        End Try
        SplashScreenManager.CloseForm()
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If MsgBox("¿Esta seguro que desea eliminar los asientos seleccionados?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Anular asientos") = MsgBoxResult.Yes Then
            Dim cadena As String = ""

            cnx.Open()
            Dim trsql = cnx.BeginTransaction()

            For Each row As DataRow In dt.Rows
                If row.Item("Selector") Then
                    cadena += row.Item("#Asiento") & "," & row.Item("Contratista") & ","
                End If
            Next

            Try
                SplashScreenManager.ShowForm(GetType(WaitForm1))
                Dim cmd As New SqlCommand("spMTP_AsientosContable_MO @SitioID, @ZafraID, @SemanaID, @TipoTransaccion, @SelectorReg", cnx, trsql)
                cmd.CommandTimeout = time
                cmd.Parameters.AddWithValue("@SitioID", cmbSitio.EditValue)
                cmd.Parameters.AddWithValue("@ZafraID", cmbZafra.EditValue)
                cmd.Parameters.AddWithValue("@SemanaID", cmbSemana.EditValue)
                cmd.Parameters.AddWithValue("@TipoTransaccion", 3)
                cmd.Parameters.AddWithValue("@SelectorReg", cadena)

                cmd.ExecuteNonQuery()
                trsql.Commit()
                dt.DefaultView.RowFilter = "Selector = 0"

                MsgBox("Asientos eliminados exitosamente!", MsgBoxStyle.Information, "Eliminación de asientos")
                cnx.Close()

                SplashScreenManager.CloseForm()
                EjecutarProceso(False)
            Catch ex As SqlException
                trsql.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
                cnx.Close()
            End Try


        End If
    End Sub
    Private Sub cmbSemana_EditValueChanged(sender As Object, e As EventArgs) Handles cmbSemana.EditValueChanged
        If Not IsNothing(cmbSemana.EditValue) And Not IsNothing(cmbSitio.EditValue) And Not IsNothing(cmbZafra.EditValue) And (rbAnular.Checked Or rbGenerar.Checked) Then
            btnMostrar.Enabled = True
        End If
    End Sub
End Class