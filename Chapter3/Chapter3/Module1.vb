'Imports System.Diagnostics  'For the StackTrace.

Module Module1

    Sub Main()
        ' Uncomment the functions you want to call.
        'YourTest()

        'Listing3_1()
        'Listing3_2()
        'Listing3_3()
        'Listing3_4()
        'Listing3_5()
        'Listing3_6()

    End Sub

    Sub YourTest()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        ' Do whatever you want in here.

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing3_1()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim presidents() As String = _
        { _
            "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
            "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
            "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
            "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
            "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
            "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson" _
        }

        Dim president As String = presidents.Where(Function(p) p.StartsWith("Lin")).First()

        Console.WriteLine(president)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing3_2()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim presidents() As String = _
        { _
            "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
            "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
            "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
            "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
            "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
            "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson" _
        }

        Dim items As IEnumerable(Of String) = _
            presidents.Where(Function(p) p.StartsWith("A"))

        For Each item As String In items
            Console.WriteLine(item)
        Next item

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing3_3()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim presidents() As String = _
        { _
            "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
            "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
            "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
            "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
            "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
            "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson" _
        }

        Dim items As IEnumerable(Of String) = _
            presidents.Where(Function(s) Char.IsLower(s(4)))

        Console.WriteLine("After the query.")

        For Each item As String In items
            Console.WriteLine(item)
        Next item

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing3_4()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        '  Create an array of ints.
        Dim intArray() As Integer = {1, 2, 3}

        Dim ints As IEnumerable(Of Integer) = intArray.Select(Function(i) i)

        '  Display the results.
        For Each i As Integer In ints
            Console.WriteLine(i)
        Next i

        ' Change an element in the source data.
        intArray(0) = 5

        Console.WriteLine("---------")

        '  Display the results again.
        For Each i As Integer In ints
            Console.WriteLine(i)
        Next i

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing3_5()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        '  Create an array of Integers.
        Dim intArray() As Integer = {1, 2, 3}

        Dim ints As List(Of Integer) = intArray.Select(Function(i) i).ToList()

        '  Display the results.
        For Each i As Integer In ints
            Console.WriteLine(i)
        Next i

        ' Change an element in the source data.
        intArray(0) = 5

        Console.WriteLine("---------")

        '  Display the results again.
        For Each i As Integer In ints
            Console.WriteLine(i)
        Next i

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing3_6()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        '  Create an array of Integerss.
        Dim ints() As Integer = {1, 2, 3, 4, 5, 6}

        '  Declare our delegate.
        Dim GreaterThanTwo As Func(Of Integer, Boolean) = Function(i) i > 2

        '  Perform the query ... not really.  Don't forget about deferred queries!!!
        Dim intsGreaterThanTwo As IEnumerable(Of Integer) = ints.Where(GreaterThanTwo)

        '  Display the results.
        For Each i As Integer In intsGreaterThanTwo
            Console.WriteLine(i)
        Next i

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing3_()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

End Module
