Public Class frmLoadingScreen
    Dim i As Integer = 0
    Private Sub tmrLoad_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLoad.Tick
        If prgLoader.Value = 100 Then
            lblLoading.Text = "Status: Complete"
            If i = 20 Then
                frmWriteFileWithArray.Show()
                Me.Hide()
                tmrLoad.Enabled = False
            Else
                i += 1
            End If
        Else
            prgLoader.Value += 1
        End If
    End Sub
End Class