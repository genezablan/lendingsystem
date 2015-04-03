Public Class frmCustomers

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub SplitContainer3_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer3.Panel1.Paint

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        If frmAddCustomer.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.OnLoad(e)
        End If
    End Sub

    Private Sub SplitContainer3_SplitterMoved(sender As Object, e As SplitterEventArgs)

    End Sub
End Class