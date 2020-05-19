using System.Linq;
using System.Threading.Tasks;
using ClubAdministration.Core.Contracts;
using ClubAdministration.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClubAdministration.Persistence
{
  public class MemberRepository : IMemberRepository
  {
    private readonly ApplicationDbContext _dbContext;

    public MemberRepository(ApplicationDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    //public async Task<Member> GetMemberByNameAsync(string lastName, string firstName)
    //  => await _dbContext.Members
    //        .Include(m => m.MemberSections)
    //          .ThenInclude(ms => ms.Section)
    //        .FirstOrDefaultAsync(m => m.LastName == lastName && m.FirstName == firstName);

    //public async Task<Member[]> GetMembersForSectionAsync(int sectionId)
    //  => (await _dbContext.Sections
    //        .Include(s => s.MemberSections)
    //        .ThenInclude(ms => ms.Member)
    //        .FirstOrDefaultAsync(s => s.Id == sectionId))
    //        ?.MemberSections
    //          .Select(ms => ms.Member)
    //          .OrderBy(m => m.LastName)
    //          .ThenBy(m => m.FirstName)
    //          .ToArray();

    //public async Task<MemberDto[]> GetMemberDtosAsync(int sectionId)
    //  => (await _dbContext.MemberSections
    //        .Where(ms => ms.SectionId == sectionId)
    //        .Include(ms => ms.Member)
    //        .ToArrayAsync())
    //        .GroupBy(ms => ms.Member)
    //        .Select(ms => new MemberDto
    //        {
    //          Id = ms.Key.Id,
    //          FirstName = ms.Key.FirstName,
    //          LastName = ms.Key.LastName,
    //          CountSections = _dbContext.Members.Single(m => m.Id == ms.Key.Id).MemberSections.Count
    //        })
    //        .OrderBy(m => m.LastName)
    //          .ThenBy(m => m.FirstName)
    //        .ToArray();

    //public async Task<Member> GetByIdAsync(int id)
    //  => await _dbContext.Members
    //        .FindAsync(id);

    //public async Task<string[]> GetMemberNamesAsync()
    //  => await _dbContext.Members
    //      .OrderBy(m => m.LastName)
    //        .ThenBy(m => m.FirstName)
    //      .Select(m => $"{m.LastName} {m.FirstName}")
    //      .ToArrayAsync();

    //public async Task<bool> HasDuplicateAsync(Member member)
    //  => await _dbContext.Members
    //        .AnyAsync(m =>
    //              m.Id != member.Id
    //              && m.FirstName == member.FirstName
    //              && m.LastName == member.LastName);
  }
}