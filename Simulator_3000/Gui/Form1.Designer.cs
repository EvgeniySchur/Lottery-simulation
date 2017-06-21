using System;

namespace Gui
{
    partial class MainGui
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.CB_SelectFile = new System.Windows.Forms.ComboBox();
            this.CB_CycleCount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ExpCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SilverCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewID = new System.Windows.Forms.DataGridView();
            this.dataGridViewIDExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewIDSilver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewIDGold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_openFolder = new System.Windows.Forms.Button();
            this.btn_saveResult = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewID)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStart.Location = new System.Drawing.Point(17, 211);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(197, 52);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // CB_SelectFile
            // 
            this.CB_SelectFile.FormattingEnabled = true;
            this.CB_SelectFile.Location = new System.Drawing.Point(17, 144);
            this.CB_SelectFile.Name = "CB_SelectFile";
            this.CB_SelectFile.Size = new System.Drawing.Size(341, 21);
            this.CB_SelectFile.TabIndex = 1;
            this.CB_SelectFile.SelectedIndexChanged += new System.EventHandler(this.CB_SelectFile_SelectedIndexChanged);
            this.CB_SelectFile.Click += new System.EventHandler(this.GetFiles);
            // 
            // CB_CycleCount
            // 
            this.CB_CycleCount.FormattingEnabled = true;
            this.CB_CycleCount.Items.AddRange(new object[] {
            "10",
            "20",
            "50",
            "100",
            "1000",
            "10000",
            "100000",
            "1000000"});
            this.CB_CycleCount.Location = new System.Drawing.Point(17, 184);
            this.CB_CycleCount.Name = "CB_CycleCount";
            this.CB_CycleCount.Size = new System.Drawing.Size(197, 21);
            this.CB_CycleCount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Num cycles";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExpCol,
            this.ExpSum,
            this.SilverCol});
            this.dataGridView.Location = new System.Drawing.Point(17, 271);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(341, 178);
            this.dataGridView.TabIndex = 8;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // ExpCol
            // 
            this.ExpCol.HeaderText = "Type";
            this.ExpCol.Name = "ExpCol";
            // 
            // ExpSum
            // 
            this.ExpSum.HeaderText = "Drop Count";
            this.ExpSum.Name = "ExpSum";
            // 
            // SilverCol
            // 
            this.SilverCol.HeaderText = "Sum Count";
            this.SilverCol.Name = "SilverCol";
            // 
            // dataGridViewID
            // 
            this.dataGridViewID.AllowUserToOrderColumns = true;
            this.dataGridViewID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewIDExp,
            this.dataGridViewIDSilver,
            this.dataGridViewIDGold});
            this.dataGridViewID.Location = new System.Drawing.Point(362, 146);
            this.dataGridViewID.Name = "dataGridViewID";
            this.dataGridViewID.Size = new System.Drawing.Size(340, 303);
            this.dataGridViewID.TabIndex = 9;
            this.dataGridViewID.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewID_CellContentClick);
            // 
            // dataGridViewIDExp
            // 
            this.dataGridViewIDExp.HeaderText = "Exp";
            this.dataGridViewIDExp.Name = "dataGridViewIDExp";
            // 
            // dataGridViewIDSilver
            // 
            this.dataGridViewIDSilver.HeaderText = "Silver";
            this.dataGridViewIDSilver.Name = "dataGridViewIDSilver";
            // 
            // dataGridViewIDGold
            // 
            this.dataGridViewIDGold.HeaderText = "Gold";
            this.dataGridViewIDGold.Name = "dataGridViewIDGold";
            // 
            // btn_openFolder
            // 
            this.btn_openFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_openFolder.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_openFolder.Location = new System.Drawing.Point(220, 213);
            this.btn_openFolder.Name = "btn_openFolder";
            this.btn_openFolder.Size = new System.Drawing.Size(138, 23);
            this.btn_openFolder.TabIndex = 10;
            this.btn_openFolder.Text = "Open folder";
            this.btn_openFolder.UseVisualStyleBackColor = false;
            this.btn_openFolder.Click += new System.EventHandler(this.btn_openFolder_Click);
            // 
            // btn_saveResult
            // 
            this.btn_saveResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_saveResult.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_saveResult.Location = new System.Drawing.Point(220, 242);
            this.btn_saveResult.Name = "btn_saveResult";
            this.btn_saveResult.Size = new System.Drawing.Size(138, 23);
            this.btn_saveResult.TabIndex = 11;
            this.btn_saveResult.Text = "Save result";
            this.btn_saveResult.UseVisualStyleBackColor = false;
            this.btn_saveResult.Click += new System.EventHandler(this.btn_saveResult_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_Clear.Location = new System.Drawing.Point(220, 184);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(138, 23);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "Clear folder";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(17, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(685, 112);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "if you want to open the tables NOT USE \",\" as field splitter\r\nif you want save th" +
    "e tables \r\nuse option \"Save as\"\r\nuse CSV with  \"#\" field splitter";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(714, 461);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_saveResult);
            this.Controls.Add(this.btn_openFolder);
            this.Controls.Add(this.dataGridViewID);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_CycleCount);
            this.Controls.Add(this.CB_SelectFile);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "MainGui";
            this.Text = "Simulator_3000";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox CB_SelectFile;
        private System.Windows.Forms.ComboBox CB_CycleCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn SilverCol;
        private System.Windows.Forms.DataGridView dataGridViewID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewIDExp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewIDSilver;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewIDGold;
        private System.Windows.Forms.Button btn_openFolder;
        private System.Windows.Forms.Button btn_saveResult;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox textBox1;
    }
}

