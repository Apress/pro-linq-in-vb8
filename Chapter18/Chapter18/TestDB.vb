Imports System.Data.Linq
Imports System.Data.Linq.Mapping

Partial Public Class TestDB
    Inherits DataContext
    Public Shapes As Table(Of Shape)

    Public Sub New(ByVal connection As String)
        MyBase.New(connection)
    End Sub

    Public Sub New(ByVal connection As System.Data.IDbConnection)
        MyBase.New(connection)
    End Sub

    Public Sub New(ByVal connection As String, _
            ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
        MyBase.New(connection, mappingSource)
    End Sub

    Public Sub New(ByVal connection As System.Data.IDbConnection, _
            ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
        MyBase.New(connection, mappingSource)
    End Sub
End Class

<Table(), _
    InheritanceMapping(Code:="G", Type:=GetType(Shape), IsDefault:=True), _
    InheritanceMapping(Code:="S", Type:=GetType(Square)), _
    InheritanceMapping(Code:="R", Type:=GetType(Rectangle))> _
Public Class Shape
  <Column(IsPrimaryKey:=True, IsDbGenerated:=True, DbType:="Int NOT NULL IDENTITY")> _
  Public Id As Integer

  <Column(IsDiscriminator:=True, DbType:="NVarChar(2)")> _
  Public ShapeCode As String

  <Column(DbType:="Int")> _
  Public StartingX As Integer

  <Column(DbType:="Int")> _
  Public StartingY As Integer

End Class

Public Class Square
  Inherits Shape
  <Column(DbType:="Int")> _
  Public Width As Integer
End Class

Public Class Rectangle
  Inherits Square
  <Column(DbType:="Int")> _
  Public Length As Integer
End Class

