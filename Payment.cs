namespace CSCI213___Assignment_5 {
    public class Payment {
        public Payment(int id, int orderID, decimal total) {
            PaymentID = id;
            OrderID = orderID;
            PaymentTotal = total;
            PaymentDate = DateTime.Now;
            PaymentStatus = "Pending"; //Default
        }
        public int PaymentID {  get; set; }
        public int OrderID { get; set; }
        public decimal PaymentTotal { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentStatus { get; private set; }

        public void ProcessPayment() {
            PaymentStatus = "Processed";
        }

        public override string ToString() =>
            $"Payment (ID: {PaymentID}, Order ID: {OrderID}, Amount: {PaymentTotal:C}, Date: {PaymentDate}, Status: {PaymentStatus})";
    }
}
