Public Class TICKET

    Dim rdr As System.Data.OleDb.OleDbDataReader
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String
        str = "insert into ticket_information values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "'," + TextBox6.Text + ")"

        cmd.CommandText = str
        cmd.ExecuteNonQuery()


        MsgBox("information saved successfully")
        ' rdr.Close()



        Me.Visible = False
        Welcome_student.Show()


    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TICKET_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=MSDAORA;Data Source=XE;Persist Security Info=True;User ID=system;PASSWORD=ashita;Unicode=true;"
        Try
            con.Open()
            cmd.Connection = con
            ' MsgBox("connection successfull")
        Catch ex As Exception
            MsgBox("connection unsuccessfull!!!TRY AFTER SOME TIME")
        End Try
    End Sub

    Private Sub TextBox1_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim x As Char
        x = e.KeyChar
        If x >= "0" And x <= "9" Then
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class