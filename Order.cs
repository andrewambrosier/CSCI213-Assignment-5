namespace CSCI213___Assignment_5 {
    public class Order {
        public Order(int id, int userID, decimal total, DateTime date) {
            OrderID = id;
            UserID = userID;
            OrderTotal = total;
            OrderDate = date;
            Status = "Pending"; //Default
        }
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public decimal OrderTotal { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; private set; }

        public void CreateOrder() { //something along this line
            OrderDate = DateTime.Now;
            OrderID = 0;
            OrderTotal = 0m;
        } 

        public void ConfirmOrder() {
            Status = "Confirmed";
        }

        public void CancelOrder() {
            Status = "Canceled";
        }

        public override string ToString() =>
            $"Order (ID: {OrderID}, User ID: {UserID}, Total: {OrderTotal:C}, Date: {OrderDate}, Status: {Status})";
    }
}
