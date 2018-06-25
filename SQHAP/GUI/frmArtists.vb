' Form Name:    frmArtists
' Purpose:      To allow the user to either enter data or display an object
' Change Log:   10/25/16 J. Loverme

Option Strict On
Public Class frmArtists
    'declare dataset
    Private dsArtists As New DataSet

    Public Sub DisplayRecord(ByVal aIndex As Integer)
        Try
            If dsArtists.Tables("Artist").Rows.Count = 0 Then
                Exit Sub
            End If

            lblCurrent.Text = (aIndex + 1).ToString
            lblTotal.Text = (dsArtists.Tables("Artist").Rows.Count).ToString

            ArtistIDTextBox.Text = dsArtists.Tables("Artist").Rows(aIndex).Item(0).ToString
            FirstNameTextBox.Text = dsArtists.Tables("Artist").Rows(aIndex).Item(1).ToString
            LastNameTextBox.Text = dsArtists.Tables("Artist").Rows(aIndex).Item(2).ToString
            PhoneNumberTextBox.Text = dsArtists.Tables("Artist").Rows(aIndex).Item(3).ToString
            EmailTextBox.Text = dsArtists.Tables("Artist").Rows(aIndex).Item(4).ToString
            WebPageTextBox.Text = dsArtists.Tables("Artist").Rows(aIndex).Item(5).ToString
            AIRCheckBox.Checked = CBool(dsArtists.Tables("Artist").Rows(aIndex).Item(6))

        Catch ex As Exception
            MessageBox.Show("Error occurred in Form: frmEvents. Method: DisplayRecord(index). Error: " _
                           & ex.Message)
        End Try
    End Sub

    Private Sub frmArtists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQHAP_DBDataSet.Artist' table. You can move, or remove it, as needed.
        Me.ArtistTableAdapter.Fill(Me.SQHAP_DBDataSet.Artist)
        dsArtists = clsArtists.GetRecords()
        DisplayRecord(0)
    End Sub
    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Try
            ' go to the first record
            DisplayRecord(0)
        Catch ex As Exception
            MessageBox.Show("Error occurred in Form: frmArtists. Method: btnFirst_Click(). Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Try
            ' check to see if it is the first record
            If lblCurrent.Text = "1" Then
                ' don't do anything
                Exit Sub
            End If

            ' go to the previous one
            DisplayRecord(CInt(lblCurrent.Text) - 2)
        Catch ex As Exception
            MessageBox.Show("Error occurred in Form: frmArtists. Method: btnPrevious_Click(). Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Try
            If (CInt(lblCurrent.Text) = dsArtists.Tables("Artist").Rows.Count) Then
                ' do nothing, because we don't care
                Exit Sub
            End If
            ' go to the next record
            DisplayRecord(CInt(lblCurrent.Text))
        Catch ex As Exception
            MessageBox.Show("Error occurred in Form: frmArtists. Method: btnNext_Click(). Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Try
            ' go to the last record
            DisplayRecord(dsArtists.Tables("Artist").Rows.Count - 1)
        Catch ex As Exception
            MessageBox.Show("Error occurred in Form: frmArtists. Method: btnLast_Click(). Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim aForm As New SQHAPhome
        aForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ArtistIDTextBox.Clear()
        FirstNameTextBox.Clear()
        LastNameTextBox.Clear()
        PhoneNumberTextBox.Clear()
        EmailTextBox.Clear()
        WebPageTextBox.Clear()
        AIRCheckBox.Checked = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim myArtist As clsArtists
        Try
            ' validate the user input
            If IsValidNumber(ArtistIDTextBox, "ArtistID") Then
                If IsValidText(FirstNameTextBox, "FirstName") Then
                    If IsValidText(LastNameTextBox, "LastName") Then
                        If IsValidText(EmailTextBox, "Email") Then
                            If IsValidNumber(PhoneNumberTextBox, "PhoneNumber") Then
                                If IsValidText(WebPageTextBox, "WebPage") Then

                                    myArtist = New clsArtists(CInt(ArtistIDTextBox.Text.Trim),
                                                          FirstNameTextBox.Text, LastNameTextBox.Text, PhoneNumberTextBox.Text,
                                                             EmailTextBox.Text, WebPageTextBox.Text, CBool(AIRCheckBox.Checked))

                                    ' declare a variable to holds the result
                                    Dim intResult As Integer
                                    ' call the function to add a record
                                    intResult = clsArtists.AddRecord(myArtist)
                                    ' evaluate the result
                                    If intResult = 1 Then
                                        MessageBox.Show("A record has been successfully added!")
                                    ElseIf intResult = 0 Then
                                        MessageBox.Show("Add failed!")
                                    Else
                                        MessageBox.Show("Massive fail on your part...")

                                    End If

                                    ' get the updated dataset
                                    dsArtists = clsArtists.GetRecords()
                                    Me.ArtistDataGridView.DataSource = dsArtists.Tables("Artist")
                                    ' display the first record
                                    DisplayRecord(0)
                                End If
                            End If
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error occurred in Form: frmArtists. Method: btnAdd_Click(). Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim myArtist As clsArtists
        Try
            ' validate the user input
            If IsValidNumber(ArtistIDTextBox, "ArtistID") Then
                If IsValidText(FirstNameTextBox, "FirstName") Then
                    If IsValidText(LastNameTextBox, "LastName") Then
                        If IsValidText(EmailTextBox, "Email") Then
                            If IsValidNumber(PhoneNumberTextBox, "PhoneNumber") Then
                                If IsValidText(WebPageTextBox, "WebPage") Then

                                    myArtist = New clsArtists(CInt(ArtistIDTextBox.Text.Trim),
                                                          FirstNameTextBox.Text, LastNameTextBox.Text, PhoneNumberTextBox.Text,
                                                             EmailTextBox.Text, WebPageTextBox.Text, CBool(AIRCheckBox.Checked))

                                    ' declare a variable to holds the result
                                    Dim intResult As Integer
                                    ' call the function to add a record
                                    intResult = clsArtists.UpdateRecord(myArtist)
                                    ' evaluate the result
                                    If intResult = 1 Then
                                        MessageBox.Show("A record has been successfully updated!")
                                    ElseIf intResult = 0 Then
                                        MessageBox.Show("Update failed!")
                                    Else
                                        MessageBox.Show("Massive fail on your part...")

                                    End If

                                    ' get the updated dataset
                                    dsArtists = clsArtists.GetRecords()
                                    Me.ArtistDataGridView.DataSource = dsArtists.Tables("Artist")
                                    ' display the first record
                                    DisplayRecord(0)
                                End If
                            End If
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error occurred in Form: frmArtists. Method: btnAdd_Click(). Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' a variable to hold user's response
        Dim intResponse As Integer

        Try
            intResponse = MessageBox.Show("Are you certain you want to delete the record?",
                                          "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                                          MessageBoxDefaultButton.Button2)
            ' check the user response
            If intResponse = vbNo Then
                Exit Sub
            ElseIf ArtistIDTextBox.Text.Length = 0 Or Not IsNumeric(ArtistIDTextBox.Text.Trim) Then
                MessageBox.Show("You must enter a valid ID number for record deletion.")
                Exit Sub
            Else
                ' user answered Yes! and ID field has a valid value
                Dim intResult As Integer
                intResult = clsArtists.DeleteRecord(ArtistIDTextBox.Text.Trim)

                ' evaluate the return result
                If intResult = 1 Then
                    MessageBox.Show("The record has been deleted!")
                ElseIf intResult = 0 Then
                    MessageBox.Show("Massive failure: delete failed!")
                Else
                    MessageBox.Show("Something is very wrong, prepare to die!!!")
                End If
            End If

            ' get the updated dataset
            dsArtists = clsArtists.GetRecords()
            Me.ArtistDataGridView.DataSource = dsArtists.Tables("Artist")
            ' display the first record
            DisplayRecord(0)
        Catch ex As Exception
            MessageBox.Show("Error occurred in Form: frmArtists. Method: btnDelete_Click(). Error: " & ex.Message)
        End Try
    End Sub

End Class
