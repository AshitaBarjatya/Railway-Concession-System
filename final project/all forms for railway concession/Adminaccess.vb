Public Class Adminaccess
    Dim rdr As System.Data.OleDb.OleDbDataReader
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        welcome_to_system.Show()
        Me.Visible = False
    End Sub

    Private Sub Adminaccess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        If RadioButton1.Checked = True Then
            str = "select count(*) from student_information"
        End If
        If RadioButton2.Checked = True Then
            str = "select count(*) from status"
        End If

        If RadioButton3.Checked = True Then
            str = "select sum(fare_amt) from ticket_information"
        End If
        cmd.CommandText = str
        rdr = cmd.ExecuteReader()
        If rdr.Read = True Then

            TextBox1.Text = rdr(0).ToString
            GroupBox1.Visible = True
            TextBox1.Visible = True
            TextBox1.Enabled = False

            Label4.Visible = True

        End If

        rdr.Close()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class