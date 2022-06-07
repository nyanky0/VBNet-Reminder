Imports System.Data.Odbc

Public Class FormUser

    Private Sub btnFututup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFututup.Click
        Call dgvfuclear()

        Me.Close()

        Call FormMenuUtama.updatedgv()
    End Sub
    Public Sub dgvfuclear()
        dgvFu.Rows.Clear()
        dgvFu.Columns.Clear()
    End Sub
    Public Sub dgvfuloaddata()
        
        Try
            Koneksi()
            Da = New OdbcDataAdapter("select * from tbl_user order by user_name asc", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            dgvFu.ColumnCount = 5
            dgvFu.Columns(0).Name = "USER NAME"
            dgvFu.Columns(1).Name = "USER ID"
            dgvFu.Columns(2).Name = "USER PASSWORD"
            dgvFu.Columns(3).Name = "USER STATUS"
            dgvFu.Columns(4).Name = "USER KODE"
            For Each row In Dt.Rows
                dgvFu.Rows.Add(row(1), row(0), row(2), row(3), row(4))
            Next
            Dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Error")
        End Try

    End Sub
    
    Sub dgvfusize()
        dgvFu.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFu.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFu.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFu.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFu.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
    Sub dgvfuaddbutton()
        Dim btnedit As New DataGridViewButtonColumn
        dgvFu.Columns.Add(btnedit)
        btnedit.HeaderText = ""
        btnedit.Text = "Edit"
        btnedit.Name = "btnpass"
        btnedit.UseColumnTextForButtonValue = True
        Dim btnhapus As New DataGridViewButtonColumn
        dgvFu.Columns.Add(btnhapus)
        btnhapus.HeaderText = ""
        btnhapus.Text = "Hapus User"
        btnhapus.Name = "btnhapus"
        btnhapus.UseColumnTextForButtonValue = True
    End Sub
    Public Sub dgvload()

        dgvfuclear()
        dgvfuloaddata()
        dgvfusize()
        dgvfuaddbutton()
        dgvFu.Columns(2).Visible = False
        btnPass.Text = "TAMPILKAN PASSWORD"
    End Sub
    Private Sub FormUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call dgvload()
    End Sub
    Private Sub dgvFu_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFu.CellClick
        If e.ColumnIndex = 5 Then
            FormUserInput.gbFui.Text = "EDIT USER"
            FormUserInput.txtFuiid.ReadOnly = True
            FormUserInput.txtFuiname.ReadOnly = True
            FormUserInput.txtFuikode.ReadOnly = True
            FormUserInput.txtFuiid.Text = dgvFu.CurrentRow.Cells(1).Value.ToString
            FormUserInput.txtFuiname.Text = dgvFu.CurrentRow.Cells(0).Value.ToString
            FormUserInput.txtFuipass.Text = dgvFu.CurrentRow.Cells(2).Value.ToString
            FormUserInput.txtFuikode.Text = dgvFu.CurrentRow.Cells(4).Value.ToString
            FormUserInput.cbFui.Text = dgvFu.CurrentRow.Cells(3).Value.ToString
            If FormUserInput.txtFuiname.Text = FormMenuUtama.txtFmuuser.Text Or FormUserInput.txtFuiname.Text = "ADMINISTRATOR" Then
                FormUserInput.cbFui.Visible = False
                FormUserInput.Label5.Visible = False
            Else
                FormUserInput.cbFui.Visible = True
                FormUserInput.Label5.Visible = True
            End If
            FormUserInput.ShowDialog()
        ElseIf e.ColumnIndex = 6 Then
            Dim id As String
            id = dgvFu.CurrentRow.Cells(0).Value.ToString
            FormUserHapus.cbFuh.Visible = False
            FormUserHapus.txtFuhid.Text = id
            FormUserHapus.ShowDialog()
        End If
    End Sub

    Private Sub btnPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPass.Click
        If btnPass.Text = "TAMPILKAN PASSWORD" Then
            btnPass.Text = "SEMBUNYIKAN PASSWORD"
            dgvFu.Columns(2).Visible = True
        Else
            btnPass.Text = "TAMPILKAN PASSWORD"
            dgvFu.Columns(2).Visible = False
        End If
    End Sub

    Private Sub btnFuinput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFuinput.Click
        FormUserInput.gbFui.Text = "INPUT USER"
        FormUserInput.txtFuiid.ReadOnly = False
        FormUserInput.txtFuiname.ReadOnly = False
        FormUserInput.txtFuikode.ReadOnly = False
        FormUserInput.ShowDialog()

    End Sub

    Private Sub btnFuhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFuhapus.Click
        FormUserHapus.cbFuh.Visible = True
        FormUserHapus.ShowDialog()

    End Sub
End Class