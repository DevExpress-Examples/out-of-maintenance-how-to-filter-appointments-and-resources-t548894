Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraEditors
Imports DevExpress.Data.Filtering

Namespace CodeExampleTemplate
    Partial Public Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            schedulerControl1.Start = Date.Today
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            Dim helper As New InitHelper(Me.schedulerStorage1)

            schedulerStorage1.BeginUpdate()
            Try
                schedulerStorage1.Resources.DataSource = helper.InitResources()
                schedulerStorage1.Appointments.DataSource = helper.InitAppointments()
            Finally
                schedulerStorage1.EndUpdate()
            End Try
            schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
'            #Region "#filters"
            schedulerStorage1.Appointments.Filter = "Contains([Subject], 'travel') And [Start] >= #2017-08-24#"
            schedulerStorage1.Resources.Filter = "StartsWith([Caption], 'N')"
'            #End Region ' #filters

            btnApplyFilter.Enabled = False

        End Sub

        Private Sub AppointmentFilterControl_FilterStringChanged(ByVal sender As Object, ByVal e As EventArgs) Handles AppointmentFilterControl.FilterStringChanged
            btnApplyFilter.Enabled = True
        End Sub

        Private Sub ResourceFilterControl_FilterStringChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ResourceFilterControl.FilterStringChanged
            btnApplyFilter.Enabled = True
        End Sub

        Private Sub btnApplyFilter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnApplyFilter.Click
            AppointmentFilterControl.ApplyFilter()
            ResourceFilterControl.ApplyFilter()
            btnApplyFilter.Enabled = False
        End Sub
    End Class
End Namespace
