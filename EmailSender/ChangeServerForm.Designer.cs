namespace EmailSender
{
    partial class ChangeServerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeServerForm));
            defaultPresetsCBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            serverIpTBox = new TextBox();
            label3 = new Label();
            serverPortTBox = new TextBox();
            useCustomCButton = new CheckBox();
            changeB = new Button();
            closeB = new Button();
            SuspendLayout();
            // 
            // defaultPresetsCBox
            // 
            defaultPresetsCBox.DisplayMember = "0";
            defaultPresetsCBox.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            defaultPresetsCBox.FormattingEnabled = true;
            defaultPresetsCBox.Items.AddRange(new object[] { "Gmail", "Outlook", "Abv.bg" });
            defaultPresetsCBox.Location = new Point(184, 33);
            defaultPresetsCBox.Name = "defaultPresetsCBox";
            defaultPresetsCBox.Size = new Size(156, 27);
            defaultPresetsCBox.TabIndex = 0;
            defaultPresetsCBox.SelectedIndexChanged += defaultPresetsCBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(50, 36);
            label1.Name = "label1";
            label1.Size = new Size(120, 19);
            label1.TabIndex = 1;
            label1.Text = "Default presets:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(50, 132);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 2;
            label2.Text = "Server ip:";
            // 
            // serverIpTBox
            // 
            serverIpTBox.Enabled = false;
            serverIpTBox.Location = new Point(142, 132);
            serverIpTBox.Name = "serverIpTBox";
            serverIpTBox.Size = new Size(474, 23);
            serverIpTBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(35, 176);
            label3.Name = "label3";
            label3.Size = new Size(89, 19);
            label3.TabIndex = 4;
            label3.Text = "Server port:";
            // 
            // serverPortTBox
            // 
            serverPortTBox.Enabled = false;
            serverPortTBox.Location = new Point(142, 176);
            serverPortTBox.Name = "serverPortTBox";
            serverPortTBox.Size = new Size(198, 23);
            serverPortTBox.TabIndex = 3;
            // 
            // useCustomCButton
            // 
            useCustomCButton.AutoSize = true;
            useCustomCButton.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            useCustomCButton.Location = new Point(388, 35);
            useCustomCButton.Name = "useCustomCButton";
            useCustomCButton.Size = new Size(191, 23);
            useCustomCButton.TabIndex = 1;
            useCustomCButton.Text = "Use custom ip and port";
            useCustomCButton.UseVisualStyleBackColor = true;
            useCustomCButton.CheckedChanged += useCustomCButton_CheckedChanged;
            // 
            // changeB
            // 
            changeB.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            changeB.Location = new Point(377, 292);
            changeB.Name = "changeB";
            changeB.Size = new Size(104, 36);
            changeB.TabIndex = 4;
            changeB.Text = "Change";
            changeB.UseVisualStyleBackColor = true;
            changeB.Click += changeB_Click;
            // 
            // closeB
            // 
            closeB.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            closeB.Location = new Point(512, 292);
            closeB.Name = "closeB";
            closeB.Size = new Size(104, 36);
            closeB.TabIndex = 5;
            closeB.Text = "Close";
            closeB.UseVisualStyleBackColor = true;
            closeB.Click += closeB_Click;
            // 
            // ChangeServerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 361);
            Controls.Add(closeB);
            Controls.Add(changeB);
            Controls.Add(useCustomCButton);
            Controls.Add(serverPortTBox);
            Controls.Add(label3);
            Controls.Add(serverIpTBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(defaultPresetsCBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ChangeServerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Change Server";
            Load += ChangeServerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox defaultPresetsCBox;
        private Label label1;
        private Label label2;
        private TextBox serverIpTBox;
        private Label label3;
        private TextBox serverPortTBox;
        private CheckBox useCustomCButton;
        private Button changeB;
        private Button closeB;
    }
}