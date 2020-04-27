namespace WindowsFormsApp2
{
    partial class Form4
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pmDb = new System.Windows.Forms.Button();
            this.pmAutoDn = new System.Windows.Forms.Button();
            this.pmSave = new System.Windows.Forms.Button();
            this.pmDelete = new System.Windows.Forms.Button();
            this.pmInsert = new System.Windows.Forms.Button();
            this.pmInquiry = new System.Windows.Forms.Button();
            this.pmExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ExeProgramName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VersionOrValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PMetc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pmDb);
            this.panel1.Controls.Add(this.pmAutoDn);
            this.panel1.Controls.Add(this.pmSave);
            this.panel1.Controls.Add(this.pmDelete);
            this.panel1.Controls.Add(this.pmInsert);
            this.panel1.Controls.Add(this.pmInquiry);
            this.panel1.Controls.Add(this.pmExit);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 47);
            this.panel1.TabIndex = 0;
            // 
            // pmDb
            // 
            this.pmDb.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pmDb.Location = new System.Drawing.Point(985, 3);
            this.pmDb.Name = "pmDb";
            this.pmDb.Size = new System.Drawing.Size(41, 40);
            this.pmDb.TabIndex = 6;
            this.pmDb.Text = "Db";
            this.pmDb.UseVisualStyleBackColor = true;
            // 
            // pmAutoDn
            // 
            this.pmAutoDn.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pmAutoDn.Location = new System.Drawing.Point(896, 3);
            this.pmAutoDn.Name = "pmAutoDn";
            this.pmAutoDn.Size = new System.Drawing.Size(83, 40);
            this.pmAutoDn.TabIndex = 5;
            this.pmAutoDn.Text = "Auto Dn";
            this.pmAutoDn.UseVisualStyleBackColor = true;
            // 
            // pmSave
            // 
            this.pmSave.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pmSave.Location = new System.Drawing.Point(416, 3);
            this.pmSave.Name = "pmSave";
            this.pmSave.Size = new System.Drawing.Size(131, 40);
            this.pmSave.TabIndex = 4;
            this.pmSave.Text = "저장 ( S )";
            this.pmSave.UseVisualStyleBackColor = true;
            this.pmSave.Click += new System.EventHandler(this.PmSave_Click);
            // 
            // pmDelete
            // 
            this.pmDelete.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pmDelete.Location = new System.Drawing.Point(327, 3);
            this.pmDelete.Name = "pmDelete";
            this.pmDelete.Size = new System.Drawing.Size(83, 40);
            this.pmDelete.TabIndex = 3;
            this.pmDelete.Text = "삭제 ( D )";
            this.pmDelete.UseVisualStyleBackColor = true;
            this.pmDelete.Click += new System.EventHandler(this.PmDelete_Click);
            // 
            // pmInsert
            // 
            this.pmInsert.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pmInsert.Location = new System.Drawing.Point(238, 3);
            this.pmInsert.Name = "pmInsert";
            this.pmInsert.Size = new System.Drawing.Size(83, 40);
            this.pmInsert.TabIndex = 2;
            this.pmInsert.Text = "삽입 ( I )";
            this.pmInsert.UseVisualStyleBackColor = true;
            this.pmInsert.Click += new System.EventHandler(this.PmInsert_Click);
            // 
            // pmInquiry
            // 
            this.pmInquiry.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pmInquiry.Location = new System.Drawing.Point(108, 3);
            this.pmInquiry.Name = "pmInquiry";
            this.pmInquiry.Size = new System.Drawing.Size(124, 40);
            this.pmInquiry.TabIndex = 1;
            this.pmInquiry.Text = "조회 ( S )";
            this.pmInquiry.UseVisualStyleBackColor = true;
            this.pmInquiry.Click += new System.EventHandler(this.PmInquiry_Click);
            // 
            // pmExit
            // 
            this.pmExit.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pmExit.Location = new System.Drawing.Point(3, 3);
            this.pmExit.Name = "pmExit";
            this.pmExit.Size = new System.Drawing.Size(99, 40);
            this.pmExit.TabIndex = 0;
            this.pmExit.Text = "Exit";
            this.pmExit.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CK,
            this.ExeProgramName,
            this.VersionOrValues,
            this.modifyDate,
            this.PMetc});
            this.dataGridView1.Location = new System.Drawing.Point(3, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 425);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // CK
            // 
            this.CK.FillWeight = 200F;
            this.CK.HeaderText = "CK";
            this.CK.Name = "CK";
            this.CK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CK.Width = 35;
            // 
            // ExeProgramName
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExeProgramName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ExeProgramName.HeaderText = "EXE_Program_Name";
            this.ExeProgramName.Name = "ExeProgramName";
            this.ExeProgramName.Width = 200;
            // 
            // VersionOrValues
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.VersionOrValues.DefaultCellStyle = dataGridViewCellStyle3;
            this.VersionOrValues.HeaderText = "버전 Or values";
            this.VersionOrValues.Name = "VersionOrValues";
            this.VersionOrValues.Width = 280;
            // 
            // modifyDate
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.modifyDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.modifyDate.HeaderText = "수정일자";
            this.modifyDate.Name = "modifyDate";
            this.modifyDate.Width = 150;
            // 
            // PMetc
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PMetc.DefaultCellStyle = dataGridViewCellStyle5;
            this.PMetc.HeaderText = "비고";
            this.PMetc.Name = "PMetc";
            this.PMetc.Width = 300;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 479);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pmDb;
        private System.Windows.Forms.Button pmAutoDn;
        private System.Windows.Forms.Button pmSave;
        private System.Windows.Forms.Button pmDelete;
        private System.Windows.Forms.Button pmInsert;
        private System.Windows.Forms.Button pmInquiry;
        private System.Windows.Forms.Button pmExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExeProgramName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VersionOrValues;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMetc;
    }
}

