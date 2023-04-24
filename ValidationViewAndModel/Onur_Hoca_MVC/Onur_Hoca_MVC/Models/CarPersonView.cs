namespace Onur_Hoca_MVC.Models
{
    public class CarPersonView
    {
        public Car Car { get; set; }
        public Person Person { get; set; }
        public CarPersonView(Car car, Person person)
        {
            Car = car;
            Person = person;
        }
    }
}
