using Light.Contracts;
using Light.Grab.GrabMart.Models.MasterData;
using System.Threading.Tasks;

namespace Light.Grab.GrabMart
{
    public interface IMenuClient
    {
        /// <summary>
        /// MY - Malaysia, PH - Philippines, TH - Thailand, SG - Singapore, VN - Vietnam, ID - Indonesia, MM - Myanmar, KH - Cambodia
        /// </summary>
        /// <param name="region"></param>
        /// <returns></returns>
        Task<MartCategory> GetMartCategories(string region = "VN");

        /// <summary>
        /// Notify Grab to update merchant menu
        /// </summary>
        /// <returns></returns>
        Task<Result> UpdateMenu(string merchantId);

        /// <summary>
        /// Update item to Grab menu
        /// </summary>
        /// <param name="merchantId"></param>
        /// <returns></returns>
        Task<Result> UpdateItem(string merchantId, string itemNo, long price, int maxStock);

    }
}
