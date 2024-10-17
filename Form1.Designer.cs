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
            txtPONo = new TextBox();
            btnTest = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(585, 14);
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
            txtOutput.ScrollBars = ScrollBars.Both;
            txtOutput.Size = new Size(530, 272);
            txtOutput.TabIndex = 1;
            // 
            // txtPONo
            // 
            txtPONo.Location = new Point(36, 14);
            txtPONo.Name = "txtPONo";
            txtPONo.PlaceholderText = "PO Number";
            txtPONo.Size = new Size(530, 31);
            txtPONo.TabIndex = 3;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(585, 63);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(112, 34);
            btnTest.TabIndex = 0;
            btnTest.Text = "Test";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 347);
            Controls.Add(txtPONo);
            Controls.Add(txtOutput);
            Controls.Add(btnTest);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtOutput;
        private TextBox txtPONo;
        private Button btnTest;
    }
}
