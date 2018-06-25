using System.Threading.Tasks;
using SpaceX.Api.Client.Models.Company;

namespace SpaceX.Api.Client
{
    public interface ISpaceXClient
    {
        /// <summary>
        /// Get company info
        /// </summary>
        /// <returns><see cref="CompanyInfo"/></returns>
        Task<CompanyInfo> GetCompanyInfo();

        /// <summary>
        /// Get company history / milestones
        /// </summary>
        /// <returns><see cref="CompanyHistory"/></returns>
        Task<CompanyHistory> GetCompanyHistory();
    }
}
