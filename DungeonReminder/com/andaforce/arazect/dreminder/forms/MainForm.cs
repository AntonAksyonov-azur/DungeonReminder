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

        private void MainForm_Load(object sender, EventArgs e)
        {
            _drc = ConfigurationLoader
                .LoadConfiguration<DungeonReminderConfiguration>(Filename);

            RefreshBindings();
        }

        #region Bindings

        private void RefreshBindings()
        {
            RefreshDataGrid(_drc);
            RefreshLabels(_drc);
        }

        private void RefreshLabels(DungeonReminderConfiguration drc)
        {
            tsslDate.Text = String.Format("Last updated at: {0}", drc.LastUpdateDate);
            tsslTotalGold.Text = String.Format(
                "Total gold earned: {0}",
                drc.Dungeons
                    .Where(a => a.IsCompleted)
                    .Sum(a => a.GoldReward));
        }

        private void RefreshDataGrid(DungeonReminderConfiguration drc)
        {
            // dgvDungeons.DataSource = null;
            if (dgvDungeons.DataSource == null)
            {
                _bindingList = new BindingList<Dungeon>(drc.Dungeons);
                dgvDungeons.DataSource = _bindingList;
            }
            else
            {
                //_bindingList.ResetBindings();
            }

            // Color
            for (int i = 0; i < drc.Dungeons.Count; i++)
            {
                dgvDungeons.Rows[i].DefaultCellStyle =
                    new DataGridViewCellStyle()
                    {
                        BackColor =
                            drc.Dungeons[i].IsCompleted
                                ? Color.LightGreen
                                : i % 2 == 0 ? Color.LightGray : Color.White
                    };
            }
        }

        #endregion

        #region Grid

        private void dgvDungeons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvDungeons.Rows[e.RowIndex].Cells[3].Value =
                    !Convert.ToBoolean(dgvDungeons.Rows[e.RowIndex].Cells[3].Value);
            }
        }

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
                    _drc.LastUpdateDate = DateTime.Now;

                    RefreshBindings();
                    SaveCurrent();
                }
            }
        }

        private void dgvDungeons_SelectionChanged(object sender, EventArgs e)
        {
            dgvDungeons.ClearSelection();
        }

        #endregion

        private void SaveCurrent()
        {
            _drc.Dungeons = _bindingList.ToList();

            ConfigurationLoader.SaveConfiguration(_drc, Filename);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveCurrent();
        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            _drc.Dungeons.ForEach(a => a.IsCompleted = false);
            RefreshBindings();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            dgvDungeons.Height = Height - 100;
        }

    }
}