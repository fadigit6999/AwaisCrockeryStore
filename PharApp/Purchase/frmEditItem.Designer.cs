namespace PharApp.Purchase
{
    partial class frmEditItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditItem));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtOrderId = new TextBox();
            txtItemCode = new TextBox();
            txtTotalQnty = new TextBox();
            txtChangeQnty = new TextBox();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            txtItem = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 65);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "&Order Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 137);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 0;
            label2.Text = "Item Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 172);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 0;
            label3.Text = "Total Qnty";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 207);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 0;
            label4.Text = "Change Qnty";
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(116, 62);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(207, 23);
            txtOrderId.TabIndex = 1;
            // 
            // txtItemCode
            // 
            txtItemCode.Location = new Point(116, 134);
            txtItemCode.Name = "txtItemCode";
            txtItemCode.Size = new Size(207, 23);
            txtItemCode.TabIndex = 3;
            // 
            // txtTotalQnty
            // 
            txtTotalQnty.Location = new Point(116, 169);
            txtTotalQnty.Name = "txtTotalQnty";
            txtTotalQnty.Size = new Size(207, 23);
            txtTotalQnty.TabIndex = 4;
            // 
            // txtChangeQnty
            // 
            txtChangeQnty.Location = new Point(116, 204);
            txtChangeQnty.Name = "txtChangeQnty";
            txtChangeQnty.Size = new Size(207, 23);
            txtChangeQnty.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(27, 239);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(25, 21);
            label5.Name = "label5";
            label5.Size = new Size(135, 21);
            label5.TabIndex = 0;
            label5.Text = "Edit Item Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 100);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 0;
            label6.Text = "&Item";
            // 
            // txtItem
            // 
            txtItem.Location = new Point(116, 97);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(207, 23);
            txtItem.TabIndex = 2;
            // 
            // frmEditItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 284);
            Controls.Add(button1);
            Controls.Add(txtChangeQnty);
            Controls.Add(txtTotalQnty);
            Controls.Add(txtItemCode);
            Controls.Add(txtItem);
            Controls.Add(txtOrderId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmEditItem";
            Text = "Edit Item Quantity";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtOrderId;
        private TextBox txtItemCode;
        private TextBox txtTotalQnty;
        private TextBox txtChangeQnty;
        private Button button1;
        private Label label5;
        private Label label6;
        private TextBox txtItem;
    }
}