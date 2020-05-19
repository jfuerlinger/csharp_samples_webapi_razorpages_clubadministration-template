using ClubAdministration.Core.Contracts;
using ClubAdministration.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ClubAdministration.Web.ApiControllers
{
  /// <summary>
  /// API-Controller für die Abfrage von Mitgliedern
  /// </summary>
  [Route("api/[controller]")]
  [ApiController]
  public class MembersController : ControllerBase
  {
    private readonly IUnitOfWork _unitOfWork;

    /// <summary>
    /// Constructor mit DI
    /// </summary>
    /// <param name="unitOfWork"></param>
    public MembersController(IUnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

  }
}