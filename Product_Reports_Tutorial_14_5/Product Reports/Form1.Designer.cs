namespace Product_Reports
{
    partial class Form1
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
            this.closeButton = new System.Windows.Forms.Button();
            this.qtyLT100Button = new System.Windows.Forms.Button();
            this.qtyGT100Button = new System.Windows.Forms.Button();
            this.priceLT100Button = new System.Windows.Forms.Button();
            this.priceGT100Button = new System.Windows.Forms.Button();
            this.descriptionListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(69, 209);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 28);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // qtyLT100Button
            // 
            this.qtyLT100Button.Location = new System.Drawing.Point(125, 174);
            this.qtyLT100Button.Margin = new System.Windows.Forms.Padding(4);
            this.qtyLT100Button.Name = "qtyLT100Button";
            this.qtyLT100Button.Size = new System.Drawing.Size(100, 28);
            this.qtyLT100Button.TabIndex = 10;
            this.qtyLT100Button.Text = "Qty < $100";
            this.qtyLT100Button.UseVisualStyleBackColor = true;
            this.qtyLT100Button.Click += new System.EventHandler(this.qtyLT100Button_Click);
            // 
            // qtyGT100Button
            // 
            this.qtyGT100Button.Location = new System.Drawing.Point(17, 174);
            this.qtyGT100Button.Margin = new System.Windows.Forms.Padding(4);
            this.qtyGT100Button.Name = "qtyGT100Button";
            this.qtyGT100Button.Size = new System.Drawing.Size(100, 28);
            this.qtyGT100Button.TabIndex = 9;
            this.qtyGT100Button.Text = "Qty > $100";
            this.qtyGT100Button.UseVisualStyleBackColor = true;
            this.qtyGT100Button.Click += new System.EventHandler(this.qtyGT100Button_Click);
            // 
            // priceLT100Button
            // 
            this.priceLT100Button.Location = new System.Drawing.Point(125, 138);
            this.priceLT100Button.Margin = new System.Windows.Forms.Padding(4);
            this.priceLT100Button.Name = "priceLT100Button";
            this.priceLT100Button.Size = new System.Drawing.Size(100, 28);
            this.priceLT100Button.TabIndex = 8;
            this.priceLT100Button.Text = "Price < $100";
            this.priceLT100Button.UseVisualStyleBackColor = true;
            this.priceLT100Button.Click += new System.EventHandler(this.priceLT100Button_Click);
            // 
            // priceGT100Button
            // 
            this.priceGT100Button.Location = new System.Drawing.Point(17, 138);
            this.priceGT100Button.Margin = new System.Windows.Forms.Padding(4);
            this.priceGT100Button.Name = "priceGT100Button";
            this.priceGT100Button.Size = new System.Drawing.Size(100, 28);
            this.priceGT100Button.TabIndex = 7;
            this.priceGT100Button.Text = "Price > $100";
            this.priceGT100Button.UseVisualStyleBackColor = true;
            this.priceGT100Button.Click += new System.EventHandler(this.priceGT100Button_Click);
            // 
            // descriptionListBox
            // 
            this.descriptionListBox.FormattingEnabled = true;
            this.descriptionListBox.ItemHeight = 16;
            this.descriptionListBox.Location = new System.Drawing.Point(17, 14);
            this.descriptionListBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionListBox.Name = "descriptionListBox";
            this.descriptionListBox.Size = new System.Drawing.Size(207, 116);
            this.descriptionListBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 251);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.qtyLT100Button);
            this.Controls.Add(this.qtyGT100Button);
            this.Controls.Add(this.priceLT100Button);
            this.Controls.Add(this.priceGT100Button);
            this.Controls.Add(this.descriptionListBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Product Reports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button qtyLT100Button;
        private System.Windows.Forms.Button qtyGT100Button;
        private System.Windows.Forms.Button priceLT100Button;
        private System.Windows.Forms.Button priceGT100Button;
        private System.Windows.Forms.ListBox descriptionListBox;
    }
}

