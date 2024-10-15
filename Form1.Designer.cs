namespace KeyboardApp
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
            button1 = new Button();
            txtOutput = new TextBox();
            btnGetData = new Button();
            txtPONo = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(402, 11);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(36, 63);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(351, 177);
            txtOutput.TabIndex = 1;
            // 
            // btnGetData
            // 
            btnGetData.Location = new Point(402, 63);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(112, 34);
            btnGetData.TabIndex = 2;
            btnGetData.Text = "Get Data";
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += btnGetData_Click;
            // 
            // txtPONo
            // 
            txtPONo.Location = new Point(36, 14);
            txtPONo.Name = "txtPONo";
            txtPONo.PlaceholderText = "PO Number";
            txtPONo.Size = new Size(351, 31);
            txtPONo.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 262);
            Controls.Add(txtPONo);
            Controls.Add(btnGetData);
            Controls.Add(txtOutput);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtOutput;
        private Button btnGetData;
        private TextBox txtPONo;
    }
}
