using ClubAdministration.Core.Entities;
using System.Threading.Tasks;

namespace ClubAdministration.Core.Contracts
{
    public interface IMemberSectionRepository
    {
        Task AddRangeAsync(MemberSection[] memberSections);
    }
}
