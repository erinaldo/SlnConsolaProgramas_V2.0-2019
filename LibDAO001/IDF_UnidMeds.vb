'------------------------------------------------------------------------------
' Clase IDF_UnidMeds generada autom�ticamente con CrearClaseSQL
' de la tabla 'IDF_UnidMeds' de la base 'Finanzas'
' Fecha: 18/Mar/2015 10:50:43
'
' �Guillermo 'guille' Som, 2004-2015
'------------------------------------------------------------------------------
Option Strict On
Option Explicit On
'
Imports System
Imports System.Data
Imports System.Data.SqlClient
'
Public Class IDF_UnidMeds
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _UnidMedCodigo As System.String
    Private _Descripcion As System.String
    '
    ' Este m�todo se usar� para ajustar los anchos de las propiedades
    Private Function ajustarAncho(cadena As String, ancho As Integer) As String
        Dim sb As New System.Text.StringBuilder(New String(" "c, ancho))
        ' devolver la cadena quitando los espacios en blanco
        ' esto asegura que no se devolver� un tama�o mayor ni espacios "extras"
        Return (cadena & sb.ToString()).Substring(0, ancho).Trim()
    End Function
    '
    ' Las propiedades p�blicas
    ' TODO: Revisar los tipos de las propiedades
    Public Property UnidMedCodigo() As System.String
        Get
            Return ajustarAncho(_UnidMedCodigo,10)
        End Get
        Set(value As System.String)
            _UnidMedCodigo = value
        End Set
    End Property
    Public Property Descripcion() As System.String
        Get
            Return ajustarAncho(_Descripcion,50)
        End Get
        Set(value As System.String)
            _Descripcion = value
        End Set
    End Property
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el �ndice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.UnidMedCodigo.ToString()
            ElseIf index = 1 Then
                Return Me.Descripcion.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Me.UnidMedCodigo = value
            ElseIf index = 1 Then
                Me.Descripcion = value
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el �ndice corresponde al nombre de la columna)
        Get
            If index = "UnidMedCodigo" Then
                Return Me.UnidMedCodigo.ToString()
            ElseIf index = "Descripcion" Then
                Return Me.Descripcion.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "UnidMedCodigo" Then
                Me.UnidMedCodigo = value
            ElseIf index = "Descripcion" Then
                Me.Descripcion = value
            End If
        End Set
    End Property
    '
    ' Campos y m�todos compartidos (est�ticos) para gestionar la base de datos
    '
    ' La cadena de conexi�n a la base de datos
    Private Shared cadenaConexion As String = ""
    ' La cadena de selecci�n
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_UnidMeds"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' M�todos compartidos (est�ticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_UnidMeds
    Private Shared Function row2IDF_UnidMeds(r As DataRow) As IDF_UnidMeds
        ' asigna a un objeto IDF_UnidMeds los datos del dataRow indicado
        Dim oIDF_UnidMeds As New IDF_UnidMeds
        '
        oIDF_UnidMeds.UnidMedCodigo = r("UnidMedCodigo").ToString()
        oIDF_UnidMeds.Descripcion = r("Descripcion").ToString()
        '
        Return oIDF_UnidMeds
    End Function
    '
    ' asigna un objeto IDF_UnidMeds a la fila indicada
    Private Shared Sub IDF_UnidMeds2Row(oIDF_UnidMeds As IDF_UnidMeds, r As DataRow)
        ' asigna un objeto IDF_UnidMeds al dataRow indicado
        r("UnidMedCodigo") = oIDF_UnidMeds.UnidMedCodigo
        r("Descripcion") = oIDF_UnidMeds.Descripcion
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_UnidMeds
    Private Shared Sub nuevoIDF_UnidMeds(dt As DataTable, oIDF_UnidMeds As IDF_UnidMeds)
        ' Crear un nuevo IDF_UnidMeds
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_UnidMeds = row2IDF_UnidMeds(dr)
        '
        oI.UnidMedCodigo = oIDF_UnidMeds.UnidMedCodigo
        oI.Descripcion = oIDF_UnidMeds.Descripcion
        '
        IDF_UnidMeds2Row(oI, dr)
        '
        dt.Rows.Add(dr)
    End Sub
    '
    ' M�todos p�blicos
    '
    ' devuelve una tabla con los datos indicados en la cadena de selecci�n
    Public Shared Function Tabla() As DataTable
        Return Tabla(CadenaSelect)
    End Function
    Public Shared Function Tabla(sel As String) As DataTable
        ' devuelve una tabla con los datos de la tabla IDF_UnidMeds
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_UnidMeds")
        '
        Try
            da = New SqlDataAdapter(sel, cadenaConexion)
            da.Fill(dt)
        Catch
            Return Nothing
        End Try
        '
        Return dt
    End Function
    '
    Public Shared Function Buscar(sWhere As String) As IDF_UnidMeds
        ' Busca en la tabla los datos indicados en el par�metro
        ' el par�metro contendr� lo que se usar� despu�s del WHERE
        Dim oIDF_UnidMeds As IDF_UnidMeds = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_UnidMeds")
        Dim sel As String = "SELECT * FROM IDF_UnidMeds WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_UnidMeds = row2IDF_UnidMeds(dt.Rows(0))
        End If
        Return oIDF_UnidMeds
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se crear� uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el UnidMedCodigo existe en la tabla.
    '             TODO: Si en lugar de UnidMedCodigo usas otro campo, indicalo en la cadena SELECT
    '                   Tambi�n puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aqu� la selecci�n a realizar para acceder a este registro
        '       yo uso el UnidMedCodigo que es el identificador �nico de cada registro
        Dim sel As String = "SELECT * FROM IDF_UnidMeds WHERE UnidMedCodigo = '" & Me.UnidMedCodigo & "'"
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El par�metro, que es una cadena de selecci�n, indicar� el criterio de actualizaci�n
        '
        ' En caso de error, devolver� la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_UnidMeds")
        '
        cnn = New SqlConnection(cadenaConexion)
        'da = New SqlDataAdapter(CadenaSelect, cnn)
        da = New SqlDataAdapter(sel, cnn)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la m�s �ptima, pero funcionar�
        '-------------------------------------------
        Dim cb As New SqlCommandBuilder(da)
        da.UpdateCommand = cb.GetUpdateCommand()
        '
        '--------------------------------------------------------------------
        ' Esta est� m�s optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        'Dim sCommand As String
        ''
        '' El comando UPDATE
        '' TODO: Comprobar cual es el campo de �ndice principal (sin duplicados)
        ''       Yo compruebo que sea un campo llamado UnidMedCodigo, pero en tu caso puede ser otro
        ''       Ese campo, (en mi caso UnidMedCodigo) ser� el que hay que poner al final junto al WHERE.
        'sCommand = "UPDATE IDF_UnidMeds SET Descripcion = @Descripcion  WHERE (UnidMedCodigo = @UnidMedCodigo)"
        'da.UpdateCommand = New SqlCommand(sCommand, cnn)
        'da.UpdateCommand.Parameters.Add("@UnidMedCodigo", SqlDbType.NVarChar, 10, "UnidMedCodigo")
        'da.UpdateCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50, "Descripcion")
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        If dt.Rows.Count = 0 Then
            ' crear uno nuevo
            Return Crear()
        Else
            IDF_UnidMeds2Row(Me, dt.Rows(0))
        End If
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Actualizado correctamente"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Crear() As String
        ' Crear un nuevo registro
        ' En caso de error, devolver� la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_UnidMeds")
        '
        cnn = New SqlConnection(cadenaConexion)
        da = New SqlDataAdapter(CadenaSelect, cnn)
        'da = New SqlDataAdapter(CadenaSelect, cadenaConexion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la m�s �ptima, pero funcionar�
        '-------------------------------------------
        Dim cb As New SqlCommandBuilder(da)
        da.InsertCommand = cb.GetInsertCommand()
        '
        '--------------------------------------------------------------------
        ' Esta est� m�s optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        'Dim sCommand As String
        ''
        '' El comando INSERT
        '' TODO: No incluir el campo de clave primaria incremental
        ''       Yo compruebo que sea un campo llamado UnidMedCodigo, pero en tu caso puede ser otro
        'sCommand = "INSERT INTO IDF_UnidMeds (UnidMedCodigo, Descripcion)  VALUES(@UnidMedCodigo, @Descripcion)"
        'da.InsertCommand = New SqlCommand(sCommand, cnn)
        'da.InsertCommand.Parameters.Add("@UnidMedCodigo", SqlDbType.NVarChar, 10, "UnidMedCodigo")
        'da.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50, "Descripcion")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoIDF_UnidMeds(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo IDF_UnidMeds"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aqu� la selecci�n a realizar para acceder a este registro
        '       yo uso el UnidMedCodigo que es el identificador �nico de cada registro
        Dim sel As String = "SELECT * FROM IDF_UnidMeds WHERE UnidMedCodigo = '" & Me.UnidMedCodigo & "'"
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolver� la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_UnidMeds")
        '
        cnn = New SqlConnection(cadenaConexion)
        da = New SqlDataAdapter(sel, cnn)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la m�s �ptima, pero funcionar�
        '-------------------------------------------
        Dim cb As New SqlCommandBuilder(da)
        da.DeleteCommand = cb.GetDeleteCommand()
        '
        '
        '--------------------------------------------------------------------
        ' Esta est� m�s optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        'Dim sCommand As String
        ''
        '' El comando DELETE
        '' TODO: S�lo incluir el campo de clave primaria incremental
        ''       Yo compruebo que sea un campo llamado UnidMedCodigo, pero en tu caso puede ser otro
        'sCommand = "DELETE FROM IDF_UnidMeds WHERE (UnidMedCodigo = @p1)"
        'da.DeleteCommand = New SqlCommand(sCommand, cnn)
        'da.DeleteCommand.Parameters.Add("@p1", SqlDbType.NVarChar, 10, "UnidMedCodigo")
        'da.DeleteCommand.Parameters.Add("@p2", SqlDbType.Int, 0, "")
        '
        '
        da.Fill(dt)
        '
        If dt.Rows.Count = 0 Then
            Return "ERROR: No hay datos"
        Else
            dt.Rows(0).Delete()
        End If
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Borrado satisfactoriamente"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
End Class
