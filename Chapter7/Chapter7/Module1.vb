Imports System.Xml
Public Enum ParticipantTypes
  Author = 0
  Editor
End Enum

Module Module1

  Sub Main()
    ' Uncomment the functions you want to call.
    YourTest()

    'Listing7_1()
    'Listing7_2()
    'Listing7_3()
    'Listing7_4()
    'Listing7_5()
    'Listing7_6()
    'Listing7_7()
    'Listing7_8()
    'Listing7_9()
    'Listing7_10()
    'Listing7_11()
    'Listing7_12()
    'Listing7_13()
    'Listing7_14()
    'Listing7_15()
    'Listing7_16()
    'Listing7_17()
    'Listing7_18()
    'Listing7_19()
    'Listing7_20()
    'Listing7_21()
    'Listing7_22()
    'Listing7_23()
    'Listing7_24()
    'Listing7_25()
    'Listing7_26()
    'Listing7_27()
    'Listing7_28()
    'Listing7_29()
    'Listing7_30()
    'Listing7_31()
    'Listing7_32()
    'Listing7_33()
    'Listing7_34()
    'Listing7_35()
    'Listing7_36()
    'Listing7_37()
    'Listing7_38()
    'Listing7_39()
    'Listing7_40()
    'Listing7_41()
    'Listing7_42()
    'Listing7_43()
    'Listing7_44()
    'Listing7_45()
    'Listing7_46()
    'Listing7_47()
    'Listing7_48()
    'Listing7_49()
    'Listing7_50()
    'Listing7_51()
    'Listing7_52()
    'Listing7_53()
    'Listing7_54()
    'Listing7_55()
    'Listing7_56()
    'Listing7_57()
    'Listing7_58()
    'Listing7_59()
    'Listing7_60()
    'Listing7_61()
    'Listing7_62()
    'Listing7_63()
    'Listing7_64()
    'Listing7_65()
    'Listing7_66()
    'Listing7_67()
    'Listing7_68()
    'Listing7_69()
    'Listing7_70()
    'Listing7_71()
    'Listing7_72()
    'Listing7_73()
    'Listing7_74()
    'Listing7_75()
    'Listing7_76()
    'Listing7_77()
    'Listing7_78()
    'Listing7_79()
    'Listing7_80()
    'Listing7_81()
    'Listing7_82()
    'Listing7_83()
    'Listing7_84()
    'Listing7_85()
    'Listing7_86()
    Listing7_87()

  End Sub

  Sub YourTest()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    'Dim xml = _
    '  <root>
    '    <BookParticipants>
    '      <BookParticipant>
    '        <FirstName>Ewan</FirstName>
    '        <LastName>Buckingham</LastName>
    '        <RelatedContacts>
    '          <BookParticipant>
    '            <FirstName>Ewan</FirstName>
    '            <LastName>Hayes</LastName>
    '          </BookParticipant>
    '        </RelatedContacts>
    '      </BookParticipant>
    '      <BookParticipant>
    '        <FirstName>Joe</FirstName>
    '        <LastName>Rattz</LastName>
    '      </BookParticipant>
    '    </BookParticipants>
    '  </root>

    'For Each item In xml...<BookParticipant>.Where(Function(e) e.Element("FirstName").Value = "Ewan")
    '  Console.WriteLine("{0} - {1}", item.Name, item.Value)
    'Next

    'Dim xDocument = _
    '  <?xml version="1.0"?>
    '  <RootElement>
    '  </RootElement>

    'xDocument.<RootElement>.First() _
    '  .Add(<ChildElement>Joe was here.</ChildElement>)

    'Console.WriteLine(xDocument)

    'Dim xBookParticipants As New XElement("BookParticipants")

    Dim i1 As Integer = LoadOptions.SetBaseUri
    Dim i2 As Integer = LoadOptions.SetLineInfo
    Dim i3 As Integer = LoadOptions.SetBaseUri Or LoadOptions.SetLineInfo

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_1()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xBookParticipant As _
      New XElement("BookParticipant", _
        New XElement("FirstName", "Dennis"), _
        New XElement("LastName", "Hayes"))
    Console.WriteLine(xBookParticipant.ToString())

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_2()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xBookParticipants As _
      New XElement("BookParticipants", _
        New XElement("BookParticipant", _
          New XAttribute("type", "Author"), _
          New XElement("FirstName", "Dennis"), _
          New XElement("LastName", "Hayes")), _
        New XElement("BookParticipant", _
          New XAttribute("type", "Editor"), _
          New XElement("FirstName", "Ewan"), _
          New XElement("LastName", "Buckingham")))

    Console.WriteLine(xBookParticipants.ToString())

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_3()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument As New XDocument( _
      New XElement("BookParticipants", _
        New XElement("BookParticipant", _
          New XAttribute("type", "Author"), _
          New XElement("FirstName", "Dennis"), _
          New XElement("LastName", "Hayes"))))

    Console.WriteLine(xDocument.ToString())

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_4()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xElement As _
      New XElement("BookParticipants", _
        New XElement("BookParticipant", _
          New XAttribute("type", "Author"), _
          New XElement("FirstName", "Dennis"), _
          New XElement("LastName", "Hayes")))

    Console.WriteLine(xElement.ToString())

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_5()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim MyNameSpace As XNamespace = "http://www.linqdev.com"

    Dim xBookParticipants As _
      New XElement(MyNameSpace + "BookParticipants", _
        New XElement(MyNameSpace + "BookParticipant", _
          New XAttribute("type", "Author"), _
          New XElement(MyNameSpace + "FirstName", "Dennis"), _
          New XElement(MyNameSpace + "LastName", "Hayes")), _
        New XElement(MyNameSpace + "BookParticipant", _
          New XAttribute("type", "Editor"), _
          New XElement(MyNameSpace + "FirstName", "Ewan"), _
          New XElement(MyNameSpace + "LastName", "Buckingham")))

    Console.WriteLine(xBookParticipants.ToString())


    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_6()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim MyNameSpace As XNamespace = "http://www.linqdev.com"

    Dim xBookParticipants As _
      New XElement(MyNameSpace + "BookParticipants", _
        New XAttribute(XNamespace.Xmlns + "linqdev", MyNameSpace), _
        New XElement(MyNameSpace + "BookParticipant"))

    Console.WriteLine(xBookParticipants.ToString())

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_7()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim name As New XElement("Name", "Dennis")
    Console.WriteLine(name.ToString())

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_8()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim name As _
      New XElement("Person", _
        New XElement("FirstName", "Dennis"), _
        New XElement("LastName", "Hayes"))

    Console.WriteLine(name)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_9()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim name As New XElement("Name", "Dennis")
    Console.WriteLine(name)
    Console.WriteLine(CType(name, String))

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_10()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim count As New XElement("Count", 12)
    Console.WriteLine(count)
    Console.WriteLine(CType(count, Integer))

    Dim smoker As New XElement("Smoker", False)
    Console.WriteLine(smoker)
    Console.WriteLine(CType(smoker, Boolean))

    Dim pi As New XElement("Pi", 3.1415926535)
    Console.WriteLine(pi)
    Console.WriteLine(CType(pi, Double))

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_11()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim smoker As New XElement("Smoker", "true")
    Console.WriteLine(smoker)
    Console.WriteLine(CType(smoker, Boolean))

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_12()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Try
      Dim smoker As New XElement("Smoker", "Tue")
      Console.WriteLine(smoker)
      Console.WriteLine(CType(smoker, Boolean))
    Catch ex As Exception
      Console.WriteLine(ex)
    End Try

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_13()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0"?>
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    '  I'll get a sequence of BookParticipant elements.  I need a sequence of some
    '  elements to remove to demonstrate the Halloween problem.
    Dim elements As IEnumerable(Of XElement) = _
      xDocument.Element("BookParticipants").Elements("BookParticipant")

    '  Just so you can see the actual source elements in the sequence...
    For Each element As XElement In elements
      ' First, we will display the source elements.
      Console.WriteLine( _
        "Source element: {0} : value = {1}", _
        element.Name, element.Value)
    Next element
    '  Ok, I have the BookParticipant elements.

    '  Now that we have seen the sequence of source elements, I'll enumerate 
    '  through the sequence removing them one at a time.
    For Each element As XElement In elements
      ' Now, I'll remove each element.
      Console.WriteLine("Removing {0} = {1} ...", element.Name, element.Value)
      element.Remove()
    Next element

    Console.WriteLine(xDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_14()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0"?>
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    '  I'll get a sequence of BookParticipant elements.  I need a sequence of some
    '  elements to remove to demonstrate the Halloween problem.
    Dim elements As IEnumerable(Of XElement) = _
      xDocument.Element("BookParticipants").Elements("BookParticipant")

    '  Just so you can see the actual source elements in the sequence...
    For Each element As XElement In elements
      ' First, we will display the source elements.
      Console.WriteLine( _
        "Source element: {0} : value = {1}", _
        element.Name, element.Value)
    Next element
    '  Ok, I have the BookParticipant elements.

    '  Now that we have seen the sequence of source elements, I'll enumerate 
    '  through the sequence removing them one at a time.
    For Each element As XElement In elements.ToArray()
      ' Now, I'll remove each element.
      Console.WriteLine("Removing {0} = {1} ...", element.Name, element.Value)
      element.Remove()
    Next element

    Console.WriteLine(xDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_15()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim firstName As New XElement("FirstName", "Dennis")
    Console.WriteLine(CType(firstName, String))

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_16()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim bookParticipants() As BookParticipant = { _
      New BookParticipant With { _
        .FirstName = "Dennis", _
        .LastName = "Hayes", _
        .ParticipantType = ParticipantTypes.Author}, _
      New BookParticipant With { _
        .FirstName = "Ewan", _
        .LastName = "Buckingham", _
        .ParticipantType = ParticipantTypes.Editor}}

    'Dim xBookParticipants As New XElement( _
    '  "BookParticipants", _
    '  bookParticipants.Select(Function(p) New XElement( _
    '    "BookParticipant", _
    '    New XAttribute("type", p.ParticipantType), _
    '    New XElement("FirstName", p.FirstName), _
    '    New XElement("LastName", p.LastName))))

    Dim xBookParticipants = _
      <BookPartecipants>
        <%= From p In bookParticipants Select _
          <BookPartecipant type=<%= p.ParticipantType %>>
            <FirstName><%= p.FirstName %></FirstName>
            <LastName><%= p.LastName %></LastName>
          </BookPartecipant> _
        %>
      </BookPartecipants>

    Console.WriteLine(xBookParticipants)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_17()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xBookParticipant As _
      New XElement("BookParticipant", _
        New XAttribute("type", "Author"))

    Console.WriteLine(xBookParticipant)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_18()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xBookParticipant As New XElement("BookParticipant")
    Dim xAttribute As New XAttribute("type", "Author")
    xBookParticipant.Add(xAttribute)

    Console.WriteLine(xBookParticipant)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_19()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xBookParticipant As _
      New XElement("BookParticipant", _
        New XComment("This person is retired."))

    Console.WriteLine(xBookParticipant)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_20()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xBookParticipant As New XElement("BookParticipant")
    Dim xComment As New XComment("This person is retired.")
    xBookParticipant.Add(xComment)

    Console.WriteLine(xBookParticipant)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_21()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument As New XDocument( _
      New XDeclaration("1.0", "UTF-8", "yes"), _
      New XElement("BookParticipant"))

    Console.WriteLine(xDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_22()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument As New XDocument(New XElement("BookParticipant"))

    Dim xDeclaration As New XDeclaration("1.0", "UTF-8", "yes")
    xDocument.Declaration = xDeclaration

    Console.WriteLine(xDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_23()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument As New XDocument( _
      New XDocumentType( _
        "BookParticipants", _
        Nothing, _
        "BookParticipants.dtd", _
        Nothing), _
      New XElement("BookParticipants"))

    Console.WriteLine(xDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_24()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument As New XDocument()

    Dim documentType As New XDocumentType( _
      "BookParticipants", _
      Nothing, _
      "BookParticipants.dtd", _
      Nothing)

    xDocument.Add(documentType, New XElement("BookParticipants"))

    Console.WriteLine(xDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_25()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument As New XDocument()
    Console.WriteLine(xDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_26()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument As New XDocument( _
      New XDeclaration("1.0", "UTF-8", "yes"), _
      New XDocumentType( _
        "BookParticipants", _
        Nothing, _
        "BookParticipants.dtd", _
        Nothing), _
      New XProcessingInstruction( _
        "BookCataloger", _
        "out-of-print"), _
      New XElement( _
        "BookParticipants"))

    Console.WriteLine(xDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_27()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xBookParticipant As New XElement("BookParticipant")
    Console.WriteLine(xBookParticipant)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_28()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim ns As XNamespace = "http://www.linqdev.com/Books"
    Dim xBookParticipant As New XElement(ns + "BookParticipant")
    Console.WriteLine(xBookParticipant)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_29()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument As New XDocument( _
      New XProcessingInstruction("BookCataloger", "out-of-print"), _
      New XElement("BookParticipants", _
        New XElement("BookParticipant", _
          New XProcessingInstruction("ParticipantDeleter", "delete"), _
          New XElement("FirstName", "Dennis"), _
          New XElement("LastName", "Hayes"))))

    Console.WriteLine(xDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_30()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    'Dim xDocument As New XDocument( _
    '  New XElement("BookParticipants", _
    '    New XElement("BookParticipant", _
    '      New XElement("FirstName", "Dennis"), _
    '      New XElement("LastName", "Hayes"))))

    Dim xDocument = _
      <?xml version="1.0"?>
      <BookParticipants>
        <BookParticipant>
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim xPI1 As New XProcessingInstruction("BookCataloger", "out-of-print")
    XDocument.AddFirst(xPI1)

    Dim xPI2 As New XProcessingInstruction("ParticipantDeleter", "delete")
    'Dim outOfPrintParticipant As XElement = _
    '  MyxDocument.Element("BookParticipants") _
    '    .Elements("BookParticipant") _
    '    .Where( _
    '      Function(e) (CStr((CType(e, XElement)).Element("FirstName"))) = "Dennis" _
    '      AndAlso (CStr((CType(e, XElement)).Element("LastName"))) = "Hayes") _
    '    .Single()

    'Dim outOfPrintParticipant As XElement = _
    '  xDocument.Element("BookParticipants") _
    '    .Elements("BookParticipant") _
    '    .Where( _
    '      Function(e) e.Element("FirstName") = "Dennis" _
    '      AndAlso e.Element("LastName") = "Hayes") _
    '    .Single()

    'Dim outOfPrintParticipant As XElement = _
    '  xDocument.<BookParticipants>.<BookParticipant> _
    '    .Where(Function(e) e.Element("FirstName").Value = "Dennis" _
    '           AndAlso e.Element("LastName").Value = "Hayes") _
    '    .Single()

    Dim outOfPrintParticipant As XElement = _
      xDocument.<BookParticipants>.<BookParticipant> _
        .Where(Function(e) e.<FirstName>.Value = "Dennis" AndAlso _
                           e.<LastName>.Value = "Hayes") _
        .Single()

    outOfPrintParticipant.AddFirst(xPI2)

    Console.WriteLine(xDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_31()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim names() As String = {"John", "Paul", "George", "Pete"}

    'Dim xNames As New XElement( _
    '  "Beatles", From n In names Select New XElement("Name", n))

    Dim xNames = _
      <Beatles>
        <%= From n In names Select _
          <Name><%= n %></Name> %>
      </Beatles>

    names(3) = "Ringo"

    Console.WriteLine(xNames)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_32()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim names() As String = {"John", "Paul", "George", "Pete"}

    Dim xNames As New XStreamingElement( _
      "Beatles", From n In names Select New XStreamingElement("Name", n))

    names(3) = "Ringo"

    Console.WriteLine(xNames)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_33()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xFirstName As New XElement("FirstName", "Dennis")
    Console.WriteLine(xFirstName)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_34()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xName As New XText("Dennis")
    Dim xFirstName As New XElement("FirstName", xName)
    Console.WriteLine(xFirstName)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_35()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xErrorMessage As New XElement( _
      "HTMLMessage", New XCData("<H1>Invalid user id or password.</H1>"))

    Console.WriteLine(xErrorMessage)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_36()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument As New XDocument( _
      New XElement( _
        "BookParticipants", _
        New XElement( _
          "BookParticipant", _
          New XAttribute("type", "Author"), _
          New XAttribute("experience", "first-time"), _
          New XAttribute("language", "English"), _
          New XElement("FirstName", "Dennis"), _
          New XElement("LastName", "Hayes"))))

    'xDocument.Save("bookparticipants.xml")
    xDocument.Save("bookparticipants.xml", SaveOptions.DisableFormatting)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_37()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim bookParticipants As New XElement( _
      "BookParticipants", _
      New XElement("BookParticipant", _
        New XAttribute("type", "Author"), _
        New XAttribute("experience", "first-time"), _
        New XAttribute("language", "English"), _
        New XElement("FirstName", "Dennis"), _
        New XElement("LastName", "Hayes")))

    bookParticipants.Save("bookparticipants.xml")

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_38()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument As XDocument = xDocument.Load( _
      "bookparticipants.xml", LoadOptions.SetBaseUri Or LoadOptions.SetLineInfo)

    Console.WriteLine(xDocument)

    'Dim firstName As XElement = xDocument.Descendants("FirstName").First()
    Dim firstName = xDocument...<FirstName>.First()

    Console.WriteLine( _
      "FirstName Line:{0} - Position:{1}", _
      (CType(firstName, IXmlLineInfo)).LineNumber, _
      (CType(firstName, IXmlLineInfo)).LinePosition)

    Console.WriteLine("FirstName Base URI:{0}", firstName.BaseUri)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_39()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xElement As XElement = xElement.Load("bookparticipants.xml")
    Console.WriteLine(xElement)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_40()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xml As String = _
      "<?xml version=""1.0"" encoding=""utf-8""?><BookParticipants>" & _
      "<BookParticipant type=""Author"" experience=""first-time"" language=" & _
      """English""><FirstName>Dennis</FirstName><LastName>Hayes</LastName>" & _
      "</BookParticipant></BookParticipants>"

    Dim xElement As XElement = xElement.Parse(xml)
    Console.WriteLine(xElement)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_41()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <?BookCataloger out-of-print?>
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    Console.WriteLine(xDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_42()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <?BookCataloger out-of-print?>
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    Console.WriteLine(firstParticipant.NextNode)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_43()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <?BookCataloger out-of-print?>
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    Console.WriteLine(firstParticipant.NextNode.PreviousNode)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_44()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <?BookCataloger out-of-print?>
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    Console.WriteLine(firstParticipant.Document)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_45()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <?BookCataloger out-of-print?>
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    Console.WriteLine(firstParticipant.Parent)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_46()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <?BookCataloger out-of-print?>
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    For Each node As XNode In firstParticipant.Nodes()
      Console.WriteLine(node)
    Next node

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_47()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <?BookCataloger out-of-print?>
      <BookParticipants>
        <BookParticipant type="Author">
          <!--This is a new author.-->
          <?AuthorHandler new?>
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    For Each node As XNode In firstParticipant.Nodes()
      Console.WriteLine(node)
    Next node

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_48()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <?BookCataloger out-of-print?>
      <BookParticipants>
        <BookParticipant type="Author">
          <!--This is a new author.-->
          <?AuthorHandler new?>
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    For Each node As XNode In firstParticipant.Nodes().OfType(Of XElement)()
      Console.WriteLine(node)
    Next node

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_49()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <?BookCataloger out-of-print?>
      <BookParticipants>
        <BookParticipant type="Author">
          <!--This is a new author.-->
          <?AuthorHandler new?>
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    For Each node As XNode In firstParticipant.Nodes().OfType(Of XComment)()
      Console.WriteLine(node)
    Next node

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_50()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <?BookCataloger out-of-print?>
      <BookParticipants>
        <BookParticipant type="Author">
          <!--This is a new author.-->
          <?AuthorHandler new?>
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    For Each attr As XAttribute In firstParticipant.Attributes()
      Console.WriteLine(attr)
    Next attr

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_51()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <?BookCataloger out-of-print?>
      <BookParticipants>
        <BookParticipant type="Author">
          <!--This is a new author.-->
          <?AuthorHandler new?>
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    For Each node As XNode In firstParticipant.Elements()
      Console.WriteLine(node)
    Next node

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_52()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <?BookCataloger out-of-print?>
      <BookParticipants>
        <BookParticipant type="Author">
          <!--This is a new author.-->
          <?AuthorHandler new?>
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    'For Each node As XNode In firstParticipant.<FirstName>
    For Each node As XNode In firstParticipant.Elements("FirstName")
      Console.WriteLine(node)
    Next node

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_53()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <?BookCataloger out-of-print?>
      <BookParticipants>
        <BookParticipant type="Author">
          <!--This is a new author.-->
          <?AuthorHandler new?>
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    'Console.WriteLine(firstParticipant.Element("FirstName"))
    Console.WriteLine(firstParticipant.<FirstName>(0))

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_54()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <?BookCataloger out-of-print?>
      <BookParticipants>
        <BookParticipant type="Author">
          <!--This is a new author.-->
          <?AuthorHandler new?>
          <FirstName>Dennis<NickName>Spider</NickName></FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    For Each element As XElement In _
        firstParticipant.<FirstName>.<NickName>.Ancestors()
      'firstParticipant.Element("FirstName").Element("NickName").Ancestors()
      Console.WriteLine(element.Name)
    Next element

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_55()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <?BookCataloger out-of-print?>
      <BookParticipants>
        <BookParticipant type="Author">
          <!--This is a new author.-->
          <?AuthorHandler new?>
          <FirstName>Dennis<NickName>Spider</NickName></FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    For Each element As XElement In _
        firstParticipant.<FirstName>.<NickName>.AncestorsAndSelf()
      Console.WriteLine(element.Name)
    Next element

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_56()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <?BookCataloger out-of-print?>
      <BookParticipants>
        <BookParticipant type="Author">
          <!--This is a new author.-->
          <?AuthorHandler new?>
          <FirstName>Dennis<NickName>Spider</NickName></FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    'For Each element As XElement In firstParticipant...
    For Each element As XElement In firstParticipant.Descendants()
      Console.WriteLine(element.Name)
    Next element

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_57()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <?BookCataloger out-of-print?>
      <BookParticipants>
        <BookParticipant type="Author">
          <!--This is a new author.-->
          <?AuthorHandler new?>
          <FirstName>Dennis<NickName>Spider</NickName></FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    For Each element As XElement In firstParticipant.DescendantsAndSelf()
      Console.WriteLine(element.Name)
    Next element

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_58()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <?BookCataloger out-of-print?>
      <BookParticipants>
        <!--Begin Of List-->
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
        <!--End Of List-->
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    For Each node As XNode In firstParticipant.NodesAfterSelf()
      Console.WriteLine(node)
    Next node

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_59()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <?BookCataloger out-of-print?>
      <BookParticipants>
        <!--Begin Of List-->
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
        <!--End Of List-->
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    For Each node As XNode In firstParticipant.ElementsAfterSelf()
      Console.WriteLine(node)
    Next node

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_60()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <?BookCataloger out-of-print?>
      <BookParticipants>
        <!--Begin Of List-->
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
        <!--End Of List-->
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    For Each node As XNode In firstParticipant.NextNode.NodesBeforeSelf()
      Console.WriteLine(node)
    Next node

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_61()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <?BookCataloger out-of-print?>
      <BookParticipants>
        <!--Begin Of List-->
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
        <!--End Of List-->
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    For Each node As XNode In firstParticipant.NextNode.ElementsBeforeSelf()
      Console.WriteLine(node)
    Next node

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_62()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0"?>
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
      </BookParticipants>

    Console.WriteLine(xDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_63()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0"?>
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
      </BookParticipants>

    xDocument.<BookParticipants>(0). _
      Add(<BookParticipant type="Editor">
            <FirstName>Ewan</FirstName>
            <LastName>Buckingham</LastName>
          </BookParticipant>)

    Console.WriteLine(xDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_64()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0"?>
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
      </BookParticipants>

    xDocument.<BookParticipants>(0). _
      AddFirst(<BookParticipant type="Editor">
                 <FirstName>Ewan</FirstName>
                 <LastName>Buckingham</LastName>
               </BookParticipant>)

    Console.WriteLine(xDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_65()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0"?>
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
      </BookParticipants>

    xDocument.<BookParticipants>(0). _
      Add(<BookParticipant type="Editor">
            <FirstName>Ewan</FirstName>
            <LastName>Buckingham</LastName>
          </BookParticipant>)

    xDocument...<BookParticipant>(1). _
      AddBeforeSelf(<BookParticipant type="Technical Editor">
                      <FirstName>Joe</FirstName>
                      <LastName>Rattz</LastName>
                    </BookParticipant>)

    Console.WriteLine(xDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_66()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0"?>
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
      </BookParticipants>

    xDocument.<BookParticipants>(0). _
      Add(<BookParticipant type="Editor">
            <FirstName>Ewan</FirstName>
            <LastName>Buckingham</LastName>
          </BookParticipant>)

    'xDocument...<BookParticipant>(1). _
    xDocument.Element("BookParticipants").Elements("BookParticipant").First(). _
      AddAfterSelf(<BookParticipant type="Technical Editor">
                     <FirstName>Joe</FirstName>
                     <LastName>Rattz</LastName>
                   </BookParticipant>)

    Console.WriteLine(xDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_67()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    '  I will use this to store a reference to one of the elements in the XML tree.
    'Dim firstParticipant As XElement = _
    '  New XElement( _
    '    "BookParticipant", _
    '    New XAttribute("type", "Author"), _
    '    New XElement("FirstName", "Dennis"), _
    '    New XElement("LastName", "Hayes"))

    'Console.WriteLine(System.Environment.NewLine + "Before node deletion")

    'Dim MyxDocument As New XDocument( _
    '  New XElement( _
    '    "BookParticipants", _
    '    firstParticipant, _
    '    New XElement( _
    '      "BookParticipant", _
    '      New XAttribute("type", "Editor"), _
    '      New XElement("FirstName", "Ewan"), _
    '      New XElement("LastName", "Buckingham"))))

    'Console.WriteLine(MyxDocument)

    'firstParticipant.Remove()
    'Console.WriteLine(System.Environment.NewLine + "After node deletion")

    'Console.WriteLine(MyxDocument)

    '  I will use this to store a reference to one of the elements in the XML tree.
    'Dim firstParticipant As XElement = _
    'New XElement( _
    '    <BookParticipant type="Author">
    '      <FirstName>Dennis</FirstName>
    '      <LastName>Hayes</LastName>
    '    </BookParticipant>)

    'Dim secondParticipant As XElement = _
    'New XElement( _
    '    <BookParticipant type="Editor">
    '      <FirstName>Ewan</FirstName>
    '      <LastName>Buckingham</LastName>
    '    </BookParticipant>)

    'Console.WriteLine(System.Environment.NewLine + "Before node deletion")

    'Dim MyxDocument As New XDocument( _
    '    <BookParticipants>
    '      <%= firstParticipant %>
    '      <%= secondParticipant %>
    '    </BookParticipants>)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    Console.WriteLine(System.Environment.NewLine + "Before node deletion")
    Console.WriteLine(xDocument)

    firstParticipant.Remove()
    Console.WriteLine(System.Environment.NewLine + "After node deletion")

    Console.WriteLine(xDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_68()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    'xDocument.Descendants().Where(Function(e) e.Name = "FirstName").Remove()
    xDocument...<FirstName>.Remove()

    Console.WriteLine(xDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_69()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Console.WriteLine(System.Environment.NewLine + "Before removing the content.")
    Console.WriteLine(xDocument)

    xDocument.Element("BookParticipants").RemoveAll()

    Console.WriteLine(System.Environment.NewLine + "After removing the content.")
    Console.WriteLine(xDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_70()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <BookParticipants>
        <BookParticipant type="Author">
          <!--This is a new author.-->
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    Console.WriteLine("Before updating nodes:")
    Console.WriteLine(xDocument)

    '  Now, I'll update an element, a comment, and a text node.
    firstParticipant.Element("FirstName").Value = "Spider"

    firstParticipant.Nodes().OfType(Of XComment)().Single().Value = _
      "Author of Pro LINQ: Language Integrated Query in VB.Net 2008."

    CType(firstParticipant.Element("FirstName").NextNode, XElement) _
      .Nodes().OfType(Of XText)().Single().Value = "Hayes, Jr."

    Console.WriteLine("After updating nodes:")
    Console.WriteLine(xDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_71()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    '  I will use this to store a reference to the DocumentType for later access.
    Dim docType As XDocumentType = _
      New XDocumentType("BookParticipants", Nothing, "BookParticipants.dtd", Nothing)

    Dim MyxDocument As New XDocument(docType, New XElement("BookParticipants"))

    Console.WriteLine("Before updating document type:")
    Console.WriteLine(MyxDocument)

    docType.Name = "MyBookParticipants"
    docType.SystemId = "http://www.somewhere.com/DTDs/MyBookParticipants.DTD"
    docType.PublicId = "-//DTDs//TEXT Book Participants//EN"

    Console.WriteLine("After updating document type:")
    Console.WriteLine(MyxDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_72()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    '  I will use this to store a reference for later access.
    Dim procInst As XProcessingInstruction = _
      New XProcessingInstruction("BookCataloger", "out-of-print")

    Dim MyxDocument As New XDocument(New XElement("BookParticipants"), procInst)

    Console.WriteLine("Before updating processing instruction:")
    Console.WriteLine(MyxDocument)

    procInst.Target = "BookParticipantContactManager"
    procInst.Data = "update"

    Console.WriteLine("After updating processing instruction:")
    Console.WriteLine(MyxDocument)


    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_73()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    Console.WriteLine(System.Environment.NewLine & "Before updating elements:")
    Console.WriteLine(xDocument)

    'firstParticipant.ReplaceAll( _
    '  New XElement("FirstName", "Ewan"), _
    '  New XElement("LastName", "Buckingham"))

    firstParticipant.ReplaceAll( _
      <FirstName>Ewan</FirstName>, _
      <LastName>BuckingHam</LastName>)

    Console.WriteLine(System.Environment.NewLine & "After updating elements:")
    Console.WriteLine(xDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_74()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    Console.WriteLine(System.Environment.NewLine & "Before updating elements:")
    Console.WriteLine(xDocument)

    '  First, I will use XElement.SetElementValue to update the value of an element.
    '  Since an element named FirstName is there, its value will be updated to Denny.
    firstParticipant.SetElementValue("FirstName", "Denny")

    '  Second, I will use XElement.SetElementValue to add an element.
    '  Since no element named MiddleInitial exists, one will be added.
    firstParticipant.SetElementValue("MiddleInitial", "E")

    '  Third, I will use XElement.SetElementValue to remove an element.
    '  Setting an element's value to Nothing will remove it.
    firstParticipant.SetElementValue("LastName", Nothing)

    Console.WriteLine(System.Environment.NewLine & "After updating elements:")
    Console.WriteLine(xDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_75()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <BookParticipants>
        <BookParticipant type="Author" experience="first-time" language="English">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    Console.WriteLine(firstParticipant.FirstAttribute)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_76()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <BookParticipants>
        <BookParticipant type="Author" experience="first-time" language="English">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    Console.WriteLine(firstParticipant.FirstAttribute.NextAttribute)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_77()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <BookParticipants>
        <BookParticipant type="Author" experience="first-time" language="English">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    Console.WriteLine(firstParticipant.FirstAttribute.NextAttribute.PreviousAttribute)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_78()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <BookParticipants>
        <BookParticipant type="Author" experience="first-time" language="English">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    Console.WriteLine(firstParticipant.LastAttribute)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_79()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <BookParticipants>
        <BookParticipant type="Author" experience="first-time" language="English">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    'Console.WriteLine(firstParticipant.Attribute("type").Value)
    Console.WriteLine(firstParticipant.@type)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_80()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <BookParticipants>
        <BookParticipant type="Author" experience="first-time" language="English">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    For Each attr As XAttribute In firstParticipant.Attributes()
      Console.WriteLine(attr)
    Next attr

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_81()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <BookParticipants>
        <BookParticipant type="Author" experience="first-time" language="English">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    Console.WriteLine(System.Environment.NewLine & "Before removing attribute:")
    Console.WriteLine(xDocument)

    firstParticipant.Attribute("type").Remove()

    Console.WriteLine(System.Environment.NewLine & "After removing attribute:")
    Console.WriteLine(xDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_82()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <BookParticipants>
        <BookParticipant type="Author" experience="first-time" language="English">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    Console.WriteLine(vbCrLf & "Before removing attributes:")
    Console.WriteLine(xDocument)

    firstParticipant.Attributes().Remove()

    Console.WriteLine(vbCrLf & "After removing attributes:")
    Console.WriteLine(xDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_83()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <BookParticipants>
        <BookParticipant type="Author" experience="first-time" language="English">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    Console.WriteLine(vbCrLf & "Before changing attribute's value:")
    Console.WriteLine(xDocument)

    'firstParticipant.Attribute("experience").Value = "beginner"
    firstParticipant.@experience = "beginner"

    Console.WriteLine(vbCrLf & "After changing attribute's value:")
    Console.WriteLine(xDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_84()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <BookParticipants>
        <BookParticipant type="Author" experience="first-time">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    Console.WriteLine(vbCrLf & "Before changing the attributes:")
    Console.WriteLine(xDocument)

    '  This call will update the type attribute's value because an attribute whose 
    '  name is "type" exists.
    'firstParticipant.SetAttributeValue("type", "beginner")
    firstParticipant.@type = "beginner"

    '  This call will add an attribute because an attribute with the specified name
    '  does not exist.
    'firstParticipant.SetAttributeValue("language", "English")
    firstParticipant.@language = "English"

    '  This call will delete an attribute because an attribute with the specified name
    '  exists, and the passed value is Nothing.
    'firstParticipant.SetAttributeValue("experience", Nothing)
    firstParticipant.@experience = Nothing

    Console.WriteLine(vbCrLf & "After changing the attributes:")
    Console.WriteLine(xDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_85()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <BookParticipants>
        <BookParticipant type="Author" experience="first-time" language="English">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>


    '  Display the document for reference.
    Console.WriteLine(xDocument)
    Console.WriteLine()

    '  I'll add some annotations based on their type attribute.
    For Each e As XElement In xDocument.Element("BookParticipants").Elements()
      If e.@type = "Author" Then
        Dim aHandler As New AuthorHandler()
        e.AddAnnotation(aHandler)
      ElseIf e.Attribute("type").Value = "Editor" Then
        Dim eHandler As New EditorHandler()
        e.AddAnnotation(eHandler)
      End If
    Next e

    '  Declare some variables for the handler objects.  I declared additional
    '  variables because normally, I probably wouldn't be adding the annotations
    '  and retrieving them in the same place.
    Dim aHandler2 As AuthorHandler
    Dim eHandler2 As EditorHandler
    For Each e As XElement In xDocument...<BookParticipant>
      If e.@type = "Author" Then
        aHandler2 = e.Annotation(Of AuthorHandler)()
        If aHandler2 IsNot Nothing Then
          aHandler2.Display(e)
        End If
      ElseIf e.@type = "Editor" Then
        eHandler2 = e.Annotation(Of EditorHandler)()
        If eHandler2 IsNot Nothing Then
          eHandler2.Display(e)
        End If
      End If
    Next e

    '  Now, I'll remove the annotations.
    '  This time I will just reuse the handler variables from above.  But normally,
    '  this too would probably be done elsewhere.
    For Each e As XElement In xDocument...<BookParticipant>
      If e.@type = "Author" Then
        e.RemoveAnnotations(Of AuthorHandler)()
      ElseIf e.@type = "Editor" Then
        e.RemoveAnnotations(Of EditorHandler)()
      End If
    Next e

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_86()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    Console.WriteLine("{0}{1}", xDocument, System.Environment.NewLine)

    '  First I must register for the event.
    AddHandler firstParticipant.Changing, AddressOf MyChangingEventHandler
    AddHandler firstParticipant.Changed, AddressOf MyChangedEventHandler
    AddHandler xDocument.Changed, AddressOf DocumentChangedHandler

    '  Now. let's make a change.
    firstParticipant.Element("FirstName").Value = "Spider"

    Console.WriteLine("{0}{1}", xDocument, vbCrLf)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_87()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument = _
      <?xml version="1.0" encoding="utf-8" standalone="yes"?>
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Dim firstParticipant = xDocument...<BookParticipant>(0)

    Console.WriteLine("{0}{1}", xDocument, System.Environment.NewLine)

    '  First I must register for the event.
    'AddHandler firstParticipant.Changing, AddressOf MyChangingEventHandler
    'AddHandler firstParticipant.Changing, _
    '  Sub(sender As Object, cea As XObjectChangeEventArgs) _
    '              True = True
    'Console.WriteLine( _
    '  "Type of object changing: {0}, Type of change: {1}", _
    '  sender.GetType().Name, cea.ObjectChange) As Boolean

    AddHandler firstParticipant.Changed, AddressOf MyChangedEventHandler
    AddHandler xDocument.Changed, AddressOf DocumentChangedHandler

    '  Now. let's make a change.
    firstParticipant.Element("FirstName").Value = "Spider"

    Console.WriteLine("{0}{1}", xDocument, vbCrLf)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing7_()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Public Sub MyChangingEventHandler(ByVal sender As Object, _
                                    ByVal cea As XObjectChangeEventArgs)
    Console.WriteLine( _
      "Type of object changing: {0}, Type of change: {1}", _
      sender.GetType().Name, cea.ObjectChange)
  End Sub

  Public Sub MyChangedEventHandler(ByVal sender As Object, _
                                   ByVal cea As XObjectChangeEventArgs)
    Console.WriteLine( _
      "Type of object changed: {0}, Type of change: {1}", _
      sender.GetType().Name, cea.ObjectChange)
  End Sub

  Public Sub DocumentChangedHandler(ByVal sender As Object, _
                                    ByVal cea As XObjectChangeEventArgs)
    Console.WriteLine( _
      "Doc:  Type of object changed: {0}, Type of change: {1}{2}", _
      sender.GetType().Name, cea.ObjectChange, vbCrLf)
  End Sub

End Module

Public Class BookParticipant
  Public FirstName As String
  Public LastName As String
  Public ParticipantType As ParticipantTypes
End Class

Public Class AuthorHandler
  Public Sub Display(ByVal element As XElement)
    Console.WriteLine("AUTHOR BIO")
    Console.WriteLine("--------------------------")
    Console.WriteLine("Name:        {0} {1}", element.Element("FirstName").Value, _
      element.Element("LastName").Value)
    Console.WriteLine("Language:    {0}", element.Attribute("language").Value)
    Console.WriteLine("Experience:  {0}", element.Attribute("experience").Value)
    Console.WriteLine("==========================" & System.Environment.NewLine)
  End Sub
End Class

Public Class EditorHandler
  Public Sub Display(ByVal element As XElement)
    Console.WriteLine("EDITOR BIO")
    Console.WriteLine("--------------------------")
    Console.WriteLine("Name:        {0}", element.Element("FirstName").Value)
    Console.WriteLine("             {0}", element.Element("LastName").Value)
    Console.WriteLine("==========================" & System.Environment.NewLine)
  End Sub
End Class

