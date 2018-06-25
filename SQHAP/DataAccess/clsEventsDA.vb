Imports System.Data.OleDb

Public Class clsEventsDA

    ' Method Name:  GetRecords
    ' Purpose:      To get all the records from the database for this entity
    ' Parameter:    Nothing
    ' Return:       All the records of this entity - Dataset

    Public Shared Function GetRecords() As DataSet
        Dim dbConnection As OleDbConnection = Nothing
        ' error handling
        Try
            ' connect to the database
            dbConnection = ConnectToDb()

            ' check the status of the connection
            If dbConnection Is Nothing Then
                MessageBox.Show("Connection failed!")
                Return Nothing
            End If

            ' the connection if made
            ' create a SQL string
            Dim strQuery As String
            strQuery = "SELECT * FROM Event"

            ' Setup ADO component
            ' create a data adapter object
            Dim dbDataAdapter As New OleDbDataAdapter
            ' create a command object for the data adapter
            Dim dbCommand As New OleDbCommand

            ' configure the components
            dbCommand.CommandText = strQuery
            dbCommand.Connection = dbConnection
            dbDataAdapter.SelectCommand = dbCommand

            ' declare a dataset
            Dim ds As New DataSet

            ' fill the dataset
            dbDataAdapter.Fill(ds, "Event")

            Return ds
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsEventsDA. Method: GetRecords(). Error: " _
                            & ex.Message)
            Return Nothing
        Finally
            CloseDb(dbConnection)
        End Try
    End Function

    ' Method Name:  DeleteRecord
    ' Purpose:      To delete a record from the database for this entity
    ' Parameter:    Primary Key - String
    ' Return:       Result (number of rows affected) - Integer


    Public Shared Function DeleteRecord(ByVal aPrimaryKey As String) As Integer
        Dim dbConnection As OleDbConnection = Nothing
        ' error handling
        Try
            ' connect to the database
            dbConnection = ConnectToDb()

            ' check the status of the connection
            If dbConnection Is Nothing Then
                MessageBox.Show("Connection failed!")
                Return Nothing
            End If

            ' the connection if made
            ' create a SQL string
            Dim strQuery As String
            strQuery = "DELETE FROM Event WHERE EventID = ?"

            ' Setup ADO component
            ' create a data adapter object
            Dim dbDataAdapter As New OleDbDataAdapter
            ' create a command object for the data adapter
            Dim dbCommand As New OleDbCommand

            ' add a new parameter
            dbCommand.Parameters.Add(New OleDbParameter("@EventID", aPrimaryKey))

            ' configure the components
            dbCommand.CommandText = strQuery
            dbCommand.Connection = dbConnection
            dbDataAdapter.SelectCommand = dbCommand

            ' declare a variable to hold the result
            Dim intResult As Integer
            ' call the method to get the result
            intResult = dbCommand.ExecuteNonQuery

            ' return the result
            Return intResult
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsEventsDA. Method: DeleteRecord(String). Error: " _
                            & ex.Message)
            Return -9
        Finally
            CloseDb(dbConnection)
        End Try
    End Function

    ' Method Name:  AddRecord
    ' Purpose:      To add a record from the database for this entity
    ' Parameter:    Object (aEvent) - clsEvents
    ' Return:       Result (number of rows affected) - Integer

    Public Shared Function AddRecord(ByVal aEvent As clsEvents) As Integer
        Dim dbConnection As OleDbConnection = Nothing
        ' error handling
        Try
            ' connect to the database
            dbConnection = ConnectToDb()

            ' check the status of the connection
            If dbConnection Is Nothing Then
                MessageBox.Show("Connection failed!")
                Return Nothing
            End If

            ' the connection if made
            ' create a SQL string
            Dim strQuery As String
            strQuery = "INSERT INTO Event ([EventID], [Title], [Date], [EntryCost]) VALUES (?, ?, ?, ?)"

            ' Setup ADO component
            ' create a data adapter object
            Dim dbDataAdapter As New OleDbDataAdapter
            ' create a command object for the data adapter
            Dim dbCommand As New OleDbCommand

            ' add new parameters
            dbCommand.Parameters.Add(New OleDbParameter("@EventID", aEvent.EventID))
            dbCommand.Parameters.Add(New OleDbParameter("@Title", aEvent.Title))
            dbCommand.Parameters.Add(New OleDbParameter("@Date", aEvent.DDate))
            dbCommand.Parameters.Add(New OleDbParameter("@EntryCost", aEvent.EntryCost))


            ' configure the components
            dbCommand.CommandText = strQuery
            dbCommand.Connection = dbConnection
            dbDataAdapter.SelectCommand = dbCommand

            ' declare a variable to hold the result
            Dim intResult As Integer
            ' call the method to get the result
            intResult = dbCommand.ExecuteNonQuery

            ' return the result
            Return intResult
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsEventsDA. Method: AddRecord(Object). Error: " _
                            & ex.Message)
            Return -9
        Finally
            CloseDb(dbConnection)
        End Try
    End Function

    ' Method Name:  UpdateRecord
    ' Purpose:      To update a record from the database for this entity
    ' Parameter:    Object (aEvent) - clsEvents
    ' Return:       Result (number of rows affected) - Integer

    Public Shared Function UpdateRecord(ByVal aEvent As clsEvents) As Integer
        Dim dbConnection As OleDbConnection = Nothing
        ' error handling
        Try
            ' connect to the database
            dbConnection = ConnectToDb()

            ' check the status of the connection
            If dbConnection Is Nothing Then
                MessageBox.Show("Connection failed!")
                Return Nothing
            End If

            ' the connection if made
            ' create a SQL string
            Dim strQuery As String
            strQuery = "UPDATE Event SET [Title] = ?, [Date] = ?, [EntryCost] = ? WHERE [EventID] = ?"

            ' Setup ADO component
            ' create a data adapter object
            Dim dbDataAdapter As New OleDbDataAdapter
            ' create a command object for the data adapter
            Dim dbCommand As New OleDbCommand

            ' add new parameters

            dbCommand.Parameters.Add(New OleDbParameter("@Title", aEvent.Title))
            dbCommand.Parameters.Add(New OleDbParameter("@Date", aEvent.DDate))
            dbCommand.Parameters.Add(New OleDbParameter("@EntryCost", aEvent.EntryCost))
            ' *********** adding your primary key field last *************************************
            dbCommand.Parameters.Add(New OleDbParameter("@EventID", aEvent.EventID))
            ' ************************************************************************************

            ' configure the components
            dbCommand.CommandText = strQuery
            dbCommand.Connection = dbConnection
            dbDataAdapter.SelectCommand = dbCommand

            ' declare a variable to hold the result
            Dim intResult As Integer
            ' call the method to get the result
            intResult = dbCommand.ExecuteNonQuery

            ' return the result
            Return intResult
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsEventDA. Method: UpdateRecord(Object). Error: " _
                            & ex.Message)
            Return -9
        Finally
            CloseDb(dbConnection)
        End Try
    End Function

End Class

