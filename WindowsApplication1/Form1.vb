Public Class Form1
    Private Sub clbCanciones_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbCanciones.ItemCheck

        Dim Monto As Double
        Monto = 0
        'ToolTip1.SetToolTip(Button1, "Save changes")

        If clbCanciones.CheckedItems.Count = 0 Then
            txbP_Cancion.Text = "S/.  5.99"
            Monto &= 5.99
            txbP_Total.Text = CStr(Monto)
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class
