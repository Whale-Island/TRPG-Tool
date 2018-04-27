using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trpg_Tool
{
    public partial class MainForm : Form
    {
        MemberListForm memberListForm;
        BattleForm battleForm;
        SettingsForm settingsForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            memberListForm = new MemberListForm();
            battleForm = new BattleForm();
            settingsForm = new SettingsForm();
        }

        private void MemberListButton_Click(object sender, EventArgs e)
        {
            memberListForm.Show();
        }

        private void BattleButton_Click(object sender, EventArgs e)
        {
            battleForm.Show();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            settingsForm.Show();
        }
    }
}
