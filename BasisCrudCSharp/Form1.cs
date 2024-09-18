using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicCrudCSharp.model;
using BasicCrudCSharp.view;
using BasicCrudCSharp.presenter;

namespace BasicCrudCSharp
{
    public partial class Form1 : Form, IUserView
    {
        public event EventHandler AddNewRecord;

        public Form1()
        {
            InitializeComponent();
            new UserPrensenter(this, new UserModel());

        }

        public string Name
        {
            get => nameTxtBox.Text;
            set => nameTxtBox.Text = value;
        }

        public int Age
        {
            get => Convert.ToInt32(ageTxtBox.Text);
            set => ageTxtBox.Text = value.ToString();
        }

        public string Email
        {
            get => emailTxtBox.Text;
            set => emailTxtBox.Text = value;
        }

        public void RefreshDGV(List<IUserModel> NewRecord)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = NewRecord;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewRecord?.Invoke(this, EventArgs.Empty);
        }
    }
}
