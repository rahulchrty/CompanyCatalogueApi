using CompanyCatalogue.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyCatalogue.Interfaces
{
    public interface ICatalogueUOW
    {
        Task Create(List<CompanyDetailModel> catalogues, string guid, string fileName);
    }
}
