using System.Collections.Generic;
using mantri_web_api.Modules;
namespace mantri_web_api.Dependencies
{
    public interface IMantri
    {
        List<Mantri> GetMantriList();

        Mantri GetMantri(int id);
    }
}