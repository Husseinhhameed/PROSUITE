namespace Readpdf {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            
            this.pdfViewer = new DevExpress.XtraPdfViewer.PdfViewer();


            

            this.SuspendLayout();

            this.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
this.pdfViewer.Location = new System.Drawing.Point(0, 0);
this.pdfViewer.Name = "pdfViewer";
this.pdfViewer.Size = new System.Drawing.Size(441, 253);
this.pdfViewer.TabIndex = 0;
this.pdfViewer.Text = "pdfViewer";


            this.Name = "Form1";
            this.Text = "Form1";
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.Controls.Add(this.pdfViewer);

            
            
            
            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer;
        
    }
}
