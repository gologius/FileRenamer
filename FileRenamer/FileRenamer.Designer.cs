namespace FileRenamer
{
    partial class FileRenamer
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.regexp1Text = new System.Windows.Forms.TextBox();
            this.fileView = new System.Windows.Forms.DataGridView();
            this.filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repalce1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.replace2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.replace3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullpath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regexp2Text = new System.Windows.Forms.TextBox();
            this.regexp3Text = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openPathMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.renameMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.replace11Text = new System.Windows.Forms.TextBox();
            this.replace12Text = new System.Windows.Forms.TextBox();
            this.replace13Text = new System.Windows.Forms.TextBox();
            this.selectReplace1Text = new System.Windows.Forms.TextBox();
            this.selectReplaceButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.replace63Text = new System.Windows.Forms.TextBox();
            this.replace43Text = new System.Windows.Forms.TextBox();
            this.replace53Text = new System.Windows.Forms.TextBox();
            this.replace23Text = new System.Windows.Forms.TextBox();
            this.replace33Text = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.replace62Text = new System.Windows.Forms.TextBox();
            this.replace22Text = new System.Windows.Forms.TextBox();
            this.replace32Text = new System.Windows.Forms.TextBox();
            this.replace42Text = new System.Windows.Forms.TextBox();
            this.replace52Text = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.replace61Text = new System.Windows.Forms.TextBox();
            this.replace21Text = new System.Windows.Forms.TextBox();
            this.replace31Text = new System.Windows.Forms.TextBox();
            this.replace41Text = new System.Windows.Forms.TextBox();
            this.replace51Text = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selectUnionButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.selectReplace2Text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // regexp1Text
            // 
            this.regexp1Text.Location = new System.Drawing.Point(117, 20);
            this.regexp1Text.Name = "regexp1Text";
            this.regexp1Text.Size = new System.Drawing.Size(102, 19);
            this.regexp1Text.TabIndex = 1;
            this.regexp1Text.Text = "^\\(.+?\\)";
            // 
            // fileView
            // 
            this.fileView.AllowUserToAddRows = false;
            this.fileView.AllowUserToDeleteRows = false;
            this.fileView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filename,
            this.repalce1,
            this.replace2,
            this.replace3,
            this.fullpath});
            this.fileView.Location = new System.Drawing.Point(505, 29);
            this.fileView.Name = "fileView";
            this.fileView.RowTemplate.Height = 21;
            this.fileView.Size = new System.Drawing.Size(467, 521);
            this.fileView.TabIndex = 8;
            this.fileView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // filename
            // 
            this.filename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.filename.HeaderText = "filename";
            this.filename.Name = "filename";
            // 
            // repalce1
            // 
            this.repalce1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.repalce1.HeaderText = "replace1";
            this.repalce1.Name = "repalce1";
            // 
            // replace2
            // 
            this.replace2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.replace2.HeaderText = "replace2";
            this.replace2.Name = "replace2";
            // 
            // replace3
            // 
            this.replace3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.replace3.HeaderText = "replace3";
            this.replace3.Name = "replace3";
            // 
            // fullpath
            // 
            this.fullpath.HeaderText = "fullpath";
            this.fullpath.Name = "fullpath";
            this.fullpath.ReadOnly = true;
            this.fullpath.Visible = false;
            // 
            // regexp2Text
            // 
            this.regexp2Text.Location = new System.Drawing.Point(239, 20);
            this.regexp2Text.Name = "regexp2Text";
            this.regexp2Text.Size = new System.Drawing.Size(100, 19);
            this.regexp2Text.TabIndex = 11;
            this.regexp2Text.Text = "\\[.+?\\]";
            // 
            // regexp3Text
            // 
            this.regexp3Text.Location = new System.Drawing.Point(357, 20);
            this.regexp3Text.Name = "regexp3Text";
            this.regexp3Text.Size = new System.Drawing.Size(100, 19);
            this.regexp3Text.TabIndex = 12;
            this.regexp3Text.Text = "\\].*";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(6, 18);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(101, 23);
            this.convertButton.TabIndex = 13;
            this.convertButton.Text = "行抽出";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPathMenu,
            this.renameMenu,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openPathMenu
            // 
            this.openPathMenu.Name = "openPathMenu";
            this.openPathMenu.Size = new System.Drawing.Size(82, 20);
            this.openPathMenu.Text = "フォルダを開く";
            this.openPathMenu.Click += new System.EventHandler(this.openPathMenu_Click);
            // 
            // renameMenu
            // 
            this.renameMenu.Name = "renameMenu";
            this.renameMenu.Size = new System.Drawing.Size(85, 20);
            this.renameMenu.Text = "ファイルに反映";
            this.renameMenu.Click += new System.EventHandler(this.renameMenu_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(123, 20);
            this.toolStripMenuItem1.Text = "よく使う表現(未実装)";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItem2.Text = "設定";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(6, 51);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(101, 23);
            this.replaceButton.TabIndex = 17;
            this.replaceButton.Text = "行置換";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(117, 55);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(30, 16);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(239, 55);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(30, 16);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(357, 55);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(30, 16);
            this.checkBox3.TabIndex = 20;
            this.checkBox3.Text = "3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // replace11Text
            // 
            this.replace11Text.Location = new System.Drawing.Point(6, 18);
            this.replace11Text.Name = "replace11Text";
            this.replace11Text.Size = new System.Drawing.Size(102, 19);
            this.replace11Text.TabIndex = 21;
            this.replace11Text.Text = "%ss%";
            // 
            // replace12Text
            // 
            this.replace12Text.Location = new System.Drawing.Point(6, 18);
            this.replace12Text.Name = "replace12Text";
            this.replace12Text.Size = new System.Drawing.Size(100, 19);
            this.replace12Text.TabIndex = 22;
            this.replace12Text.Text = "%ss%";
            // 
            // replace13Text
            // 
            this.replace13Text.Location = new System.Drawing.Point(5, 18);
            this.replace13Text.Name = "replace13Text";
            this.replace13Text.Size = new System.Drawing.Size(100, 19);
            this.replace13Text.TabIndex = 23;
            this.replace13Text.Text = "%ss%";
            // 
            // selectReplace1Text
            // 
            this.selectReplace1Text.Location = new System.Drawing.Point(158, 20);
            this.selectReplace1Text.Name = "selectReplace1Text";
            this.selectReplace1Text.Size = new System.Drawing.Size(115, 19);
            this.selectReplace1Text.TabIndex = 24;
            // 
            // selectReplaceButton
            // 
            this.selectReplaceButton.Location = new System.Drawing.Point(6, 18);
            this.selectReplaceButton.Name = "selectReplaceButton";
            this.selectReplaceButton.Size = new System.Drawing.Size(100, 23);
            this.selectReplaceButton.TabIndex = 25;
            this.selectReplaceButton.Text = "選択置換";
            this.selectReplaceButton.UseVisualStyleBackColor = true;
            this.selectReplaceButton.Click += new System.EventHandler(this.selectReplaceButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.convertButton);
            this.groupBox1.Controls.Add(this.regexp1Text);
            this.groupBox1.Controls.Add(this.regexp2Text);
            this.groupBox1.Controls.Add(this.regexp3Text);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.replaceButton);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(14, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 318);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "行処理";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 30;
            this.label8.Text = "置換後";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 29;
            this.label7.Text = "置換前";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "置換後";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 29;
            this.label5.Text = "置換前";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 30;
            this.label4.Text = "置換後";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 29;
            this.label3.Text = "置換前";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.replace63Text);
            this.groupBox5.Controls.Add(this.replace43Text);
            this.groupBox5.Controls.Add(this.replace13Text);
            this.groupBox5.Controls.Add(this.replace53Text);
            this.groupBox5.Controls.Add(this.replace23Text);
            this.groupBox5.Controls.Add(this.replace33Text);
            this.groupBox5.Location = new System.Drawing.Point(352, 85);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(112, 223);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "3列目置換";
            // 
            // replace63Text
            // 
            this.replace63Text.Location = new System.Drawing.Point(6, 195);
            this.replace63Text.Name = "replace63Text";
            this.replace63Text.Size = new System.Drawing.Size(100, 19);
            this.replace63Text.TabIndex = 36;
            this.replace63Text.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // replace43Text
            // 
            this.replace43Text.Location = new System.Drawing.Point(6, 119);
            this.replace43Text.Name = "replace43Text";
            this.replace43Text.Size = new System.Drawing.Size(100, 19);
            this.replace43Text.TabIndex = 34;
            this.replace43Text.TextChanged += new System.EventHandler(this.replace43Text_TextChanged);
            // 
            // replace53Text
            // 
            this.replace53Text.Location = new System.Drawing.Point(6, 170);
            this.replace53Text.Name = "replace53Text";
            this.replace53Text.Size = new System.Drawing.Size(100, 19);
            this.replace53Text.TabIndex = 35;
            // 
            // replace23Text
            // 
            this.replace23Text.Location = new System.Drawing.Point(6, 43);
            this.replace23Text.Name = "replace23Text";
            this.replace23Text.Size = new System.Drawing.Size(100, 19);
            this.replace23Text.TabIndex = 32;
            // 
            // replace33Text
            // 
            this.replace33Text.Location = new System.Drawing.Point(6, 94);
            this.replace33Text.Name = "replace33Text";
            this.replace33Text.Size = new System.Drawing.Size(100, 19);
            this.replace33Text.TabIndex = 33;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.replace62Text);
            this.groupBox4.Controls.Add(this.replace12Text);
            this.groupBox4.Controls.Add(this.replace22Text);
            this.groupBox4.Controls.Add(this.replace32Text);
            this.groupBox4.Controls.Add(this.replace42Text);
            this.groupBox4.Controls.Add(this.replace52Text);
            this.groupBox4.Location = new System.Drawing.Point(233, 85);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(113, 223);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "2列目置換";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // replace62Text
            // 
            this.replace62Text.Location = new System.Drawing.Point(6, 195);
            this.replace62Text.Name = "replace62Text";
            this.replace62Text.Size = new System.Drawing.Size(100, 19);
            this.replace62Text.TabIndex = 32;
            // 
            // replace22Text
            // 
            this.replace22Text.Location = new System.Drawing.Point(7, 43);
            this.replace22Text.Name = "replace22Text";
            this.replace22Text.Size = new System.Drawing.Size(100, 19);
            this.replace22Text.TabIndex = 28;
            // 
            // replace32Text
            // 
            this.replace32Text.Location = new System.Drawing.Point(8, 94);
            this.replace32Text.Name = "replace32Text";
            this.replace32Text.Size = new System.Drawing.Size(100, 19);
            this.replace32Text.TabIndex = 29;
            // 
            // replace42Text
            // 
            this.replace42Text.Location = new System.Drawing.Point(9, 119);
            this.replace42Text.Name = "replace42Text";
            this.replace42Text.Size = new System.Drawing.Size(97, 19);
            this.replace42Text.TabIndex = 30;
            // 
            // replace52Text
            // 
            this.replace52Text.Location = new System.Drawing.Point(7, 170);
            this.replace52Text.Name = "replace52Text";
            this.replace52Text.Size = new System.Drawing.Size(99, 19);
            this.replace52Text.TabIndex = 31;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.replace61Text);
            this.groupBox3.Controls.Add(this.replace11Text);
            this.groupBox3.Controls.Add(this.replace21Text);
            this.groupBox3.Controls.Add(this.replace31Text);
            this.groupBox3.Controls.Add(this.replace41Text);
            this.groupBox3.Controls.Add(this.replace51Text);
            this.groupBox3.Location = new System.Drawing.Point(111, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(116, 223);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "1列目置換";
            // 
            // replace61Text
            // 
            this.replace61Text.Location = new System.Drawing.Point(8, 195);
            this.replace61Text.Name = "replace61Text";
            this.replace61Text.Size = new System.Drawing.Size(100, 19);
            this.replace61Text.TabIndex = 28;
            // 
            // replace21Text
            // 
            this.replace21Text.Location = new System.Drawing.Point(6, 43);
            this.replace21Text.Name = "replace21Text";
            this.replace21Text.Size = new System.Drawing.Size(102, 19);
            this.replace21Text.TabIndex = 24;
            // 
            // replace31Text
            // 
            this.replace31Text.Location = new System.Drawing.Point(6, 94);
            this.replace31Text.Name = "replace31Text";
            this.replace31Text.Size = new System.Drawing.Size(102, 19);
            this.replace31Text.TabIndex = 25;
            // 
            // replace41Text
            // 
            this.replace41Text.Location = new System.Drawing.Point(6, 119);
            this.replace41Text.Name = "replace41Text";
            this.replace41Text.Size = new System.Drawing.Size(102, 19);
            this.replace41Text.TabIndex = 26;
            // 
            // replace51Text
            // 
            this.replace51Text.Location = new System.Drawing.Point(7, 170);
            this.replace51Text.Name = "replace51Text";
            this.replace51Text.Size = new System.Drawing.Size(101, 19);
            this.replace51Text.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectUnionButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.selectReplace2Text);
            this.groupBox2.Controls.Add(this.selectReplaceButton);
            this.groupBox2.Controls.Add(this.selectReplace1Text);
            this.groupBox2.Location = new System.Drawing.Point(14, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 78);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "選択処理";
            // 
            // selectUnionButton
            // 
            this.selectUnionButton.Location = new System.Drawing.Point(6, 48);
            this.selectUnionButton.Name = "selectUnionButton";
            this.selectUnionButton.Size = new System.Drawing.Size(100, 23);
            this.selectUnionButton.TabIndex = 29;
            this.selectUnionButton.Text = "選択行連結";
            this.selectUnionButton.UseVisualStyleBackColor = true;
            this.selectUnionButton.Click += new System.EventHandler(this.selectUnionButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 28;
            this.label2.Text = "置換後";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "置換前";
            // 
            // selectReplace2Text
            // 
            this.selectReplace2Text.Location = new System.Drawing.Point(326, 20);
            this.selectReplace2Text.Name = "selectReplace2Text";
            this.selectReplace2Text.Size = new System.Drawing.Size(113, 19);
            this.selectReplace2Text.TabIndex = 26;
            // 
            // FileRenamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fileView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FileRenamer";
            this.Text = "FileRenamer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox regexp1Text;
        private System.Windows.Forms.DataGridView fileView;
        private System.Windows.Forms.DataGridViewTextBoxColumn filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn repalce1;
        private System.Windows.Forms.DataGridViewTextBoxColumn replace2;
        private System.Windows.Forms.DataGridViewTextBoxColumn replace3;
        private System.Windows.Forms.TextBox regexp2Text;
        private System.Windows.Forms.TextBox regexp3Text;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openPathMenu;
        private System.Windows.Forms.ToolStripMenuItem renameMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox replace11Text;
        private System.Windows.Forms.TextBox replace12Text;
        private System.Windows.Forms.TextBox replace13Text;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullpath;
        private System.Windows.Forms.TextBox selectReplace1Text;
        private System.Windows.Forms.Button selectReplaceButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox selectReplace2Text;
        private System.Windows.Forms.Button selectUnionButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.TextBox replace53Text;
        private System.Windows.Forms.TextBox replace43Text;
        private System.Windows.Forms.TextBox replace33Text;
        private System.Windows.Forms.TextBox replace23Text;
        private System.Windows.Forms.TextBox replace52Text;
        private System.Windows.Forms.TextBox replace42Text;
        private System.Windows.Forms.TextBox replace32Text;
        private System.Windows.Forms.TextBox replace22Text;
        private System.Windows.Forms.TextBox replace51Text;
        private System.Windows.Forms.TextBox replace41Text;
        private System.Windows.Forms.TextBox replace31Text;
        private System.Windows.Forms.TextBox replace21Text;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox replace63Text;
        private System.Windows.Forms.TextBox replace62Text;
        private System.Windows.Forms.TextBox replace61Text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

