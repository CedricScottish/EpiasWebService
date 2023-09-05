namespace EpiasWebService
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
            dgDataWs = new DataGridView();
            btnGetData = new Button();
            dtStartDate = new DateTimePicker();
            dtEndDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dgDataWs2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgDataWs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgDataWs2).BeginInit();
            SuspendLayout();
            // 
            // dgDataWs
            // 
            dgDataWs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDataWs.Location = new Point(12, 12);
            dgDataWs.Name = "dgDataWs";
            dgDataWs.RowTemplate.Height = 25;
            dgDataWs.Size = new Size(463, 344);
            dgDataWs.TabIndex = 0;
            // 
            // btnGetData
            // 
            btnGetData.Location = new Point(697, 375);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(75, 23);
            btnGetData.TabIndex = 1;
            btnGetData.Text = "Get Data";
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += btnGetData_Click;
            // 
            // dtStartDate
            // 
            dtStartDate.Location = new Point(91, 375);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(200, 23);
            dtStartDate.TabIndex = 2;
            dtStartDate.Value = new DateTime(2023, 6, 1, 0, 0, 0, 0);
            // 
            // dtEndDate
            // 
            dtEndDate.Location = new Point(435, 375);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.Size = new Size(200, 23);
            dtEndDate.TabIndex = 3;
            dtEndDate.Value = new DateTime(2023, 6, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 379);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 4;
            label1.Text = "Start Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 379);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 5;
            label2.Text = "End Date";
            // 
            // dgDataWs2
            // 
            dgDataWs2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDataWs2.Location = new Point(481, 12);
            dgDataWs2.Name = "dgDataWs2";
            dgDataWs2.RowTemplate.Height = 25;
            dgDataWs2.Size = new Size(458, 344);
            dgDataWs2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 450);
            Controls.Add(dgDataWs2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtEndDate);
            Controls.Add(dtStartDate);
            Controls.Add(btnGetData);
            Controls.Add(dgDataWs);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgDataWs).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgDataWs2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgDataWs;
        private Button btnGetData;
        private DateTimePicker dtStartDate;
        private DateTimePicker dtEndDate;
        private Label label1;
        private Label label2;
        private DataGridView dgDataWs2;
    }
}