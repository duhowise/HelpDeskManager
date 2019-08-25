using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HelpDeskManager.UI.HelpDeskManagerService;

namespace HelpDeskManager.UI
{
    public partial class HelpDesk : DevExpress.XtraEditors.XtraForm
    {
        List<BOVisitation> _visitations = new List<BOVisitation>();
        BOVisitation _selectedVisitation = new BOVisitation();
        HelpDeskManagerServiceClient _helpDeskManagerService = new HelpDeskManagerServiceClient();

        public HelpDesk()
        {
            InitializeComponent();
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            _visitations = _helpDeskManagerService.VisitationCollection().ToList();
            foreach (var visit in _visitations)
            {
                ListViewItem visitation = new ListViewItem();
                visitation.Text=visit.Name;
                visitation.SubItems.Add(visit.Arrived.ToString());
                visitation.SubItems.Add(visit.Departed.ToString());
                listView1.Items.Add(visitation);

            }
        }

       
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            List<BOVisitation> _searchVisitations = new List<BOVisitation>();
            _searchVisitations = _visitations.FindAll(x => x.Name.ToLower().Contains($"{searchbox.Text.ToLower()}")).ToList();
            foreach (var visit in _searchVisitations)
            {
                ListViewItem visitation = new ListViewItem();
                visitation.Text = visit.Name;
                visitation.SubItems.Add(visit.Arrived.ToString());
                visitation.SubItems.Add(visit.Departed.ToString());
                listView2.Items.Add(visitation);

            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new Edit().ShowDialog();
            if (listView1.SelectedItems[0].Text!="")
                GetDetails(listView1);
        }

        protected void GetDetails(ListView listView)
        {
            ListViewItem item = new ListViewItem();
            item = listView.SelectedItems[0];
            var name = item.Text;
            var arrived = item.SubItems[1].Text;
            _selectedVisitation = _visitations.Find(x => x.Name == $"{name}" && x.Arrived.ToString() == arrived);
            Nametxt.Text = _selectedVisitation.Name;
            Purposetxt.Text = _selectedVisitation.Purpose;
            int staffid = Convert.ToInt32(_selectedVisitation.Staffid);
            var staff = _helpDeskManagerService.GetStaff(staffid);
            Persontxt.Text = staff.Name;
            ArrivalDate.DateTime = _selectedVisitation.Arrived.Value;
            DepartureDate.DateTime = _selectedVisitation.Departed.Value;
        }

        private void listView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new Edit().ShowDialog();
            if (listView2.SelectedItems[0].Text != "")
                GetDetails(listView2);
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                ArrivalDate.DateTime=DateTime.Now;    
            }
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit2.Checked)
            {
                DepartureDate.DateTime = DateTime.Now;
            }
        }
    }
}
