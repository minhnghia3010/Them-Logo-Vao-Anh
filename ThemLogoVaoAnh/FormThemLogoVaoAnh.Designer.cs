
namespace ThemLogoVaoAnh
{
    partial class FormThemLogoVaoAnh
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
            this.btnthumuc = new System.Windows.Forms.Button();
            this.txtchu = new System.Windows.Forms.TextBox();
            this.cbmau = new System.Windows.Forms.ComboBox();
            this.chkauto = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsize = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.cbxX = new System.Windows.Forms.ComboBox();
            this.cbxY = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnthumuc
            // 
            this.btnthumuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthumuc.Location = new System.Drawing.Point(15, 396);
            this.btnthumuc.Name = "btnthumuc";
            this.btnthumuc.Size = new System.Drawing.Size(773, 70);
            this.btnthumuc.TabIndex = 0;
            this.btnthumuc.Text = "Chọn Thư Mục Cần Thêm Logo";
            this.btnthumuc.UseVisualStyleBackColor = true;
            this.btnthumuc.Click += new System.EventHandler(this.btnthumuc_Click);
            // 
            // txtchu
            // 
            this.txtchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchu.Location = new System.Drawing.Point(178, 89);
            this.txtchu.Name = "txtchu";
            this.txtchu.Size = new System.Drawing.Size(388, 30);
            this.txtchu.TabIndex = 1;
            // 
            // cbmau
            // 
            this.cbmau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmau.FormattingEnabled = true;
            this.cbmau.Location = new System.Drawing.Point(178, 151);
            this.cbmau.Name = "cbmau";
            this.cbmau.Size = new System.Drawing.Size(269, 33);
            this.cbmau.TabIndex = 2;
            // 
            // chkauto
            // 
            this.chkauto.AutoSize = true;
            this.chkauto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkauto.Location = new System.Drawing.Point(432, 288);
            this.chkauto.Name = "chkauto";
            this.chkauto.Size = new System.Drawing.Size(102, 26);
            this.chkauto.TabIndex = 3;
            this.chkauto.Text = "Tự Động";
            this.chkauto.UseVisualStyleBackColor = true;
            this.chkauto.CheckedChanged += new System.EventHandler(this.chkauto_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(237, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "THÊM LOGO VÀO ẢNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhập Tên Logo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập Màu Logo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhập Size Logo";
            // 
            // txtsize
            // 
            this.txtsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsize.Location = new System.Drawing.Point(178, 217);
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(186, 30);
            this.txtsize.TabIndex = 8;
            this.txtsize.Leave += new System.EventHandler(this.txtsize_Leave);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Trục X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Trục Y";
            // 
            // txtX
            // 
            this.txtX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX.Location = new System.Drawing.Point(178, 282);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(248, 32);
            this.txtX.TabIndex = 13;
            // 
            // txtY
            // 
            this.txtY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtY.Location = new System.Drawing.Point(178, 341);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(248, 32);
            this.txtY.TabIndex = 14;
            // 
            // cbxX
            // 
            this.cbxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxX.FormattingEnabled = true;
            this.cbxX.Location = new System.Drawing.Point(540, 283);
            this.cbxX.Name = "cbxX";
            this.cbxX.Size = new System.Drawing.Size(248, 33);
            this.cbxX.TabIndex = 15;
            // 
            // cbxY
            // 
            this.cbxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxY.FormattingEnabled = true;
            this.cbxY.Location = new System.Drawing.Point(540, 340);
            this.cbxY.Name = "cbxY";
            this.cbxY.Size = new System.Drawing.Size(248, 33);
            this.cbxY.TabIndex = 16;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(592, 91);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 26);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Xoay";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormThemLogoVaoAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 486);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cbxY);
            this.Controls.Add(this.cbxX);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkauto);
            this.Controls.Add(this.cbmau);
            this.Controls.Add(this.txtchu);
            this.Controls.Add(this.btnthumuc);
            this.Name = "FormThemLogoVaoAnh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Logo Vào Ảnh";
            this.Load += new System.EventHandler(this.FormThemLogoVaoAnh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthumuc;
        private System.Windows.Forms.TextBox txtchu;
        private System.Windows.Forms.ComboBox cbmau;
        private System.Windows.Forms.CheckBox chkauto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsize;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.ComboBox cbxX;
        private System.Windows.Forms.ComboBox cbxY;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

