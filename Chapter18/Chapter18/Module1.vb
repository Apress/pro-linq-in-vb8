Imports System.Linq
Imports System.Data.Linq
Imports System.Diagnostics  'For the StackTrace.

Imports Chapter18.nwind

Module Module1

  Sub Main()
    ' Uncomment the functions you want to call.
    'YourTest()

    'Listing18_1()
    'Listing18_2()
    'Listing18_3()
    'Listing18_4()
    'Listing18_5()
    'Listing18_6()
    Listing18_7()

  End Sub

  Sub YourTest()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    ' Do whatever you want in here.

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing18_1()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind( _
      "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;")

    Dim seq As IQueryable(Of CategorySalesFor1997) = _
      From c In db.CategorySalesFor1997s _
      Where c.CategorySales > CDec(100000.0) _
      Order By c.CategorySales Descending _
      Select c

    For Each c As CategorySalesFor1997 In seq
      Console.WriteLine("{0} : {1:C}", c.CategoryName, c.CategorySales)
    Next c


    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing18_2()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind( _
      "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;")

    'db.CategorySalesFor1997s.InsertOnSubmit( _
    '                                        New CategorySalesFor1997 _
    '                                         With {.CategoryName = "Legumes", _
    '                                         .CategorySales = CDec(79043.92)})

    db.CategorySalesFor1997s.InsertOnSubmit( _
      New CategorySalesFor1997 With { _
        .CategoryName = "Legumes", _
        .CategorySales = CDec(79043.92)})

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing18_3()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    'Dim db As New TestDB("Data Source=.\SQLEXPRESS;" & _
    '                     "Initial Catalog=TestDB;" & _
    '                     "Integrated Security=SSPI;")
    Dim db As New TestDB( _
      "Data Source=.\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=SSPI;")

    db.CreateDatabase()

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing18_4()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    'Dim db As New TestDB("Data Source=.\SQLEXPRESS;" & _
    '                                   "Initial Catalog=TestDB;Integrated" & _
    '                                   " Security=SSPI;")

    Dim db As New TestDB( _
      "Data Source=.\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=SSPI;")

    db.Shapes.InsertOnSubmit(New Square With {.Width = 4})
    db.Shapes.InsertOnSubmit(New Rectangle With {.Width = 3, .Length = 6})
    db.Shapes.InsertOnSubmit(New Rectangle With {.Width = 11, .Length = 5})
    db.Shapes.InsertOnSubmit(New Square With {.Width = 6})
    db.Shapes.InsertOnSubmit(New Rectangle With {.Width = 4, .Length = 7})
    db.Shapes.InsertOnSubmit(New Square With {.Width = 9})

    db.SubmitChanges()

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing18_5()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    'Dim db As New TestDB("Data Source=.\SQLEXPRESS;" & _
    '                                   "Initial Catalog=TestDB;Integrated " & _
    '                                   "Security=SSPI;")

    Dim db As New TestDB( _
      "Data Source=.\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=SSPI;")

    ' First I get all squares which will include rectangles.
    Dim squares As IQueryable(Of Shape) = _
        From s In db.Shapes _
        Where TypeOf s Is Square _
        Select s

    Console.WriteLine("The following squares exist.")
    For Each s As Shape In squares
      Console.WriteLine("{0} : {1}", s.Id, s.ToString())
    Next s

    '    Now I'll get just the rectangles.
    Dim rectangles As IQueryable(Of Shape) = _
        From r In db.Shapes _
        Where TypeOf r Is Rectangle _
        Select r

    Console.WriteLine("{0}The following rectangles exist.", System.Environment.NewLine)
    For Each r As Shape In rectangles
      Console.WriteLine("{0} : {1}", r.Id, r.ToString())
    Next r

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing18_6()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind( _
      "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;")
    Dim testDb As New TestDB( _
      "Data Source=.\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=SSPI;")

    Dim cust As Customer = _
        db.Customers.Where(Function(c) c.CustomerID = "LONEP").SingleOrDefault()
    cust.ContactName = "Barbara Penczek"

    Dim rect As Rectangle = _
        CType(testDb.Shapes.Where(Function(s) s.Id = 3).SingleOrDefault(), Rectangle)
    rect.Width = 15

    Try
      Using scope As New System.Transactions.TransactionScope()
        db.SubmitChanges()
        testDb.SubmitChanges()
        Throw (New Exception("Just to rollback the transaction."))
        scope.Complete()
      End Using
    Catch ex As Exception
      Console.WriteLine(ex.Message)
    End Try

    db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, cust)
    Console.WriteLine("Contact Name = {0}", cust.ContactName)

    testDb.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, rect)
    Console.WriteLine("Rectangle Width = {0}", rect.Width)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing18_7a()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim statesXml As String = "<States>" & ControlChars.CrLf & _
"            <State ID=""OR"" Description=""Oregon"" />" & _
ControlChars.CrLf & _
"            <State ID=""WA"" Description=""Washington"" />" & _
ControlChars.CrLf & _
"            <State ID=""CA"" Description=""California"" />" & _
ControlChars.CrLf & _
"            <State ID=""AK"" Description=""Alaska"" />" & _
ControlChars.CrLf & _
"            <State ID=""NM"" Description=""New Mexico"" />" & _
ControlChars.CrLf & _
"            <State ID=""ID"" Description=""Idaho"" />" & _
ControlChars.CrLf & _
"            <State ID=""MT"" Description=""Montana"" />" & _
ControlChars.CrLf & _
"          </States>"

    Dim states As XElement = XElement.Parse(statesXml)

    Dim db As New Northwind( _
        "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;")

    Dim custs = (From c In db.Customers _
        Where c.Country = "USA" _
        Select c).AsEnumerable() _
        .Join(states.Elements("State"), _
            Function(c) c.Region, _
            Function(s) CStr(s.Attribute("ID")), _
            Function(c, s) New With {Key .Customer = c, _
                                                        Key .State = CStr(s.Attribute("Description"))})

    For Each cust In custs
      Console.WriteLine("Customer = {0} : {1} : {2}", _
          cust.Customer.CompanyName, cust.Customer.Region, cust.State)
    Next cust

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing18_7()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    'Dim states As XElement = _
    '                            <States>
    '                              <State ID="OR" Description="Oregon"/>
    '                              <State ID="WA" Description="Washington"/>
    '                              <State ID="CA" Description="California"/>
    '                              <State ID="AK" Description="Alaska"/>
    '                              <State ID="NM" Description="New Mexico"/>
    '                              <State ID="ID" Description="Idaho"/>
    '                              <State ID="MT" Description="Montana"/>
    '                            </States>

    'Dim db As New Northwind("Data Source=.\SQLEXPRESS;" & _
    '                                          "Initial Catalog=Northwind;" & _
    '                                          "Integrated Security=SSPI;")

    'Dim custs = ( _
    '                  From c In db.Customers _
    '                  Where c.Country = "USA" _
    '                  Select c).AsEnumerable() _
    '                  .Join(states.Elements("State"), _
    '                  Function(c) c.Region, _
    '                  Function(s) CStr(s.Attribute("ID")), _
    '                  Function(c, s) New With _
    '                  { _
    '                      Key .Customer = c, _
    '                      Key .State = CStr(s.Attribute("Description")) _
    '                  })

    'For Each cust In custs
    '  Console.WriteLine("Customer = {0} : {1} : {2}", _
    '    cust.Customer.CompanyName, cust.Customer.Region, cust.State)
    'Next cust

    Dim states As XElement = _
      <States>
        <State ID="OR" Description="Oregon"/>
        <State ID="WA" Description="Washington"/>
        <State ID="CA" Description="California"/>
        <State ID="AK" Description="Alaska"/>
        <State ID="NM" Description="New Mexico"/>
        <State ID="ID" Description="Idaho"/>
        <State ID="MT" Description="Montana"/>
      </States>

    Dim db As New Northwind( _
      "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;")

    Dim custs = (From c In db.Customers _
                 Where c.Country = "USA" _
                 Select c) _
                .AsEnumerable() _
                .Join(states.Elements("State"), _
                      Function(c) c.Region, _
                      Function(s) CStr(s.Attribute("ID")), _
                      Function(c, s) New With { _
                        Key .Customer = c, _
                        Key .State = CStr(s.Attribute("Description")) _
                      })

    For Each cust In custs
      Console.WriteLine("Customer = {0} : {1} : {2}", _
        cust.Customer.CompanyName, cust.Customer.Region, cust.State)
    Next cust

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing18_()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

End Module
