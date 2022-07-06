Imports System.Data
Imports System.Data.OleDb
Public Class DBControl

    ' CREATE YOUR DB CONNECTION
    Private DBCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" &
                                        "Data Source=\\l4pncdot01svm02\WebsInc\Access DB - Prod Support\Prod Support Issue Tracking_be.accdb;")
    'Private DBCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" &
    '                                    "Data Source=\\l4pncdot01svm02\WebsInc\Alain\Issue Log (Access DB)\For Dev Testing\Prod Support Issue Tracking_be.accdb;")

    ' PREPARE DB COMMAND
    Private DBCmd As OleDbCommand

    ' DB DATA
    Public DBDA As OleDbDataAdapter
    Public DBDT As DataTable
    Public ChannelsDA As OleDbDataAdapter
    Public ChannelsDT As DataTable
    Public ClientsDA As OleDbDataAdapter
    Public ClientsDT As DataTable
    Public ContactsDA As OleDbDataAdapter
    Public ContactsDT As DataTable

    ' QUERY PARAMETERS
    Public Params As New List(Of OleDbParameter)

    ' QUERY STATISTICS
    Public RecordCount As Integer
    Public Exception As String

    Public Sub ExecQuery(Query As String)
        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""

        Try
            ' OPEN A CONNECTION
            DBCon.Open()

            ' CREATE DB COMMAND
            DBCmd = New OleDbCommand(Query, DBCon)

            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            ' CLEAR PARAMS LIST
            Params.Clear()

            ' EXECUTE COMMAND & FILL DATATABLE
            DBDT = New DataTable
            DBDA = New OleDbDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)
        Catch ex As Exception
            Exception = ex.Message
        End Try

        ' CLOSE YOUR CONNECTION
        If DBCon.State = ConnectionState.Open Then DBCon.Close()
    End Sub

    ' INCLUDE QUERY & COMMAND PARAMETERS
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New OleDbParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    Public Sub StartupQueries(QryTbl As String, Query As String)
        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""

        Try
            ' OPEN A CONNECTION
            DBCon.Open()

            ' CREATE DB COMMAND
            DBCmd = New OleDbCommand(Query, DBCon)

            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            ' CLEAR PARAMS LIST
            Params.Clear()

            ' EXECUTE COMMAND & FILL DATATABLE
            Select Case QryTbl
                Case = "Channels"
                    ChannelsDT = New DataTable
                    ChannelsDA = New OleDbDataAdapter(DBCmd)
                    RecordCount = ChannelsDA.Fill(ChannelsDT)
                Case = "Clients"
                    ClientsDT = New DataTable
                    ClientsDA = New OleDbDataAdapter(DBCmd)
                    RecordCount = ClientsDA.Fill(ClientsDT)
                Case = "Contacts"
                    ContactsDT = New DataTable
                    ContactsDA = New OleDbDataAdapter(DBCmd)
                    RecordCount = ContactsDA.Fill(ContactsDT)
            End Select

        Catch ex As Exception
            Exception = ex.Message
        End Try

        ' CLOSE YOUR CONNECTION
        If DBCon.State = ConnectionState.Open Then DBCon.Close()
    End Sub

End Class
