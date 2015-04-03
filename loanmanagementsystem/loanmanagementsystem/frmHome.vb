Imports loanmanagementsystem.Models.DBConnection
Public Class frmHome

    Private Sub viewForm(ByVal myForm As Form)
        
        myForm.TopLevel = False
        myForm.Dock = DockStyle.Fill
        Me.SplitContainer2.Panel2.Controls.Clear()
        Me.SplitContainer2.Panel2.Controls.Add(myForm)
        myForm.Show()
    End Sub
    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If

        'Dim x As Integer = SplitContainer1.Panel2.Width - pnlLoanDetails.Width
        'Dim y As Integer = SplitContainer1.Panel2.Height - pnlLoanDetails.Height
        'pnlLoanDetails.Location = New Point(x / 2, y / 2)

        'Dim x1 As Integer = SplitContainer1.Panel2.Width - pnlPersonal.Width
        'Dim y1 As Integer = SplitContainer1.Panel2.Height - pnlPersonal.Height
        'pnlLoanDetails.Location = New Point(x1 / 2, y1 / 2)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()

    End Sub

    Private Sub frmHome_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
            NotifyIcon1.Visible = True
        End If
    End Sub

    Private Sub frmHome_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd

    End Sub

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()


        viewForm(frmMain)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel2.BackgroundImage = Image.FromFile(ICONS_URL & "sidebarCustomer.png")
        viewForm(frmCustomers)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel2.BackgroundImage = Image.FromFile(ICONS_URL & "sidebar.png")
        viewForm(frmMain)
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Panel2.BackgroundImage = Image.FromFile(ICONS_URL & "sidebarQuote.png")
        viewForm(frmQuotes)
    End Sub
End Class
