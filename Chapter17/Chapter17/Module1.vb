Imports System.Linq
Imports System.Data.Linq
Imports System.Diagnostics  'For the StackTrace.

Imports Chapter17.nwind

Module Module1

  Sub Main()
    ' Uncomment the functions you want to call.
    'YourTest()

    'Listing17_1()
    'Listing17_2()
    'Listing17_3()
    'Listing17_4()
    'Listing17_5()
    'Listing17_6()

  End Sub

  Sub YourTest()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    ' Do whatever you want in here.

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing17_1()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind( _
      "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;")
    db.Log = Console.Out

    Dim cust As Customer = _
      db.Customers.Where(Function(c) c.CustomerID = "LONEP").SingleOrDefault()
    If cust IsNot Nothing Then
      Dim name As String = cust.ContactName ' to restore later.
      cust.ContactName = "Neo Anderson"
      db.SubmitChanges()

      '  Restore database.
      cust.ContactName = name
      db.SubmitChanges()
    End If

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing17_2()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind( _
      "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;")

    Dim cust As Customer = _
      db.Customers.Where(Function(c) c.CustomerID = "LAZYK").SingleOrDefault()

    ExecuteStatementInDb(String.Format("update Customers" & vbNewLine & _
      "set ContactName = 'Samuel Arthur Sanders' " & vbNewLine & _
      "where CustomerID = 'LAZYK'"))

    cust.ContactTitle = "President"
    Try
      db.SubmitChanges(ConflictMode.ContinueOnConflict)
    Catch e1 As ChangeConflictException
      db.ChangeConflicts.ResolveAll(RefreshMode.KeepChanges)
      Try
        db.SubmitChanges(ConflictMode.ContinueOnConflict)
        cust = db.Customers.Where(Function(c) c.CustomerID = "LAZYK").SingleOrDefault()
        Console.WriteLine _
          ("ContactName = {0} : ContactTitle = {1}", _
            cust.ContactName, cust.ContactTitle)
      Catch e2 As ChangeConflictException
        Console.WriteLine("Conflict again, aborting.")
      End Try
    End Try

    '  Reset the database.
    ExecuteStatementInDb(String.Format("update Customers " & vbNewLine & _
      "set ContactName = 'John Steel', " & _
      "ContactTitle = 'Marketing Manager' " & vbNewLine & _
      "where CustomerID = 'LAZYK'"))

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

  End Sub

  Sub Listing17_3()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind( _
      "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;")

    Dim cust As Customer = db.Customers.Where(Function(c) c.CustomerID = "LAZYK") _
      .SingleOrDefault()

    ExecuteStatementInDb(String.Format("update Customers" & vbNewLine & _
      "set ContactName = 'Samuel Arthur Sanders' " & vbNewLine & _
      "where CustomerID = 'LAZYK'"))

    cust.ContactTitle = "President"
    Try
      db.SubmitChanges(ConflictMode.ContinueOnConflict)
    Catch e1 As ChangeConflictException
      For Each conflict As ObjectChangeConflict In db.ChangeConflicts
        Console.WriteLine("Conflict occurred in customer {0}.", _
          (CType(conflict.Object, Customer)) _
          .CustomerID)
        Console.WriteLine("Calling Resolve ...")
        conflict.Resolve(RefreshMode.KeepChanges)
        Console.WriteLine("Conflict resolved.{0}", System.Environment.NewLine)
      Next conflict

      Try
        db.SubmitChanges(ConflictMode.ContinueOnConflict)
        cust = db.Customers.Where(Function(c) c.CustomerID = "LAZYK").SingleOrDefault()
        Console.WriteLine("ContactName = {0} : ContactTitle = {1}", cust.ContactName, _
          cust.ContactTitle)
      Catch e2 As ChangeConflictException
        Console.WriteLine("Conflict again, aborting.")
      End Try
    End Try

    '  Reset the database.
    ExecuteStatementInDb(String.Format("update Customers " & vbNewLine & _
      "set ContactName = 'John Steel', ContactTitle = 'Marketing Manager' " & _
      vbNewLine & "where CustomerID = 'LAZYK'"))

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing17_4()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind( _
      "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;")

    Dim cust As Customer = _
      db.Customers.Where(Function(c) c.CustomerID = "LAZYK").SingleOrDefault()

    ExecuteStatementInDb(String.Format("update Customers" & vbNewLine & _
      "set ContactName = 'Samuel Arthur Sanders', " & vbNewLine & _
      "ContactTitle = 'CEO' " & vbNewLine & _
      "where CustomerID = 'LAZYK'"))

    cust.ContactName = "Viola Sanders"
    cust.ContactTitle = "President"
    Try
      db.SubmitChanges(ConflictMode.ContinueOnConflict)
    Catch e1 As ChangeConflictException
      For Each conflict As ObjectChangeConflict In db.ChangeConflicts
        Console.WriteLine("Conflict occurred in customer {0}.", _
          (CType(conflict.Object, Customer)).CustomerID)
        For Each memberConflict As MemberChangeConflict In conflict.MemberConflicts
          Console.WriteLine("Calling Resolve for {0} ...", _
            memberConflict.Member.Name)
          If memberConflict.Member.Name.Equals("ContactName") Then
            memberConflict.Resolve(RefreshMode.OverwriteCurrentValues)
          Else
            memberConflict.Resolve(RefreshMode.KeepChanges)
          End If

          Console.WriteLine("Conflict resolved.{0}", System.Environment.NewLine)
        Next memberConflict
      Next conflict

      Try
        db.SubmitChanges(ConflictMode.ContinueOnConflict)
        cust = db.Customers.Where(Function(c) c.CustomerID = "LAZYK") _
          .SingleOrDefault()
        Console.WriteLine("ContactName = {0} : ContactTitle = {1}", _
          cust.ContactName, cust.ContactTitle)
      Catch e2 As ChangeConflictException
        Console.WriteLine("Conflict again, aborting.")
      End Try
    End Try

    '  Reset the database.
    ExecuteStatementInDb(String.Format("update Customers " & vbNewLine & _
      "set ContactName = 'John Steel'," & _
      "ContactTitle = " & "'Marketing Manager' " & vbNewLine & _
      "where CustomerID = 'LAZYK'"))

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing17_5()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind( _
      "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;")

    Using transaction As New System.Transactions.TransactionScope()
      Dim cust As Customer = db.Customers.Where(Function(c) c.CustomerID = "LAZYK") _
        .SingleOrDefault()

      Try
        Console.WriteLine("Let's try to update LAZYK's ContactName with ADO.NET.")
        Console.WriteLine("  Please be patient, we have to wait for timeout ...")
        Using t2 As New System.Transactions. _
            TransactionScope(System.Transactions. _
            TransactionScopeOption.RequiresNew)
          ExecuteStatementInDb(String.Format("update Customers " & vbNewLine & _
            "set ContactName = 'Samuel Arthur Sanders' " & vbNewLine & _
            "where CustomerID = 'LAZYK'"))

          t2.Complete()
        End Using

        Console.WriteLine( _
          "LAZYK's ContactName updated.{0}", System.Environment.NewLine)
      Catch ex As Exception
        Console.WriteLine( _
          "Exception occurred trying to update LAZYK with ADO.NET:{0}  {1}{0}", _
          vbNewLine, ex.Message)
      End Try

      cust.ContactName = "Viola Sanders"
      db.SubmitChanges()

      cust = db.Customers.Where(Function(c) c.CustomerID = "LAZYK").SingleOrDefault()
      Console.WriteLine("Customer Contact Name: {0}", cust.ContactName)

      transaction.Complete()
    End Using

    '  Reset the database.
    ExecuteStatementInDb(String.Format("update Customers " & vbNewLine & _
      "set ContactName = 'John Steel'," & vbNewLine & _
      "ContactTitle = 'Marketing Manager' " & vbNewLine & _
      "where CustomerID = 'LAZYK'"))

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing17_6()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind( _
      "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;")

    '  Create an entity object.
    Console.WriteLine("Constructing an empty Customer object.")
    Dim cust As New Customer()

    '  First, all fields establishing identity must get set.
    Console.WriteLine("Setting the primary keys.")
    cust.CustomerID = "LAZYK"

    '  Next, every field that will change must be set.
    Console.WriteLine("Setting the fields I will change.")
    cust.ContactName = "John Steel"

    '  Last, all fields participating in update check must be set.  
    '  Unfortunately, for the Customer entity class, that is all of them.
    Console.WriteLine("Setting all fields participating in update check.")
    cust.CompanyName = "Lazy K Kountry Store"
    cust.ContactTitle = "Marketing Manager"
    cust.Address = "12 Orchestra Terrace"
    cust.City = "Walla Walla"
    cust.Region = "WA"
    cust.PostalCode = "99362"
    cust.Country = "USA"
    cust.Phone = "(509) 555-7969"
    cust.Fax = "(509) 555-6221"

    '  Now let's attach to the Customers Table(Of T);
    Console.WriteLine("Attaching to the Customers Table(Of Customer).")
    db.Customers.Attach(cust)

    '  At this point we can make our changes and call SubmitChanges().
    Console.WriteLine("Making my changes and calling SubmitChanges().")
    cust.ContactName = "Vickey Rattz"
    db.SubmitChanges()

    cust = db.Customers.Where(Function(c) c.CustomerID = "LAZYK").SingleOrDefault()
    Console.WriteLine("ContactName in database = {0}", cust.ContactName)

    Console.WriteLine("Restoring changes and calling SubmitChanges().")
    cust.ContactName = "John Steel"
    db.SubmitChanges()

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing17_()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)


    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub


  Sub ExecuteStatementInDb(ByVal cmd As String)
    Dim connection As String = _
        "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;"

    Dim sqlConn As System.Data.SqlClient.SqlConnection = _
        New System.Data.SqlClient.SqlConnection(connection)

    Dim sqlComm As System.Data.SqlClient.SqlCommand = _
        New System.Data.SqlClient.SqlCommand(cmd)

    sqlComm.Connection = sqlConn
    Try
      sqlConn.Open()
      Console.WriteLine("Executing SQL statement against database with ADO.NET ...")
      sqlComm.ExecuteNonQuery()
      Console.WriteLine("Database updated.")
    Finally
      '  Close the connection.
      sqlComm.Connection.Close()
    End Try
  End Sub

End Module
