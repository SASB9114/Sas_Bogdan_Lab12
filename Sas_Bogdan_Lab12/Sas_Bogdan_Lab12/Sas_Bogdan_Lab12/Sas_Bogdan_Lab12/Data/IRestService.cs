using System.Collections.Generic;
using System.Threading.Tasks;
using Sas_Bogdan_Lab12.Models;

namespace Sas_Bogdan_Lab12.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
