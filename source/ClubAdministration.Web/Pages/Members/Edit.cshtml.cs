using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using ClubAdministration.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClubAdministration.Core.Entities;

namespace ClubAdministration.Web.Pages.Members
{
  public class EditModel : PageModel
  {
    private readonly IUnitOfWork _unitOfWork;

    public EditModel(IUnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
  }
}
