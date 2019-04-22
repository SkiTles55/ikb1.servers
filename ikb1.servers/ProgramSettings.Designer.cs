namespace ikb1.servers
{
    partial class ProgramSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.AutoStartCheckBox = new System.Windows.Forms.CheckBox();
            this.sListView = new System.Windows.Forms.DataGridView();
            this.colIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletebtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.sIP = new System.Windows.Forms.TextBox();
            this.sName = new System.Windows.Forms.TextBox();
            this.sAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sListView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список компьютеров";
            // 
            // AutoStartCheckBox
            // 
            this.AutoStartCheckBox.AutoSize = true;
            this.AutoStartCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoStartCheckBox.Location = new System.Drawing.Point(16, 13);
            this.AutoStartCheckBox.Name = "AutoStartCheckBox";
            this.AutoStartCheckBox.Size = new System.Drawing.Size(236, 24);
            this.AutoStartCheckBox.TabIndex = 1;
            this.AutoStartCheckBox.Text = "Запуск при старте Windows";
            this.AutoStartCheckBox.UseVisualStyleBackColor = true;
            this.AutoStartCheckBox.CheckedChanged += new System.EventHandler(this.AutoStartCheckBox_CheckedChanged);
            // 
            // sListView
            // 
            this.sListView.AllowUserToAddRows = false;
            this.sListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIP,
            this.colName,
            this.deletebtn});
            this.sListView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.sListView.Location = new System.Drawing.Point(16, 83);
            this.sListView.MultiSelect = false;
            this.sListView.Name = "sListView";
            this.sListView.ReadOnly = true;
            this.sListView.Size = new System.Drawing.Size(305, 183);
            this.sListView.TabIndex = 2;
            this.sListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sListView_CellContentClick);
            // 
            // colIP
            // 
            this.colIP.HeaderText = "IP машины";
            this.colIP.Name = "colIP";
            this.colIP.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Имя машины";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // deletebtn
            // 
            this.deletebtn.HeaderText = "Удалить";
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.ReadOnly = true;
            this.deletebtn.Text = "X";
            this.deletebtn.UseColumnTextForButtonValue = true;
            this.deletebtn.Width = 60;
            // 
            // sIP
            // 
            this.sIP.Location = new System.Drawing.Point(16, 282);
            this.sIP.Name = "sIP";
            this.sIP.Size = new System.Drawing.Size(96, 20);
            this.sIP.TabIndex = 3;
            // 
            // sName
            // 
            this.sName.Location = new System.Drawing.Point(119, 281);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(100, 20);
            this.sName.TabIndex = 4;
            // 
            // sAdd
            // 
            this.sAdd.Location = new System.Drawing.Point(225, 278);
            this.sAdd.Name = "sAdd";
            this.sAdd.Size = new System.Drawing.Size(96, 23);
            this.sAdd.TabIndex = 5;
            this.sAdd.Text = "Добавить";
            this.sAdd.UseVisualStyleBackColor = true;
            this.sAdd.Click += new System.EventHandler(this.sAdd_Click);
            // 
            // ProgramSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 318);
            this.Controls.Add(this.sAdd);
            this.Controls.Add(this.sName);
            this.Controls.Add(this.sIP);
            this.Controls.Add(this.sListView);
            this.Controls.Add(this.AutoStartCheckBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ProgramSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Deactivate += new System.EventHandler(this.ProgramSettings_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.sListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AutoStartCheckBox;
        private System.Windows.Forms.DataGridView sListView;
        private System.Windows.Forms.TextBox sIP;
        private System.Windows.Forms.TextBox sName;
        private System.Windows.Forms.Button sAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewButtonColumn deletebtn;
    }
}