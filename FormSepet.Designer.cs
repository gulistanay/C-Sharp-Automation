
namespace Kirtasiye_Otomasyon
{
    partial class FormSepet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSepet));
            this.dataGridViewSepet = new System.Windows.Forms.DataGridView();
            this.buttonSepetGoruntule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSepet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSepet
            // 
            this.dataGridViewSepet.BackgroundColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSepet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSepet.Location = new System.Drawing.Point(133, 245);
            this.dataGridViewSepet.Name = "dataGridViewSepet";
            this.dataGridViewSepet.ReadOnly = true;
            this.dataGridViewSepet.RowHeadersWidth = 51;
            this.dataGridViewSepet.RowTemplate.Height = 24;
            this.dataGridViewSepet.Size = new System.Drawing.Size(737, 268);
            this.dataGridViewSepet.TabIndex = 0;
            // 
            // buttonSepetGoruntule
            // 
            this.buttonSepetGoruntule.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonSepetGoruntule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSepetGoruntule.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.buttonSepetGoruntule.FlatAppearance.BorderSize = 5;
            this.buttonSepetGoruntule.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSalmon;
            this.buttonSepetGoruntule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon;
            this.buttonSepetGoruntule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.buttonSepetGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSepetGoruntule.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSepetGoruntule.Image = ((System.Drawing.Image)(resources.GetObject("buttonSepetGoruntule.Image")));
            this.buttonSepetGoruntule.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSepetGoruntule.Location = new System.Drawing.Point(722, 151);
            this.buttonSepetGoruntule.Name = "buttonSepetGoruntule";
            this.buttonSepetGoruntule.Size = new System.Drawing.Size(148, 62);
            this.buttonSepetGoruntule.TabIndex = 29;
            this.buttonSepetGoruntule.Text = "Sepeti Görüntüle";
            this.buttonSepetGoruntule.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSepetGoruntule.UseMnemonic = false;
            this.buttonSepetGoruntule.UseVisualStyleBackColor = false;
            this.buttonSepetGoruntule.Click += new System.EventHandler(this.buttonSepetGoruntule_Click);
            // 
            // FormSepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(995, 589);
            this.Controls.Add(this.buttonSepetGoruntule);
            this.Controls.Add(this.dataGridViewSepet);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSepet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sepet";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSepet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSepet;
        private System.Windows.Forms.Button buttonSepetGoruntule;
    }
}