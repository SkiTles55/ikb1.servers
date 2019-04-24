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
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deletebtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.sIP = new System.Windows.Forms.TextBox();
            this.sName = new System.Windows.Forms.TextBox();
            this.sAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timerInt = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.popupInt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.sListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupInt)).BeginInit();
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
            this.sListView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.sListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIP,
            this.colName,
            this.edit,
            this.deletebtn});
            this.sListView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.sListView.Location = new System.Drawing.Point(16, 83);
            this.sListView.MultiSelect = false;
            this.sListView.Name = "sListView";
            this.sListView.ReadOnly = true;
            this.sListView.RowHeadersVisible = false;
            this.sListView.Size = new System.Drawing.Size(380, 183);
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
            // edit
            // 
            this.edit.HeaderText = "Изменить";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "Изменить";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 70;
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
            this.sIP.Location = new System.Drawing.Point(17, 281);
            this.sIP.Name = "sIP";
            this.sIP.Size = new System.Drawing.Size(96, 20);
            this.sIP.TabIndex = 3;
            this.sIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sIP_KeyPress);
            // 
            // sName
            // 
            this.sName.Location = new System.Drawing.Point(119, 281);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(163, 20);
            this.sName.TabIndex = 4;
            // 
            // sAdd
            // 
            this.sAdd.Location = new System.Drawing.Point(288, 279);
            this.sAdd.Name = "sAdd";
            this.sAdd.Size = new System.Drawing.Size(108, 23);
            this.sAdd.TabIndex = 5;
            this.sAdd.Text = "Добавить";
            this.sAdd.UseVisualStyleBackColor = true;
            this.sAdd.Click += new System.EventHandler(this.sAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Интервал проверки (минуты)";
            // 
            // timerInt
            // 
            this.timerInt.Location = new System.Drawing.Point(315, 326);
            this.timerInt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timerInt.Name = "timerInt";
            this.timerInt.Size = new System.Drawing.Size(81, 20);
            this.timerInt.TabIndex = 7;
            this.timerInt.Value = global::ikb1.servers.Properties.Settings.Default.tint;
            this.timerInt.ValueChanged += new System.EventHandler(this.timerInt_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Длительность оповещения (секунды)";
            // 
            // popupInt
            // 
            this.popupInt.Location = new System.Drawing.Point(315, 366);
            this.popupInt.Name = "popupInt";
            this.popupInt.Size = new System.Drawing.Size(81, 20);
            this.popupInt.TabIndex = 9;
            this.popupInt.Value = global::ikb1.servers.Properties.Settings.Default.pint;
            this.popupInt.ValueChanged += new System.EventHandler(this.popupInt_ValueChanged);
            // 
            // ProgramSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 418);
            this.Controls.Add(this.popupInt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timerInt);
            this.Controls.Add(this.label2);
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
            ((System.ComponentModel.ISupportInitialize)(this.timerInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupInt)).EndInit();
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
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn deletebtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown timerInt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown popupInt;
    }
}