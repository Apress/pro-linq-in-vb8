'Option Explicit On
'Option Infer On
'Option Strict On

Imports System
Imports System.Linq
Imports System.Xml.Linq
Imports System.Data.Linq

Imports Chapter1.nwind

Module ProLINQ

    Sub Main()
        ' Uncomment the functions you want to call.
        'YourTest()

        'Listing1_1()
        'Listing1_2()
        'Listing1_3()
        'Listing1_4()
        'Listing1_5()
        'Listing1_6()
    Listing1_7()
        'Listing1_8()
    'Listing1_9()
    'Listing1_10()
        'Listing1_11()
        'Listing1_12()


    End Sub

    Sub YourTest()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        ' Do whatever you want in here.

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing1_1()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim greetings() As String = {"hello world", "hello LINQ", "hello Apress"}

    Dim items = _
      From s In greetings _
      Where s.EndsWith("LINQ") _
      Select s

    For Each item In items
      Console.WriteLine(item)
    Next item

    'Console.ReadLine()

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

    Sub Listing1_2()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim books As XElement = _
        <books>
            <book>
                <title>Pro LINQ: Language Integrated Query in VB.NET 2008</title>
                <author>Dennis Hayes</author>
            </book>
            <book>
                <title>Pro WF: Windows Workflow in .NET 3.0</title>
                <author>Bruce Bukovics</author>
            </book>
            <book>
                <title>Pro C# 2005 and the .NET 2.0 Platform, Third Edition</title>
                <author>Andrew Troelsen</author>
            </book>
        </books>

        'CStr cast not needed if Option Strict is off
        Dim titles = From book In books.Elements("book") _
                     Where CStr(book.Element("author")) = "Dennis Hayes" _
                     Select book.Element("title")

        For Each title In titles
            Console.WriteLine(title.Value)
        Next title

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing1_3()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim db As New Northwind( _
            "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;")

        Dim custs = From c In db.Customers _
                    Where c.City = "Rio de Janeiro" _
                    Select c

        For Each cust In custs
            Console.WriteLine("{0}", cust.CompanyName)
        Next cust

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing1_4()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim numbers() As String = {"0042", "010", "9", "27"}

        Dim nums() As Integer = numbers.Select(Function(s) Int32.Parse(s)).ToArray()

        For Each num As Integer In nums
            Console.WriteLine(num)
        Next num

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing1_5()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim numbers() As String = {"0042", "010", "9", "27"}

        Dim nums() As Integer = _
            numbers.Select(Function(s) Int32.Parse(s)).OrderBy(Function(s) s).ToArray()

        For Each num As Integer In nums
            Console.WriteLine(num)
        Next num

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing1_6()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim alEmployees As ArrayList = LINQDev.HR.Employee.GetEmployees()

        Dim contacts() As LINQDev.Common.Contact = alEmployees _
            .Cast(Of LINQDev.HR.Employee)() _
            .Select(Function(e) New LINQDev.Common.Contact With { _
                .Id = e.id, _
                .Name = String.Format("{0} {1}", e.firstName, e.lastName) _
              }) _
            .ToArray()
        LINQDev.Common.Contact.PublishContacts(contacts)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing1_7()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim db As New Northwind("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind")

        Dim orders = db.Customers _
            .Where(Function(c) c.Country = "USA" AndAlso c.Region Is "WA") _
            .SelectMany(Function(c) c.Orders)

        Console.WriteLine(orders.GetType())

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing1_8()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim db As New Northwind( _
            "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;")

        Dim orders As IEnumerable(Of Order) = db.Customers _
            .Where(Function(c) c.Country = "USA" AndAlso c.Region Is "WA") _
            .SelectMany(Function(c) c.Orders)

        For Each item As Order In orders
            Console.WriteLine("{0} - {1} - {2}", item.OrderDate, item.OrderID, _
                item.ShipName)
        Next item

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing1_9()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        '  I’ll build a legacy collection.
    Dim arrayList As ArrayList = _
      New ArrayList(New Object() {"Adams", "Arthur", "Buchanan"})

        Dim names As IEnumerable(Of String) = _
            arrayList.Cast(Of String)().Where(Function(n) n.Length < 7)
        For Each name As String In names
            Console.WriteLine(name)
        Next name

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing1_10()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        '  I’ll build a legacy collection.
    Dim arrayList As ArrayList = _
      New ArrayList(New Object() {"Adams", "Arthur", "Buchanan"})

        Dim names As IEnumerable(Of String) = _
            arrayList.OfType(Of String)().Where(Function(n) n.Length < 7)
        For Each name As String In names
            Console.WriteLine(name)
        Next name

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing1_11()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim strings() As String = {"one", "two", Nothing, "three"}

        Console.WriteLine("Before Where() is called.")
        Dim ieStrings As IEnumerable(Of String) = strings.Where(Function(s) s.Length = 3)
        Console.WriteLine("After Where() is called.")

        For Each s As String In ieStrings
            Console.WriteLine("Processing " & s)
        Next s

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing1_12()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim db As New Northwind( _
            "Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;")

        db.Log = Console.Out

        Dim orders As IQueryable(Of Order) = From c In db.Customers _
            From o In c.Orders _
            Where c.Country = "USA" AndAlso c.Region Is "WA" _
            Select o

        For Each item As Order In orders
            Console.WriteLine _
                ("{0} - {1} - {2}", item.OrderDate, item.OrderID, item.ShipName)
        Next item

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing1_()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

End Module

Namespace LINQDev.HR
  Public Class Employee
    Public id As Integer
    Public firstName As String
    Public lastName As String

    Public Shared Function GetEmployees() As ArrayList
      '  Of course the real code would probably be making a database query 
      '  right about here.
      Dim al As New ArrayList()

      '  Man, do the new VB.NET object initialization features make this a snap.
      al.Add(New Employee With { _
             .id = 1, .firstName = "Dennis", .lastName = "Hayes"})
      al.Add(New Employee With { _
             .id = 2, .firstName = "William", .lastName = "Gates"})
      al.Add(New Employee With { _
             .id = 3, .firstName = "Anders", .lastName = "Hejlsberg"})

      Return al
    End Function
  End Class
End Namespace

Namespace LINQDev.Common
    Public Class Contact
        Public Id As Integer
        Public Name As String

        Public Shared Sub PublishContacts(ByVal contacts() As Contact)
            ' This publish method just writes them to the console window.
            For Each c As Contact In contacts
                Console.WriteLine("Contact Id: {0} Contact: {1}", c.Id, c.Name)
            Next c
        End Sub
    End Class
End Namespace
