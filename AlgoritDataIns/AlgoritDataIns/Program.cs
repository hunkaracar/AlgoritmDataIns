
namespace AlgoritDataIns
{
    class Program
    {
        public static void Main()
        {
            LinkedListe liste = new LinkedListe();

            liste.AddtoEnd(5);
            liste.AddtoEnd(6);  
            liste.AddtoEnd(10);
            liste.AddtoEnd(15);
            liste.AddtoHead(1); 
            liste.AddtoHead(3);
            liste.Delete(1);
            liste.DeletefromIndex(1);
            liste.print();

            Console.ReadKey();  
        }
    }
}