namespace ProgressManagementSystem
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxEngineer = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBoxNumberOfCases = new System.Windows.Forms.TextBox();
            this.dataGridViewCaseList = new System.Windows.Forms.DataGridView();
            this.窓口DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.実務担当者DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ケース番号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.クライアント名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.クライアント整理番号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.期限DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTableCaseListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.caseList = new ProgressManagementSystem.CaseList();
            this.checkBoxDueOn = new System.Windows.Forms.CheckBox();
            this.checkBoxDueOff = new System.Windows.Forms.CheckBox();
            this.checkBoxDomesticApplication = new System.Windows.Forms.CheckBox();
            this.checkBoxDomesticOfficeAction = new System.Windows.Forms.CheckBox();
            this.checkBoxForeignApplication = new System.Windows.Forms.CheckBox();
            this.checkBoxForeignOfficeAction = new System.Windows.Forms.CheckBox();
            this.buttonUpDate = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.linkLabelCaseThread = new System.Windows.Forms.LinkLabel();
            this.linkLabelClientInformation = new System.Windows.Forms.LinkLabel();
            this.linkLabelElectricalWrapper = new System.Windows.Forms.LinkLabel();
            this.linkLabelElectricalLibrary = new System.Windows.Forms.LinkLabel();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.buttonCaseReceived = new System.Windows.Forms.Button();
            this.buttonMeeting = new System.Windows.Forms.Button();
            this.buttonSupplementReceived = new System.Windows.Forms.Button();
            this.buttonDraftDeadline = new System.Windows.Forms.Button();
            this.buttonDraftSent = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.textBoxCaseReceived = new System.Windows.Forms.TextBox();
            this.textBoxMeeting = new System.Windows.Forms.TextBox();
            this.textBoxSupplementReceived = new System.Windows.Forms.TextBox();
            this.textBoxDraftDeadline = new System.Windows.Forms.TextBox();
            this.textBoxDraftSent = new System.Windows.Forms.TextBox();
            this.textBoxDraftDays = new System.Windows.Forms.TextBox();
            this.DraftDays = new System.Windows.Forms.Label();
            this.buttonStore = new System.Windows.Forms.Button();
            this.labelMemo = new System.Windows.Forms.Label();
            this.buttonFiledDate = new System.Windows.Forms.Button();
            this.textBoxFiledDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCaseList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableCaseListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseList)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEngineer
            // 
            this.comboBoxEngineer.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxEngineer.FormattingEnabled = true;
            this.comboBoxEngineer.Location = new System.Drawing.Point(36, 24);
            this.comboBoxEngineer.Name = "comboBoxEngineer";
            this.comboBoxEngineer.Size = new System.Drawing.Size(178, 32);
            this.comboBoxEngineer.TabIndex = 0;
            this.comboBoxEngineer.Text = "　担当者";
            this.comboBoxEngineer.SelectedIndexChanged += new System.EventHandler(this.comboBoxEngineer_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "期限近い順"});
            this.comboBox2.Location = new System.Drawing.Point(36, 78);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(178, 32);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Text = "　ソート";
            // 
            // textBoxNumberOfCases
            // 
            this.textBoxNumberOfCases.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxNumberOfCases.Location = new System.Drawing.Point(246, 25);
            this.textBoxNumberOfCases.Name = "textBoxNumberOfCases";
            this.textBoxNumberOfCases.Size = new System.Drawing.Size(178, 31);
            this.textBoxNumberOfCases.TabIndex = 5;
            this.textBoxNumberOfCases.Text = "　表示件数：-";
            // 
            // dataGridViewCaseList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewCaseList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCaseList.AutoGenerateColumns = false;
            this.dataGridViewCaseList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCaseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCaseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.窓口DataGridViewTextBoxColumn,
            this.実務担当者DataGridViewTextBoxColumn,
            this.ケース番号DataGridViewTextBoxColumn,
            this.クライアント名DataGridViewTextBoxColumn,
            this.クライアント整理番号DataGridViewTextBoxColumn,
            this.期限DataGridViewTextBoxColumn});
            this.dataGridViewCaseList.DataSource = this.dataTableCaseListBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCaseList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCaseList.Location = new System.Drawing.Point(36, 130);
            this.dataGridViewCaseList.Name = "dataGridViewCaseList";
            this.dataGridViewCaseList.RowHeadersWidth = 51;
            this.dataGridViewCaseList.RowTemplate.Height = 21;
            this.dataGridViewCaseList.Size = new System.Drawing.Size(711, 542);
            this.dataGridViewCaseList.TabIndex = 7;
            this.dataGridViewCaseList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCaseList_CellClick);
            // 
            // 窓口DataGridViewTextBoxColumn
            // 
            this.窓口DataGridViewTextBoxColumn.DataPropertyName = "窓口";
            this.窓口DataGridViewTextBoxColumn.HeaderText = "窓口";
            this.窓口DataGridViewTextBoxColumn.Name = "窓口DataGridViewTextBoxColumn";
            // 
            // 実務担当者DataGridViewTextBoxColumn
            // 
            this.実務担当者DataGridViewTextBoxColumn.DataPropertyName = "実務担当者";
            this.実務担当者DataGridViewTextBoxColumn.HeaderText = "実務担当者";
            this.実務担当者DataGridViewTextBoxColumn.Name = "実務担当者DataGridViewTextBoxColumn";
            // 
            // ケース番号DataGridViewTextBoxColumn
            // 
            this.ケース番号DataGridViewTextBoxColumn.DataPropertyName = "ケース番号";
            this.ケース番号DataGridViewTextBoxColumn.HeaderText = "ケース番号";
            this.ケース番号DataGridViewTextBoxColumn.Name = "ケース番号DataGridViewTextBoxColumn";
            // 
            // クライアント名DataGridViewTextBoxColumn
            // 
            this.クライアント名DataGridViewTextBoxColumn.DataPropertyName = "クライアント名";
            this.クライアント名DataGridViewTextBoxColumn.HeaderText = "クライアント名";
            this.クライアント名DataGridViewTextBoxColumn.Name = "クライアント名DataGridViewTextBoxColumn";
            // 
            // クライアント整理番号DataGridViewTextBoxColumn
            // 
            this.クライアント整理番号DataGridViewTextBoxColumn.DataPropertyName = "クライアント整理番号";
            this.クライアント整理番号DataGridViewTextBoxColumn.HeaderText = "クライアント整理番号";
            this.クライアント整理番号DataGridViewTextBoxColumn.Name = "クライアント整理番号DataGridViewTextBoxColumn";
            // 
            // 期限DataGridViewTextBoxColumn
            // 
            this.期限DataGridViewTextBoxColumn.DataPropertyName = "期限";
            this.期限DataGridViewTextBoxColumn.HeaderText = "期限";
            this.期限DataGridViewTextBoxColumn.Name = "期限DataGridViewTextBoxColumn";
            // 
            // dataTableCaseListBindingSource
            // 
            this.dataTableCaseListBindingSource.DataMember = "DataTableCaseList";
            this.dataTableCaseListBindingSource.DataSource = this.caseList;
            // 
            // caseList
            // 
            this.caseList.DataSetName = "CaseList";
            this.caseList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBoxDueOn
            // 
            this.checkBoxDueOn.AutoSize = true;
            this.checkBoxDueOn.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxDueOn.Location = new System.Drawing.Point(786, 22);
            this.checkBoxDueOn.Name = "checkBoxDueOn";
            this.checkBoxDueOn.Size = new System.Drawing.Size(109, 28);
            this.checkBoxDueOn.TabIndex = 8;
            this.checkBoxDueOn.Text = "期限管理中";
            this.checkBoxDueOn.UseVisualStyleBackColor = true;
            // 
            // checkBoxDueOff
            // 
            this.checkBoxDueOff.AutoSize = true;
            this.checkBoxDueOff.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxDueOff.Location = new System.Drawing.Point(786, 62);
            this.checkBoxDueOff.Name = "checkBoxDueOff";
            this.checkBoxDueOff.Size = new System.Drawing.Size(125, 28);
            this.checkBoxDueOff.TabIndex = 9;
            this.checkBoxDueOff.Text = "期限管理終了";
            this.checkBoxDueOff.UseVisualStyleBackColor = true;
            // 
            // checkBoxDomesticApplication
            // 
            this.checkBoxDomesticApplication.AutoSize = true;
            this.checkBoxDomesticApplication.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxDomesticApplication.Location = new System.Drawing.Point(921, 24);
            this.checkBoxDomesticApplication.Name = "checkBoxDomesticApplication";
            this.checkBoxDomesticApplication.Size = new System.Drawing.Size(93, 28);
            this.checkBoxDomesticApplication.TabIndex = 10;
            this.checkBoxDomesticApplication.Text = "国内出願";
            this.checkBoxDomesticApplication.UseVisualStyleBackColor = true;
            // 
            // checkBoxDomesticOfficeAction
            // 
            this.checkBoxDomesticOfficeAction.AutoSize = true;
            this.checkBoxDomesticOfficeAction.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxDomesticOfficeAction.Location = new System.Drawing.Point(921, 62);
            this.checkBoxDomesticOfficeAction.Name = "checkBoxDomesticOfficeAction";
            this.checkBoxDomesticOfficeAction.Size = new System.Drawing.Size(93, 28);
            this.checkBoxDomesticOfficeAction.TabIndex = 11;
            this.checkBoxDomesticOfficeAction.Text = "国内中間";
            this.checkBoxDomesticOfficeAction.UseVisualStyleBackColor = true;
            // 
            // checkBoxForeignApplication
            // 
            this.checkBoxForeignApplication.AutoSize = true;
            this.checkBoxForeignApplication.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxForeignApplication.Location = new System.Drawing.Point(1034, 24);
            this.checkBoxForeignApplication.Name = "checkBoxForeignApplication";
            this.checkBoxForeignApplication.Size = new System.Drawing.Size(93, 28);
            this.checkBoxForeignApplication.TabIndex = 12;
            this.checkBoxForeignApplication.Text = "外国出願";
            this.checkBoxForeignApplication.UseVisualStyleBackColor = true;
            // 
            // checkBoxForeignOfficeAction
            // 
            this.checkBoxForeignOfficeAction.AutoSize = true;
            this.checkBoxForeignOfficeAction.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxForeignOfficeAction.Location = new System.Drawing.Point(1034, 62);
            this.checkBoxForeignOfficeAction.Name = "checkBoxForeignOfficeAction";
            this.checkBoxForeignOfficeAction.Size = new System.Drawing.Size(93, 28);
            this.checkBoxForeignOfficeAction.TabIndex = 13;
            this.checkBoxForeignOfficeAction.Text = "外国中間";
            this.checkBoxForeignOfficeAction.UseVisualStyleBackColor = true;
            // 
            // buttonUpDate
            // 
            this.buttonUpDate.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonUpDate.Location = new System.Drawing.Point(1174, 22);
            this.buttonUpDate.Name = "buttonUpDate";
            this.buttonUpDate.Size = new System.Drawing.Size(75, 72);
            this.buttonUpDate.TabIndex = 14;
            this.buttonUpDate.Text = "更新";
            this.buttonUpDate.UseVisualStyleBackColor = true;
            this.buttonUpDate.Click += new System.EventHandler(this.buttonUpDate_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonEnd.Location = new System.Drawing.Point(1273, 22);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(75, 72);
            this.buttonEnd.TabIndex = 15;
            this.buttonEnd.Text = "終了";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // linkLabelCaseThread
            // 
            this.linkLabelCaseThread.AutoSize = true;
            this.linkLabelCaseThread.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.linkLabelCaseThread.Location = new System.Drawing.Point(1168, 130);
            this.linkLabelCaseThread.Name = "linkLabelCaseThread";
            this.linkLabelCaseThread.Size = new System.Drawing.Size(159, 36);
            this.linkLabelCaseThread.TabIndex = 16;
            this.linkLabelCaseThread.TabStop = true;
            this.linkLabelCaseThread.Text = "案件スレッド";
            this.linkLabelCaseThread.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCaseThread_LinkClicked);
            // 
            // linkLabelClientInformation
            // 
            this.linkLabelClientInformation.AutoSize = true;
            this.linkLabelClientInformation.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.linkLabelClientInformation.Location = new System.Drawing.Point(1168, 210);
            this.linkLabelClientInformation.Name = "linkLabelClientInformation";
            this.linkLabelClientInformation.Size = new System.Drawing.Size(111, 36);
            this.linkLabelClientInformation.TabIndex = 17;
            this.linkLabelClientInformation.TabStop = true;
            this.linkLabelClientInformation.Text = "顧客情報";
            this.linkLabelClientInformation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClientInformation_LinkClicked);
            // 
            // linkLabelElectricalWrapper
            // 
            this.linkLabelElectricalWrapper.AutoSize = true;
            this.linkLabelElectricalWrapper.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.linkLabelElectricalWrapper.Location = new System.Drawing.Point(1168, 291);
            this.linkLabelElectricalWrapper.Name = "linkLabelElectricalWrapper";
            this.linkLabelElectricalWrapper.Size = new System.Drawing.Size(116, 36);
            this.linkLabelElectricalWrapper.TabIndex = 18;
            this.linkLabelElectricalWrapper.TabStop = true;
            this.linkLabelElectricalWrapper.Text = "Wrapper";
            this.linkLabelElectricalWrapper.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelElectricalWrapper_LinkClicked);
            // 
            // linkLabelElectricalLibrary
            // 
            this.linkLabelElectricalLibrary.AutoSize = true;
            this.linkLabelElectricalLibrary.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.linkLabelElectricalLibrary.Location = new System.Drawing.Point(1168, 364);
            this.linkLabelElectricalLibrary.Name = "linkLabelElectricalLibrary";
            this.linkLabelElectricalLibrary.Size = new System.Drawing.Size(104, 36);
            this.linkLabelElectricalLibrary.TabIndex = 19;
            this.linkLabelElectricalLibrary.TabStop = true;
            this.linkLabelElectricalLibrary.Text = "Rooster";
            this.linkLabelElectricalLibrary.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelElectricalLibrary_LinkClicked);
            // 
            // textBoxNote
            // 
            this.textBoxNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxNote.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxNote.Location = new System.Drawing.Point(786, 156);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(340, 133);
            this.textBoxNote.TabIndex = 20;
            this.textBoxNote.TextChanged += new System.EventHandler(this.textBoxNote_TextChanged);
            // 
            // buttonCaseReceived
            // 
            this.buttonCaseReceived.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCaseReceived.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonCaseReceived.Location = new System.Drawing.Point(787, 427);
            this.buttonCaseReceived.Name = "buttonCaseReceived";
            this.buttonCaseReceived.Size = new System.Drawing.Size(142, 33);
            this.buttonCaseReceived.TabIndex = 34;
            this.buttonCaseReceived.Text = "受託";
            this.buttonCaseReceived.UseVisualStyleBackColor = true;
            this.buttonCaseReceived.Click += new System.EventHandler(this.buttonCaseReceived_Click);
            // 
            // buttonMeeting
            // 
            this.buttonMeeting.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonMeeting.Location = new System.Drawing.Point(787, 463);
            this.buttonMeeting.Name = "buttonMeeting";
            this.buttonMeeting.Size = new System.Drawing.Size(142, 33);
            this.buttonMeeting.TabIndex = 35;
            this.buttonMeeting.Text = "面談";
            this.buttonMeeting.UseVisualStyleBackColor = true;
            this.buttonMeeting.Click += new System.EventHandler(this.buttonMeeting_Click);
            // 
            // buttonSupplementReceived
            // 
            this.buttonSupplementReceived.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSupplementReceived.Location = new System.Drawing.Point(787, 499);
            this.buttonSupplementReceived.Name = "buttonSupplementReceived";
            this.buttonSupplementReceived.Size = new System.Drawing.Size(142, 33);
            this.buttonSupplementReceived.TabIndex = 36;
            this.buttonSupplementReceived.Text = "補充資料受領";
            this.buttonSupplementReceived.UseVisualStyleBackColor = true;
            this.buttonSupplementReceived.Click += new System.EventHandler(this.buttonSupplementReceived_Click);
            // 
            // buttonDraftDeadline
            // 
            this.buttonDraftDeadline.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonDraftDeadline.Location = new System.Drawing.Point(787, 538);
            this.buttonDraftDeadline.Name = "buttonDraftDeadline";
            this.buttonDraftDeadline.Size = new System.Drawing.Size(142, 33);
            this.buttonDraftDeadline.TabIndex = 37;
            this.buttonDraftDeadline.Text = "初稿期限";
            this.buttonDraftDeadline.UseVisualStyleBackColor = true;
            this.buttonDraftDeadline.Click += new System.EventHandler(this.buttonDraftDeadline_Click);
            // 
            // buttonDraftSent
            // 
            this.buttonDraftSent.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonDraftSent.Location = new System.Drawing.Point(787, 577);
            this.buttonDraftSent.Name = "buttonDraftSent";
            this.buttonDraftSent.Size = new System.Drawing.Size(142, 33);
            this.buttonDraftSent.TabIndex = 38;
            this.buttonDraftSent.Text = "初稿送付";
            this.buttonDraftSent.UseVisualStyleBackColor = true;
            this.buttonDraftSent.Click += new System.EventHandler(this.buttonDraftSent_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(1068, 427);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 33;
            // 
            // textBoxCaseReceived
            // 
            this.textBoxCaseReceived.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxCaseReceived.Location = new System.Drawing.Point(935, 427);
            this.textBoxCaseReceived.Name = "textBoxCaseReceived";
            this.textBoxCaseReceived.Size = new System.Drawing.Size(121, 31);
            this.textBoxCaseReceived.TabIndex = 40;
            this.textBoxCaseReceived.Text = "-";
            this.textBoxCaseReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMeeting
            // 
            this.textBoxMeeting.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxMeeting.Location = new System.Drawing.Point(935, 464);
            this.textBoxMeeting.Name = "textBoxMeeting";
            this.textBoxMeeting.Size = new System.Drawing.Size(121, 31);
            this.textBoxMeeting.TabIndex = 41;
            this.textBoxMeeting.Text = "-";
            this.textBoxMeeting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSupplementReceived
            // 
            this.textBoxSupplementReceived.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxSupplementReceived.Location = new System.Drawing.Point(935, 501);
            this.textBoxSupplementReceived.Name = "textBoxSupplementReceived";
            this.textBoxSupplementReceived.Size = new System.Drawing.Size(121, 31);
            this.textBoxSupplementReceived.TabIndex = 42;
            this.textBoxSupplementReceived.Text = "-";
            this.textBoxSupplementReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDraftDeadline
            // 
            this.textBoxDraftDeadline.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxDraftDeadline.Location = new System.Drawing.Point(935, 538);
            this.textBoxDraftDeadline.Name = "textBoxDraftDeadline";
            this.textBoxDraftDeadline.Size = new System.Drawing.Size(121, 31);
            this.textBoxDraftDeadline.TabIndex = 43;
            this.textBoxDraftDeadline.Text = "-";
            this.textBoxDraftDeadline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDraftSent
            // 
            this.textBoxDraftSent.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxDraftSent.Location = new System.Drawing.Point(935, 577);
            this.textBoxDraftSent.Name = "textBoxDraftSent";
            this.textBoxDraftSent.Size = new System.Drawing.Size(121, 31);
            this.textBoxDraftSent.TabIndex = 44;
            this.textBoxDraftSent.Text = "-";
            this.textBoxDraftSent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDraftDays
            // 
            this.textBoxDraftDays.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxDraftDays.Location = new System.Drawing.Point(935, 620);
            this.textBoxDraftDays.Name = "textBoxDraftDays";
            this.textBoxDraftDays.Size = new System.Drawing.Size(121, 31);
            this.textBoxDraftDays.TabIndex = 45;
            this.textBoxDraftDays.Text = "-";
            this.textBoxDraftDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DraftDays
            // 
            this.DraftDays.AutoSize = true;
            this.DraftDays.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DraftDays.Location = new System.Drawing.Point(805, 623);
            this.DraftDays.Name = "DraftDays";
            this.DraftDays.Size = new System.Drawing.Size(106, 24);
            this.DraftDays.TabIndex = 46;
            this.DraftDays.Text = "ドラフト日数";
            // 
            // buttonStore
            // 
            this.buttonStore.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonStore.Location = new System.Drawing.Point(524, 25);
            this.buttonStore.Name = "buttonStore";
            this.buttonStore.Size = new System.Drawing.Size(164, 72);
            this.buttonStore.TabIndex = 47;
            this.buttonStore.Text = "保存";
            this.buttonStore.UseVisualStyleBackColor = true;
            this.buttonStore.Click += new System.EventHandler(this.buttonStore_Click);
            // 
            // labelMemo
            // 
            this.labelMemo.AutoSize = true;
            this.labelMemo.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMemo.Location = new System.Drawing.Point(783, 130);
            this.labelMemo.Name = "labelMemo";
            this.labelMemo.Size = new System.Drawing.Size(40, 23);
            this.labelMemo.TabIndex = 48;
            this.labelMemo.Text = "メモ";
            // 
            // buttonFiledDate
            // 
            this.buttonFiledDate.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonFiledDate.Location = new System.Drawing.Point(786, 659);
            this.buttonFiledDate.Name = "buttonFiledDate";
            this.buttonFiledDate.Size = new System.Drawing.Size(142, 33);
            this.buttonFiledDate.TabIndex = 49;
            this.buttonFiledDate.Text = "庁提出日";
            this.buttonFiledDate.UseVisualStyleBackColor = true;
            this.buttonFiledDate.Click += new System.EventHandler(this.buttonFiledDate_Click);
            // 
            // textBoxFiledDate
            // 
            this.textBoxFiledDate.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxFiledDate.Location = new System.Drawing.Point(934, 661);
            this.textBoxFiledDate.Name = "textBoxFiledDate";
            this.textBoxFiledDate.Size = new System.Drawing.Size(121, 31);
            this.textBoxFiledDate.TabIndex = 50;
            this.textBoxFiledDate.Text = "-";
            this.textBoxFiledDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 739);
            this.Controls.Add(this.textBoxFiledDate);
            this.Controls.Add(this.buttonFiledDate);
            this.Controls.Add(this.labelMemo);
            this.Controls.Add(this.buttonStore);
            this.Controls.Add(this.DraftDays);
            this.Controls.Add(this.textBoxDraftDays);
            this.Controls.Add(this.textBoxDraftSent);
            this.Controls.Add(this.textBoxDraftDeadline);
            this.Controls.Add(this.textBoxSupplementReceived);
            this.Controls.Add(this.textBoxMeeting);
            this.Controls.Add(this.textBoxCaseReceived);
            this.Controls.Add(this.buttonDraftSent);
            this.Controls.Add(this.buttonDraftDeadline);
            this.Controls.Add(this.buttonSupplementReceived);
            this.Controls.Add(this.buttonMeeting);
            this.Controls.Add(this.buttonCaseReceived);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.linkLabelElectricalLibrary);
            this.Controls.Add(this.linkLabelElectricalWrapper);
            this.Controls.Add(this.linkLabelClientInformation);
            this.Controls.Add(this.linkLabelCaseThread);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.buttonUpDate);
            this.Controls.Add(this.checkBoxForeignOfficeAction);
            this.Controls.Add(this.checkBoxForeignApplication);
            this.Controls.Add(this.checkBoxDomesticOfficeAction);
            this.Controls.Add(this.checkBoxDomesticApplication);
            this.Controls.Add(this.checkBoxDueOff);
            this.Controls.Add(this.checkBoxDueOn);
            this.Controls.Add(this.dataGridViewCaseList);
            this.Controls.Add(this.textBoxNumberOfCases);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBoxEngineer);
            this.Name = "FormMain";
            this.Text = "進捗管理システム";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCaseList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableCaseListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEngineer;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBoxNumberOfCases;
        private System.Windows.Forms.DataGridView dataGridViewCaseList;
        private System.Windows.Forms.CheckBox checkBoxDueOn;
        private System.Windows.Forms.CheckBox checkBoxDueOff;
        private System.Windows.Forms.CheckBox checkBoxDomesticApplication;
        private System.Windows.Forms.CheckBox checkBoxDomesticOfficeAction;
        private System.Windows.Forms.CheckBox checkBoxForeignApplication;
        private System.Windows.Forms.CheckBox checkBoxForeignOfficeAction;
        private System.Windows.Forms.Button buttonUpDate;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.LinkLabel linkLabelCaseThread;
        private System.Windows.Forms.LinkLabel linkLabelClientInformation;
        private System.Windows.Forms.LinkLabel linkLabelElectricalWrapper;
        private System.Windows.Forms.LinkLabel linkLabelElectricalLibrary;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Button buttonCaseReceived;
        private System.Windows.Forms.Button buttonMeeting;
        private System.Windows.Forms.Button buttonSupplementReceived;
        private System.Windows.Forms.Button buttonDraftDeadline;
        private System.Windows.Forms.Button buttonDraftSent;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.TextBox textBoxCaseReceived;
        private System.Windows.Forms.TextBox textBoxMeeting;
        private System.Windows.Forms.TextBox textBoxSupplementReceived;
        private System.Windows.Forms.TextBox textBoxDraftDeadline;
        private System.Windows.Forms.TextBox textBoxDraftSent;
        private System.Windows.Forms.TextBox textBoxDraftDays;
        private System.Windows.Forms.Label DraftDays;
        private CaseList caseList;
        private System.Windows.Forms.Button buttonStore;
        private System.Windows.Forms.Label labelMemo;
        private System.Windows.Forms.Button buttonFiledDate;
        private System.Windows.Forms.TextBox textBoxFiledDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn 窓口DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 実務担当者DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ケース番号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn クライアント名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn クライアント整理番号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 期限DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTableCaseListBindingSource;
    }
}

