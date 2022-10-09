namespace Exercise_Tables
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDrawrs = new System.Windows.Forms.TextBox();
            this.txtWoodType = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many drawrs?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type of Wood - O(ak), P(ine) or M(aple)";
            // 
            // txtDrawrs
            // 
            this.txtDrawrs.Location = new System.Drawing.Point(330, 35);
            this.txtDrawrs.Name = "txtDrawrs";
            this.txtDrawrs.Size = new System.Drawing.Size(100, 20);
            this.txtDrawrs.TabIndex = 2;
            // 
            // txtWoodType
            // 
            this.txtWoodType.Location = new System.Drawing.Point(330, 68);
            this.txtWoodType.Name = "txtWoodType";
            this.txtWoodType.Size = new System.Drawing.Size(100, 20);
            this.txtWoodType.TabIndex = 3;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(185, 136);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(113, 23);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Make an order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Location = new System.Drawing.Point(111, 191);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(0, 13);
            this.lblOrderSummary.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOrderSummary);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.txtWoodType);
            this.Controls.Add(this.txtDrawrs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDrawrs;
        private System.Windows.Forms.TextBox txtWoodType;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblOrderSummary;
    }
}

