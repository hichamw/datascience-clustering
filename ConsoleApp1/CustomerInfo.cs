namespace ConsoleApp1
{
    public class CustomerInfo
    {
        private string customerID;
        private string customerName;
        private string quotationId;

        public CustomerInfo(string customerId, string customerName, string quotationId)
        {
            customerID = customerId;
            this.customerName = customerName;
            this.quotationId = quotationId;
        }

        public string CustomerId
        {
            get => customerID;
            set => customerID = value;
        }

        public string CustomerName
        {
            get => customerName;
            set => customerName = value;
        }

        public string QuotationId
        {
            get => quotationId;
            set => quotationId = value;
        }
    }
}