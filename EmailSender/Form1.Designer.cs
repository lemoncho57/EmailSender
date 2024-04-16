namespace EmailSender
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            fromTBox = new TextBox();
            label2 = new Label();
            toTBox = new TextBox();
            label3 = new Label();
            subjectTbox = new TextBox();
            label4 = new Label();
            bodyTBox = new TextBox();
            sendB = new Button();
            changeCredentialsB = new Button();
            label5 = new Label();
            toEmailTBox = new TextBox();
            changeServerB = new Button();
            clearB = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(50, 54);
            label1.Name = "label1";
            label1.Size = new Size(88, 19);
            label1.TabIndex = 0;
            label1.Text = "From(You):";
            // 
            // fromTBox
            // 
            fromTBox.Location = new Point(159, 54);
            fromTBox.Name = "fromTBox";
            fromTBox.Size = new Size(406, 23);
            fromTBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(107, 98);
            label2.Name = "label2";
            label2.Size = new Size(31, 19);
            label2.TabIndex = 2;
            label2.Text = "To:";
            // 
            // toTBox
            // 
            toTBox.Location = new Point(159, 98);
            toTBox.Name = "toTBox";
            toTBox.Size = new Size(406, 23);
            toTBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(72, 178);
            label3.Name = "label3";
            label3.Size = new Size(66, 19);
            label3.TabIndex = 4;
            label3.Text = "Subject:";
            // 
            // subjectTbox
            // 
            subjectTbox.Location = new Point(159, 178);
            subjectTbox.Name = "subjectTbox";
            subjectTbox.Size = new Size(406, 23);
            subjectTbox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(15, 221);
            label4.Name = "label4";
            label4.Size = new Size(123, 19);
            label4.TabIndex = 6;
            label4.Text = "Message(body):";
            // 
            // bodyTBox
            // 
            bodyTBox.Location = new Point(159, 211);
            bodyTBox.Multiline = true;
            bodyTBox.Name = "bodyTBox";
            bodyTBox.Size = new Size(406, 109);
            bodyTBox.TabIndex = 5;
            // 
            // sendB
            // 
            sendB.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sendB.Location = new Point(462, 373);
            sendB.Name = "sendB";
            sendB.Size = new Size(103, 30);
            sendB.TabIndex = 6;
            sendB.Text = "Send";
            sendB.UseVisualStyleBackColor = true;
            sendB.Click += sendB_Click;
            // 
            // changeCredentialsB
            // 
            changeCredentialsB.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            changeCredentialsB.Location = new Point(35, 373);
            changeCredentialsB.Name = "changeCredentialsB";
            changeCredentialsB.Size = new Size(152, 30);
            changeCredentialsB.TabIndex = 7;
            changeCredentialsB.Text = "Change credentials";
            changeCredentialsB.UseVisualStyleBackColor = true;
            changeCredentialsB.Click += changeCredentialsB_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(57, 136);
            label5.Name = "label5";
            label5.Size = new Size(81, 19);
            label5.TabIndex = 10;
            label5.Text = "To(email):";
            // 
            // toEmailTBox
            // 
            toEmailTBox.Location = new Point(159, 132);
            toEmailTBox.Name = "toEmailTBox";
            toEmailTBox.Size = new Size(406, 23);
            toEmailTBox.TabIndex = 3;
            // 
            // changeServerB
            // 
            changeServerB.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            changeServerB.Location = new Point(193, 373);
            changeServerB.Name = "changeServerB";
            changeServerB.Size = new Size(190, 30);
            changeServerB.TabIndex = 11;
            changeServerB.Text = "Change provider(Server)";
            changeServerB.UseVisualStyleBackColor = true;
            changeServerB.Click += changeServerB_Click;
            // 
            // clearB
            // 
            clearB.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clearB.Location = new Point(585, 373);
            clearB.Name = "clearB";
            clearB.Size = new Size(103, 30);
            clearB.TabIndex = 12;
            clearB.Text = "Clear";
            clearB.UseVisualStyleBackColor = true;
            clearB.Click += clearB_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(585, 98);
            label6.Name = "label6";
            label6.Size = new Size(73, 19);
            label6.TabIndex = 13;
            label6.Text = "*required";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(585, 58);
            label7.Name = "label7";
            label7.Size = new Size(73, 19);
            label7.TabIndex = 14;
            label7.Text = "*required";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(585, 136);
            label8.Name = "label8";
            label8.Size = new Size(73, 19);
            label8.TabIndex = 15;
            label8.Text = "*required";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 451);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(clearB);
            Controls.Add(changeServerB);
            Controls.Add(toEmailTBox);
            Controls.Add(label5);
            Controls.Add(changeCredentialsB);
            Controls.Add(sendB);
            Controls.Add(bodyTBox);
            Controls.Add(label4);
            Controls.Add(subjectTbox);
            Controls.Add(label3);
            Controls.Add(toTBox);
            Controls.Add(label2);
            Controls.Add(fromTBox);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Email sender | Lemoncho";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox fromTBox;
        private Label label2;
        private TextBox toTBox;
        private Label label3;
        private TextBox subjectTbox;
        private Label label4;
        private TextBox bodyTBox;
        private Button sendB;
        private Button changeCredentialsB;
        private Label label5;
        private TextBox toEmailTBox;
        private Button changeServerB;
        private Button clearB;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
