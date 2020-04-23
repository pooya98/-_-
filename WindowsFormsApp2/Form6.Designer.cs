namespace WindowsFormsApp2
{
    partial class Form6
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
            this.Ch_exit = new System.Windows.Forms.Button();
            this.Ch_save = new System.Windows.Forms.Button();
            this.list_name = new System.Windows.Forms.ListBox();
            this.listBox_state = new System.Windows.Forms.ListBox();
            this.list_ward = new System.Windows.Forms.ListBox();
            this.ch_list = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label_room = new System.Windows.Forms.Label();
            this.RoomNo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_center = new System.Windows.Forms.Label();
            this.WhereCenter = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_clinic = new System.Windows.Forms.Label();
            this.clinic = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Roomstate = new System.Windows.Forms.Label();
            this.RoomState = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label_charger = new System.Windows.Forms.Label();
            this.charger = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.ch_doctor = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Roomstate2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label_doctor = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label_now = new System.Windows.Forms.Label();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.label_change = new System.Windows.Forms.Label();
            this.textBox_charger = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.ch_insert = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ch_exit
            // 
            this.Ch_exit.Location = new System.Drawing.Point(3, 4);
            this.Ch_exit.Name = "Ch_exit";
            this.Ch_exit.Size = new System.Drawing.Size(117, 35);
            this.Ch_exit.TabIndex = 0;
            this.Ch_exit.Text = "Exit";
            this.Ch_exit.UseVisualStyleBackColor = true;
            // 
            // Ch_save
            // 
            this.Ch_save.Location = new System.Drawing.Point(126, 4);
            this.Ch_save.Name = "Ch_save";
            this.Ch_save.Size = new System.Drawing.Size(283, 35);
            this.Ch_save.TabIndex = 1;
            this.Ch_save.Text = "저장";
            this.Ch_save.UseVisualStyleBackColor = true;
            this.Ch_save.Click += new System.EventHandler(this.Ch_save_Click);
            // 
            // list_name
            // 
            this.list_name.FormattingEnabled = true;
            this.list_name.ItemHeight = 12;
            this.list_name.Location = new System.Drawing.Point(414, 4);
            this.list_name.Name = "list_name";
            this.list_name.ScrollAlwaysVisible = true;
            this.list_name.Size = new System.Drawing.Size(133, 412);
            this.list_name.TabIndex = 2;
            // 
            // listBox_state
            // 
            this.listBox_state.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox_state.FormattingEnabled = true;
            this.listBox_state.ItemHeight = 21;
            this.listBox_state.Items.AddRange(new object[] {
            "진료",
            "휴진",
            "휴진2"});
            this.listBox_state.Location = new System.Drawing.Point(275, 412);
            this.listBox_state.Name = "listBox_state";
            this.listBox_state.Size = new System.Drawing.Size(133, 67);
            this.listBox_state.TabIndex = 12;
            this.listBox_state.SelectedIndexChanged += new System.EventHandler(this.ListBox2_SelectedIndexChanged);
            // 
            // list_ward
            // 
            this.list_ward.FormattingEnabled = true;
            this.list_ward.ItemHeight = 12;
            this.list_ward.Location = new System.Drawing.Point(552, 4);
            this.list_ward.Name = "list_ward";
            this.list_ward.Size = new System.Drawing.Size(221, 148);
            this.list_ward.TabIndex = 14;
            // 
            // ch_list
            // 
            this.ch_list.FormattingEnabled = true;
            this.ch_list.ItemHeight = 12;
            this.ch_list.Location = new System.Drawing.Point(552, 187);
            this.ch_list.Name = "ch_list";
            this.ch_list.Size = new System.Drawing.Size(221, 292);
            this.ch_list.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(552, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 26);
            this.button3.TabIndex = 16;
            this.button3.Text = "전체과 VIEW";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.96936F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.03064F));
            this.tableLayoutPanel3.Controls.Add(this.label_room, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.RoomNo, 0, 0);
            this.tableLayoutPanel3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 45);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(405, 35);
            this.tableLayoutPanel3.TabIndex = 27;
            // 
            // label_room
            // 
            this.label_room.AutoSize = true;
            this.label_room.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_room.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_room.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_room.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_room.Location = new System.Drawing.Point(117, 0);
            this.label_room.Margin = new System.Windows.Forms.Padding(0);
            this.label_room.Name = "label_room";
            this.label_room.Size = new System.Drawing.Size(288, 35);
            this.label_room.TabIndex = 24;
            this.label_room.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoomNo
            // 
            this.RoomNo.AutoSize = true;
            this.RoomNo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RoomNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoomNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomNo.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RoomNo.Location = new System.Drawing.Point(0, 0);
            this.RoomNo.Margin = new System.Windows.Forms.Padding(0);
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.Size = new System.Drawing.Size(117, 35);
            this.RoomNo.TabIndex = 23;
            this.RoomNo.Text = "룸No";
            this.RoomNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.96936F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.03064F));
            this.tableLayoutPanel1.Controls.Add(this.label_center, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.WhereCenter, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 86);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(405, 35);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // label_center
            // 
            this.label_center.AutoSize = true;
            this.label_center.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_center.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_center.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_center.Location = new System.Drawing.Point(117, 0);
            this.label_center.Margin = new System.Windows.Forms.Padding(0);
            this.label_center.Name = "label_center";
            this.label_center.Size = new System.Drawing.Size(288, 35);
            this.label_center.TabIndex = 24;
            this.label_center.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WhereCenter
            // 
            this.WhereCenter.AutoSize = true;
            this.WhereCenter.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.WhereCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WhereCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WhereCenter.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WhereCenter.Location = new System.Drawing.Point(0, 0);
            this.WhereCenter.Margin = new System.Windows.Forms.Padding(0);
            this.WhereCenter.Name = "WhereCenter";
            this.WhereCenter.Size = new System.Drawing.Size(117, 35);
            this.WhereCenter.TabIndex = 23;
            this.WhereCenter.Text = "센터과";
            this.WhereCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.96936F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.03064F));
            this.tableLayoutPanel2.Controls.Add(this.label_clinic, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.clinic, 0, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 146);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(405, 35);
            this.tableLayoutPanel2.TabIndex = 29;
            // 
            // label_clinic
            // 
            this.label_clinic.AutoSize = true;
            this.label_clinic.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_clinic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_clinic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_clinic.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_clinic.Location = new System.Drawing.Point(117, 0);
            this.label_clinic.Margin = new System.Windows.Forms.Padding(0);
            this.label_clinic.Name = "label_clinic";
            this.label_clinic.Size = new System.Drawing.Size(288, 35);
            this.label_clinic.TabIndex = 24;
            this.label_clinic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clinic
            // 
            this.clinic.AutoSize = true;
            this.clinic.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.clinic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clinic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clinic.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.clinic.Location = new System.Drawing.Point(0, 0);
            this.clinic.Margin = new System.Windows.Forms.Padding(0);
            this.clinic.Name = "clinic";
            this.clinic.Size = new System.Drawing.Size(117, 35);
            this.clinic.TabIndex = 23;
            this.clinic.Text = "진료과";
            this.clinic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.label_Roomstate, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.RoomState, 0, 0);
            this.tableLayoutPanel6.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 371);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(266, 35);
            this.tableLayoutPanel6.TabIndex = 32;
            // 
            // label_Roomstate
            // 
            this.label_Roomstate.AutoSize = true;
            this.label_Roomstate.BackColor = System.Drawing.Color.PowderBlue;
            this.label_Roomstate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Roomstate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Roomstate.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Roomstate.Location = new System.Drawing.Point(133, 0);
            this.label_Roomstate.Margin = new System.Windows.Forms.Padding(0);
            this.label_Roomstate.Name = "label_Roomstate";
            this.label_Roomstate.Size = new System.Drawing.Size(133, 35);
            this.label_Roomstate.TabIndex = 24;
            this.label_Roomstate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoomState
            // 
            this.RoomState.AutoSize = true;
            this.RoomState.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RoomState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoomState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomState.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RoomState.Location = new System.Drawing.Point(0, 0);
            this.RoomState.Margin = new System.Windows.Forms.Padding(0);
            this.RoomState.Name = "RoomState";
            this.RoomState.Size = new System.Drawing.Size(133, 35);
            this.RoomState.TabIndex = 23;
            this.RoomState.Text = "룸상태";
            this.RoomState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label_charger, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.charger, 0, 0);
            this.tableLayoutPanel4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 294);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(265, 35);
            this.tableLayoutPanel4.TabIndex = 33;
            // 
            // label_charger
            // 
            this.label_charger.AutoSize = true;
            this.label_charger.BackColor = System.Drawing.Color.PowderBlue;
            this.label_charger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_charger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_charger.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_charger.Location = new System.Drawing.Point(132, 0);
            this.label_charger.Margin = new System.Windows.Forms.Padding(0);
            this.label_charger.Name = "label_charger";
            this.label_charger.Size = new System.Drawing.Size(133, 35);
            this.label_charger.TabIndex = 24;
            this.label_charger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // charger
            // 
            this.charger.AutoSize = true;
            this.charger.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.charger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.charger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.charger.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.charger.Location = new System.Drawing.Point(0, 0);
            this.charger.Margin = new System.Windows.Forms.Padding(0);
            this.charger.Name = "charger";
            this.charger.Size = new System.Drawing.Size(132, 35);
            this.charger.TabIndex = 23;
            this.charger.Text = "담당자";
            this.charger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.ch_doctor, 0, 0);
            this.tableLayoutPanel5.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 256);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(265, 35);
            this.tableLayoutPanel5.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.PowderBlue;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(132, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 35);
            this.label9.TabIndex = 24;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ch_doctor
            // 
            this.ch_doctor.AutoSize = true;
            this.ch_doctor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ch_doctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ch_doctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ch_doctor.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ch_doctor.Location = new System.Drawing.Point(0, 0);
            this.ch_doctor.Margin = new System.Windows.Forms.Padding(0);
            this.ch_doctor.Name = "ch_doctor";
            this.ch_doctor.Size = new System.Drawing.Size(132, 35);
            this.ch_doctor.TabIndex = 23;
            this.ch_doctor.Text = "의사";
            this.ch_doctor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ch_doctor.Click += new System.EventHandler(this.Label10_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.label_Roomstate2, 0, 0);
            this.tableLayoutPanel7.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tableLayoutPanel7.Location = new System.Drawing.Point(275, 371);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(133, 35);
            this.tableLayoutPanel7.TabIndex = 35;
            // 
            // label_Roomstate2
            // 
            this.label_Roomstate2.AutoSize = true;
            this.label_Roomstate2.BackColor = System.Drawing.Color.PowderBlue;
            this.label_Roomstate2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Roomstate2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Roomstate2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Roomstate2.Location = new System.Drawing.Point(0, 0);
            this.label_Roomstate2.Margin = new System.Windows.Forms.Padding(0);
            this.label_Roomstate2.Name = "label_Roomstate2";
            this.label_Roomstate2.Size = new System.Drawing.Size(133, 35);
            this.label_Roomstate2.TabIndex = 23;
            this.label_Roomstate2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.textBox_charger, 0, 0);
            this.tableLayoutPanel8.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tableLayoutPanel8.Location = new System.Drawing.Point(275, 294);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(133, 35);
            this.tableLayoutPanel8.TabIndex = 36;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.label_doctor, 0, 0);
            this.tableLayoutPanel9.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tableLayoutPanel9.Location = new System.Drawing.Point(275, 256);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(133, 35);
            this.tableLayoutPanel9.TabIndex = 37;
            // 
            // label_doctor
            // 
            this.label_doctor.AutoSize = true;
            this.label_doctor.BackColor = System.Drawing.Color.PowderBlue;
            this.label_doctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_doctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_doctor.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_doctor.Location = new System.Drawing.Point(0, 0);
            this.label_doctor.Margin = new System.Windows.Forms.Padding(0);
            this.label_doctor.Name = "label_doctor";
            this.label_doctor.Size = new System.Drawing.Size(133, 35);
            this.label_doctor.TabIndex = 23;
            this.label_doctor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.label_now, 0, 0);
            this.tableLayoutPanel10.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 215);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(266, 35);
            this.tableLayoutPanel10.TabIndex = 38;
            // 
            // label_now
            // 
            this.label_now.AutoSize = true;
            this.label_now.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label_now.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_now.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_now.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_now.Location = new System.Drawing.Point(0, 0);
            this.label_now.Margin = new System.Windows.Forms.Padding(0);
            this.label_now.Name = "label_now";
            this.label_now.Size = new System.Drawing.Size(266, 35);
            this.label_now.TabIndex = 23;
            this.label_now.Text = "현재    ";
            this.label_now.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.label_change, 0, 0);
            this.tableLayoutPanel11.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tableLayoutPanel11.Location = new System.Drawing.Point(275, 215);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(133, 35);
            this.tableLayoutPanel11.TabIndex = 39;
            // 
            // label_change
            // 
            this.label_change.AutoSize = true;
            this.label_change.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label_change.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_change.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_change.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_change.Location = new System.Drawing.Point(0, 0);
            this.label_change.Margin = new System.Windows.Forms.Padding(0);
            this.label_change.Name = "label_change";
            this.label_change.Size = new System.Drawing.Size(133, 35);
            this.label_change.TabIndex = 23;
            this.label_change.Text = "변경";
            this.label_change.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_charger
            // 
            this.textBox_charger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_charger.Location = new System.Drawing.Point(0, 0);
            this.textBox_charger.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_charger.Multiline = true;
            this.textBox_charger.Name = "textBox_charger";
            this.textBox_charger.Size = new System.Drawing.Size(133, 35);
            this.textBox_charger.TabIndex = 0;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.ch_insert, 0, 0);
            this.tableLayoutPanel12.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tableLayoutPanel12.Location = new System.Drawing.Point(414, 422);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(133, 57);
            this.tableLayoutPanel12.TabIndex = 40;
            // 
            // ch_insert
            // 
            this.ch_insert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ch_insert.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ch_insert.Location = new System.Drawing.Point(0, 0);
            this.ch_insert.Margin = new System.Windows.Forms.Padding(0);
            this.ch_insert.Multiline = true;
            this.ch_insert.Name = "ch_insert";
            this.ch_insert.Size = new System.Drawing.Size(133, 57);
            this.ch_insert.TabIndex = 0;
            this.ch_insert.Text = "NULL";
            this.ch_insert.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 483);
            this.Controls.Add(this.tableLayoutPanel12);
            this.Controls.Add(this.tableLayoutPanel11);
            this.Controls.Add(this.tableLayoutPanel10);
            this.Controls.Add(this.tableLayoutPanel9);
            this.Controls.Add(this.tableLayoutPanel8);
            this.Controls.Add(this.tableLayoutPanel7);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ch_list);
            this.Controls.Add(this.list_ward);
            this.Controls.Add(this.listBox_state);
            this.Controls.Add(this.list_name);
            this.Controls.Add(this.Ch_save);
            this.Controls.Add(this.Ch_exit);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ch_exit;
        private System.Windows.Forms.Button Ch_save;
        private System.Windows.Forms.ListBox list_name;
        private System.Windows.Forms.ListBox listBox_state;
        private System.Windows.Forms.ListBox list_ward;
        private System.Windows.Forms.ListBox ch_list;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label_room;
        private System.Windows.Forms.Label RoomNo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_center;
        private System.Windows.Forms.Label WhereCenter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label_clinic;
        private System.Windows.Forms.Label clinic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label_Roomstate;
        private System.Windows.Forms.Label RoomState;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label_charger;
        private System.Windows.Forms.Label charger;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label ch_doctor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label_Roomstate2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label_doctor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label_now;
        private System.Windows.Forms.TextBox textBox_charger;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label label_change;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.TextBox ch_insert;
    }
}

