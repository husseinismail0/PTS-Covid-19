Public Class Form1
    Dim sqlnya As String
    Sub panggildata()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_klinik", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_klinik")
        DataGridView1.DataSource = DS.Tables("tb_klinik")
        DataGridView1.Enabled = True
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False
        CheckBox12.Checked = False
        CheckBox13.Checked = False
        CheckBox14.Checked = False
        CheckBox15.Checked = False
        CheckBox16.Checked = False
        CheckBox17.Checked = False
        CheckBox18.Checked = False
        CheckBox19.Checked = False
        CheckBox20.Checked = False
        CheckBox21.Checked = False
    End Sub
    Sub jalan()
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call konek()
        objcmd.Connection = conn
        objcmd.CommandType = CommandType.Text
        objcmd.CommandText = sqlnya
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Label4.Text = ""
        Label5.Text = ""
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call panggildata()
    End Sub
    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        TextBox1.Text = DataGridView1.Item(0, i).Value
        TextBox2.Text = DataGridView1.Item(1, i).Value
        TextBox3.Text = DataGridView1.Item(2, i).Value
        Label5.Text = DataGridView1.Item(3, i).Value
        Label4.Text = DataGridView1.Item(4, i).Value
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '-------------------------------------------------------CheckedBox--------------------------------------'
        If CheckBox1.Checked = True Then
            Label4.Text = Val(Label4.Text) + 1
        End If

        If CheckBox2.Checked = True Then
            Label4.Text = Val(Label4.Text) + 1
        End If

        If CheckBox3.Checked = True Then
            Label4.Text = Val(Label4.Text) + 1
        End If

        If CheckBox4.Checked = True Then
            Label4.Text = Val(Label4.Text) + 1
        End If

        If CheckBox5.Checked = True Then
            Label4.Text = Val(Label4.Text) + 1
        End If

        If CheckBox6.Checked = True Then
            Label4.Text = Val(Label4.Text) + 1
        End If

        If CheckBox7.Checked = True Then
            Label4.Text = Val(Label4.Text) + 1
        End If

        If CheckBox8.Checked = True Then
            Label4.Text = Val(Label4.Text) + 1
        End If

        If CheckBox9.Checked = True Then
            Label4.Text = Val(Label4.Text) + 1
        End If

        If CheckBox10.Checked = True Then
            Label4.Text = Val(Label4.Text) + 1
        End If

        If CheckBox11.Checked = True Then
            Label4.Text = Val(Label4.Text) + 1
        End If

        If CheckBox12.Checked = True Then
            Label4.Text = Val(Label4.Text) + 1
        End If

        If CheckBox13.Checked = True Then
            Label4.Text = Val(Label4.Text) + 1
        End If

        If CheckBox14.Checked = True Then
            Label4.Text = Val(Label4.Text) + 1
        End If

        If CheckBox15.Checked = True Then
            Label4.Text = Val(Label4.Text) + 1
        End If

        If CheckBox16.Checked = True Then
            Label4.Text = Val(Label4.Text) + 1
        End If

        If CheckBox17.Checked = True Then
            Label4.Text = Val(Label4.Text) + 1
        End If

        If CheckBox18.Checked = True Then
            Label4.Text = Val(Label4.Text) + 1
        End If

        If CheckBox19.Checked = True Then
            Label4.Text = Val(Label4.Text) + 1
        End If

        If CheckBox20.Checked = True Then
            Label4.Text = Val(Label4.Text) + 1
        End If

        If CheckBox21.Checked = True Then
            Label4.Text = Val(Label4.Text) + 1
        End If

        '------------------------------------------RESIKO CORONA----------------------------------------------------------'

        If Label4.Text < 8 Then
            Label5.Text = "Rendah"
        ElseIf Label4.Text < 15 Then
            Label5.Text = "Sedang"
        ElseIf Label4.Text < 22 Then
            Label5.Text = "Tinggi"
        End If
        '------------------------------------------------------Data-------------------------------------------'
        sqlnya = "insert into tb_klinik (Nama,NIK,Umur,Bahaya,Ceklis) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & Label5.Text & "','" & Label4.Text & "')"
        Call jalan()
        MsgBox("Data Berhasil Tersimpan")
        Call panggildata()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sqlnya = "delete from tb_klinik where NIK='" & TextBox2.Text & "'"
        Call jalan()
        MsgBox("Data Berhasil Dihapus")
        Call panggildata()
    End Sub
End Class
