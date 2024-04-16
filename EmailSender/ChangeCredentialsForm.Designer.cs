namespace EmailSender
{
    partial class ChangeCredentialsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeCredentialsForm));
            label1 = new Label();
            emailTBox = new TextBox();
            label2 = new Label();
            appPasswordTBox = new TextBox();
            changeB = new Button();
            closeB = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(68, 55);
            label1.Name = "label1";
            label1.Size = new Size(88, 19);
            label1.TabIndex = 0;
            label1.Text = "Your email:";
            // 
            // emailTBox
            // 
            emailTBox.Location = new Point(167, 51);
            emailTBox.Name = "emailTBox";
            emailTBox.Size = new Size(408, 23);
            emailTBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(42, 108);
            label2.Name = "label2";
            label2.Size = new Size(114, 19);
            label2.TabIndex = 2;
            label2.Text = "App password:";
            // 
            // appPasswordTBox
            // 
            appPasswordTBox.Location = new Point(167, 108);
            appPasswordTBox.Name = "appPasswordTBox";
            appPasswordTBox.PasswordChar = '*';
            appPasswordTBox.Size = new Size(408, 23);
            appPasswordTBox.TabIndex = 3;
            // 
            // changeB
            // 
            changeB.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            changeB.Location = new Point(449, 348);
            changeB.Name = "changeB";
            changeB.Size = new Size(105, 33);
            changeB.TabIndex = 4;
            changeB.Text = "Change";
            changeB.UseVisualStyleBackColor = true;
            changeB.Click += changeB_Click;
            // 
            // closeB
            // 
            closeB.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            closeB.Location = new Point(577, 348);
            closeB.Name = "closeB";
            closeB.Size = new Size(105, 33);
            closeB.TabIndex = 5;
            closeB.Text = "Close";
            closeB.UseVisualStyleBackColor = true;
            closeB.Click += closeB_Click;
            // 
            // ChangeCredentialsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 419);
            Controls.Add(closeB);
            Controls.Add(changeB);
            Controls.Add(appPasswordTBox);
            Controls.Add(label2);
            Controls.Add(emailTBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ChangeCredentialsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Change Credentials";
            Load += ChangeCredentialsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox emailTBox;
        private Label label2;
        private TextBox appPasswordTBox;
        private Button changeB;
        private Button closeB;
    }
}