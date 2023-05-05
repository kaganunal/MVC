using Microsoft.AspNetCore.Mvc.Rendering;

namespace DTO_API_VIEW.Models
{
    public class ClassesVM
    {
        public List<ClassesDto> ClassesList { get; set; }
        public Classes ClassesDb { get; set; }
        public List<SelectListItem> ClassBranchForDropDown { get; set; }
        public ClassesVM()
        {
            ClassesList = new List<ClassesDto>();
        }
    }
}
