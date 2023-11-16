Imports System.Xml '' Imports a library to access classes that give functionality to manipulate XML
Public Class Scanner
    Dim intRemainingTix As Integer
    '' Initial Set-up to Allow For Loading Document and Accessing the ticket's node
    Dim xmlDocument As XmlDocument = New XmlDocument
    Dim ticketNode As XmlNode

    '' Logic to Return to Homepage
    Private Sub btnHomepage_Click(sender As Object, e As EventArgs) Handles btnHomepage.Click
        Close()
        Form1.Show()
    End Sub

    '' Sub-routine to set redemption parts of form visible or invisible and adjusts the applications window size accordingly
    Private Sub SetRedemptionVisibility(boolVisibility As Boolean)
        lblRemainingTickets.Visible = boolVisibility
        nudTicketsToUse.Visible = boolVisibility
        lblTixToUse.Visible = boolVisibility
        btnUseTix.Visible = boolVisibility

        '' Adjusts window size to avoid large empty areas on form
        If (boolVisibility = False) Then
            Size = New Size(384, 285)
        Else
            Size = New Size(384, 445)
        End If
    End Sub

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        '' Get Ticket Code to Scan For and Scanning Area from the input textbox and combobox
        Dim strCode As String = txtTicketCode.Text
        Dim strScanArea As String = cbxArea.SelectedItem

        '' Open the XML document and define an object for the ticket node to set to
        xmlDocument.Load("Tickets.xml")
        ticketNode = xmlDocument.SelectSingleNode("/Tickets/Ticket[@id='" & strCode & "']")

        '' Validate that the ticket exists, if not inform the user to double check the code and hides the redemption section of gui
        If ticketNode Is Nothing Then
            MsgBox("Ticket Not Found! Please check the code")
            SetRedemptionVisibility(False)
            Exit Sub
        End If

        '' Set the number of remaining ticket to a variable
        intRemainingTix = ticketNode.ChildNodes.Item(0).InnerText
        '' Validate that there is at least 1 ticket remaining, if not inform the user as such and hides the redemption section of gui
        If intRemainingTix < 1 Then
            MsgBox("No tickets remaining, please purchase a new one!")
            SetRedemptionVisibility(False)
            Exit Sub
        End If

        '' Validate that the ticket is valid for the area selected and that an area to scan in has been selected, if not inform the user as such and hides the redemption section of gui
        If ticketNode.ChildNodes.Item(5).InnerText <> strScanArea Or strScanArea Is Nothing Then
            MsgBox("This ticket is only valid in " & ticketNode.ChildNodes.Item(5).InnerText)
            SetRedemptionVisibility(False)
            Exit Sub
        End If

        '' Set all the tickets redeeming parts of app visible and inform user of number of tickets left and shows the redemption section of gui
        lblRemainingTickets.Text = "There are " & intRemainingTix & " tickets remaining"
        SetRedemptionVisibility(True)
    End Sub

    Private Sub btnUseTix_Click(sender As Object, e As EventArgs) Handles btnUseTix.Click
        '' Get the input of how many ticketo to redeem and validate it
        Dim intTixToUse As Integer = nudTicketsToUse.Value
        If intTixToUse = 0 Or intTixToUse > intRemainingTix Then '' Validation to ensure the number of tickets to redeem is within an acceptable range
            MsgBox("Please ensure you have selected a number of ticket more than 0, but not exceeding the " & intRemainingTix & " remaining tickets!")
        Else
            '' Rename the Area and Save the XML Dcoument
            ticketNode.ChildNodes.Item(0).InnerText = intRemainingTix - intTixToUse
            xmlDocument.Save("Tickets.xml")

            '' Inform the user of the successful ticket redemption
            MsgBox(intTixToUse & " Tickets Redeemed, " & intRemainingTix - intTixToUse & " Remain.")
            lblRemainingTickets.Text = "There are " & intRemainingTix - intTixToUse & " tickets remaining"
            '' Update the remaining tickets for the particular ticket and reset tickets available
            intRemainingTix = intRemainingTix - intTixToUse
            nudTicketsToUse.Value = 0 '' Reset the number up down to avoid accidental double redemptions
        End If
    End Sub

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

    Private Sub Scanner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateAreaBox() '' Populate the combobox
    End Sub

    '' Upon Changing the Area to Scan in, Resets the interface to prevent errors and incorrect application usage
    Private Sub cbxArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxArea.SelectedIndexChanged
        SetRedemptionVisibility(False)
        txtTicketCode.Text = ""
    End Sub
End Class