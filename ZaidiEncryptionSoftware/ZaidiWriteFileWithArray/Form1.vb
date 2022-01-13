Imports System.IO

Public Class frmWriteFileWithArray
    Dim IntArray(-1) As Integer 'Dim array of size zero ie. no indecies
    Dim NumtoFind As Integer
    Dim n As Integer 'the table value for the transposition function

    Private Sub addLine()
        If txtFileContents.Text <> Nothing Then
            txtFileContents.Text += vbNewLine 'adds a new line to keep things neat
        End If
    End Sub

    Sub showFileContents(ByVal filename As String)
        Dim fs As New FileStream(filename, FileMode.Open, FileAccess.Read)
        Dim textFile As New StreamReader(fs)
        Dim lineOfText As String
        'clear textbox of previous contents
        Me.txtFileContents.Text = Nothing
        Do While textFile.Peek > -1 'check for the end of file
            lineOfText = textFile.ReadLine

            'Display line of text
            Me.txtFileContents.Text &= lineOfText & vbCrLf
        Loop
        textFile.Close()
        fs.Close()
    End Sub

    Sub storeArrayContents(ByVal filename As String)
        Dim fs As New FileStream(filename, FileMode.Open, FileAccess.Read)
        Dim textFile As New StreamReader(fs)
        Dim index As Integer = 0
        ReDim Preserve IntArray(-1) 'empty the array if the button is clicked more than once in a row
        'clear textbox of previous contents
        Me.txtFileContents.Text = Nothing
        Do While textFile.Peek > -1 'loop through the file, line-by-line until the end of file
            ReDim Preserve IntArray(IntArray.Length) 'increase the array size by one
            IntArray(index) = Val(textFile.ReadLine) 'Store line of file into Array
            'Me.txtFileContents.Text &= IntArray(index) & vbCrLf 'Display line of text
            index += 1 'add one to the array index value for the next line of the file
        Loop 'loop to the next line of the file
        textFile.Close()
        fs.Close()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        'Empty textbox
        Me.txtFileContents.Text = Nothing
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        'empty textbox
        Me.txtFileContents.Text = Nothing
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Me.SaveFileDialog1.ShowDialog() 'display Save As dialog box
        Dim filename As String = Me.SaveFileDialog1.FileName 'get the entered file name
        If filename <> Nothing Then
            Dim fs As New FileStream(filename, FileMode.Create, FileAccess.Write)
            Dim textfile As New StreamWriter(fs)
            textfile.Write(Me.txtFileContents.Text) 'write text box contents to file
            textfile.Close()
            fs.Close()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'close program
        Application.Exit()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Me.OpenFileDialog1.ShowDialog() 'show Open dialog box
        Dim filename As String = Me.OpenFileDialog1.FileName
        If filename <> Nothing Then
            Call showFileContents(filename) 'Call Sub to open a regular textfile and show it's contents
        End If
    End Sub

    Private Sub OpenAndStoreIntoArrayToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenAndStoreIntoArrayToolStripMenuItem.Click
        Me.OpenFileDialog1.ShowDialog() 'show Open dialog box
        Dim filename As String = Me.OpenFileDialog1.FileName
        If filename <> Nothing Then
            Call storeArrayContents(filename) 'Call Sub to open a Numeric textfile and store it's contents into the array()
        End If
        'notify the user that the Array is stored
        MessageBox.Show("The array has been stored. Select Display Array to view it.")
    End Sub

    Private Sub DisplayArrayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayArrayToolStripMenuItem.Click
        addLine()
        'display column titles
        Me.txtFileContents.Text &= "Index" & vbTab & "Array" & vbCrLf
        For index As Integer = 0 To IntArray.Length - 1
            'Display line of text
            Me.txtFileContents.Text &= index & vbTab & IntArray(index) & vbCrLf
        Next index
    End Sub

    Private Sub SortArrayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SortArrayToolStripMenuItem.Click
        'Sorts intArray from low to high
        'post: intArray elements have been sorted low to high
        Dim temp As Integer
        'Bubble each element as necessary
        For bubbleItem As Integer = 0 To IntArray.Length - 1
            For testItem As Integer = 0 To IntArray.Length - 2
                If IntArray(testItem) > IntArray(testItem + 1) Then
                    'Swap Elements
                    temp = IntArray(testItem)
                    IntArray(testItem) = IntArray(testItem + 1)
                    IntArray(testItem + 1) = temp

                End If
            Next testItem
        Next bubbleItem
        'notify the user that the Array is sorted
        MessageBox.Show("The array has been sorted. Select Display Array to view it.")
    End Sub

    Private Sub SearchArrayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchArrayToolStripMenuItem.Click
        addLine()
        'Get search number from user
        NumtoFind = InputBox("What number would you like to find?")
        'Find number
        Dim numFoundIndex As Integer = BinarySearch(IntArray, NumtoFind)
        If numFoundIndex = -1 Then
            Me.txtFileContents.Text &= "Number not found."
        Else
            Me.txtFileContents.Text &= "The number " & NumtoFind & " found at index " & numFoundIndex
        End If
    End Sub

    'Returns the index of numToFind or -1 if numToFind is not in array.
    'post: A -1 or the index of numToFind has been returned.

    Function BinarySearch(ByRef intArray() As Integer, ByVal numToFind As Integer) As Integer
        Dim highIndex As Integer = intArray.Length - 1
        Dim midIndex As Integer
        Dim lowIndex = 0
        Dim found As Boolean = False
        Do While (Not found) And (lowIndex <= highIndex)
            midIndex = (highIndex + lowIndex) \ 2
            If intArray(midIndex) = numToFind Then
                found = True
            ElseIf intArray(midIndex) > numToFind Then
                highIndex = midIndex - 1
            Else
                lowIndex = midIndex + 1
            End If
        Loop
        If found Then
            Return midIndex
        Else
            Return -1
        End If
    End Function

    Function DecodeCharNegOne(ByVal plain As Char) As Char
        'decode -1 cipher by Replacing each letter with one letter after it in the alphabet
        Select Case plain
            Case "A" To "Y", "a" To "y"
                Return ChrW(AscW(plain) + 1)
                'do the last letter manually
            Case "Z"
                Return "A"
            Case "z"
                Return "a"
            Case Else
                Return plain
        End Select
    End Function

    Function EncodeCharNegOne(ByVal plain As Char) As Char
        'encode -1 cipher by Replacing each letter with one letter before it in the alphabet
        Select Case plain
            Case "B" To "Z", "b" To "z"
                Return ChrW(AscW(plain) - 1)
                'do the first letter manually
            Case "a"
                Return "z"
            Case "A"
                Return "Z"
            Case Else
                Return plain
        End Select
    End Function

    Function DecodeCaeserChar(ByVal plain As Char) As Char
        Select Case plain
            Case "D" To "Z", "d" To "z"
                Return ChrW(AscW(plain) - 3)
            Case "C"
                Return "Z"
            Case "c"
                Return "z"
            Case "B"
                Return "Y"
            Case "b"
                Return "y"
            Case "A"
                Return "X"
            Case "a"
                Return "x"
            Case Else
                Return plain
        End Select
    End Function

    Function EncodeCaeserChar(ByVal plain As Char) As Char
        Select Case plain
            Case "A" To "W", "a" To "w"
                Return ChrW(AscW(plain) + 3)
            Case "X"
                Return "A"
            Case "x"
                Return "a"
            Case "Y"
                Return "B"
            Case "y"
                Return "b"
            Case "Z"
                Return "C"
            Case "z"
                Return "c"
            Case Else
                Return plain
        End Select
    End Function

    Private Sub EncodeNegOneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncodeNegOneToolStripMenuItem.Click
        'set up to call the Encode Sub, sending each character to be replaced
        Dim plain As Char
        Dim message As String = Me.txtFileContents.Text
        Dim Encodedmessage As String = Nothing
        For Each plain In message
            Encodedmessage = Encodedmessage & EncodeCharNegOne(plain)
        Next plain
        Me.txtFileContents.Text = Encodedmessage
    End Sub

    Private Sub DecodeNegOneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecodeNegOneToolStripMenuItem.Click
        'set up to call the Decode Sub, sending each character to be replaced
        Dim plain As Char
        Dim message As String = Me.txtFileContents.Text
        Dim Decodedmessage As String = Nothing
        For Each plain In message
            Decodedmessage = Decodedmessage & DecodeCharNegOne(plain)
        Next plain
        Me.txtFileContents.Text = Decodedmessage
    End Sub

    Private Sub EncodeCaeserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncodeCaeserToolStripMenuItem.Click
        Dim plain As Char
        Dim message As String = Me.txtFileContents.Text
        Dim Encodedmessage As String = Nothing
        For Each plain In message
            Encodedmessage = Encodedmessage & EncodeCaeserChar(plain)
        Next plain
        Me.txtFileContents.Text = Encodedmessage
    End Sub

    Private Sub DecodeCaeserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecodeCaeserToolStripMenuItem.Click
        Dim plain As Char
        Dim message As String = Me.txtFileContents.Text
        Dim Decodedmessage As String = Nothing
        For Each plain In message
            Decodedmessage = Decodedmessage & DecodeCaeserChar(plain)
        Next plain
        Me.txtFileContents.Text = Decodedmessage
    End Sub

    Private Sub TableYieldToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TableYieldToolStripMenuItem.Click
        Dim tempnum As String = InputBox("Enter the numerical table yield value for the transposition encryption/decryption:", "Enter Value")
        If tempnum = Nothing Then
            MessageBox.Show("Your value returned as null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf IsNumeric(tempnum) = False Then
            While IsNumeric(tempnum) = False
                If MessageBox.Show("The number you entered was not valid, would you like to retry?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = Windows.Forms.DialogResult.Yes Then
                    tempnum = InputBox("Enter the numerical table yield value for the transposition encryption:", "Enter Value")
                Else
                    Exit Sub
                End If
            End While
        End If
        tempnum = Math.Round(Val(tempnum))
        n = Int(tempnum)
    End Sub

    Private Sub EncodeDefaultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncodeDefaultToolStripMenuItem.Click
        If txtFileContents.Text = Nothing Then
            MessageBox.Show("Please enter something to encrypt in the multiline textbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Try
            Dim lines() As String = txtFileContents.Lines
            Dim Encodedmessage As String = Nothing
            For Each plain As Char In lines(0)
                n += 1
            Next
            Dim x As Integer = 0
            While x < n
                For i As Integer = 0 To lines.Length - 1
                    Dim characterArray(n)
                    Dim temp As Integer = 0
                    For Each plain As Char In lines(i)
                        characterArray(temp) = plain
                        If temp < n Then
                            temp += 1
                        End If
                    Next
                    Encodedmessage = Encodedmessage & characterArray(x)
                Next
                x += 1
            End While
            Me.txtFileContents.Text = Encodedmessage
        Catch ex As Exception
            MessageBox.Show("An error occured, please check your text for any inconsistencies again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DecodeYieldToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecodeYieldToolStripMenuItem.Click
        If n = Nothing Or n = 0 Then
            MessageBox.Show("Please enter a table yield first to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim message As String = Me.txtFileContents.Text
                Dim Decodedmessage As String = Nothing
                Dim x As Integer = 0
                Dim charLength As Integer
                For Each plain As Char In message
                    charLength += 1
                Next
                Dim characterArray(charLength - 1)
                Dim temp As Integer = 0
                For Each plain As Char In message
                    characterArray(temp) = plain
                    If temp < charLength Then
                        temp += 1
                    End If
                Next
                Dim lines As Integer = charLength / n
                While x < lines
                    Dim i As Integer = x
                    For index As Integer = 0 To n - 1
                        Decodedmessage = Decodedmessage & characterArray(i)
                        i += lines
                    Next
                    x += 1
                End While
                Me.txtFileContents.Text = Decodedmessage
            Catch ex As Exception
                MessageBox.Show("An error occured, please check your encrypted text for any inconsistencies again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub StoreIntoArrayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StoreIntoArrayToolStripMenuItem.Click
        Dim lines() As String = txtFileContents.Lines
        'clear textbox of previous contents
        For i As Integer = 0 To lines.Length - 1
            If IsNumeric(lines(i)) = False Then
                MessageBox.Show("A value returned invalid (string) in the array, please re-check the text and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                lines(i) = Math.Round(Val(lines(i)))
            End If
            ReDim Preserve IntArray(IntArray.Length)
            IntArray(i) = Int(lines(i))
        Next
        MessageBox.Show("Items successfully stored into an array", "Success", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub

    Private Sub FontSize1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontSize1ToolStripMenuItem.Click
        Using f As Font = txtFileContents.Font
            txtFileContents.Font = New Font(f.FontFamily, f.Size + 1, f.Style)
        End Using
    End Sub

    Private Sub FontSize1ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontSize1ToolStripMenuItem1.Click
        Using f As Font = txtFileContents.Font 'this program decreases the font size by one
            txtFileContents.Font = New Font(f.FontFamily, f.Size - 1, f.Style)
        End Using
    End Sub

    Private Sub DefaultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultToolStripMenuItem.Click
        txtFileContents.Font = New Font(txtFileContents.Font.FontFamily, txtFileContents.Font.Size, FontStyle.Regular)
    End Sub

    Private Sub BoldToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoldToolStripMenuItem.Click
        txtFileContents.Font = New Font(txtFileContents.Font.FontFamily, txtFileContents.Font.Size, FontStyle.Bold)
    End Sub

    Private Sub UnderlineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtFileContents.Font = New Font(txtFileContents.Font.FontFamily, txtFileContents.Font.Size, FontStyle.Regular)
    End Sub

    Private Sub StrikeoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StrikeoutToolStripMenuItem.Click
        txtFileContents.Font = New Font(txtFileContents.Font.FontFamily, txtFileContents.Font.Size, FontStyle.Strikeout)
    End Sub

    Private Sub HelpToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem3.Click
        MessageBox.Show("Array Help:" + vbNewLine + vbNewLine + "Open and Store into Array: Allows user to open a text file and store it into a new array (only accepts Integers)." + vbNewLine + vbNewLine + "Store (current) into Array: Allows user to store anything on the textbox into a new Array (only accepts Integers)." + vbNewLine + vbNewLine + "Sort Array: Allows user to sort Integers stored inside an array numerically." + vbNewLine + vbNewLine + "Display Array: Allows users to display the array created in the textbox." + vbNewLine + vbNewLine + "Search Array: Allows users to search for any integer present in the array.", "Array Help", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub HelpToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem2.Click
        MessageBox.Show("Cipher Help:" + vbNewLine + vbNewLine + "Encode: Replaces each letter with one before it." + vbNewLine + vbNewLine + "Decode: Replaces each letter with one after it.", "Cipher Help", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        MessageBox.Show("Caeser Cipher Help:" + vbNewLine + vbNewLine + "Encode: Replaces each letter with one 3 after it." + vbNewLine + vbNewLine + "Decode: Replaces each letter with one three before it.", "Caeser Chiper Help", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show("Transposition Help:" + vbNewLine + vbNewLine + "Encode: Shuffles the letters at the specefic n (table yield) value. For encoding, the nth value is automatically detected. Each line *Must* have exactly (n) amount of letters or it will fail." + vbNewLine + vbNewLine + "Decode: Deshuffles letter at the nth value. The n value must be set beforehand." + vbNewLine + vbNewLine + "Table Yield: Sets the n value to work with.", "Transposition Help", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
