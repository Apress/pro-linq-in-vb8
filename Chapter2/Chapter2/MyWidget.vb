Partial Public Class MyWidget
  Partial Private Sub MyWidgetStart(ByVal count As Integer)
  End Sub

  Partial Private Sub MyWidgetEnd(ByVal count As Integer)
  End Sub

  Public refCount As Integer

  Public Property ReferenceCount() As Integer
    Get
      refCount += 1
      Return refCount
    End Get
    Set(ByVal value As Integer)
      refCount = value
    End Set
  End Property

  Public Sub New()
    ReferenceCount = 0
    MyWidgetStart(ReferenceCount)
    Console.WriteLine("In the constructor of MyWidget.")
    MyWidgetEnd(ReferenceCount)
    Console.WriteLine("refCount = " & refCount)
  End Sub
End Class
