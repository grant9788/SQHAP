Public Class frmMaintenance
    Private Sub MaintenanceBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.MaintenanceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQHAP_DBDataSet)

    End Sub

    Private Sub frmMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQHAP_DBDataSet.Maintenance' table. You can move, or remove it, as needed.
        Me.MaintenanceTableAdapter.Fill(Me.SQHAP_DBDataSet.Maintenance)

    End Sub
End Class