using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment1 {
    public partial class StaffForm : Form {

        private Staff staff;

        public StaffForm() {
            InitializeComponent();
            InitializeGUI();
            if (staff == null) {
                staff = new Staff();
            }

        }

        public Staff Staff {
            get { return staff; }
            set { staff = value; }
        }

        private void InitializeGUI() {
            textBoxName.Text = string.Empty;
            listBoxQualifications.Items.Clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            staff.Qualifications.Add(textBoxQualification.Text);
            textBoxQualification.Clear();
            listBoxQualifications.Items.Clear();
            listBoxQualifications.Items.AddRange(staff.Qualifications.ToStringArray());
        }

        private void buttonChange_Click(object sender, EventArgs e) {
            int index = listBoxQualifications.SelectedIndex;
            staff.Qualifications.ChangeAt(textBoxQualification.Text, index);
            textBoxQualification.Clear();
            listBoxQualifications.Items.Clear();
            listBoxQualifications.Items.AddRange(staff.Qualifications.ToStringArray());
        }

        private void buttonDelete_Click(object sender, EventArgs e) {
            int index = listBoxQualifications.SelectedIndex;
            staff.Qualifications.DeleteAt(index);
            textBoxQualification.Clear();
            listBoxQualifications.Items.Clear();
            listBoxQualifications.Items.AddRange(staff.Qualifications.ToStringArray());
        }

        private void buttonOk_Click(object sender, EventArgs e) {
            if (textBoxName.Text != string.Empty) {
                //if (staff.Qualifications.Count > 0) { //Not usable as property not defined in IListManager(?)
                if (listBoxQualifications.Items.Count > 0) { 
                    staff.Name = textBoxName.Text;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                } else {
                    MessageBox.Show("Staff must have at least one qualification", "Error");
                }
            } else {
                MessageBox.Show("Name must be entered", "Error");
            }

        }

        private void listBoxIngredients_SelectedIndexChanged(object sender, EventArgs e) {
            int index = listBoxQualifications.SelectedIndex;
            textBoxQualification.Text = staff.Qualifications.GetAt(index);
        }
    }
}
