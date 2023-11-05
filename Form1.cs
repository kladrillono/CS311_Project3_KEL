namespace CS311_Project3_KEL
{
    public partial class Form1 : Form
    {
        double small = 2.00;
        double medium = 5.00;
        double large = 10.00;
        double xLarge = 15.00;
        double ginormous = 20.00;
        double pepperoni = 2.00;
        double sausage = 2.00;
        double canadianBacon = 2.00;
        double spicyItalianSausage = 2.00;
        double onion = 1.00;
        double greenPepper = 1.00;
        double blackOlives = 1.00;
        double greenOlives = 1.00;
        double bananaPeppers = 1.00;
        double jalapenos = 1.00;
        double extraCheese = 1.00;
        double mushrooms = 1.00;

        public Form1()
        {
            InitializeComponent();
        }

        /*Click method to collect user's pizza options and calls Summarize method to calculate
         * totals. */
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /*Pulls user's pizza size. */
            String sizeChoice = cboPizzaSize.GetItemText(cboPizzaSize.Text);
            rtfOrderSummary.Text = "You ordered a " + sizeChoice + " pizza ";

            /*Statement that determines which type of pizza crust. */
            if (rdoThin.Checked)
                rtfOrderSummary.Text += "with Thin crust and the following toppings: \n";
            else if (rdoThick.Checked)
                rtfOrderSummary.Text += "with Thick crust and the following toppings: \n";
            else if (rdoRegular.Checked)
                rtfOrderSummary.Text += "with Regular crust and the following toppings: \n";

            /*Statement that collects the chosen pizza toppings. */
            if (ckbPepperoni.Checked)
                rtfOrderSummary.Text += "\u2022 Pepperoni\n";
            if (ckbSausage.Checked)
                rtfOrderSummary.Text += "\u2022 Sausage\n";
            if (ckbCanadianBacon.Checked)
                rtfOrderSummary.Text += "\u2022 Canadian Bacon\n";
            if (ckbItalianSausage.Checked)
                rtfOrderSummary.Text += "\u2022 Spicy Italian\n";
            if (ckbOnion.Checked)
                rtfOrderSummary.Text += "\u2022 Onion\n";
            if (ckbGreenPepper.Checked)
                rtfOrderSummary.Text += "\u2022 Green Pepper\n";
            if (ckbBlackOlives.Checked)
                rtfOrderSummary.Text += "\u2022 Black Olives\n";
            if (ckbGreenOlives.Checked)
                rtfOrderSummary.Text += "\u2022 Green Olives\n";
            if (ckbBananaPeppers.Checked)
                rtfOrderSummary.Text += "\u2022 Banana Peppers\n";
            if (ckbJalapenos.Checked)
                rtfOrderSummary.Text += "\u2022 Jalapenos\n";
            if (ckbExtraCheese.Checked)
                rtfOrderSummary.Text += "\u2022 Extra Cheese\n";
            if (ckbMushrooms.Checked)
                rtfOrderSummary.Text += "\u2022 Mushrooms\n";

            /*Call to Summarize method to calculate totals. */
            Summarize();

        }//end btnCalculate_Click

        /*Method that calculates user's totals based on various pizza choices. */
        private void Summarize()
        {
            double subtotal = 0;
            double tax = 0;
            double total = 0;

            /*Statement to determine cost of chosen size. Adds to subtotal. */
            String pizzaSize = "";
            pizzaSize = cboPizzaSize.Text;
            if (pizzaSize == "Small")
                subtotal += small;
            if (pizzaSize == "Medium")
                subtotal += medium;
            if (pizzaSize == "Large")
                subtotal += large;
            if (pizzaSize == "X-Large")
                subtotal += xLarge;
            if (pizzaSize == "Ginormous")
                subtotal += ginormous;

            /*Statement to determine cost of toppings. Adds to subtotal. */
            if (ckbPepperoni.Checked)
                subtotal += pepperoni;
            if (ckbSausage.Checked)
                subtotal += sausage;
            if (ckbCanadianBacon.Checked)
                subtotal += canadianBacon;
            if (ckbItalianSausage.Checked)
                subtotal += spicyItalianSausage;
            if (ckbOnion.Checked)
                subtotal += onion;
            if (ckbGreenPepper.Checked)
                subtotal += greenPepper;
            if (ckbBlackOlives.Checked)
                subtotal += blackOlives;
            if (ckbGreenOlives.Checked)
                subtotal += greenOlives;
            if (ckbBananaPeppers.Checked)
                subtotal += bananaPeppers;
            if (ckbJalapenos.Checked)
                subtotal += jalapenos;
            if (ckbExtraCheese.Checked)
                subtotal += extraCheese;
            if (ckbMushrooms.Checked)
                subtotal += mushrooms;

            /*Prints subtotal to subtotal textbox. */
            txtSubtotal.Text = subtotal.ToString("C");

            /*Applies tax rate to subtotal and prints tax amount. */
            tax = subtotal * 0.047;
            txtTax.Text = tax.ToString("C");

            /*Adds subtotal to tax to determine total cost. */
            total = subtotal + tax;
            txtTotal.Text = total.ToString("C");

        }//end Summarize

    }//end form
}//end namespace