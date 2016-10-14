Imports Chapter12.nwind

Module Module1

  Sub Main()
    ' Uncomment the functions you want to call.
    'YourTest()

    Listing12_1()

  End Sub

  Sub YourTest()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    ' Do whatever you want in here.

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing12_1()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    '  Create a DataContext.
    Dim db As New Northwind( _
      "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;")

    '  Retrieve customer LAZYK.
    Dim cust As Customer = (From c In db.Customers _
      Where c.CustomerID = "LAZYK" _
      Select c).Single()

    '  Update the contact name.
    cust.ContactName = "Ned Plimpton"

    Try
      '  Save the changes.
      db.SubmitChanges()
      '  Detect concurrency conflicts.
    Catch e1 As ChangeConflictException
      '  Resolve conflicts.
      db.ChangeConflicts.ResolveAll(RefreshMode.KeepChanges)
    End Try

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing12_()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)


    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
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

End Module


