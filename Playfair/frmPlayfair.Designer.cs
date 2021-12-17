namespace Playfair
{
    partial class frmPlayfair
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
            this.lbKey = new System.Windows.Forms.Label();
            this.tb_Key = new System.Windows.Forms.TextBox();
            this.lbMatrix = new System.Windows.Forms.Label();
            this.tb_Matrix = new System.Windows.Forms.TextBox();
            this.lbInput = new System.Windows.Forms.Label();
            this.tb_Input = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblGirdiMetniSay = new System.Windows.Forms.Label();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lbOutput = new System.Windows.Forms.Label();
            this.tb_Output = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbHint1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbKey
            // 
            this.lbKey.AutoSize = true;
            this.lbKey.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbKey.Location = new System.Drawing.Point(12, 18);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(191, 17);
            this.lbKey.TabIndex = 0;
            this.lbKey.Text = "Nhập chuỗi khóa (KeyWord)";
            // 
            // tb_Key
            // 
            this.tb_Key.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tb_Key.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_Key.Location = new System.Drawing.Point(15, 44);
            this.tb_Key.Multiline = true;
            this.tb_Key.Name = "tb_Key";
            this.tb_Key.Size = new System.Drawing.Size(256, 24);
            this.tb_Key.TabIndex = 0;
            this.tb_Key.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // lbMatrix
            // 
            this.lbMatrix.AutoSize = true;
            this.lbMatrix.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatrix.Location = new System.Drawing.Point(462, 18);
            this.lbMatrix.Name = "lbMatrix";
            this.lbMatrix.Size = new System.Drawing.Size(91, 17);
            this.lbMatrix.TabIndex = 2;
            this.lbMatrix.Text = "Ma trận khóa";
            // 
            // tb_Matrix
            // 
            this.tb_Matrix.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tb_Matrix.Enabled = false;
            this.tb_Matrix.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Matrix.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_Matrix.Location = new System.Drawing.Point(327, 44);
            this.tb_Matrix.Multiline = true;
            this.tb_Matrix.Name = "tb_Matrix";
            this.tb_Matrix.Size = new System.Drawing.Size(385, 221);
            this.tb_Matrix.TabIndex = 3;
            this.tb_Matrix.TextChanged += new System.EventHandler(this.txtMatrix_TextChanged);
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbInput.Location = new System.Drawing.Point(6, 20);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(172, 17);
            this.lbInput.TabIndex = 4;
            this.lbInput.Text = "Nhập văn bản (message)";
            // 
            // tb_Input
            // 
            this.tb_Input.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tb_Input.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_Input.Location = new System.Drawing.Point(9, 44);
            this.tb_Input.MaxLength = 199;
            this.tb_Input.Multiline = true;
            this.tb_Input.Name = "tb_Input";
            this.tb_Input.Size = new System.Drawing.Size(286, 117);
            this.tb_Input.TabIndex = 1;
            this.tb_Input.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblGirdiMetniSay);
            this.groupBox2.Controls.Add(this.btnSwitch);
            this.groupBox2.Controls.Add(this.btnDecrypt);
            this.groupBox2.Controls.Add(this.btnEncrypt);
            this.groupBox2.Controls.Add(this.lbOutput);
            this.groupBox2.Controls.Add(this.tb_Output);
            this.groupBox2.Controls.Add(this.lbInput);
            this.groupBox2.Controls.Add(this.tb_Input);
            this.groupBox2.Location = new System.Drawing.Point(12, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(725, 192);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            // 
            // lblGirdiMetniSay
            // 
            this.lblGirdiMetniSay.AutoSize = true;
            this.lblGirdiMetniSay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirdiMetniSay.Location = new System.Drawing.Point(6, 164);
            this.lblGirdiMetniSay.Name = "lblGirdiMetniSay";
            this.lblGirdiMetniSay.Size = new System.Drawing.Size(51, 13);
            this.lblGirdiMetniSay.TabIndex = 10;
            this.lblGirdiMetniSay.Text = "(300000)";
            this.lblGirdiMetniSay.Click += new System.EventHandler(this.lblGirdiMetniSay_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSwitch.Location = new System.Drawing.Point(340, 135);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(42, 26);
            this.btnSwitch.TabIndex = 4;
            this.btnSwitch.Text = "<";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDecrypt.Location = new System.Drawing.Point(321, 84);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(82, 34);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Giải mã";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEncrypt.Location = new System.Drawing.Point(321, 44);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(82, 34);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Mã hóa";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbOutput.Location = new System.Drawing.Point(430, 20);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(156, 17);
            this.lbOutput.TabIndex = 6;
            this.lbOutput.Text = "Văn bản đã được xử lý";
            // 
            // tb_Output
            // 
            this.tb_Output.Enabled = false;
            this.tb_Output.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_Output.Location = new System.Drawing.Point(433, 44);
            this.tb_Output.MaxLength = 399;
            this.tb_Output.Multiline = true;
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.Size = new System.Drawing.Size(286, 117);
            this.tb_Output.TabIndex = 5;
            this.tb_Output.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbMatrix);
            this.groupBox1.Controls.Add(this.tb_Key);
            this.groupBox1.Controls.Add(this.lbKey);
            this.groupBox1.Controls.Add(this.lbHint1);
            this.groupBox1.Controls.Add(this.tb_Matrix);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 334);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // lbHint1
            // 
            this.lbHint1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbHint1.Location = new System.Drawing.Point(12, 71);
            this.lbHint1.Name = "lbHint1";
            this.lbHint1.Size = new System.Drawing.Size(255, 47);
            this.lbHint1.TabIndex = 11;
            this.lbHint1.Text = "(Ma trận khóa sẽ được hình thành theo chuỗi khóa đã nhập)";
            this.lbHint1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPlayfair
            // 
            this.AcceptButton = this.btnEncrypt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 564);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPlayfair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Playfair";
            this.Load += new System.EventHandler(this.frmPlayfair_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label lbMatrix;
        private System.Windows.Forms.TextBox tb_Matrix;

        private System.Windows.Forms.Label lbKey;
        private System.Windows.Forms.TextBox tb_Key;
        private System.Windows.Forms.Label lbHint1;

        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.TextBox tb_Input;

        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.TextBox tb_Output;

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;

        private System.Windows.Forms.Button btnSwitch;
        
        private System.Windows.Forms.Label lblGirdiMetniSay;        
        
        //private System.Windows.Forms.CheckBox cbTemizle;
    }
}

