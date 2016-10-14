Module Module1

    Sub Main()
    ' Uncomment the functions you want to call.
    'YourTest()

    'Listing13_1()
    'Listing13_2()
    'Listing13_3()

    End Sub

  Sub YourTest()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    ' Do whatever you want in here.

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing13_1()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New nwind.Northwind("Data Source=.\SQLEXPRESS;" & _
                                  "Initial Catalog=Northwind;" & _
                                  "Integrated Security=SSPI;")

    db.Log = Console.Out

    Dim custs = From c In db.Customers _
                Where c.Region Is "WA" _
                Select New With {Key .Id = c.CustomerID, Key .Name = c.ContactName}

    For Each cust In custs
      Console.WriteLine("{0} - {1}", cust.Id, cust.Name)
    Next cust

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing13_2()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New NwndDataContext()

    Dim custs As IQueryable(Of Customer) = From c In db.Customers _
                                           Where c.City = "London" _
                                           Select c

    For Each c As Customer In custs
      Console.WriteLine("{0} has {1} orders.", c.CompanyName, c.Orders.Count)
    Next c

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing13_3()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New NwndDataContext()

    db.Log = Console.Out

    Dim cust As Customer = New Customer With {.CustomerID = "EWICH", _
                                            .CompanyName = "Every 'Wich Way", _
                                            .ContactName = "Vickey Rattz", _
                                            .ContactTitle = "Owner", _
                                            .Address = "105 Chip Morrow Dr.", _
                                            .City = "Alligator Point", _
                                            .Region = "FL", _
                                            .PostalCode = "32346", _
                                            .Country = "USA", _
                                            .Phone = "(800) EAT-WICH", _
                                            .Fax = "(800) FAX-WICH"}

    db.Customers.InsertOnSubmit(cust)

    db.SubmitChanges()

    Dim customer As Customer = _
        db.Customers.Where(Function(c) c.CustomerID = "EWICH").First()
    Console.WriteLine("{0} - {1}", _
                      customer.CompanyName, customer.ContactName)

    '  Restore the database.
    db.Customers.DeleteOnSubmit(cust)
    db.SubmitChanges()

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing13_()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

End Module
