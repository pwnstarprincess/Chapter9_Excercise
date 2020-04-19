'Jennifer Pezzulo
'April 18, 2020
'Intro to MS Visual Basic.net
'Module 4 Assignment 2: Chapter 9 Exercise 1 (Membership list)


Public Class MembershipForm

    'Create a structure to hold names and phone numbers
    Structure Membership
        Dim name As String
        Dim phone As String
    End Structure

    'Declare variables
    Private UpperBound As Integer
    Private numLines As Integer

    'holds index of name
    Private nameTextBoxArray As Integer
    'holds index of phone number
    Private phoneTextBoxArray As Integer
    'Initialize structure
    Private membershipInfo(99) As Membership

    'Variable to hold format for output data
    Private outputFormat As String = "{0,-20}"

    'Sub routine called at load
    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Load and show the membership data
        LoadMembership()
        ShowMembership()

    End Sub

    'Sub routine to be called when selecting modify from the form menu
    Private Sub Modify()

        'variables to hold textbox data
        Dim newName As String
        Dim newPhone As String
        'Get textbox data
        newName = NameBox.Text
        newPhone = PhoneBox.Text
        'update the membership at the selected index with the new data
        membershipInfo(nameTextBoxArray).name = newName
        membershipInfo(phoneTextBoxArray).phone = newPhone
        'Show updated the data in the listbox
        ShowMembership()
    End Sub

    'Sub routine to be called when selecting Add from the form menu
    Private Sub Add()

        'Declare variables to hold textbox data
        Dim name As String
        Dim phone As String

        'Get textbox data
        name = NameBox.Text
        phone = PhoneBox.Text

        'Increment upper bound
        UpperBound += 1

        'Add name and phone number to membership structure
        membershipInfo(UpperBound).name = name
        membershipInfo(UpperBound).phone = phone

        'Update list box with membership data

        'Clear input fields to be ready for next entry
        NameBox.Clear()
        PhoneBox.Clear()
        'Set focus to namebox
        NameBox.Select()


        ShowMembership()
    End Sub

    'Sub routine to be called when selecting Delete from the form menu
    Private Sub Delete()

        'Remove selected data from membership data
        membershipInfo(nameTextBoxArray).name = Nothing
        membershipInfo(phoneTextBoxArray).phone = Nothing

        'update listbox 
        ShowMembership()
    End Sub

    Private Sub ExitProgram()
        'Prompt to save with msg box
        Dim message As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult

        message = "Save before exiting?"
        style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo

        title = "Save Before Exiting"

        response = MsgBox(message, style, title)

        If response = MsgBoxResult.Yes Then

            SaveFile()
            End

        Else
            End

        End If
    End Sub

    'Sub routine to handle selecting items in listbox
    Private Sub ListBoxOutput_selectedtext() Handles MemberListBox.SelectedIndexChanged

        'Set variables based on selected item in listbox
        nameTextBoxArray = MemberListBox.SelectedIndex
        phoneTextBoxArray = MemberListBox.SelectedIndex

        NameBox.Text = MemberListBox.SelectedItem
        PhoneBox.Text = membershipInfo(phoneTextBoxArray).phone


    End Sub

    Sub LoadMembership()

        'Declare streamreader to read membership data
        Dim readStream As IO.StreamReader
        'does the file exist?  If so open the txt file
        If IO.File.Exists("membership.txt") Then
            readStream = IO.File.OpenText("membership.txt")

            'Look at the incoming characters.  Is there data?
            'If so ShowMembership
            If (readStream.Peek <> -1) Then
                ShowMembership()
            End If
            'Read line As long as there is data...
            'First line is name and second line is number
            'increment number of lines
            Do While (readStream.Peek <> -1)
                Dim unused = readStream.ReadLine()
                unused = readStream.ReadLine()
                numLines += 1
            Loop
            'Close the stream
            readStream.Close()
            'upper bound is one less than the number of lines
            UpperBound = numLines - 1
            readStream = IO.File.OpenText("membership.txt")

            'load data into membership info
            For numberMember As Integer = 0 To UpperBound
                membershipInfo(numberMember).name = readStream.ReadLine
                membershipInfo(numberMember).phone = readStream.ReadLine
            Next
            'close the stream
            readStream.Close()
        Else

            'if the file does not exist prompt the user to create
            Dim message As String
            Dim title As String
            Dim style As MsgBoxStyle
            Dim response As MsgBoxResult

            message = "membership.txt not found. "
            message &= " Create file (yes) or close program (no)"


            style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
            'style = MsgBoxStyle.YesNo

            title = "File Not Found"

            response = MsgBox(message, style, title)

            'Create the file if the user says yes
            If response = MsgBoxResult.Yes Then
                Dim sw As IO.StreamWriter = IO.File.CreateText("membership.txt")
                sw.Close()
            Else
                End
            End If
        End If

    End Sub

    'Sub routine to show membership names
    Sub ShowMembership()
        'Clear the listbox
        MemberListBox.Items.Clear()
        'As Long as there are members...
        For numberMember As Integer = 0 To UpperBound
            'As long as we have not hit the upper bound
            For index As Integer = 1 To UpperBound
                'Sort alphabetically
                If (membershipInfo(index - 1).name > membershipInfo(index).name) Then
                    SwapData(index)
                Else
                End If

            Next
        Next
        'Display the membership data...
        For numberMember As Integer = 0 To UpperBound
            MemberListBox.Items.Add(String.Format(outputFormat, membershipInfo(numberMember).name))
        Next

    End Sub

    'Sub routine to swap data when two values are not in alphabetical order
    Sub SwapData(ByVal numberMember As Integer)
        Dim temp As Membership
        temp = membershipInfo(numberMember - 1)
        membershipInfo(numberMember - 1) = membershipInfo(numberMember)
        membershipInfo(numberMember) = temp

    End Sub


    Private Sub AddToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        'Run add sub routine when menu item clicked
        Add()


    End Sub

    Private Sub ModifyToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ModifyToolStripMenuItem.Click
        'Run modify subroutine when menu item is clicked
        Modify()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        'Run delete subroutine when menu is clicked
        Delete()

    End Sub

    Private Sub SaveToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

        ExitProgram()

    End Sub
    'Sub routne to save the file
    Sub SaveFile()

        'Initialize stream writer
        Dim sw As IO.StreamWriter = IO.File.CreateText("membership.txt")

        'Until you hit the upepr bound.  If there is data write it.
        For writeFile As Integer = 0 To UpperBound
            If membershipInfo(writeFile).name = Nothing Then
            Else
                sw.WriteLine(membershipInfo(writeFile).name)
            End If
            If membershipInfo(writeFile).phone = Nothing Then
            Else
                sw.WriteLine(membershipInfo(writeFile).phone)
            End If
        Next
        sw.Close()

    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        'Handle shortcut keys
        Select Case keyData
            Case Keys.F1
                Modify()
                Return True
            Case Keys.F2
                Add()
                Return True
            Case Keys.F3
                Delete()
                Return True
            Case Keys.F9
                ExitProgram()
                Return True
            Case Else
                Exit Select
        End Select

        Return False

    End Function

End Class