using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Xtd.AngularWebApp.Localization
{
    public static class AngularWebAppLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AngularWebAppConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AngularWebAppLocalizationConfigurer).GetAssembly(),
                        "Xtd.AngularWebApp.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
