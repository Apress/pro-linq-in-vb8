Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports Chapter15.nwind

Module Module1

  Sub Main()
    ' Uncomment the functions you want to call.
    'YourTest()

    'Listing15_1()
    'Listing15_2()
    'Listing15_3()
    'Listing15_4()
    'Listing15_5()
    'Listing15_6()

  End Sub
  Sub YourTest()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    ' Do whatever you want in here.
    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    'Dim custs As IEnumerable(Of Customer) = _
    '  From c In db.Customers _
    '  Select c

    'For Each cust As Customer In custs
    '  Console.WriteLine("{0} - {1}", cust.CustomerID, cust.CompanyName)
    'Next

    Dim custs = _
      From c In db.Customers _
      Select New With {Key .Id = c.CustomerID, Key .Name = c.ContactName}

    For Each cust In custs
      Console.WriteLine("{0} - {1}", cust.Id, cust.Name)
    Next

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing15_1()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim cusorders = _
      From o In db.Orders _
      Where o.Customer.CustomerID = "CONSH" _
      Order By o.ShippedDate Descending _
      Select New With {Key .Customer = o.Customer, Key .Order = o}

    '  Grab the first order.
    Dim firstOrder As Order = cusorders.First().Order

    '  Now, let's save off the first order's shipcountry so I can reset it later.
    Dim MyshipCountry As String = firstOrder.ShipCountry
    Console.WriteLine("Order is originally shipping to {0}", MyshipCountry)

    '  Now, I'll change the order's ship country from UK to USA.
    firstOrder.ShipCountry = "USA"
    db.SubmitChanges()

    '  Query to see that the country was indeed changed.
    Dim country As String = ( _
        From o In db.Orders _
        Where o.Customer.CustomerID = "CONSH" _
        Order By o.ShippedDate Descending _
        Select o.ShipCountry).FirstOrDefault()

    Console.WriteLine("Order is now shipping to {0}", country)

    '  Reset the order in the database so example can be re-run.
    firstOrder.ShipCountry = MyshipCountry
    db.SubmitChanges()

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing15_2()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
        "Integrated Security=SSPI;")

    db.Log = Console.Out

    Dim contacts = _
      From c In db.Customers _
      Where c.City = "Buenos Aires" _
      Select New With {.Name = c.ContactName, .Phone = c.Phone}

    Dim orderedContacts = From co In contacts Order By co.Name

    For Each contact In orderedContacts
      Console.WriteLine("{0} - {1}", contact.Name, contact.Phone)
    Next contact

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing15_3()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
        "Integrated Security=SSPI;")

    db.Log = Console.Out

    Dim contacts = _
      From c In db.Customers _
      Where c.City = "Buenos Aires" _
      Select New CustomerContact(c.ContactName, c.Phone)

    Dim orderedContacts = From co In contacts Order By co.Name

    For Each contact In orderedContacts
      Console.WriteLine("{0} - {1}", contact.Name, contact.Phone)
    Next contact

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing15_4()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
        "Integrated Security=SSPI;")

    db.Log = Console.Out

    Dim contacts = From c In db.Customers _
      Where c.City = "Buenos Aires" _
      Select New CustomerContact(c.ContactName, c.Phone)

    For Each contact In contacts
      Console.WriteLine("{0} - {1}", contact.Name, contact.Phone)
    Next contact

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing15_5()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
        "Integrated Security=SSPI;")

    db.Log = Console.Out

    Dim contacts = db.Customers _
      .Where(Function(c) c.City = "Buenos Aires") _
      .Select(Function(c) New CustomerContact(c.ContactName, c.Phone)) _
      .OrderBy(Function(c) c.Name)

    For Each contact In contacts
      Console.WriteLine("{0} - {1}", contact.Name, contact.Phone)
    Next contact

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing15_6()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
        "Integrated Security=SSPI;")

    Dim contact As Contact = db.Contacts _
      .Where(Function(c) c.ContactID = 11) _
      .SingleOrDefault()
    Console.WriteLine("CompanyName = {0}", contact.CompanyName)

    contact.CompanyName = "Joe's House of Booze"
    Console.WriteLine("CompanyName = {0}", contact.CompanyName)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing15_()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

End Module

Public Class CustomerContact
  Public Name As String
  Public Phone As String

  Public Sub New(ByVal name As String, ByVal phone As String)
    Me.Name = name
    Me.Phone = phone
  End Sub
End Class
