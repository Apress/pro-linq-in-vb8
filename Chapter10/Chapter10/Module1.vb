Module Module1

  Sub Main()
    ' Uncomment the functions you want to call.
    'YourTest()

    'Listing10_1()
    'Listing10_2()
    'Listing10_3()
    'Listing10_4()
    'Listing10_5()
    'Listing10_6()
    'Listing10_7()
    'Listing10_8()
    'Listing10_9()
    'Listing10_10()
    'Listing10_11()
    'Listing10_12()
    'Listing10_13()
    'Listing10_14()
    'Listing10_15()
    'Listing10_16()
    'Listing10_17()
    'Listing10_18()
    'Listing10_19()
    'Listing10_20()

  End Sub

  Sub YourTest()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    ' Do whatever you want in here.

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing10_1()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim students() As Student = { _
      New Student With {.Id = 1, .Name = "Dennis Hayes"}, _
      New Student With {.Id = 6, .Name = "Ulyses Hutchens"}, _
      New Student With {.Id = 19, .Name = "Bob Tanko"}, _
      New Student With {.Id = 45, .Name = "Erin Doutensal"}, _
      New Student With {.Id = 1, .Name = "Dennis Hayes"}, _
      New Student With {.Id = 12, .Name = "Bob Mapplethorpe"}, _
      New Student With {.Id = 17, .Name = "Anthony Adams"}, _
      New Student With {.Id = 32, .Name = "Dignan Stephens"}}

    Dim dt As DataTable = GetDataTable(students)

    Console.WriteLine("{0}Before calling Distinct(){0}", System.Environment.NewLine)

    OutputDataTableHeader(dt, 15)

    For Each dataRow As DataRow In dt.Rows
      Console.WriteLine( _
        "{0,-15}{1,-15}", _
        dataRow.Field(Of Integer)(0), _
        dataRow.Field(Of String)(1))
    Next dataRow

    Dim distinct As IEnumerable(Of DataRow) = _
      dt.AsEnumerable().Distinct(DataRowComparer.Default)

    Console.WriteLine( _
      "{0}After calling Distinct(){0}", System.Environment.NewLine)

    OutputDataTableHeader(dt, 15)

    For Each dataRow As DataRow In distinct
      Console.WriteLine( _
        "{0,-15}{1,-15}", _
        dataRow.Field(Of Integer)(0), _
        dataRow.Field(Of String)(1))
    Next dataRow

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing10_2()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim students() As Student = { _
      New Student With {.Id = 1, .Name = "Dennis Hayes"}, _
      New Student With {.Id = 6, .Name = "Ulyses Hutchens"}, _
      New Student With {.Id = 19, .Name = "Bob Tanko"}, _
      New Student With {.Id = 45, .Name = "Erin Doutensal"}, _
      New Student With {.Id = 1, .Name = "Dennis Hayes"}, _
      New Student With {.Id = 12, .Name = "Bob Mapplethorpe"}, _
      New Student With {.Id = 17, .Name = "Anthony Adams"}, _
      New Student With {.Id = 32, .Name = "Dignan Stephens"}}

    Dim dt As DataTable = GetDataTable(students)

    Console.WriteLine("{0}Before calling Distinct(){0}", System.Environment.NewLine)

    OutputDataTableHeader(dt, 15)

    For Each dataRow As DataRow In dt.Rows
      Console.WriteLine( _
        "{0,-15}{1,-15}", _
        dataRow.Field(Of Integer)(0), _
        dataRow.Field(Of String)(1))
    Next dataRow

    Dim distinct As IEnumerable(Of DataRow) = dt.AsEnumerable().Distinct()

    Console.WriteLine("{0}After calling Distinct(){0}", System.Environment.NewLine)

    OutputDataTableHeader(dt, 15)

    For Each dataRow As DataRow In distinct
      Console.WriteLine( _
        "{0,-15}{1,-15}", _
        dataRow.Field(Of Integer)(0), _
        dataRow.Field(Of String)(1))
    Next dataRow

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing10_3()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim students() As Student = { _
      New Student With {.Id = 1, .Name = "Dennis Hayes"}, _
      New Student With {.Id = 7, .Name = "Anthony Adams"}, _
      New Student With {.Id = 13, .Name = "Stacy Sinclair"}, _
      New Student With {.Id = 72, .Name = "Dignan Stephens"}}

    Dim students2() As Student = { _
      New Student With {.Id = 5, .Name = "Abe Henry"}, _
      New Student With {.Id = 7, .Name = "Anthony Adams"}, _
      New Student With {.Id = 29, .Name = "Future Man"}, _
      New Student With {.Id = 72, .Name = "Dignan Stephens"}}

    Dim dt1 As DataTable = GetDataTable(students)
    Dim seq1 As IEnumerable(Of DataRow) = dt1.AsEnumerable()
    Dim dt2 As DataTable = GetDataTable(students2)
    Dim seq2 As IEnumerable(Of DataRow) = dt2.AsEnumerable()

    Dim except As IEnumerable(Of DataRow) = _
      seq1.Except(seq2, System.Data.DataRowComparer.Default)

    Console.WriteLine( _
      "{0}Results of Except() with comparer{0}", System.Environment.NewLine)

    OutputDataTableHeader(dt1, 15)

    For Each dataRow As DataRow In except
      Console.WriteLine( _
        "{0,-15}{1,-15}", _
        dataRow.Field(Of Integer)(0), _
        dataRow.Field(Of String)(1))
    Next dataRow

    except = seq1.Except(seq2)

    Console.WriteLine( _
      "{0}Results of Except() without comparer{0}", _
      System.Environment.NewLine)

    OutputDataTableHeader(dt1, 15)

    For Each dataRow As DataRow In except
      Console.WriteLine( _
        "{0,-15}{1,-15}", _
        dataRow.Field(Of Integer)(0), _
        dataRow.Field(Of String)(1))
    Next dataRow

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing10_4()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim students() As Student = { _
      New Student With {.Id = 1, .Name = "Dennis Hayes"}, _
      New Student With {.Id = 7, .Name = "Anthony Adams"}, _
      New Student With {.Id = 13, .Name = "Stacy Sinclair"}, _
      New Student With {.Id = 72, .Name = "Dignan Stephens"}}

    Dim students2() As Student = { _
      New Student With {.Id = 5, .Name = "Abe Henry"}, _
      New Student With {.Id = 7, .Name = "Anthony Adams"}, _
      New Student With {.Id = 29, .Name = "Future Man"}, _
      New Student With {.Id = 72, .Name = "Dignan Stephens"}}

    Dim dt1 As DataTable = GetDataTable(students)
    Dim seq1 As IEnumerable(Of DataRow) = dt1.AsEnumerable()
    Dim dt2 As DataTable = GetDataTable(students2)
    Dim seq2 As IEnumerable(Of DataRow) = dt2.AsEnumerable()

    Dim intersect As IEnumerable(Of DataRow) = _
      seq1.Intersect(seq2, System.Data.DataRowComparer.Default)

    Console.WriteLine( _
      "{0}Results of Intersect() with comparer{0}", _
      System.Environment.NewLine)

    OutputDataTableHeader(dt1, 15)

    For Each dataRow As DataRow In intersect
      Console.WriteLine( _
        "{0,-15}{1,-15}", _
        dataRow.Field(Of Integer)(0), _
        dataRow.Field(Of String)(1))
    Next dataRow

    intersect = seq1.Intersect(seq2)

    Console.WriteLine( _
      "{0}Results of Intersect() without comparer{0}", _
      System.Environment.NewLine)

    OutputDataTableHeader(dt1, 15)

    For Each dataRow As DataRow In intersect
      Console.WriteLine( _
        "{0,-15}{1,-15}", _
        dataRow.Field(Of Integer)(0), _
        dataRow.Field(Of String)(1))
    Next dataRow

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing10_5()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim students() As Student = { _
      New Student With {.Id = 1, .Name = "Dennis Hayes"}, _
      New Student With {.Id = 7, .Name = "Anthony Adams"}, _
      New Student With {.Id = 13, .Name = "Stacy Sinclair"}, _
      New Student With {.Id = 72, .Name = "Dignan Stephens"}}

    Dim students2() As Student = { _
      New Student With {.Id = 5, .Name = "Abe Henry"}, _
      New Student With {.Id = 7, .Name = "Anthony Adams"}, _
      New Student With {.Id = 29, .Name = "Future Man"}, _
      New Student With {.Id = 72, .Name = "Dignan Stephens"}}

    Dim dt1 As DataTable = GetDataTable(students)
    Dim seq1 As IEnumerable(Of DataRow) = dt1.AsEnumerable()
    Dim dt2 As DataTable = GetDataTable(students2)
    Dim seq2 As IEnumerable(Of DataRow) = dt2.AsEnumerable()

    Dim union As IEnumerable(Of DataRow) = _
      seq1.Union(seq2, System.Data.DataRowComparer.Default)

    Console.WriteLine( _
      "{0}Results of Union() with comparer{0}", _
      System.Environment.NewLine)

    OutputDataTableHeader(dt1, 15)

    For Each dataRow As DataRow In union
      Console.WriteLine( _
        "{0,-15}{1,-15}", _
        dataRow.Field(Of Integer)(0), _
        dataRow.Field(Of String)(1))
    Next dataRow

    union = seq1.Union(seq2)

    Console.WriteLine( _
      "{0}Results of Union() without comparer{0}", _
      System.Environment.NewLine)

    OutputDataTableHeader(dt1, 15)

    For Each dataRow As DataRow In union
      Console.WriteLine( _
        "{0,-15}{1,-15}", _
        dataRow.Field(Of Integer)(0), _
        dataRow.Field(Of String)(1))
    Next dataRow

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing10_6()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim students() As Student = { _
      New Student With {.Id = 1, .Name = "Dennis Hayes"}, _
      New Student With {.Id = 7, .Name = "Anthony Adams"}, _
      New Student With {.Id = 13, .Name = "Stacy Sinclair"}, _
      New Student With {.Id = 72, .Name = "Dignan Stephens"}}

    Dim dt1 As DataTable = GetDataTable(students)
    Dim seq1 As IEnumerable(Of DataRow) = dt1.AsEnumerable()
    Dim dt2 As DataTable = GetDataTable(students)
    Dim seq2 As IEnumerable(Of DataRow) = dt2.AsEnumerable()

    Dim equal As Boolean = _
      seq1.SequenceEqual(seq2, System.Data.DataRowComparer.Default)
    Console.WriteLine("SequenceEqual() with comparer : {0}", equal)

    equal = seq1.SequenceEqual(seq2)
    Console.WriteLine("SequenceEqual() without comparer : {0}", equal)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing10_7()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Console.WriteLine("(3 = 3) is {0}.", (3 = 3))

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing10_8()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    'Console.WriteLine("((Object)3 == (Object)3) is {0}.", ((Object)3 == (Object)3))
    'Console.WriteLine("((Object)3 == (Object)3) is {0}.", (CType(3, Object) = CType(3, Object)))
    'Console.WriteLine( _
    '  "((Object)3 = (Object)3) is {0}.", _
    '  (CType(3, Object) = CType(3, Object)))


    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing10_9()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    'Console.WriteLine("((Object)3 == (Object)3) is {0}.", ((Object)3 == (Object)3))
    'Console.WriteLine("((Object)3 == (Object)3) is {0}.", (CType(3, Object) = CType(3, Object)))
    'Console.WriteLine( _
    '  "((Object)3 = (Object)3) is {0}.", _
    '  (CType(3, Object) = CType(3, Object)))
    Console.WriteLine( _
      "((Object)3 Is (Object)3) is {0}.", _
      (CType(3, Object) Is CType(3, Object)))

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing10_10()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim students() As Student = { _
      New Student With {.Id = 1, .Name = "Dennis Hayes"}, _
      New Student With {.Id = 7, .Name = "Anthony Adams"}, _
      New Student With {.Id = 13, .Name = "Stacy Sinclair"}, _
      New Student With {.Id = 72, .Name = "Dignan Stephens"}}

    Dim classDesignations() As StudentClass = { _
      New StudentClass With {.Id = 1, .ClassYear = "Sophmore"}, _
      New StudentClass With {.Id = 7, .ClassYear = "Freshman"}, _
      New StudentClass With {.Id = 13, .ClassYear = "Graduate"}, _
      New StudentClass With {.Id = 72, .ClassYear = "Senior"}}

    Dim dt1 As DataTable = GetDataTable(students)
    Dim seq1 As IEnumerable(Of DataRow) = dt1.AsEnumerable()
    Dim dt2 As DataTable = GetDataTable2(classDesignations)
    Dim seq2 As IEnumerable(Of DataRow) = dt2.AsEnumerable()

    Dim anthonysClass As String = ( _
      From s In seq1 _
      Where s.Field(Of String)("Name") = "Anthony Adams" _
      From c In seq2 _
      Where c("Id") Is s("Id") _
      Select CStr(c("ClassYear"))).SingleOrDefault()
    'Where c("Id") = s("Id") _
    'Where c("Id") Is s("Id") _

    Console.WriteLine("Anthony's Class is: {0}", _
      If(anthonysClass IsNot Nothing, anthonysClass, "Nothing"))

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing10_11()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim students() As Student = { _
      New Student With {.Id = 1, .Name = "Dennis Hayes"}, _
      New Student With {.Id = 7, .Name = "Anthony Adams"}, _
      New Student With {.Id = 13, .Name = "Stacy Sinclair"}, _
      New Student With {.Id = 72, .Name = "Dignan Stephens"}}

    Dim classDesignations() As StudentClass = { _
      New StudentClass With {.Id = 1, .ClassYear = "Sophmore"}, _
      New StudentClass With {.Id = 7, .ClassYear = "Freshman"}, _
      New StudentClass With {.Id = 13, .ClassYear = "Graduate"}, _
      New StudentClass With {.Id = 72, .ClassYear = "Senior"}}

    Dim dt1 As DataTable = GetDataTable(students)
    Dim seq1 As IEnumerable(Of DataRow) = dt1.AsEnumerable()
    Dim dt2 As DataTable = GetDataTable2(classDesignations)
    Dim seq2 As IEnumerable(Of DataRow) = dt2.AsEnumerable()

    Dim anthonysClass As String = CStr(( _
        From s In seq1 _
        Where s.Field(Of String)("Name") = "Anthony Adams" _
        From c In seq2 _
        Where (CInt(c("Id")) = CInt(s("Id"))) _
        Select c("ClassYear")).SingleOrDefault())
    'Where(CInt(c("Id")) = CInt(s("Id"))) _
    'Where CInt(c("Id")) Is CInt(s("Id")) _

    Console.WriteLine( _
        "Anthony's Class is: {0}", _
        If(anthonysClass IsNot Nothing, anthonysClass, "null"))

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing10_12()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim students() As Student = { _
      New Student With {.Id = 1, .Name = "Dennis Hayes"}, _
      New Student With {.Id = 7, .Name = "Anthony Adams"}, _
      New Student With {.Id = 13, .Name = "Stacy Sinclair"}, _
      New Student With {.Id = 72, .Name = "Dignan Stephens"}}

    Dim classDesignations() As StudentClass = { _
      New StudentClass With {.Id = 1, .ClassYear = "Sophmore"}, _
      New StudentClass With {.Id = 7, .ClassYear = "Freshman"}, _
      New StudentClass With {.Id = 13, .ClassYear = "Graduate"}, _
      New StudentClass With {.Id = 72, .ClassYear = "Senior"}}

    Dim dt1 As DataTable = GetDataTable(students)
    Dim seq1 As IEnumerable(Of DataRow) = dt1.AsEnumerable()
    Dim dt2 As DataTable = GetDataTable2(classDesignations)
    Dim seq2 As IEnumerable(Of DataRow) = dt2.AsEnumerable()

    Dim anthonysClass As String = ( _
      From s In seq1 _
      Where s.Field(Of String)("Name") = "Anthony Adams" _
      From c In seq2 _
      Where c.Field(Of Integer)("Id") = s.Field(Of Integer)("Id") _
      Select CStr(c("ClassYear"))).SingleOrDefault()

    Console.WriteLine("Anthony's Class is: {0}", If(anthonysClass IsNot Nothing, anthonysClass, "null"))

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing10_13()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim students() As Student = { _
      New Student With {.Id = 1, .Name = "Dennis Hayes"}, _
      New Student With {.Id = 7, .Name = "Anthony Adams"}, _
      New Student With {.Id = 13, .Name = "Stacy Sinclair"}, _
      New Student With {.Id = 72, .Name = "Dignan Stephens"}}

    Dim dt1 As DataTable = GetDataTable(students)
    Dim seq1 As IEnumerable(Of DataRow) = dt1.AsEnumerable()

    Dim id As Integer

    '  Using declaration 1.
    id = ( _
      From s In seq1 _
      Where s.Field(Of String)("Name") = "Anthony Adams" _
      Select s.Field(Of Integer)(dt1.Columns(0), DataRowVersion.Current)).Single()
    Console.WriteLine("Anthony's Id retrieved with declaration 1 is: {0}", id)

    '  Using declaration 2.
    id = ( _
      From s In seq1 _
      Where s.Field(Of String)("Name") = "Anthony Adams" _
      Select s.Field(Of Integer)("Id", DataRowVersion.Current)).Single()
    Console.WriteLine("Anthony's Id retrieved with declaration 2 is: {0}", id)

    '  Using declaration 3.
    id = ( _
      From s In seq1 _
      Where s.Field(Of String)("Name") = "Anthony Adams" _
      Select s.Field(Of Integer)(0, DataRowVersion.Current)).Single()
    Console.WriteLine("Anthony's Id retrieved with declaration 3 is: {0}", id)

    '  Using declaration 4.
    id = ( _
      From s In seq1 _
      Where s.Field(Of String)("Name") = "Anthony Adams" _
      Select s.Field(Of Integer)(dt1.Columns(0))).Single()
    Console.WriteLine("Anthony's Id retrieved with declaration 4 is: {0}", id)

    '  Using declaration 5.
    id = ( _
      From s In seq1 _
      Where s.Field(Of String)("Name") = "Anthony Adams" _
      Select s.Field(Of Integer)("Id")).Single()
    Console.WriteLine("Anthony's Id retrieved with declaration 5 is: {0}", id)

    '  Using declaration 6.
    id = ( _
      From s In seq1 _
      Where s.Field(Of String)("Name") = "Anthony Adams" _
      Select s.Field(Of Integer)(0)).Single()
    Console.WriteLine("Anthony's Id retrieved with declaration 6 is: {0}", id)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing10_14()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim students() As Student = { _
      New Student With {.Id = 1, .Name = "Dennis Hayes"}, _
      New Student With {.Id = 7, .Name = "Anthony Adams"}, _
      New Student With {.Id = 13, .Name = "Stacy Sinclair"}, _
      New Student With {.Id = 72, .Name = "Dignan Stephens"}}

    Dim dt1 As DataTable = GetDataTable(students)
    Dim seq1 As IEnumerable(Of DataRow) = dt1.AsEnumerable()

    Dim row As DataRow = ( _
      From s In seq1 _
        Where s.Field(Of String)("Name") = "Anthony Adams" _
        Select s).Single()

    row.AcceptChanges()
    row.SetField("Name", "George Oscar Bluth")

    Console.WriteLine( _
      "Original value = {0} : Current value = {1}", _
      row.Field(Of String)("Name", DataRowVersion.Original), _
      row.Field(Of String)("Name", DataRowVersion.Current))

    row.AcceptChanges()
    Console.WriteLine( _
      "Original value = {0} : Current value = {1}", _
      row.Field(Of String)("Name", DataRowVersion.Original), _
      row.Field(Of String)("Name", DataRowVersion.Current))

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing10_15()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim students() As Student = { _
      New Student With {.Id = 1, .Name = "Dennis Hayes"}, _
      New Student With {.Id = 7, .Name = Nothing}, _
      New Student With {.Id = 13, .Name = "Stacy Sinclair"}, _
      New Student With {.Id = 72, .Name = "Dignan Stephens"}}

    Dim dt1 As DataTable = GetDataTable(students)
    Dim seq1 As IEnumerable(Of DataRow) = dt1.AsEnumerable()

    Dim name As String = seq1.Where( _
      Function(student) student.Field(Of Integer)("Id") = 7) _
        .Select(Function(student) CStr(student("Name"))).Single()

    Console.WriteLine("Student's name is '{0}'", name)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing10_16()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim students() As Student = { _
      New Student With {.Id = 1, .Name = "Dennis Hayes"}, _
      New Student With {.Id = 7, .Name = Nothing}, _
      New Student With {.Id = 13, .Name = "Stacy Sinclair"}, _
      New Student With {.Id = 72, .Name = "Dignan Stephens"}}

    Dim dt1 As DataTable = GetDataTable(students)
    Dim seq1 As IEnumerable(Of DataRow) = dt1.AsEnumerable()

    Dim name As String = seq1.Where( _
      Function(student) student.Field(Of Integer)("Id") = 7) _
        .Select(Function(student) student.Field(Of String)("Name")).Single()

    Console.WriteLine("Student's name is '{0}'", name)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing10_17()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim students() As Student = { _
      New Student With {.Id = 1, .Name = "Dennis Hayes"}, _
      New Student With {.Id = 7, .Name = "Anthony Adams"}, _
      New Student With {.Id = 13, .Name = "Stacy Sinclair"}, _
      New Student With {.Id = 72, .Name = "Dignan Stephens"}}

    Dim dt1 As DataTable = GetDataTable(students)
    Dim seq1 As IEnumerable(Of DataRow) = dt1.AsEnumerable()

    Console.WriteLine( _
      "{0}Results before calling any declaration:", vbCrLf)

    For Each dataRow As DataRow In seq1
      Console.WriteLine("Student Id = {0} is {1}", _
        dataRow.Field(Of Integer)("Id"), _
        dataRow.Field(Of String)("Name"))
    Next dataRow

    Dim MyRow As DataRow

    '  Using declaration 1.
    MyRow = (From s In seq1 Where s.Field(Of String)("Name") = "Anthony Adams" _
      Select s).Single()
    MyRow.SetField(dt1.Columns(1), "George Oscar Bluth")

    Console.WriteLine("{0}Results after calling declaration 1:", vbCrLf)

    For Each dataRow As DataRow In seq1
      Console.WriteLine("Student Id = {0} is {1}", dataRow.Field(Of Integer)("Id"), _
        dataRow.Field(Of String)("Name"))
    Next dataRow

    '  Using declaration 2.
    MyRow = ( _
      From s In seq1 Where s.Field(Of String)("Name") = "George Oscar Bluth" _
        Select s).Single()
    MyRow.SetField("Name", "Michael Bluth")

    Console.WriteLine("{0}Results after calling declaration 2:", vbCrLf)

    For Each dataRow As DataRow In seq1
      Console.WriteLine("Student Id = {0} is {1}", dataRow.Field(Of Integer)("Id"), _
        dataRow.Field(Of String)("Name"))
    Next dataRow

    '  Using declaration 3.
    MyRow = (From s In seq1 Where s.Field(Of String)("Name") = "Michael Bluth" _
      Select s).Single()
    MyRow.SetField(1, "Tony Wonder")

    Console.WriteLine("{0}Results after calling declaration 3:", vbCrLf)

    For Each dataRow As DataRow In seq1
      Console.WriteLine("Student Id = {0} is {1}", dataRow.Field(Of Integer)("Id"), _
        dataRow.Field(Of String)("Name"))
    Next dataRow

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing10_18()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim students() As Student = { _
      New Student With {.Id = 1, .Name = "Dennis Hayes"}, _
      New Student With {.Id = 7, .Name = "Anthony Adams"}, _
      New Student With {.Id = 13, .Name = "Stacy Sinclair"}, _
      New Student With {.Id = 72, .Name = "Dignan Stephens"}}

    Dim dt1 As DataTable = GetDataTable(students)

    Console.WriteLine("Original DataTable:")
    For Each dataRow As DataRow In dt1.AsEnumerable()
      Console.WriteLine( _
      "Student Id = {0} is {1}", _
      dataRow.Field(Of Integer)("Id"), _
      dataRow.Field(Of String)("Name"))
    Next dataRow

    Dim MyRow As DataRow
    MyRow = ( _
      From s In dt1.AsEnumerable() _
        Where s.Field(Of String)("Name") = "Anthony Adams" _
        Select s).Single()

    MyRow.SetField("Name", "George Oscar Bluth")

    Dim newTable As DataTable = dt1.AsEnumerable().CopyToDataTable()

    Console.WriteLine("{0}New DataTable:", System.Environment.NewLine)
    For Each dataRow As DataRow In newTable.AsEnumerable()
      Console.WriteLine( _
      "Student Id = {0} is {1}", _
      dataRow.Field(Of Integer)("Id"), _
      dataRow.Field(Of String)("Name"))
    Next dataRow

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing10_19()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim students() As Student = { _
      New Student With {.Id = 1, .Name = "Dennis Hayes"}, _
      New Student With {.Id = 7, .Name = "Anthony Adams"}, _
      New Student With {.Id = 13, .Name = "Stacy Sinclair"}, _
      New Student With {.Id = 72, .Name = "Dignan Stephens"}}

    Dim dt1 As DataTable = GetDataTable(students)
    Dim newTable As DataTable = dt1.AsEnumerable().CopyToDataTable()

    Console.WriteLine("Before upserting DataTable:")
    For Each dataRow As DataRow In newTable.AsEnumerable()
      Console.WriteLine( _
        "Student Id = {0} : original {1} : current {2}", _
        dataRow.Field(Of Integer)("Id"), _
        dataRow.Field(Of String)("Name", DataRowVersion.Original), _
        dataRow.Field(Of String)("Name", DataRowVersion.Current))
    Next dataRow

    Dim MyRow As DataRow

    MyRow = (From s In dt1.AsEnumerable() _
      Where s.Field(Of String)("Name") = "Anthony Adams" Select s).Single()
    MyRow.SetField("Name", "George Oscar Bluth")

    dt1.AsEnumerable().CopyToDataTable(newTable, LoadOption.Upsert)

    Console.WriteLine("{0}After upserting DataTable:", System.Environment.NewLine)
    For Each dataRow As DataRow In newTable.AsEnumerable()
      Console.WriteLine( _
        "Student Id = {0} : original {1} : current {2}", _
        dataRow.Field(Of Integer)("Id"), _
        If(dataRow.HasVersion(DataRowVersion.Original), _
           dataRow.Field(Of String) _
             ("Name", DataRowVersion.Original), _
           "-does not exist-"), _
        dataRow.Field(Of String)("Name", DataRowVersion.Current))
    Next dataRow

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing10_20()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim students() As Student = { _
      New Student With {.Id = 1, .Name = "Dennis Hayes"}, _
      New Student With {.Id = 7, .Name = "Anthony Adams"}, _
      New Student With {.Id = 13, .Name = "Stacy Sinclair"}, _
      New Student With {.Id = 72, .Name = "Dignan Stephens"}}

    Dim dt1 As DataTable = GetDataTable(students)
    Dim newTable As DataTable = dt1.AsEnumerable().CopyToDataTable()
    newTable.PrimaryKey = New DataColumn() {newTable.Columns(0)}

    Console.WriteLine("Before upserting DataTable:")
    For Each dataRow As DataRow In newTable.AsEnumerable()
      Console.WriteLine( _
        "Student Id = {0} : original {1} : current {2}", _
        dataRow.Field(Of Integer)("Id"), _
        dataRow.Field(Of String)("Name", DataRowVersion.Original), _
        dataRow.Field(Of String)("Name", DataRowVersion.Current))
    Next dataRow

    Dim MyRow As DataRow
    MyRow = (From s In dt1.AsEnumerable() _
      Where s.Field(Of String)("Name") = "Anthony Adams" Select s).Single()
    MyRow.SetField("Name", "George Oscar Bluth")

    dt1.AsEnumerable().CopyToDataTable(newTable, LoadOption.Upsert)

    Console.WriteLine("{0}After upserting DataTable:", System.Environment.NewLine)
    For Each dataRow As DataRow In newTable.AsEnumerable()
      Console.WriteLine("Student Id = {0} : original {1} : current {2}", _
        dataRow.Field(Of Integer)("Id"), _
        If(dataRow.HasVersion(DataRowVersion.Original), _
           dataRow.Field(Of String) _
             ("Name", DataRowVersion.Original), _
           "-does not exist-"), _
        dataRow.Field(Of String) _
          ("Name", DataRowVersion.Current))
    Next dataRow

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing10_()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Function GetDataTable(ByVal students() As Student) As DataTable
    Dim table As New DataTable()

    table.Columns.Add("Id", GetType(Int32))
    table.Columns.Add("Name", GetType(String))

    For Each student As Student In students
      table.Rows.Add(student.Id, student.Name)
    Next student

    Return (table)
  End Function

  Sub OutputDataTableHeader( _
      ByVal dt As DataTable, _
      ByVal columnWidth As Integer)
    Dim format As String = String.Format("{0}0,-{1}{2}", "{", columnWidth, "}")

    '  Display the column headings.
    For Each column As DataColumn In dt.Columns
      Console.Write(format, column.ColumnName)
    Next column
    Console.WriteLine()
    For Each column As DataColumn In dt.Columns
      For i As Integer = 0 To columnWidth - 1
        Console.Write("=")
      Next i
    Next column
    Console.WriteLine()
  End Sub

  Private Function GetDataTable2(ByVal studentClasses() As StudentClass) _
      As DataTable
    Dim table As New DataTable()

    table.Columns.Add("Id", GetType(Integer))
    table.Columns.Add("ClassYear", GetType(String))

    For Each studentClass As StudentClass In studentClasses
      table.Rows.Add(studentClass.Id, studentClass.ClassYear)
    Next studentClass

    Return (table)
  End Function

End Module

Friend Class Student
  Public Id As Integer
  Public Name As String
End Class

Class StudentClass
  Public Id As Integer
  Public ClassYear As String
End Class
