using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.XtraEditors;
using DevExpress.Data.Filtering;

namespace CodeExampleTemplate {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
            schedulerControl1.Start = DateTime.Today;
        }

        private void Form1_Load(object sender, EventArgs e) {
            InitHelper helper = new InitHelper(this.schedulerStorage1);

            schedulerStorage1.BeginUpdate();
            try {
                schedulerStorage1.Resources.DataSource = helper.InitResources();
                schedulerStorage1.Appointments.DataSource = helper.InitAppointments();
            }
            finally {
                schedulerStorage1.EndUpdate();
            }
            schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            #region #filters
            schedulerStorage1.Appointments.Filter = "Contains([Subject], 'travel') And [Start] >= #2017-08-24#";
            schedulerStorage1.Resources.Filter = "StartsWith([Caption], 'N')";
            #endregion #filters

            btnApplyFilter.Enabled = false;
            
        }

        private void AppointmentFilterControl_FilterStringChanged(object sender, EventArgs e) {
            btnApplyFilter.Enabled = true;
        }

        private void ResourceFilterControl_FilterStringChanged(object sender, EventArgs e) {
            btnApplyFilter.Enabled = true;
        }

        private void btnApplyFilter_Click(object sender, EventArgs e) {
            AppointmentFilterControl.ApplyFilter();
            ResourceFilterControl.ApplyFilter();
            btnApplyFilter.Enabled = false;
        }
    }
}
