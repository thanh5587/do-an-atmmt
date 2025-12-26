namespace playfair_and_RSA
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
            txtPlain = new TextBox();
            txtKey = new TextBox();
            txtCipher = new TextBox();
            btnPFEnc = new Button();
            btnPFDec = new Button();
            btnRSAEnc = new Button();
            btnRSADec = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtPlain
            // 
            txtPlain.AcceptsTab = true;
            txtPlain.Location = new Point(25, 62);
            txtPlain.Multiline = true;
            txtPlain.Name = "txtPlain";
            txtPlain.ScrollBars = ScrollBars.Vertical;
            txtPlain.Size = new Size(701, 94);
            txtPlain.TabIndex = 0;
            txtPlain.TextChanged += txtPlain_TextChanged;
            // 
            // txtKey
            // 
            txtKey.Location = new Point(25, 216);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(251, 23);
            txtKey.TabIndex = 1;
            // 
            // txtCipher
            // 
            txtCipher.Location = new Point(25, 307);
            txtCipher.Multiline = true;
            txtCipher.Name = "txtCipher";
            txtCipher.ScrollBars = ScrollBars.Vertical;
            txtCipher.Size = new Size(701, 100);
            txtCipher.TabIndex = 2;
            // 
            // btnPFEnc
            // 
            btnPFEnc.Font = new Font("Segoe UI", 12F);
            btnPFEnc.Location = new Point(392, 168);
            btnPFEnc.Name = "btnPFEnc";
            btnPFEnc.Size = new Size(128, 58);
            btnPFEnc.TabIndex = 3;
            btnPFEnc.Text = "Playfair Encrypt";
            btnPFEnc.UseVisualStyleBackColor = true;
            btnPFEnc.Click += btnPFEnc_Click;
            // 
            // btnPFDec
            // 
            btnPFDec.Font = new Font("Segoe UI", 12F);
            btnPFDec.Location = new Point(392, 232);
            btnPFDec.Name = "btnPFDec";
            btnPFDec.Size = new Size(128, 57);
            btnPFDec.TabIndex = 4;
            btnPFDec.Text = "Playfair Decrypt";
            btnPFDec.UseVisualStyleBackColor = true;
            btnPFDec.Click += btnPFDec_Click;
            // 
            // btnRSAEnc
            // 
            btnRSAEnc.Font = new Font("Segoe UI", 12F);
            btnRSAEnc.Location = new Point(561, 169);
            btnRSAEnc.Name = "btnRSAEnc";
            btnRSAEnc.Size = new Size(128, 57);
            btnRSAEnc.TabIndex = 5;
            btnRSAEnc.Text = "RSA Encrypt";
            btnRSAEnc.UseVisualStyleBackColor = true;
            btnRSAEnc.Click += btnRSAEnc_Click;
            // 
            // btnRSADec
            // 
            btnRSADec.Font = new Font("Segoe UI", 12F);
            btnRSADec.Location = new Point(561, 232);
            btnRSADec.Name = "btnRSADec";
            btnRSADec.Size = new Size(128, 57);
            btnRSADec.TabIndex = 6;
            btnRSADec.Text = "RSA Decrypt";
            btnRSADec.UseVisualStyleBackColor = true;
            btnRSADec.Click += btnRSADec_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(326, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 32);
            label1.TabIndex = 7;
            label1.Text = "Playfair - RSA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F);
            label2.Location = new Point(25, 29);
            label2.Name = "label2";
            label2.Size = new Size(62, 30);
            label2.TabIndex = 8;
            label2.Text = "Input";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 15.75F);
            label3.Location = new Point(25, 182);
            label3.Name = "label3";
            label3.Size = new Size(116, 30);
            label3.TabIndex = 9;
            label3.Text = "PlayFairKey";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F);
            label4.Location = new Point(25, 259);
            label4.Name = "label4";
            label4.Size = new Size(79, 30);
            label4.TabIndex = 10;
            label4.Text = "Output";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.hinh_nen_may_tinh_4;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(795, 441);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRSADec);
            Controls.Add(btnRSAEnc);
            Controls.Add(btnPFDec);
            Controls.Add(btnPFEnc);
            Controls.Add(txtCipher);
            Controls.Add(txtKey);
            Controls.Add(txtPlain);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPlain;
        private TextBox txtKey;
        private TextBox txtCipher;
        private Button btnPFEnc;
        private Button btnPFDec;
        private Button btnRSAEnc;
        private Button btnRSADec;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
