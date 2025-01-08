namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            Product products= new Product("asus","tuf",45,true,2400,16,1024);


            Notebook.GetFullData();
        }
        
    }
    class Product
    {
        public string Name;
        public string Description;
        public int Count;
        public bool isstock;
        public double Price;
        public Product()
        {

        }

        public Product(string Name, string Description, int Count, bool isstock, double Price)
        {
            this.Name = Name;
            this.Description = Description;
            this.Count = Count;
            this.isstock = isstock;
            this.Price = Price;
                
        }
    }
    class Notebook:Product
    {
        public byte RAM;
        public int Storage;


        public void GetFullData(string Name, string Description, int Count, bool isstock, double Price, byte Ram, int Storage):base(Name, Description, Count, isstock, Price)
        {
            this.RAM=Ram;
            this.Storage=Storage;
            
            
            
            Console.WriteLine(Name,Description,Count,isstock,Price,Ram,Storage);
        }
    }









}
