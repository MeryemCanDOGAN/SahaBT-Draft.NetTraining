namespace SahaBT_.NETTraining
{
    partial class Form1
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
            this.dtgridAll = new System.Windows.Forms.DataGridView();
            this.dtGridF = new System.Windows.Forms.DataGridView();
            this.dtGridM = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rdBtnKadın = new System.Windows.Forms.RadioButton();
            this.rdBtnErkek = new System.Windows.Forms.RadioButton();
            this.rdBtnHerkes = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridM)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgridAll
            // 
            this.dtgridAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridAll.Location = new System.Drawing.Point(796, 68);
            this.dtgridAll.Name = "dtgridAll";
            this.dtgridAll.Size = new System.Drawing.Size(379, 382);
            this.dtgridAll.TabIndex = 0;
            // 
            // dtGridF
            // 
            this.dtGridF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridF.Location = new System.Drawing.Point(12, 68);
            this.dtGridF.Name = "dtGridF";
            this.dtGridF.Size = new System.Drawing.Size(381, 382);
            this.dtGridF.TabIndex = 1;
            // 
            // dtGridM
            // 
            this.dtGridM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridM.Location = new System.Drawing.Point(421, 68);
            this.dtGridM.Name = "dtGridM";
            this.dtGridM.Size = new System.Drawing.Size(365, 382);
            this.dtGridM.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(796, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "-Ülke Seçiniz-";
            // 
            // rdBtnKadın
            // 
            this.rdBtnKadın.AutoSize = true;
            this.rdBtnKadın.Location = new System.Drawing.Point(936, 42);
            this.rdBtnKadın.Name = "rdBtnKadın";
            this.rdBtnKadın.Size = new System.Drawing.Size(52, 17);
            this.rdBtnKadın.TabIndex = 4;
            this.rdBtnKadın.TabStop = true;
            this.rdBtnKadın.Text = "Kadın";
            this.rdBtnKadın.UseVisualStyleBackColor = true;
            this.rdBtnKadın.CheckedChanged += new System.EventHandler(this.rdBtnKadın_CheckedChanged);
            // 
            // rdBtnErkek
            // 
            this.rdBtnErkek.AutoSize = true;
            this.rdBtnErkek.Location = new System.Drawing.Point(994, 41);
            this.rdBtnErkek.Name = "rdBtnErkek";
            this.rdBtnErkek.Size = new System.Drawing.Size(53, 17);
            this.rdBtnErkek.TabIndex = 5;
            this.rdBtnErkek.TabStop = true;
            this.rdBtnErkek.Text = "Erkek";
            this.rdBtnErkek.UseVisualStyleBackColor = true;
            this.rdBtnErkek.CheckedChanged += new System.EventHandler(this.rdBtnErkek_CheckedChanged);
            // 
            // rdBtnHerkes
            // 
            this.rdBtnHerkes.AutoSize = true;
            this.rdBtnHerkes.Location = new System.Drawing.Point(1053, 41);
            this.rdBtnHerkes.Name = "rdBtnHerkes";
            this.rdBtnHerkes.Size = new System.Drawing.Size(59, 17);
            this.rdBtnHerkes.TabIndex = 6;
            this.rdBtnHerkes.TabStop = true;
            this.rdBtnHerkes.Text = "Herkes";
            this.rdBtnHerkes.UseVisualStyleBackColor = true;
            this.rdBtnHerkes.CheckedChanged += new System.EventHandler(this.rdBtnHerkes_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kadınlar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(416, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Erkekler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 486);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdBtnHerkes);
            this.Controls.Add(this.rdBtnErkek);
            this.Controls.Add(this.rdBtnKadın);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dtGridM);
            this.Controls.Add(this.dtGridF);
            this.Controls.Add(this.dtgridAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgridAll;
        private System.Windows.Forms.DataGridView dtGridF;
        private System.Windows.Forms.DataGridView dtGridM;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rdBtnKadın;
        private System.Windows.Forms.RadioButton rdBtnErkek;
        private System.Windows.Forms.RadioButton rdBtnHerkes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

