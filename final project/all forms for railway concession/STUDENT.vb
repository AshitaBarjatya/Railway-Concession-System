Public Class STUDENT

    Dim rdr As System.Data.OleDb.OleDbDataReader
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Private Sub STUDENT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Dim caste As String
        If RadioButton1.Checked = True Then
            caste = "Genral"
        End If

        If RadioButton2.Checked = True Then
            caste = "OBC"

        End If
        If RadioButton3.Checked = True Then
            caste = "SC/ST"

        End If

        'If RadioButton2.Checked = True Then
        'caste = "OBC"
        'End If
        ' If RadioButton1.Checked = True Then
        'caste = "SC/ST"
        '  End If
        TextBox1.Text = caste


        ' str = "insert into student_information values ('" + TextBox2.Text + "','" + TextBox3.Text + "', '" + TextBox1.Text + "','" + RichTextBox1.Text + "','" + RichTextBox2.Text + " ')"
        str = "insert into student_information values ('" + TextBox3.Text + "','" + TextBox2.Text + "','" + TextBox1.Text + "','" + RichTextBox1.Text + "','" + RichTextBox2.Text + "')"
        cmd.CommandText = str
        cmd.ExecuteNonQuery()


        MsgBox("information saved successfully")
        ' rdr.Close()
        TICKET.Show()
        Me.Visible = False
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim x As Char
        x = e.KeyChar
        If x >= "0" And x <= "9" Then

        Else
            e.Handled = True
        End If

    End Sub

    

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        Dim x As Char
        x = e.KeyChar
        If x >= "0" And x <= "9" Then
            e.Handled = True
        
        End If

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        ' If RadioButton1.Checked = True Then
        'MsgBox("gotchya")
        'End If

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        

    End Sub
End Class
