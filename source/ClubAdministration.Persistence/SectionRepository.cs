using System.Linq;
using System.Threading.Tasks;
using ClubAdministration.Core.Contracts;
using ClubAdministration.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClubAdministration.Persistence
{
  public class SectionRepository : ISectionRepository
  {
    private readonly ApplicationDbContext _dbContext;

    public SectionRepository(ApplicationDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<Section[]> GetAllAsync()
      => await _dbContext.Sections
          .OrderBy(s => s.Name)
          .ToArrayAsync();

    public async Task<string[]> GetSectionNamesForMemberAsync(int memberId)
      => await _dbContext.MemberSections
          .Where(ms => ms.MemberId == memberId)
          .OrderBy(ms => ms.Section.Name)
          .Select(ms => ms.Section.Name)
          .ToArrayAsync();

  }
}