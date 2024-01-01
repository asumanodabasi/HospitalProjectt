using Microsoft.Extensions.Localization;
using System.Reflection;

namespace HospitalProject.Models
{
    public class LanguageService
    {
        private readonly IStringLocalizer stringLocalizer;

        public LanguageService(IStringLocalizerFactory factory)
        {
            var type = typeof(SharedResource);
            var asseblyName=new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            stringLocalizer = factory.Create("SharedResource", asseblyName.Name);
        }


        public LocalizedString GetKey(string key)
        {
            return stringLocalizer[key];
        }
    }
}
