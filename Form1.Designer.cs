namespace Pantry_Manager
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtQuantity = new TextBox();
            dtpExpiry = new DateTimePicker();
            btnAdd = new Button();
            btnUse = new Button();
            btnExit = new Button();
            dgvInventory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 63);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 3;
            label1.Text = "Item Name";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 132);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 5;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 198);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 6;
            label4.Text = "Expiration Date";
            label4.Click += label4_Click;
            // 
            // txtName
            // 
            txtName.AccessibleName = "txtName";
            txtName.Location = new Point(229, 57);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 7;
            // 
            // txtQuantity
            // 
            txtQuantity.AccessibleName = "txtQuantity";
            txtQuantity.Location = new Point(229, 132);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(150, 31);
            txtQuantity.TabIndex = 8;
            // 
            // dtpExpiry
            // 
            dtpExpiry.Location = new Point(229, 193);
            dtpExpiry.Name = "dtpExpiry";
            dtpExpiry.Size = new Size(300, 31);
            dtpExpiry.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.AccessibleName = "btnAdd";
            btnAdd.Location = new Point(92, 250);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // btnUse
            // 
            btnUse.AccessibleName = "btnUse";
            btnUse.Location = new Point(247, 250);
            btnUse.Name = "btnUse";
            btnUse.Size = new Size(112, 34);
            btnUse.TabIndex = 11;
            btnUse.Text = "Use Item";
            btnUse.UseVisualStyleBackColor = true;
            btnUse.Click += button2_Click;
            // 
            // btnExit
            // 
            btnExit.AccessibleName = "btnExit";
            btnExit.Location = new Point(426, 250);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvInventory
            // 
            dgvInventory.AccessibleName = "dgvInventory";
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(93, 308);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.RowHeadersWidth = 62;
            dgvInventory.Size = new Size(446, 150);
            dgvInventory.TabIndex = 13;
            // 
            // Form1
            // 
            AccessibleName = "dtpExpiry";
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 482);
            Controls.Add(dgvInventory);
            Controls.Add(btnExit);
            Controls.Add(btnUse);
            Controls.Add(btnAdd);
            Controls.Add(dtpExpiry);
            Controls.Add(txtQuantity);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtQuantity;
        private DateTimePicker dtpExpiry;
        private Button btnAdd;
        private Button btnUse;
        private Button btnExit;
        private DataGridView dgvInventory;
    }
}