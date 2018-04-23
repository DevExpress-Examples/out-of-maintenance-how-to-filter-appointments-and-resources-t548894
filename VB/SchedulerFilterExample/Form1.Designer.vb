Namespace CodeExampleTemplate
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler3 As New DevExpress.XtraScheduler.TimeRuler()
            Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.noDocumentsView1 = New DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView(Me.components)
            Me.tabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
            Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.dockPanel3 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.AppointmentFilterControl = New DevExpress.XtraEditors.FilterControl()
            Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.ResourceFilterControl = New DevExpress.XtraEditors.FilterControl()
            Me.btnApplyFilter = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.noDocumentsView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanel3.SuspendLayout()
            Me.panelContainer1.SuspendLayout()
            Me.dockPanel1.SuspendLayout()
            Me.dockPanel1_Container.SuspendLayout()
            Me.dockPanel2.SuspendLayout()
            Me.dockPanel2_Container.SuspendLayout()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' documentManager1
            ' 
            Me.documentManager1.ClientControl = Me.schedulerControl1
            Me.documentManager1.View = Me.noDocumentsView1
            Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() { Me.noDocumentsView1, Me.tabbedView1})
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.DataStorage = Me.schedulerStorage1
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.Size = New System.Drawing.Size(515, 507)
            Me.schedulerControl1.Start = New Date(2017, 8, 24, 0, 0, 0, 0)
            Me.schedulerControl1.TabIndex = 1
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl1.Views.FullWeekView.Enabled = True
            Me.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2)
            Me.schedulerControl1.Views.WeekView.Enabled = False
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3)
            ' 
            ' tabbedView1
            ' 
            Me.tabbedView1.RootContainer.Element = Nothing
            ' 
            ' dockManager1
            ' 
            Me.dockManager1.Form = Me
            Me.dockManager1.HiddenPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.dockPanel3})
            Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.panelContainer1})
            Me.dockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            ' 
            ' dockPanel3
            ' 
            Me.dockPanel3.Controls.Add(Me.dockPanel3_Container)
            Me.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanel3.FloatLocation = New System.Drawing.Point(616, 415)
            Me.dockPanel3.FloatVertical = True
            Me.dockPanel3.ID = New System.Guid("51aa1eca-048e-46a0-91cd-b1bb421d6cc7")
            Me.dockPanel3.Location = New System.Drawing.Point(-32768, -32768)
            Me.dockPanel3.Name = "dockPanel3"
            Me.dockPanel3.OriginalSize = New System.Drawing.Size(200, 57)
            Me.dockPanel3.SavedIndex = 1
            Me.dockPanel3.Size = New System.Drawing.Size(200, 200)
            Me.dockPanel3.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            ' 
            ' dockPanel3_Container
            ' 
            Me.dockPanel3_Container.Location = New System.Drawing.Point(4, 38)
            Me.dockPanel3_Container.Name = "dockPanel3_Container"
            Me.dockPanel3_Container.Size = New System.Drawing.Size(192, 158)
            Me.dockPanel3_Container.TabIndex = 0
            ' 
            ' panelContainer1
            ' 
            Me.panelContainer1.Controls.Add(Me.dockPanel1)
            Me.panelContainer1.Controls.Add(Me.dockPanel2)
            Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.panelContainer1.ID = New System.Guid("2e73d1b4-3c0b-4b06-a470-407dce7539f0")
            Me.panelContainer1.Location = New System.Drawing.Point(515, 0)
            Me.panelContainer1.Name = "panelContainer1"
            Me.panelContainer1.OriginalSize = New System.Drawing.Size(269, 200)
            Me.panelContainer1.Size = New System.Drawing.Size(269, 561)
            Me.panelContainer1.Text = "panelContainer1"
            ' 
            ' dockPanel1
            ' 
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel1.FloatVertical = True
            Me.dockPanel1.ID = New System.Guid("32f0603f-453f-41f7-8eb5-c4126bf3f377")
            Me.dockPanel1.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(200, 281)
            Me.dockPanel1.Size = New System.Drawing.Size(269, 281)
            Me.dockPanel1.Text = "Appointment Filter"
            ' 
            ' dockPanel1_Container
            ' 
            Me.dockPanel1_Container.Controls.Add(Me.AppointmentFilterControl)
            Me.dockPanel1_Container.Location = New System.Drawing.Point(5, 38)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(260, 238)
            Me.dockPanel1_Container.TabIndex = 0
            ' 
            ' AppointmentFilterControl
            ' 
            Me.AppointmentFilterControl.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.AppointmentFilterControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.AppointmentFilterControl.Location = New System.Drawing.Point(0, 0)
            Me.AppointmentFilterControl.Name = "AppointmentFilterControl"
            Me.AppointmentFilterControl.Size = New System.Drawing.Size(260, 238)
            Me.AppointmentFilterControl.SourceControl = Me.schedulerStorage1.Appointments
            Me.AppointmentFilterControl.TabIndex = 0
            ' 
            ' dockPanel2
            ' 
            Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel2.ID = New System.Guid("188bfab6-9ace-4b66-a65a-b97c53af28a0")
            Me.dockPanel2.Location = New System.Drawing.Point(0, 281)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.OriginalSize = New System.Drawing.Size(200, 280)
            Me.dockPanel2.Size = New System.Drawing.Size(269, 280)
            Me.dockPanel2.Text = "Resource Filter"
            ' 
            ' dockPanel2_Container
            ' 
            Me.dockPanel2_Container.Controls.Add(Me.ResourceFilterControl)
            Me.dockPanel2_Container.Location = New System.Drawing.Point(5, 38)
            Me.dockPanel2_Container.Name = "dockPanel2_Container"
            Me.dockPanel2_Container.Size = New System.Drawing.Size(260, 238)
            Me.dockPanel2_Container.TabIndex = 0
            ' 
            ' ResourceFilterControl
            ' 
            Me.ResourceFilterControl.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.ResourceFilterControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ResourceFilterControl.Location = New System.Drawing.Point(0, 0)
            Me.ResourceFilterControl.Name = "ResourceFilterControl"
            Me.ResourceFilterControl.Size = New System.Drawing.Size(260, 238)
            Me.ResourceFilterControl.SourceControl = Me.schedulerStorage1.Resources
            Me.ResourceFilterControl.TabIndex = 0
            ' 
            ' btnApplyFilter
            ' 
            Me.btnApplyFilter.AutoWidthInLayoutControl = True
            Me.btnApplyFilter.Location = New System.Drawing.Point(12, 12)
            Me.btnApplyFilter.Name = "btnApplyFilter"
            Me.btnApplyFilter.Size = New System.Drawing.Size(491, 30)
            Me.btnApplyFilter.StyleController = Me.layoutControl1
            Me.btnApplyFilter.TabIndex = 10
            Me.btnApplyFilter.Text = "Apply Filter"
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.btnApplyFilter)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.layoutControl1.Location = New System.Drawing.Point(0, 507)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(632, 338, 450, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(515, 54)
            Me.layoutControl1.TabIndex = 3
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(515, 54)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.btnApplyFilter
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(65, 26)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(495, 34)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 561)
            Me.Controls.Add(Me.schedulerControl1)
            Me.Controls.Add(Me.layoutControl1)
            Me.Controls.Add(Me.panelContainer1)
            Me.Name = "Form1"
            Me.Text = "Scheduler Filter Example"
            CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.noDocumentsView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanel3.ResumeLayout(False)
            Me.panelContainer1.ResumeLayout(False)
            Me.dockPanel1.ResumeLayout(False)
            Me.dockPanel1_Container.ResumeLayout(False)
            Me.dockPanel2.ResumeLayout(False)
            Me.dockPanel2_Container.ResumeLayout(False)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private documentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
        Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
        Private noDocumentsView1 As DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView
        Private tabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
        Private dockManager1 As DevExpress.XtraBars.Docking.DockManager
        Private panelContainer1 As DevExpress.XtraBars.Docking.DockPanel
        Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private WithEvents AppointmentFilterControl As DevExpress.XtraEditors.FilterControl
        Private dockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Private dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private WithEvents ResourceFilterControl As DevExpress.XtraEditors.FilterControl
        Private dockPanel3 As DevExpress.XtraBars.Docking.DockPanel
        Private dockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private WithEvents btnApplyFilter As DevExpress.XtraEditors.SimpleButton
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace

