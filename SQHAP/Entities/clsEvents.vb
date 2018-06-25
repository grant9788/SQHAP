' Class Name:   clsEvents
' Purpose:  A container to hold all attributes and methods in a class
' Change log:  10/24/16 J. Loverme


Public Class clsEvents

    ' *******************************************************************************************
    ' attributes
    '********************************************************************************************
    Private intEventID As Integer
    Private strTitle As String
    Private dateDate As Date
    Private strEntryCost As String

    ' *******************************************************************************************
    ' Property methods - getters and setters
    '********************************************************************************************
    Public Property EventID() As Integer
        Get
            Return intEventID
        End Get
        Set(value As Integer)
            If value > 0 Then
                intEventID = value
            Else
                ' decide what you want to do
                intEventID = -1
            End If
        End Set
    End Property

    Public Property Title() As String
        Get
            Return strTitle
        End Get
        Set(value As String)
            If value <> String.Empty Then
                strTitle = value
            Else
                strTitle = "Null String"
            End If
        End Set
    End Property

    Public Property DDate() As Date
        Get
            Return dateDate
        End Get
        Set(value As Date)
            If IsDate(value) = True Then
                dateDate = value
            Else
                dateDate = #1/1/2017#
            End If
        End Set
    End Property
    Public Property EntryCost() As String
        Get
            Return strEntryCost
        End Get
        Set(value As String)
            If value <> String.Empty Then
                strEntryCost = value
            Else
                strEntryCost = "Null String"
            End If
        End Set
    End Property

    ' *******************************************************************************************
    ' Constructors
    '********************************************************************************************

    ' default constructor
    Public Sub New()
        intEventID = 0
        strTitle = ""
        dateDate = #01/01/9999#
        strEntryCost = ""
    End Sub

    ' parameter based constructor
    Public Sub New(ByVal aEventID As Integer, ByVal aTitle As String,
                  ByVal aDate As Date, ByVal aEntryCost As String)
        intEventID = aEventID
        strTitle = aTitle
        dateDate = aDate
        strEntryCost = aEntryCost
    End Sub

    ' *******************************************************************************************
    ' Class Methods
    '********************************************************************************************

    ' Method Name:  classInfo
    ' Purpose:      To obtain a record from the database for this entity
    ' Parameter:    None
    ' Return:       A record of this entity - String
    ' Change Log:   10/17/16 J. Loverme

    Public Function classInfo() As String
        Return "EventID = " & EventID() & vbCr & "Event Name: " & Title() & vbCr _
            & "Event Date: " & DDate() & vbCr & "Event Price: " & EntryCost() & vbCr
    End Function

    ' Method Name:  GetRecords
    ' Purpose:      To obtain all the records from the database for this entity
    ' Parameter:    None
    ' Return:       All the records for this entity - Dataset
    ' Change Log:   10/17/16 J. Loverme

    Public Shared Function GetRecords() As DataSet
        Try
            Return clsEventsDA.GetRecords()
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsEvents. Method: GetRecords(). Error: " _
                            & ex.Message)
            Return Nothing
        End Try
    End Function

    ' Method Name:  DeleteRecord
    ' Purpose:      To delete a record from the database for this entity
    ' Parameter:    Primary Key - String
    ' Return:       Result (number of rows affected) - Integer
    ' Change Log:   10/17/16 J. Loverme
    Public Shared Function DeleteRecord(ByVal aPrimaryKey As String) As Integer
        Try
            Return clsEventsDA.DeleteRecord(aPrimaryKey)
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsEvents. Method: DeleteRecord(String). Error: " _
                            & ex.Message)
            Return -9
        End Try
    End Function

    ' Method Name:  AddRecord
    ' Purpose:      To add a record from the database for this entity
    ' Parameter:    Object (aEvent) - clsEvents
    ' Return:       Result (number of rows affected) - Integer
    ' Change Log:   10/17/16 J. Loverme
    Public Shared Function AddRecord(ByVal aEvent As clsEvents) As Integer
        Try
            Return clsEventsDA.AddRecord(aEvent)
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsEvent. Method: AddRecord(Object). Error: " _
                            & ex.Message)
            Return -9
        End Try
    End Function

    ' Method Name:  UpdateRecord
    ' Purpose:      To update a record from the database for this entity
    ' Parameter:    Object (aEvent) - clsEvent
    ' Return:       Result (number of rows affected) - Integer
    ' Change Log:   10/17/16 J. Loverme
    Public Shared Function UpdateRecord(ByVal aEvent As clsEvents) As Integer
        Try
            Return clsEventsDA.UpdateRecord(aEvent)
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsEvents. Method: UpdateRecord(Object). Error: " _
                            & ex.Message)
            Return -9
        End Try
    End Function
End Class
