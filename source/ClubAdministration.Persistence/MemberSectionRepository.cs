using System.Threading.Tasks;
using ClubAdministration.Core.Contracts;
using ClubAdministration.Core.Entities;

namespace ClubAdministration.Persistence
{
  public class MemberSectionRepository : IMemberSectionRepository
  {
    private readonly ApplicationDbContext _dbContext;

    public MemberSectionRepository(ApplicationDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task AddRangeAsync(MemberSection[] memberSections)
      => await _dbContext.MemberSections
                  .AddRangeAsync(memberSections);
  }
}