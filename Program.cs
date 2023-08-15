namespace oop_vazifa_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Price = 10;
            product1.Name = "olma";
            product1.Code = 1122;
            product1.Category = "Meva";

            product1.DisplayInfo();
            Console.WriteLine();

            Product product2 = new Product();
            product2.Price = 30;
            product2.Name = "shokalat";
            product2.Code = 3322;
            product2.Category = "Shirinlik";

            product2.DisplayInfo();
            Console.WriteLine();

            string[] product = {product1.Name,product2.Name};

            int[] Prices = {product1.Price,product2.Price};

            CalculateTotal(product,Prices); 
        }
        static void CalculateTotal(string[] productName , int[] Prices)
        {
            long sum=0;

            Console.WriteLine("Products Info");
            foreach(string i in productName)
            {
                Console.WriteLine(i);
            }
            
            foreach(int j in Prices)
            {
                sum += j;
            }
            Console.WriteLine($"ToTal Result: {sum}");
        }
    }
    class Product
    {
        public Product()
        {
        }
        public Product(string Price, string Name)
        {
            Price = Price;
            Name = Name;  
        }
        public Product(string Price, string Name, int Code, string Category)
        {
            Price = Price;
            Name = Name;
            Code = Code;
            Category = Category;
        }

        public int  Price { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public string Category { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Price:{Price}\nName:{Name}\n Code:{Code} \nCategory:{Category}");
        }
    }
}