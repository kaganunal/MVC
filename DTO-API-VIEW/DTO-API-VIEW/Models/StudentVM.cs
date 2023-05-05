using Microsoft.AspNetCore.Mvc.Rendering;

namespace DTO_API_VIEW.Models
{
    public class StudentVM
    {
        public List<StudentDto> StudentsList { get; set; }
        public Student StudentDb { get; set; }
        public List<SelectListItem> ClassNoForDropDown { get; set; }
        public List<SelectListItem> ClassBranchForDropDown { get; set; }
        public StudentVM()
        {
            StudentsList = new List<StudentDto>();
        }
    }
}
