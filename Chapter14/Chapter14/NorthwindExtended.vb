Imports System
Imports System.Data.Linq

Namespace nwind
  Partial Public Class Northwind
    Inherits DataContext
    Private Sub InsertShipper(ByVal instance As Shipper)
      Console.WriteLine( _
        "Insert override method was called for shipper {0}.", instance.CompanyName)
      'Me.ExecuteDynamicInsert(instance)
    End Sub

    Private Sub UpdateShipper(ByVal instance As Shipper)
      Console.WriteLine( _
        "Update override method was called for shipper {0}.", instance.CompanyName)
      'Me.ExecuteDynamicUpdate(instance)
    End Sub

    Private Sub DeleteShipper(ByVal instance As Shipper)
      Console.WriteLine( _
        "Delete override method was called for shipper {0}.", instance.CompanyName)
      'Me.ExecuteDynamicDelete(instance)
    End Sub
  End Class
End Namespace
