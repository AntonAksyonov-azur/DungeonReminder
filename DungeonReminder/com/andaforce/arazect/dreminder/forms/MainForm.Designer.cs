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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTotalGold = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.Dungeon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Completed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDungeons)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDungeons
            // 
            this.dgvDungeons.AllowUserToAddRows = false;
            this.dgvDungeons.AllowUserToDeleteRows = false;
            this.dgvDungeons.AllowUserToResizeRows = false;
            this.dgvDungeons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDungeons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dungeon,
            this.Path,
            this.Reward,
            this.Completed});
            this.dgvDungeons.Location = new System.Drawing.Point(12, 44);
            this.dgvDungeons.Name = "dgvDungeons";
            this.dgvDungeons.RowHeadersVisible = false;
            this.dgvDungeons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDungeons.Size = new System.Drawing.Size(620, 330);
            this.dgvDungeons.TabIndex = 1;
            this.dgvDungeons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDungeons_CellContentClick);
            this.dgvDungeons.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDungeons_CellValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslDate,
            this.toolStripStatusLabel2,
            this.tsslTotalGold});
            this.statusStrip1.Location = new System.Drawing.Point(0, 381);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(642, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslDate
            // 
            this.tsslDate.Name = "tsslDate";
            this.tsslDate.Size = new System.Drawing.Size(86, 17);
            this.tsslDate.Text = "Last updated at ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // tsslTotalGold
            // 
            this.tsslTotalGold.Name = "tsslTotalGold";
            this.tsslTotalGold.Size = new System.Drawing.Size(74, 17);
            this.tsslTotalGold.Text = "Total gold = 0";
            // 
            // btnResetAll
            // 
            this.btnResetAll.Location = new System.Drawing.Point(554, 12);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(75, 23);
            this.btnResetAll.TabIndex = 3;
            this.btnResetAll.Text = "Reset All";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // Dungeon
            // 
            this.Dungeon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Dungeon.DataPropertyName = "DungeonName";
            this.Dungeon.HeaderText = "Dungeon";
            this.Dungeon.Name = "Dungeon";
            this.Dungeon.ReadOnly = true;
            this.Dungeon.Width = 200;
            // 
            // Path
            // 
            this.Path.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Path.DataPropertyName = "PathName";
            this.Path.HeaderText = "Path Name";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Width = 200;
            // 
            // Reward
            // 
            this.Reward.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Reward.DataPropertyName = "GoldReward";
            this.Reward.HeaderText = "Gold Reward";
            this.Reward.Name = "Reward";
            this.Reward.ReadOnly = true;
            // 
            // Completed
            // 
            this.Completed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
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
            this.ClientSize = new System.Drawing.Size(642, 403);
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvDungeons);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 670);
            this.MinimumSize = new System.Drawing.Size(650, 185);
            this.Name = "MainForm";
            this.Text = "Dungeon Reminder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDungeons)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDungeons;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalGold;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dungeon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reward;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Completed;
    }
}

