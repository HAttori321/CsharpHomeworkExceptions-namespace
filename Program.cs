namespace ConsoleApp3
{
    class CreditCard
    {
        private string cardNumber;
        public string CardNumber
        {
            get { return cardNumber; }
            set
            {
                if (value.Length != 16)
                {
                    throw new ArgumentException("Incorrect number card!");
                }
                cardNumber = value;
            }
        }
        private string cardholderName;
        public string CardHolderName
        {
            get { return cardholderName; }
            set { cardholderName = value; }
        }
        private string cvv;
        public string Cvv
        {
            get { return cvv; }
            set
            {
                if (value.Length != 3)
                {
                    throw new ArgumentException("Incorrect cvv code");
                }
                cvv = value;
            }
        }
        private string expiryDate;
        public string ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate = value; }
        }
        public CreditCard(string cardNumber, string cardholderName, string cvv, string expiryDate)
        {
            CardNumber = cardNumber;
            CardHolderName = cardholderName;
            Cvv = cvv;
            ExpiryDate = expiryDate;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            //Console.WriteLine("Enter string with numbers(0-9) : ");
            //string input=Console.ReadLine();
            //try
            //{
            //    int number=int.Parse(input);
            //    Console.WriteLine(number);
            //}
            //catch(FormatException)
            //{
            //    Console.WriteLine("Error.You cant use a letter!");
            //}
            //catch(OverflowException)
            //{
            //    Console.WriteLine("Error.Limit is a 9 number.");
            //}
            //Task2
            //try
            //{
            //    CreditCard myCard = new CreditCard("4332432143233241", "Nazar Shnyruk", "456", "24/27");
            //    Console.WriteLine($"Card Number: {myCard.CardNumber}");
            //    Console.WriteLine($"Cardholder Name: {myCard.CardHolderName}");
            //    Console.WriteLine($"CVV: {myCard.Cvv}");
            //    Console.WriteLine($"Expiry Date: {myCard.ExpiryDate}");
            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine($"Error creating credit card: {e.Message}");
            //}
            Console.WriteLine("Enter a mathematical expression in the format number*number*...*number : ");
            string input = Console.ReadLine();
            try
            {
                string[] numbers = input.Split('*');
                int result = int.Parse(numbers[0]);
                for (int i = 1; i < numbers.Length; i++)
                {
                    result *= int.Parse(numbers[i]);
                }
                Console.WriteLine($"Result : {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error.");
            }
        }
    }
}