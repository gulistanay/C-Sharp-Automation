
namespace Kirtasiye_Otomasyon
{
    partial class FormSiparisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSiparisler));
            this.dataGridViewSiparisler = new System.Windows.Forms.DataGridView();
            this.buttonGoruntule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSiparisler
            // 
            this.dataGridViewSiparisler.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridViewSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiparisler.Location = new System.Drawing.Point(76, 149);
            this.dataGridViewSiparisler.Name = "dataGridViewSiparisler";
            this.dataGridViewSiparisler.RowHeadersWidth = 51;
            this.dataGridViewSiparisler.RowTemplate.Height = 24;
            this.dataGridViewSiparisler.Size = new System.Drawing.Size(608, 253);
            this.dataGridViewSiparisler.TabIndex = 0;
            // 
            // buttonGoruntule
            // 
            this.buttonGoruntule.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonGoruntule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonGoruntule.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.buttonGoruntule.FlatAppearance.BorderSize = 5;
            this.buttonGoruntule.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSalmon;
            this.buttonGoruntule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon;
            this.buttonGoruntule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.buttonGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoruntule.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGoruntule.Image = ((System.Drawing.Image)(resources.GetObject("buttonGoruntule.Image")));
            this.buttonGoruntule.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGoruntule.Location = new System.Drawing.Point(592, 71);
            this.buttonGoruntule.Name = "buttonGoruntule";
            this.buttonGoruntule.Size = new System.Drawing.Size(148, 62);
            this.buttonGoruntule.TabIndex = 35;
            this.buttonGoruntule.Text = "Siparişleri Göster";
            this.buttonGoruntule.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGoruntule.UseMnemonic = false;
            this.buttonGoruntule.UseVisualStyleBackColor = false;
            this.buttonGoruntule.Click += new System.EventHandler(this.buttonGoruntule_Click);
            // 
            // FormSiparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGoruntule);
            this.Controls.Add(this.dataGridViewSiparisler);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSiparisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparişler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSiparisler;
        private System.Windows.Forms.Button buttonGoruntule;
    }
}