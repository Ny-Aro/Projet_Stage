using System.Configuration;

namespace ProjetStage
{
    public class CheminElement : ConfigurationElement
    {

        #region Fields
        private static ConfigurationPropertyCollection s_properties;
        private static ConfigurationProperty s_propSource;
        private static ConfigurationProperty s_propRecherche;
        private static ConfigurationProperty s_propBackup;

        #endregion

        #region Constructor
        static CheminElement()
        {
            s_propSource = new ConfigurationProperty(
                "source",
                typeof(string),
                null,
                ConfigurationPropertyOptions.IsRequired
                );
            s_propRecherche = new ConfigurationProperty(
                "recherche",
                typeof(string),
                null,
                ConfigurationPropertyOptions.IsRequired
                );
            s_propBackup = new ConfigurationProperty(
                "backup",
                typeof(string),
                null,
                ConfigurationPropertyOptions.IsRequired
                );
            s_properties = new ConfigurationPropertyCollection();

            s_properties.Add(s_propSource);
            s_properties.Add(s_propRecherche);
            s_properties.Add(s_propBackup);

        }
        #endregion

        #region Properties
        public string Source
        {
            get { return (string)base[s_propSource]; }
            set { base[s_propSource] = value; }
        }
        public string Recherche
        {
            get { return (string)base[s_propRecherche]; }
            set { base[s_propRecherche] = value; }
        }
        public string Backup
        {
            get { return (string)base[s_propBackup]; }
            set { base[s_propBackup] = value; }
        }
        protected override ConfigurationPropertyCollection Properties
        {
            get { return s_properties; }
        }
        #endregion

    }
}