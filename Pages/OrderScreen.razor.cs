namespace CalculatorApp.Pages
{
    public partial class OrderScreen
    {
        private double craftsman = 67.45;
        private double neverkink = 99.99;
        private double steel = 85.67;
        private double ultralite = 47.92;
        public string? TotalPrice { get; set; } = "$0.00";
        public double CraftQty { get; set; } = 0;
        public double KinkQty { get; set; } = 0;
        public double SteelQty { get; set; } = 0;
        public double UltraQty { get; set; } = 0;
        public double CraftSubTotal { get; set; } = 0;
        public double KinkSubTotal { get; set; } = 0;
        public double SteelSubTotal { get; set; } = 0;
        public double UltraSubTotal { get; set; } = 0;

        private void CalculateTotalPrice()
        {
            CraftSubTotal = CraftQty * craftsman;
            KinkSubTotal = KinkQty * neverkink;
            SteelSubTotal = SteelQty * steel;
            UltraSubTotal = UltraQty * ultralite;
            double temp = CraftSubTotal + KinkSubTotal + SteelSubTotal + UltraSubTotal;
            TotalPrice = $"${temp.ToString("N2")}";
        }

        private void NewOrder()
        {
            CraftQty = 0;
            KinkQty = 0;
            SteelQty = 0;
            UltraQty = 0;
            CraftSubTotal = 0;
            KinkSubTotal = 0;
            SteelSubTotal = 0;
            UltraSubTotal = 0;
            TotalPrice = "$0.00";
        }
    }
}
