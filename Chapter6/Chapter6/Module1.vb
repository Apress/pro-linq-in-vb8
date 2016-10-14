Imports System.Xml

Module Module1

  Sub Main()
    ' Uncomment the functions you want to call.
    'YourTest()

    Listing6_1()

  End Sub

  Sub YourTest()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    ' Do whatever you want in here.

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

  Sub Listing6_1()
    Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

    '  I'll declare some variables I will reuse.
    Dim xmlBookParticipant As XmlElement
    Dim xmlParticipantType As XmlAttribute
    Dim xmlFirstName As XmlElement
    Dim xmlLastName As XmlElement

    '  First, I must build an XML document.
    Dim xmlDoc As New XmlDocument()

    '  I'll create the root element and add it to the document.
    Dim xmlBookParticipants As XmlElement = xmlDoc.CreateElement("BookParticipants")
    xmlDoc.AppendChild(xmlBookParticipants)

    '  I'll create a participant and add it to the book participants list.
    xmlBookParticipant = xmlDoc.CreateElement("BookParticipant")

    xmlParticipantType = xmlDoc.CreateAttribute("type")
    xmlParticipantType.InnerText = "Author"
    xmlBookParticipant.Attributes.Append(xmlParticipantType)

    xmlFirstName = xmlDoc.CreateElement("FirstName")
    xmlFirstName.InnerText = "Dennis"
    xmlBookParticipant.AppendChild(xmlFirstName)

    xmlLastName = xmlDoc.CreateElement("LastName")
    xmlLastName.InnerText = "Hayes"
    xmlBookParticipant.AppendChild(xmlLastName)

    xmlBookParticipants.AppendChild(xmlBookParticipant)

    '  I'll create another participant and add it to the book participants list.
    xmlBookParticipant = xmlDoc.CreateElement("BookParticipant")

    xmlParticipantType = xmlDoc.CreateAttribute("type")
    xmlParticipantType.InnerText = "Editor"
    xmlBookParticipant.Attributes.Append(xmlParticipantType)

    xmlFirstName = xmlDoc.CreateElement("FirstName")
    xmlFirstName.InnerText = "Ewan"
    xmlBookParticipant.AppendChild(xmlFirstName)

    xmlLastName = xmlDoc.CreateElement("LastName")
    xmlLastName.InnerText = "Buckingham"
    xmlBookParticipant.AppendChild(xmlLastName)

    xmlBookParticipants.AppendChild(xmlBookParticipant)

    '  Now, I'll search for authors and display their first and last name.
    Dim authorsList As XmlNodeList = _
      xmlDoc.SelectNodes("BookParticipants/BookParticipant[@type=""Author""]")

    For Each node As XmlNode In authorsList
      Dim firstName As XmlNode = node.SelectSingleNode("FirstName")
      Dim lastName As XmlNode = node.SelectSingleNode("LastName")
      'Console.WriteLine("{0} {1}", firstName, lastName)
      Console.WriteLine("{0} {1}", firstName.ToString(), lastName.ToString())
    Next node

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
  End Sub

End Module
