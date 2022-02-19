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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBoxNumberOfCases = new System.Windows.Forms.TextBox();
            this.dataGridViewCaseList = new System.Windows.Forms.DataGridView();
            this.進捗状況DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.事務所整理番号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.顧客整理番号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出願期限DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.textBoxDraftTerm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCaseList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableCaseListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseList)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(48, 30);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 32);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "　担当者";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "期限近い順"});
            this.comboBox2.Location = new System.Drawing.Point(48, 98);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(236, 32);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Text = "　ソート";
            // 
            // textBoxNumberOfCases
            // 
            this.textBoxNumberOfCases.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxNumberOfCases.Location = new System.Drawing.Point(328, 31);
            this.textBoxNumberOfCases.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumberOfCases.Name = "textBoxNumberOfCases";
            this.textBoxNumberOfCases.Size = new System.Drawing.Size(236, 31);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCaseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCaseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.進捗状況DataGridViewTextBoxColumn,
            this.事務所整理番号DataGridViewTextBoxColumn,
            this.顧客整理番号DataGridViewTextBoxColumn,
            this.出願期限DataGridViewTextBoxColumn});
            this.dataGridViewCaseList.DataSource = this.dataTableCaseListBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCaseList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCaseList.Location = new System.Drawing.Point(48, 162);
            this.dataGridViewCaseList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCaseList.Name = "dataGridViewCaseList";
            this.dataGridViewCaseList.RowHeadersWidth = 51;
            this.dataGridViewCaseList.RowTemplate.Height = 21;
            this.dataGridViewCaseList.Size = new System.Drawing.Size(948, 678);
            this.dataGridViewCaseList.TabIndex = 7;
            // 
            // 進捗状況DataGridViewTextBoxColumn
            // 
            this.進捗状況DataGridViewTextBoxColumn.DataPropertyName = "進捗状況";
            this.進捗状況DataGridViewTextBoxColumn.HeaderText = "進捗状況";
            this.進捗状況DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.進捗状況DataGridViewTextBoxColumn.Name = "進捗状況DataGridViewTextBoxColumn";
            // 
            // 事務所整理番号DataGridViewTextBoxColumn
            // 
            this.事務所整理番号DataGridViewTextBoxColumn.DataPropertyName = "事務所整理番号";
            this.事務所整理番号DataGridViewTextBoxColumn.HeaderText = "事務所整理番号";
            this.事務所整理番号DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.事務所整理番号DataGridViewTextBoxColumn.Name = "事務所整理番号DataGridViewTextBoxColumn";
            // 
            // 顧客整理番号DataGridViewTextBoxColumn
            // 
            this.顧客整理番号DataGridViewTextBoxColumn.DataPropertyName = "顧客整理番号";
            this.顧客整理番号DataGridViewTextBoxColumn.HeaderText = "顧客整理番号";
            this.顧客整理番号DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.顧客整理番号DataGridViewTextBoxColumn.Name = "顧客整理番号DataGridViewTextBoxColumn";
            // 
            // 出願期限DataGridViewTextBoxColumn
            // 
            this.出願期限DataGridViewTextBoxColumn.DataPropertyName = "出願期限";
            this.出願期限DataGridViewTextBoxColumn.HeaderText = "出願期限";
            this.出願期限DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.出願期限DataGridViewTextBoxColumn.Name = "出願期限DataGridViewTextBoxColumn";
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
            this.checkBoxDueOn.Location = new System.Drawing.Point(1048, 28);
            this.checkBoxDueOn.Margin = new System.Windows.Forms.Padding(4);
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
            this.checkBoxDueOff.Location = new System.Drawing.Point(1048, 78);
            this.checkBoxDueOff.Margin = new System.Windows.Forms.Padding(4);
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
            this.checkBoxDomesticApplication.Location = new System.Drawing.Point(1228, 30);
            this.checkBoxDomesticApplication.Margin = new System.Windows.Forms.Padding(4);
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
            this.checkBoxDomesticOfficeAction.Location = new System.Drawing.Point(1228, 78);
            this.checkBoxDomesticOfficeAction.Margin = new System.Windows.Forms.Padding(4);
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
            this.checkBoxForeignApplication.Location = new System.Drawing.Point(1379, 30);
            this.checkBoxForeignApplication.Margin = new System.Windows.Forms.Padding(4);
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
            this.checkBoxForeignOfficeAction.Location = new System.Drawing.Point(1379, 78);
            this.checkBoxForeignOfficeAction.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxForeignOfficeAction.Name = "checkBoxForeignOfficeAction";
            this.checkBoxForeignOfficeAction.Size = new System.Drawing.Size(93, 28);
            this.checkBoxForeignOfficeAction.TabIndex = 13;
            this.checkBoxForeignOfficeAction.Text = "外国中間";
            this.checkBoxForeignOfficeAction.UseVisualStyleBackColor = true;
            // 
            // buttonUpDate
            // 
            this.buttonUpDate.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonUpDate.Location = new System.Drawing.Point(1565, 28);
            this.buttonUpDate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpDate.Name = "buttonUpDate";
            this.buttonUpDate.Size = new System.Drawing.Size(100, 90);
            this.buttonUpDate.TabIndex = 14;
            this.buttonUpDate.Text = "更新";
            this.buttonUpDate.UseVisualStyleBackColor = true;
            this.buttonUpDate.Click += new System.EventHandler(this.buttonUpDate_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonEnd.Location = new System.Drawing.Point(1697, 28);
            this.buttonEnd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(100, 90);
            this.buttonEnd.TabIndex = 15;
            this.buttonEnd.Text = "終了";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // linkLabelCaseThread
            // 
            this.linkLabelCaseThread.AutoSize = true;
            this.linkLabelCaseThread.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.linkLabelCaseThread.Location = new System.Drawing.Point(1557, 162);
            this.linkLabelCaseThread.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.linkLabelClientInformation.Location = new System.Drawing.Point(1557, 262);
            this.linkLabelClientInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.linkLabelElectricalWrapper.Location = new System.Drawing.Point(1557, 364);
            this.linkLabelElectricalWrapper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelElectricalWrapper.Name = "linkLabelElectricalWrapper";
            this.linkLabelElectricalWrapper.Size = new System.Drawing.Size(111, 36);
            this.linkLabelElectricalWrapper.TabIndex = 18;
            this.linkLabelElectricalWrapper.TabStop = true;
            this.linkLabelElectricalWrapper.Text = "電子包帯";
            this.linkLabelElectricalWrapper.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelElectricalWrapper_LinkClicked);
            // 
            // linkLabelElectricalLibrary
            // 
            this.linkLabelElectricalLibrary.AutoSize = true;
            this.linkLabelElectricalLibrary.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.linkLabelElectricalLibrary.Location = new System.Drawing.Point(1557, 455);
            this.linkLabelElectricalLibrary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelElectricalLibrary.Name = "linkLabelElectricalLibrary";
            this.linkLabelElectricalLibrary.Size = new System.Drawing.Size(135, 36);
            this.linkLabelElectricalLibrary.TabIndex = 19;
            this.linkLabelElectricalLibrary.TabStop = true;
            this.linkLabelElectricalLibrary.Text = "電子図書館";
            this.linkLabelElectricalLibrary.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelElectricalLibrary_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(1049, 162);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 165);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "メモ";
            // 
            // buttonCaseReceived
            // 
            this.buttonCaseReceived.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCaseReceived.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonCaseReceived.Location = new System.Drawing.Point(1097, 565);
            this.buttonCaseReceived.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCaseReceived.Name = "buttonCaseReceived";
            this.buttonCaseReceived.Size = new System.Drawing.Size(189, 41);
            this.buttonCaseReceived.TabIndex = 34;
            this.buttonCaseReceived.Text = "受託";
            this.buttonCaseReceived.UseVisualStyleBackColor = true;
            this.buttonCaseReceived.Click += new System.EventHandler(this.buttonCaseReceived_Click);
            // 
            // buttonMeeting
            // 
            this.buttonMeeting.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonMeeting.Location = new System.Drawing.Point(1097, 610);
            this.buttonMeeting.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMeeting.Name = "buttonMeeting";
            this.buttonMeeting.Size = new System.Drawing.Size(189, 41);
            this.buttonMeeting.TabIndex = 35;
            this.buttonMeeting.Text = "打合せ";
            this.buttonMeeting.UseVisualStyleBackColor = true;
            this.buttonMeeting.Click += new System.EventHandler(this.buttonMeeting_Click);
            // 
            // buttonSupplementReceived
            // 
            this.buttonSupplementReceived.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSupplementReceived.Location = new System.Drawing.Point(1097, 655);
            this.buttonSupplementReceived.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSupplementReceived.Name = "buttonSupplementReceived";
            this.buttonSupplementReceived.Size = new System.Drawing.Size(189, 41);
            this.buttonSupplementReceived.TabIndex = 36;
            this.buttonSupplementReceived.Text = "補充資料受領";
            this.buttonSupplementReceived.UseVisualStyleBackColor = true;
            this.buttonSupplementReceived.Click += new System.EventHandler(this.buttonSupplementReceived_Click);
            // 
            // buttonDraftDeadline
            // 
            this.buttonDraftDeadline.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonDraftDeadline.Location = new System.Drawing.Point(1097, 704);
            this.buttonDraftDeadline.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDraftDeadline.Name = "buttonDraftDeadline";
            this.buttonDraftDeadline.Size = new System.Drawing.Size(189, 41);
            this.buttonDraftDeadline.TabIndex = 37;
            this.buttonDraftDeadline.Text = "初稿期限";
            this.buttonDraftDeadline.UseVisualStyleBackColor = true;
            this.buttonDraftDeadline.Click += new System.EventHandler(this.buttonDraftDeadline_Click);
            // 
            // buttonDraftSent
            // 
            this.buttonDraftSent.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonDraftSent.Location = new System.Drawing.Point(1097, 752);
            this.buttonDraftSent.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDraftSent.Name = "buttonDraftSent";
            this.buttonDraftSent.Size = new System.Drawing.Size(189, 41);
            this.buttonDraftSent.TabIndex = 38;
            this.buttonDraftSent.Text = "初稿送付";
            this.buttonDraftSent.UseVisualStyleBackColor = true;
            this.buttonDraftSent.Click += new System.EventHandler(this.buttonDraftSent_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(1472, 565);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 33;
            // 
            // textBoxCaseReceived
            // 
            this.textBoxCaseReceived.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxCaseReceived.Location = new System.Drawing.Point(1295, 565);
            this.textBoxCaseReceived.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCaseReceived.Name = "textBoxCaseReceived";
            this.textBoxCaseReceived.Size = new System.Drawing.Size(160, 31);
            this.textBoxCaseReceived.TabIndex = 40;
            this.textBoxCaseReceived.Text = "-";
            this.textBoxCaseReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMeeting
            // 
            this.textBoxMeeting.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxMeeting.Location = new System.Drawing.Point(1295, 611);
            this.textBoxMeeting.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMeeting.Name = "textBoxMeeting";
            this.textBoxMeeting.Size = new System.Drawing.Size(160, 31);
            this.textBoxMeeting.TabIndex = 41;
            this.textBoxMeeting.Text = "-";
            this.textBoxMeeting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSupplementReceived
            // 
            this.textBoxSupplementReceived.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxSupplementReceived.Location = new System.Drawing.Point(1295, 658);
            this.textBoxSupplementReceived.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSupplementReceived.Name = "textBoxSupplementReceived";
            this.textBoxSupplementReceived.Size = new System.Drawing.Size(160, 31);
            this.textBoxSupplementReceived.TabIndex = 42;
            this.textBoxSupplementReceived.Text = "-";
            this.textBoxSupplementReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDraftDeadline
            // 
            this.textBoxDraftDeadline.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxDraftDeadline.Location = new System.Drawing.Point(1295, 704);
            this.textBoxDraftDeadline.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDraftDeadline.Name = "textBoxDraftDeadline";
            this.textBoxDraftDeadline.Size = new System.Drawing.Size(160, 31);
            this.textBoxDraftDeadline.TabIndex = 43;
            this.textBoxDraftDeadline.Text = "-";
            this.textBoxDraftDeadline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDraftSent
            // 
            this.textBoxDraftSent.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxDraftSent.Location = new System.Drawing.Point(1295, 752);
            this.textBoxDraftSent.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDraftSent.Name = "textBoxDraftSent";
            this.textBoxDraftSent.Size = new System.Drawing.Size(160, 31);
            this.textBoxDraftSent.TabIndex = 44;
            this.textBoxDraftSent.Text = "-";
            this.textBoxDraftSent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDraftTerm
            // 
            this.textBoxDraftTerm.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxDraftTerm.Location = new System.Drawing.Point(1295, 806);
            this.textBoxDraftTerm.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDraftTerm.Name = "textBoxDraftTerm";
            this.textBoxDraftTerm.Size = new System.Drawing.Size(160, 31);
            this.textBoxDraftTerm.TabIndex = 45;
            this.textBoxDraftTerm.Text = "-";
            this.textBoxDraftTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(1121, 810);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 46;
            this.label3.Text = "ドラフト日数";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1843, 924);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDraftTerm);
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
            this.Controls.Add(this.textBox1);
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
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
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

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBoxNumberOfCases;
        private System.Windows.Forms.DataGridView dataGridViewCaseList;
        private CaseList caseList;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 進捗状況DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 事務所整理番号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 顧客整理番号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出願期限DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTableCaseListBindingSource;
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
        private System.Windows.Forms.TextBox textBoxDraftTerm;
        private System.Windows.Forms.Label label3;
    }
}

