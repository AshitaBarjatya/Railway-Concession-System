Public Class status
    Dim rdr As System.Data.OleDb.OleDbDataReader
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Private Sub status_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=MSDAORA;Data Source=XE;Persist Security Info=True;User ID=system;PASSWORD=ashita;Unicode=true;"
        Try
            con.Open()
            cmd.Connection = con
            ' MsgBox("connection successfull")
        Catch ex As Exception
            MsgBox("connection unsuccessfull!!!TRY AFTER SOME TIME")
        End Try
    End Sub

   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String
        str = "select * from status where (roll_no=" + TextBox1.Text + ")"
        cmd.CommandText = str
        rdr = cmd.ExecuteReader()
        If rdr.Read = True Then
            RichTextBox1.Text = rdr(1).ToString
            RichTextBox1.Visible = True
            RichTextBox1.Enabled = False

            Label2.Visible = True
            Label3.Visible = True

            RichTextBox2.Text = rdr(2).ToString
            RichTextBox2.Visible = True
            RichTextBox2.Enabled = False


            Else
            MsgBox("YOU HAVE NOT REGISTERD YET")

        End If

        rdr.Close()



    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub RichTextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Welcome_student.Show()
        Me.Visible = False
    End Sub
End Class