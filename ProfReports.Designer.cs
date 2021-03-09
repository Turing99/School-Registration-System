
namespace SistemScolarDeInregistrare_Proof_Elev_
{
    partial class ProfReports
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SchoolSystemDataSet = new SistemScolarDeInregistrare_Proof_Elev_.SchoolSystemDataSet();
            this.ProfessorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProfessorsTableAdapter = new SistemScolarDeInregistrare_Proof_Elev_.SchoolSystemDataSetTableAdapters.ProfessorsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfessorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProfessorsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemScolarDeInregistrare_Proof_Elev_.ProfReports.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // SchoolSystemDataSet
            // 
            this.SchoolSystemDataSet.DataSetName = "SchoolSystemDataSet";
            this.SchoolSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProfessorsBindingSource
            // 
            this.ProfessorsBindingSource.DataMember = "Professors";
            this.ProfessorsBindingSource.DataSource = this.SchoolSystemDataSet;
            // 
            // ProfessorsTableAdapter
            // 
            this.ProfessorsTableAdapter.ClearBeforeFill = true;
            // 
            // ProfReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ProfReports";
            this.Text = "ProfReports";
            this.Load += new System.EventHandler(this.ProfReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SchoolSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfessorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProfessorsBindingSource;
        private SchoolSystemDataSet SchoolSystemDataSet;
        private SchoolSystemDataSetTableAdapters.ProfessorsTableAdapter ProfessorsTableAdapter;
    }
}