using System.ComponentModel;
using System.Windows.Forms;
using DungeonReminder.com.andaforce.arazect.axna.configuration;
using DungeonReminder.com.andaforce.arazect.dreminder.data;

namespace DungeonReminder.com.andaforce.arazect.dreminder.forms
{
    public partial class MainForm : Form
    {
        private DungeonReminderConfiguration _drc;
        private bool _gridIsUpdating;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            _drc = ConfigurationLoader
                .LoadConfiguration<DungeonReminderConfiguration>("config.xml");

            RefreshDataBinding(_drc);
        }

        private void RefreshDataBinding(DungeonReminderConfiguration drc)
        {
            dgvDungeons.DataSource = null;
            dgvDungeons.DataSource = new BindingList<Dungeon>(drc.Dungeons);
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
                    MessageBox.Show(checkBox.Value.ToString(), "Caption");
                }
            }
        }
        #endregion

    }
}