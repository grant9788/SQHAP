' Form Name:    frmEvents
' Purpose:      To allow the user to either enter data or display an object
' Change Log:   10/25/16 J. Loverme

Option Strict On

Public Class frmEvents
    'declare dataset
    Private dsEvents As New DataSet

    Public Sub DisplayRecord(ByVal aIndex As Integer)
        Try
            If dsEvents.Tables("Event").Rows.Count = 0 Then
                Exit Sub
            End If

            lblCurrent.Text = (aIndex + 1).ToString
            lblTotal.Text = (dsEvents.Tables("Event").Rows.Count).ToString

            EventIDTextBox.Text = dsEvents.Tables("Event").Rows(aIndex).Item(0).ToString
            TitleTextBox.Text = dsEvents.Tables("Event").Rows(aIndex).Item(1).ToString
            DateDateTimePicker.Value = CDate(dsEvents.Tables("Event").Rows(aIndex).Item(2))
            EntryCostTextBox.Text = dsEvents.Tables("Event").Rows(aIndex).Item(3).ToString

        Catch ex As Exception
            MessageBox.Show("Error occurred in Form: frmEvents. Method: DisplayRecord(index). Error: " _
                           & ex.Message)
        End Try
    End Sub

    Private Sub frmEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQHAP_DBDataSet._Event' table. You can move, or remove it, as needed.
        Me.EventTableAdapter.Fill(Me.SQHAP_DBDataSet._Event)
        dsEvents = clsEvents.GetRecords()
        DisplayRecord(0)
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim aForm As New SQHAPhome
        aForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Try
            ' go to the first record
            DisplayRecord(0)
        Catch ex As Exception
            MessageBox.Show("error occurred in form: frmevents. method: btnfirst_click(). error: " & ex.Message)
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
            MessageBox.Show("error occurred in form: frmevents. method: btnprevious_click(). error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Try
            If (CInt(lblCurrent.Text) = dsEvents.Tables("Event").Rows.Count) Then
                ' do nothing, because we don't care
                Exit Sub
            End If
            ' go to the next record
            DisplayRecord(CInt(lblCurrent.Text))
        Catch ex As Exception
            MessageBox.Show("error occurred in form: frmevents. method: btnnext_click(). error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Try
            ' go to the last record
            DisplayRecord(dsEvents.Tables("Event").Rows.Count - 1)
        Catch ex As Exception
            MessageBox.Show("error occurred in form: frmevents. method: btnlast_click(). error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        EventIDTextBox.Clear()
        TitleTextBox.Clear()
        DateDateTimePicker.Value = #01/01/2017#
        EntryCostTextBox.Clear()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'create variable
        Dim myEvent As clsEvents

        Try
            'validate user data
            If IsValidNumber(EventIDTextBox, "EventID") = True Then
                If IsValidText(TitleTextBox, "Title") = True Then
                    If IsDate(DateDateTimePicker.Value) = True Then
                        If IsValidNumber(EntryCostTextBox, "EntryCost") = True Then

                            myEvent = New clsEvents(CInt(EventIDTextBox.Text.Trim), TitleTextBox.Text,
                                                    CDate(DateDateTimePicker.Value), EntryCostTextBox.Text)

                            ' declare a variable to holds the result
                            Dim intResult As Integer
                            ' call the function to add a record
                            intResult = clsEvents.AddRecord(myEvent)
                            ' evaluate the result
                            If intResult = 1 Then
                                MessageBox.Show("A record has been successfully added!")
                            ElseIf intResult = 0 Then
                                MessageBox.Show("Add failed!")
                            Else
                                MessageBox.Show("Massive fail on your part...")

                            End If

                            ' get the updated dataset
                            dsEvents = clsEvents.GetRecords()
                            Me.EventDataGridView.DataSource = dsEvents.Tables("Event")
                            ' display the first record
                            DisplayRecord(0)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error occurred in Form: frmEvents. Method: btnAdd_Click(). Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'create variable
        Dim myEvent As clsEvents

        Try
            'validate user data
            If IsValidNumber(EventIDTextBox, "EventID") = True Then
                If IsValidText(TitleTextBox, "Title") = True Then
                    If IsDate(DateDateTimePicker.Value) = True Then
                        If IsValidNumber(EntryCostTextBox, "EntryCost") = True Then

                            myEvent = New clsEvents(CInt(EventIDTextBox.Text.Trim), TitleTextBox.Text,
                                                    CDate(DateDateTimePicker.Value), EntryCostTextBox.Text)

                            ' declare a variable to holds the result
                            Dim intResult As Integer
                            ' call the function to add a record
                            intResult = clsEvents.UpdateRecord(myEvent)
                            ' evaluate the result
                            If intResult = 1 Then
                                MessageBox.Show("A record has been successfully updated!")
                            ElseIf intResult = 0 Then
                                MessageBox.Show("update failed!")
                            Else
                                MessageBox.Show("Massive fail on your part...")

                            End If

                            ' get the updated dataset
                            dsEvents = clsEvents.GetRecords()
                            Me.EventDataGridView.DataSource = dsEvents.Tables("Event")
                            ' display the first record
                            DisplayRecord(0)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error occurred in Form: frmEvents. Method: btnUpdate_Click(). Error: " & ex.Message)
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
            ElseIf EventIDTextBox.Text.Length = 0 Or Not IsNumeric(EventIDTextBox.Text.Trim) Then
                MessageBox.Show("You must enter a valid ID number for record deletion.")
                Exit Sub
            Else
                ' user answered Yes! and ID field has a valid value
                Dim intResult As Integer
                intResult = clsEvents.DeleteRecord(EventIDTextBox.Text.Trim)

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
            dsEvents = clsEvents.GetRecords()
            Me.EventDataGridView.DataSource = dsEvents.Tables("Event")
            ' display the first record
            DisplayRecord(0)
        Catch ex As Exception
            MessageBox.Show("Error occurred in Form: frmEvents. Method: btnDelete_Click(). Error: " & ex.Message)
        End Try
    End Sub
End Class