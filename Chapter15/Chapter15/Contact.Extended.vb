Namespace nwind
  Partial Public Class Contact
    Private Sub OnLoaded()
      Console.WriteLine("OnLoaded() called.")
    End Sub

    Private Sub OnCreated()
      Console.WriteLine("OnCreated() called.")
    End Sub

    Private Sub OnCompanyNameChanging(ByVal value As String)
      Console.WriteLine("OnCompanyNameChanging() called.")
    End Sub

    Private Sub OnCompanyNameChanged()
      Console.WriteLine("OnCompanyNameChanged() called.")
    End Sub
  End Class
End Namespace
