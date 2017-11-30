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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.btnPref = new System.Windows.Forms.Button();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.bsGrid = new System.Windows.Forms.BindingSource(this.components);
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
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
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer1.Size = new System.Drawing.Size(407, 441);
            this.splitContainer1.SplitterDistance = 387;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnPref);
            this.splitContainer2.Panel1.Controls.Add(this.tbText);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.tbOutput);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gridData);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.splitContainer2.Size = new System.Drawing.Size(407, 387);
            this.splitContainer2.SplitterDistance = 231;
            this.splitContainer2.TabIndex = 0;
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(59, 6);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(282, 19);
            this.tbOutput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "出力先";
            // 
            // tbText
            // 
            this.tbText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Text", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbText.Location = new System.Drawing.Point(10, 31);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(387, 197);
            this.tbText.TabIndex = 2;
            // 
            // btnPref
            // 
            this.btnPref.Location = new System.Drawing.Point(347, 6);
            this.btnPref.Name = "btnPref";
            this.btnPref.Size = new System.Drawing.Size(46, 23);
            this.btnPref.TabIndex = 3;
            this.btnPref.Text = "参照";
            this.btnPref.UseVisualStyleBackColor = true;
            // 
            // gridData
            // 
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.Location = new System.Drawing.Point(10, 0);
            this.gridData.Name = "gridData";
            this.gridData.RowTemplate.Height = 21;
            this.gridData.Size = new System.Drawing.Size(387, 152);
            this.gridData.TabIndex = 0;
            // 
            // btnOutput
            // 
            this.btnOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOutput.Location = new System.Drawing.Point(329, 3);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Padding = new System.Windows.Forms.Padding(3);
            this.btnOutput.Size = new System.Drawing.Size(75, 44);
            this.btnOutput.TabIndex = 0;
            this.btnOutput.Text = "出力";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAnalyze.Location = new System.Drawing.Point(254, 3);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Padding = new System.Windows.Forms.Padding(3);
            this.btnAnalyze.Size = new System.Drawing.Size(75, 44);
            this.btnAnalyze.TabIndex = 1;
            this.btnAnalyze.Text = "解析";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // bsGrid
            // 
            this.bsGrid.DataMember = "DataList";
            this.bsGrid.DataSource = this.bsMain;
            // 
            // bsMain
            // 
            this.bsMain.DataSource = typeof(TheHolyChaliceOfChan.Model);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 441);
            this.Controls.Add(this.splitContainer1);
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
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.BindingSource bsMain;
        private System.Windows.Forms.BindingSource bsGrid;
    }
}

