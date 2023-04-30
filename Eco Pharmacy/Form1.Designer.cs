namespace Eco_Pharmacy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAdd = new Button();
            label1 = new Label();
            txtNum = new TextBox();
            txtAmount = new TextBox();
            txtPrice = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnShow = new Button();
            btnUpgrade = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.ForeColor = Color.Lime;
            btnAdd.Location = new Point(31, 661);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(108, 30);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(13, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 24);
            label1.TabIndex = 1;
            label1.Text = "Product Number";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(243, 65);
            txtNum.Margin = new Padding(4, 3, 4, 3);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(407, 23);
            txtNum.TabIndex = 2;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(243, 269);
            txtAmount.Margin = new Padding(4, 3, 4, 3);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(407, 23);
            txtAmount.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(243, 204);
            txtPrice.Margin = new Padding(4, 3, 4, 3);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(407, 23);
            txtPrice.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(243, 136);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(407, 23);
            txtName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(13, 135);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(153, 24);
            label2.TabIndex = 6;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(13, 204);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 24);
            label3.TabIndex = 7;
            label3.Text = "price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(13, 269);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 24);
            label4.TabIndex = 8;
            label4.Text = "Amount";
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.White;
            btnShow.ForeColor = Color.Black;
            btnShow.Location = new Point(187, 661);
            btnShow.Margin = new Padding(4, 3, 4, 3);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(108, 30);
            btnShow.TabIndex = 9;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // btnUpgrade
            // 
            btnUpgrade.BackColor = Color.White;
            btnUpgrade.ForeColor = Color.FromArgb(192, 192, 0);
            btnUpgrade.Location = new Point(347, 661);
            btnUpgrade.Margin = new Padding(4, 3, 4, 3);
            btnUpgrade.Name = "btnUpgrade";
            btnUpgrade.Size = new Size(108, 30);
            btnUpgrade.TabIndex = 10;
            btnUpgrade.Text = "Upgrade";
            btnUpgrade.UseVisualStyleBackColor = false;
            btnUpgrade.Click += btnUpgrade_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.WhiteSmoke;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(505, 661);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 30);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 429);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(582, 188);
            dataGridView1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.U121314ntitled_11;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 703);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpgrade);
            Controls.Add(btnShow);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(txtPrice);
            Controls.Add(txtAmount);
            Controls.Add(txtNum);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Font = new Font("Tahoma", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            Text = "Eco Pharmacy";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label label1;
        private TextBox txtNum;
        private TextBox txtAmount;
        private TextBox txtPrice;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnShow;
        private Button btnUpgrade;
        private Button btnDelete;
        private DataGridView dataGridView1;
    }
}