
namespace ConsoleApp3
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Car Car = new Car("Mercedes" ,"S-Class" , 23131 , 4);
            Car.ShowFullData();

            
            Moto Moto = new Moto("Harley-Davidson",  "Sportster" , 15000 , 2);
            Moto.ShowFullData();
            
        }

    }
    class Vehicle
    {
        public string brand;
        public string model;
        public double Mille;
        public Vehicle()
        {
            
        }
        public Vehicle(string brand,string model,double Mille)
        {
            this.brand = brand;
            this.model = model;
            this.Mille = Mille;

        }
    }

    class Car:Vehicle
    {
        public double DoorsNum;

        public Car(string brand,string model,double Mille , double DoorsNum):base(brand,model,Mille)
        {
            this.DoorsNum = DoorsNum;

        }


        public void ShowFullData()
        {
            Console.WriteLine(brand +""+ model +""+ Mille +""+ DoorsNum);
        }
    }
    class Moto : Vehicle
    {
        public double WheelsNum;

        public Moto(string brand, string model, double Mille, double wheelsnum):base(brand,model,Mille) 
        {
            this.WheelsNum = wheelsnum;
        }
        public void ShowFullData()
        {
            Console.WriteLine(brand +""+ model + "" + Mille + "" + WheelsNum);
        }
    }
}
