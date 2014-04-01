namespace DungeonReminder.com.andaforce.arazect.dreminder.forms
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDungeons = new System.Windows.Forms.DataGridView();
            this.Dungeon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Completed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDungeons)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDungeons
            // 
            this.dgvDungeons.AllowUserToAddRows = false;
            this.dgvDungeons.AllowUserToDeleteRows = false;
            this.dgvDungeons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDungeons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dungeon,
            this.Path,
            this.Reward,
            this.Completed});
            this.dgvDungeons.Location = new System.Drawing.Point(12, 12);
            this.dgvDungeons.Name = "dgvDungeons";
            this.dgvDungeons.RowHeadersVisible = false;
            this.dgvDungeons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDungeons.Size = new System.Drawing.Size(620, 440);
            this.dgvDungeons.TabIndex = 1;
            this.dgvDungeons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDungeons_CellContentClick);
            this.dgvDungeons.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDungeons_CellValueChanged);
            // 
            // Dungeon
            // 
            this.Dungeon.DataPropertyName = "DungeonName";
            this.Dungeon.HeaderText = "Dungeon";
            this.Dungeon.Name = "Dungeon";
            this.Dungeon.ReadOnly = true;
            this.Dungeon.Width = 200;
            // 
            // Path
            // 
            this.Path.DataPropertyName = "PathName";
            this.Path.HeaderText = "Path Name";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Width = 200;
            // 
            // Reward
            // 
            this.Reward.DataPropertyName = "GoldReward";
            this.Reward.HeaderText = "Gold Reward";
            this.Reward.Name = "Reward";
            this.Reward.ReadOnly = true;
            // 
            // Completed
            // 
            this.Completed.DataPropertyName = "IsCompleted";
            this.Completed.HeaderText = "Completed";
            this.Completed.Name = "Completed";
            this.Completed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Completed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 480);
            this.Controls.Add(this.dgvDungeons);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDungeons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDungeons;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dungeon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reward;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Completed;
    }
}

