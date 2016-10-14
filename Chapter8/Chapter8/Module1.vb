Module Module1

    Sub Main()
        ' Uncomment the functions you want to call.
        'YourTest()

    'Listing8_1()
        'Listing8_2()
    'Listing8_3()
        'Listing8_4()
        'Listing8_5()
        'Listing8_6()
        'Listing8_7()
    Listing8_8()
        'Listing8_9()
        'Listing8_10()
        'Listing8_11()
        'Listing8_12()
        'Listing8_13()
        'Listing8_14()
        'Listing8_15()
        'Listing8_16()
        'Listing8_17()
        'Listing8_18()
        'Listing8_19()
        'Listing8_20()

    End Sub

    Sub YourTest()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        ' Do whatever you want in here.

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing8_1()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim xDocument As XDocument = <?xml version="1.0"?>
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
      xDocument...<FirstName>
    'xDocument.Element("BookParticipants").Descendants("FirstName")

        '  First, I will display the source elements.
        For Each element As XElement In elements
            Console.WriteLine _
                ("Source element: {0} : value = {1}", element.Name, element.Value)
        Next element

        '  Now, I will display the ancestor elements for each source element.
        For Each element As XElement In elements.Ancestors()
            Console.WriteLine("Ancestor element: {0}", element.Name)
        Next element

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing8_2()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim xDocument As XDocument = <?xml version="1.0"?>
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
          xDocument.Element("BookParticipants").Descendants("FirstName")

        '  First, I will display the source elements.
        For Each element As XElement In elements
            Console.WriteLine _
              ("Source element: {0} : value = {1}", element.Name, element.Value)
        Next element

        For Each element As XElement In elements
            '  Call the Ancestors method on each element.
            For Each e As XElement In element.Ancestors()
                '  Now, I will display the ancestor elements for each source element.
                Console.WriteLine("Ancestor element: {0}", e.Name)
            Next e
        Next element

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing8_3()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim xDocument As XDocument = <?xml version="1.0"?>
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

    'In xDocument.Element("BookParticipants").Descendants("FirstName").Ancestors()
    For Each element As XElement In xDocument...<FirstName>.Ancestors()
      Console.WriteLine("Ancestor element: {0}", element.Name)
    Next element

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing8_4()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim xDocument As XDocument = <?xml version="1.0"?>
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
          xDocument.Element("BookParticipants").Descendants("FirstName")

        '  First, I will display the source elements.
        For Each element As XElement In elements
            Console.WriteLine _
                ("Source element: {0} : value = {1}", element.Name, element.Value)
        Next element

        '  Now, I will display the ancestor elements for each source element.
        For Each element As XElement In elements.Ancestors("BookParticipant")
            Console.WriteLine("Ancestor element: {0}", element.Name)
        Next element

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing8_5()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim xDocument As XDocument = <?xml version="1.0"?>
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
            xDocument.Element("BookParticipants").Descendants("FirstName")

        '  First, I will display the source elements.
        For Each element As XElement In elements
            Console.WriteLine _
                ("Source element: {0} : value = {1}", element.Name, element.Value)
        Next element

        '  Now, I will display the ancestor elements for each source element.
        For Each element As XElement In elements.AncestorsAndSelf()
            Console.WriteLine("Ancestor element: {0}", element.Name)
        Next element

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing8_6()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim xDocument As XDocument = <?xml version="1.0"?>
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
            xDocument.Element("BookParticipants").Descendants("FirstName")

        '  First, I will display the source elements.
        For Each element As XElement In elements
            Console.WriteLine _
                ("Source element: {0} : value = {1}", element.Name, element.Value)
        Next element

        '  Now, I will display the ancestor elements for each source element.
        For Each element As XElement In elements.AncestorsAndSelf("BookParticipant")
            Console.WriteLine("Ancestor element: {0}", element.Name)
        Next element

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing8_7()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim xDocument As XDocument = <?xml version="1.0"?>
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
            xDocument.Element("BookParticipants").Elements("BookParticipant")

        '  First, I will display the source elements.
        For Each element As XElement In elements
            Console.WriteLine _
                ("Source element: {0} : value = {1}", element.Name, element.Value)
        Next element

        '  Now, I will display each source element's attributes.
        For Each attribute As XAttribute In elements.Attributes()
            Console.WriteLine("Attribute: {0} : value = {1}", attribute.Name, attribute.Value)
        Next attribute

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing8_8()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim xDocument As XDocument = <?xml version="1.0"?>
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
            xDocument.Element("BookParticipants").Elements("BookParticipant")

        '  First, I will display the source elements.
        For Each element As XElement In elements
            Console.WriteLine _
                ("Source element: {0} : value = {1}", element.Name, element.Value)
        Next element

        '  Now, I will display each source element's attributes.
    For Each attribute As XAttribute In elements.Attributes("type")
      Console.WriteLine _
      ("Attribute: {0} : value = {1}", attribute.Name, attribute.Value)
    Next attribute

    Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing8_9()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim xDocument As XDocument = <?xml version="1.0"?>
                                     <BookParticipants>
                                         <BookParticipant type="Author">
                                             <!--This is a new author-->
                                             <FirstName>Dennis</FirstName>
                                             <LastName>Hayes</LastName>
                                         </BookParticipant>
                                         <BookParticipant type="Editor">
                                             <FirstName>Ewan</FirstName>
                                             <LastName>Buckingham</LastName>
                                         </BookParticipant>
                                     </BookParticipants>

        Dim elements As IEnumerable(Of XElement) = _
            xDocument.Element("BookParticipants").Elements("BookParticipant")

        '  First, I will display the source elements.
        For Each element As XElement In elements
            Console.WriteLine _
                ("Source element: {0} : value = {1}", element.Name, element.Value)
        Next element

        '  Now, I will display each source element's descendant nodes.
        For Each node As XNode In elements.DescendantNodes()
            Console.WriteLine("Descendant node: {0}", node)
        Next node

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing8_10()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim xDocument As XDocument = <?xml version="1.0"?>
                                     <BookParticipants>
                                         <BookParticipant type="Author">
                                             <!--This is a new author-->
                                             <FirstName>Dennis</FirstName>
                                             <LastName>Hayes</LastName>
                                         </BookParticipant>
                                         <BookParticipant type="Editor">
                                             <FirstName>Ewan</FirstName>
                                             <LastName>Buckingham</LastName>
                                         </BookParticipant>
                                     </BookParticipants>

        Dim elements As IEnumerable(Of XElement) = _
            xDocument.Element("BookParticipants").Elements("BookParticipant")

        '  First, I will display the source elements.
        For Each element As XElement In elements
            Console.WriteLine _
                ("Source element: {0} : value = {1}", element.Name, element.Value)
        Next element

        '  Now, I will display each source element's descendant nodes.
        For Each node As XNode In elements.DescendantNodesAndSelf()
            Console.WriteLine("Descendant node: {0}", node)
        Next node

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing8_11()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim xDocument As XDocument = <?xml version="1.0"?>
                                     <BookParticipants>
                                         <BookParticipant type="Author">
                                             <!--This is a new author-->
                                             <FirstName>Dennis</FirstName>
                                             <LastName>Hayes</LastName>
                                         </BookParticipant>
                                         <BookParticipant type="Editor">
                                             <FirstName>Ewan</FirstName>
                                             <LastName>Buckingham</LastName>
                                         </BookParticipant>
                                     </BookParticipants>

        Dim elements As IEnumerable(Of XElement) = _
            xDocument.Element("BookParticipants").Elements("BookParticipant")

        '  First, I will display the source elements.
        For Each element As XElement In elements
            Console.WriteLine( _
                "Source element: {0} : value = {1}", element.Name, element.Value)
        Next element

        '  Now, I will display each source element's descendant elements.
        For Each element As XElement In elements.Descendants()
            Console.WriteLine("Descendant element: {0}", element)
        Next element

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing8_12()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim xDocument As XDocument = <?xml version="1.0"?>
                                     <BookParticipants>
                                         <BookParticipant type="Author">
                                             <!--This is a new author-->
                                             <FirstName>Dennis</FirstName>
                                             <LastName>Hayes</LastName>
                                         </BookParticipant>
                                         <BookParticipant type="Editor">
                                             <FirstName>Ewan</FirstName>
                                             <LastName>Buckingham</LastName>
                                         </BookParticipant>
                                     </BookParticipants>

        Dim elements As IEnumerable(Of XElement) = _
            xDocument.Element("BookParticipants").Elements("BookParticipant")

        '  First, I will display the source elements.
        For Each element As XElement In elements
            Console.WriteLine _
                ("Source element: {0} : value = {1}", element.Name, element.Value)
        Next element

        '  Now, I will display each source element's descendant elements.
        For Each element As XElement In elements.Descendants("LastName")
            Console.WriteLine("Descendant element: {0}", element)
        Next element

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing8_13()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim xDocument As XDocument = <?xml version="1.0"?>
                                     <BookParticipants>
                                         <BookParticipant type="Author">
                                             <!--This is a new author-->
                                             <FirstName>Dennis</FirstName>
                                             <LastName>Hayes</LastName>
                                         </BookParticipant>
                                         <BookParticipant type="Editor">
                                             <FirstName>Ewan</FirstName>
                                             <LastName>Buckingham</LastName>
                                         </BookParticipant>
                                     </BookParticipants>

        Dim elements As IEnumerable(Of XElement) = _
            xDocument.Element("BookParticipants").Elements("BookParticipant")

        '  First, I will display the source elements.
        For Each element As XElement In elements
            Console.WriteLine _
                ("Source element: {0} : value = {1}", element.Name, element.Value)
        Next element

        '  Now, I will display each source element's descendant elements.
        For Each element As XElement In elements.DescendantsAndSelf()
            Console.WriteLine("Descendant element: {0}", element)
        Next element

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing8_14()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim xDocument As XDocument = <?xml version="1.0"?>
                                     <BookParticipants>
                                         <BookParticipant type="Author">
                                             <!--This is a new author-->
                                             <FirstName>Dennis</FirstName>
                                             <LastName>Hayes</LastName>
                                         </BookParticipant>
                                         <BookParticipant type="Editor">
                                             <FirstName>Ewan</FirstName>
                                             <LastName>Buckingham</LastName>
                                         </BookParticipant>
                                     </BookParticipants>

        Dim elements As IEnumerable(Of XElement) = _
            xDocument.Element("BookParticipants").Elements("BookParticipant")

        '  First, I will display the source elements.
        For Each element As XElement In elements
            Console.WriteLine _
                ("Source element: {0} : value = {1}", element.Name, element.Value)
        Next element

        '  Now, I will display each source element's descendant elements.
        For Each element As XElement In elements.DescendantsAndSelf("LastName")
            Console.WriteLine("Descendant element: {0}", element)
        Next element

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing8_15()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim xDocument As XDocument = <?xml version="1.0"?>
                                     <BookParticipants>
                                         <BookParticipant type="Author">
                                             <!--This is a new author-->
                                             <FirstName>Dennis</FirstName>
                                             <LastName>Hayes</LastName>
                                         </BookParticipant>
                                         <BookParticipant type="Editor">
                                             <FirstName>Ewan</FirstName>
                                             <LastName>Buckingham</LastName>
                                         </BookParticipant>
                                     </BookParticipants>

        Dim elements As IEnumerable(Of XElement) = _
            xDocument.Element("BookParticipants").Elements("BookParticipant")

        '  First, I will display the source elements.
        For Each element As XElement In elements
            Console.WriteLine _
                ("Source element: {0} : value = {1}", element.Name, element.Value)
        Next element

        '  Now, I will display each source element's elements.
        For Each element As XElement In elements.Elements()
            Console.WriteLine("Child element: {0}", element)
        Next element

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing8_16()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim xDocument As XDocument = <?xml version="1.0"?>
                                     <BookParticipants>
                                         <BookParticipant type="Author">
                                             <!--This is a new author-->
                                             <FirstName>Dennis</FirstName>
                                             <LastName>Hayes</LastName>
                                         </BookParticipant>
                                         <BookParticipant type="Editor">
                                             <FirstName>Ewan</FirstName>
                                             <LastName>Buckingham</LastName>
                                         </BookParticipant>
                                     </BookParticipants>

        Dim elements As IEnumerable(Of XElement) = _
            xDocument.Element("BookParticipants").Elements("BookParticipant")

        '  First, I will display the source elements.
        For Each element As XElement In elements
            Console.WriteLine _
                ("Source element: {0} : value = {1}", element.Name, element.Value)
        Next element

        '  Now, I will display each source element's elements.
        For Each element As XElement In elements.Elements("LastName")
            Console.WriteLine("Child element: {0}", element)
        Next element

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing8_17()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim xDocument As XDocument = <?xml version="1.0"?>
                                     <BookParticipants>
                                         <BookParticipant type="Author">
                                             <!--This is a new author-->
                                             <FirstName>Dennis</FirstName>
                                             <LastName>Hayes</LastName>
                                         </BookParticipant>
                                         <BookParticipant type="Editor">
                                             <FirstName>Ewan</FirstName>
                                             <LastName>Buckingham</LastName>
                                         </BookParticipant>
                                     </BookParticipants>

        Dim nodes As IEnumerable(Of XNode) = _
            xDocument.Element("BookParticipants") _
                .Elements("BookParticipant").Nodes().Reverse()

        '  First, I will display the source nodes.
        For Each node As XNode In nodes
            Console.WriteLine("Source node: {0}", node)
        Next node

        '  Now, I will display each source nodes's child nodes.
        For Each node As XNode In nodes.InDocumentOrder()
            Console.WriteLine("Ordered node: {0}", node)
        Next node

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing8_18()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim xDocument As XDocument = <?xml version="1.0"?>
                                     <BookParticipants>
                                         <BookParticipant type="Author">
                                             <!--This is a new author-->
                                             <FirstName>Dennis</FirstName>
                                             <LastName>Hayes</LastName>
                                         </BookParticipant>
                                         <BookParticipant type="Editor">
                                             <FirstName>Ewan</FirstName>
                                             <LastName>Buckingham</LastName>
                                         </BookParticipant>
                                     </BookParticipants>

        Dim elements As IEnumerable(Of XElement) = _
            xDocument.Element("BookParticipants").Elements("BookParticipant")

        '  First, I will display the source elements.
        For Each element As XElement In elements
            Console.WriteLine _
                ("Source element: {0} : value = {1}", element.Name, element.Value)
        Next element

        '  Now, I will display each source element's child nodes.
        For Each node As XNode In elements.Nodes()
            Console.WriteLine("Child node: {0}", node)
        Next node

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing8_19()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim xDocument As XDocument = <?xml version="1.0"?>
                                     <BookParticipants>
                                         <BookParticipant type="Author">
                                             <!--This is a new author-->
                                             <FirstName>Dennis</FirstName>
                                             <LastName>Hayes</LastName>
                                         </BookParticipant>
                                         <BookParticipant type="Editor">
                                             <FirstName>Ewan</FirstName>
                                             <LastName>Buckingham</LastName>
                                         </BookParticipant>
                                     </BookParticipants>

        Dim attributes As IEnumerable(Of XAttribute) = _
            xDocument.Element("BookParticipants").Elements("BookParticipant").Attributes()

        '  First, I will display the source attributes.
        For Each attribute As XAttribute In attributes
            Console.WriteLine("Source attribute: {0} : value = {1}", attribute.Name, attribute.Value)
        Next attribute

        attributes.Remove()

        '  Now, I will display the XML document.
        Console.WriteLine(xDocument)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing8_20()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)

        Dim xDocument As XDocument = <?xml version="1.0"?>
                                     <BookParticipants>
                                         <BookParticipant type="Author">
                                             <!--This is a new author-->
                                             <FirstName>Dennis</FirstName>
                                             <LastName>Hayes</LastName>
                                         </BookParticipant>
                                         <BookParticipant type="Editor">
                                             <FirstName>Ewan</FirstName>
                                             <LastName>Buckingham</LastName>
                                         </BookParticipant>
                                     </BookParticipants>

        Dim comments As IEnumerable(Of XComment) = _
            xDocument.Element("BookParticipants").Elements("BookParticipant") _
                .Nodes().OfType(Of XComment)()

        '  First, I will display the source comments.
        For Each comment As XComment In comments
            Console.WriteLine("Source comment: {0}", comment)
        Next comment

        comments.Remove()

        '  Now, I will display the XML document.
        Console.WriteLine(xDocument)

        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub

    Sub Listing8_()
        Console.WriteLine("{0} : Begin", New StackTrace(0, True).GetFrame(0).GetMethod().Name)


        Console.WriteLine("{0} : End", New StackTrace(0, True).GetFrame(0).GetMethod().Name)
    End Sub


End Module
