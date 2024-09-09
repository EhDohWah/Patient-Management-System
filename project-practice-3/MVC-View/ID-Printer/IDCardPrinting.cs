using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace project_practice_3.MVC_View.ID_Printer
{
    public partial class IDCardPrinting : Form
    {
        Bitmap memoryImage;

        public IDCardPrinting()
        {
            InitializeComponent();
            gbxGeneratedIDCard.Visible = false;

           
        }

        // Capture the panel as an image
        private void CapturePanel(Panel panel)
        {
            // Create a new bitmap with the size of the panel
            memoryImage = new Bitmap(panel.Width, panel.Height);
            // Render the panel's content onto the bitmap
            panel.DrawToBitmap(memoryImage, new Rectangle(0, 0, panel.Width, panel.Height));
        }

        // Print the panel (ID Card)
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            // Capture the panel containing the ID card layout
            CapturePanel(generatedID);

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            PrintDialog printDlg = new PrintDialog();
            printDlg.Document = printDoc;

            if (printDlg.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }


        // Method to generate and display a barcode from the PID
        private void GenerateBarcode(string pid)
        {
            var barcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,  // You can choose other formats like QR_CODE, etc.
                Options = new ZXing.Common.EncodingOptions
                {
                    Width = pbxBarCode.Width,  // Set the barcode width to fit the PictureBox
                    Height = pbxBarCode.Height,  // Set the barcode height to fit the PictureBox
                    Margin = 1  // Optional: Set a margin around the barcode
                }
            };

            // Generate the barcode image from the PID
            Bitmap barcodeBitmap = barcodeWriter.Write(pid);

            // Display the barcode in the PictureBox
            pbxBarCode.Image = barcodeBitmap;
        }


        private void BtnPrintPreview_Click(object sender, EventArgs e)
        {
            // Capture the panel containing the ID card layout
            CapturePanel(generatedID);

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            // Create a print preview dialog
            PrintPreviewDialog printPreviewDlg = new PrintPreviewDialog();
            printPreviewDlg.Document = printDoc;

            // Set the size of the print preview dialog (optional)
            printPreviewDlg.Width = 800;
            printPreviewDlg.Height = 600;

            // Center the print preview dialog relative to the parent form
            int x = this.Location.X + (this.Width - printPreviewDlg.Width) / 2;
            int y = this.Location.Y + (this.Height - printPreviewDlg.Height) / 2;

            printPreviewDlg.StartPosition = FormStartPosition.Manual;  // Set the dialog to manual positioning
            printPreviewDlg.Location = new Point(x, y);                // Set the calculated center position

            // Show the print preview dialog
            printPreviewDlg.ShowDialog();
        }


        // Printing Document
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Adjust the position for where to print the ID card on the page
            int x = 100;  // Adjust X position to center or as needed
            int y = 100;  // Adjust Y position to center or as needed

            // Use high-quality settings for better print output
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

            // Draw the image at the specified position
            e.Graphics.DrawImage(memoryImage, x, y, memoryImage.Width, memoryImage.Height);
        }

        // Generate the ID card 
        private void BtnGenerateIDCard_Click(object sender, EventArgs e)
        {

            using (var context = new DatabaseConnection())
            {
                string patientId = tbxPID.Text;  // Example Patient ID
                var patient = context.Patients.Where(p => p.PID == patientId).FirstOrDefault();

                if (patient != null)
                {
                    lblFullNameValue.Text = patient.FullName;
                    lblPIDValue.Text = patient.PID;
                    lblPhoneNumber.Text = patient.PhoneNumber;
                    GenerateBarcode(patient.PID);
                }
            }


            gbxGeneratedIDCard.Visible = true;

        }
    }
}
