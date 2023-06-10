namespace Currency_Converter
{
    partial class ConversionForm
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
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.currency = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.BackColor = System.Drawing.Color.Silver;
            this.numericUpDownAmount.DecimalPlaces = 2;
            this.numericUpDownAmount.Location = new System.Drawing.Point(184, 146);
            this.numericUpDownAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownAmount.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(131, 23);
            this.numericUpDownAmount.TabIndex = 0;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmount.ValueChanged += new System.EventHandler(this.numericUpDownAmount_ValueChanged);
            // 
            // currency
            // 
            this.currency.AutoSize = true;
            this.currency.BackColor = System.Drawing.Color.Silver;
            this.currency.Location = new System.Drawing.Point(426, 146);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(69, 15);
            this.currency.TabIndex = 1;
            this.currency.Text = "BGN to EUR";
            this.currency.Click += new System.EventHandler(this.currency_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(184, 200);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(319, 19);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultButton
            // 
            this.resultButton.BackColor = System.Drawing.Color.Transparent;
            this.resultButton.Location = new System.Drawing.Point(329, 146);
            this.resultButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(82, 22);
            this.resultButton.TabIndex = 3;
            this.resultButton.Text = "Convert";
            this.resultButton.UseVisualStyleBackColor = false;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // ConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.currency);
            this.Controls.Add(this.numericUpDownAmount);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConversionForm";
            this.Text = "CurrencyConverterByDimitar";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numericUpDownAmount;
        private Label currency;
        private Label resultLabel;
        private Button resultButton;
    }
}