'Option Strict On
Imports Chapter2.Netsplore.Utilities

' The following two Imports are for Listing2_37 and should be commented out
' for all other examples so that they don't interfere.
'Imports <xmlns="http://www.linqdev.com/schemas/ProLinq">
'Imports <xmlns:cfg="http://schemas.microsoft.com/.NetConfiguration/v2.0">

Module Module1

  Sub Main()
    ' Uncomment the functions you want to call.
    'YourTest()

    'Listing2_1()
    'Listing2_2()
    'Listing2_3()
    'Listing2_4()
    'Listing2_5()
    'Listing2_6()
    'Listing2_7()
    'Listing2_8()
    'Listing2_9()
    'Listing2_10()
    'Listing2_11()
    'Listing2_12()
    'Listing2_13()
    'Listing2_14()
    'Listing2_15()
    'Listing2_16()
    'Listing2_17()
    'Listing2_18()
    'Listing2_19()
    'Listing2_20()
    'Listing2_21()
    'Listing2_22()
    'Listing2_23()
    'Listing2_24()
    'Listing2_25()
    'Listing2_26()
    'Listing2_27()
    'Listing2_28()
    'Listing2_29()
    'Listing2_30()
    'Listing2_31()
    'Listing2_32()
    'Listing2_33()
    'Listing2_34()
    'Listing2_35()
    'Listing2_36()
    'Listing2_37()

  End Sub

  Sub YourTest()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    ' Do whatever you want in here.
    'Dim b As Byte
    'Dim i As Integer

    'i = 1
    ''b = i  'OK
    'b = Convert.ToByte(i)

    'i = 300
    ''b = i  'Compiles fine, but causes a run time error
    'b = Convert.ToByte(i)

    'a = 4
    'b = 5
    'a = b
    'i = a = b

    'oddDay = DateTime.Today.Day & 1

    'Dim nums() As Integer = {6, 2, 7, 1, 9, 3}
    'Dim numsLessThanFour As IEnumerable(Of Integer) = nums _
    '  .Where(Function(i) i < 4) _
    '  .OrderBy(Function(i) i)

    'For Each i As Integer In numsLessThanFour
    '  Console.WriteLine(i)
    'Next i

    'Dim x = 1
    'Dim mySpouse = New With {.FirstName = "Vickey", .LastName = "Rattz"}
    ''Dim names As String() = New String() {"Adams", "Arthur", "Buchanan"}
    'Dim names = New String() {"Adams", "Arthur", "Buchanan"}

    'Dim address1 = New With { _
    '  Key .address = "105 Elm Street", _
    '  Key .city = "Atlanta", _
    '  Key .state = "GA", _
    '      .postalCode = "30339"}

    'Dim address2 = New With { _
    '  Key .address = "105 Elm Street", _
    '  Key .city = "Atlanta", _
    '  Key .state = "GA", _
    '      .postalCode = "30339"}

    'Dim presidents() As String = _
    '{ _
    '  "Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland", _
    '  "Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield", _
    '  "Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson", _
    '  "Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley", _
    '  "Monroe", "Nixon", "Pierce", "Polk", "Reagan", "Roosevelt", "Taft", _
    '  "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson" _
    '}

    'Console.WriteLine(String.Format("{0}", address1.Equals(address2)))

    Dim bookParticipants = _
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Joe</FirstName>
          <LastName>Rattz</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim mySpouse = New With {Key .FirstName = "Vickey", Key .LastName = "Rattz"}

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_1()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim nums() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}

    Dim oddNums() As Integer = _
      Common.FilterArrayOfInts(nums, AddressOf Application.IsOdd)

    For Each i As Integer In oddNums
      Console.WriteLine(i)
    Next i

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_2()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim nums() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}

    Dim oddNums() As Integer = _
      Common.FilterArrayOfInts(nums, Function(i) (i And 1) = 1)

    For Each i As Integer In oddNums
      Console.WriteLine(i)
    Next i

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_3()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    'Dim name

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_4()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim name = "Dennis" ' So far so good.
    'name = 1      '  Uh oh. ' will work in VB.NET unless strict is off.
    Console.WriteLine(name)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_5()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim unnamedTypeVar = New With {.firstArg = 1, .secondArg = "Joe"}
    Console.WriteLine(unnamedTypeVar.firstArg & ". " & unnamedTypeVar.secondArg)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_6()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim address As New Address()
    address.address = "105 Elm Street"
    address.city = "Atlanta"
    address.state = "GA"
    address.postalCode = "30339"

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_7()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim address As Address = New Address With { _
      .address = "105 Elm Street", _
      .city = "Atlanta", _
      .state = "GA", _
      .postalCode = "30339"}

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_8()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim address = New With { _
      .address = "105 Elm Street", _
      .city = "Atlanta", _
      .state = "GA", _
      .postalCode = "30339"}

    Console.WriteLine("address = {0} : city = {1} : state = {2} : zip = {3}", _
      address.address, address.city, address.state, address.postalCode)

    Console.WriteLine("{0}", address.GetType().ToString())

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_9()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim address1 = New With { _
      .address = "105 Elm Street", _
      .city = "Atlanta", _
      .state = "GA", _
      .postalCode = "30339"}

    Dim address2 = New With { _
      .address = "105 Elm Street", _
      .city = "Atlanta", _
      .state = "GA", _
      .postalCode = "30339"}

    Console.WriteLine(String.Format("{0}", address1.Equals(address2)))

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_10()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim address1 = New With { _
      Key .address = "105 Elm Street", _
      Key .city = "Atlanta", _
      Key .state = "GA", _
          .postalCode = "30339"}

    Dim address2 = New With { _
      Key .address = "105 Elm Street", _
      Key .city = "Atlanta", _
      Key .state = "GA", _
          .postalCode = "30340"}

    Console.WriteLine(String.Format("{0}", address1.Equals(address2)))

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_11()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim address1 = New With { _
      Key .address = "105 Elm Street", _
      Key .city = "Atlanta", _
      Key .state = "GA", _
      Key .postalCode = "30339"}

    Dim address2 = New With { _
      Key .address = "105 Elm Street", _
      Key .city = "Atlanta", _
      Key .state = "GA", _
      Key .postalCode = "30340"}

    Console.WriteLine(String.Format("{0}", address1.Equals(address2)))

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_12()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim address1 = New With { _
      Key .address = "105 Elm Street", _
      Key .city = "Atlanta", _
      Key .state = "GA", _
      Key .postalCode = "30339"}

    Dim address2 = New With { _
      Key .address = "105 Elm Street", _
      Key .city = "Atlanta", _
      Key .state = "GA", _
      Key .postalCode = "30339"}

    Console.WriteLine(String.Format("{0}", address1.Equals(address2)))

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_13()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    '  This code will compile.
    Dim name As String = "Joe"
    Console.WriteLine(name.ToUpper())

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_14()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    '  This code will not even compile.
    'String.ToUpper()

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_15()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim firstName As String = "Dennis"
    Dim lastName As String = "Hayes"
    'Dim name As String = firstName.Format("{0} {1}", firstName, lastName)
    'Console.WriteLine(name)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_16()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim firstName As String = "Dennis"
    Dim lastName As String = "Hayes"
    Dim name As String = String.Format("{0} {1}", firstName, lastName)
    Console.WriteLine(name)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_17()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim pi As Double = "3.1415926535".ToDouble()
    Console.WriteLine(pi)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_18()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim myWidget As New MyWidget()

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_19()
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

    Dim sequence As IEnumerable(Of String) = _
      presidents _
        .Where(Function(n) n.Length < 6) _
        .Select(Function(n) n)

    For Each name As String In sequence
      Console.WriteLine("{0}", name)
    Next name

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_20()
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

    Dim sequence As IEnumerable(Of String) = _
      From n In presidents _
      Where n.Length < 6 _
      Select n

    For Each name As String In sequence
      Console.WriteLine("{0}", name)
    Next name

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_21()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    'Dim mySpouse = New With {.FirstName = "Vickey", .LastName = "Rattz"}

    'Dim contacts() As Contact = _
    '{ _
    '  New Contact With {.Name = "Joe", .Age = 45}, _
    '  New Contact With {.Name = "Vickey", .Age = 44}, _
    '  New Contact With {.Name = "Babs", .Age = 43} _
    '}

    'Dim age As Integer = contacts.Where(Function(c) c.Name.Equals("Brad")).Select(Function(c) c.Age).

    Dim age As Integer = Nothing
    Console.WriteLine("You are {0}.", age)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_22()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim age As Integer? = Nothing
    If (age.HasValue) Then
      Console.WriteLine("You are {0}.", age)
    Else
      Console.WriteLine("There is no value for age.")
    End If

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_23()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim bookParticipants = _
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Joe</FirstName>
          <LastName>Rattz</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Console.WriteLine(bookParticipants.GetType())

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_24()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim bookParticipants = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Joe</FirstName>
          <LastName>Rattz</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Console.WriteLine(bookParticipants.GetType())

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_25()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim pi = _
      <?BookCataloger out-of-print?>

    Console.WriteLine("pi is type {0}.", pi.GetType())

    Dim comment = _
      <!--This person is retired.-->

    Console.WriteLine("comment is type {0}.", comment.GetType())

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_26()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim firstName As String = "Fabio"
    Dim lastName As String = "Ferracchiati"
    Dim type As String = "Technical Reviewer"

    Dim bookParticipants = _
      <BookParticipants>
        <BookParticipant type=<%= type %>>
          <FirstName><%= firstName %></FirstName>
          <LastName><%= lastName %></LastName>
        </BookParticipant>
      </BookParticipants>

    Console.WriteLine(bookParticipants)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_27()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim addresses As List(Of Address) = New List(Of Address)
    Dim address As Address

    address = New Address With { _
      .address = "1600 Pennsylvania Avenue NW", _
      .city = "Washington", _
      .state = "DC", _
      .postalCode = "20500"}
    addresses.Add(address)

    address = New Address With { _
      .address = "1 Grand Avenue", _
      .city = "Mackinac Island", _
      .state = "MI", _
      .postalCode = "49757"}
    addresses.Add(address)

    address = New Address With { _
      .address = "1 Approach Road", _
      .city = "Asheville", _
      .state = "NC", _
      .postalCode = "28803"}
    addresses.Add(address)

    Dim famousAddresses = _
      <FamousAddresses>
        <%= From a In addresses _
          Where a.postalCode.StartsWith("2") _
          Select _
          <FamousAddress>
            <Address><%= a.address %></Address>
            <City><%= a.city %></City>
            <State><%= a.state %></State>
            <PostalCode><%= a.postalCode %></PostalCode>
          </FamousAddress> %>
      </FamousAddresses>

    Console.WriteLine(famousAddresses)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_28()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim bookParticipants = _
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Joe</FirstName>
          <LastName>Rattz</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim participants = bookParticipants.<BookParticipant>
    For Each participant In participants
      Console.WriteLine(participant)
    Next

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_29()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim bookParticipants = _
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Joe</FirstName>
          <LastName>Rattz</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim participant1 = bookParticipants.<BookParticipant>(1)
    Console.WriteLine(participant1.Value)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_30()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim bookParticipants = _
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Joe</FirstName>
          <LastName>Rattz</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim LastNames = bookParticipants...<LastName>
    For Each lastName In LastNames
      Console.WriteLine(lastName.Value)
    Next

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_31()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim bookParticipants = _
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Joe</FirstName>
          <LastName>Rattz</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim participant2 = bookParticipants.<BookParticipant>.Value
    Console.WriteLine(participant2)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_32()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim bookParticipants = _
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Joe</FirstName>
          <LastName>Rattz</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim participants2 = bookParticipants.<BookParticipant>
    For Each participant In participants2
      Console.WriteLine(participant.@type)
    Next

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_33()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim bookParticipants = _
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Joe</FirstName>
          <LastName>Rattz</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim type = bookParticipants...<BookParticipant>.@type
    Console.WriteLine(type)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_34()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim bookParticipants = _
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Joe</FirstName>
          <LastName>Rattz</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    bookParticipants...<BookParticipant>(1).@type = "Lead Editor"
    Console.WriteLine(bookParticipants)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_35()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim bookParticipants = _
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Joe</FirstName>
          <LastName>Rattz</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    bookParticipants...<BookParticipant>(1).@country = "United Kingdom"
    Console.WriteLine(bookParticipants)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_36()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim bookParticipants = _
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Joe</FirstName>
          <LastName>Rattz</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    bookParticipants.<BookParticipant>(0).<FirstName>.Value = "Joseph"
    Console.WriteLine(bookParticipants)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing2_37()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    ' This example requires the two commented out Imports at the top of the file
    ' to be uncommented out.

    'Dim bookParticipants = _
    '  <BookParticipants>
    '    <BookParticipant type="Author">
    '      <FirstName>Joe</FirstName>
    '      <LastName>Rattz</LastName>
    '      <cfg:configuration>
    '        <cfg:configSections></cfg:configSections>
    '      </cfg:configuration>
    '    </BookParticipant>
    '    <BookParticipant type="Editor">
    '      <FirstName>Ewan</FirstName>
    '      <LastName>Buckingham</LastName>
    '    </BookParticipant>
    '  </BookParticipants>

    'Console.WriteLine(bookParticipants)

    'Console.WriteLine(vbCrLf)

    'Dim bookParticipant = bookParticipants.<BookParticipant>(0)
    'Console.WriteLine("<BookParticipant>=")
    'Console.WriteLine(bookParticipant)

    'Console.WriteLine(vbCrLf)

    'bookParticipant = bookParticipants.<cfg:BookParticipant>(0)
    'Console.WriteLine("<cfg:BookParticipant>=")
    'Console.WriteLine(bookParticipant)

    'Console.WriteLine(vbCrLf)

    'Dim configuration = bookParticipants.<BookParticipant>(0).<configuration>(0)
    'Console.WriteLine("<configuration>=")
    'Console.WriteLine(configuration)

    'Console.WriteLine(vbCrLf)

    'configuration = bookParticipants.<BookParticipant>(0).<cfg:configuration>(0)
    'Console.WriteLine("<cfg:configuration>=")
    'Console.WriteLine(configuration)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

End Module

Public Class Common
  Public Delegate Function IntFilter(ByVal i As Integer) As Boolean

  Public Shared Function FilterArrayOfInts _
    (ByVal ints() As Integer, ByVal filter As IntFilter) As Integer()

    Dim aList As New ArrayList()
    For Each i As Integer In ints
      If filter(i) Then
        aList.Add(i)
      End If
    Next i
    Return CType(aList.ToArray(GetType(Integer)), Integer())

  End Function
End Class

Public Class Application
  Public Shared Function IsOdd(ByVal i As Integer) As Boolean
    Return (i And 1) = 1
  End Function
End Class

Public Class Address
  Public address As String
  Public city As String
  Public state As String
  Public postalCode As String
End Class

Public Class Contact
  Public Name As String
  Public Age As Integer
End Class

Namespace Netsplore.Utilities
  Module StringConversions
    <System.Runtime.CompilerServices.Extension()> _
    Public Function ToDouble(ByVal s As String) As Double
      Return Double.Parse(s)
    End Function

    <System.Runtime.CompilerServices.Extension()> _
    Public Function ToBool(ByVal s As String) As Boolean
      Return Boolean.Parse(s)
    End Function
  End Module
End Namespace

Partial Public Class MyWidget
  Private Sub MyWidgetStart(ByVal count As Integer)
    Console.WriteLine("In MyWidgetStart(count is {0})", count)
  End Sub

  Private Sub MyWidgetEnd(ByVal count As Integer)
    Console.WriteLine("In MyWidgetEnd(count is {0})", count)
  End Sub
End Class
