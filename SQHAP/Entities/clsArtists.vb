' Class Name:   clsArtists
' Purpose:  A container to hold all attributes and methods in a class
' Change log:  10/25/16 J. Loverme

Public Class clsArtists
    ' *******************************************************************************************
    ' attributes
    '********************************************************************************************
    Private intArtistID As Integer
    Private strFirstName As String
    Private strLastName As String
    Private strPhoneNumber As String
    Private strEmail As String
    Private strWebPage As String
    Public boolAIR As Boolean

    ' *******************************************************************************************
    ' Property methods - getters and setters
    '********************************************************************************************
    Public Property ArtistID() As Integer
        Get
            Return intArtistID
        End Get
        Set(value As Integer)
            If value > 0 Then
                intArtistID = value
            Else
                ' decide what you want to do
                intArtistID = -1
            End If
        End Set
    End Property

    Public Property FirstName() As String
        Get
            Return strFirstName
        End Get
        Set(value As String)
            If value <> String.Empty Then
                strFirstName = value
            Else
                strFirstName = "Null String"
            End If
        End Set
    End Property
    Public Property LastName() As String
        Get
            Return strLastName
        End Get
        Set(value As String)
            If value <> String.Empty Then
                strLastName = value
            Else
                strLastName = "Null String"
            End If
        End Set
    End Property
    Public Property PhoneNumber() As String
        Get
            Return strPhoneNumber
        End Get
        Set(value As String)
            If value <> String.Empty Then
                strPhoneNumber = value
            Else
                strPhoneNumber = "Null String"
            End If
        End Set
    End Property
    Public Property Email() As String
        Get
            Return strEmail
        End Get
        Set(value As String)
            If value <> String.Empty Then
                strEmail = value
            Else
                strEmail = "Null String"
            End If
        End Set
    End Property
    Public Property WebPage() As String
        Get
            Return strWebPage
        End Get
        Set(value As String)
            If value <> String.Empty Then
                strWebPage = value
            Else
                strWebPage = "Null String"
            End If
        End Set
    End Property
    Public Property AIR() As Boolean
        Get
            Return boolAIR
        End Get
        Set(value As Boolean)
            boolAIR = value
        End Set
    End Property

    ' *******************************************************************************************
    ' Constructors
    '********************************************************************************************

    ' default constructor
    Public Sub New()
        intArtistID = 0
        strFirstName = ""
        strLastName = ""
        strWebPage = ""
        strEmail = ""
        strPhoneNumber = ""
        boolAIR = False
    End Sub

    ' parameter based constructor
    Public Sub New(ByVal aArtistID As Integer, ByVal aFirstName As String, ByVal aLastName As String,
                   ByVal aPhoneNumber As String, ByVal aEmail As String, ByVal aWebPage As String, ByVal aAIR As Boolean)
        intArtistID = aArtistID
        strFirstName = aFirstName
        strLastName = aLastName
        strWebPage = aWebPage
        strEmail = aEmail
        strPhoneNumber = aPhoneNumber
        boolAIR = aAIR
    End Sub

    ' Method Name:  GetRecords
    ' Purpose:      To obtain all the records from the database for this entity
    ' Parameter:    None
    ' Return:       All the records for this entity - Dataset
    ' Change Log:   10/25/16
    Public Shared Function GetRecords() As DataSet
        Try
            Return clsArtistsDA.GetRecords()
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsArtists. Method: GetRecords(). Error: " _
                            & ex.Message)
            Return Nothing
        End Try
    End Function

    ' Method Name:  DeleteRecord
    ' Purpose:      To delete a record from the database for this entity
    ' Parameter:    Primary Key - String
    ' Return:       Result (number of rows affected) - Integer
    ' Change Log:   10/25/16
    Public Shared Function DeleteRecord(ByVal aPrimaryKey As String) As Integer
        Try
            Return clsArtistsDA.DeleteRecord(aPrimaryKey)
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsArtists. Method: DeleteRecord(String). Error: " _
                            & ex.Message)
            Return -9
        End Try
    End Function

    ' Method Name:  AddRecord
    ' Purpose:      To add a record from the database for this entity
    ' Parameter:    Object (aArtist) - clsArtists
    ' Return:       Result (number of rows affected) - Integer
    ' Change Log:   10/25/16
    Public Shared Function AddRecord(ByVal aArtist As clsArtists) As Integer
        Try
            Return clsArtistsDA.AddRecord(aArtist)
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsArtists. Method: AddRecord(Object). Error: " _
                            & ex.Message)
            Return -9
        End Try
    End Function

    ' Method Name:  UpdateRecord
    ' Purpose:      To update a record from the database for this entity
    ' Parameter:    Object (aArtist) - clsArtists
    ' Return:       Result (number of rows affected) - Integer
    ' Change Log:   10/25/16
    Public Shared Function UpdateRecord(ByVal aArtist As clsArtists) As Integer
        Try
            Return clsArtistsDA.UpdateRecord(aArtist)
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsArtists. Method: UpdateRecord(Object). Error: " _
                            & ex.Message)
            Return -9
        End Try
    End Function

End Class
