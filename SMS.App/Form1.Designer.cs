namespace SMS.App
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
            label1 = new Label();
            textBoxID = new TextBox();
            label2 = new Label();
            textBoxName = new TextBox();
            label3 = new Label();
            textBoxEmail = new TextBox();
            buttonShow = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(277, 142);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(312, 139);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(204, 23);
            textBoxID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 178);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(312, 175);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(204, 23);
            textBoxName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 213);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(312, 210);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(204, 23);
            textBoxEmail.TabIndex = 5;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(287, 58);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(250, 42);
            buttonShow.TabIndex = 6;
            buttonShow.Text = "Show Information";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // Form1
            // 
            AcceptButton = buttonShow;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonShow);
            Controls.Add(textBoxEmail);
            Controls.Add(label3);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(textBoxID);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxID;
        private Label label2;
        private TextBox textBoxName;
        private Label label3;
        private TextBox textBoxEmail;
        private Button buttonShow;
    }
}
