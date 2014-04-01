using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DungeonReminder.com.andaforce.arazect.axna.configuration;
using DungeonReminder.com.andaforce.arazect.dreminder.data;

namespace DungeonReminder.com.andaforce.arazect.dreminder.forms
{
    public partial class MainForm : Form
    {
        private const String Filename = "drm_value.xml";
        private DungeonReminderConfiguration _drc;
        private bool _gridIsUpdating;
        private BindingList<Dungeon> _bindingList;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            _drc = ConfigurationLoader
                .LoadConfiguration<DungeonReminderConfiguration>(Filename);

            RefreshDataBinding(_drc);
        }

        private void RefreshDataBinding(DungeonReminderConfiguration drc)
        {
            dgvDungeons.DataSource = null;
            _bindingList = new BindingList<Dungeon>(drc.Dungeons);
            dgvDungeons.DataSource = _bindingList;

        }

        #region Grid

        private void dgvDungeons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDungeons.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvDungeons_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                var checkBox = dgvDungeons.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                if (checkBox != null)
                {
                    SaveCurrent();
                }
            }
        }

        #endregion

        private void SaveCurrent()
        {
            _drc.LastUpdateDate = DateTime.Now;
            _drc.Dungeons = _bindingList.ToList();

            ConfigurationLoader.SaveConfiguration(_drc, Filename);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveCurrent();
        }
    }
}