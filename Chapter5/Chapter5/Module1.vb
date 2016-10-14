Imports System.Linq
Imports System.Collections
Imports System.Collections.Generic
Imports System.Diagnostics  'For the StackTrace.

Module Module1

    Sub Main()
        ' Uncomment the functions you want to call.
    'YourTest()

        'Listing5_1()
        'Listing5_2()
    'Listing5_3()
    'Listing5_4()
    'Listing5_5()
        'Listing5_6()
        'Listing5_7()
        'Listing5_8()
        'Listing5_9()
        'Listing5_10()
        'Listing5_11()
        'Listing5_12()
        'Listing5_13()
        'Listing5_14()
        'Listing5_15()
        'Listing5_16()
        'Listing5_17()
        'Listing5_18()
        'Listing5_19()
        'Listing5_20()
        'Listing5_21()
        'Listing5_22()
        'Listing5_23()
        'Listing5_24()
        'Listing5_25()
        'Listing5_26()
        'Listing5_27()
    'Listing5_28()
    'Listing5_29()
    'Listing5_30()
    'Listing5_31()
    'Listing5_32()
    'Listing5_33()
    'Listing5_34()
    'Listing5_35()
    'Listing5_36()
        'Listing5_37()
        'Listing5_38()
        'Listing5_39()
        'Listing5_40()
        'Listing5_41()
        'Listing5_42()
        'Listing5_43()
        'Listing5_44()
        'Listing5_45()
        'Listing5_46()
        'Listing5_47()
        'Listing5_48()
        'Listing5_49()
        'Listing5_50()
        'Listing5_51()
        'Listing5_52()
        'Listing5_53()
        'Listing5_54()
        'Listing5_55()
        'Listing5_56()
        'Listing5_57()
        'Listing5_58()
        'Listing5_59()
        'Listing5_60()
        'Listing5_61()
        'Listing5_62()
        'Listing5_63()
    'Listing5_64()
    Listing5_65()


    End Sub

    Sub YourTest()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    ' Do whatever you want in here.
    Dim nums As Integer() = {1, 3, 5, 7}

    Dim num As Integer = 5
    num = nums.FirstOrDefault(Function(i) i > 10)
    Console.WriteLine(num)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_1()
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

        Dim names() As String = presidents.OfType(Of String)().ToArray()

        For Each name As String In names
            Console.WriteLine(name)
        Next name

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_2()
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

        Dim names As List(Of String) = presidents.ToList()

        For Each name As String In names
            Console.WriteLine(name)
        Next name

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_3()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        '  My dictionary is going to be of type Dictionary<int, Employee> because 
        '  I am going to use the Employee.id field as the key, which is of type int,
        '  and I am going to store the entire Employee object as the element.
        Dim eDictionary As Dictionary(Of Integer, Employee) = _
            Employee.GetEmployeesArray().ToDictionary(Function(k) k.id)

        Dim e As Employee = eDictionary(2)
    Console.WriteLine("Employee whose id = 2 is {0} {1}", e.firstName, e.lastName)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_4()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        '  My dictionary is going to be of type Dictionary(Of string, Employee2) because
        '  I am going to use the Employee2.id field as the key, which is of type string,
        '  and I am going to store the entire Employee2 object as the element.
        Dim eDictionary As Dictionary(Of String, Employee2) = _
            Employee2.GetEmployeesArray(). _
                ToDictionary(Function(k) k.id, New MyStringifiedNumberComparer())

        Dim e As Employee2 = eDictionary("2")
        Console.WriteLine("Employee whose id == ""2"" : {0} {1}", e.firstName, e.lastName)

        e = eDictionary("000002")
        Console.WriteLine _
            ("Employee whose id == ""000002"" : {0} {1}", e.firstName, e.lastName)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_5()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        '  My dictionary is going to be of type Dictionary(Of Integer, String) because
        '  I am going to use the Employee.id field as the key, which is of type int,
        '  and I am going to store a concatenation of the firstName and lastName as 
        '  the element.
        Dim eDictionary As Dictionary(Of Integer, String) = Employee.GetEmployeesArray() _
            .ToDictionary( _
                Function(k) k.id, _
                Function(i) String.Format("{0} {1}", i.firstName, i.lastName))

        Dim name As String = eDictionary(2)
    Console.WriteLine("Employee whose id = 2 is {0}", name)


        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_6()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        '  My dictionary is going to be of type Dictionary<string, string> because
        '  I am going to use the Employee.id field as the key, which is of type string,
        '  and I am going to store firstName and lastName concatenated as the value.
        Dim eDictionary As Dictionary(Of String, String) = Employee2.GetEmployeesArray() _
            .ToDictionary( _
                Function(k) k.id, _
                Function(i) String.Format("{0} {1}", i.firstName, i.lastName), _
                    New MyStringifiedNumberComparer()) ' comparer

        Dim name As String = eDictionary("2")
        Console.WriteLine("Employee whose id == ""2"" : {0}", name)

        name = eDictionary("000002")
        Console.WriteLine("Employee whose id == ""000002"" : {0}", name)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_7()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        '  My Lookup is going to be of type ILookup(Integer, Actor) because I am
        '  going to use the Actor.birthYear field as the key, which is of type int,
        '  and I am going to store the entire Actor object as the stored value.
        Dim lookup As ILookup(Of Integer, Actor) = _
            Actor.GetActors().ToLookup(Function(k) k.birthYear)

        '  Let's see if I can find the 'one' born in 1964.
        Dim actors As IEnumerable(Of Actor) = lookup(1964)
        For Each actor In actors
            Console.WriteLine("{0} {1}", actor.firstName, actor.lastName)
        Next actor

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_8()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        '  My Lookup is going to be of type ILookup(String, Actor2) because I am 
        '  going to use the Actor2.birthYear field as the key, which is of type string,
        '  and I am going to store the entire Actor2 object as the stored value.
        Dim lookup As ILookup(Of String, Actor2) = Actor2.GetActors() _
            .ToLookup(Function(k) k.birthYear, New MyStringifiedNumberComparer())

        '  Let's see if I can find the 'one' born in 1964.
        Dim actors As IEnumerable(Of Actor2) = lookup("0001964")
        For Each actor In actors
            Console.WriteLine("{0} {1}", actor.firstName, actor.lastName)
        Next actor

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_9()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        '  My Lookup is going to be of type ILookup(Of Integer, String) because I am
        '  going to use the Actor.birthYear field as the key, which is of type int,
        '  and I am going to store the firstName and lastName concatenated
        '  together as the stored value.
        Dim lookup As ILookup(Of Integer, String) = _
            Actor.GetActors() _
                .ToLookup( _
                    Function(k) k.birthYear, _
                    Function(a) String.Format("{0} {1}", a.firstName, a.lastName))

        '  Let's see if I can find the 'one' born in 1964.
        Dim actors As IEnumerable(Of String) = lookup(1964)
        For Each actor In actors
            Console.WriteLine("{0}", actor)
        Next actor

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_10()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        '  My Lookup is going to be of type ILookup<string, string> because I am 
        '  going to use the Actor2.birthYear field as the key, which is of type string,
        '  and I am going to store the firstName and lastName concatenated together,
        '  which is a string, as the stored value.
        Dim lookup As ILookup(Of String, String) = Actor2.GetActors() _
            .ToLookup( _
                Function(k) k.birthYear, _
                Function(a) String.Format("{0} {1}", a.firstName, a.lastName), _
                New MyStringifiedNumberComparer())

        '  Let's see if I can find the 'one' born in 1964.
        Dim actors As IEnumerable(Of String) = lookup("0001964")
        For Each actor In actors
            Console.WriteLine("{0}", actor)
        Next actor

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_11()
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

        Dim eq As Boolean = presidents.SequenceEqual(presidents)
        Console.WriteLine(eq)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_12()
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

        Dim eq As Boolean = presidents.SequenceEqual(presidents.Take(presidents.Count()))
        Console.WriteLine(eq)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_13()
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

        Dim eq As Boolean = presidents _
            .SequenceEqual(presidents.Take(presidents.Count() - 1))
        Console.WriteLine(eq)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_14()
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

        Dim eq As Boolean = presidents _
            .SequenceEqual(presidents.Take(5).Concat(presidents.Skip(5)))
        Console.WriteLine(eq)


        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_15()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim stringifiedNums1() As String = {"001", "49", "017", "0080", "00027", "2"}
        Dim stringifiedNums2() As String = {"1", "0049", "17", "080", "27", "02"}

        Dim eq As Boolean = stringifiedNums1 _
            .SequenceEqual(stringifiedNums2, New MyStringifiedNumberComparer())

        Console.WriteLine(eq)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_16()
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

        Dim name As String = presidents.First()
        Console.WriteLine(name)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_17()
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

        Dim name As String = presidents.First(Function(p) p.StartsWith("H"))
        Console.WriteLine(name)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_18()
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

        Dim name As String = presidents.Take(0).FirstOrDefault()
        Console.WriteLine(If(name Is Nothing, "NOTHING", name))

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_19()
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

        Dim name As String = presidents.FirstOrDefault()
        Console.WriteLine(If(name Is Nothing, "NOTHING", name))

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_20()
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

        Dim name As String = presidents.FirstOrDefault(Function(p) p.StartsWith("B"))
        Console.WriteLine(If(name Is Nothing, "NOTHING", name))

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_21()
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

        Dim name As String = presidents.FirstOrDefault(Function(p) p.StartsWith("Z"))
        Console.WriteLine(If(name Is Nothing, "NOTHING", name))

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_22()
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

        Dim name As String = presidents.Last()
        Console.WriteLine(name)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_23()
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

        Dim name As String = presidents.Last(Function(p) p.StartsWith("H"))
        Console.WriteLine(name)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_24()
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

        Dim name As String = presidents.Take(0).LastOrDefault()
        Console.WriteLine(If(name Is Nothing, "NOTHING", name))

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_25()
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

        Dim name As String = presidents.LastOrDefault()
        Console.WriteLine(If(name Is Nothing, "NOTHING", name))

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_26()
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

        Dim name As String = presidents.LastOrDefault(Function(p) p.StartsWith("B"))
        Console.WriteLine(If(name Is Nothing, "NOTHING", name))

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_27()
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

        Dim name As String = presidents.LastOrDefault(Function(p) p.StartsWith("Z"))
        Console.WriteLine(If(name Is Nothing, "NOTHING", name))

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_28()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        '  For the Single call to not throw an exception, I must have a sequence with 
        '  a single element.  I will use the Where operator to insure this.
        Dim emp As Employee = _
            Employee.GetEmployeesArray().Where(Function(e) e.id = 3).Single()

        Console.WriteLine("{0} {1}", emp.firstName, emp.lastName)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_29()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        '  For the Single call to not throw an exception, I must have a sequence with
        '  a single element.  I will use the Where operator to insure this.
        Dim emp As Employee = Employee.GetEmployeesArray().Single(Function(e) e.id = 3)

        Console.WriteLine("{0} {1}", emp.firstName, emp.lastName)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_30()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim emp As Employee = Employee.GetEmployeesArray().Where(Function(e) e.id = 5) _
            .SingleOrDefault()

        Console.WriteLine(If(emp Is Nothing, "NOTHING", _
            String.Format("{0} {1}", emp.firstName, emp.lastName)))

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_31()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim emp As Employee = Employee.GetEmployeesArray().Where(Function(e) e.id = 4) _
            .SingleOrDefault()

        Console.WriteLine(If(emp Is Nothing, "NOTHING", _
            String.Format("{0} {1}", emp.firstName, emp.lastName)))

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_32()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim emp As Employee = Employee.GetEmployeesArray() _
            .SingleOrDefault(Function(e) e.id = 4)

        Console.WriteLine(If(emp Is Nothing, "NOTHING", _
            String.Format("{0} {1}", emp.firstName, emp.lastName)))

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_33()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim emp As Employee = Employee.GetEmployeesArray() _
            .SingleOrDefault(Function(e) e.id = 5)

        Console.WriteLine(If(emp Is Nothing, "NOTHINIG", _
            String.Format("{0} {1}", emp.firstName, emp.lastName)))

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_34()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim emp As Employee = Employee.GetEmployeesArray().ElementAt(3)

        Console.WriteLine("{0} {1}", emp.firstName, emp.lastName)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_35()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim emp As Employee = Employee.GetEmployeesArray().ElementAtOrDefault(3)

        Console.WriteLine(If(emp Is Nothing, "NOTHING", _
            String.Format("{0} {1}", emp.firstName, emp.lastName)))

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_36()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim emp As Employee = Employee.GetEmployeesArray() _
            .ElementAtOrDefault(5)

        Console.WriteLine(If(emp Is Nothing, "NOTHING", _
            String.Format("{0} {1}", emp.firstName, emp.lastName)))

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_37()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim any As Boolean = Enumerable.Empty(Of String)().Any()
        Console.WriteLine(any)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_38()
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

        Dim any As Boolean = presidents.Any()
        Console.WriteLine(any)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_39()
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

        Dim any As Boolean = presidents.Any(Function(s) s.StartsWith("Z"))
        Console.WriteLine(any)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_40()
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

        Dim any As Boolean = presidents.Any(Function(s) s.StartsWith("A"))
        Console.WriteLine(any)


        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_41()
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

        Dim all As Boolean = presidents.All(Function(s) s.Length > 5)
        Console.WriteLine(all)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_42()
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

        Dim all As Boolean = presidents.All(Function(s) s.Length > 3)
        Console.WriteLine(all)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_43()
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

        Dim contains As Boolean = presidents.Contains("Rattz")
        Console.WriteLine(contains)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_44()
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

        Dim contains As Boolean = presidents.Contains("Hayes")
        Console.WriteLine(contains)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_45()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim stringifiedNums() As String = {"001", "49", "017", "0080", "00027", "2"}

        Dim contains As Boolean = stringifiedNums _
            .Contains("0000002", New MyStringifiedNumberComparer())

        Console.WriteLine(contains)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_46()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim stringifiedNums() As String = {"001", "49", "017", "0080", "00027", "2"}

        Dim contains As Boolean = stringifiedNums _
            .Contains("000271", New MyStringifiedNumberComparer())

        Console.WriteLine(contains)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_47()
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

        Dim count As Integer = presidents.Count()
        Console.WriteLine(count)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_48()
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

        Dim count As Integer = presidents _
            .Count(Function(s) s.StartsWith("J"))
        Console.WriteLine(count)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_49()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim count As Long = Enumerable.Range(0, Integer.MaxValue) _
            .Concat(Enumerable.Range(0, Integer.MaxValue)).LongCount()

        Console.WriteLine(count)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_50()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim count As Long = Enumerable.Range(0, Integer.MaxValue) _
            .Concat(Enumerable.Range(0, Integer.MaxValue)) _
            .LongCount(Function(n) n > 1 AndAlso n < 4)

        Console.WriteLine(count)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_51()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        '  First I'll generate a sequence of integers.
        Dim ints As IEnumerable(Of Integer) = Enumerable.Range(1, 10)

        '  I'll show you the sequence of integers.
        For Each i As Integer In ints
            Console.WriteLine(i)
        Next i

        Console.WriteLine("--")

        '  Now, I'll sum them.
        Dim sum As Integer = ints.Sum()
        Console.WriteLine(sum)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_52()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim options As IEnumerable(Of EmployeeOptionEntry) = _
            EmployeeOptionEntry.GetEmployeeOptionEntries()

        Dim optionsSum As Long = options.Sum(Function(o) o.optionsCount)
        Console.WriteLine("The sum of the employee options is: {0}", optionsSum)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_53()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim myInts() As Integer = {974, 2, 7, 1374, 27, 54}
        Dim minInt As Integer = myInts.Min()
        Console.WriteLine(minInt)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_54()
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

        Dim minName As String = presidents.Min()
        Console.WriteLine(minName)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_55()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim oldestActorAge As Integer = Actor.GetActors() _
            .Min(Function(a) a.birthYear)
        Console.WriteLine(oldestActorAge)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_56()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim firstAlphabetically As String = Actor.GetActors() _
            .Min(Function(a) a.lastName)
        Console.WriteLine(firstAlphabetically)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_57()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim myInts() As Integer = {974, 2, 7, 1374, 27, 54}
        Dim maxInt As Integer = myInts.Max()
        Console.WriteLine(maxInt)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_58()
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

        Dim maxName As String = presidents.Max()
        Console.WriteLine(maxName)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_59()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim youngestActorAge As Integer = Actor.GetActors() _
            .Max(Function(a) a.birthYear)
        Console.WriteLine(youngestActorAge)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_60()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim lastAlphabetically As String = Actor.GetActors() _
            .Max(Function(a) a.lastName)
        Console.WriteLine(lastAlphabetically)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_61()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        '  First build a sequence of integers.
        Dim intSequence As IEnumerable(Of Integer) = Enumerable.Range(1, 10)
        Console.WriteLine("Here is my sequnece of integers:")
        For Each i As Integer In intSequence
            Console.WriteLine(i)
        Next i

        '  Now I'll get the average.
        Dim average As Double = intSequence.Average()
        Console.WriteLine("Here is the average:  {0}", average)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_62()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        '  First, I'll get the sequence of EmployeeOptionEntry objects.
        Dim options As IEnumerable(Of EmployeeOptionEntry) = _
            EmployeeOptionEntry.GetEmployeeOptionEntries()

        Console.WriteLine("Here are the employee ids and their options:")
        For Each eo As EmployeeOptionEntry In options
            Console.WriteLine("Employee id:  {0},  Options:  {1}", eo.id, eo.optionsCount)
        Next eo

        '  Now I'll get the average of the options.
        Dim optionAverage As Double = options.Average(Function(o) o.optionsCount)
        Console.WriteLine("The average of the employee options is: {0}", optionAverage)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_63()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        '  First I need an array of Integers from 1 to N where
        '  N is the number I want the factorial for.  In this case,
        '  N will be 5.
        Dim N As Integer = 5
        Dim intSequence As IEnumerable(Of Integer) = Enumerable.Range(1, N)

        '  I will just ouput the sequence so all can see it.
        For Each item As Integer In intSequence
            Console.WriteLine(item)
        Next item

        '  Now calculate the factorial and display it.
        '  av == aggregated value, e == element
        Dim agg As Integer = intSequence.Aggregate(Function(av, e) av * e)
        Console.WriteLine("{0}! = {1}", N, agg)


        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing5_64()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        '  Create a sequence of ints from 1 to 10.
        Dim intSequence As IEnumerable(Of Integer) = Enumerable.Range(1, 10)

        '  I'll just ouput the sequence so all can see it.
        For Each item As Integer In intSequence
            Console.WriteLine(item)
        Next item
        Console.WriteLine("--")

        '  Now calculate the sum and display it.
        Dim sum As Integer = intSequence.Aggregate(0, Function(s, i) s + i)
        Console.WriteLine(sum)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

  Sub Listing5_65()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    '  Create a sequence of ints from 1 to 10.
    Dim intSequence As IEnumerable(Of Integer) = Enumerable.Range(1, 10)

    '  I'll just ouput the sequence so all can see it.
    For Each item As Integer In intSequence
      Console.WriteLine(item)
    Next item

    '  Now calculate the average and display it.
    Dim avg As Double = intSequence.Aggregate(0, _
                                              Function(s, i) s + i, _
                                              Function(r) r / intSequence.Count)

    Console.WriteLine("Here is the average:  {0}", avg)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

    Sub Listing5_()
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

Public Class MyStringifiedNumberComparer
    Implements IEqualityComparer(Of String)
    Public Overloads Function Equals(ByVal x As String, ByVal y As String) _
            As Boolean Implements IEqualityComparer(Of String).Equals
        Return (GetHashCode(x) = GetHashCode(y))
    End Function

    Public Overloads Function GetHashCode(ByVal obj As String) _
            As Integer Implements IEqualityComparer(Of String).GetHashCode
        Return (Integer.Parse(obj))
    End Function
End Class

Public Class Actor
    Public birthYear As Integer
    Public firstName As String
    Public lastName As String

    Public Shared Function GetActors() As Actor()
        Dim actors() As Actor = { _
            New Actor With {.birthYear = 1964, _
                .firstName = "Keanu", .lastName = "Reeves"}, _
            New Actor With {.birthYear = 1968, _
                .firstName = "Owen", .lastName = "Wilson"}, _
            New Actor With {.birthYear = 1960, _
                .firstName = "James", .lastName = "Spader"}, _
            New Actor With {.birthYear = 1964, _
                .firstName = "Sandra", .lastName = "Bullock"}}
        Return (actors)
    End Function
End Class

Public Class Employee2
    Public id As String
    Public firstName As String
    Public lastName As String

    Public Shared Function GetEmployeesArrayList() As ArrayList
        Dim al As New ArrayList()

        al.Add(New Employee2 With _
            {.id = "1", .firstName = "Joe", .lastName = "Rattz"})
        al.Add(New Employee2 With _
            {.id = "2", .firstName = "William", .lastName = "Gates"})
        al.Add(New Employee2 With _
            {.id = "3", .firstName = "Anders", .lastName = "Hejlsberg"})
        al.Add(New Employee2 With _
            {.id = "4", .firstName = "David", .lastName = "Lightman"})
        al.Add(New Employee2 With _
            {.id = "101", .firstName = "Kevin", .lastName = "Flynn"})
        Return (al)
    End Function

    Public Shared Function GetEmployeesArray() As Employee2()
    Return (GetEmployeesArrayList().ToArray(GetType(Employee2)))
    End Function
End Class

Public Class Actor2
    Public birthYear As String
    Public firstName As String
    Public lastName As String

    Public Shared Function GetActors() As Actor2()
    Dim actors() As Actor2 = { _
            New Actor2 With {.birthYear = "1964", _
                .firstName = "Keanu", .lastName = "Reeves"}, _
            New Actor2 With {.birthYear = "1968", _
                .firstName = "Owen", .lastName = "Wilson"}, _
            New Actor2 With {.birthYear = "1960", _
                .firstName = "James", .lastName = "Spader"}, _
            New Actor2 With {.birthYear = "01964", _
                .firstName = "Sandra", .lastName = "Bullock"}}
    '  The worlds first Y10K compliant date!

        Return (actors)
    End Function
End Class
