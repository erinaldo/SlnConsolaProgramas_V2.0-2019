﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenAsientosMQFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.cmbSitio = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbZafra = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnMostrar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbAnular = New System.Windows.Forms.RadioButton()
        Me.rbGenerar = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSemana = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcMostrar = New DevExpress.XtraGrid.GridControl()
        Me.gvMostrar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Seleccionar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Fecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Libro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Asiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Descripción = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Interfase = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.cmbSitio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbZafra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmbSemana.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcMostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(437, 381)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(119, 23)
        Me.txtTotal.TabIndex = 45
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotal.Visible = False
        '
        'cmbSitio
        '
        Me.cmbSitio.Location = New System.Drawing.Point(296, 22)
        Me.cmbSitio.Name = "cmbSitio"
        Me.cmbSitio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSitio.Properties.NullText = ""
        Me.cmbSitio.Size = New System.Drawing.Size(222, 20)
        Me.cmbSitio.TabIndex = 44
        '
        'cmbZafra
        '
        Me.cmbZafra.Location = New System.Drawing.Point(296, 53)
        Me.cmbZafra.Name = "cmbZafra"
        Me.cmbZafra.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbZafra.Properties.NullText = ""
        Me.cmbZafra.Size = New System.Drawing.Size(222, 20)
        Me.cmbZafra.TabIndex = 42
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Location = New System.Drawing.Point(9, 382)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(200, 23)
        Me.btnAceptar.TabIndex = 41
        Me.btnAceptar.Text = "Eliminar Asientos"
        '
        'btnMostrar
        '
        Me.btnMostrar.Enabled = False
        Me.btnMostrar.Location = New System.Drawing.Point(9, 118)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(200, 23)
        Me.btnMostrar.TabIndex = 40
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbAnular)
        Me.GroupBox1.Controls.Add(Me.rbGenerar)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar Tipo de Transacción"
        '
        'rbAnular
        '
        Me.rbAnular.AutoSize = True
        Me.rbAnular.Location = New System.Drawing.Point(16, 66)
        Me.rbAnular.Name = "rbAnular"
        Me.rbAnular.Size = New System.Drawing.Size(125, 17)
        Me.rbAnular.TabIndex = 3
        Me.rbAnular.TabStop = True
        Me.rbAnular.Text = "Anulación de Asiento"
        Me.rbAnular.UseVisualStyleBackColor = True
        '
        'rbGenerar
        '
        Me.rbGenerar.AutoSize = True
        Me.rbGenerar.Location = New System.Drawing.Point(16, 25)
        Me.rbGenerar.Name = "rbGenerar"
        Me.rbGenerar.Size = New System.Drawing.Size(136, 17)
        Me.rbGenerar.TabIndex = 2
        Me.rbGenerar.TabStop = True
        Me.rbGenerar.Text = "Generación de Asiento "
        Me.rbGenerar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(230, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Semana:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(230, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Zafra:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(230, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Sitio:"
        '
        'cmbSemana
        '
        Me.cmbSemana.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbSemana.Location = New System.Drawing.Point(296, 82)
        Me.cmbSemana.Name = "cmbSemana"
        Me.cmbSemana.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSemana.Properties.NullText = ""
        Me.cmbSemana.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cmbSemana.Properties.View = Me.GridView1
        Me.cmbSemana.Size = New System.Drawing.Size(222, 20)
        Me.cmbSemana.TabIndex = 52
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'gcMostrar
        '
        Me.gcMostrar.Location = New System.Drawing.Point(9, 147)
        Me.gcMostrar.MainView = Me.gvMostrar
        Me.gcMostrar.Name = "gcMostrar"
        Me.gcMostrar.Size = New System.Drawing.Size(536, 229)
        Me.gcMostrar.TabIndex = 53
        Me.gcMostrar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMostrar})
        '
        'gvMostrar
        '
        Me.gvMostrar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Seleccionar, Me.Fecha, Me.Libro, Me.Total, Me.Asiento, Me.Descripción, Me.Interfase})
        Me.gvMostrar.GridControl = Me.gcMostrar
        Me.gvMostrar.Name = "gvMostrar"
        Me.gvMostrar.OptionsView.ShowAutoFilterRow = True
        Me.gvMostrar.OptionsView.ShowGroupPanel = False
        '
        'Seleccionar
        '
        Me.Seleccionar.Caption = "Seleccionar"
        Me.Seleccionar.FieldName = "Selector"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.Visible = True
        Me.Seleccionar.VisibleIndex = 0
        Me.Seleccionar.Width = 50
        '
        'Fecha
        '
        Me.Fecha.Caption = "Fecha"
        Me.Fecha.FieldName = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.OptionsColumn.AllowEdit = False
        Me.Fecha.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Fecha.Visible = True
        Me.Fecha.VisibleIndex = 1
        Me.Fecha.Width = 60
        '
        'Libro
        '
        Me.Libro.Caption = "Libro"
        Me.Libro.FieldName = "Libro"
        Me.Libro.Name = "Libro"
        Me.Libro.OptionsColumn.AllowEdit = False
        Me.Libro.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Libro.Visible = True
        Me.Libro.VisibleIndex = 2
        Me.Libro.Width = 40
        '
        'Total
        '
        Me.Total.Caption = "Total"
        Me.Total.DisplayFormat.FormatString = "{0:0,0.00}"
        Me.Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Total.FieldName = "Total"
        Me.Total.Name = "Total"
        Me.Total.OptionsColumn.AllowEdit = False
        Me.Total.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Total.Visible = True
        Me.Total.VisibleIndex = 3
        Me.Total.Width = 60
        '
        'Asiento
        '
        Me.Asiento.Caption = "Asiento"
        Me.Asiento.FieldName = "Asiento"
        Me.Asiento.Name = "Asiento"
        Me.Asiento.OptionsColumn.AllowEdit = False
        Me.Asiento.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Asiento.Visible = True
        Me.Asiento.VisibleIndex = 4
        Me.Asiento.Width = 70
        '
        'Descripción
        '
        Me.Descripción.Caption = "Descripción"
        Me.Descripción.FieldName = "Descripcion"
        Me.Descripción.Name = "Descripción"
        Me.Descripción.OptionsColumn.AllowEdit = False
        Me.Descripción.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Descripción.Visible = True
        Me.Descripción.VisibleIndex = 5
        Me.Descripción.Width = 70
        '
        'Interfase
        '
        Me.Interfase.Caption = "Interface"
        Me.Interfase.FieldName = "Interface"
        Me.Interfase.Name = "Interfase"
        Me.Interfase.OptionsColumn.AllowEdit = False
        Me.Interfase.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Interfase.Visible = True
        Me.Interfase.VisibleIndex = 6
        Me.Interfase.Width = 50
        '
        'GenAsientosMQFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 416)
        Me.Controls.Add(Me.gcMostrar)
        Me.Controls.Add(Me.cmbSemana)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.cmbSitio)
        Me.Controls.Add(Me.cmbZafra)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GenAsientosMQFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generación de Asientos Servicios Internos / Contratista"
        CType(Me.cmbSitio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbZafra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmbSemana.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcMostrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMostrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents cmbSitio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbZafra As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbAnular As System.Windows.Forms.RadioButton
    Friend WithEvents rbGenerar As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbSemana As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcMostrar As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMostrar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Seleccionar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Fecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Libro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Asiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Descripción As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Interfase As DevExpress.XtraGrid.Columns.GridColumn
End Class
