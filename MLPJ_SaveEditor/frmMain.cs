using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLPJ_SaveEditor
{
    public partial class frmMain : Form
    {
        private SaveFile m_savefile;

        public frmMain()
        {
            InitializeComponent();
            
        }
        
        private void Save()
        {
            if (m_savefile == null)
                return;

            if (sfdGameSave.ShowDialog() == DialogResult.OK)
            {
                SetCheats();
                m_savefile.Save(sfdGameSave.FileName);
                MessageBox.Show("Finished!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SetCheats()
        {
            for (int i = 0; i < tabCheats.TabPages.Count; ++i)
            {
                TabPage page = tabCheats.TabPages[i];

                for (int j = 0; j < page.Controls.Count; ++j)
                {
                    Control control = page.Controls[j];

                    if (control is CheckBox)
                    {
                        CheckBox tempControl = control as CheckBox;
                        if (tempControl.Checked)
                        {
                            switch((string)tempControl.Tag)
                            {
                                case "MaxLevel":
                                    m_savefile.Characters[page.Text].MaxLevel();
                                    break;
                                case "MaxAddedStats":
                                    m_savefile.Characters[page.Text].MaxAddedStats();
                                    break;
                                case "MaxInventory":
                                    m_savefile.Inventory.MaxInventory();
                                    break;
                                case "MaxCoins":
                                    m_savefile.MaxCoins();
                                    break;
                            }
                        }
                    }
                    else if (control is ComboBox)
                    {
                        ComboBox tempControl = control as ComboBox;
                        string tag = (string)tempControl.Tag;

                        if (tag != "(None)")
                        {
                            if (tempControl.SelectedIndex > -1)
                                m_savefile.Characters[page.Text].SetRankBonus(tag, tempControl.SelectedIndex - 1);
                        }

                    }
                }
            }
        }

        private void msFileOpen_Click(object sender, EventArgs e)
        {
            if (ofdGameSave.ShowDialog() == DialogResult.OK)
            {
                m_savefile = new SaveFile(ofdGameSave.FileName);
                MessageBox.Show("File loaded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void msFileSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void msFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
