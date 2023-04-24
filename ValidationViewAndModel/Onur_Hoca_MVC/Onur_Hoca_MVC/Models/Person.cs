namespace Onur_Hoca_MVC.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public Person(int ıd, string name, string age)
        {
            Id = ıd;
            Name = name;
            Age = age;
        }
        public Person()
        {

        }
    }
}
