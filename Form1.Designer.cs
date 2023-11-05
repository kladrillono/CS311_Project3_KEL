namespace CS311_Project3_KEL
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
            lblName = new Label();
            pictPizzaImage = new PictureBox();
            lblPizzaSize = new Label();
            cboPizzaSize = new ComboBox();
            lblCrust = new Label();
            grpCrust = new GroupBox();
            rdoRegular = new RadioButton();
            rdoThick = new RadioButton();
            rdoThin = new RadioButton();
            lblToppings = new Label();
            ckbPepperoni = new CheckBox();
            ckbSausage = new CheckBox();
            ckbCanadianBacon = new CheckBox();
            ckbItalianSausage = new CheckBox();
            ckbOnion = new CheckBox();
            ckbGreenPepper = new CheckBox();
            ckbBlackOlives = new CheckBox();
            ckbGreenOlives = new CheckBox();
            ckbBananaPeppers = new CheckBox();
            ckbJalapenos = new CheckBox();
            ckbExtraCheese = new CheckBox();
            ckbMushrooms = new CheckBox();
            lblOrderSummary = new Label();
            rtfOrderSummary = new RichTextBox();
            lblSubtotal = new Label();
            lblTax = new Label();
            lblTotal = new Label();
            txtSubtotal = new TextBox();
            txtTax = new TextBox();
            txtTotal = new TextBox();
            btnCalculate = new Button();
            ((System.ComponentModel.ISupportInitialize)pictPizzaImage).BeginInit();
            grpCrust.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Rockwell", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblName.Location = new Point(389, 78);
            lblName.Name = "lblName";
            lblName.Size = new Size(870, 120);
            lblName.TabIndex = 0;
            lblName.Text = "Kendall's Pizzeria";
            // 
            // pictPizzaImage
            // 
            pictPizzaImage.Image = Properties.Resources.small_pizza;
            pictPizzaImage.Location = new Point(104, 36);
            pictPizzaImage.Name = "pictPizzaImage";
            pictPizzaImage.Size = new Size(254, 202);
            pictPizzaImage.TabIndex = 1;
            pictPizzaImage.TabStop = false;
            // 
            // lblPizzaSize
            // 
            lblPizzaSize.AutoSize = true;
            lblPizzaSize.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblPizzaSize.Location = new Point(40, 277);
            lblPizzaSize.Name = "lblPizzaSize";
            lblPizzaSize.Size = new Size(250, 37);
            lblPizzaSize.TabIndex = 2;
            lblPizzaSize.Text = "Choose your size:";
            // 
            // cboPizzaSize
            // 
            cboPizzaSize.FormattingEnabled = true;
            cboPizzaSize.Items.AddRange(new object[] { "Small", "Medium", "Large", "X-Large", "Ginormous" });
            cboPizzaSize.Location = new Point(300, 278);
            cboPizzaSize.Name = "cboPizzaSize";
            cboPizzaSize.Size = new Size(242, 40);
            cboPizzaSize.TabIndex = 3;
            // 
            // lblCrust
            // 
            lblCrust.AutoSize = true;
            lblCrust.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblCrust.Location = new Point(548, 281);
            lblCrust.Name = "lblCrust";
            lblCrust.Size = new Size(169, 37);
            lblCrust.TabIndex = 4;
            lblCrust.Text = "Crust Type:";
            // 
            // grpCrust
            // 
            grpCrust.Controls.Add(rdoRegular);
            grpCrust.Controls.Add(rdoThick);
            grpCrust.Controls.Add(rdoThin);
            grpCrust.Location = new Point(723, 263);
            grpCrust.Name = "grpCrust";
            grpCrust.Size = new Size(494, 84);
            grpCrust.TabIndex = 5;
            grpCrust.TabStop = false;
            // 
            // rdoRegular
            // 
            rdoRegular.AutoSize = true;
            rdoRegular.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rdoRegular.Location = new Point(272, 20);
            rdoRegular.Name = "rdoRegular";
            rdoRegular.Size = new Size(132, 36);
            rdoRegular.TabIndex = 2;
            rdoRegular.TabStop = true;
            rdoRegular.Text = "Regular";
            rdoRegular.UseVisualStyleBackColor = true;
            // 
            // rdoThick
            // 
            rdoThick.AutoSize = true;
            rdoThick.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rdoThick.Location = new Point(146, 20);
            rdoThick.Name = "rdoThick";
            rdoThick.Size = new Size(105, 36);
            rdoThick.TabIndex = 1;
            rdoThick.TabStop = true;
            rdoThick.Text = "Thick";
            rdoThick.UseVisualStyleBackColor = true;
            // 
            // rdoThin
            // 
            rdoThin.AutoSize = true;
            rdoThin.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rdoThin.Location = new Point(28, 20);
            rdoThin.Name = "rdoThin";
            rdoThin.Size = new Size(95, 36);
            rdoThin.TabIndex = 0;
            rdoThin.TabStop = true;
            rdoThin.Text = "Thin";
            rdoThin.UseVisualStyleBackColor = true;
            // 
            // lblToppings
            // 
            lblToppings.AutoSize = true;
            lblToppings.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblToppings.Location = new Point(40, 353);
            lblToppings.Name = "lblToppings";
            lblToppings.Size = new Size(149, 37);
            lblToppings.TabIndex = 6;
            lblToppings.Text = "Toppings:";
            // 
            // ckbPepperoni
            // 
            ckbPepperoni.AutoSize = true;
            ckbPepperoni.Location = new Point(59, 402);
            ckbPepperoni.Name = "ckbPepperoni";
            ckbPepperoni.Size = new Size(154, 36);
            ckbPepperoni.TabIndex = 7;
            ckbPepperoni.Text = "Pepperoni";
            ckbPepperoni.UseVisualStyleBackColor = true;
            // 
            // ckbSausage
            // 
            ckbSausage.AutoSize = true;
            ckbSausage.Location = new Point(59, 444);
            ckbSausage.Name = "ckbSausage";
            ckbSausage.Size = new Size(134, 36);
            ckbSausage.TabIndex = 8;
            ckbSausage.Text = "Sausage";
            ckbSausage.UseVisualStyleBackColor = true;
            // 
            // ckbCanadianBacon
            // 
            ckbCanadianBacon.AutoSize = true;
            ckbCanadianBacon.Location = new Point(59, 486);
            ckbCanadianBacon.Name = "ckbCanadianBacon";
            ckbCanadianBacon.Size = new Size(217, 36);
            ckbCanadianBacon.TabIndex = 9;
            ckbCanadianBacon.Text = "Canadian Bacon";
            ckbCanadianBacon.UseVisualStyleBackColor = true;
            // 
            // ckbItalianSausage
            // 
            ckbItalianSausage.AutoSize = true;
            ckbItalianSausage.Location = new Point(59, 528);
            ckbItalianSausage.Name = "ckbItalianSausage";
            ckbItalianSausage.Size = new Size(268, 36);
            ckbItalianSausage.TabIndex = 10;
            ckbItalianSausage.Text = "Spicy Italian Sausage";
            ckbItalianSausage.UseVisualStyleBackColor = true;
            // 
            // ckbOnion
            // 
            ckbOnion.AutoSize = true;
            ckbOnion.Location = new Point(366, 402);
            ckbOnion.Name = "ckbOnion";
            ckbOnion.Size = new Size(112, 36);
            ckbOnion.TabIndex = 11;
            ckbOnion.Text = "Onion";
            ckbOnion.UseVisualStyleBackColor = true;
            // 
            // ckbGreenPepper
            // 
            ckbGreenPepper.AutoSize = true;
            ckbGreenPepper.Location = new Point(366, 444);
            ckbGreenPepper.Name = "ckbGreenPepper";
            ckbGreenPepper.Size = new Size(191, 36);
            ckbGreenPepper.TabIndex = 12;
            ckbGreenPepper.Text = "Green Pepper";
            ckbGreenPepper.UseVisualStyleBackColor = true;
            // 
            // ckbBlackOlives
            // 
            ckbBlackOlives.AutoSize = true;
            ckbBlackOlives.Location = new Point(366, 486);
            ckbBlackOlives.Name = "ckbBlackOlives";
            ckbBlackOlives.Size = new Size(173, 36);
            ckbBlackOlives.TabIndex = 13;
            ckbBlackOlives.Text = "Black Olives";
            ckbBlackOlives.UseVisualStyleBackColor = true;
            // 
            // ckbGreenOlives
            // 
            ckbGreenOlives.AutoSize = true;
            ckbGreenOlives.Location = new Point(366, 528);
            ckbGreenOlives.Name = "ckbGreenOlives";
            ckbGreenOlives.Size = new Size(182, 36);
            ckbGreenOlives.TabIndex = 14;
            ckbGreenOlives.Text = "Green Olives";
            ckbGreenOlives.UseVisualStyleBackColor = true;
            // 
            // ckbBananaPeppers
            // 
            ckbBananaPeppers.AutoSize = true;
            ckbBananaPeppers.Location = new Point(631, 402);
            ckbBananaPeppers.Name = "ckbBananaPeppers";
            ckbBananaPeppers.Size = new Size(215, 36);
            ckbBananaPeppers.TabIndex = 15;
            ckbBananaPeppers.Text = "Banana Peppers";
            ckbBananaPeppers.UseVisualStyleBackColor = true;
            // 
            // ckbJalapenos
            // 
            ckbJalapenos.AutoSize = true;
            ckbJalapenos.Location = new Point(631, 444);
            ckbJalapenos.Name = "ckbJalapenos";
            ckbJalapenos.Size = new Size(150, 36);
            ckbJalapenos.TabIndex = 16;
            ckbJalapenos.Text = "Jalapenos";
            ckbJalapenos.UseVisualStyleBackColor = true;
            // 
            // ckbExtraCheese
            // 
            ckbExtraCheese.AutoSize = true;
            ckbExtraCheese.Location = new Point(631, 486);
            ckbExtraCheese.Name = "ckbExtraCheese";
            ckbExtraCheese.Size = new Size(182, 36);
            ckbExtraCheese.TabIndex = 17;
            ckbExtraCheese.Text = "Extra Cheese";
            ckbExtraCheese.UseVisualStyleBackColor = true;
            // 
            // ckbMushrooms
            // 
            ckbMushrooms.AutoSize = true;
            ckbMushrooms.Location = new Point(631, 528);
            ckbMushrooms.Name = "ckbMushrooms";
            ckbMushrooms.Size = new Size(173, 36);
            ckbMushrooms.TabIndex = 18;
            ckbMushrooms.Text = "Mushrooms";
            ckbMushrooms.UseVisualStyleBackColor = true;
            // 
            // lblOrderSummary
            // 
            lblOrderSummary.AutoSize = true;
            lblOrderSummary.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrderSummary.Location = new Point(40, 576);
            lblOrderSummary.Name = "lblOrderSummary";
            lblOrderSummary.Size = new Size(238, 37);
            lblOrderSummary.TabIndex = 19;
            lblOrderSummary.Text = "Order Summary:";
            // 
            // rtfOrderSummary
            // 
            rtfOrderSummary.Location = new Point(59, 626);
            rtfOrderSummary.Name = "rtfOrderSummary";
            rtfOrderSummary.Size = new Size(832, 337);
            rtfOrderSummary.TabIndex = 20;
            rtfOrderSummary.Text = "";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubtotal.Location = new Point(917, 629);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(137, 37);
            lblSubtotal.TabIndex = 21;
            lblSubtotal.Text = "Subtotal:";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblTax.Location = new Point(979, 694);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(75, 37);
            lblTax.TabIndex = 22;
            lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(960, 763);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(94, 37);
            lblTotal.TabIndex = 23;
            lblTotal.Text = "Total:";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(1071, 626);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(200, 39);
            txtSubtotal.TabIndex = 24;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(1071, 692);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(200, 39);
            txtTax.TabIndex = 25;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(1071, 761);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(200, 39);
            txtTotal.TabIndex = 26;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculate.Location = new Point(995, 883);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(286, 80);
            btnCalculate.TabIndex = 27;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 1009);
            Controls.Add(btnCalculate);
            Controls.Add(txtTotal);
            Controls.Add(txtTax);
            Controls.Add(txtSubtotal);
            Controls.Add(lblTotal);
            Controls.Add(lblTax);
            Controls.Add(lblSubtotal);
            Controls.Add(rtfOrderSummary);
            Controls.Add(lblOrderSummary);
            Controls.Add(ckbMushrooms);
            Controls.Add(ckbExtraCheese);
            Controls.Add(ckbJalapenos);
            Controls.Add(ckbBananaPeppers);
            Controls.Add(ckbGreenOlives);
            Controls.Add(ckbBlackOlives);
            Controls.Add(ckbGreenPepper);
            Controls.Add(ckbOnion);
            Controls.Add(ckbItalianSausage);
            Controls.Add(ckbCanadianBacon);
            Controls.Add(ckbSausage);
            Controls.Add(ckbPepperoni);
            Controls.Add(lblToppings);
            Controls.Add(grpCrust);
            Controls.Add(lblCrust);
            Controls.Add(cboPizzaSize);
            Controls.Add(lblPizzaSize);
            Controls.Add(pictPizzaImage);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Kendall's Pizzeria ";
            ((System.ComponentModel.ISupportInitialize)pictPizzaImage).EndInit();
            grpCrust.ResumeLayout(false);
            grpCrust.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private PictureBox pictPizzaImage;
        private Label lblPizzaSize;
        private ComboBox cboPizzaSize;
        private Label lblCrust;
        private GroupBox grpCrust;
        private RadioButton rdoRegular;
        private RadioButton rdoThick;
        private RadioButton rdoThin;
        private Label lblToppings;
        private CheckBox ckbPepperoni;
        private CheckBox ckbSausage;
        private CheckBox ckbCanadianBacon;
        private CheckBox ckbItalianSausage;
        private CheckBox ckbOnion;
        private CheckBox ckbGreenPepper;
        private CheckBox ckbBlackOlives;
        private CheckBox ckbGreenOlives;
        private CheckBox ckbBananaPeppers;
        private CheckBox ckbJalapenos;
        private CheckBox ckbExtraCheese;
        private CheckBox ckbMushrooms;
        private Label lblOrderSummary;
        private RichTextBox rtfOrderSummary;
        private Label lblSubtotal;
        private Label lblTax;
        private Label lblTotal;
        private TextBox txtSubtotal;
        private TextBox txtTax;
        private TextBox txtTotal;
        private Button btnCalculate;
    }
}