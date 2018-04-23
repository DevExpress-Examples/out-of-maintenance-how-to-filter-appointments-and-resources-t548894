using DevExpress.XtraScheduler;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CodeExampleTemplate {
    class InitHelper {
        SchedulerStorage Storage { get; set; }
        public static Random RandomInstance = new Random();

        private List<CustomResource> CustomResourceCollection = new List<CustomResource>();
        private List<CustomAppointment> CustomEventList = new List<CustomAppointment>();

        public InitHelper (SchedulerStorage currentStorage) {
            Storage = currentStorage;
        }

        public List<CustomResource> InitResources() {
        ResourceMappingInfo mappings = this.Storage.Resources.Mappings;
            mappings.Id = "ResID";
            mappings.Caption = "Name";
            mappings.Color = "ResColor";
            CustomResourceCollection.Add(CreateCustomResource(1, "Max Fowler", Color.PowderBlue));
            CustomResourceCollection.Add(CreateCustomResource(2, "Nancy Drewmore", Color.PaleVioletRed));
            CustomResourceCollection.Add(CreateCustomResource(3, "Pak Jang", Color.PeachPuff));
            return CustomResourceCollection;
        }

        private CustomResource CreateCustomResource(int res_id, string caption, Color resColor) {
            CustomResource cr = new CustomResource();
            cr.ResID = res_id;
            cr.Name = caption;
            cr.ResColor = resColor;
            return cr;
        }

        public List<CustomAppointment> InitAppointments() {
            AppointmentMappingInfo mappings = this.Storage.Appointments.Mappings;
            mappings.Start = "StartTime";
            mappings.End = "EndTime";
            mappings.Subject = "Subject";
            mappings.AllDay = "AllDay";
            mappings.Description = "Description";
            mappings.Label = "Label";
            mappings.Location = "Location";
            mappings.RecurrenceInfo = "RecurrenceInfo";
            mappings.ReminderInfo = "ReminderInfo";
            mappings.ResourceId = "OwnerId";
            mappings.Status = "Status";
            mappings.Type = "EventType";

            GenerateEvents(CustomEventList, 3);

            return CustomEventList;
        }

        private void GenerateEvents(List<CustomAppointment> eventList, int count) {
            for (int i = 0; i < count; i++) {
                CustomResource c_Resource = CustomResourceCollection[i];
                string subjPrefix = c_Resource.Name + "'s ";
                eventList.Add(CreateEvent(subjPrefix + "meeting", "The meeting will be held in the Conference Room", c_Resource.ResID, 2, 5));
                eventList.Add(CreateEvent(subjPrefix + "travel", "Book a hotel in advance", c_Resource.ResID, 3, 6));
                eventList.Add(CreateEvent(subjPrefix + "phone call", "Important phone call", c_Resource.ResID, 0, 10));
            }
        }

        private CustomAppointment CreateEvent(string subject, string additionalInfo, object resourceId, int status, int label) {
            CustomAppointment apt = new CustomAppointment();
            apt.Subject = subject;
            apt.OwnerId = resourceId;
            Random rnd = RandomInstance;
            int rangeInMinutes = 60 * 24;
            apt.StartTime = DateTime.Today + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes));
            apt.EndTime = apt.StartTime + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes / 4));
            apt.Status = status;
            apt.Label = label;
            return apt;
        }
    }
}
