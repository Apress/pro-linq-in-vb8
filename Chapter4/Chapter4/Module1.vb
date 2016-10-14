Imports System.Collections
Imports System.Collections.Generic
Imports System.Data.Linq
Imports System.Linq

Imports Chapter4.nwind


Module Module1

  Sub Main()
    ' Uncomment the functions you want to call.
    'YourTest()

    'Listing4_1()
    'Listing4_2()
    'Listing4_3()
    'Listing4_4()
    'Listing4_5()
    'Listing4_6()
    'Listing4_7()
    'Listing4_8()
    'Listing4_9()
    'Listing4_10()
    'Listing4_11()
    'Listing4_12()
    'Listing4_13()
    'Listing4_14()
    'Listing4_15()
    'Listing4_16()
    'Listing4_17()
    'Listing4_18()
    'Listing4_19()
    'Listing4_20()
    'Listing4_21()
    'Listing4_22()
    'Listing4_23()
    'Listing4_24()
    'Listing4_25()
    'Listing4_26()
    'Listing4_27()
    'Listing4_28()
    'Listing4_29()
    'Listing4_30()
    'Listing4_31()
    'Listing4_32()
    'Listing4_33()
    'Listing4_34()
    'Listing4_35()
    'Listing4_36()
    'Listing4_37()
    'Listing4_38()
    'Listing4_39()
    'Listing4_40()
    'Listing4_41()
    'Listing4_42()
    'Listing4_43()
    'Listing4_44()
    'Listing4_45()
    'Listing4_46()
    'Listing4_47()
    'Listing4_48()
    'Listing4_49()

  End Sub

  Sub YourTest()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    ' Do whatever you want in here.
    'Dim presidents() As String = { _
    '  "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
    '  "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
    '  "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
    '  "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
    '  "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
    '  "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    'Dim nameObjs = presidents.Select(Function(p) New With {Key p, Key p.Length})
    'nameObjs = 1

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_1()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim sequence As IEnumerable(Of String) = _
      presidents.Where(Function(p) p.StartsWith("J"))

    For Each s As String In sequence
      Console.WriteLine("{0}", s)
    Next s

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_2()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim sequence As IEnumerable(Of String) = _
      presidents.Where(Function(p, i) (i And 1) = 1)

    For Each s As String In sequence
      Console.WriteLine("{0}", s)
    Next s

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_3()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim nameLengths As IEnumerable(Of Integer) = _
      presidents.Select(Function(p) p.Length)

    For Each item As Integer In nameLengths
      Console.WriteLine(item)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_4()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim nameObjs = _
      presidents.Select(Function(p) New With {Key p, Key p.Length})

    For Each item In nameObjs
      Console.WriteLine(item)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_5()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim nameObjs = presidents.Select( _
      Function(p) New With {Key .LastName = p, Key .Length = p.Length})

    For Each item In nameObjs
      Console.WriteLine("{0} is {1} characters long.", item.LastName, item.Length)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_6()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim nameObjs = _
      presidents.Select(Function(p, i) New With {Key .Index = i, Key .LastName = p})

    For Each item In nameObjs
      Console.WriteLine("{0}.  {1}", item.Index + 1, item.LastName)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_7()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim chars As IEnumerable(Of Char) = presidents.SelectMany(Function(p) p.ToArray())

    For Each ch As Char In chars
      Console.WriteLine(ch)
    Next ch

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_8()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim employees() As Employee = Employee.GetEmployeesArray()
    Dim empOptions() As EmployeeOptionEntry = _
      EmployeeOptionEntry.GetEmployeeOptionEntries()

    Dim employeeOptions = employees _
      .SelectMany(Function(e) empOptions _
                    .Where(Function(eo) eo.id = e.id) _
                    .Select(Function(eo) New With { _
                                           Key .id = eo.id, _
                                           Key .optionsCount = eo.optionsCount}))

    For Each item In employeeOptions
      Console.WriteLine(item)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_9()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim chars As IEnumerable(Of Char) = _
      presidents.SelectMany(Function(p, i) If(i < 5, p.ToArray(), New Char() {}))

    For Each ch As Char In chars
      Console.WriteLine(ch)
    Next ch

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_10()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim items As IEnumerable(Of String) = _
      From p In presidents _
      Take (5)

    For Each item As String In items
      Console.WriteLine(item)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_11()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim chars As IEnumerable(Of Char) = _
      presidents.Take(5).SelectMany(Function(s) s.ToArray())

    For Each ch As Char In chars
      Console.WriteLine(ch)
    Next ch

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_12()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim items As IEnumerable(Of String) = _
      From p In presidents _
      Take While p.Length < 10

    For Each item As String In items
      Console.WriteLine(item)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_13()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim items As IEnumerable(Of String) = _
      presidents.TakeWhile( _
        Function(s, i) s.Length < 10 AndAlso i < 5)

    For Each item As String In items
      Console.WriteLine(item)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_14()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim items As IEnumerable(Of String) = _
      From p In presidents _
      Skip (1)

    For Each item As String In items
      Console.WriteLine(item)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_15()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim items As IEnumerable(Of String) = _
      From p In presidents _
      Skip While p.StartsWith("A")

    For Each item As String In items
      Console.WriteLine(item)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_16()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim items As IEnumerable(Of String) = _
      presidents.SkipWhile(Function(s, i) s.Length > 4 AndAlso i < 10)

    For Each item As String In items
      Console.WriteLine(item)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_17()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim items As IEnumerable(Of String) = _
      presidents.Take(5).Concat(presidents.Skip(5))

    For Each item As String In items
      Console.WriteLine(item)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_18()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim items = New IEnumerable(Of String)() _
    { _
      presidents.Take(5), _
      presidents.Skip(5) _
    }.SelectMany(Function(s) s)

    For Each item As String In items
      Console.WriteLine(item)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_19()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim items As IEnumerable(Of String) = _
      presidents.OrderBy(Function(s) s.Length)

    For Each item As String In items
      Console.WriteLine(item)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_20()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    '  I am going to instantiate my comparer ahead of time so I can keep a
    '  reference so I can call the GetVowelConsonantCount() method later
    '  for display purposes.
    Dim myComp As New MyVowelToConsonantRatioComparer()

    Dim namesByVToCRatio As IEnumerable(Of String) = _
      presidents.OrderBy((Function(s) s), myComp)

    For Each item As String In namesByVToCRatio
      Dim vCount As Integer = 0
      Dim cCount As Integer = 0

      myComp.GetVowelConsonantCount(item, vCount, cCount)
      Dim dRatio As Double = CDbl(vCount) / CDbl(cCount)

      Console.WriteLine(item & " - " & dRatio & " - " & vCount & ":" & cCount)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_21()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim items As IEnumerable(Of String) = _
      presidents.OrderByDescending(Function(s) s)

    For Each item As String In items
      Console.WriteLine(item)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_22()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    '  I am going to instantiate my comparer ahead of time so I can keep a
    '  reference so I can call the GetVowelConsonantCount() method later
    '  for display purposes.
    Dim myComp As New MyVowelToConsonantRatioComparer()

    Dim namesByVToCRatio As IEnumerable(Of String) = _
      presidents.OrderByDescending((Function(s) s), myComp)

    For Each item As String In namesByVToCRatio
      Dim vCount As Integer = 0
      Dim cCount As Integer = 0

      myComp.GetVowelConsonantCount(item, vCount, cCount)
      Dim dRatio As Double = CDbl(vCount) / CDbl(cCount)

      Console.WriteLine(item & " - " & dRatio & " - " & vCount & ":" & cCount)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_23()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim items As IEnumerable(Of String) = _
      presidents.OrderBy(Function(s) s.Length).ThenBy(Function(s) s)

    For Each item As String In items
      Console.WriteLine(item)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_24()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    '  I am going to instantiate my comparer ahead of time so I can keep a
    '  reference so I can call the GetVowelConsonantCount() method later
    '  for display purposes.
    Dim myComp As New MyVowelToConsonantRatioComparer()

    Dim namesByVToCRatio As IEnumerable(Of String) = _
      presidents.OrderBy(Function(n) n.Length).ThenBy((Function(s) s), myComp)

    For Each item As String In namesByVToCRatio
      Dim vCount As Integer = 0
      Dim cCount As Integer = 0

      myComp.GetVowelConsonantCount(item, vCount, cCount)
      Dim dRatio As Double = CDbl(vCount) / CDbl(cCount)

      Console.WriteLine(item & " - " & dRatio & " - " & vCount & ":" & cCount)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_25()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim items As IEnumerable(Of String) = _
      presidents.OrderBy(Function(s) s.Length).ThenByDescending(Function(s) s)

    For Each item As String In items
      Console.WriteLine(item)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_26()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    '  I am going to instantiate my comparer ahead of time so I can keep a
    '  reference so I can call the GetVowelConsonantCount() method later
    '  for display purposes.
    Dim myComp As New MyVowelToConsonantRatioComparer()

    Dim namesByVToCRatio As IEnumerable(Of String) = _
      presidents.OrderBy(Function(n) n.Length) _
                .ThenByDescending((Function(s) s), myComp)

    For Each item As String In namesByVToCRatio
      Dim vCount As Integer = 0
      Dim cCount As Integer = 0

      myComp.GetVowelConsonantCount(item, vCount, cCount)
      Dim dRatio As Double = CDbl(vCount) / CDbl(cCount)

      Console.WriteLine(item & " - " & dRatio & " - " & vCount & ":" & cCount)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_27()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim items As IEnumerable(Of String) = presidents.Reverse()

    For Each item As String In items
      Console.WriteLine(item)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_28()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim employees() As Employee = Employee.GetEmployeesArray()
    Dim empOptions() As EmployeeOptionEntry = _
      EmployeeOptionEntry.GetEmployeeOptionEntries()

    '  Remember, the first argument of the overload is the outer sequence, which will 
    '  be the sequence we call join on.  In this case, the employees array is the outer
    '  sequence.
    Dim employeeOptions = employees _
      .Join( _
        empOptions, _
        Function(e) e.id, _
        Function(o) o.id, _
        Function(e, o) New With { _
          Key .id = e.id, _
          Key .name = String.Format("{0} {1}", e.firstName, e.lastName), _
          Key .options = o.optionsCount})

    For Each item In employeeOptions
      Console.WriteLine(item)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_29()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim employees() As Employee = Employee.GetEmployeesArray()
    Dim empOptions() As EmployeeOptionEntry = _
      EmployeeOptionEntry.GetEmployeeOptionEntries()

    Dim employeeOptions = employees _
      .GroupJoin( _
        empOptions, _
        Function(e) e.id, _
        Function(o) o.id, _
        Function(e, os) New With { _
          Key .id = e.id, _
          Key .name = String.Format("{0} {1}", e.firstName, e.lastName), _
          Key .options = os.Sum(Function(o) o.optionsCount)})

    For Each item In employeeOptions
      Console.WriteLine(item)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_30()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim empOptions() As EmployeeOptionEntry = _
      EmployeeOptionEntry.GetEmployeeOptionEntries()
    Dim outerSequence As IEnumerable(Of IGrouping(Of Integer, EmployeeOptionEntry)) = _
      empOptions.GroupBy(Function(o) o.id)

    '  First enumerate through the outer sequence of IGroupings.
    For Each keyGroupSequence As IGrouping(Of Integer, EmployeeOptionEntry) _
        In outerSequence
      Console.WriteLine("Option records for employee: " & keyGroupSequence.Key)

      ' Now enumerate through the grouping's sequence of EmployeeOptionEntry elements.
      For Each element As EmployeeOptionEntry In keyGroupSequence
        Console.WriteLine("id={0} : optionsCount={1} : dateAwarded={2:d}", _
                          element.id, element.optionsCount, element.dateAwarded)
      Next element
    Next keyGroupSequence

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_31()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    '  Instead of instantiating the comparer on the fly, I am going
    '  to keep a reference to because I will use its isFounder()
    '  method on the group's key for header display purposes.
    Dim comp As New MyFounderNumberComparer()

    Dim empOptions() As EmployeeOptionEntry = _
      EmployeeOptionEntry.GetEmployeeOptionEntries()

    Dim opts As IEnumerable(Of IGrouping(Of Integer, EmployeeOptionEntry)) = _
      empOptions.GroupBy(Function(o) o.id, comp)

    ' First enumerate through the sequence of IGroupings.
    For Each keyGroup As IGrouping(Of Integer, EmployeeOptionEntry) In opts
      Console.WriteLine( _
        "Option records for: " & _
        (If(comp.isFounder(keyGroup.Key), "founder", "non-founder")))

      ' Now enumerate through the grouping's sequence of EmployeeOptionEntry elements.
      For Each element As EmployeeOptionEntry In keyGroup
        Console.WriteLine( _
          "id={0} : optionsCount={1} : dateAwarded={2:d}", _
          element.id, _
          element.optionsCount, _
          element.dateAwarded)
      Next element
    Next keyGroup

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_32()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim empOptions() As EmployeeOptionEntry = _
      EmployeeOptionEntry.GetEmployeeOptionEntries()
    Dim opts As IEnumerable(Of IGrouping(Of Integer, DateTime)) = _
      empOptions.GroupBy(Function(o) o.id, Function(e) e.dateAwarded)

    '  First enumerate through the sequence of IGroupings.
    For Each keyGroup As IGrouping(Of Integer, DateTime) In opts
      Console.WriteLine("Option records for employee: " & keyGroup.Key)

      '  Now enumerate through the grouping's sequence of DateTime elements.
      For Each [date] As DateTime In keyGroup
        Console.WriteLine([date].ToShortDateString())
      Next [date]
    Next keyGroup

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_33()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    '  Instead of instantiating the comparer on the fly, I am going
    '  to keep a reference to is because I will use its isFounder()
    '  method on the group's key for header display purposes.
    Dim comp As New MyFounderNumberComparer()

    Dim empOptions() As EmployeeOptionEntry = _
      EmployeeOptionEntry.GetEmployeeOptionEntries()
    Dim opts As IEnumerable(Of IGrouping(Of Integer, DateTime)) = _
      empOptions.GroupBy(Function(o) o.id, Function(o) o.dateAwarded, comp)

    '  First enumerate through the sequence of IGroupings.
    For Each keyGroup As IGrouping(Of Integer, DateTime) In opts
      Console.WriteLine("Option records for: " & _
        (If(comp.isFounder(keyGroup.Key), "founder", "non-founder")))

      '  Now enumerate through the grouping's sequence of EmployeeOptionEntry elements.
      For Each [date] As DateTime In keyGroup
        Console.WriteLine([date].ToShortDateString())
      Next [date]
    Next keyGroup

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_34()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    '  Display the count of the presidents array.
    Console.WriteLine("presidents count:  " & presidents.Count())

    '  Concatenate presidents with itself.  Now each element should 
    '  be in the sequence twice.
    Dim presidentsWithDupes As IEnumerable(Of String) = presidents.Concat(presidents)
    '  Display the count of the concatenated sequence.
    Console.WriteLine("presidentsWithDupes count:  " & presidentsWithDupes.Count())

    '  Eliminate the duplicates and display the count.
    ' Note that I use the VB.NET only Distinct query expression syntax here. 
    Dim presidentsDistinct As IEnumerable(Of String) = _
      From p In presidentsWithDupes _
      Distinct

    Console.WriteLine("presidentsDistinct count:  " & presidentsDistinct.Count())

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_35()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim first As IEnumerable(Of String) = presidents.Take(5)
    Dim second As IEnumerable(Of String) = presidents.Skip(4)
    '  Since I only skipped 4 elements, the fifth element 
    '  should be in both sequences.

    Dim concat As IEnumerable(Of String) = first.Concat(second)
    Dim union As IEnumerable(Of String) = first.Union(second)

    Console.WriteLine("The count of the presidents array is: " & presidents.Count())
    Console.WriteLine("The count of the first sequence is: " & first.Count())
    Console.WriteLine("The count of the second sequence is: " & second.Count())
    Console.WriteLine("The count of the concat sequence is: " & concat.Count())
    Console.WriteLine("The count of the union sequence is: " & union.Count())

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_36()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim first As IEnumerable(Of String) = presidents.Take(5)
    Dim second As IEnumerable(Of String) = presidents.Skip(4)
    '  Since I only skipped 4 elements, the fifth element 
    '  should be in both sequences.

    Dim intersect As IEnumerable(Of String) = first.Intersect(second)

    Console.WriteLine("The count of the presidents array is: " & presidents.Count())
    Console.WriteLine("The count of the first sequence is: " & first.Count())
    Console.WriteLine("The count of the second sequence is: " & second.Count())
    Console.WriteLine("The count of the intersect sequence is: " & intersect.Count())

    '  Just for kicks, I will display the intersection sequence,
    '  which should be just the fifth element.
    For Each name As String In intersect
      Console.WriteLine(name)
    Next name

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_37()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    '  First generate a processed sequence.
    Dim processed As IEnumerable(Of String) = presidents.Take(4)

    Dim exceptions As IEnumerable(Of String) = presidents.Except(processed)
    For Each name As String In exceptions
      Console.WriteLine(name)
    Next name

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_38()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim employees As ArrayList = Employee.GetEmployeesArrayList()
    Console.WriteLine("The data type of employees is " & employees.GetType().ToString)

    Dim seq = employees.Cast(Of Employee)()
    Console.WriteLine("The data type of seq is " & seq.GetType().ToString)

    Dim emps = seq.OrderBy(Function(e) e.lastName)
    For Each emp As Employee In emps
      Console.WriteLine("{0} {1}", emp.firstName, emp.lastName)
    Next emp

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_39()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim al As New ArrayList()
    al.Add(New Employee With {.id = 1, .firstName = "Dennis", .lastName = "Hayes"})
    al.Add(New Employee With {.id = 2, .firstName = "William", .lastName = "Gates"})
    al.Add(New EmployeeOptionEntry With {.id = 1, .optionsCount = 0})
    al.Add(New EmployeeOptionEntry With {.id = 2, .optionsCount = 99999999999})
    al.Add(New Employee With {.id = 3, .firstName = "Anders", .lastName = "Hejlsberg"})
    al.Add(New EmployeeOptionEntry With {.id = 3, .optionsCount = 848475745})

    '  First I will demonstrate the Cast Operator's weakness.
    Dim items = al.Cast(Of Employee)()

    Console.WriteLine("Attempting to use the Cast operator ...")
    '  Notice that I am starting the Try after the actual call to the OfType operator.
    '  I can get away with that because the operator is deferred.
    Try
      For Each item As Employee In items
        Console.WriteLine("{0} {1} {2}", item.id, item.firstName, item.lastName)
      Next item
    Catch ex As Exception
      Console.WriteLine("{0}{1}", ex.Message, System.Environment.NewLine)
    End Try

    '  Now let's try using OfType.
    Console.WriteLine("Attempting to use the OfType operator ...")
    Dim items2 = al.OfType(Of Employee)()
    '  I am so confident, I am not even wrapping in a try/catch.
    For Each item As Employee In items2
      Console.WriteLine("{0} {1} {2}", item.id, item.firstName, item.lastName)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_40()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind( _
      "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;")

    Dim custs = ( _
      From c In db.Customers _
      Where c.City = "Rio de Janeiro" _
      Select c).Reverse()

    For Each cust In custs
      Console.WriteLine("{0}", cust.CompanyName)
    Next cust

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_41()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim db As New Northwind( _
      "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;")

    Dim custs = ( _
      From c In db.Customers _
      Where c.City = "Rio de Janeiro" _
      Select c).AsEnumerable().Reverse()

    For Each cust In custs
      Console.WriteLine("{0}", cust.CompanyName)
    Next cust

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_42()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim jones As String = presidents.Where(Function(n) n.Equals("Jones")).First()
    If jones IsNot Nothing Then
      Console.WriteLine("Jones was found")
    Else
      Console.WriteLine("Jones was not found")
    End If

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_43()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim jones As String = _
      presidents.Where(Function(n) n.Equals("Jones")).DefaultIfEmpty().First()

    If jones IsNot Nothing Then
      Console.WriteLine("Jones was found.")
    Else
      Console.WriteLine("Jones was not found.")
    End If

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_44()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim presidents() As String = { _
      "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
      "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
      "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
      "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
      "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
      "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"}

    Dim name As String = presidents _
      .Where(Function(n) n.Equals("Jones")).DefaultIfEmpty("Missing").First()

    Console.WriteLine(name)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_45()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim employeesAL As ArrayList = Employee.GetEmployeesArrayList()

    '  Add a new employee so one employee will have no EmployeeOptionEntry records.
    employeesAL.Add(New Employee With { _
      .id = 102, _
      .firstName = "Michael", _
      .lastName = "Bolton"})

    Dim employees() As Employee = employeesAL.Cast(Of Employee)().ToArray()
    Dim empOptions() As EmployeeOptionEntry = EmployeeOptionEntry.GetEmployeeOptionEntries()

    Dim employeeOptions = employees _
      .GroupJoin( _
        empOptions, _
        Function(e) e.id, _
        Function(o) o.id, _
        Function(e, os) os.Select _
          (Function(o) New With { _
             Key .id = e.id, _
             Key .name = String.Format("{0} {1}", e.firstName, e.lastName), _
             Key .options = If(o IsNot Nothing, o.optionsCount, 0)})) _
      .SelectMany(Function(r) r)

    For Each item In employeeOptions
      Console.WriteLine(item)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_46()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim employeesAL As ArrayList = Employee.GetEmployeesArrayList()

    '  Add a new employee so one employee will have no EmployeeOptionEntry records.
    employeesAL.Add(New Employee With { _
      .id = 102, _
      .firstName = "Michael", _
      .lastName = "Bolton"})

    Dim employees() As Employee = employeesAL.Cast(Of Employee)().ToArray()
    Dim empOptions() As EmployeeOptionEntry = EmployeeOptionEntry.GetEmployeeOptionEntries()

    Dim employeeOptions = employees _
      .GroupJoin( _
        empOptions, _
        Function(e) e.id, _
        Function(o) o.id, _
        Function(e, os) os.DefaultIfEmpty() _
          .Select(Function(o) New With { _
            Key .id = e.id, _
            Key .name = String.Format("{0} {1}", e.firstName, e.lastName), _
            Key .options = If(o IsNot Nothing, o.optionsCount, 0)})) _
      .SelectMany(Function(r) r)

    For Each item In employeeOptions
      Console.WriteLine(item)
    Next item

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_47()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim ints As IEnumerable(Of Integer) = Enumerable.Range(1, 10)
    For Each i As Integer In ints
      Console.WriteLine(i)
    Next i

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_48()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim ints As IEnumerable(Of Integer) = Enumerable.Repeat(2, 10)
    For Each i As Integer In ints
      Console.WriteLine(i)
    Next i

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_49()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim strings As IEnumerable(Of String) = Enumerable.Empty(Of String)()
    For Each s As String In strings
      Console.WriteLine(s)
    Next s
    Console.WriteLine(strings.Count())

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing4_()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

End Module

Public Class Employee
  Public id As Integer
  Public firstName As String
  Public lastName As String

  Public Shared Function GetEmployeesArrayList() As ArrayList
    Dim al As New ArrayList()

    al.Add(New Employee With _
        {.id = 1, .firstName = "Joe", .lastName = "Rattz"})
    al.Add(New Employee With _
        {.id = 2, .firstName = "William", .lastName = "Gates"})
    al.Add(New Employee With _
        {.id = 3, .firstName = "Anders", .lastName = "Hejlsberg"})
    al.Add(New Employee With _
        {.id = 4, .firstName = "David", .lastName = "Lightman"})
    al.Add(New Employee With _
        {.id = 101, .firstName = "Kevin", .lastName = "Flynn"})
    Return (al)
  End Function

  Public Shared Function GetEmployeesArray() As Employee()
    Return (GetEmployeesArrayList().ToArray(GetType(Employee)))
  End Function
End Class

Public Class EmployeeOptionEntry
  Public id As Integer
  Public optionsCount As Long
  Public dateAwarded As DateTime

  Public Shared Function GetEmployeeOptionEntries() As EmployeeOptionEntry()
    Dim empOptions() As EmployeeOptionEntry = { _
        New EmployeeOptionEntry With { _
            .id = 1, _
            .optionsCount = 2, _
            .dateAwarded = DateTime.Parse("1999/12/31")}, _
        New EmployeeOptionEntry With { _
            .id = 2, _
            .optionsCount = 10000, _
            .dateAwarded = DateTime.Parse("1992/06/30")}, _
        New EmployeeOptionEntry With { _
            .id = 2, _
            .optionsCount = 10000, _
            .dateAwarded = DateTime.Parse("1994/01/01")}, _
        New EmployeeOptionEntry With { _
            .id = 3, _
            .optionsCount = 5000, _
            .dateAwarded = DateTime.Parse("1997/09/30")}, _
        New EmployeeOptionEntry With { _
            .id = 2, _
            .optionsCount = 10000, _
            .dateAwarded = DateTime.Parse("2003/04/01")}, _
        New EmployeeOptionEntry With { _
            .id = 3, _
            .optionsCount = 7500, _
            .dateAwarded = DateTime.Parse("1998/09/30")}, _
        New EmployeeOptionEntry With { _
            .id = 3, _
            .optionsCount = 7500, _
            .dateAwarded = DateTime.Parse("1998/09/30")}, _
        New EmployeeOptionEntry With { _
            .id = 4, _
            .optionsCount = 1500, _
            .dateAwarded = DateTime.Parse("1997/12/31")}, _
        New EmployeeOptionEntry With { _
            .id = 101, _
            .optionsCount = 2, _
            .dateAwarded = DateTime.Parse("1998/12/31")} _
        }
    Return (empOptions)
  End Function
End Class

Public Class MyVowelToConsonantRatioComparer
  Implements IComparer(Of String)

  Public Function Compare(ByVal s1 As String, ByVal s2 As String) As Integer _
    Implements IComparer(Of String).Compare

    Dim vCount1 As Integer = 0
    Dim cCount1 As Integer = 0
    Dim vCount2 As Integer = 0
    Dim cCount2 As Integer = 0

    GetVowelConsonantCount(s1, vCount1, cCount1)
    GetVowelConsonantCount(s2, vCount2, cCount2)

    Dim dRatio1 As Double = CDbl(vCount1) / CDbl(cCount1)
    Dim dRatio2 As Double = CDbl(vCount2) / CDbl(cCount2)

    If dRatio1 < dRatio2 Then
      Return (-1)
    ElseIf dRatio1 > dRatio2 Then
      Return (1)
    Else
      Return (0)
    End If
  End Function

  '  This method is public so my code using this comparer can get the values
  '  if it wants.
  Public Sub GetVowelConsonantCount(ByVal s As String, _
    ByRef vowelCount As Integer, ByRef consonantCount As Integer)
    '  DISCLAIMER:  This code is for demonstration purposes only.
    '  This code treats the letter 'y' or 'Y' as a vowel always,
    '  which linguistically speaking, is probably invalid.

    Dim vowels As String = "AEIOUY"

    '  Initialize the counts.
    vowelCount = 0
    consonantCount = 0

    '  Convert to upper case so we are case insensitive.
    Dim sUpper As String = s.ToUpper()

    For Each ch As Char In sUpper
      If vowels.IndexOf(ch) < 0 Then
        consonantCount += 1
      Else
        vowelCount += 1
      End If
    Next ch

    Return
  End Sub
End Class

Public Class MyFounderNumberComparer
  Implements IEqualityComparer(Of Integer)

  Public Overloads Function Equals(ByVal x As Integer, ByVal y As Integer) _
        As Boolean _
      Implements System.Collections.Generic.IEqualityComparer(Of Integer).Equals
    Return (isFounder(x) = isFounder(y))
  End Function

  Public Overloads Function GetHashCode(ByVal obj As Integer) As Integer _
      Implements System.Collections.Generic. _
        IEqualityComparer(Of Integer).GetHashCode
    Dim f As Integer = 1
    Dim nf As Integer = 100
    Dim i As Integer = (If(isFounder(obj), f.GetHashCode(), nf.GetHashCode()))
    Return i
  End Function

  Public Function isFounder(ByVal id As Integer) As Boolean
    Return (id < 100)
  End Function

End Class
