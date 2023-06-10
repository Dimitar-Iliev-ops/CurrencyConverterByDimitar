namespace Currency_Converter
{
    public partial class ConversionForm : Form
    {
        public ConversionForm()
        {
            InitializeComponent();
        }

        private void currency_Click(object sender, EventArgs e)
        {

        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            
            const decimal ConversionCoefficient = 1.95583m;
            decimal amountBGN = this.numericUpDownAmount.Value;
            decimal amountEUR = amountBGN/ ConversionCoefficient;
            this.resultLabel.Text = $"{amountBGN} BGN = {amountEUR:f2} EUR";

        }

        private void ConversionForm_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}