using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whatsoccuring2
{
    public partial class TaskEntryForm : Form
    {
        public string TaskTitle
        {
            get
            {
                return txtTitle.Text;
            }
            set
            {
                txtTitle.Text = value;
            }
        }
        public string TaskDescription
        {
            get
            {
                return rtbDescription.Text;
            }
            set
            {
                rtbDescription.Text = value;
            }
        }
        public DateTime TaskDueDate
        {
            get
            {
                return dtpDueDate.Value;
            }
            set
            {
                dtpDueDate.Value = value;
            }
        }

        public TaskEntryForm()
        {
            InitializeComponent();
        }

        private void TaskEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                MessageBox.Show("Title is required", "Validation Error");
                return;
            }

            if (string.IsNullOrEmpty(rtbDescription.Text))
            {
                MessageBox.Show("Description is required", "Validation Error");
                return;
            }

            if (dtpDueDate.Value < DateTime.Today)
            {
                MessageBox.Show("The date is too old! Try Again.", "Validation Error");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
