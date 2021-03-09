
namespace SistemScolarDeInregistrare_Proof_Elev_
{
    partial class FrmDisplayFeesData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDisplayFeesData));
            this.lblSearch_Fee = new System.Windows.Forms.Label();
            this.txtSearch_Fee = new System.Windows.Forms.TextBox();
            this.DGridView_Fees = new System.Windows.Forms.DataGridView();
            this.btn_Excel_Fees = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGridView_Fees)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch_Fee
            // 
            this.lblSearch_Fee.AutoSize = true;
            this.lblSearch_Fee.BackColor = System.Drawing.Color.White;
            this.lblSearch_Fee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch_Fee.Location = new System.Drawing.Point(16, 98);
            this.lblSearch_Fee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch_Fee.Name = "lblSearch_Fee";
            this.lblSearch_Fee.Size = new System.Drawing.Size(208, 24);
            this.lblSearch_Fee.TabIndex = 5;
            this.lblSearch_Fee.Text = "Search by First name";
            // 
            // txtSearch_Fee
            // 
            this.txtSearch_Fee.Location = new System.Drawing.Point(16, 138);
            this.txtSearch_Fee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch_Fee.Multiline = true;
            this.txtSearch_Fee.Name = "txtSearch_Fee";
            this.txtSearch_Fee.Size = new System.Drawing.Size(512, 37);
            this.txtSearch_Fee.TabIndex = 4;
            this.txtSearch_Fee.TextChanged += new System.EventHandler(this.txtSearch_Fee_TextChanged);
            // 
            // DGridView_Fees
            // 
            this.DGridView_Fees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridView_Fees.Location = new System.Drawing.Point(16, 194);
            this.DGridView_Fees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGridView_Fees.Name = "DGridView_Fees";
            this.DGridView_Fees.RowHeadersWidth = 51;
            this.DGridView_Fees.Size = new System.Drawing.Size(1005, 446);
            this.DGridView_Fees.TabIndex = 3;
            this.DGridView_Fees.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridView_Fees_CellDoubleClick);
            // 
            // btn_Excel_Fees
            // 
            this.btn_Excel_Fees.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Excel_Fees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Excel_Fees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excel_Fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excel_Fees.ForeColor = System.Drawing.Color.White;
            this.btn_Excel_Fees.Image = ((System.Drawing.Image)(resources.GetObject("btn_Excel_Fees.Image")));
            this.btn_Excel_Fees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Excel_Fees.Location = new System.Drawing.Point(659, 127);
            this.btn_Excel_Fees.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Excel_Fees.Name = "btn_Excel_Fees";
            this.btn_Excel_Fees.Size = new System.Drawing.Size(279, 59);
            this.btn_Excel_Fees.TabIndex = 7;
            this.btn_Excel_Fees.Text = "Export to Excel";
            this.btn_Excel_Fees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Excel_Fees.UseVisualStyleBackColor = false;
            this.btn_Excel_Fees.Click += new System.EventHandler(this.btn_Excel_Fees_Click);
            // 
            // FrmDisplayFeesData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 665);
            this.Controls.Add(this.btn_Excel_Fees);
            this.Controls.Add(this.lblSearch_Fee);
            this.Controls.Add(this.txtSearch_Fee);
            this.Controls.Add(this.DGridView_Fees);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDisplayFeesData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDisplayFeesData";
            this.Load += new System.EventHandler(this.FrmDisplayFeesData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGridView_Fees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch_Fee;
        private System.Windows.Forms.TextBox txtSearch_Fee;
        private System.Windows.Forms.DataGridView DGridView_Fees;
        private System.Windows.Forms.Button btn_Excel_Fees;
    }
}