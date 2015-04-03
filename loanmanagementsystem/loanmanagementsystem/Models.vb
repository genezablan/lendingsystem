Imports System.Data.SqlClient
Module Models
    Public Class DBConnection
        Private Shared con As New SqlConnection(My.Computer.FileSystem.ReadAllText(BASE_URL & "/config.txt"))

        Public Shared Sub Connect()
            Try
                If con.State <> ConnectionState.Open Then
                    con.Open()
                End If
            Catch ex As Exception
                Throw ex
            End Try
           
        End Sub


    End Class
End Module
