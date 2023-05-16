namespace GiftBasket
{
    partial class TetGiftBasket
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbITetGiftBasket = new System.Windows.Forms.Label();
            this.cbITetGiftBasket = new System.Windows.Forms.ComboBox();
            this.lbSnacks = new System.Windows.Forms.Label();
            this.cbNameSnacks = new System.Windows.Forms.ComboBox();
            this.lbNameSnacks = new System.Windows.Forms.Label();
            this.lbPriceSnacks = new System.Windows.Forms.Label();
            this.lbSnacksAmount = new System.Windows.Forms.Label();
            this.lbKindsOfSpice = new System.Windows.Forms.Label();
            this.lbAmountKindsOfSpice = new System.Windows.Forms.Label();
            this.lbPriceKindsOfSpice = new System.Windows.Forms.Label();
            this.lbNameKindsOfSpice = new System.Windows.Forms.Label();
            this.cbNameKindsOfSpice = new System.Windows.Forms.ComboBox();
            this.lbWine = new System.Windows.Forms.Label();
            this.lbAmountFFoods = new System.Windows.Forms.Label();
            this.lbPriceFFoods = new System.Windows.Forms.Label();
            this.lbNameFFoods = new System.Windows.Forms.Label();
            this.cbNameFFoods = new System.Windows.Forms.ComboBox();
            this.lbFunctionsFoods = new System.Windows.Forms.Label();
            this.lbAmountWine = new System.Windows.Forms.Label();
            this.lbPriceWine = new System.Windows.Forms.Label();
            this.txtPriceSnacks = new System.Windows.Forms.TextBox();
            this.txtAmountSnacks = new System.Windows.Forms.TextBox();
            this.txtPriceKindsOfSpice = new System.Windows.Forms.TextBox();
            this.txtAmountKindsOfSpice = new System.Windows.Forms.TextBox();
            this.txtPriceWine = new System.Windows.Forms.TextBox();
            this.txtAmountWine = new System.Windows.Forms.TextBox();
            this.txtAmountFFoods = new System.Windows.Forms.TextBox();
            this.txtPriceFFoods = new System.Windows.Forms.TextBox();
            this.dgvGiftBasket = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiftBasket)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.Location = new System.Drawing.Point(174, 688);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 50);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbITetGiftBasket
            // 
            this.lbITetGiftBasket.AutoSize = true;
            this.lbITetGiftBasket.Location = new System.Drawing.Point(42, 31);
            this.lbITetGiftBasket.Name = "lbITetGiftBasket";
            this.lbITetGiftBasket.Size = new System.Drawing.Size(165, 25);
            this.lbITetGiftBasket.TabIndex = 1;
            this.lbITetGiftBasket.Text = "ITetGiftBasket : ";
            this.lbITetGiftBasket.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbITetGiftBasket
            // 
            this.cbITetGiftBasket.FormattingEnabled = true;
            this.cbITetGiftBasket.Items.AddRange(new object[] {
            "Tet Gift Basket",
            "Warm Gift Basket",
            "Health Gift Basket"});
            this.cbITetGiftBasket.Location = new System.Drawing.Point(258, 28);
            this.cbITetGiftBasket.Name = "cbITetGiftBasket";
            this.cbITetGiftBasket.Size = new System.Drawing.Size(211, 33);
            this.cbITetGiftBasket.TabIndex = 3;
            this.cbITetGiftBasket.SelectedIndexChanged += new System.EventHandler(this.cbITetGiftBasket_SelectedIndexChanged);
            // 
            // lbSnacks
            // 
            this.lbSnacks.AutoSize = true;
            this.lbSnacks.Location = new System.Drawing.Point(33, 157);
            this.lbSnacks.Name = "lbSnacks";
            this.lbSnacks.Size = new System.Drawing.Size(89, 25);
            this.lbSnacks.TabIndex = 4;
            this.lbSnacks.Text = "Snacks ";
            this.lbSnacks.Click += new System.EventHandler(this.lbSnacks_Click);
            // 
            // cbNameSnacks
            // 
            this.cbNameSnacks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbNameSnacks.FormattingEnabled = true;
            this.cbNameSnacks.Items.AddRange(new object[] {
            "Candy",
            "Cake",
            "Dried Fruit"});
            this.cbNameSnacks.Location = new System.Drawing.Point(145, 211);
            this.cbNameSnacks.Name = "cbNameSnacks";
            this.cbNameSnacks.Size = new System.Drawing.Size(173, 33);
            this.cbNameSnacks.TabIndex = 5;
            this.cbNameSnacks.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            // 
            // lbNameSnacks
            // 
            this.lbNameSnacks.AutoSize = true;
            this.lbNameSnacks.Location = new System.Drawing.Point(33, 222);
            this.lbNameSnacks.Name = "lbNameSnacks";
            this.lbNameSnacks.Size = new System.Drawing.Size(86, 25);
            this.lbNameSnacks.TabIndex = 6;
            this.lbNameSnacks.Text = "Name : ";
            // 
            // lbPriceSnacks
            // 
            this.lbPriceSnacks.AutoSize = true;
            this.lbPriceSnacks.Location = new System.Drawing.Point(33, 286);
            this.lbPriceSnacks.Name = "lbPriceSnacks";
            this.lbPriceSnacks.Size = new System.Drawing.Size(73, 25);
            this.lbPriceSnacks.TabIndex = 7;
            this.lbPriceSnacks.Text = "Price :";
            this.lbPriceSnacks.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbSnacksAmount
            // 
            this.lbSnacksAmount.AutoSize = true;
            this.lbSnacksAmount.Location = new System.Drawing.Point(33, 341);
            this.lbSnacksAmount.Name = "lbSnacksAmount";
            this.lbSnacksAmount.Size = new System.Drawing.Size(97, 25);
            this.lbSnacksAmount.TabIndex = 8;
            this.lbSnacksAmount.Text = "Amount :";
            // 
            // lbKindsOfSpice
            // 
            this.lbKindsOfSpice.AutoSize = true;
            this.lbKindsOfSpice.Location = new System.Drawing.Point(382, 157);
            this.lbKindsOfSpice.Name = "lbKindsOfSpice";
            this.lbKindsOfSpice.Size = new System.Drawing.Size(142, 25);
            this.lbKindsOfSpice.TabIndex = 9;
            this.lbKindsOfSpice.Text = "KindsOfSpice";
            // 
            // lbAmountKindsOfSpice
            // 
            this.lbAmountKindsOfSpice.AutoSize = true;
            this.lbAmountKindsOfSpice.Location = new System.Drawing.Point(373, 341);
            this.lbAmountKindsOfSpice.Name = "lbAmountKindsOfSpice";
            this.lbAmountKindsOfSpice.Size = new System.Drawing.Size(97, 25);
            this.lbAmountKindsOfSpice.TabIndex = 13;
            this.lbAmountKindsOfSpice.Text = "Amount :";
            // 
            // lbPriceKindsOfSpice
            // 
            this.lbPriceKindsOfSpice.AutoSize = true;
            this.lbPriceKindsOfSpice.Location = new System.Drawing.Point(375, 283);
            this.lbPriceKindsOfSpice.Name = "lbPriceKindsOfSpice";
            this.lbPriceKindsOfSpice.Size = new System.Drawing.Size(73, 25);
            this.lbPriceKindsOfSpice.TabIndex = 12;
            this.lbPriceKindsOfSpice.Text = "Price :";
            // 
            // lbNameKindsOfSpice
            // 
            this.lbNameKindsOfSpice.AutoSize = true;
            this.lbNameKindsOfSpice.Location = new System.Drawing.Point(375, 219);
            this.lbNameKindsOfSpice.Name = "lbNameKindsOfSpice";
            this.lbNameKindsOfSpice.Size = new System.Drawing.Size(86, 25);
            this.lbNameKindsOfSpice.TabIndex = 11;
            this.lbNameKindsOfSpice.Text = "Name : ";
            // 
            // cbNameKindsOfSpice
            // 
            this.cbNameKindsOfSpice.FormattingEnabled = true;
            this.cbNameKindsOfSpice.Items.AddRange(new object[] {
            "Fish sauce",
            "Salt",
            "Broth mix ",
            "Monosodium glutamate"});
            this.cbNameKindsOfSpice.Location = new System.Drawing.Point(491, 216);
            this.cbNameKindsOfSpice.Name = "cbNameKindsOfSpice";
            this.cbNameKindsOfSpice.Size = new System.Drawing.Size(173, 33);
            this.cbNameKindsOfSpice.TabIndex = 10;
            // 
            // lbWine
            // 
            this.lbWine.AutoSize = true;
            this.lbWine.Location = new System.Drawing.Point(45, 450);
            this.lbWine.Name = "lbWine";
            this.lbWine.Size = new System.Drawing.Size(61, 25);
            this.lbWine.TabIndex = 14;
            this.lbWine.Text = "Wine";
            // 
            // lbAmountFFoods
            // 
            this.lbAmountFFoods.AutoSize = true;
            this.lbAmountFFoods.Location = new System.Drawing.Point(375, 625);
            this.lbAmountFFoods.Name = "lbAmountFFoods";
            this.lbAmountFFoods.Size = new System.Drawing.Size(97, 25);
            this.lbAmountFFoods.TabIndex = 18;
            this.lbAmountFFoods.Text = "Amount :";
            // 
            // lbPriceFFoods
            // 
            this.lbPriceFFoods.AutoSize = true;
            this.lbPriceFFoods.Location = new System.Drawing.Point(375, 570);
            this.lbPriceFFoods.Name = "lbPriceFFoods";
            this.lbPriceFFoods.Size = new System.Drawing.Size(73, 25);
            this.lbPriceFFoods.TabIndex = 17;
            this.lbPriceFFoods.Text = "Price :";
            // 
            // lbNameFFoods
            // 
            this.lbNameFFoods.AutoSize = true;
            this.lbNameFFoods.Location = new System.Drawing.Point(375, 506);
            this.lbNameFFoods.Name = "lbNameFFoods";
            this.lbNameFFoods.Size = new System.Drawing.Size(86, 25);
            this.lbNameFFoods.TabIndex = 16;
            this.lbNameFFoods.Text = "Name : ";
            // 
            // cbNameFFoods
            // 
            this.cbNameFFoods.FormattingEnabled = true;
            this.cbNameFFoods.Items.AddRange(new object[] {
            "DHC",
            "BlackMores",
            "GH Creation EX"});
            this.cbNameFFoods.Location = new System.Drawing.Point(491, 503);
            this.cbNameFFoods.Name = "cbNameFFoods";
            this.cbNameFFoods.Size = new System.Drawing.Size(173, 33);
            this.cbNameFFoods.TabIndex = 15;
            // 
            // lbFunctionsFoods
            // 
            this.lbFunctionsFoods.AutoSize = true;
            this.lbFunctionsFoods.Location = new System.Drawing.Point(373, 450);
            this.lbFunctionsFoods.Name = "lbFunctionsFoods";
            this.lbFunctionsFoods.Size = new System.Drawing.Size(172, 25);
            this.lbFunctionsFoods.TabIndex = 19;
            this.lbFunctionsFoods.Text = "FunctionalFoods";
            // 
            // lbAmountWine
            // 
            this.lbAmountWine.AutoSize = true;
            this.lbAmountWine.Location = new System.Drawing.Point(45, 566);
            this.lbAmountWine.Name = "lbAmountWine";
            this.lbAmountWine.Size = new System.Drawing.Size(97, 25);
            this.lbAmountWine.TabIndex = 21;
            this.lbAmountWine.Text = "Amount :";
            // 
            // lbPriceWine
            // 
            this.lbPriceWine.AutoSize = true;
            this.lbPriceWine.Location = new System.Drawing.Point(45, 511);
            this.lbPriceWine.Name = "lbPriceWine";
            this.lbPriceWine.Size = new System.Drawing.Size(73, 25);
            this.lbPriceWine.TabIndex = 20;
            this.lbPriceWine.Text = "Price :";
            // 
            // txtPriceSnacks
            // 
            this.txtPriceSnacks.Location = new System.Drawing.Point(145, 280);
            this.txtPriceSnacks.Name = "txtPriceSnacks";
            this.txtPriceSnacks.Size = new System.Drawing.Size(173, 31);
            this.txtPriceSnacks.TabIndex = 22;
            this.txtPriceSnacks.TextChanged += new System.EventHandler(this.txtPriceSnacks_TextChanged);
            // 
            // txtAmountSnacks
            // 
            this.txtAmountSnacks.Location = new System.Drawing.Point(145, 335);
            this.txtAmountSnacks.Name = "txtAmountSnacks";
            this.txtAmountSnacks.Size = new System.Drawing.Size(175, 31);
            this.txtAmountSnacks.TabIndex = 23;
            // 
            // txtPriceKindsOfSpice
            // 
            this.txtPriceKindsOfSpice.Location = new System.Drawing.Point(491, 280);
            this.txtPriceKindsOfSpice.Name = "txtPriceKindsOfSpice";
            this.txtPriceKindsOfSpice.Size = new System.Drawing.Size(173, 31);
            this.txtPriceKindsOfSpice.TabIndex = 24;
            // 
            // txtAmountKindsOfSpice
            // 
            this.txtAmountKindsOfSpice.Location = new System.Drawing.Point(491, 341);
            this.txtAmountKindsOfSpice.Name = "txtAmountKindsOfSpice";
            this.txtAmountKindsOfSpice.Size = new System.Drawing.Size(173, 31);
            this.txtAmountKindsOfSpice.TabIndex = 25;
            // 
            // txtPriceWine
            // 
            this.txtPriceWine.Location = new System.Drawing.Point(145, 506);
            this.txtPriceWine.Name = "txtPriceWine";
            this.txtPriceWine.Size = new System.Drawing.Size(173, 31);
            this.txtPriceWine.TabIndex = 26;
            // 
            // txtAmountWine
            // 
            this.txtAmountWine.Location = new System.Drawing.Point(147, 564);
            this.txtAmountWine.Name = "txtAmountWine";
            this.txtAmountWine.Size = new System.Drawing.Size(173, 31);
            this.txtAmountWine.TabIndex = 27;
            // 
            // txtAmountFFoods
            // 
            this.txtAmountFFoods.Location = new System.Drawing.Point(491, 625);
            this.txtAmountFFoods.Name = "txtAmountFFoods";
            this.txtAmountFFoods.Size = new System.Drawing.Size(173, 31);
            this.txtAmountFFoods.TabIndex = 28;
            // 
            // txtPriceFFoods
            // 
            this.txtPriceFFoods.Location = new System.Drawing.Point(491, 570);
            this.txtPriceFFoods.Name = "txtPriceFFoods";
            this.txtPriceFFoods.Size = new System.Drawing.Size(173, 31);
            this.txtPriceFFoods.TabIndex = 29;
            // 
            // dgvGiftBasket
            // 
            this.dgvGiftBasket.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvGiftBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiftBasket.Location = new System.Drawing.Point(710, 211);
            this.dgvGiftBasket.Name = "dgvGiftBasket";
            this.dgvGiftBasket.RowHeadersWidth = 82;
            this.dgvGiftBasket.RowTemplate.Height = 33;
            this.dgvGiftBasket.Size = new System.Drawing.Size(666, 449);
            this.dgvGiftBasket.TabIndex = 30;
            this.dgvGiftBasket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiftBasket_CellContentClick_1);
            // 
            // TetGiftBasket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1426, 767);
            this.Controls.Add(this.dgvGiftBasket);
            this.Controls.Add(this.txtPriceFFoods);
            this.Controls.Add(this.txtAmountFFoods);
            this.Controls.Add(this.txtAmountWine);
            this.Controls.Add(this.txtPriceWine);
            this.Controls.Add(this.txtAmountKindsOfSpice);
            this.Controls.Add(this.txtPriceKindsOfSpice);
            this.Controls.Add(this.txtAmountSnacks);
            this.Controls.Add(this.txtPriceSnacks);
            this.Controls.Add(this.lbAmountWine);
            this.Controls.Add(this.lbPriceWine);
            this.Controls.Add(this.lbFunctionsFoods);
            this.Controls.Add(this.lbAmountFFoods);
            this.Controls.Add(this.lbPriceFFoods);
            this.Controls.Add(this.lbNameFFoods);
            this.Controls.Add(this.cbNameFFoods);
            this.Controls.Add(this.lbWine);
            this.Controls.Add(this.lbAmountKindsOfSpice);
            this.Controls.Add(this.lbPriceKindsOfSpice);
            this.Controls.Add(this.lbNameKindsOfSpice);
            this.Controls.Add(this.cbNameKindsOfSpice);
            this.Controls.Add(this.lbKindsOfSpice);
            this.Controls.Add(this.lbSnacksAmount);
            this.Controls.Add(this.lbPriceSnacks);
            this.Controls.Add(this.lbNameSnacks);
            this.Controls.Add(this.cbNameSnacks);
            this.Controls.Add(this.lbSnacks);
            this.Controls.Add(this.cbITetGiftBasket);
            this.Controls.Add(this.lbITetGiftBasket);
            this.Controls.Add(this.btnAdd);
            this.Name = "TetGiftBasket";
            this.Text = "Tet Gift Basket";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiftBasket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbITetGiftBasket;
        private System.Windows.Forms.ComboBox cbITetGiftBasket;
        private System.Windows.Forms.Label lbSnacks;
        private System.Windows.Forms.ComboBox cbNameSnacks;
        private System.Windows.Forms.Label lbNameSnacks;
        private System.Windows.Forms.Label lbPriceSnacks;
        private System.Windows.Forms.Label lbSnacksAmount;
        private System.Windows.Forms.Label lbKindsOfSpice;
        private System.Windows.Forms.Label lbAmountKindsOfSpice;
        private System.Windows.Forms.Label lbPriceKindsOfSpice;
        private System.Windows.Forms.Label lbNameKindsOfSpice;
        private System.Windows.Forms.ComboBox cbNameKindsOfSpice;
        private System.Windows.Forms.Label lbWine;
        private System.Windows.Forms.Label lbAmountFFoods;
        private System.Windows.Forms.Label lbPriceFFoods;
        private System.Windows.Forms.Label lbNameFFoods;
        private System.Windows.Forms.ComboBox cbNameFFoods;
        private System.Windows.Forms.Label lbFunctionsFoods;
        private System.Windows.Forms.Label lbAmountWine;
        private System.Windows.Forms.Label lbPriceWine;
        private System.Windows.Forms.TextBox txtPriceSnacks;
        private System.Windows.Forms.TextBox txtAmountSnacks;
        private System.Windows.Forms.TextBox txtPriceKindsOfSpice;
        private System.Windows.Forms.TextBox txtAmountKindsOfSpice;
        private System.Windows.Forms.TextBox txtPriceWine;
        private System.Windows.Forms.TextBox txtAmountWine;
        private System.Windows.Forms.TextBox txtAmountFFoods;
        private System.Windows.Forms.TextBox txtPriceFFoods;
        private System.Windows.Forms.DataGridView dgvGiftBasket;
    }
}

