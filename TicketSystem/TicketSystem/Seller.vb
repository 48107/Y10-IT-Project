Imports System.Xml '' Imports the library to access classes that give functionality to manipulate XML
Imports System.IO '' Imports broad library used to engage with text files among other things

Public Class Seller
    '' Define the ticket price to be accessalbe anywhere whilst the seller form is open
    Dim dblTixPrice As Double

    '' Logic to Populate Areas in Combobox
    Private Sub PopulateAreaBox()
        cbxArea.Items.Clear()  '' Ensure combobox is empty to avoid double population

        '' Open XML Document and read in Areas and add to the combobox
        Dim ReaderControl As XmlReader = XmlReader.Create("Areas.xml")
        Do While ReaderControl.Read
            If ReaderControl.NodeType = XmlNodeType.Element AndAlso ReaderControl.Name = "Name" Then
                cbxArea.Items.Add(ReaderControl.ReadElementString)  '' Add the Area to the ComboBox
            Else
                ReaderControl.Read()
            End If
        Loop
        ReaderControl.Close()  '' Close the XML document
    End Sub

    '' Function to get the current ticket price from the the Price.txt file and return it
    Private Function GetTicketPrice() As Double
        '' Opens the text file and reads the current price
        Dim srdrPrice As StreamReader = File.OpenText("Price.txt")
        Dim dblPrice As Double = srdrPrice.ReadLine
        srdrPrice.Close()

        '' Returns the current ticket price
        Return dblPrice
    End Function

    '' Logic to Return to Homepage
    Private Sub btnHomepage_Click(sender As Object, e As EventArgs) Handles btnHomepage.Click
        Close()
        Form1.Show()
    End Sub

    '' Logic to Load in Variables: Area, Ticket Price
    Private Sub Seller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dblTixPrice = GetTicketPrice() '' Sets Ticket Price using the GetTicketPrice() function from the file

        PopulateAreaBox() '' Populate the combobox
    End Sub

    '' Logic to Update Total Price for Ticket Order
    Private Sub nudPaidTix_ValueChanged(sender As Object, e As EventArgs) Handles nudPaidTix.ValueChanged
        Dim intPaidTickets As Double = nudPaidTix.Value  '' Read in Number of Paid Tickets
        lblPrice_Output.Text = "$" & intPaidTickets * dblTixPrice  '' Calculate and Output the Total Cost
    End Sub

    Private Sub btnCharge_Click(sender As Object, e As EventArgs) Handles btnCharge.Click
        '' Pulls user input for tickets and area from the pre-entered values
        Dim strArea As String = cbxArea.SelectedItem
        Dim intPaidTix As Integer = nudPaidTix.Value
        Dim intFreeTix As Integer = nudFreeTix.Value
        Dim intTotalTix As Integer = intPaidTix + intFreeTix '' Calculates total tickets
        Dim dblTotalPrice As Double = intPaidTix * dblTixPrice '' Calculates the total price for order

        '' Validates All Input Exists and Has Allowed Values
        If (strArea Is Nothing) Then '' Validates that an area has been selected, if not informs user to do so
            MsgBox("Please select an area for the ticket's validity!")
            Exit Sub
        End If
        If (intTotalTix = 0) Then '' Validates that a number of tickets greater than 0 has been selected, if not informs user to do so
            MsgBox("Please select an amount of tickets greater than 0!")
            Exit Sub
        End If

        '' Logic to open and access XML document and prepare to add new ticket entry
        Dim xelement As XElement = XElement.Load("Tickets.xml")
        Dim Areas As IEnumerable(Of XElement) = xelement.Elements()
        Dim Document As XDocument
        Document = XDocument.Load("Tickets.xml")

        '' Create the object for the new ticket's entry in XML doc
        Dim root = New XElement("Ticket")

        '' Create a unique ID for the ticket and attach it as an attribute to the ticket
        Dim guidID As Guid = Guid.NewGuid()
        root.SetAttributeValue("id", guidID.ToString())

        '' Create the objects for the elements within the new entry
        Dim TotalTixRemainElement = New XElement("Tickets_Left", intTotalTix) '' Creates an element to track of tickets left in the ticket
        Dim TotalTixElement = New XElement("Total_Tickets", intTotalTix) '' Creates an element to record the total number of tickets in the order
        Dim PaidTixElement = New XElement("Paid_Tickets", intPaidTix) '' Creates an element to record the amount of Paid Tickets in the Order
        Dim FreeTixElement = New XElement("Free_Tickets", intFreeTix) '' Creates an element to record the amount of Free Tickets in the Order
        Dim PriceElement = New XElement("Price", dblTotalPrice) '' Creates an element to record the Order Price
        Dim AreaElement = New XElement("Area", strArea) '' Creates an element to record where tickets are valid

        '' Add the entry to the XML doc
        root.Add(TotalTixRemainElement, TotalTixElement, PaidTixElement, FreeTixElement, PriceElement, AreaElement)
        Document.Root.Add(root)
        Document.Save("Tickets.xml")


        '' Message Box Becomes Imaginary Printer Because I don't otherwise have access to one
        MsgBox("Congratulations, you have purchase: " & intTotalTix & " tickets valid in " & strArea & " for $" & dblTotalPrice & ". Comprised of " & intPaidTix & " paid tickets and " & intFreeTix & " free tickets. ID: " & guidID.ToString())
    End Sub
End Class