Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports Chapter16.nwind

'Imports nwind

Module Module1

  Sub Main()
    ' Uncomment the functions you want to call.
    'YourTest()

    'Listing16_1()
    'Listing16_2()
    'Listing16_3()
    'Listing16_4()
    'Listing16_5()
    'Listing16_6()
    'Listing16_7()
    'Listing16_8()
    'Listing16_9()
    'Listing16_10()
    'Listing16_11()
    'Listing16_12()
    'Listing16_13()
    'Listing16_14()
    'Listing16_15()
    'Listing16_16()
    'Listing16_17()
    'Listing16_18()
    'Listing16_19()
    'Listing16_20()
    Listing16_21()
    'Listing16_22()
    'Listing16_23()
    'Listing16_24()
    'Listing16_25()
    'Listing16_26()
    'Listing16_27()
    'Listing16_28()
    'Listing16_29()
    'Listing16_30()
    'Listing16_31()
    'Listing16_32()
    'Listing16_33()
    'Listing16_34()
    'Listing16_35()

  End Sub

  Sub YourTest()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    ' Do whatever you want in here.
    Dim db As New DataContext("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim cust As Customer = ( _
      From c In (CType(db.GetTable(GetType(Customer)), IQueryable(Of Customer))) _
      Where c.CustomerID = "LAZYK" _
      Select c).Single()

    Dim cust2 As Customer = ( _
      From c In (CType(db.GetTable(cust.GetType()), IQueryable(Of Customer))) _
      Where c.CustomerID = "LONEP" _
      Select c).Single()

    Console.WriteLine("Customer {0} retrieved.", cust2.CompanyName)


    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_1()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind( _
      "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;")

    Dim query As IQueryable(Of Customer) = _
      From cust In db.Customers _
      Where cust.Country = "USA" _
      Select cust

    For Each c As Customer In query
      Console.WriteLine("{0}", c.CompanyName)
    Next c

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_2()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim dc As New DataContext( _
      "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;")

    Dim query As IQueryable(Of Customer) = _
      From cust In dc.GetTable(Of Customer)() _
      Where cust.Country = "USA" _
      Select cust

    For Each c As Customer In query
      Console.WriteLine("{0}", c.CompanyName)
    Next c

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_3()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI")

    '  Let's get a cutomer to modify that will be outside our query of region == 'WA'.
    Dim cust As Customer = ( _
      From c In db.Customers _
      Where c.CustomerID = "LONEP" _
      Select c).Single()

    Console.WriteLine( _
      "Customer {0} has region = {1}.{2}", _
      cust.CustomerID, cust.Region, _
      System.Environment.NewLine)

    '  Ok, LONEP's region is OR.

    '  Now, let's get a sequence of customers from 'WA', which will not include LONEP
    '  since his region is OR.
    Dim custs As IEnumerable(Of Customer) = ( _
      From c In db.Customers _
      Where c.Region Is "WA" _
      Select c)

    Console.WriteLine("Customers from WA before ADO.NET change - start ...")
    For Each c As Customer In custs
      '  Display each entity object's Region.
      Console.WriteLine("Customer {0}'s region is {1}.", c.CustomerID, c.Region)
    Next c
    Console.WriteLine( _
      "Customers from WA before ADO.NET change - end.{0}", _
      System.Environment.NewLine)

    '  Now I will change LONEP's region to WA, which would have included it
    '  in that previous query's results.

    '  Change the customers' region through ADO.NET.
    Console.WriteLine("Updating LONEP's region to WA in ADO.NET...")
    ExecuteStatementInDb( _
      "update Customers set Region = 'WA' " & _
      "where CustomerID = 'LONEP'")
    Console.WriteLine("LONEP's region updated.{0}", System.Environment.NewLine)

    Console.WriteLine("So LONEP's region is WA in database, but ...")
    Console.WriteLine( _
      "Customer {0} has region = {1} in entity object.{2}", _
      cust.CustomerID, _
      cust.Region, _
      vbCrLf)

    '  Now, LONEP's region is WA in database, but still OR in entity object.

    '  Now, let's perform the query again.
    '  Display the customers entity object's region again.
    Console.WriteLine("Query entity objects after ADO.NET change - start ...")
    For Each c As Customer In custs
      '  Display each entity object's Region.
      Console.WriteLine("Customer {0}'s region is {1}.", c.CustomerID, c.Region)
    Next c
    Console.WriteLine( _
      "Query entity objects after ADO.NET change - end.{0}", _
      System.Environment.NewLine)

    '  We need to reset the changed values so that the code can be run
    '  more than once.
    Console.WriteLine("{0}Resetting data to original values.", vbCrLf)
    ExecuteStatementInDb( _
      "update Customers set Region = 'OR' where CustomerID = 'LONEP'")

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_4()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI")

    Console.WriteLine("First I will add customer LAWN.")
    db.Customers.InsertOnSubmit( _
      New Customer With { _
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
        .Fax = "(800) MOW-LAWO"})

    Console.WriteLine("Next I will query for customer LAWN.")
    Dim cust As Customer = ( _
      From c In db.Customers _
      Where c.CustomerID = "LAWN" _
      Select c).SingleOrDefault()
    Console.WriteLine( _
      "Customer LAWN {0}.{1}", _
      If(cust Is Nothing, "does not exist", "exists"), _
      vbCrLf)

    Console.WriteLine("Now I will delete customer LONEP")
    cust = ( _
      From c In db.Customers _
      Where c.CustomerID = "LONEP" _
      Select c).SingleOrDefault()
    db.Customers.DeleteOnSubmit(cust)

    Console.WriteLine("Next I will query for customer LONEP.")
    cust = ( _
      From c In db.Customers _
      Where c.CustomerID = "LONEP" _
      Select c).SingleOrDefault()
    Console.WriteLine( _
      "Customer LONEP {0}.{1}", _
      If(cust Is Nothing, "does not exist", "exists"), _
      vbCrLf)

    '  No need to reset database since SubmitChanges() was not called.

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_5()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim s As String = "c:\Northwind.mdf"
    'I can't get the above line to work. I get an execption that
    'It has to do with the way SQL Server is setup.
    'I think it used to work before I uninstalled, and reinstalled SQL server.
    'It may be that upgrading carried over old security setting, and the fresh
    'install setup stronger defaults. I don't know.

    'Dim s As String = "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
    '  "Integrated Security=SSPI"

    Dim dc As New DataContext(s)
    'Dim dc As New DataContext("c:\Northwind.mdf")

    Dim query As IQueryable(Of Customer) = _
      From cust In dc.GetTable(Of Customer)() _
      Where cust.Country = "USA" _
      Select cust

    For Each c As Customer In query
      Console.WriteLine("{0}", c.CompanyName)
    Next c

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_6()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    'Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
    '  "Integrated Security=SSPI;")

    Dim db As New Northwind("C:\Northwind.mdf")

    Dim query As IQueryable(Of Customer) = _
      From cust In db.Customers _
      Where cust.Country = "USA" _
      Select cust

    For Each c As Customer In query
      Console.WriteLine("{0}", c.CompanyName)
    Next c

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_7()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim query As IQueryable(Of Customer) = _
      From cust In db.Customers _
      Where cust.Country = "USA" _
      Select cust

    For Each c As Customer In query
      Console.WriteLine("{0}", c.CompanyName)
    Next c

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_8()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Using sqlConn As New System.Data.SqlClient.SqlConnection( _
      "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;")

      Dim cmd As String = _
        "insert into Customers values ('LAWN', 'Lawn Wranglers', " & _
        "  'Mr. Abe Henry', 'Owner', '1017 Maple Leaf Way', 'Ft. Worth', 'TX', " & _
        "  '76104', 'USA', '(800) MOW-LAWN', '(800) MOW-LAWO')"

      Using sqlComm As New System.Data.SqlClient.SqlCommand(cmd)

        sqlComm.Connection = sqlConn

        sqlConn.Open()
        '  Insert the record.
        sqlComm.ExecuteNonQuery()

        Dim db As New Northwind(sqlConn)

        Dim query As IQueryable(Of Customer) = _
          From cust In db.Customers _
          Where cust.Country = "USA" _
          Select cust

        Console.WriteLine("Customers after insertion, but before deletion.")
        For Each c As Customer In query
          Console.WriteLine("{0}", c.CompanyName)
        Next c

        sqlComm.CommandText = "delete from Customers where CustomerID = 'LAWN'"
        '  Delete the record.
        sqlComm.ExecuteNonQuery()

        Console.WriteLine("{0}{0}Customers after deletion.", vbCrLf)
        For Each c As Customer In query
          Console.WriteLine("{0}", c.CompanyName)
        Next c
      End Using
    End Using

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_9()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim mapPath As String = "abbreviatednorthwindmap.xml"
    Dim nwindMap As XmlMappingSource = _
      XmlMappingSource.FromXml(System.IO.File.ReadAllText(mapPath))

    Dim db As New DataContext("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;", nwindMap)

    Dim query As IQueryable(Of Linqdev.Customer) = _
      From cust In db.GetTable(Of Linqdev.Customer)() _
      Where cust.Country = "USA" _
      Select cust

    For Each c As Linqdev.Customer In query
      Console.WriteLine("{0}", c.CompanyName)
    Next c

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_10()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Using sqlConn As New System.Data.SqlClient.SqlConnection( _
      "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;")

      Dim cmd As String = _
        "insert into Customers values ('LAWN', 'Lawn Wranglers', " _
        & vbCrLf & _
        "        'Mr. Abe Henry', 'Owner', '1017 Maple Leaf Way', 'Ft. Worth', 'TX', " _
        & vbCrLf & _
        "        '76104', 'USA', '(800) MOW-LAWN', '(800) MOW-LAWO')"

      Using sqlComm As New System.Data.SqlClient.SqlCommand(cmd)

        sqlComm.Connection = sqlConn

        sqlConn.Open()
        '  Insert the record.
        sqlComm.ExecuteNonQuery()

        Dim mapPath As String = "abbreviatednorthwindmap.xml"
        Dim nwindMap As XmlMappingSource = _
          XmlMappingSource.FromXml(System.IO.File.ReadAllText(mapPath))

        Dim db As New DataContext(sqlConn, nwindMap)

        Dim query As IQueryable(Of Linqdev.Customer) = _
          From cust In db.GetTable(Of Linqdev.Customer)() _
          Where cust.Country = "USA" _
          Select cust

        Console.WriteLine("Customers after insertion, but before deletion.")
        For Each c As Linqdev.Customer In query
          Console.WriteLine("{0}", c.CompanyName)
        Next c

        sqlComm.CommandText = "delete from Customers where CustomerID = 'LAWN'"
        '  Delete the record.
        sqlComm.ExecuteNonQuery()

        Console.WriteLine("{0}{0}Customers after deletion.", vbCrLf)
        For Each c As Linqdev.Customer In query
          Console.WriteLine("{0}", c.CompanyName)
        Next c
      End Using
    End Using

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_11()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim sqlConn As New System.Data.SqlClient.SqlConnection( _
      "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;")

    Try
      sqlConn.Open()

      Dim sqlQuery As String = _
        "select ContactTitle from Customers where CustomerID = 'LAZYK'"
      Dim originalTitle As String = GetStringFromDb(sqlConn, sqlQuery)
      Dim title As String = originalTitle
      Console.WriteLine("Title from database record: {0}", title)

      Dim db As New Northwind(sqlConn)

      Dim c As Customer = ( _
        From cust In db.Customers _
        Where cust.CustomerID = "LAZYK" _
        Select cust).Single()
      Console.WriteLine("Title from entity object : {0}", c.ContactTitle)

      Console.WriteLine(String.Format("{0}Change the title to " & _
        "'Director of Marketing' in the entity object:", vbCrLf))
      c.ContactTitle = "Director of Marketing"

      title = GetStringFromDb(sqlConn, sqlQuery)
      Console.WriteLine("Title from database record: {0}", title)

      Dim c2 As Customer = ( _
        From cust In db.Customers _
        Where cust.CustomerID = "LAZYK" _
        Select cust).Single()
      Console.WriteLine("Title from entity object : {0}", c2.ContactTitle)

      db.SubmitChanges()
      Console.WriteLine( _
        String.Format("{0}SubmitChanges() method has been called.", vbCrLf))

      title = GetStringFromDb(sqlConn, sqlQuery)
      Console.WriteLine("Title from database record: {0}", title)

      Console.WriteLine("Restoring ContactTitle back to original value ...")
      c.ContactTitle = "Marketing Manager"
      db.SubmitChanges()
      Console.WriteLine("ContactTitle restored.")
    Finally
      sqlConn.Close()
    End Try

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_12()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Console.WriteLine("Querying for the LAZYK Customer with LINQ.")
    Dim cust1 As Customer = ( _
      From c In db.Customers _
      Where c.CustomerID = "LAZYK" _
      Select c).Single()

    Console.WriteLine("Querying for the LONEP Customer with LINQ.")
    Dim cust2 As Customer = ( _
      From c In db.Customers _
      Where c.CustomerID = "LONEP" _
      Select c).Single()

    Dim cmd As String = _
      "update Customers set ContactTitle = 'Director of Marketing' " & _
      "  where CustomerID = 'LAZYK'; " & _
      "update Customers set ContactTitle = 'Director of Sales' " & _
      "  where CustomerID = 'LONEP'"
    ExecuteStatementInDb(cmd)

    Console.WriteLine("Change ContactTitle in entity objects for LAZYK and LONEP.")
    cust1.ContactTitle = "Vice President of Marketing"
    cust2.ContactTitle = "Vice President of Sales"

    Try
      Console.WriteLine("Calling SubmitChanges() ...")
      db.SubmitChanges(ConflictMode.ContinueOnConflict)
      Console.WriteLine("SubmitChanges() called successfully.")
    Catch ex As ChangeConflictException
      Console.WriteLine( _
        "Conflict(s) occurred calling SubmitChanges(): {0}", ex.Message)

      For Each objectConflict As ObjectChangeConflict In db.ChangeConflicts
        Console.WriteLine( _
          "Conflict for {0} occurred.", _
          (CType(objectConflict.Object, Customer)).CustomerID)

        For Each memberConflict _
            As MemberChangeConflict _
            In objectConflict.MemberConflicts
          Console.WriteLine( _
            "  LINQ value = {0}{1}  Database value = {2}", _
            memberConflict.CurrentValue, _
            vbCrLf, _
            memberConflict.DatabaseValue)
        Next memberConflict
      Next objectConflict
    End Try

    Console.WriteLine("{0}Resetting data to original values.", vbCrLf)
    cmd = _
      "update Customers set ContactTitle = 'Marketing Manager'" & _
      "  where CustomerID = 'LAZYK'; " & _
      "update Customers set ContactTitle = 'Sales Manager' " & _
      "  where CustomerID = 'LONEP'"
    ExecuteStatementInDb(cmd)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_13()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind( _
      "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Console.WriteLine("Querying for the LAZYK Customer with LINQ.")
    Dim cust1 As Customer = ( _
      From c In db.Customers _
      Where c.CustomerID = "LAZYK" _
      Select c).Single()

    Console.WriteLine("Querying for the LONEP Customer with LINQ.")
    Dim cust2 As Customer = ( _
    From c In db.Customers _
    Where c.CustomerID = "LONEP" _
    Select c).Single()

    Dim cmd As String = _
      "update Customers set ContactTitle = 'Director of Marketing' " & vbCrLf & _
      "                       where CustomerID = 'LAZYK'; " & vbCrLf & _
      "                       update Customers set ContactTitle = " & _
      "                         'Director of Sales' " & vbCrLf & _
      "                       where CustomerID = 'LONEP'"
    ExecuteStatementInDb(cmd)

    Console.WriteLine("Change ContactTitle in entity objects for LAZYK and LONEP.")
    cust1.ContactTitle = "Vice President of Marketing"
    cust2.ContactTitle = "Vice President of Sales"

    Try
      Console.WriteLine("Calling SubmitChanges() ...")
      db.SubmitChanges(ConflictMode.FailOnFirstConflict)
      Console.WriteLine("SubmitChanges() called successfully.")
    Catch ex As ChangeConflictException
      Console.WriteLine( _
        "Conflict(s) occurred calling SubmitChanges(): {0}", _
        ex.Message)

      For Each objectConflict As ObjectChangeConflict In db.ChangeConflicts
        Console.WriteLine( _
          "Conflict for {0} occurred.", _
          (CType(objectConflict.Object, Customer)).CustomerID)

        For Each memberConflict As MemberChangeConflict _
            In objectConflict.MemberConflicts
          Console.WriteLine( _
            "  LINQ value = {0}{1}  Database value = {2}", _
            memberConflict.CurrentValue, vbCrLf, memberConflict.DatabaseValue)
        Next memberConflict
      Next objectConflict
    End Try

    Console.WriteLine("{0}Resetting data to original values.", vbCrLf)
    cmd = "update Customers set ContactTitle = 'Marketing Manager'" & vbCrLf & _
      "                where CustomerID = 'LAZYK'; " & vbCrLf & _
      "              update Customers set ContactTitle = 'Sales Manager' " & vbCrLf & _
      "                where CustomerID = 'LONEP'"
    ExecuteStatementInDb(cmd)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_14()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Console.WriteLine("The Northwind database {0}.", _
      If(db.DatabaseExists(), "exists", "does not exist"))

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_15()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    'Dim db As New Northwind( _
    '  "Data Source=.\SQLEXPRESS;" & _
    '  "Initial Catalog=C:\Northwnd4.mdf;" & _
    '  "Integrated Security=SSPI;")
    'You can try the following command to specify the new DB.
    'For me, it generates an execption that I failed to generate a 
    'a user instance of SQL Server.
    'This is due to the way I have SQL Server setup.
    'Not sure how to change it, just setting it to 
    Dim db As New Northwind("C:\Northwnd.mdf")
    db.CreateDatabase()

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_16()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    'Dim db As New Northwind( _
    '  "Data Source=.\SQLEXPRESS;" & _
    '  "Initial Catalog=C:\Northwnd4.mdf;" & _
    '  "Integrated Security=SSPI;")
    Dim db As New Northwind("C:\Northwnd.mdf")
    db.DeleteDatabase()

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_17()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim results As IQueryable(Of ProductsUnderThisUnitPriceResult) = _
      db.ProductsUnderThisUnitPrice(New Decimal(5.5D))

    For Each prod As ProductsUnderThisUnitPriceResult In results
      Console.WriteLine("{0} - {1:C}", prod.ProductName, prod.UnitPrice)
    Next prod

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_18()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim custs As IEnumerable(Of Customer) = db.ExecuteQuery(Of Customer) _
      ("select CustomerID, CompanyName, ContactName, ContactTitle" & vbCrLf & _
       "from Customers where Region = {0}", "WA")

    For Each c As Customer In custs
      Console.WriteLine("ID = {0} : Name = {1} : Contact = {2}", _
        c.CustomerID, c.CompanyName, c.ContactName)
    Next c

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_19()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim custs As IEnumerable(Of Customer) = db.ExecuteQuery(Of Customer) _
      ("select CustomerID, CompanyName, ContactName, ContactTitle " & _
       "from Customers where Region = 'WA'")

    For Each c As Customer In custs
      Console.WriteLine("ID = {0} : Name = {1} : Contact = {2}", _
        c.CustomerID, c.CompanyName, c.ContactName)
    Next c

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_20()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim custs As IEnumerable(Of Customer) = db.ExecuteQuery(Of Customer) _
      ("select CustomerID, Address + ', ' + City + ', ' + Region as Address " & _
       "from Customers where Region = 'WA'")

    For Each c As Customer In custs
      Console.WriteLine("Id = {0} : Address = {1}", c.CustomerID, c.Address)
    Next c

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_21()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Using sqlConn As New System.Data.SqlClient.SqlConnection( _
      "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;")

      Dim cmd As String = _
      "select CustomerID, CompanyName, ContactName, ContactTitle " & _
      "from Customers where Region = 'WA'"

      Using sqlComm As New System.Data.SqlClient.SqlCommand(cmd)

        sqlComm.Connection = sqlConn
        sqlConn.Open()
        Using reader As System.Data.SqlClient.SqlDataReader = sqlComm.ExecuteReader()

          Dim db As New Northwind(sqlConn)
          Dim custs As IEnumerable(Of Customer) = db.Translate(Of Customer)(reader)

          For Each c As Customer In custs
            Console.WriteLine("ID = {0} : Name = {1} : Contact = {2}", _
            c.CustomerID, c.CompanyName, c.ContactName)
          Next c
        End Using
      End Using
    End Using

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_22()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Console.WriteLine("Inserting customer ...")
    Dim rowsAffected As Integer = db.ExecuteCommand( _
      "insert into Customers values ({0}, 'Lawn Wranglers', " & _
      " 'Mr. Abe Henry', 'Owner', '1017 Maple Leaf Way', 'Ft. Worth', 'TX', " & _
      " '76104', 'USA', '(800) MOW-LAWN', '(800) MOW-LAWO')", "LAWN")
    Console.WriteLine("Insert complete.{0}", vbCrLf)

    Console.WriteLine("There were {0} row(s) affected.  Is customer in database?", _
      rowsAffected)

    Dim cust As Customer = ( _
      From c In db.Customers _
      Where c.CustomerID = "LAWN" _
      Select c).DefaultIfEmpty().Single()

    Console.WriteLine("{0}{1}", _
      If(cust IsNot Nothing, "Yes, customer is in database.", _
        "No, customer is not in database."), vbCrLf)

    Console.WriteLine("Deleting customer ...")
    rowsAffected = db.ExecuteCommand( _
      "delete from Customers where CustomerID = {0}", "LAWN")

    Console.WriteLine("Delete complete.{0}", vbCrLf)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_23()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")
    Dim rc As Integer = db.CustomersCountByRegion("WA")
    Console.WriteLine("There are {0} customers in WA.", rc)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_24()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")
    Dim totalSales As Nullable(Of Decimal) = 0
    Dim rc As Integer = db.CustOrderTotal("LAZYK", totalSales)
    Console.WriteLine("Customer LAZYK has total sales of {0:C}.", totalSales)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_25()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim results As ISingleResult(Of CustomersByCityResult) = _
      db.CustomersByCity("London")

    For Each cust As CustomersByCityResult In results
      Console.WriteLine("{0} - {1} - {2} - {3}", _
        cust.CustomerID, cust.CompanyName, cust.ContactName, cust.City)
    Next cust

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_26()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim results As IMultipleResults = db.WholeOrPartialCustomersSet(1)

    For Each cust As WholeOrPartialCustomersSetResult1 _
        In results.GetResult(Of WholeOrPartialCustomersSetResult1)()
      Console.WriteLine("{0} - {1} - {2} - {3}", _
        cust.CustomerID, cust.CompanyName, cust.ContactName, cust.City)
    Next cust

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_27()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim results As IMultipleResults = db.GetCustomerAndOrders("LAZYK")

    Dim cust As GetCustomerAndOrdersResult1 = _
      results.GetResult(Of GetCustomerAndOrdersResult1)().Single()

    Console.WriteLine("{0} orders:", cust.CompanyName)

    For Each order As GetCustomerAndOrdersResult2 _
        In results.GetResult(Of GetCustomerAndOrdersResult2)()
      Console.WriteLine("{0} - {1}", order.OrderID, order.OrderDate)
    Next order

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_28()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim products As IQueryable(Of Product) = _
      From p In db.Products _
      Where p.UnitPrice.Equals(db.MinUnitPriceByCategory(p.CategoryID)) _
      Select p

    For Each p As Product In products
      Console.WriteLine("{0} - {1:C}", p.ProductName, p.UnitPrice)
    Next p

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_29()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim custs As IQueryable(Of Customer) = _
      From c In db.Customers _
      Where c.Region Is "WA" _
      Select c

    Dim dbc As System.Data.Common.DbCommand = db.GetCommand(custs)

    Console.WriteLine("Query's timeout is: {0}{1}", dbc.CommandTimeout, vbCrLf)

    dbc.CommandTimeout = 1

    Console.WriteLine("Query's SQL is: {0}{1}", dbc.CommandText, vbCrLf)

    Console.WriteLine("Query's timeout is: {0}{1}", dbc.CommandTimeout, vbCrLf)

    For Each c As Customer In custs
      Console.WriteLine("{0}", c.CompanyName)
    Next c

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_30()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim cust As Customer = ( _
      From c In db.Customers _
      Where c.CustomerID = "LAZYK" _
      Select c).Single()
    cust.Region = "Washington"

    db.Customers.InsertOnSubmit( _
      New Customer With { _
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
        .Fax = "(800) MOW-LAWO"})

    Dim cust2 As Customer = ( _
      From c In db.Customers _
      Where c.CustomerID = "LONEP" _
      Select c).Single()
    db.Customers.DeleteOnSubmit(cust2)
    cust2 = Nothing

    Dim changeSet As ChangeSet = db.GetChangeSet()

    Console.WriteLine("{0}First, the added entities:", vbCrLf)
    For Each c As Customer In changeSet.Inserts
      Console.WriteLine("Customer {0} will be added.", c.CompanyName)
    Next c

    Console.WriteLine("{0}Second, the modified entities:", vbCrLf)
    For Each c As Customer In changeSet.Updates
      Console.WriteLine("Customer {0} will be updated.", c.CompanyName)
    Next c

    Console.WriteLine("{0}Third, the removed entities:", vbCrLf)
    For Each c As Customer In changeSet.Deletes
      Console.WriteLine("Customer {0} will be deleted.", c.CompanyName)
    Next c

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_31()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New DataContext("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim cust As Customer = ( _
      From c In db.GetTable(Of Customer)() _
      Where c.CustomerID = "LAZYK" _
      Select c).Single()

    Console.WriteLine("Customer {0} retrieved.", cust.CompanyName)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_32()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New DataContext("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim cust As Customer = ( _
      From c In (CType(db.GetTable(GetType(Customer)), IQueryable(Of Customer))) _
      Where c.CustomerID = "LAZYK" _
      Select c).Single()

    Console.WriteLine("Customer {0} retrieved.", cust.CompanyName)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_33()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim cust As Customer = ( _
      From c In db.Customers _
      Where c.CustomerID = "GREAL" _
      Select c).Single()

    Console.WriteLine("Customer's original name is {0}, ContactTitle is {1}.{2}", _
      cust.ContactName, cust.ContactTitle, vbCrLf)

    ExecuteStatementInDb(String.Format( _
      "update Customers set ContactName = 'Brad Radaker' where CustomerID = 'GREAL'"))

    cust.ContactTitle = "Chief Technology Officer"

    Console.WriteLine( _
      "Customer's name before refresh is {0}, ContactTitle is {1}.{2}", _
      cust.ContactName, cust.ContactTitle, vbCrLf)

    db.Refresh(RefreshMode.KeepChanges, cust)

    Console.WriteLine( _
      "Customer's name after refresh is {0}, ContactTitle is {1}.{2}", _
      cust.ContactName, cust.ContactTitle, vbCrLf)

    '  I need to reset the changed values so that the code can be run
    '  more than once.
    Console.WriteLine("{0}Resetting data to original values.", vbCrLf)
    ExecuteStatementInDb(String.Format( _
      "update Customers set ContactName = 'Howard Snyder' where CustomerID = 'GREAL'"))

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_34()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim custs As IEnumerable(Of Customer) = ( _
      From c In db.Customers _
      Where c.Region Is "WA" _
      Select c)

    Console.WriteLine("Entity objects before ADO.NET change and Refresh() call:")
    For Each c As Customer In custs
      Console.WriteLine("Customer {0}'s region is {1}, country is {2}.", _
        c.CustomerID, c.Region, c.Country)
    Next c

    Console.WriteLine( _
      "{0}Updating customers' country to United States in ADO.NET...", vbCrLf)
    ExecuteStatementInDb( _
      "update Customers set Country = 'United States' where Region = 'WA'")
    Console.WriteLine("Customers' country updated.{0}", vbCrLf)

    Console.WriteLine("Entity objects after ADO.NET change but before Refresh() call:")
    For Each c As Customer In custs
      Console.WriteLine("Customer {0}'s region is {1}, country is {2}.", _
        c.CustomerID, c.Region, c.Country)
    Next c

    Dim custArray() As Customer = custs.ToArray()
    Console.WriteLine( _
      "{0}Refreshing params array of customer entity objects ...", vbCrLf)
    db.Refresh(RefreshMode.KeepChanges, custArray(0), custArray(1), custArray(2))
    Console.WriteLine("Params array of Customer entity objects refreshed.{0}", vbCrLf)

    Console.WriteLine("Entity objects after ADO.NET change and Refresh() call:")
    For Each c As Customer In custs
      Console.WriteLine("Customer {0}'s region is {1}, country is {2}.", _
        c.CustomerID, c.Region, c.Country)
    Next c

    '  We need to reset the changed values so that the code can be run
    '  more than once.
    Console.WriteLine("{0}Resetting data to original values.", vbCrLf)
    ExecuteStatementInDb( _
      "update Customers set Country = 'USA' where Region = 'WA'")

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_35()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;")

    Dim custs As IEnumerable(Of Customer) = ( _
      From c In db.Customers _
      Where c.Region Is "WA" _
      Select c)

    Console.WriteLine("Entity objects before ADO.NET change and Refresh() call:")
    For Each c As Customer In custs
      Console.WriteLine("Customer {0}'s region is {1}, country is {2}.", _
        c.CustomerID, c.Region, c.Country)
    Next c

    Console.WriteLine( _
      "{0}Updating customers' country to United States in ADO.NET...", vbCrLf)
    ExecuteStatementInDb( _
      "update Customers set Country = 'United States' where Region = 'WA'")
    Console.WriteLine("Customers' country updated.{0}", vbCrLf)

    Console.WriteLine("Entity objects after ADO.NET change but before Refresh() call:")
    For Each c As Customer In custs
      Console.WriteLine("Customer {0}'s region is {1}, country is {2}.", _
        c.CustomerID, c.Region, c.Country)
    Next c

    Console.WriteLine("{0}Refreshing sequence of customer entity objects ...", vbCrLf)
    db.Refresh(RefreshMode.KeepChanges, custs)
    Console.WriteLine("Sequence of Customer entity objects refreshed.{0}", vbCrLf)

    Console.WriteLine("Entity objects after ADO.NET change and Refresh() call:")
    For Each c As Customer In custs
      Console.WriteLine("Customer {0}'s region is {1}, country is {2}.", _
        c.CustomerID, c.Region, c.Country)
    Next c

    '  We need to reset the changed values so that the code can be run
    '  more than once.
    Console.WriteLine("{0}Resetting data to original values.", vbCrLf)
    ExecuteStatementInDb( _
      "update Customers set Country = 'USA' where Region = 'WA'")

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing16_()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)


    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  'Private Shared Sub ExecuteStatementInDb(ByVal cmd As String)
  Private Sub ExecuteStatementInDb(ByVal cmd As String)
    Dim connection As String = _
      "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" & _
      "Integrated Security=SSPI;"

    Using sqlConn As New System.Data.SqlClient.SqlConnection(connection)

      Using sqlComm As New System.Data.SqlClient.SqlCommand(cmd)

        sqlComm.Connection = sqlConn
        sqlConn.Open()
        Console.WriteLine( _
          "Executing SQL statement against database with ADO.NET ...")
        sqlComm.ExecuteNonQuery()
        Console.WriteLine("Database updated.")
      End Using
    End Using
  End Sub

  Private Function GetStringFromDb( _
    ByVal sqlConnection As System.Data.SqlClient.SqlConnection, _
    ByVal sqlQuery As String) As String
    If sqlConnection.State <> System.Data.ConnectionState.Open Then
      sqlConnection.Open()
    End If
    Dim result As String = Nothing

    Using sqlCommand As New System.Data.SqlClient.SqlCommand(sqlQuery, sqlConnection)
      Using sqlDataReader As System.Data.SqlClient.SqlDataReader = _
          sqlCommand.ExecuteReader()

        If (Not sqlDataReader.Read()) Then
          Throw (New Exception(String.Format( _
            "Unexpected exception executing query [{0}].", sqlQuery)))
        Else
          If (Not sqlDataReader.IsDBNull(0)) Then
            result = sqlDataReader.GetString(0)
          End If
        End If

      End Using
    End Using

    Return (result)
  End Function

End Module

Namespace Linqdev
  Partial Public Class Customer
    Private _CustomerID As String
    Private _CompanyName As String
    Private _ContactName As String
    Private _ContactTitle As String
    Private _Address As String
    Private _City As String
    Private _Region As String
    Private _PostalCode As String
    Private _Country As String
    Private _Phone As String
    Private _Fax As String

    Public Sub New()
    End Sub

    Public Property CustomerID() As String
      Get
        Return Me._CustomerID
      End Get
      Set(ByVal value As String)
        If (Me._CustomerID <> value) Then
          Me._CustomerID = value
        End If
      End Set
    End Property

    Public Property CompanyName() As String
      Get
        Return Me._CompanyName
      End Get
      Set(ByVal value As String)
        If (Me._CompanyName <> value) Then
          Me._CompanyName = value
        End If
      End Set
    End Property

    Public Property ContactName() As String
      Get
        Return Me._ContactName
      End Get
      Set(ByVal value As String)
        If (Me._ContactName <> value) Then
          Me._ContactName = value
        End If
      End Set
    End Property

    Public Property ContactTitle() As String
      Get
        Return Me._ContactTitle
      End Get
      Set(ByVal value As String)
        If (Me._ContactTitle <> value) Then
          Me._ContactTitle = value
        End If
      End Set
    End Property

    Public Property Address() As String
      Get
        Return Me._Address
      End Get
      Set(ByVal value As String)
        If (Me._Address <> value) Then
          Me._Address = value
        End If
      End Set
    End Property

    Public Property City() As String
      Get
        Return Me._City
      End Get
      Set(ByVal value As String)
        If (Me._City <> value) Then
          Me._City = value
        End If
      End Set
    End Property

    Public Property Region() As String
      Get
        Return Me._Region
      End Get
      Set(ByVal value As String)
        If (Me._Region <> value) Then
          Me._Region = value
        End If
      End Set
    End Property

    Public Property PostalCode() As String
      Get
        Return Me._PostalCode
      End Get
      Set(ByVal value As String)
        If (Me._PostalCode <> value) Then
          Me._PostalCode = value
        End If
      End Set
    End Property

    Public Property Country() As String
      Get
        Return Me._Country
      End Get
      Set(ByVal value As String)
        If (Me._Country <> value) Then
          Me._Country = value
        End If
      End Set
    End Property

    Public Property Phone() As String
      Get
        Return Me._Phone
      End Get
      Set(ByVal value As String)
        If (Me._Phone <> value) Then
          Me._Phone = value
        End If
      End Set
    End Property

    Public Property Fax() As String
      Get
        Return Me._Fax
      End Get
      Set(ByVal value As String)
        If (Me._Fax <> value) Then
          Me._Fax = value
        End If
      End Set
    End Property
  End Class
End Namespace
