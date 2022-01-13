
namespace TurRehberi
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGeziBilgileriniListele = new System.Windows.Forms.Button();
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.btnRehberListele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbRehberler = new System.Windows.Forms.ComboBox();
            this.cmbUlkeler = new System.Windows.Forms.ComboBox();
            this.btnRehberProgramListele = new System.Windows.Forms.Button();
            this.btnUlkesineGoreListele = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grdwTablo = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMusteriKimlikNo = new System.Windows.Forms.TextBox();
            this.txtRehberKimlikNo = new System.Windows.Forms.TextBox();
            this.btnRehberKimlikNoAra = new System.Windows.Forms.Button();
            this.btnMusteriKimlikNoAra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSifreleriGoster = new System.Windows.Forms.Button();
            this.btnDilBilgileriniGoster = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdwTablo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDilBilgileriniGoster);
            this.panel1.Controls.Add(this.btnGeziBilgileriniListele);
            this.panel1.Controls.Add(this.btnSifreleriGoster);
            this.panel1.Controls.Add(this.btnMusteriListele);
            this.panel1.Controls.Add(this.btnRehberListele);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 138);
            this.panel1.TabIndex = 0;
            // 
            // btnGeziBilgileriniListele
            // 
            this.btnGeziBilgileriniListele.Location = new System.Drawing.Point(7, 72);
            this.btnGeziBilgileriniListele.Name = "btnGeziBilgileriniListele";
            this.btnGeziBilgileriniListele.Size = new System.Drawing.Size(140, 23);
            this.btnGeziBilgileriniListele.TabIndex = 3;
            this.btnGeziBilgileriniListele.Text = "Gezi Bilgilerini Listele";
            this.btnGeziBilgileriniListele.UseVisualStyleBackColor = true;
            this.btnGeziBilgileriniListele.Click += new System.EventHandler(this.btnGeziBilgileriniListele_Click);
            // 
            // btnMusteriListele
            // 
            this.btnMusteriListele.Location = new System.Drawing.Point(6, 101);
            this.btnMusteriListele.Name = "btnMusteriListele";
            this.btnMusteriListele.Size = new System.Drawing.Size(141, 23);
            this.btnMusteriListele.TabIndex = 2;
            this.btnMusteriListele.Text = "Musteri Listele";
            this.btnMusteriListele.UseVisualStyleBackColor = true;
            this.btnMusteriListele.Click += new System.EventHandler(this.btnMusteriListele_Click);
            // 
            // btnRehberListele
            // 
            this.btnRehberListele.Location = new System.Drawing.Point(7, 43);
            this.btnRehberListele.Name = "btnRehberListele";
            this.btnRehberListele.Size = new System.Drawing.Size(140, 23);
            this.btnRehberListele.TabIndex = 1;
            this.btnRehberListele.Text = "Rehberleri Listele";
            this.btnRehberListele.UseVisualStyleBackColor = true;
            this.btnRehberListele.Click += new System.EventHandler(this.btnRehberListele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genel Listeleme İslemleri";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbRehberler);
            this.panel2.Controls.Add(this.cmbUlkeler);
            this.panel2.Controls.Add(this.btnRehberProgramListele);
            this.panel2.Controls.Add(this.btnUlkesineGoreListele);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(25, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 134);
            this.panel2.TabIndex = 1;
            // 
            // cmbRehberler
            // 
            this.cmbRehberler.FormattingEnabled = true;
            this.cmbRehberler.Location = new System.Drawing.Point(202, 73);
            this.cmbRehberler.Name = "cmbRehberler";
            this.cmbRehberler.Size = new System.Drawing.Size(121, 21);
            this.cmbRehberler.TabIndex = 4;
            // 
            // cmbUlkeler
            // 
            this.cmbUlkeler.FormattingEnabled = true;
            this.cmbUlkeler.Location = new System.Drawing.Point(202, 42);
            this.cmbUlkeler.Name = "cmbUlkeler";
            this.cmbUlkeler.Size = new System.Drawing.Size(121, 21);
            this.cmbUlkeler.TabIndex = 3;
            // 
            // btnRehberProgramListele
            // 
            this.btnRehberProgramListele.Location = new System.Drawing.Point(14, 71);
            this.btnRehberProgramListele.Name = "btnRehberProgramListele";
            this.btnRehberProgramListele.Size = new System.Drawing.Size(133, 23);
            this.btnRehberProgramListele.TabIndex = 2;
            this.btnRehberProgramListele.Text = "Rehberin Programını Listele";
            this.btnRehberProgramListele.UseVisualStyleBackColor = true;
            this.btnRehberProgramListele.Click += new System.EventHandler(this.btnRehberProgramListele_Click);
            // 
            // btnUlkesineGoreListele
            // 
            this.btnUlkesineGoreListele.Location = new System.Drawing.Point(14, 42);
            this.btnUlkesineGoreListele.Name = "btnUlkesineGoreListele";
            this.btnUlkesineGoreListele.Size = new System.Drawing.Size(133, 23);
            this.btnUlkesineGoreListele.TabIndex = 1;
            this.btnUlkesineGoreListele.Text = "Ulkesine Gore Listele";
            this.btnUlkesineGoreListele.UseVisualStyleBackColor = true;
            this.btnUlkesineGoreListele.Click += new System.EventHandler(this.btnUlkesineGoreListele_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Özel Listeleme İslemleri";
            // 
            // grdwTablo
            // 
            this.grdwTablo.AllowUserToAddRows = false;
            this.grdwTablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdwTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdwTablo.Location = new System.Drawing.Point(537, 12);
            this.grdwTablo.Name = "grdwTablo";
            this.grdwTablo.Size = new System.Drawing.Size(764, 291);
            this.grdwTablo.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMusteriKimlikNo);
            this.panel3.Controls.Add(this.txtRehberKimlikNo);
            this.panel3.Controls.Add(this.btnRehberKimlikNoAra);
            this.panel3.Controls.Add(this.btnMusteriKimlikNoAra);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(25, 309);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(495, 134);
            this.panel3.TabIndex = 3;
            // 
            // txtMusteriKimlikNo
            // 
            this.txtMusteriKimlikNo.Location = new System.Drawing.Point(192, 42);
            this.txtMusteriKimlikNo.Name = "txtMusteriKimlikNo";
            this.txtMusteriKimlikNo.Size = new System.Drawing.Size(131, 20);
            this.txtMusteriKimlikNo.TabIndex = 5;
            // 
            // txtRehberKimlikNo
            // 
            this.txtRehberKimlikNo.Location = new System.Drawing.Point(192, 73);
            this.txtRehberKimlikNo.Name = "txtRehberKimlikNo";
            this.txtRehberKimlikNo.Size = new System.Drawing.Size(131, 20);
            this.txtRehberKimlikNo.TabIndex = 4;
            // 
            // btnRehberKimlikNoAra
            // 
            this.btnRehberKimlikNoAra.Location = new System.Drawing.Point(14, 71);
            this.btnRehberKimlikNoAra.Name = "btnRehberKimlikNoAra";
            this.btnRehberKimlikNoAra.Size = new System.Drawing.Size(159, 23);
            this.btnRehberKimlikNoAra.TabIndex = 2;
            this.btnRehberKimlikNoAra.Text = "Rehber Ara";
            this.btnRehberKimlikNoAra.UseVisualStyleBackColor = true;
            this.btnRehberKimlikNoAra.Click += new System.EventHandler(this.btnRehberKimlikNoAra_Click);
            // 
            // btnMusteriKimlikNoAra
            // 
            this.btnMusteriKimlikNoAra.Location = new System.Drawing.Point(14, 42);
            this.btnMusteriKimlikNoAra.Name = "btnMusteriKimlikNoAra";
            this.btnMusteriKimlikNoAra.Size = new System.Drawing.Size(159, 23);
            this.btnMusteriKimlikNoAra.TabIndex = 1;
            this.btnMusteriKimlikNoAra.Text = "Musteri Kimlik Nosuna Gore Ara";
            this.btnMusteriKimlikNoAra.UseVisualStyleBackColor = true;
            this.btnMusteriKimlikNoAra.Click += new System.EventHandler(this.btnMusteriKimlikNoAra_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Özel Listeleme İslemleri";
            // 
            // btnSifreleriGoster
            // 
            this.btnSifreleriGoster.Location = new System.Drawing.Point(153, 43);
            this.btnSifreleriGoster.Name = "btnSifreleriGoster";
            this.btnSifreleriGoster.Size = new System.Drawing.Size(181, 23);
            this.btnSifreleriGoster.TabIndex = 4;
            this.btnSifreleriGoster.Text = "Metinleri Ve Sifreleri Goster";
            this.btnSifreleriGoster.UseVisualStyleBackColor = true;
            this.btnSifreleriGoster.Click += new System.EventHandler(this.btnSifreleriGoster_Click);
            // 
            // btnDilBilgileriniGoster
            // 
            this.btnDilBilgileriniGoster.Location = new System.Drawing.Point(153, 72);
            this.btnDilBilgileriniGoster.Name = "btnDilBilgileriniGoster";
            this.btnDilBilgileriniGoster.Size = new System.Drawing.Size(181, 23);
            this.btnDilBilgileriniGoster.TabIndex = 5;
            this.btnDilBilgileriniGoster.Text = "Metni Ve Dil bilgilerini Goster";
            this.btnDilBilgileriniGoster.UseVisualStyleBackColor = true;
            this.btnDilBilgileriniGoster.Click += new System.EventHandler(this.btnDilBilgileriniGoster_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.grdwTablo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AnaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdwTablo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGeziBilgileriniListele;
        private System.Windows.Forms.Button btnMusteriListele;
        private System.Windows.Forms.Button btnRehberListele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbRehberler;
        private System.Windows.Forms.ComboBox cmbUlkeler;
        private System.Windows.Forms.Button btnRehberProgramListele;
        private System.Windows.Forms.Button btnUlkesineGoreListele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdwTablo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMusteriKimlikNo;
        private System.Windows.Forms.TextBox txtRehberKimlikNo;
        private System.Windows.Forms.Button btnRehberKimlikNoAra;
        private System.Windows.Forms.Button btnMusteriKimlikNoAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSifreleriGoster;
        private System.Windows.Forms.Button btnDilBilgileriniGoster;
    }
}

