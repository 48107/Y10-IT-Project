Imports System.Xml '' Import Library to work with XML files
Imports System.IO
Public Class Admin
    Dim intMaxLength As Integer = 16 '' Set a Max Length for Area Names
    Dim intMinLength As Integer = 2 '' Set a Minimum Length for Area Names

    '' Sub-routine to read in Areas from XML doc and populate list box with them
    Private Sub PopulateAreaBox()
        lbxAreas.Items.Clear() '' Ensure listbox is empty to avoid double population

        '' Open XML Document and read in Areas and add to the Listbox
        Dim ReaderControl As XmlReader = XmlReader.Create("Areas.xml")
        Do While ReaderControl.Read
            If ReaderControl.NodeType = XmlNodeType.Element AndAlso ReaderControl.Name = "Name" Then
                lbxAreas.Items.Add(ReaderControl.ReadElementString)  '' Add the Areas to a listbox
            Else
                ReaderControl.Read()
            End If
        Loop
        ReaderControl.Close()  '' Close the XML document
    End Sub

    '' Logic to Return to Homepage
    Private Sub btnHomepage_Click(sender As Object, e As EventArgs) Handles btnHomepage.Click
        Close()
        Form1.Show()
    End Sub

    '' A Function to Return True/False on Whether An Area Name Does Exists Elsewhere
    Private Function AreaNameExists(strAreaName As String) As Boolean
        '' Function to Loop through Each Area and Check if it already exists
        For Each Item In lbxAreas.Items
            If (strAreaName.Replace(" ", "") = Item.ToString.Replace(" ", "")) Then
                Return True '' If the name already exists return the value as such
            End If
        Next
        '' If it doesn't match any other area name return as such
        Return False
    End Function

    '' A Function to Validate an Area Name is within an acceptable length
    Private Function ValidateLength(strName As String, intMaxChars As Integer, intMinChars As Integer) As Boolean
        '' Checks the Length of the name is not more than the max allowable length and not less then the min
        If (Len(strName) > intMaxChars Or Len(strName) < intMinChars) Then
            Return False '' If the name is unnacceptable return as such
        Else
            Return True '' If the name is acceptable return as such
        End If
    End Function

    '' A subroutine to Validate the Input for an Area Name
    Private Function GetAndValidateAreaName() As String
        '' Get The Name for the Area with leading and trailing whitespaces trimmed
        Dim strCheckedName As String = InputBox("What would you like to name the area?").Trim()

        '' Bad code to make Validate Length not skip name exists
        Do While AreaNameExists(strCheckedName) = True Or ValidateLength(strCheckedName, intMaxLength, intMinLength) = False Or strCheckedName.Contains("'")
            '' Checks if a valid Area Name has been inputed and loops until is has
            While AreaNameExists(strCheckedName) = True
                MsgBox("Please Choose a Name That Doesn't Already Exist!")  '' Inform the use to input a new name
                strCheckedName = InputBox("What would you like to name the area?").Trim()  '' Get user input for area name with leading and trailing whitespaces trimmed
            End While
            '' Checks if a valid length for a name has been inputed and loops until it has
            While ValidateLength(strCheckedName, intMaxLength, intMinLength) = False
                MsgBox("Please Choose a Name That is More Than " & intMinLength & " Characters and Less Than " & intMaxLength & " Characters!")  '' Inform the use to input a new name
                strCheckedName = InputBox("What would you like to name the area?").Trim()  '' Get user input for new area name with leading and trailing whitespaces trimmed
            End While
            While strCheckedName.Contains("'")
                MsgBox("Please Choose a Name That Only Contains Alphanumeric Characters!")  '' Inform the use to input a new name
                strCheckedName = InputBox("What would you like to name the area?").Trim()  '' Get user input for area name with leading and trailing whitespaces trimmed
            End While
        Loop

        Return strCheckedName '' Returns the validated name
    End Function

    '' Sub-routine to get the current ticket price and populate it in the price text box
    Private Sub PopulatePriceBox()
        '' Opens the text file and reads the current price
        Dim srdrPrice As StreamReader = File.OpenText("Price.txt")
        Dim dblPrice As Double = srdrPrice.ReadLine
        srdrPrice.Close()

        '' Populates the price text box with the current ticket price
        txtTicketPrice.Text = dblPrice
    End Sub

    '' Logic to, upon Form Load, populate ticket price and areas fields
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' Initial Population of Areas in Aera Listbox
        PopulateAreaBox()
        '' Initial Population of Ticket Price Box
        PopulatePriceBox()
    End Sub

    '' Upon Add Area Button Click: Get input for name and add area entry to XML doc
    Private Sub btnAddArea_Click(sender As Object, e As EventArgs) Handles btnAddArea.Click
        '' Logic to open and access XML document and prepare to add new entry
        Dim xelement As XElement = XElement.Load("Areas.xml")
        Dim Areas As IEnumerable(Of XElement) = xelement.Elements()
        Dim Document As XDocument
        Document = XDocument.Load("Areas.xml")

        '' Get the users input for the name and validate it through the GetAndVal function
        Dim strName As String = GetAndValidateAreaName()

        '' Create the new entry in XML doc
        Dim root = New XElement("Area")
        Dim NameElement = New XElement("Name", strName)

        '' Add the entry to the XML doc
        root.Add(NameElement)
        Document.Root.Add(root)
        Document.Save("Areas.xml")

        '' Update area Listbox with New Entries
        PopulateAreaBox()
    End Sub

    '' Logic to upon clicking the rename button, get input and rename the selected Area
    Private Sub btnRenameArea_Click(sender As Object, e As EventArgs) Handles btnRenameArea.Click
        '' Initial Set-up to Allow Loading Document and Accessing Node
        Dim xmlDocument As XmlDocument = New XmlDocument
        Dim areaNode As XmlNode = Nothing

        '' Get the old area name
        Dim strAreaName As String = lbxAreas.SelectedItem
        '' Validation to ensure the user has selected an area, if not, get them to do it
        If strAreaName Is Nothing Then
            MsgBox("Please select an area!")
            Exit Sub
        End If

        '' Get the users input for the name and validate it through the GetAndVal function
        Dim strNewAreaName As String = GetAndValidateAreaName()

        '' Open the XML document and access the specific area's node
        xmlDocument.Load("Areas.xml")
        areaNode = xmlDocument.SelectSingleNode("/Areas/Area[Name='" & strAreaName & "']")

        '' Rename the Area and Save the XML Dcoument
        areaNode.FirstChild.InnerText = strNewAreaName
        xmlDocument.Save("Areas.xml")

        '' Update Area Listbox with New Names
        PopulateAreaBox()
    End Sub

    '' Upon Clicking Remove Selected Area Button, deletes the selected Area from XML Doc
    Private Sub btnRemoveArea_Click(sender As Object, e As EventArgs) Handles btnRemoveArea.Click
        '' Load the Document In
        Dim xmlDocument As XmlDocument = New XmlDocument
        Dim xmlNode As XmlNode = Nothing
        xmlDocument.Load("Areas.xml")

        '' Find which area is to be deleted and open the node
        Dim strAreaName As String = lbxAreas.SelectedItem
        '' Validation to ensure that the user has selected an area, if not ask to do it
        If strAreaName Is Nothing Then
            MsgBox("Please select an area!")
            Exit Sub
        End If
        xmlNode = xmlDocument.SelectSingleNode("/Areas/Area[Name='" & strAreaName & "']")

        '' Delete the node and save the updated document
        xmlNode.ParentNode.RemoveChild(xmlNode)
        xmlDocument.Save("Areas.xml")

        '' Update Area Listbox with New Names
        PopulateAreaBox()
    End Sub

    Private Sub btnUpdatePrice_Click(sender As Object, e As EventArgs) Handles btnUpdatePrice.Click
        '' Get the updated ticket price and validate it, storing it in a local variable
        If IsNumeric(txtTicketPrice.Text) = False Then '' Checks the inputed value is a number, if not informs the user as such
            MsgBox("Please ensure the ticket price is a number!")
            Exit Sub
        ElseIf txtTicketPrice.Text < 1 Then '' Check the inputed number is at least $1, if not informs the user as such
            MsgBox("Please ensure the price is at least $1!")
            Exit Sub
        End If
        Dim dblNewPrice As Double = txtTicketPrice.Text '' Stores the price in var

        Dim objWriter As New IO.StreamWriter("Price.txt", False) '' Defines the objeect that writes the price, overwriting the previous one
        objWriter.WriteLine(dblNewPrice) '' Writes the ticket price to the file
        objWriter.Close() '' Closes and Saves File

        MsgBox("Price Successfully Updated to $" & dblNewPrice & "!") '' Informs the user of the price update
    End Sub
End Class