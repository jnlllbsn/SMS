namespace SMS.App
{
    partial class ProgramView
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
            textBoxProgramName = new TextBox();
            textBoxDescription = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxID = new TextBox();
            buttonCreate = new Button();
            buttonRead = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            dataGridViewProgramList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProgramList).BeginInit();
            SuspendLayout();
            // 
            // textBoxProgramName
            // 
            textBoxProgramName.Location = new Point(58, 150);
            textBoxProgramName.Name = "textBoxProgramName";
            textBoxProgramName.Size = new Size(156, 23);
            textBoxProgramName.TabIndex = 0;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(58, 205);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(156, 23);
            textBoxDescription.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 132);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 2;
            label1.Text = "Program Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 187);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 78);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 5;
            label3.Text = "I.D.";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(58, 96);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(156, 23);
            textBoxID.TabIndex = 4;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(58, 252);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(156, 26);
            buttonCreate.TabIndex = 6;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonRead
            // 
            buttonRead.Location = new Point(58, 284);
            buttonRead.Name = "buttonRead";
            buttonRead.Size = new Size(156, 26);
            buttonRead.TabIndex = 7;
            buttonRead.Text = "Read";
            buttonRead.UseVisualStyleBackColor = true;
            buttonRead.Click += buttonRead_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(58, 316);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(156, 26);
            buttonUpdate.TabIndex = 8;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(58, 348);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(156, 26);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // dataGridViewProgramList
            // 
            dataGridViewProgramList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProgramList.Location = new Point(284, 75);
            dataGridViewProgramList.Name = "dataGridViewProgramList";
            dataGridViewProgramList.Size = new Size(426, 299);
            dataGridViewProgramList.TabIndex = 10;
            // 
            // ProgramView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 434);
            Controls.Add(dataGridViewProgramList);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonRead);
            Controls.Add(buttonCreate);
            Controls.Add(label3);
            Controls.Add(textBoxID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxProgramName);
            Name = "ProgramView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Program Management";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProgramList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxProgramName;
        private TextBox textBoxDescription;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxID;
        private Button buttonCreate;
        private Button buttonRead;
        private Button buttonUpdate;
        private Button buttonDelete;
        private DataGridView dataGridViewProgramList;
    }
}