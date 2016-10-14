Imports Chapter14.nwind
Imports System.Data.Linq

Module Module1

  Sub Main()
    ' Uncomment the functions you want to call.
    'YourTest()

    'Listing14_1()
    'Listing14_2()
    'Listing14_3()
    'Listing14_4()
    'Listing14_5()
    'Listing14_6()
    'Listing14_7()
    'Listing14_8()
    'Listing14_9()
    'Listing14_10()
    'Listing14_11()
    'Listing14_12()
    'Listing14_13()
    'Listing14_14()
    'Listing14_15()
    'Listing14_16()
    'Listing14_17()
    'Listing14_18()
    'Listing14_19()
    'Listing14_20()
    'Listing14_21()
    Listing14_22()
    'Listing14_23()
    'Listing14_24()
    'Listing14_25()

  End Sub

  Sub YourTest()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    ' Do whatever you want in here.

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing14_1()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    '  1.  Create the DataContext.
    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    '  2.  Instantiate an entity object.
    Dim cust As Customer = New Customer With _
    { _
      .CustomerID = "LAWN", _
      .CompanyName = "Lawn Wranglers", _
      .ContactName = "Mr. Abe Henry", _
      .ContactTitle = "Owner", _
      .Address = "1017 Maple Leaf Way", _
      .City = "Ft. Worth", _
      .Region = "TX", _
      .PostalCode = "76104", _
      .Country = "USA", _
      .Phone = "(800) MOW-LAWN", _
      .Fax = "(800) MOW-LAWO"}

    '  3.  Add the entity object to the Customers table.
    db.Customers.InsertOnSubmit(cust)

    '  4.  Call the SubmitChanges method.
    db.SubmitChanges()

    '  5.  Query the record.
    Dim customer As Customer = _
      db.Customers.Where(Function(c) c.CustomerID = "LAWN").First()
    Console.WriteLine("{0} - {1}", customer.CompanyName, customer.ContactName)

    '  This part of the code merely resets the database so the example can be
    '  run more than once.
    Console.WriteLine("Deleting the added customer LAWN.")
    db.Customers.DeleteOnSubmit(cust)
    db.SubmitChanges()

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing14_2()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim cust As Customer = ( _
      From c In db.Customers _
      Where c.CustomerID = "LONEP" _
      Select c).Single()

    '  Used to query record back out.
    Dim now As DateTime = DateTime.Now

    Dim order As Order = New Order With { _
      .CustomerID = cust.CustomerID, _
      .EmployeeID = 4, .OrderDate = now, _
      .RequiredDate = DateTime.Now.AddDays(7), _
      .ShipVia = 3, .Freight = New Decimal(24.66), _
      .ShipName = cust.CompanyName, _
      .ShipAddress = cust.Address, _
      .ShipCity = cust.City, _
      .ShipRegion = cust.Region, _
      .ShipPostalCode = cust.PostalCode, _
      .ShipCountry = cust.Country}

    cust.Orders.Add(order)

    db.SubmitChanges()

    Dim orders As IEnumerable(Of Order) = db.Orders _
      .Where(Function(o) o.CustomerID = "LONEP" AndAlso o.OrderDate.Value = now)

    For Each o As Order In orders
      Console.WriteLine("{0} {1}", o.OrderDate, o.ShipName)
    Next o

    '  This part of the code merely resets the database so the example can be
    '  run more than once.
    db.Orders.DeleteOnSubmit(order)
    db.SubmitChanges()


    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing14_3()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim cust As Customer = New Customer With { _
      .CustomerID = "LAWN", _
      .CompanyName = "Lawn Wranglers", _
      .ContactName = "Mr. Abe Henry", _
      .ContactTitle = "Owner", _
      .Address = "1017 Maple Leaf Way", _
      .City = "Ft. Worth", _
      .Region = "TX", _
      .PostalCode = "76104", _
      .Country = "USA", _
      .Phone = "(800) MOW-LAWN", _
      .Fax = "(800) MOW-LAWO"}

    cust.Orders.Add(New Order With { _
      .CustomerID = "LAWN", _
      .EmployeeID = 4, _
      .OrderDate = DateTime.Now, _
      .RequiredDate = DateTime.Now.AddDays(7), _
      .ShipVia = 3, _
      .Freight = New Decimal(24.66), _
      .ShipName = "Lawn Wranglers", _
      .ShipAddress = "1017 Maple Leaf Way", _
      .ShipCity = "Ft. Worth", _
      .ShipRegion = "TX", _
      .ShipPostalCode = "76104", _
      .ShipCountry = "USA"})

    db.Customers.InsertOnSubmit(cust)
    db.SubmitChanges()

    Dim customer As Customer = _
      db.Customers.Where(Function(c) c.CustomerID = "LAWN").First()

    Console.WriteLine("{0} - {1}", customer.CompanyName, customer.ContactName)
    For Each order As Order In customer.Orders
      Console.WriteLine("{0} - {1}", order.CustomerID, order.OrderDate)
    Next order

    '  This part of the code merely resets the database so the example can be
    '  run more than once.
    db.Orders.DeleteOnSubmit(cust.Orders.First())
    db.Customers.DeleteOnSubmit(cust)
    db.SubmitChanges()

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing14_4()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim cust As Customer = ( _
      From c In db.Customers _
      Where c.CustomerID Is "LONEP" _
      Select c).Single()

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing14_5()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim cust As Customer = ( _
      From c In db.Customers _
      Where c.CustomerID Is "LONEP" _
      Select c).Single()

    Console.WriteLine("{0} - {1}", cust.CompanyName, cust.ContactName)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing14_6()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim custs As IQueryable(Of Customer) = _
      From c In db.Customers _
      Where c.City = "London" _
      Select c

    For Each cust As Customer In custs
      Console.WriteLine("Customer: {0}", cust.CompanyName)
    Next cust

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing14_7()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim custs As IQueryable(Of Customer) = _
      From c In db.Customers _
      Where c.Country = "UK" AndAlso c.City = "London" _
      Order By c.CustomerID _
      Select c

    For Each cust As Customer In custs
      Console.WriteLine("{0} - {1}", cust.CompanyName, cust.ContactName)
      For Each order As Order In cust.Orders
        Console.WriteLine("    {0} {1}", order.OrderID, order.OrderDate)
      Next order
    Next cust

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing14_8()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim custs As IQueryable(Of Customer) = _
      From c In db.Customers _
      Where c.Country = "UK" AndAlso c.City = "London" _
      Order By c.CustomerID _
      Select c

    '  Turn on the logging.
    db.Log = Console.Out

    For Each cust As Customer In custs
      Console.WriteLine("{0} - {1}", cust.CompanyName, cust.ContactName)
      For Each order As Order In cust.Orders
        Console.WriteLine("    {0} {1}", order.OrderID, order.OrderDate)
      Next order
    Next cust

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing14_9()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim dlo As New DataLoadOptions()
    dlo.LoadWith(Of Customer)(Function(c) c.Orders)
    db.LoadOptions = dlo

    Dim custs As IQueryable(Of Customer) = ( _
      From c In db.Customers _
      Where c.Country = "UK" AndAlso c.City = "London" _
      Order By c.CustomerID _
      Select c)
    '  Turn on the logging.
    db.Log = Console.Out

    For Each cust As Customer In custs
      Console.WriteLine("{0} - {1}", cust.CompanyName, cust.ContactName)
    Next cust

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing14_10()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim dlo As New DataLoadOptions()
    dlo.LoadWith(Of Customer)(Function(c) c.Orders)
    dlo.LoadWith(Of Customer)(Function(c) c.CustomerCustomerDemos)
    db.LoadOptions = dlo

    Dim custs As IQueryable(Of Customer) = ( _
      From c In db.Customers _
      Where c.Country = "UK" AndAlso c.City = "London" _
      Order By c.CustomerID _
      Select c)
    '  Turn on the logging.
    db.Log = Console.Out

    For Each cust As Customer In custs
      Console.WriteLine("{0} - {1}", cust.CompanyName, cust.ContactName)
    Next cust

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing14_11()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim dlo As New DataLoadOptions()
    dlo.LoadWith(Of Customer)(Function(c) c.Orders)
    dlo.LoadWith(Of Order)(Function(o) o.OrderDetails)
    db.LoadOptions = dlo

    Dim custs As IQueryable(Of Customer) = ( _
      From c In db.Customers _
      Where c.Country = "UK" AndAlso c.City = "London" _
      Order By c.CustomerID _
      Select c)
    '  Turn on the logging.
    db.Log = Console.Out

    For Each cust As Customer In custs
      Console.WriteLine("{0} - {1}", cust.CompanyName, cust.ContactName)
      For Each order As Order In cust.Orders
        Console.WriteLine("    {0} {1}", order.OrderID, order.OrderDate)
      Next order
    Next cust

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing14_12()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim dlo As New DataLoadOptions()
    dlo.AssociateWith(Of Customer)(Function(c) _
      From o In c.Orders _
      Where o.OrderID < 10700 _
      Order By o.OrderDate Descending)
    'Order By o.OrderDate Descending _
    'Select o)
    db.LoadOptions = dlo

    Dim custs As IQueryable(Of Customer) = _
      From c In db.Customers _
      Where c.Country = "UK" AndAlso c.City = "London" _
      Order By c.CustomerID _
      Select c

    For Each cust As Customer In custs
      Console.WriteLine("{0} - {1}", cust.CompanyName, cust.ContactName)
      For Each order As Order In cust.Orders
        Console.WriteLine("    {0} {1}", order.OrderID, order.OrderDate)
      Next order
    Next cust

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing14_13()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim entities = From s In db.Suppliers _
                   Join c In db.Customers On s.City Equals c.City _
                   Select New With _
                   { _
                     .SupplierName = s.CompanyName, _
                     .CustomerName = c.CompanyName, _
                     .City = c.City _
                   }

    For Each e In entities
      Console.WriteLine("{0}: {1} - {2}", e.City, e.SupplierName, e.CustomerName)
    Next e


    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing14_14()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    db.Log = Console.Out

    Dim entities = From s In db.Suppliers _
                   Group Join c In db.Customers On s.City Equals c.City _
                   Into temp = Group _
                   From t In temp.DefaultIfEmpty() _
                   Select New With _
                   { _
                     .SupplierName = s.CompanyName, _
                     .CustomerName = t.CompanyName, _
                     .City = s.City _
                   }

    For Each e In entities
      Console.WriteLine("{0}: {1} - {2}", e.City, e.SupplierName, e.CustomerName)
    Next e

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing14_15()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim entities = _
      From s In db.Suppliers _
      Group Join c In db.Customers On s.City Equals c.City Into temp = Group _
      From t In temp.DefaultIfEmpty() _
      Select New With {Key s, Key t}

    For Each e In entities
      Console.WriteLine( _
        "{0}: {1} - {2}", _
        e.s.City, e.s.CompanyName, _
        If(e.t IsNot Nothing, e.t.CompanyName, ""))
    Next e

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing14_16()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    '  Turn on the logging.
    db.Log = Console.Out

    '  Pretend the values below are not hardcoded, but instead, obtained by accessing 
    '  a dropdown list's selected value.
    Dim dropdownListCityValue As String = "Cowes"
    Dim dropdownListCountryValue As String = "UK"

    Dim custs As IQueryable(Of Customer) = ( _
      From c In db.Customers _
      Select c)

    If (Not dropdownListCityValue.Equals("[ALL]")) Then
      custs = _
        From c In custs _
        Where c.City = dropdownListCityValue _
        Select c
    End If

    If (Not dropdownListCountryValue.Equals("[ALL]")) Then
      custs = _
        From c In custs _
        Where c.Country = dropdownListCountryValue _
        Select c
    End If

    For Each cust As Customer In custs
      Console.WriteLine("{0} - {1} - {2}", cust.CompanyName, cust.City, cust.Country)
    Next cust

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing14_17()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    '  Turn on the logging.
    db.Log = Console.Out

    '  Pretend the values below are not hardcoded, but instead, obtained by accessing 
    '  a dropdown list's selected value.
    Dim dropdownListCityValue As String = "[ALL]"
    Dim dropdownListCountryValue As String = "UK"

    Dim custs As IQueryable(Of Customer) = ( _
      From c In db.Customers _
      Select c)

    If (Not dropdownListCityValue.Equals("[ALL]")) Then
      custs = _
        From c In custs _
        Where c.City = dropdownListCityValue _
        Select c
    End If

    If (Not dropdownListCountryValue.Equals("[ALL]")) Then
      custs = _
        From c In custs _
        Where c.Country = dropdownListCountryValue _
        Select c
    End If

    For Each cust As Customer In custs
      Console.WriteLine("{0} - {1} - {2}", cust.CompanyName, cust.City, cust.Country)
    Next cust

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing14_18()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    db.Log = Console.Out

    Dim cities() As String = {"London", "Madrid"}

    Dim custs As IQueryable(Of Customer) = _
      db.Customers.Where(Function(c) cities.Contains(c.City))

    For Each cust As Customer In custs
      Console.WriteLine("{0} - {1}", cust.CustomerID, cust.City)
    Next cust

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing14_19()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim order As Order = ( _
      From o In db.Orders _
      Where o.EmployeeID = 5 _
      Order By o.OrderDate Descending _
      Select o).First()

    '  Save off the current employee so I can reset it at the end.
    Dim origEmployee As Employee = order.Employee

    Console.WriteLine("Before changing the employee.")
    Console.WriteLine( _
      "OrderID = {0} : OrderDate = {1} : EmployeeID = {2}", _
      order.OrderID, order.OrderDate, order.Employee.EmployeeID)

    Dim emp As Employee = ( _
      From e In db.Employees _
      Where e.EmployeeID = 9 _
      Select e).Single()

    '  Now I will assign the new employee to the order.
    order.Employee = emp

    db.SubmitChanges()

    Dim order2 As Order = ( _
      From o In emp.Orders _
      Where o.OrderID = order.OrderID _
      Select o).First()

    Console.WriteLine("{0}After changing the employee.", System.Environment.NewLine)
    Console.WriteLine( _
      "OrderID = {0} : OrderDate = {1} : EmployeeID = {2}", _
      order2.OrderID, order2.OrderDate, order2.Employee.EmployeeID)

    '  Now I need to reverse the changes so the example can be run multiple times.
    order.Employee = origEmployee
    db.SubmitChanges()

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing14_20()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim order As Order = ( _
      From o In db.Orders _
      Where o.EmployeeID = 5 _
      Order By o.OrderDate Descending _
      Select o).First()

    '  Save off the current employee so I can reset it at the end.
    Dim origEmployee As Employee = order.Employee

    Console.WriteLine("Before changing the employee.")
    Console.WriteLine("OrderID = {0} : OrderDate = {1} : EmployeeID = {2}", order.OrderID, order.OrderDate, order.Employee.EmployeeID)

    Dim emp As Employee = ( _
      From e In db.Employees _
      Where e.EmployeeID = 9 _
      Select e).Single()

    '  Remove the order from the original employee's Orders.
    origEmployee.Orders.Remove(order)

    '  Now add it to the new employee's orders.
    emp.Orders.Add(order)

    db.SubmitChanges()

    Console.WriteLine("{0}After changing the employee.", System.Environment.NewLine)
    Console.WriteLine( _
      "OrderID = {0} : OrderDate = {1} : EmployeeID = {2}", _
      order.OrderID, order.OrderDate, order.Employee.EmployeeID)

    '  Now I need to reverse the changes so the example can be run multiple times.
    order.Employee = origEmployee
    db.SubmitChanges()

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing14_21()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    '  Retrieve a customer to delete.
    Dim customer As Customer = ( _
      From c In db.Customers _
      Where c.CompanyName = "Alfreds Futterkiste" _
      Select c).Single()

    db.OrderDetails.DeleteAllOnSubmit( _
      customer.Orders.SelectMany(Function(o) o.OrderDetails))
    db.Orders.DeleteAllOnSubmit(customer.Orders)
    db.Customers.DeleteOnSubmit(customer)

    db.SubmitChanges()

    Dim customer2 As Customer = ( _
      From c In db.Customers _
      Where c.CompanyName = "Alfreds Futterkiste" _
      Select c).SingleOrDefault()

    Console.WriteLine( _
      "Customer {0} found.", If(customer2 IsNot Nothing, "is", "is not"))

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing14_22()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    '  Retrieve an order to unrelate.
    Dim order As Order = ( _
      From o In db.Orders _
      Where o.OrderID = 11043 _
      Select o).Single()

    '  Save off the original customer so I can set it back.
    Dim c As Customer = order.Customer

    Console.WriteLine("Orders before deleting the relationship:")
    For Each ord As Order In c.Orders
      Console.WriteLine("OrderID = {0}", ord.OrderID)
    Next ord

    '  Remove the relationship to the customer.
    order.Customer = Nothing
    db.SubmitChanges()

    Console.WriteLine("{0}Orders after deleting the relationship:", vbCrLf)
    For Each ord As Order In c.Orders
      Console.WriteLine("OrderID = {0}", ord.OrderID)
    Next ord

    '  Restore the database back to its original state.
    order.Customer = c
    db.SubmitChanges()


    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing14_23()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim ship As Shipper = ( _
      From s In db.Shippers _
      Where s.ShipperID = 1 _
      Select s).Single()

    ship.CompanyName = "Jiffy Shipping"

    Dim newShip As Shipper = New Shipper With { _
      .ShipperID = 4, _
      .CompanyName = "Vickey Rattz Shipping", _
      .Phone = "(800) SHIP-NOW"}

    db.Shippers.InsertOnSubmit(newShip)

    Dim deletedShip As Shipper = ( _
      From s In db.Shippers _
      Where s.ShipperID = 3 _
      Select s).Single()

    db.Shippers.DeleteOnSubmit(deletedShip)

    db.SubmitChanges()

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing14_24()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim custs As IQueryable(Of Customer) = _
      From c In db.Customers _
      Where c.CustomerID.TrimEnd("K"c) = "LAZY" _
      Select c

    For Each c As Customer In custs
      Console.WriteLine("{0}", c.CompanyName)
    Next c

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing14_25()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim custs As IQueryable(Of Customer) = _
      From c In db.Customers _
      Where c.CustomerID = "LAZY".TrimEnd("K"c) _
      Select c

    For Each c As Customer In custs
      Console.WriteLine("{0}", c.CompanyName)
    Next c

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing14_()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)


    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

End Module
