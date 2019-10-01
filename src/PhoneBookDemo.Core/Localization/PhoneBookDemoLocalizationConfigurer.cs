using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;
using PhoneBookDemo.PhoneBook;

namespace PhoneBookDemo.Localization
{
    public static class PhoneBookDemoLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    PhoneBookDemoConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PhoneBookDemoLocalizationConfigurer).GetAssembly(),
                        "PhoneBookDemo.Localization.PhoneBookDemo"
                    )
                )
            );
        }
    }
}