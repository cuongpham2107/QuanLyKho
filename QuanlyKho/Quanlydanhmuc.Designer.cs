namespace QuanlyKho
{
    partial class Quanlydanhmuc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvDanhmuc = new System.Windows.Forms.DataGridView();
            this.rtxtDesc = new System.Windows.Forms.RichTextBox();
            this.rtxtBody = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhmuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên danh muc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mô tả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nội dung";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(268, 20);
            this.txtName.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(313, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "Xoá";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvDanhmuc
            // 
            this.dgvDanhmuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhmuc.Location = new System.Drawing.Point(426, 42);
            this.dgvDanhmuc.Name = "dgvDanhmuc";
            this.dgvDanhmuc.Size = new System.Drawing.Size(826, 806);
            this.dgvDanhmuc.TabIndex = 9;
            this.dgvDanhmuc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhmuc_CellContentClick);
            // 
            // rtxtDesc
            // 
            this.rtxtDesc.Location = new System.Drawing.Point(128, 85);
            this.rtxtDesc.Name = "rtxtDesc";
            this.rtxtDesc.Size = new System.Drawing.Size(268, 71);
            this.rtxtDesc.TabIndex = 10;
            this.rtxtDesc.Text = "";
            // 
            // rtxtBody
            // 
            this.rtxtBody.Location = new System.Drawing.Point(128, 173);
            this.rtxtBody.Name = "rtxtBody";
            this.rtxtBody.Size = new System.Drawing.Size(268, 109);
            this.rtxtBody.TabIndex = 11;
            this.rtxtBody.Text = "";
            // 
            // Quanlydanhmuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 871);
            this.Controls.Add(this.rtxtBody);
            this.Controls.Add(this.rtxtDesc);
            this.Controls.Add(this.dgvDanhmuc);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Quanlydanhmuc";
            this.Text = "Quanlydanhmuc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhmuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvDanhmuc;
        private System.Windows.Forms.RichTextBox rtxtDesc;
        private System.Windows.Forms.RichTextBox rtxtBody;
    }
}