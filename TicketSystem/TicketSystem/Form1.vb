Imports System.Xml '' Imports the library to access classes that give functionality to manipulate XML
Public Class Form1
    '' Upon Clicking Sell Button, switches to the seller form
    Private Sub btnSeller_Click(sender As Object, e As EventArgs) Handles btnSeller.Click
        Hide()
        Seller.Show()
    End Sub
    '' Upon Clicking Scan Button, switches to scanner form
    Private Sub btnScanner_Click(sender As Object, e As EventArgs) Handles btnScanner.Click
        Hide()
        Scanner.Show()
    End Sub
    '' Fucntion to take a string, hash it with the SHA256 algorithim and return the value as string
    Private Function StringToSHA256(strContent As String) As String
        '' Gets the SHA256 Provider Object and Hashes the Content
        Dim SH256 As New Security.Cryptography.SHA256CryptoServiceProvider
        Dim ByteString() As Byte = System.Text.Encoding.ASCII.GetBytes(strContent)
        ByteString = SH256.ComputeHash(ByteString)
        Dim FinalString As String = Nothing

        '' Converts the hashed content to a string
        For Each bt As Byte In ByteString
            FinalString &= bt.ToString("x2")
        Next

        Return FinalString '' Returns the hashed srtring
    End Function

    '' Logic to Open the Admin Panel, only if a correct password is inputted
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Dim strPassAttempt As String = InputBox("Enter Password:") '' Get the password input
        If StringToSHA256(strPassAttempt) = IO.File.ReadAllText("Password.txt") Then '' Check the password is correct (Password = @dm1n), if so open admin panel
            Hide()
            Admin.Show()
        Else '' If password incorrect, inform user.
            MsgBox("Wrong Password! Please Try Again.")
        End If
    End Sub

    '' Sub-routine to ensure databases exist, if not create one
    Private Sub CheckIfXMLFileExists(strFileName As String)
        Dim strFilePath As String = IO.Path.Combine(".\", strFileName) '' Make file name into relative path
        Dim strXMLName As String = strFileName.Substring(0, strFileName.Length - 4) '' Store the name of the xml file with the '.xml' removed

        '' Check if the inputed file already exists, if not creates it
        If IO.File.Exists(strFilePath) Then
            Exit Sub
        Else
            '' Message box that gives the user the illusion of choice
            MsgBox("Database for " & strXMLName & " does not exist! Do you agree to initialise? Ensure you add an area in the admin panel before beginning", 0 Or 48)
            Dim writer As New XmlTextWriter(strFileName, System.Text.Encoding.UTF8)  '' Creates writer method to create and write to an XML document
            '' Begin XML document and setup basic parameters for it for later edits
            writer.WriteStartDocument(True)
            writer.Formatting = Formatting.Indented
            writer.Indentation = 4
            writer.WriteStartElement(strXMLName) '' Writes the primary element that describes what the document attempts to achieve
            writer.WriteEndElement() '' Closes the writer and saves the document
            writer.WriteEndDocument()
            writer.Close()
        End If
    End Sub

    '' Sub-routine to ensure a text files exists, if not create one
    Private Sub CheckIfTextFileExists(strFileName As String)
        Dim strFilePath As String = IO.Path.Combine(".\", strFileName) '' Turn the inputted filename into a machine-readable relative path
        Dim strTxtName As String = strFileName.Substring(0, strFileName.Length - 4) '' Store the name of the txt file with the '.txt' removed

        '' Check if the inputed file already exists, if not creates it
        If (IO.File.Exists(strFilePath)) Then
            Exit Sub
        Else
            '' Message box that gives the user the illusion of choice
            MsgBox("Database for the " & strTxtName & " does not exist! Do you agree to initialise with a default value of $3 (alterable in the Admin panel)?", 0 Or 48)
            '' Create a text file and write the ticket price into it
            Dim objWriter As New IO.StreamWriter(strFilePath, True) '' Define the object to write to the file
            objWriter.WriteLine("3.00") '' Write the price to the text file
            objWriter.Close() '' Close the writer, saving the document
        End If
    End Sub

    '' Upon load, ensure neccesary DBs exist, if not create them.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' Check if the XML files exist for the areas and tickets exist, if not, create them
        CheckIfXMLFileExists("Areas.xml")
        CheckIfXMLFileExists("Tickets.xml")
        '' Check if the text file that stores the ticket price exists, if not, create it
        CheckIfTextFileExists("Price.txt")
    End Sub
End Class
