
namespace CashRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sandwichStoreLabel = new System.Windows.Forms.Label();
            this.turkeyLabel = new System.Windows.Forms.Label();
            this.veggieLabel = new System.Windows.Forms.Label();
            this.drinksLabel = new System.Windows.Forms.Label();
            this.turkeyInput = new System.Windows.Forms.TextBox();
            this.veggieInput = new System.Windows.Forms.TextBox();
            this.drinkInput = new System.Windows.Forms.TextBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sandwichStoreLabel
            // 
            this.sandwichStoreLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sandwichStoreLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sandwichStoreLabel.ForeColor = System.Drawing.Color.Gold;
            this.sandwichStoreLabel.Location = new System.Drawing.Point(-2, -1);
            this.sandwichStoreLabel.Name = "sandwichStoreLabel";
            this.sandwichStoreLabel.Size = new System.Drawing.Size(897, 80);
            this.sandwichStoreLabel.TabIndex = 0;
            this.sandwichStoreLabel.Text = "Sandwich Store";
            this.sandwichStoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // turkeyLabel
            // 
            this.turkeyLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turkeyLabel.Location = new System.Drawing.Point(5, 88);
            this.turkeyLabel.Name = "turkeyLabel";
            this.turkeyLabel.Size = new System.Drawing.Size(343, 57);
            this.turkeyLabel.TabIndex = 1;
            this.turkeyLabel.Text = "Turkey Sandwiches Ordered:";
            // 
            // veggieLabel
            // 
            this.veggieLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veggieLabel.Location = new System.Drawing.Point(5, 136);
            this.veggieLabel.Name = "veggieLabel";
            this.veggieLabel.Size = new System.Drawing.Size(367, 57);
            this.veggieLabel.TabIndex = 2;
            this.veggieLabel.Text = "Veggie Sandwiches Ordered:";
            // 
            // drinksLabel
            // 
            this.drinksLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksLabel.Location = new System.Drawing.Point(5, 183);
            this.drinksLabel.Name = "drinksLabel";
            this.drinksLabel.Size = new System.Drawing.Size(367, 57);
            this.drinksLabel.TabIndex = 3;
            this.drinksLabel.Text = "Number of Drinks:";
            // 
            // turkeyInput
            // 
            this.turkeyInput.Location = new System.Drawing.Point(354, 94);
            this.turkeyInput.Name = "turkeyInput";
            this.turkeyInput.Size = new System.Drawing.Size(100, 26);
            this.turkeyInput.TabIndex = 4;
            // 
            // veggieInput
            // 
            this.veggieInput.Location = new System.Drawing.Point(354, 142);
            this.veggieInput.Name = "veggieInput";
            this.veggieInput.Size = new System.Drawing.Size(100, 26);
            this.veggieInput.TabIndex = 5;
            // 
            // drinkInput
            // 
            this.drinkInput.Location = new System.Drawing.Point(354, 189);
            this.drinkInput.Name = "drinkInput";
            this.drinkInput.Size = new System.Drawing.Size(100, 26);
            this.drinkInput.TabIndex = 6;
            // 
            // totalButton
            // 
            this.totalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.totalButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.totalButton.FlatAppearance.BorderSize = 2;
            this.totalButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.totalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.totalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.ForeColor = System.Drawing.Color.Gold;
            this.totalButton.Location = new System.Drawing.Point(15, 226);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(439, 79);
            this.totalButton.TabIndex = 7;
            this.totalButton.Text = "Calculate Total Cost";
            this.totalButton.UseVisualStyleBackColor = false;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.Location = new System.Drawing.Point(12, 316);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(471, 104);
            this.totalCostLabel.TabIndex = 8;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(5, 428);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(143, 57);
            this.tenderedLabel.TabIndex = 9;
            this.tenderedLabel.Text = "Tendered:";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(136, 434);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(100, 26);
            this.tenderedInput.TabIndex = 10;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.changeButton.Enabled = false;
            this.changeButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.changeButton.FlatAppearance.BorderSize = 2;
            this.changeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.changeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.Color.Gold;
            this.changeButton.Location = new System.Drawing.Point(253, 423);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(201, 51);
            this.changeButton.TabIndex = 11;
            this.changeButton.Text = "Get Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(12, 485);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(526, 51);
            this.changeLabel.TabIndex = 12;
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.printButton.Enabled = false;
            this.printButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.printButton.FlatAppearance.BorderSize = 2;
            this.printButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.printButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.Color.Gold;
            this.printButton.Location = new System.Drawing.Point(10, 539);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(444, 68);
            this.printButton.TabIndex = 13;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.Color.White;
            this.receiptLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.ForeColor = System.Drawing.Color.Black;
            this.receiptLabel.Location = new System.Drawing.Point(529, 94);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(333, 442);
            this.receiptLabel.TabIndex = 14;
            this.receiptLabel.Visible = false;
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.newOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.newOrderButton.FlatAppearance.BorderSize = 2;
            this.newOrderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.newOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.ForeColor = System.Drawing.Color.Gold;
            this.newOrderButton.Location = new System.Drawing.Point(529, 544);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(333, 63);
            this.newOrderButton.TabIndex = 15;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Visible = false;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(896, 609);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.drinkInput);
            this.Controls.Add(this.veggieInput);
            this.Controls.Add(this.turkeyInput);
            this.Controls.Add(this.drinksLabel);
            this.Controls.Add(this.veggieLabel);
            this.Controls.Add(this.turkeyLabel);
            this.Controls.Add(this.sandwichStoreLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sandwich Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sandwichStoreLabel;
        private System.Windows.Forms.Label turkeyLabel;
        private System.Windows.Forms.Label veggieLabel;
        private System.Windows.Forms.Label drinksLabel;
        private System.Windows.Forms.TextBox turkeyInput;
        private System.Windows.Forms.TextBox veggieInput;
        private System.Windows.Forms.TextBox drinkInput;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Button newOrderButton;
    }
}

