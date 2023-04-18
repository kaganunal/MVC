namespace mvcListPractice.Models
{
    public class Personel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Dictionary<int, string> Cars { get; set; }
    }
}
