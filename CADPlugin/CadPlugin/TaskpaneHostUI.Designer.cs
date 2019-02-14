namespace CadPlugin
{
    partial class TaskpaneHostUi
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PluginTitleLabel = new System.Windows.Forms.Label();
            this.tableLayoutBottom = new System.Windows.Forms.TableLayoutPanel();
            this.TableTopWidthNumeric = new System.Windows.Forms.NumericUpDown();
            this.TableTopWidthLabel = new System.Windows.Forms.Label();
            this.TableTopHeightLabel = new System.Windows.Forms.Label();
            this.TableTopLengthLabel = new System.Windows.Forms.Label();
            this.TableTopLabel = new System.Windows.Forms.Label();
            this.TableTopLengthNumeric = new System.Windows.Forms.NumericUpDown();
            this.TableTopHeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutTop = new System.Windows.Forms.TableLayoutPanel();
            this.BuildButton = new System.Windows.Forms.Button();
            this.LegHeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.LegEdgeOffsetNumeric = new System.Windows.Forms.NumericUpDown();
            this.TableLegLabel = new System.Windows.Forms.Label();
            this.LegHeightLabel = new System.Windows.Forms.Label();
            this.LegRadiusLabel = new System.Windows.Forms.Label();
            this.LegEdgeOffsetLabel = new System.Windows.Forms.Label();
            this.LegRadiusNumeric = new System.Windows.Forms.NumericUpDown();
            this.StrutsCheckBox = new System.Windows.Forms.CheckBox();
            this.StrutsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.StrutsHeightLabel = new System.Windows.Forms.Label();
            this.StrutsThicknessLabel = new System.Windows.Forms.Label();
            this.StrutThicknessText = new System.Windows.Forms.TextBox();
            this.StrutHeightText = new System.Windows.Forms.TextBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableTopWidthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableTopLengthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableTopHeightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tableLayoutTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LegHeightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegEdgeOffsetNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegRadiusNumeric)).BeginInit();
            this.StrutsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // PluginTitleLabel
            // 
            this.PluginTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PluginTitleLabel.AutoSize = true;
            this.PluginTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PluginTitleLabel.Location = new System.Drawing.Point(31, 3);
            this.PluginTitleLabel.Name = "PluginTitleLabel";
            this.PluginTitleLabel.Size = new System.Drawing.Size(132, 26);
            this.PluginTitleLabel.TabIndex = 1;
            this.PluginTitleLabel.Text = "Table Plugin";
            this.PluginTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutBottom
            // 
            this.tableLayoutBottom.AutoSize = true;
            this.tableLayoutBottom.ColumnCount = 1;
            this.tableLayoutBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutBottom.Controls.Add(this.TableTopWidthNumeric, 0, 7);
            this.tableLayoutBottom.Controls.Add(this.PluginTitleLabel, 0, 0);
            this.tableLayoutBottom.Controls.Add(this.TableTopWidthLabel, 0, 6);
            this.tableLayoutBottom.Controls.Add(this.TableTopHeightLabel, 0, 4);
            this.tableLayoutBottom.Controls.Add(this.TableTopLengthLabel, 0, 2);
            this.tableLayoutBottom.Controls.Add(this.TableTopLabel, 0, 1);
            this.tableLayoutBottom.Controls.Add(this.TableTopLengthNumeric, 0, 3);
            this.tableLayoutBottom.Controls.Add(this.TableTopHeightNumeric, 0, 5);
            this.tableLayoutBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutBottom.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutBottom.MinimumSize = new System.Drawing.Size(138, 200);
            this.tableLayoutBottom.Name = "tableLayoutBottom";
            this.tableLayoutBottom.RowCount = 8;
            this.tableLayoutBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutBottom.Size = new System.Drawing.Size(195, 210);
            this.tableLayoutBottom.TabIndex = 3;
            // 
            // TableTopWidthNumeric
            // 
            this.TableTopWidthNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableTopWidthNumeric.Location = new System.Drawing.Point(3, 172);
            this.TableTopWidthNumeric.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.TableTopWidthNumeric.Minimum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.TableTopWidthNumeric.Name = "TableTopWidthNumeric";
            this.TableTopWidthNumeric.Size = new System.Drawing.Size(189, 20);
            this.TableTopWidthNumeric.TabIndex = 17;
            this.TableTopWidthNumeric.Value = new decimal(new int[] {
            700,
            0,
            0,
            0});
            // 
            // TableTopWidthLabel
            // 
            this.TableTopWidthLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableTopWidthLabel.AutoSize = true;
            this.TableTopWidthLabel.Location = new System.Drawing.Point(43, 153);
            this.TableTopWidthLabel.Name = "TableTopWidthLabel";
            this.TableTopWidthLabel.Size = new System.Drawing.Size(108, 13);
            this.TableTopWidthLabel.TabIndex = 6;
            this.TableTopWidthLabel.Text = "Width (700-1200 mm)";
            // 
            // TableTopHeightLabel
            // 
            this.TableTopHeightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableTopHeightLabel.AutoSize = true;
            this.TableTopHeightLabel.Location = new System.Drawing.Point(48, 108);
            this.TableTopHeightLabel.Name = "TableTopHeightLabel";
            this.TableTopHeightLabel.Size = new System.Drawing.Size(99, 13);
            this.TableTopHeightLabel.TabIndex = 5;
            this.TableTopHeightLabel.Text = "Height (25-100 mm)";
            // 
            // TableTopLengthLabel
            // 
            this.TableTopLengthLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableTopLengthLabel.AutoSize = true;
            this.TableTopLengthLabel.Location = new System.Drawing.Point(41, 63);
            this.TableTopLengthLabel.Name = "TableTopLengthLabel";
            this.TableTopLengthLabel.Size = new System.Drawing.Size(113, 13);
            this.TableTopLengthLabel.TabIndex = 4;
            this.TableTopLengthLabel.Text = "Length (700-3200 mm)";
            // 
            // TableTopLabel
            // 
            this.TableTopLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableTopLabel.AutoSize = true;
            this.TableTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.TableTopLabel.Location = new System.Drawing.Point(15, 37);
            this.TableTopLabel.Name = "TableTopLabel";
            this.TableTopLabel.Size = new System.Drawing.Size(164, 17);
            this.TableTopLabel.TabIndex = 11;
            this.TableTopLabel.Text = "Table top parameters";
            this.TableTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableTopLengthNumeric
            // 
            this.TableTopLengthNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableTopLengthNumeric.Location = new System.Drawing.Point(3, 82);
            this.TableTopLengthNumeric.Maximum = new decimal(new int[] {
            3200,
            0,
            0,
            0});
            this.TableTopLengthNumeric.Minimum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.TableTopLengthNumeric.Name = "TableTopLengthNumeric";
            this.TableTopLengthNumeric.Size = new System.Drawing.Size(189, 20);
            this.TableTopLengthNumeric.TabIndex = 18;
            this.TableTopLengthNumeric.Value = new decimal(new int[] {
            700,
            0,
            0,
            0});
            // 
            // TableTopHeightNumeric
            // 
            this.TableTopHeightNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableTopHeightNumeric.Location = new System.Drawing.Point(3, 127);
            this.TableTopHeightNumeric.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.TableTopHeightNumeric.Name = "TableTopHeightNumeric";
            this.TableTopHeightNumeric.Size = new System.Drawing.Size(189, 20);
            this.TableTopHeightNumeric.TabIndex = 19;
            this.TableTopHeightNumeric.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.MinimumSize = new System.Drawing.Size(138, 200);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tableLayoutBottom);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tableLayoutTop);
            this.splitContainer.Size = new System.Drawing.Size(195, 485);
            this.splitContainer.SplitterDistance = 210;
            this.splitContainer.TabIndex = 4;
            // 
            // tableLayoutTop
            // 
            this.tableLayoutTop.AutoSize = true;
            this.tableLayoutTop.ColumnCount = 1;
            this.tableLayoutTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutTop.Controls.Add(this.BuildButton, 0, 9);
            this.tableLayoutTop.Controls.Add(this.LegHeightNumeric, 0, 2);
            this.tableLayoutTop.Controls.Add(this.LegEdgeOffsetNumeric, 0, 6);
            this.tableLayoutTop.Controls.Add(this.TableLegLabel, 0, 0);
            this.tableLayoutTop.Controls.Add(this.LegHeightLabel, 0, 1);
            this.tableLayoutTop.Controls.Add(this.LegRadiusLabel, 0, 3);
            this.tableLayoutTop.Controls.Add(this.LegEdgeOffsetLabel, 0, 5);
            this.tableLayoutTop.Controls.Add(this.LegRadiusNumeric, 0, 4);
            this.tableLayoutTop.Controls.Add(this.StrutsCheckBox, 0, 7);
            this.tableLayoutTop.Controls.Add(this.StrutsPanel, 0, 8);
            this.tableLayoutTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutTop.Name = "tableLayoutTop";
            this.tableLayoutTop.RowCount = 10;
            this.tableLayoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutTop.Size = new System.Drawing.Size(195, 271);
            this.tableLayoutTop.TabIndex = 4;
            // 
            // BuildButton
            // 
            this.BuildButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BuildButton.Location = new System.Drawing.Point(3, 246);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(189, 22);
            this.BuildButton.TabIndex = 17;
            this.BuildButton.Text = "Build";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // LegHeightNumeric
            // 
            this.LegHeightNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LegHeightNumeric.Location = new System.Drawing.Point(3, 50);
            this.LegHeightNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LegHeightNumeric.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.LegHeightNumeric.Name = "LegHeightNumeric";
            this.LegHeightNumeric.Size = new System.Drawing.Size(189, 20);
            this.LegHeightNumeric.TabIndex = 16;
            this.LegHeightNumeric.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // LegEdgeOffsetNumeric
            // 
            this.LegEdgeOffsetNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LegEdgeOffsetNumeric.Location = new System.Drawing.Point(3, 140);
            this.LegEdgeOffsetNumeric.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.LegEdgeOffsetNumeric.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.LegEdgeOffsetNumeric.Name = "LegEdgeOffsetNumeric";
            this.LegEdgeOffsetNumeric.Size = new System.Drawing.Size(189, 20);
            this.LegEdgeOffsetNumeric.TabIndex = 15;
            this.LegEdgeOffsetNumeric.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // TableLegLabel
            // 
            this.TableLegLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableLegLabel.AutoSize = true;
            this.TableLegLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.TableLegLabel.Location = new System.Drawing.Point(16, 5);
            this.TableLegLabel.Name = "TableLegLabel";
            this.TableLegLabel.Size = new System.Drawing.Size(163, 17);
            this.TableLegLabel.TabIndex = 11;
            this.TableLegLabel.Text = "Table leg parameters";
            this.TableLegLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LegHeightLabel
            // 
            this.LegHeightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LegHeightLabel.AutoSize = true;
            this.LegHeightLabel.Location = new System.Drawing.Point(42, 31);
            this.LegHeightLabel.Name = "LegHeightLabel";
            this.LegHeightLabel.Size = new System.Drawing.Size(111, 13);
            this.LegHeightLabel.TabIndex = 4;
            this.LegHeightLabel.Text = "Height (200-1000 mm)";
            // 
            // LegRadiusLabel
            // 
            this.LegRadiusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LegRadiusLabel.AutoSize = true;
            this.LegRadiusLabel.Location = new System.Drawing.Point(47, 76);
            this.LegRadiusLabel.Name = "LegRadiusLabel";
            this.LegRadiusLabel.Size = new System.Drawing.Size(101, 13);
            this.LegRadiusLabel.TabIndex = 5;
            this.LegRadiusLabel.Text = "Radius (50-100 mm)";
            // 
            // LegEdgeOffsetLabel
            // 
            this.LegEdgeOffsetLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LegEdgeOffsetLabel.AutoSize = true;
            this.LegEdgeOffsetLabel.Location = new System.Drawing.Point(34, 121);
            this.LegEdgeOffsetLabel.Name = "LegEdgeOffsetLabel";
            this.LegEdgeOffsetLabel.Size = new System.Drawing.Size(127, 13);
            this.LegEdgeOffsetLabel.TabIndex = 6;
            this.LegEdgeOffsetLabel.Text = "Edge Offset (20-200 mm) ";
            // 
            // LegRadiusNumeric
            // 
            this.LegRadiusNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LegRadiusNumeric.Location = new System.Drawing.Point(3, 95);
            this.LegRadiusNumeric.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.LegRadiusNumeric.Name = "LegRadiusNumeric";
            this.LegRadiusNumeric.Size = new System.Drawing.Size(189, 20);
            this.LegRadiusNumeric.TabIndex = 14;
            this.LegRadiusNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // StrutsCheckBox
            // 
            this.StrutsCheckBox.AutoSize = true;
            this.StrutsCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StrutsCheckBox.Location = new System.Drawing.Point(3, 166);
            this.StrutsCheckBox.Name = "StrutsCheckBox";
            this.StrutsCheckBox.Size = new System.Drawing.Size(189, 18);
            this.StrutsCheckBox.TabIndex = 18;
            this.StrutsCheckBox.Text = "Build With Struts";
            this.StrutsCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StrutsCheckBox.UseVisualStyleBackColor = true;
            this.StrutsCheckBox.CheckedChanged += new System.EventHandler(this.StrutsCheckBox_CheckedChanged);
            // 
            // StrutsPanel
            // 
            this.StrutsPanel.AutoSize = true;
            this.StrutsPanel.ColumnCount = 2;
            this.StrutsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StrutsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StrutsPanel.Controls.Add(this.StrutsHeightLabel, 1, 0);
            this.StrutsPanel.Controls.Add(this.StrutsThicknessLabel, 0, 0);
            this.StrutsPanel.Controls.Add(this.StrutThicknessText, 0, 1);
            this.StrutsPanel.Controls.Add(this.StrutHeightText, 1, 1);
            this.StrutsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StrutsPanel.Location = new System.Drawing.Point(3, 190);
            this.StrutsPanel.Name = "StrutsPanel";
            this.StrutsPanel.RowCount = 2;
            this.StrutsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.StrutsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.StrutsPanel.Size = new System.Drawing.Size(189, 50);
            this.StrutsPanel.TabIndex = 19;
            this.StrutsPanel.Visible = false;
            // 
            // StrutsHeightLabel
            // 
            this.StrutsHeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.StrutsHeightLabel.AutoSize = true;
            this.StrutsHeightLabel.Location = new System.Drawing.Point(107, 7);
            this.StrutsHeightLabel.Name = "StrutsHeightLabel";
            this.StrutsHeightLabel.Size = new System.Drawing.Size(68, 13);
            this.StrutsHeightLabel.TabIndex = 7;
            this.StrutsHeightLabel.Text = "Struts Height";
            // 
            // StrutsThicknessLabel
            // 
            this.StrutsThicknessLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.StrutsThicknessLabel.AutoSize = true;
            this.StrutsThicknessLabel.Location = new System.Drawing.Point(4, 7);
            this.StrutsThicknessLabel.Name = "StrutsThicknessLabel";
            this.StrutsThicknessLabel.Size = new System.Drawing.Size(86, 13);
            this.StrutsThicknessLabel.TabIndex = 6;
            this.StrutsThicknessLabel.Text = "Struts Thickness";
            // 
            // StrutThicknessText
            // 
            this.StrutThicknessText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StrutThicknessText.Location = new System.Drawing.Point(3, 25);
            this.StrutThicknessText.Name = "StrutThicknessText";
            this.StrutThicknessText.Size = new System.Drawing.Size(88, 20);
            this.StrutThicknessText.TabIndex = 8;
            this.StrutThicknessText.Validating += new System.ComponentModel.CancelEventHandler(this.StrutsTexts_Validating);
            this.StrutThicknessText.Validated += new System.EventHandler(this.StrutsTexts_Validated);
            // 
            // StrutHeightText
            // 
            this.StrutHeightText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StrutHeightText.Location = new System.Drawing.Point(97, 25);
            this.StrutHeightText.Name = "StrutHeightText";
            this.StrutHeightText.Size = new System.Drawing.Size(89, 20);
            this.StrutHeightText.TabIndex = 9;
            this.StrutHeightText.Validating += new System.ComponentModel.CancelEventHandler(this.StrutsTexts_Validating);
            this.StrutHeightText.Validated += new System.EventHandler(this.StrutsTexts_Validated);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // TaskpaneHostUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(195, 485);
            this.Name = "TaskpaneHostUi";
            this.Size = new System.Drawing.Size(195, 485);
            this.tableLayoutBottom.ResumeLayout(false);
            this.tableLayoutBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableTopWidthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableTopLengthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableTopHeightNumeric)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tableLayoutTop.ResumeLayout(false);
            this.tableLayoutTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LegHeightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegEdgeOffsetNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegRadiusNumeric)).EndInit();
            this.StrutsPanel.ResumeLayout(false);
            this.StrutsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label PluginTitleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutBottom;
        private System.Windows.Forms.Label TableTopWidthLabel;
        private System.Windows.Forms.Label TableTopHeightLabel;
        private System.Windows.Forms.Label TableTopLengthLabel;
        private System.Windows.Forms.Label TableTopLabel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutTop;
        private System.Windows.Forms.Label TableLegLabel;
        private System.Windows.Forms.Label LegHeightLabel;
        private System.Windows.Forms.Label LegRadiusLabel;
        private System.Windows.Forms.Label LegEdgeOffsetLabel;
        private System.Windows.Forms.NumericUpDown LegRadiusNumeric;
        private System.Windows.Forms.NumericUpDown TableTopWidthNumeric;
        private System.Windows.Forms.NumericUpDown TableTopLengthNumeric;
        private System.Windows.Forms.NumericUpDown TableTopHeightNumeric;
        private System.Windows.Forms.NumericUpDown LegHeightNumeric;
        private System.Windows.Forms.NumericUpDown LegEdgeOffsetNumeric;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.CheckBox StrutsCheckBox;
        private System.Windows.Forms.TableLayoutPanel StrutsPanel;
        private System.Windows.Forms.Label StrutsHeightLabel;
        private System.Windows.Forms.Label StrutsThicknessLabel;
        private System.Windows.Forms.TextBox StrutThicknessText;
        private System.Windows.Forms.TextBox StrutHeightText;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}
