Imports System.IO
Imports System.Linq
Imports System.Xml
Imports System.Xml.Linq
Imports System.Xml.Schema
Imports System.Xml.XPath
Imports System.Xml.Xsl

Module Module1
  Private Valid As Boolean = True

  Sub Main()
    ' Uncomment the functions you want to call.
    'YourTest()

    'Listing9_1()
    'Listing9_2()
    'Listing9_3()
    'Listing9_4()
    'Listing9_5()
    'Listing9_6()
    'Listing9_7()
    'Listing9_8()
    'Listing9_9()
    'Listing9_10()
    'Listing9_11()
    'Listing9_12()
    'Listing9_13()
    'Listing9_14()
    'Listing9_15()
    'Listing9_16()
    'Listing9_17()
    'Listing9_18()
    'Listing9_19()


  End Sub

  Sub YourTest()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    ' Do whatever you want in here.
    'Dim x As XElement = _
    '  <Phases>
    '    <Phase Id="22" Name="LowerLevelInteriorWalls">
    '      <Tab0 Name="Stair Framing">
    '        <Item Id="1" Text="Stair Height to Floor Below" UOM="Feet"/>
    '      </Tab0>
    '      <Tab1 Name="Interior Walls">
    '        <Item Id="1" Text="Number of Rooms" UOM="Ea"/>
    '        <Item Id="2" Text="Lin Ft of Interior Wall" UOM="Feet"/>
    '        <Item Id="3" Text="Length of Plumbing Walls" UOM="Feet"/>
    '      </Tab1>
    '      <Tab2 Name="Ceiling Joists">
    '        <Item Id="1" Text="Ceiling Joists #1 Length" UOM="Feet"/>
    '        <Item Id="2" Text="Ceiling Joists #1 Quantity" UOM="Ea"/>
    '        <Item Id="3" Text="Ceiling Joists #1 StrongBack Width" UOM="Feet"/>
    '      </Tab2>
    '    </Phase>
    '    <Phase Id="25" Name="First Floor Exterior Wall Framing">
    '      <Tab Id="0" Name="Wall">
    '        <Item Id="1" Text="First Floor Perimeter" UOM="Feet" Precision="Fraction16s" DefaultValue="12"/>
    '        <Item Id="2" Text="First Floor Inside Corners" UOM="Ea"/>
    '        <Item Id="3" Text="First Floor Outside Corners" UOM="Unit"/>
    '        <Item Id="4" Text="First Floor Windows" UOM="Ea"/>
    '        <Item Id="5" Text="First Floor Ext Doors" UOM="Tally" Precision="NextEvenFoot"/>
    '      </Tab>
    '      <Tab Id="1" Name="Headers">
    '        <Item Id="1" Text="First Floor Wall Window Count" UOM="Ea"/>
    '        <Item Id="2" Text="First Floor Wall Ext Door Count" UOM="SqFt"/>
    '      </Tab>
    '      <Tab Id="2" Name="Sheathing">
    '        <Item Id="1" Text="First Floor Wall Area" UOM="SqFt"/>
    '        <Item Id="2" Text="First Floor Outside Corners" UOM="Ea"/>
    '        <Item Id="3" Text="Window/Door Flashing Lin Ft" UOM="Tally"/>
    '      </Tab>
    '      <Tab Id="3" Name="Extras">
    '        <Item Id="1" Text="First Floor Wall Area" UOM="SqFt"/>
    '        <Item Id="2" Text="First Floor Outside Corners" UOM="Ea"/>
    '        <Item Id="3" Text="Hold Down o/c" UOM="Feet"/>
    '        <Item Id="4" Text="First Floor Wall Perimeter" UOM="Feet"/>
    '      </Tab>
    '    </Phase>
    '    <Phase Id="59" Name="Test Window">
    '      <Tab Id="0" Name="Wall">
    '        <Item Id="1" Text="Lower Level Perimeter" UOM="Feet" Precision="Fraction16s"/>
    '        <Item Id="2" Text="Lower Level Inside Corners" UOM="Ea"/>
    '        <Item Id="3" Text="Lower Level Outside Corners" UOM="Ea"/>
    '        <Item Id="4" Text="Lower Level Windows" UOM="Ea"/>
    '        <Item Id="5" Text="Lower Level Ext Doors" UOM="Ea"/>
    '      </Tab>
    '    </Phase>
    '  </Phases>

    Dim doc = XDocument.Load("phases.xml")
    Dim partItem = doc...<Phase>.Where(Function(p) p.@Id = "25").<Tab>.Where(Function(t) t.@Id = "0").<Item>.Where(Function(i) i.@Id = "4")
    partItem.@Text = "Joe was here"
    Console.WriteLine(doc)
    doc.Save("phases_modified.xml")

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing9_1()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument As XDocument = _
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

    Dim elements As IEnumerable(Of XElement) = _
      xDocument...<BookParticipant>
    'xDocument.Descendants("BookParticipant")

    For Each element As XElement In elements
      Console.WriteLine("Element: {0} : value = {1}", element.Name, element.Value)
    Next element

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing9_2()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument As XDocument = _
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

    Dim elements As IEnumerable(Of XElement) = _
      xDocument _
        .Descendants("BookParticipant") _
        .Where(Function(e) (e.Element("FirstName")).Value = "Ewan")
    '.Where(Function(e) CType(e.Element("FirstName"), String) = "Ewan")
    '.Where(Function(e) (CStr(e.Element("FirstName"))) = "Ewan")
    '.Where(Function(e) (e.Element("FirstName")).Value = "Ewan")

    For Each element As XElement In elements
      Console.WriteLine("Element: {0} : value = {1}", element.Name, element.Value)
    Next element

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing9_3()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument As XDocument = _
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

    Dim elements As IEnumerable(Of XElement) = _
      From e In xDocument.Descendants("BookParticipant") _
        Where (CStr(e.Attribute("type"))) <> "Illustrator" _
        Order By (CStr(e.Element("LastName"))) _
        Select e

    For Each element As XElement In elements
      Console.WriteLine("Element: {0} : value = {1}", element.Name, element.Value)
    Next element

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing9_4()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim users As XDocument = _
      <?xml version="1.0"?>
      <users>
        <user_tuple>
          <userid>U01</userid>
          <name>Tom Jones</name>
          <rating>B</rating>
        </user_tuple>
        <user_tuple>
          <userid>U02</userid>
          <name>Mary Doe</name>
          <rating>A</rating>
        </user_tuple>
        <user_tuple>
          <userid>U03</userid>
          <name>Dee Linquent</name>
          <rating>D</rating>
        </user_tuple>
        <user_tuple>
          <userid>U04</userid>
          <name>Roger Smith</name>
          <rating>E</rating>
        </user_tuple>
        <user_tuple>
          <userid>U05</userid>
          <name>Jack Sprat</name>
          <rating>B</rating>
        </user_tuple>
        <user_tuple>
          <userid>U06</userid>
          <name>Rip Van Winkle</name>
          <rating>B</rating>
        </user_tuple>
      </users>

    Dim items As XDocument = _
      <?xml version="1.0"?>
      <items>
        <item_tuple>
          <itemno>1001</itemno>
          <description>Red Bicycle</description>
          <offered_by>U01</offered_by>
          <start_date>1999-01-05</start_date>
          <end_date>1999-01-20</end_date>
          <reserve_price>40</reserve_price>
        </item_tuple>
        <item_tuple>
          <itemno>1002</itemno>
          <description>Motorcycle</description>
          <offered_by>U02</offered_by>
          <start_date>1999-02-11</start_date>
          <end_date>1999-03-15</end_date>
          <reserve_price>500</reserve_price>
        </item_tuple>
        <item_tuple>
          <itemno>1003</itemno>
          <description>Old Bicycle</description>
          <offered_by>U02</offered_by>
          <start_date>1999-01-10</start_date>
          <end_date>1999-02-20</end_date>
          <reserve_price>25</reserve_price>
        </item_tuple>
        <item_tuple>
          <itemno>1004</itemno>
          <description>Tricycle</description>
          <offered_by>U01</offered_by>
          <start_date>1999-02-25</start_date>
          <end_date>1999-03-08</end_date>
          <reserve_price>15</reserve_price>
        </item_tuple>
        <item_tuple>
          <itemno>1005</itemno>
          <description>Tennis Racket</description>
          <offered_by>U03</offered_by>
          <start_date>1999-03-19</start_date>
          <end_date>1999-04-30</end_date>
          <reserve_price>20</reserve_price>
        </item_tuple>
        <item_tuple>
          <itemno>1006</itemno>
          <description>Helicopter</description>
          <offered_by>U03</offered_by>
          <start_date>1999-05-05</start_date>
          <end_date>1999-05-25</end_date>
          <reserve_price>50000</reserve_price>
        </item_tuple>
        <item_tuple>
          <itemno>1007</itemno>
          <description>Racing Bicycle</description>
          <offered_by>U04</offered_by>
          <start_date>1999-01-20</start_date>
          <end_date>1999-02-20</end_date>
          <reserve_price>200</reserve_price>
        </item_tuple>
        <item_tuple>
          <itemno>1008</itemno>
          <description>Broken Bicycle</description>
          <offered_by>U01</offered_by>
          <start_date>1999-02-05</start_date>
          <end_date>1999-03-06</end_date>
          <reserve_price>25</reserve_price>
        </item_tuple>
      </items>

    Dim bids As XDocument = _
      <?xml version="1.0"?>
      <bids>
        <bid_tuple>
          <userid>U02</userid>
          <itemno>1001</itemno>
          <bid>35</bid>
          <bid_date>1999-01-07</bid_date>
        </bid_tuple>
        <bid_tuple>
          <userid>U04</userid>
          <itemno>1001</itemno>
          <bid>40</bid>
          <bid_date>1999-01-08</bid_date>
        </bid_tuple>
        <bid_tuple>
          <userid>U02</userid>
          <itemno>1001</itemno>
          <bid>45</bid>
          <bid_date>1999-01-11</bid_date>
        </bid_tuple>
        <bid_tuple>
          <userid>U04</userid>
          <itemno>1001</itemno>
          <bid>50</bid>
          <bid_date>1999-01-13</bid_date>
        </bid_tuple>
        <bid_tuple>
          <userid>U02</userid>
          <itemno>1001</itemno>
          <bid>55</bid>
          <bid_date>1999-01-15</bid_date>
        </bid_tuple>
        <bid_tuple>
          <userid>U01</userid>
          <itemno>1002</itemno>
          <bid>400</bid>
          <bid_date>1999-02-14</bid_date>
        </bid_tuple>
        <bid_tuple>
          <userid>U02</userid>
          <itemno>1002</itemno>
          <bid>600</bid>
          <bid_date>1999-02-16</bid_date>
        </bid_tuple>
        <bid_tuple>
          <userid>U03</userid>
          <itemno>1002</itemno>
          <bid>800</bid>
          <bid_date>1999-02-17</bid_date>
        </bid_tuple>
        <bid_tuple>
          <userid>U04</userid>
          <itemno>1002</itemno>
          <bid>1000</bid>
          <bid_date>1999-02-25</bid_date>
        </bid_tuple>
        <bid_tuple>
          <userid>U02</userid>
          <itemno>1002</itemno>
          <bid>1200</bid>
          <bid_date>1999-03-02</bid_date>
        </bid_tuple>
        <bid_tuple>
          <userid>U04</userid>
          <itemno>1003</itemno>
          <bid>15</bid>
          <bid_date>1999-01-22</bid_date>
        </bid_tuple>
        <bid_tuple>
          <userid>U05</userid>
          <itemno>1003</itemno>
          <bid>20</bid>
          <bid_date>1999-02-03</bid_date>
        </bid_tuple>
        <bid_tuple>
          <userid>U01</userid>
          <itemno>1004</itemno>
          <bid>40</bid>
          <bid_date>1999-03-05</bid_date>
        </bid_tuple>
        <bid_tuple>
          <userid>U03</userid>
          <itemno>1007</itemno>
          <bid>175</bid>
          <bid_date>1999-01-25</bid_date>
        </bid_tuple>
        <bid_tuple>
          <userid>U05</userid>
          <itemno>1007</itemno>
          <bid>200</bid>
          <bid_date>1999-02-08</bid_date>
        </bid_tuple>
        <bid_tuple>
          <userid>U04</userid>
          <itemno>1007</itemno>
          <bid>225</bid>
          <bid_date>1999-02-12</bid_date>
        </bid_tuple>
      </bids>

    'Dim biddata = _
    '  From b In bids.Descendants("bid_tuple") _
    '    Where (CDbl(b.Element("bid"))) > 50 _
    '    Join u In users.Descendants("user_tuple") _
    '      On (CStr(b.Element("userid"))) _
    '        Equals (CStr(u.Element("userid"))) _
    '    Join i In items.Descendants("item_tuple") _
    '      On (CStr(b.Element("itemno"))) _
    '        Equals (CStr(i.Element("itemno"))) _
    '    Select New With { _
    '       Key .Item = (CStr(b.Element("itemno"))), _
    '           Key .Description = (CStr(i.Element("description"))), _
    '           Key .User = (CStr(u.Element("name"))), _
    '           Key .Date = (CStr(b.Element("bid_date"))), _
    '           Key .Price = (CDbl(b.Element("bid")))}

    'Dim biddata = _
    '  From b In bids.Descendants("bid_tuple") _
    '  Where (CDbl(b.Element("bid"))) > 50 _
    '  Join u In users.Descendants("user_tuple") _
    '  On b.Element("userid").Value Equals u.Element("userid").Value _
    '  Join i In items.Descendants("item_tuple") _
    '  On b.Element("itemno").Value Equals i.Element("itemno").Value _
    '  Select New With { _
    '     .Item = b.Element("itemno").Value, _
    '     .Description = i.Element("description").Value, _
    '     .User = u.Element("name").Value, _
    '     .Date = b.Element("bid_date").Value, _
    '     .Price = (CDbl(b.Element("bid")))}

    Dim biddata = _
      From b In bids.Descendants("bid_tuple") _
      Where (CDbl(b.Element("bid"))) > 50 _
      Join u In users.Descendants("user_tuple") _
      On b.Element("userid").Value Equals u.Element("userid").Value _
      Join i In items.Descendants("item_tuple") _
      On b.Element("itemno").Value Equals i.Element("itemno").Value _
      Select New With { _
        .Item = b.Element("itemno").Value, _
        .Description = i.Element("description").Value, _
        .User = u.Element("name").Value, _
        .Date = b.Element("bid_date").Value, _
        .Price = (CDbl(b.Element("bid")))}

    Console.WriteLine("{0,-12} {1,-12} {2,-6} {3,-14} {4,10}", _
      "Date", "User", "Item", "Description", "Price")

    Console.WriteLine("==========================================================")

    For Each bd In biddata
      Console.WriteLine("{0,-12} {1,-12} {2,-6} {3,-14} {4,10:C}", _
        bd.Date, _
        bd.User, _
        bd.Item, _
        bd.Description, _
        bd.Price)
    Next bd

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing9_5()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xsl As String = _
      "<xsl:stylesheet version='1.0' " & vbCrLf & _
      "xmlns:xsl='http://www.w3.org/1999/XSL/Transform'>" & vbCrLf & _
      "      <xsl:template match='//BookParticipants'>" & vbCrLf & _
      "        <html>" & vbCrLf & _
      "          <body>" & vbCrLf & _
      "          <h1>Book Participants</h1>" & vbCrLf & _
      "          <table>" & vbCrLf & _
      "            <tr align='left'>" & vbCrLf & _
      "              <th>Role</th>" & vbCrLf & _
      "              <th>First Name</th>" & vbCrLf & _
      "              <th>Last Name</th>" & vbCrLf & _
      "            </tr>" & vbCrLf & _
      "            <xsl:apply-templates></xsl:apply-templates>" & vbCrLf & _
      "          </table>" & vbCrLf & _
      "          </body>" & vbCrLf & _
      "        </html>" & vbCrLf & _
      "      </xsl:template>" & vbCrLf & _
      "      <xsl:template match='BookParticipant'>" & vbCrLf & _
      "        <tr>" & vbCrLf & _
      "          <td><xsl:value-of select='@type'/></td>" & vbCrLf & _
      "          <td><xsl:value-of select='FirstName'/></td>" & vbCrLf & _
      "          <td><xsl:value-of select='LastName'/></td>" & vbCrLf & _
      "        </tr>" & vbCrLf & _
      "      </xsl:template>" & vbCrLf & _
      "    </xsl:stylesheet>"

    Dim xDocument As XDocument = _
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

    Dim transformedDoc As New XDocument()
    Using writer As XmlWriter = transformedDoc.CreateWriter()
      Dim transform As New XslCompiledTransform()
      transform.Load(XmlReader.Create(New StringReader(xsl)))
      transform.Transform(xDocument.CreateReader(), writer)
    End Using
    Console.WriteLine(transformedDoc)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing9_6()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument As XDocument = _
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

    Console.WriteLine("Here is the original XML document:")
    Console.WriteLine("{0}{1}{1}", xDocument, vbCrLf)

    Dim xTransDocument As New XDocument( _
      New XElement("MediaParticipants", _
        New XAttribute("type", "book"), _
        xDocument.Element("BookParticipants").Elements("BookParticipant") _
          .Select(Function(e) New XElement("Participant", _
            New XAttribute("Role", e.Attribute("type").Value), _
            New XAttribute("Name", e.Element("FirstName").Value & " " & _
              e.Element("LastName").Value)))))

    Console.WriteLine("Here is the transformed XML document:")
    Console.WriteLine(xTransDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing9_7()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xElement As New XElement("RootElement", Helper())
    Console.WriteLine(xElement)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing9_8()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim elements As IEnumerable(Of XElement) = _
      New XElement() _
        {<Element>A</Element>, _
         <Element>B</Element>}

    Dim xElement As New XElement("RootElement", _
                                  elements.Select(Function(e) If(e.Value <> "A", _
                                    New XElement(e.Name, e.Value), Nothing)))

    Console.WriteLine(xElement)


    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing9_9()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim elements As IEnumerable(Of XElement) = _
      New XElement() { _
        <BookParticipant>
          <Name>Dennis Hayes</Name>
          <Book>Pro LINQ: Language Integrated Query in VB 2008</Book>
        </BookParticipant>, _
        <BookParticipant>
          <Name>John Q. Public</Name>
        </BookParticipant>}

    Dim xElement As New XElement("BookParticipants", _
                                   elements.Select(Function(e) New XElement( _
                                     e.Name, _
                                       New XElement(e.Element("Name").Name, _
                                                      e.Element("Name").Value), _
                                       New XElement("Books", e.Elements("Book")))))

    Console.WriteLine(xElement)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing9_10()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim elements As IEnumerable(Of XElement) = _
      New XElement() { _
        <BookParticipant>
          <Name>Dennis Hayes</Name>
          <Book>Pro LINQ: Language Integrated Query in VB 2008</Book>
        </BookParticipant>, _
        <BookParticipant>
          <Name>John Q. Public</Name>
        </BookParticipant>}

    Dim xElement As New XElement("BookParticipants", _
                                   elements.Select(Function(e) New XElement( _
                                     e.Name, _
                                       New XElement(e.Element("Name").Name, _
                                                      e.Element("Name").Value), _
                                       If(e.Elements("Book").Any(), _
                                         New XElement("Books", _
                                           e.Elements("Book")), Nothing))))

    Console.WriteLine(XElement)


    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing9_11()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument As XDocument = _
      <?xml version="1.0"?>
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
          <Nickname>SCCatman</Nickname>
          <Nickname>Null Pointer</Nickname>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Console.WriteLine("Here is the original XML document:")
    Console.WriteLine("{0}{1}{1}", xDocument, vbCrLf)

    Dim xTransDocument As New XDocument(New XElement("BookParticipants", _
      xDocument.Element("BookParticipants").Elements("BookParticipant") _
        .Select(Function(e) New Object() { _
          New XComment(" BookParticipant "), _
          New XElement("FirstName", e.Element("FirstName").Value), _
          New XElement("LastName", e.Element("LastName").Value), _
          e.Elements("Nickname")})))

    Console.WriteLine("Here is the transformed XML document:")
    Console.WriteLine(xTransDocument)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing9_12()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument As XDocument = _
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

    Console.WriteLine("Here is the source XML document:")
    Console.WriteLine("{0}{1}{1}", xDocument, vbCrLf)

    xDocument.Save("bookparticipants.xml")

    Dim infer As New XmlSchemaInference()
    Dim schemaSet As XmlSchemaSet = _
      infer.InferSchema(New XmlTextReader("bookparticipants.xml"))

    'Dim w As XmlWriter = XmlWriter.Create("bookparticipants.xsd")
    Using w As XmlWriter = XmlWriter.Create("bookparticipants.xsd")
      For Each schema As XmlSchema In schemaSet.Schemas()
        schema.Write(w)
      Next schema
    End Using
    'w.Close()

    Dim newDocument As XDocument = xDocument.Load("bookparticipants.xsd")
    Console.WriteLine("Here is the schema:")
    Console.WriteLine("{0}{1}{1}", newDocument, vbCrLf)
    'Console.WriteLine("{0}{1}{1}", newDocument, System.Environment.NewLine)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing9_13()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument As XDocument = _
      <?xml version="1.0"?>
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <MiddleInitial>E</MiddleInitial>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Console.WriteLine("Here is the source XML document:")
    Console.WriteLine("{0}{1}{1}", xDocument, vbCrLf)

    Dim schemaSet As New XmlSchemaSet()
    schemaSet.Add(Nothing, "bookparticipants.xsd")

    Try
      xDocument.Validate(schemaSet, Nothing)
      Console.WriteLine("Document validated successfully.")
    Catch ex As XmlSchemaValidationException
      Console.WriteLine("Exception occurred: {0}", ex.Message)
      Console.WriteLine("Document validated unsuccessfully.")
    End Try

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing9_14()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument As XDocument = _
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

    Console.WriteLine("Here is the source XML document:")
    Console.WriteLine("{0}{1}{1}", xDocument, vbCrLf)

    Dim schemaSet As New XmlSchemaSet()
    schemaSet.Add(Nothing, "bookparticipants.xsd")

    Try
      xDocument.Validate(schemaSet, AddressOf MyValidationEventHandler)
      Console.WriteLine("Document validated successfully.")
    Catch ex As XmlSchemaValidationException
      Console.WriteLine("Exception occurred: {0}", ex.Message)
      Console.WriteLine("Document validated unsuccessfully.")
    End Try

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing9_15()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument As XDocument = _
      <?xml version="1.0"?>
      <BookParticipants>
        <BookParticipant type="Author" language="English">
          <FirstName>Dennis</FirstName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Console.WriteLine("Here is the source XML document:")
    Console.WriteLine("{0}{1}{1}", xDocument, vbCrLf)

    Dim schemaSet As New XmlSchemaSet()
    schemaSet.Add(Nothing, "bookparticipants.xsd")

    Try
      xDocument.Validate(schemaSet, AddressOf MyValidationEventHandler)
      Console.WriteLine("Document validated successfully.")
    Catch ex As Exception
      Console.WriteLine("Exception occurred: {0}", ex.Message)
      Console.WriteLine("Document validated unsuccessfully.")
    End Try

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing9_16()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument As XDocument = _
      <?xml version="1.0"?>
      <BookParticipants>
        <BookParticipant type="Author">
          <FirstName>Dennis</FirstName>
          <MiddleName>Eugene</MiddleName>
          <LastName>Hayes</LastName>
        </BookParticipant>
        <BookParticipant type="Editor">
          <FirstName>Ewan</FirstName>
          <LastName>Buckingham</LastName>
        </BookParticipant>
      </BookParticipants>

    Console.WriteLine("Here is the source XML document:")
    Console.WriteLine("{0}{1}{1}", xDocument, System.Environment.NewLine)

    Dim schemaSet As New XmlSchemaSet()
    schemaSet.Add(Nothing, "bookparticipants.xsd")
    Valid = True
    xDocument.Validate(schemaSet, AddressOf MyValidationEventHandler2, True)

    For Each element As XElement In xDocument.Descendants()
      Console.WriteLine( _
        "Element {0} is {1}", _
        element.Name, _
        element.GetSchemaInfo().Validity)

      Dim se As XmlSchemaElement = element.GetSchemaInfo().SchemaElement
      If se IsNot Nothing Then
        Console.WriteLine( _
          "Schema element {0} must have " & _
            "MinOccurs = {1} and MaxOccurs = {2}{3}", _
          se.Name, _
          se.MinOccurs, _
          se.MaxOccurs, _
          System.Environment.NewLine)
      Else
        ' Invalid elements will not have a SchemaElement.
        Console.WriteLine()
      End If
    Next element

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing9_17()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim schema = _
      <?xml version="1.0" encoding="utf-8"?>
      <xs:schema attributeFormDefault="unqualified" elementFormDefault="qualified"
        xmlns:xs="http://www.w3.org/2001/XMLSchema">
        <xs:element name="BookParticipants">
          <xs:complexType>
            <xs:sequence>
              <xs:element maxOccurs="unbounded" name="BookParticipant">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name="FirstName" type="xs:string"/>
                    <xs:element minOccurs="0" name="MiddleInitial"
                      type="xs:string"/>
                    <xs:element name="LastName" type="xs:string"/>
                  </xs:sequence>
                  <xs:attribute name="type" type="xs:string" use="required"/>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:schema>

    '<?xml version='1.0' encoding='utf-8'?>
    '<xs:schema attributeFormDefault='unqualified' elementFormDefault='qualified'
    '  xmlns:xs='http://www.w3.org/2001/XMLSchema'>
    '  <xs:element name='BookParticipants'>
    '    <xs:complexType>
    '      <xs:sequence>
    '        <xs:element maxOccurs='unbounded' name='BookParticipant'>
    '          <xs:complexType>
    '            <xs:sequence>
    '              <xs:element name='FirstName' type='xs:string'/>
    '              <xs:element minOccurs='0' name='MiddleInitial'
    '                type='xs:string'/>
    '              <xs:element name='LastName' type='xs:string'/>
    '            </xs:sequence>
    '            <xs:attribute name='type' type='xs:string' use='required'/>
    '          </xs:complexType>
    '        </xs:element>
    '      </xs:sequence>
    '    </xs:complexType>
    '  </xs:element>
    '</xs:schema>

    Dim schemaSet As New XmlSchemaSet()
    schemaSet.Add("", XmlReader.Create(New StringReader(schema.ToString())))

    Dim xDocument As XDocument = _
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

    Console.WriteLine("Here is the source XML document:")
    Console.WriteLine("{0}{1}{1}", xDocument, System.Environment.NewLine)

    Valid = True
    xDocument.Validate(schemaSet, AddressOf MyValidationEventHandler2, True)

    Console.WriteLine( _
      "Document validated {0}.{1}", _
      If(Valid, "successfully", "unsuccessfully"), vbCrLf)

    'Dim bookParticipant As XElement = xDocument.Descendants("BookParticipant") _
    '  .Where(Function(e) (CStr(e.Element("FirstName"))).Equals("Dennis")).First()

    Dim bookParticipant As XElement = xDocument.Descendants("BookParticipant") _
      .Where(Function(e) e.Element("FirstName").Value.Equals("Dennis")).First()

    bookParticipant.Element("FirstName").AddAfterSelf( _
      New XElement("MiddleInitial", "E"))

    Valid = True
    bookParticipant.Validate( _
      bookParticipant.GetSchemaInfo().SchemaElement, _
      schemaSet, _
      AddressOf MyValidationEventHandler2, _
      True)

    Console.WriteLine( _
      "Element validated {0}.{1}", _
      If(Valid, "successfully", "unsuccessfully"), vbCrLf)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing9_18()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim schema = _
      <?xml version="1.0" encoding="utf-8"?>
      <xs:schema attributeFormDefault="unqualified" elementFormDefault="qualified"
        xmlns:xs="http://www.w3.org/2001/XMLSchema">
        <xs:element name="BookParticipants">
          <xs:complexType>
            <xs:sequence>
              <xs:element maxOccurs="unbounded" name="BookParticipant">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name="FirstName" type="xs:string"/>
                    <xs:element minOccurs="0" name="MiddleInitial"
                      type="xs:string"/>
                    <xs:element name="LastName" type="xs:string"/>
                  </xs:sequence>
                  <xs:attribute name="type" type="xs:string" use="required"/>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:schema>

    '<?xml version='1.0' encoding='utf-8'?>
    '<xs:schema attributeFormDefault='unqualified' elementFormDefault='qualified'
    '  xmlns:xs='http://www.w3.org/2001/XMLSchema'>
    '  <xs:element name='BookParticipants'>
    '    <xs:complexType>
    '      <xs:sequence>
    '        <xs:element maxOccurs='unbounded' name='BookParticipant'>
    '          <xs:complexType>
    '            <xs:sequence>
    '              <xs:element name='FirstName' type='xs:string'/>
    '              <xs:element minOccurs='0' name='MiddleInitial'
    '                type='xs:string'/>
    '              <xs:element name='LastName' type='xs:string'/>
    '            </xs:sequence>
    '            <xs:attribute name='type' type='xs:string' use='required'/>
    '          </xs:complexType>
    '        </xs:element>
    '      </xs:sequence>
    '    </xs:complexType>
    '  </xs:element>
    '</xs:schema>

    Dim schemaSet As New XmlSchemaSet()
    schemaSet.Add("", XmlReader.Create(New StringReader(schema.ToString())))

    Dim xDocument As XDocument = _
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

    Console.WriteLine("Here is the source XML document:")
    Console.WriteLine("{0}{1}{1}", xDocument, System.Environment.NewLine)

    Valid = True
    xDocument.Validate(schemaSet, AddressOf MyValidationEventHandler2, True)

    Console.WriteLine( _
      "Document validated {0}.{1}", _
      If(Valid, "successfully", "unsuccessfully"), vbCrLf)

    'Dim bookParticipant As XElement = xDocument.Descendants( _
    '"BookParticipant") _
    '.Where(Function(e) _
    '(CStr(e.Element("FirstName"))) _
    '.Equals("Dennis")).First()

    Dim bookParticipant As XElement = xDocument.Descendants("BookParticipant") _
      .Where(Function(e) e.Element("FirstName").Value.Equals("Dennis")).First()

    bookParticipant.Element("FirstName"). _
      AddAfterSelf(New XElement("MiddleName", "Eugene"))

    Valid = True
    bookParticipant.Validate( _
      bookParticipant.GetSchemaInfo().SchemaElement, _
      schemaSet, _
      AddressOf MyValidationEventHandler2, _
      True)

    Console.WriteLine( _
      "Element validated {0}.{1}", _
      If(Valid, "successfully", "unsuccessfully"), vbCrLf)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing9_19()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    Dim xDocument As XDocument = _
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

    Dim bookParticipant As XElement = xDocument.XPathSelectElement( _
      "//BookParticipants/BookParticipant[FirstName='Dennis']")

    Console.WriteLine(bookParticipant)

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing9_()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)



    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Function Helper() As IEnumerable(Of XElement)
    Dim elements() As XElement = {<Element>A</Element>, <Element>B</Element>}
    Return (elements)
  End Function

  Private Sub MyValidationEventHandler(ByVal o As Object, ByVal vea As  _
                               ValidationEventArgs)

    Console.WriteLine("A validation error occurred processing object type {0}.", _
                       o.GetType().Name)

    Console.WriteLine(vea.Message)
    Throw (New Exception(vea.Message))
  End Sub

  Private Sub MyValidationEventHandler2( _
      ByVal o As Object, _
      ByVal vea As ValidationEventArgs)

    Console.WriteLine( _
      "A validation error occurred processing object type {0}.", _
      o.GetType().Name)

    Console.WriteLine("{0}{1}", vea.Message, vbCrLf)
    Valid = False
  End Sub
End Module
