Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq

Module Module1

  Sub Main()
    ' Uncomment the functions you want to call.
    'YourTest()

    'Listing11_1()
    'Listing11_2()
    'Listing11_3()

  End Sub

  Sub YourTest()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    ' Do whatever you want in here.
    Dim connectionString As String = _
        "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;"

    Using dataAdapter As New SqlDataAdapter( _
        "SELECT O.EmployeeID, E.FirstName + ' ' + E.LastName as EmployeeName," & _
        "    O.CustomerID, C.CompanyName, O.ShipCountry" & _
        "    FROM Orders O" & _
        "    JOIN Employees E on O.EmployeeID = E.EmployeeID" & _
        "    JOIN Customers C on O.CustomerID = C.CustomerID", connectionString)

      Dim dataSet As New DataSet()
      dataAdapter.Fill(dataSet, "EmpCustShip")

      '  All code prior to this comment is legacy code.

      Dim ordersQuery = dataSet.Tables("EmpCustShip").AsEnumerable() _
          .Where(Function(r) r.Field(Of String)("ShipCountry").Equals("Germany")) _
          .Distinct(System.Data.DataRowComparer.Default) _
          .OrderBy(Function(r) r.Field(Of String)("EmployeeName")) _
          .ThenBy(Function(r) r.Field(Of String)("CompanyName"))

      For Each dataRow In ordersQuery
        Console.WriteLine( _
            "{0,-20} {1,-20}", dataRow.Field(Of String)("EmployeeName"), _
            dataRow.Field(Of String)("CompanyName"))
      Next dataRow

    End Using

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing11_1()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim studentsDataSet As New StudentsDataSet()
    studentsDataSet.Students.AddStudentsRow(1, "Dennis Hayes")
    studentsDataSet.Students.AddStudentsRow(7, "Ruth Weinstein")
    studentsDataSet.Students.AddStudentsRow(13, "Kerry Ayres")
    studentsDataSet.Students.AddStudentsRow(72, "George McCurdy")

    Dim name As String = _
        studentsDataSet.Students.Where(Function(student) student.Id = 7).Single().Name

    Console.WriteLine(name)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing11_2()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim connectionString As String = _
      "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;"

    Using dataAdapter As New SqlDataAdapter( _
        "SELECT O.EmployeeID, E.FirstName + ' ' + E.LastName as EmployeeName," & _
        "  O.CustomerID, C.CompanyName, O.ShipCountry" & _
        "  FROM Orders O" & _
        "  JOIN Employees E on O.EmployeeID = E.EmployeeID" & _
        "  JOIN Customers C on O.CustomerID = C.CustomerID", connectionString)

      Using dataSet As New DataSet()
        dataAdapter.Fill(dataSet, "EmpCustShip")

        '  All code prior to this comment is legacy code.

        Dim ordersQuery = dataSet.Tables("EmpCustShip").AsEnumerable() _
          .Where(Function(r) r.Field(Of String)("ShipCountry").Equals("Germany")) _
          .Distinct(System.Data.DataRowComparer.Default) _
          .OrderBy(Function(r) r.Field(Of String)("EmployeeName")) _
          .ThenBy(Function(r) r.Field(Of String)("CompanyName"))

        For Each dataRow In ordersQuery
          Console.WriteLine( _
            "{0,-20} {1,-20}", dataRow.Field(Of String)("EmployeeName"), _
            dataRow.Field(Of String)("CompanyName"))
        Next dataRow
      End Using
    End Using


    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing11_3()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim connectionString As String = _
      "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;"

    Using dataAdapter As New SqlDataAdapter( _
        "SELECT O.EmployeeID, E.FirstName + ' ' + E.LastName as EmployeeName, " & _
          "O.CustomerID, C.CompanyName, O.ShipCountry " & _
          "FROM Orders O JOIN Employees E on O.EmployeeID = E.EmployeeID " & _
          "JOIN Customers C on O.CustomerID = C.CustomerID", connectionString)

      Using dataSet As New DataSet()
        dataAdapter.Fill(dataSet, "EmpCustShip")

        '  All code prior to this comment is legacy code.

        Dim ordersQuery = (From r In dataSet.Tables("EmpCustShip").AsEnumerable() _
          Where r.Field(Of String)("ShipCountry").Equals("Germany") _
          Order By r.Field(Of String)("EmployeeName"), _
            r.Field(Of String)("CompanyName") _
          Select r).Distinct(System.Data.DataRowComparer.Default)

        For Each dataRow In ordersQuery
          Console.WriteLine("{0,-20} {1,-20}", _
            dataRow.Field(Of String)("EmployeeName"), _
            dataRow.Field(Of String)("CompanyName"))
        Next dataRow
      End Using
    End Using

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing11_()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub


End Module
