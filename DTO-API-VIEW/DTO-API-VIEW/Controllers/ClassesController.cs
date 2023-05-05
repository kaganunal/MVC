using DTO_API_VIEW.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DTO_API_VIEW.Controllers
{
    public class ClassesController : Controller
    {
        DbContext _dbContext;
        ClassesVM classesVM = new ClassesVM();
        Classes classes = new Classes();
        public IActionResult Listele(string id)
        {
            //classesVM.ClassBranchForDropDown = FillClassBranch();
            if (id != null)
            {
                classesVM.ClassesList = _dbContext.Classes.Where(x => x.ClassBranch == id).Select(x => new ClassesDto()
                {
                    ClassesId = x.ClassID,
                    ClassNo = x.ClassNo,
                    ClassBranch = x.Cl
                }).OrderBy(x => x.ClassNo).ToList();
            }
            else
                return View();
        }
    }
}
