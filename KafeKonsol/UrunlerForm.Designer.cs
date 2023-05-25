namespace KafeKonsol
{
    partial class UrunlerForm
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
            label1 = new Label();
            label2 = new Label();
            btnEkle = new Button();
            txtUrunAd = new TextBox();
            nudBirimFiyat = new NumericUpDown();
            dgvUrunler = new DataGridView();
            btnIptal = new Button();
            btnDuzenle = new Button();
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 8);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 1;
            label2.Text = "Birim Fiyatı (₺)";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(244, 27);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(12, 27);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(137, 23);
            txtUrunAd.TabIndex = 3;
            // 
            // nudBirimFiyat
            // 
            nudBirimFiyat.DecimalPlaces = 2;
            nudBirimFiyat.Location = new Point(155, 27);
            nudBirimFiyat.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudBirimFiyat.Name = "nudBirimFiyat";
            nudBirimFiyat.Size = new Size(83, 23);
            nudBirimFiyat.TabIndex = 4;
            // 
            // dgvUrunler
            // 
            dgvUrunler.AllowUserToAddRows = false;
            dgvUrunler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(12, 57);
            dgvUrunler.MultiSelect = false;
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.ReadOnly = true;
            dgvUrunler.RowHeadersVisible = false;
            dgvUrunler.RowTemplate.Height = 25;
            dgvUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUrunler.Size = new Size(452, 266);
            dgvUrunler.TabIndex = 5;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(325, 27);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(75, 23);
            btnIptal.TabIndex = 6;
            btnIptal.Text = "İPTAL";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Visible = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(389, 329);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(75, 23);
            btnDuzenle.TabIndex = 7;
            btnDuzenle.Text = "DÜZENLE";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // UrunlerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 363);
            Controls.Add(btnDuzenle);
            Controls.Add(btnIptal);
            Controls.Add(dgvUrunler);
            Controls.Add(nudBirimFiyat);
            Controls.Add(txtUrunAd);
            Controls.Add(btnEkle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UrunlerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private DataGridView dataGridView1;
        private Button btnEkle;
        private TextBox txtUrunAd;
        private NumericUpDown nudBirimFiyat;
        private DataGridView dgvUrunler;
        private Button btnIptal;
        private Button btnDuzenle;
    }
}