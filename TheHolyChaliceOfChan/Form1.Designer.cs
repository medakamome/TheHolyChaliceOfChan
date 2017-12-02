namespace TheHolyChaliceOfChan
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tbBaseLot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPref = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.Recommend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsGrid = new System.Windows.Forms.BindingSource(this.components);
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.doOrderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.curPairDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderModeTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopLossDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takeProfitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnAnalyze);
            this.splitContainer1.Panel2.Controls.Add(this.btnOutput);
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(3);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.splitContainer1.Size = new System.Drawing.Size(564, 475);
            this.splitContainer1.SplitterDistance = 421;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.tbBaseLot);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.btnPref);
            this.splitContainer2.Panel1.Controls.Add(this.tbText);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.tbOutput);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gridData);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.splitContainer2.Size = new System.Drawing.Size(564, 421);
            this.splitContainer2.SplitterDistance = 231;
            this.splitContainer2.TabIndex = 0;
            // 
            // tbBaseLot
            // 
            this.tbBaseLot.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "BaseLot", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.tbBaseLot.Location = new System.Drawing.Point(72, 32);
            this.tbBaseLot.Name = "tbBaseLot";
            this.tbBaseLot.Size = new System.Drawing.Size(45, 19);
            this.tbBaseLot.TabIndex = 2;
            this.tbBaseLot.Text = "1,0";
            this.tbBaseLot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "基準Lot";
            // 
            // btnPref
            // 
            this.btnPref.Location = new System.Drawing.Point(485, 4);
            this.btnPref.Name = "btnPref";
            this.btnPref.Size = new System.Drawing.Size(46, 23);
            this.btnPref.TabIndex = 1;
            this.btnPref.Text = "参照";
            this.btnPref.UseVisualStyleBackColor = true;
            this.btnPref.Click += new System.EventHandler(this.btnPref_Click);
            // 
            // tbText
            // 
            this.tbText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Text", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbText.Location = new System.Drawing.Point(10, 57);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbText.Size = new System.Drawing.Size(387, 171);
            this.tbText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "出力先";
            // 
            // tbOutput
            // 
            this.tbOutput.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "OutDirectory", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbOutput.Location = new System.Drawing.Point(72, 6);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(407, 19);
            this.tbOutput.TabIndex = 0;
            // 
            // gridData
            // 
            this.gridData.AllowUserToAddRows = false;
            this.gridData.AllowUserToDeleteRows = false;
            this.gridData.AllowUserToResizeRows = false;
            this.gridData.AutoGenerateColumns = false;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doOrderDataGridViewCheckBoxColumn,
            this.Recommend,
            this.curPairDataGridViewTextBoxColumn,
            this.orderModeDataGridViewTextBoxColumn,
            this.orderModeTextDataGridViewTextBoxColumn,
            this.lotDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.stopLossDataGridViewTextBoxColumn,
            this.takeProfitDataGridViewTextBoxColumn,
            this.expirationDataGridViewTextBoxColumn});
            this.gridData.DataSource = this.bsGrid;
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.Location = new System.Drawing.Point(10, 0);
            this.gridData.Name = "gridData";
            this.gridData.RowHeadersVisible = false;
            this.gridData.RowTemplate.Height = 21;
            this.gridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridData.Size = new System.Drawing.Size(544, 186);
            this.gridData.TabIndex = 4;
            // 
            // Recommend
            // 
            this.Recommend.DataPropertyName = "Recommend";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Recommend.DefaultCellStyle = dataGridViewCellStyle1;
            this.Recommend.HeaderText = "推奨";
            this.Recommend.Name = "Recommend";
            this.Recommend.ReadOnly = true;
            this.Recommend.Width = 40;
            // 
            // bsGrid
            // 
            this.bsGrid.DataMember = "DataList";
            this.bsGrid.DataSource = this.bsMain;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAnalyze.Location = new System.Drawing.Point(404, 3);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Padding = new System.Windows.Forms.Padding(3);
            this.btnAnalyze.Size = new System.Drawing.Size(75, 44);
            this.btnAnalyze.TabIndex = 1;
            this.btnAnalyze.Text = "解析";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOutput.Location = new System.Drawing.Point(479, 3);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Padding = new System.Windows.Forms.Padding(3);
            this.btnOutput.Size = new System.Drawing.Size(75, 44);
            this.btnOutput.TabIndex = 0;
            this.btnOutput.Text = "出力";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "期限（分）";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Expiration", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.textBox1.Location = new System.Drawing.Point(197, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 19);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "720";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bsMain
            // 
            this.bsMain.DataSource = typeof(TheHolyChaliceOfChan.Model);
            // 
            // doOrderDataGridViewCheckBoxColumn
            // 
            this.doOrderDataGridViewCheckBoxColumn.DataPropertyName = "DoOrder";
            this.doOrderDataGridViewCheckBoxColumn.HeaderText = "発注";
            this.doOrderDataGridViewCheckBoxColumn.Name = "doOrderDataGridViewCheckBoxColumn";
            this.doOrderDataGridViewCheckBoxColumn.Width = 60;
            // 
            // curPairDataGridViewTextBoxColumn
            // 
            this.curPairDataGridViewTextBoxColumn.DataPropertyName = "CurPair";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.curPairDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.curPairDataGridViewTextBoxColumn.HeaderText = "通貨ペア";
            this.curPairDataGridViewTextBoxColumn.Name = "curPairDataGridViewTextBoxColumn";
            this.curPairDataGridViewTextBoxColumn.Width = 80;
            // 
            // orderModeDataGridViewTextBoxColumn
            // 
            this.orderModeDataGridViewTextBoxColumn.DataPropertyName = "OrderMode";
            this.orderModeDataGridViewTextBoxColumn.HeaderText = "OrderMode";
            this.orderModeDataGridViewTextBoxColumn.Name = "orderModeDataGridViewTextBoxColumn";
            this.orderModeDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderModeTextDataGridViewTextBoxColumn
            // 
            this.orderModeTextDataGridViewTextBoxColumn.DataPropertyName = "OrderModeText";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.orderModeTextDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.orderModeTextDataGridViewTextBoxColumn.HeaderText = "注文";
            this.orderModeTextDataGridViewTextBoxColumn.Name = "orderModeTextDataGridViewTextBoxColumn";
            this.orderModeTextDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderModeTextDataGridViewTextBoxColumn.Width = 60;
            // 
            // lotDataGridViewTextBoxColumn
            // 
            this.lotDataGridViewTextBoxColumn.DataPropertyName = "Lot";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "#0.00";
            this.lotDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.lotDataGridViewTextBoxColumn.HeaderText = "Lot";
            this.lotDataGridViewTextBoxColumn.Name = "lotDataGridViewTextBoxColumn";
            this.lotDataGridViewTextBoxColumn.Width = 40;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "##0.000##";
            this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.priceDataGridViewTextBoxColumn.HeaderText = "価格";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 60;
            // 
            // stopLossDataGridViewTextBoxColumn
            // 
            this.stopLossDataGridViewTextBoxColumn.DataPropertyName = "StopLoss";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "##0.000##";
            this.stopLossDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.stopLossDataGridViewTextBoxColumn.HeaderText = "S/L";
            this.stopLossDataGridViewTextBoxColumn.Name = "stopLossDataGridViewTextBoxColumn";
            this.stopLossDataGridViewTextBoxColumn.Width = 60;
            // 
            // takeProfitDataGridViewTextBoxColumn
            // 
            this.takeProfitDataGridViewTextBoxColumn.DataPropertyName = "TakeProfit";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "##0.000##";
            this.takeProfitDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.takeProfitDataGridViewTextBoxColumn.HeaderText = "T/P";
            this.takeProfitDataGridViewTextBoxColumn.Name = "takeProfitDataGridViewTextBoxColumn";
            this.takeProfitDataGridViewTextBoxColumn.Width = 60;
            // 
            // expirationDataGridViewTextBoxColumn
            // 
            this.expirationDataGridViewTextBoxColumn.DataPropertyName = "Expiration";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.expirationDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.expirationDataGridViewTextBoxColumn.HeaderText = "期限（秒）";
            this.expirationDataGridViewTextBoxColumn.Name = "expirationDataGridViewTextBoxColumn";
            this.expirationDataGridViewTextBoxColumn.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 475);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "The Holy Chalice of Chan";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnPref;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.BindingSource bsMain;
        private System.Windows.Forms.BindingSource bsGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBaseLot;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn doOrderDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recommend;
        private System.Windows.Forms.DataGridViewTextBoxColumn curPairDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderModeTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopLossDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn takeProfitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}

