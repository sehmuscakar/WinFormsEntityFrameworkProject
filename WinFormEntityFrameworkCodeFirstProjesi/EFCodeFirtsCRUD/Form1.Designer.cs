namespace EFCodeFirtsCRUD
{
    partial class Form1
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnhastaguncelle = new System.Windows.Forms.Button();
            this.btnhastasil = new System.Windows.Forms.Button();
            this.btnhastaekle = new System.Windows.Forms.Button();
            this.txthastasoyadı = new System.Windows.Forms.TextBox();
            this.txthastaad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1112, 310);
            this.dataGridView2.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnhastaguncelle);
            this.groupBox1.Controls.Add(this.btnhastasil);
            this.groupBox1.Controls.Add(this.btnhastaekle);
            this.groupBox1.Controls.Add(this.txthastasoyadı);
            this.groupBox1.Controls.Add(this.txthastaad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(23, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 313);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ürün Kayıt";
            // 
            // btnhastaguncelle
            // 
            this.btnhastaguncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnhastaguncelle.Location = new System.Drawing.Point(244, 201);
            this.btnhastaguncelle.Name = "btnhastaguncelle";
            this.btnhastaguncelle.Size = new System.Drawing.Size(124, 45);
            this.btnhastaguncelle.TabIndex = 10;
            this.btnhastaguncelle.Text = "Güncelle";
            this.btnhastaguncelle.UseVisualStyleBackColor = false;
            // 
            // btnhastasil
            // 
            this.btnhastasil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnhastasil.Location = new System.Drawing.Point(405, 201);
            this.btnhastasil.Name = "btnhastasil";
            this.btnhastasil.Size = new System.Drawing.Size(133, 45);
            this.btnhastasil.TabIndex = 9;
            this.btnhastasil.Text = "Sil";
            this.btnhastasil.UseVisualStyleBackColor = false;
            // 
            // btnhastaekle
            // 
            this.btnhastaekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnhastaekle.Location = new System.Drawing.Point(61, 201);
            this.btnhastaekle.Name = "btnhastaekle";
            this.btnhastaekle.Size = new System.Drawing.Size(135, 45);
            this.btnhastaekle.TabIndex = 8;
            this.btnhastaekle.Text = "Ekle";
            this.btnhastaekle.UseVisualStyleBackColor = false;
            // 
            // txthastasoyadı
            // 
            this.txthastasoyadı.Location = new System.Drawing.Point(118, 76);
            this.txthastasoyadı.Name = "txthastasoyadı";
            this.txthastasoyadı.Size = new System.Drawing.Size(223, 30);
            this.txthastasoyadı.TabIndex = 5;
            // 
            // txthastaad
            // 
            this.txthastaad.Location = new System.Drawing.Point(110, 32);
            this.txthastaad.Name = "txthastaad";
            this.txthastaad.Size = new System.Drawing.Size(224, 30);
            this.txthastaad.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜrünAdı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "ÜrünFiyatı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Stok Miktarı:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 30);
            this.textBox1.TabIndex = 12;
          //  this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 681);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnhastaguncelle;
        private System.Windows.Forms.Button btnhastasil;
        private System.Windows.Forms.Button btnhastaekle;
        private System.Windows.Forms.TextBox txthastasoyadı;
        private System.Windows.Forms.TextBox txthastaad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

