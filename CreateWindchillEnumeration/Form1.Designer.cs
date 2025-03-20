namespace CreateWindchillEnumeration
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.saveBtn = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.localeCombo = new System.Windows.Forms.ComboBox();
            this.addLocaleBtn = new System.Windows.Forms.Button();
            this.enumGrid = new System.Windows.Forms.DataGridView();
            this.InternalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MasterText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.removeLocaleBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.valueSort = new System.Windows.Forms.CheckBox();
            this.internalNameEnum = new System.Windows.Forms.TextBox();
            this.organizerName = new System.Windows.Forms.TextBox();
            this.valueDisplayName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.containerDomain = new System.Windows.Forms.TextBox();
            this.domainContainerLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.resetBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxTooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.enumGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveBtn.Location = new System.Drawing.Point(944, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(94, 23);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.save_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xml";
            this.saveFileDialog.Filter = "File XMl|*.xml";
            // 
            // localeCombo
            // 
            this.localeCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.localeCombo.FormattingEnabled = true;
            this.localeCombo.Items.AddRange(new object[] {
            "en_US",
            "en_GB",
            "de",
            "fr",
            "it",
            "es",
            "ja",
            "ko",
            "zh_cn",
            "zh_tw",
            "pt_br"});
            this.localeCombo.Location = new System.Drawing.Point(3, 3);
            this.localeCombo.Name = "localeCombo";
            this.localeCombo.Size = new System.Drawing.Size(220, 21);
            this.localeCombo.TabIndex = 2;
            // 
            // addLocaleBtn
            // 
            this.addLocaleBtn.Location = new System.Drawing.Point(229, 3);
            this.addLocaleBtn.Name = "addLocaleBtn";
            this.addLocaleBtn.Size = new System.Drawing.Size(154, 21);
            this.addLocaleBtn.TabIndex = 3;
            this.addLocaleBtn.Text = "Add Locale";
            this.addLocaleBtn.UseVisualStyleBackColor = true;
            this.addLocaleBtn.Click += new System.EventHandler(this.AddLocaleBtn_Click);
            // 
            // enumGrid
            // 
            this.enumGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enumGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InternalValue,
            this.MasterText});
            this.enumGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enumGrid.Location = new System.Drawing.Point(3, 133);
            this.enumGrid.Name = "enumGrid";
            this.enumGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect;
            this.enumGrid.Size = new System.Drawing.Size(1041, 408);
            this.enumGrid.TabIndex = 2;
            this.enumGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // InternalValue
            // 
            this.InternalValue.HeaderText = "Internal Value";
            this.InternalValue.Name = "InternalValue";
            this.InternalValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MasterText
            // 
            this.MasterText.HeaderText = "Master Text";
            this.MasterText.Name = "MasterText";
            this.MasterText.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.enumGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1047, 579);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.14121F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.97887F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1041, 124);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.addLocaleBtn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.localeCombo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.removeLocaleBtn, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 65);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(453, 56);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // removeLocaleBtn
            // 
            this.removeLocaleBtn.Location = new System.Drawing.Point(229, 31);
            this.removeLocaleBtn.Name = "removeLocaleBtn";
            this.removeLocaleBtn.Size = new System.Drawing.Size(154, 22);
            this.removeLocaleBtn.TabIndex = 4;
            this.removeLocaleBtn.Text = "Remove Locale";
            this.removeLocaleBtn.UseVisualStyleBackColor = true;
            this.removeLocaleBtn.Click += new System.EventHandler(this.RemoveLocaleBtn_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.valueSort, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.internalNameEnum, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.organizerName, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.valueDisplayName, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(453, 56);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // valueSort
            // 
            this.valueSort.AutoSize = true;
            this.valueSort.Location = new System.Drawing.Point(229, 31);
            this.valueSort.Name = "valueSort";
            this.valueSort.Size = new System.Drawing.Size(68, 17);
            this.valueSort.TabIndex = 0;
            this.valueSort.Text = "Auto sort";
            this.valueSort.UseVisualStyleBackColor = true;
            // 
            // internalNameEnum
            // 
            this.internalNameEnum.Location = new System.Drawing.Point(3, 3);
            this.internalNameEnum.Name = "internalNameEnum";
            this.internalNameEnum.Size = new System.Drawing.Size(197, 20);
            this.internalNameEnum.TabIndex = 0;
            this.internalNameEnum.Text = "EnumName";
            this.internalNameEnum.MouseHover += new System.EventHandler(this.textbox_MouseHover);
            // 
            // organizerName
            // 
            this.organizerName.Location = new System.Drawing.Point(3, 31);
            this.organizerName.Name = "organizerName";
            this.organizerName.Size = new System.Drawing.Size(197, 20);
            this.organizerName.TabIndex = 1;
            this.organizerName.Text = "OrganizerName";
            this.organizerName.MouseHover += new System.EventHandler(this.textbox_MouseHover);
            // 
            // valueDisplayName
            // 
            this.valueDisplayName.Location = new System.Drawing.Point(229, 3);
            this.valueDisplayName.Name = "valueDisplayName";
            this.valueDisplayName.Size = new System.Drawing.Size(198, 20);
            this.valueDisplayName.TabIndex = 3;
            this.valueDisplayName.Text = "EnumDisplay";
            this.valueDisplayName.MouseHover += new System.EventHandler(this.textbox_MouseHover);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.containerDomain, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.domainContainerLbl, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(462, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(576, 56);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // containerDomain
            // 
            this.containerDomain.Location = new System.Drawing.Point(291, 3);
            this.containerDomain.Name = "containerDomain";
            this.containerDomain.Size = new System.Drawing.Size(198, 20);
            this.containerDomain.TabIndex = 2;
            this.containerDomain.MouseHover += new System.EventHandler(this.textbox_MouseHover);
            // 
            // domainContainerLbl
            // 
            this.domainContainerLbl.AutoSize = true;
            this.domainContainerLbl.Location = new System.Drawing.Point(3, 0);
            this.domainContainerLbl.Name = "domainContainerLbl";
            this.domainContainerLbl.Size = new System.Drawing.Size(282, 26);
            this.domainContainerLbl.TabIndex = 3;
            this.domainContainerLbl.Text = "Fill the container domain only if the enumeration should be created at org level";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel6.Controls.Add(this.resetBtn, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.saveBtn, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 547);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1041, 29);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(3, 3);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 579);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Create Enumeration";
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.enumGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ComboBox localeCombo;

        private System.Windows.Forms.DataGridView enumGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn InternalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasterText;

        private System.Windows.Forms.CheckBox valueSort;
        private System.Windows.Forms.TextBox internalNameEnum;
        private System.Windows.Forms.TextBox organizerName;
        private System.Windows.Forms.TextBox containerDomain;
        private System.Windows.Forms.TextBox valueDisplayName;

        private System.Windows.Forms.Button removeLocaleBtn;
        private System.Windows.Forms.Button addLocaleBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button resetBtn;

        private System.Windows.Forms.ToolTip textBoxTooltip;

        private System.Windows.Forms.ErrorProvider errorProvider;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label domainContainerLbl;
    }
}

