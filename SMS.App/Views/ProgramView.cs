using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.App
{
    public partial class ProgramView : Form, IProgramView
    {
        public ProgramView()
        {
            InitializeComponent();
        }

        public int ProgramId { get => Convert.ToInt16(textBoxID.Text); set => textBoxID.Text = value.ToString(); }
        public string ProgramName { get => textBoxProgramName.Text.Trim(); set => textBoxProgramName.Text = value; }
        public string Description { get => textBoxDescription.Text.Trim(); set => textBoxDescription.Text = value; }

        public void GetProgramList(BindingSource bindingSource)
        {
            dataGridViewProgramList.DataSource = bindingSource;
        }

        public event EventHandler CreateEvent;
        public event EventHandler ReadEvent;
        public event EventHandler UpdateEvent;
        public event EventHandler DeleteEvent;


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CreateEvent?.Invoke(this, EventArgs.Empty);
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            ReadEvent?.Invoke(this, EventArgs.Empty);
        }
        
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateEvent?.Invoke(this, EventArgs.Empty);
        }
        
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
