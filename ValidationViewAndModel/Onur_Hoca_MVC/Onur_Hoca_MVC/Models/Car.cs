namespace Onur_Hoca_MVC.Models
{
    public class Car
    {
        public string Marka { get; set; }
        public int Model { get; set; }
        public Car(string marka, int model)
        {
            Marka = marka;
            Model = model;
        }
        public Car()
        {

        }
    }
}
