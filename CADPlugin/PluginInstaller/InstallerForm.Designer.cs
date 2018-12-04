namespace PluginInstaller
{
    partial class InstallerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.InstallButton = new System.Windows.Forms.Button();
            this.UninstallButton = new System.Windows.Forms.Button();
            this.DllPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DllBrowseButton = new System.Windows.Forms.Button();
            this.RegAsmBrowseButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RegAsmPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InstallButton
            // 
            this.InstallButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InstallButton.Location = new System.Drawing.Point(12, 91);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Size = new System.Drawing.Size(75, 23);
            this.InstallButton.TabIndex = 0;
            this.InstallButton.Text = "Install";
            this.InstallButton.UseVisualStyleBackColor = true;
            this.InstallButton.Click += new System.EventHandler(this.InstallButton_Click);
            // 
            // UninstallButton
            // 
            this.UninstallButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UninstallButton.Location = new System.Drawing.Point(309, 91);
            this.UninstallButton.Name = "UninstallButton";
            this.UninstallButton.Size = new System.Drawing.Size(75, 23);
            this.UninstallButton.TabIndex = 1;
            this.UninstallButton.Text = "Uninstall";
            this.UninstallButton.UseVisualStyleBackColor = true;
            this.UninstallButton.Click += new System.EventHandler(this.UninstallButton_Click);
            // 
            // DllPath
            // 
            this.DllPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DllPath.Location = new System.Drawing.Point(12, 25);
            this.DllPath.Name = "DllPath";
            this.DllPath.Size = new System.Drawing.Size(291, 20);
            this.DllPath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Plugin path";
            // 
            // DllBrowseButton
            // 
            this.DllBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DllBrowseButton.Location = new System.Drawing.Point(309, 23);
            this.DllBrowseButton.Name = "DllBrowseButton";
            this.DllBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.DllBrowseButton.TabIndex = 4;
            this.DllBrowseButton.Text = "Browse...";
            this.DllBrowseButton.UseVisualStyleBackColor = true;
            this.DllBrowseButton.Click += new System.EventHandler(this.DllBrowseButton_Click);
            // 
            // RegAsmBrowseButton
            // 
            this.RegAsmBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RegAsmBrowseButton.Location = new System.Drawing.Point(309, 62);
            this.RegAsmBrowseButton.Name = "RegAsmBrowseButton";
            this.RegAsmBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.RegAsmBrowseButton.TabIndex = 7;
            this.RegAsmBrowseButton.Text = "Browse...";
            this.RegAsmBrowseButton.UseVisualStyleBackColor = true;
            this.RegAsmBrowseButton.Click += new System.EventHandler(this.RegAsmBrowseButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "RegAsm Path";
            // 
            // RegAsmPath
            // 
            this.RegAsmPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RegAsmPath.Location = new System.Drawing.Point(12, 64);
            this.RegAsmPath.Name = "RegAsmPath";
            this.RegAsmPath.Size = new System.Drawing.Size(291, 20);
            this.RegAsmPath.TabIndex = 5;
            // 
            // InstallerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 124);
            this.Controls.Add(this.RegAsmBrowseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegAsmPath);
            this.Controls.Add(this.DllBrowseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DllPath);
            this.Controls.Add(this.UninstallButton);
            this.Controls.Add(this.InstallButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InstallerForm";
            this.Text = "Plugin Installer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InstallButton;
        private System.Windows.Forms.Button UninstallButton;
        private System.Windows.Forms.TextBox DllPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DllBrowseButton;
        private System.Windows.Forms.Button RegAsmBrowseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RegAsmPath;
    }
}

