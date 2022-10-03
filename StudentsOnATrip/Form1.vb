Imports System.IO
Public Class Form1


    'creating the record structure for the student data
    Private Structure studentData
        Public Name As String             '20 characters can be entered
        Public Address As String          '30 characters can be entered
        Public Phone As String            '11 characters can be entered
        Public Course As String           '10 characters can be entered
        Public DoB As String              '10 characters can be entered
    End Structure

    'declare a record variabe using the sturcture above
    Dim studentRec As studentData

    Private Sub btnStore_Click(sender As Object, e As EventArgs) Handles btnStore.Click
        'Hide the message label
        lblMessage.Visible = False

        'declare a variable for the file, and open the file
        Dim sw As New System.IO.StreamWriter("Student.txt", True)
        'take the data from the text boxes and save into the customer record
        studentRec.Name = LSet(txtName.Text, 30)   'takes the leftmost characters from the text box and store in the field
        studentRec.Address = LSet(txtAddress.Text, 30)
        studentRec.Phone = LSet(txtPhone.Text, 13)
        studentRec.Course = LSet(txtCourse.Text, 30)
        studentRec.DoB = LSet(txtDoB.Text, 9)
        'write the fields to one line of the text file
        sw.WriteLine(studentRec.Name & studentRec.Address & studentRec.Phone & studentRec.Course & studentRec.DoB)
        sw.Close()       'closes the file

        lblMessage.Visible = True            'show the label with a message
        lblMessage.Text = "Student details stored"

        'clear the text boxes ready for the next entry
        txtName.Text = ""
        txtAddress.Text = ""
        txtPhone.Text = ""
        txtCourse.Text = ""
        txtDoB.Text = ""

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim numStudents As Integer
        Dim count As Integer
        Dim detailLine As String
        Dim name As String
        Dim address As String
        Dim phone As String
        Dim course As String
        Dim DoB As String
        lblMessage.Visible = False           'hide the message

        'the command below will read every line of text from the file, and store in the array "studentData"
        Dim studentData() As String = File.ReadAllLines("student.txt")

        'the "UBOUND" function gives the number of elements (lines/records) in the array
        numStudents = UBound(studentData)

        'use this number to loop through the array, and display every student who is on the trip

        For count = 0 To numStudents
            name = Mid(studentData(count), 1, 20)
            address = Mid(studentData(count), 21, 30)
            phone = Mid(studentData(count), 51, 11)
            course = Mid(studentData(count), 62, 10)
            DoB = Mid(studentData(count), 72, 10)

            detailLine = name & " " & address & " " & phone & " " & course & " " & DoB

            lstDetails.Items.Add(detailLine)
        Next

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BTN_Search_Click(sender As Object, e As EventArgs) Handles BTN_Search.Click
        Dim found As Boolean
        Dim searchItem As String
        Dim numStudents As Integer
        Dim count As Integer
        Dim detailLine As String
        Dim name As String
        Dim address As String
        Dim phone As String
        Dim course As String
        Dim DoB As String
        lblMessage.Visible = False           'hide the message

        'the command below will read every line of text from the file, and store in the array "studentData"
        Dim studentData() As String = File.ReadAllLines("student.txt")

        searchItem = Trim(txtName.Text)
        'use this number to loop through the array, and display every student who is on the trip
        found = False

        For count = 0 To UBound(studentData)

            If searchItem = Trim(Mid(studentData(count), 1, 20)) Then
                txtName.Text = Mid(studentData(count), 1, 20)
                txtAddress.Text = Mid(studentData(count), 21, 30)
                txtPhone.Text = Mid(studentData(count), 51, 11)
                txtCourse.Text = Mid(studentData(count), 62, 10)
                txtDoB.Text = Mid(studentData(count), 72, 10)
            Else
                lblMessage.Visible = True
                lblMessage.Text = "Not on file!"
            End If

            detailLine = name & " " & address & " " & phone & " " & course & " " & DoB

            lstDetails.Items.Add(detailLine)
        Next


    End Sub
End Class