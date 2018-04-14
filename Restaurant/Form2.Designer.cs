namespace Restaurant
{
    partial class Checkout
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
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.addressLbl = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.Location = new System.Drawing.Point(12, 349);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(164, 32);
            this.checkoutBtn.TabIndex = 24;
            this.checkoutBtn.Text = " Checkout";
            this.checkoutBtn.UseVisualStyleBackColor = true;
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(9, 322);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(45, 13);
            this.addressLbl.TabIndex = 23;
            this.addressLbl.Text = "Address";
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(61, 319);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(115, 20);
            this.addressTxt.TabIndex = 22;
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Location = new System.Drawing.Point(9, 296);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(38, 13);
            this.phoneLbl.TabIndex = 19;
            this.phoneLbl.Text = "Phone";
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(61, 293);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(115, 20);
            this.phoneTxt.TabIndex = 18;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Location = new System.Drawing.Point(12, 12);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(696, 275);
            this.printPreviewControl1.TabIndex = 25;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(633, 358);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(75, 23);
            this.printBtn.TabIndex = 26;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = true;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 390);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.printPreviewControl1);
            this.Controls.Add(this.checkoutBtn);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.phoneTxt);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkoutBtn;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button printBtn;
    }
}