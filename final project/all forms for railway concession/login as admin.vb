Public Class login_as_admin
    Dim rdr As System.Data.OleDb.OleDbDataReader
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Private Property KeyAscii As Integer


   

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        welcome_to_system.Show()
        Me.Visible = False

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub login_as_admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=MSDAORA;Data Source=XE;Persist Security Info=True;User ID=system;PASSWORD=ashita;Unicode=true;"
        Try
            con.Open()
            cmd.Connection = con
            MsgBox("connection successfull")
        Catch ex As Exception
            MsgBox("connection unsuccessfull")
        End Try

    End Sub

   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String
        str = "select * from pswadmin"
        cmd.CommandText = str
        rdr = cmd.ExecuteReader()
        If rdr.Read = True Then
            TextBox3.Text = rdr(1).ToString

            If (TextBox3.Text = TextBox2.Text) Then
                MsgBox("login successfull")
                Me.Visible = False
            Else
                MsgBox("WRONG PASSWORD!!! ENTER IT AGAIN")
            End If

        End If


        rdr.Close()
        Adminaccess.Show()
        Me.Visible = False
        



    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class