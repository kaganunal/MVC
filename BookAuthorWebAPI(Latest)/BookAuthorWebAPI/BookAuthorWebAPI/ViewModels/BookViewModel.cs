using BookAuthorWebAPI.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BookAuthorWebAPI.ViewModels
{
    public class BookViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Display(Name = "Author")]
        public int SelectedAuthorId { get; set; }
        public List<Author> Authors { get; set; }

        [Display(Name = "Type of Book")]
        public int SelectedTypeOfBookId { get; set; }
        public List<TypeOfBook> TypesOfBook { get; set; }
    }
}
