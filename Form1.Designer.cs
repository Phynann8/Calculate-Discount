namespace Calculate_Discount
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAmount = new TextBox();
            label1 = new Label();
            btnTotal = new Button();
            label2 = new Label();
            txtDiscount = new TextBox();
            label3 = new Label();
            txtTotal = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(314, 159);
            txtAmount.Multiline = true;
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(286, 61);
            txtAmount.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(129, 166);
            label1.Name = "label1";
            label1.Size = new Size(176, 54);
            label1.TabIndex = 1;
            label1.Text = "Amount";
            // 
            // btnTotal
            // 
            btnTotal.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTotal.Location = new Point(343, 451);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(206, 83);
            btnTotal.TabIndex = 2;
            btnTotal.Text = "Total";
            btnTotal.UseVisualStyleBackColor = true;
            btnTotal.Click += btnTotal_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(116, 261);
            label2.Name = "label2";
            label2.Size = new Size(189, 54);
            label2.TabIndex = 4;
            label2.Text = "Discount";
            // 
            // txtDiscount
            // 
            txtDiscount.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDiscount.Location = new Point(314, 254);
            txtDiscount.Multiline = true;
            txtDiscount.Name = "txtDiscount";
            txtDiscount.ReadOnly = true;
            txtDiscount.Size = new Size(286, 61);
            txtDiscount.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(190, 354);
            label3.Name = "label3";
            label3.Size = new Size(115, 54);
            label3.TabIndex = 6;
            label3.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(314, 347);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(286, 61);
            txtTotal.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(373, 78);
            label4.Name = "label4";
            label4.Size = new Size(189, 54);
            label4.TabIndex = 7;
            label4.Text = "Discount";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 591);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtTotal);
            Controls.Add(label2);
            Controls.Add(txtDiscount);
            Controls.Add(btnTotal);
            Controls.Add(label1);
            Controls.Add(txtAmount);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAmount;
        private Label label1;
        private Button btnTotal;
        private Label label2;
        private TextBox txtDiscount;
        private Label label3;
        private TextBox txtTotal;
        private Label label4;
    }
}
