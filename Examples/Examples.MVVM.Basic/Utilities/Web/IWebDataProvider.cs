using System.Threading.Tasks;

namespace Examples.MVVM.Basic.Utilities.Web
{
    public interface IWebDataProvider
    {
        string GetResponse(string uri);
        Task<string> GetResponseAsync(string uri);
    }
}
