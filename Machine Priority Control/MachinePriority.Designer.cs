namespace Machine_Priority_Control {
  partial class MachinePriority {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.buttonOK = new System.Windows.Forms.Button();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.listBox3 = new System.Windows.Forms.ListBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.listBox2 = new System.Windows.Forms.ListBox();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.label7 = new System.Windows.Forms.Label();
      this.listBox4 = new System.Windows.Forms.ListBox();
      this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
      this.label4 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.testbutton1 = new System.Windows.Forms.Button();
      this.cUTMACHINESBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
      this.eNGINEERINGDataSet = new Machine_Priority_Control.ENGINEERINGDataSet();
      this.cUTMACHINESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.cUTMACHINESBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.cUTPARTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.cUT_MACHINESTableAdapter = new Machine_Priority_Control.ENGINEERINGDataSetTableAdapters.CUT_MACHINESTableAdapter();
      this.cUT_PARTSTableAdapter = new Machine_Priority_Control.ENGINEERINGDataSetTableAdapters.CUT_PARTSTableAdapter();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.tableLayoutPanel4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cUTMACHINESBindingSource2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.eNGINEERINGDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cUTMACHINESBindingSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cUTMACHINESBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cUTPARTSBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(608, 392);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Controls.Add(this.buttonOK, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.buttonCancel, 0, 0);
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 360);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(602, 29);
      this.tableLayoutPanel2.TabIndex = 0;
      // 
      // buttonOK
      // 
      this.buttonOK.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonOK.Location = new System.Drawing.Point(304, 3);
      this.buttonOK.Name = "buttonOK";
      this.buttonOK.Size = new System.Drawing.Size(295, 23);
      this.buttonOK.TabIndex = 0;
      this.buttonOK.Text = "OK";
      this.buttonOK.UseVisualStyleBackColor = true;
      this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
      // 
      // buttonCancel
      // 
      this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonCancel.Location = new System.Drawing.Point(3, 3);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(295, 23);
      this.buttonCancel.TabIndex = 1;
      this.buttonCancel.Text = "Cancel";
      this.buttonCancel.UseVisualStyleBackColor = true;
      this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel3.ColumnCount = 4;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel3.Controls.Add(this.listBox3, 3, 1);
      this.tableLayoutPanel3.Controls.Add(this.label3, 3, 0);
      this.tableLayoutPanel3.Controls.Add(this.label2, 2, 0);
      this.tableLayoutPanel3.Controls.Add(this.label1, 1, 0);
      this.tableLayoutPanel3.Controls.Add(this.listBox2, 2, 1);
      this.tableLayoutPanel3.Controls.Add(this.listBox1, 1, 1);
      this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
      this.tableLayoutPanel3.Controls.Add(this.listBox4, 0, 1);
      this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 41);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 2;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(602, 313);
      this.tableLayoutPanel3.TabIndex = 1;
      // 
      // listBox3
      // 
      this.listBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.listBox3.DataSource = this.cUTMACHINESBindingSource2;
      this.listBox3.DisplayMember = "MACHNAME";
      this.listBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listBox3.FormattingEnabled = true;
      this.listBox3.ItemHeight = 17;
      this.listBox3.Location = new System.Drawing.Point(453, 38);
      this.listBox3.Name = "listBox3";
      this.listBox3.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
      this.listBox3.Size = new System.Drawing.Size(146, 259);
      this.listBox3.TabIndex = 0;
      this.listBox3.ValueMember = "MACHID";
      this.listBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox3_MouseClick);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(453, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(146, 35);
      this.label3.TabIndex = 3;
      this.label3.Text = "3";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(303, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(144, 35);
      this.label2.TabIndex = 2;
      this.label2.Text = "2";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(153, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(144, 35);
      this.label1.TabIndex = 1;
      this.label1.Text = "1";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // listBox2
      // 
      this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.listBox2.DataSource = this.cUTMACHINESBindingSource1;
      this.listBox2.DisplayMember = "MACHNAME";
      this.listBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listBox2.FormattingEnabled = true;
      this.listBox2.ItemHeight = 17;
      this.listBox2.Location = new System.Drawing.Point(303, 38);
      this.listBox2.Name = "listBox2";
      this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
      this.listBox2.Size = new System.Drawing.Size(144, 259);
      this.listBox2.TabIndex = 0;
      this.listBox2.ValueMember = "MACHID";
      this.listBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseClick);
      // 
      // listBox1
      // 
      this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.listBox1.DataSource = this.cUTMACHINESBindingSource;
      this.listBox1.DisplayMember = "MACHNAME";
      this.listBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 17;
      this.listBox1.Location = new System.Drawing.Point(153, 38);
      this.listBox1.Name = "listBox1";
      this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
      this.listBox1.Size = new System.Drawing.Size(144, 259);
      this.listBox1.TabIndex = 0;
      this.listBox1.ValueMember = "MACHID";
      this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label7.Location = new System.Drawing.Point(3, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(144, 35);
      this.label7.TabIndex = 4;
      this.label7.Text = "Common Parts";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // listBox4
      // 
      this.listBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.listBox4.DisplayMember = "PARTNUM";
      this.listBox4.FormattingEnabled = true;
      this.listBox4.Location = new System.Drawing.Point(3, 38);
      this.listBox4.Name = "listBox4";
      this.listBox4.Size = new System.Drawing.Size(144, 264);
      this.listBox4.TabIndex = 5;
      this.listBox4.ValueMember = "PARTID";
      this.listBox4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox4_MouseClick);
      this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
      // 
      // tableLayoutPanel4
      // 
      this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.tableLayoutPanel4.ColumnCount = 7;
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
      this.tableLayoutPanel4.Controls.Add(this.comboBox1, 1, 0);
      this.tableLayoutPanel4.Controls.Add(this.label5, 2, 0);
      this.tableLayoutPanel4.Controls.Add(this.label6, 4, 0);
      this.tableLayoutPanel4.Controls.Add(this.textBox1, 3, 0);
      this.tableLayoutPanel4.Controls.Add(this.textBox2, 5, 0);
      this.tableLayoutPanel4.Controls.Add(this.testbutton1, 6, 0);
      this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
      this.tableLayoutPanel4.Name = "tableLayoutPanel4";
      this.tableLayoutPanel4.RowCount = 1;
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel4.Size = new System.Drawing.Size(598, 32);
      this.tableLayoutPanel4.TabIndex = 2;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(3, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(30, 13);
      this.label4.TabIndex = 0;
      this.label4.Text = "Part:";
      // 
      // comboBox1
      // 
      this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.comboBox1.DataSource = this.cUTPARTSBindingSource;
      this.comboBox1.DisplayMember = "PARTNUM";
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(53, 3);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(222, 21);
      this.comboBox1.TabIndex = 1;
      this.comboBox1.ValueMember = "PARTID";
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(281, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(38, 13);
      this.label5.TabIndex = 2;
      this.label5.Text = "CNC1:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(431, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(38, 13);
      this.label6.TabIndex = 3;
      this.label6.Text = "CNC2:";
      // 
      // textBox1
      // 
      this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUTPARTSBindingSource, "CNC1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.cUTPARTSBindingSource, "PARTNUM", true));
      this.textBox1.Location = new System.Drawing.Point(331, 3);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(94, 15);
      this.textBox1.TabIndex = 4;
      // 
      // textBox2
      // 
      this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUTPARTSBindingSource, "CNC2", true));
      this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.cUTPARTSBindingSource, "PARTNUM", true));
      this.textBox2.Location = new System.Drawing.Point(481, 3);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(94, 15);
      this.textBox2.TabIndex = 5;
      // 
      // testbutton1
      // 
      this.testbutton1.Location = new System.Drawing.Point(581, 3);
      this.testbutton1.Name = "testbutton1";
      this.testbutton1.Size = new System.Drawing.Size(14, 23);
      this.testbutton1.TabIndex = 6;
      this.testbutton1.Text = "testbutton1";
      this.testbutton1.UseVisualStyleBackColor = true;
      this.testbutton1.Visible = false;
      this.testbutton1.Click += new System.EventHandler(this.testbutton1_Click);
      // 
      // cUTMACHINESBindingSource2
      // 
      this.cUTMACHINESBindingSource2.DataMember = "CUT_MACHINES";
      this.cUTMACHINESBindingSource2.DataSource = this.eNGINEERINGDataSet;
      // 
      // eNGINEERINGDataSet
      // 
      this.eNGINEERINGDataSet.DataSetName = "ENGINEERINGDataSet";
      this.eNGINEERINGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // cUTMACHINESBindingSource1
      // 
      this.cUTMACHINESBindingSource1.DataMember = "CUT_MACHINES";
      this.cUTMACHINESBindingSource1.DataSource = this.eNGINEERINGDataSet;
      // 
      // cUTMACHINESBindingSource
      // 
      this.cUTMACHINESBindingSource.DataMember = "CUT_MACHINES";
      this.cUTMACHINESBindingSource.DataSource = this.eNGINEERINGDataSet;
      // 
      // cUTPARTSBindingSource
      // 
      this.cUTPARTSBindingSource.DataMember = "CUT_PARTS";
      this.cUTPARTSBindingSource.DataSource = this.eNGINEERINGDataSet;
      // 
      // cUT_MACHINESTableAdapter
      // 
      this.cUT_MACHINESTableAdapter.ClearBeforeFill = true;
      // 
      // cUT_PARTSTableAdapter
      // 
      this.cUT_PARTSTableAdapter.ClearBeforeFill = true;
      // 
      // MachinePriority
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(632, 416);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "MachinePriority";
      this.Text = "Machine Priority";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MachinePriority_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel3.PerformLayout();
      this.tableLayoutPanel4.ResumeLayout(false);
      this.tableLayoutPanel4.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cUTMACHINESBindingSource2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.eNGINEERINGDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cUTMACHINESBindingSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cUTMACHINESBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cUTPARTSBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button buttonOK;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.ListBox listBox2;
    private System.Windows.Forms.ListBox listBox3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private ENGINEERINGDataSet eNGINEERINGDataSet;
    private System.Windows.Forms.BindingSource cUTMACHINESBindingSource;
    private ENGINEERINGDataSetTableAdapters.CUT_MACHINESTableAdapter cUT_MACHINESTableAdapter;
    private System.Windows.Forms.BindingSource cUTMACHINESBindingSource1;
    private System.Windows.Forms.BindingSource cUTMACHINESBindingSource2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.BindingSource cUTPARTSBindingSource;
    private ENGINEERINGDataSetTableAdapters.CUT_PARTSTableAdapter cUT_PARTSTableAdapter;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button testbutton1;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.ListBox listBox4;
  }
}