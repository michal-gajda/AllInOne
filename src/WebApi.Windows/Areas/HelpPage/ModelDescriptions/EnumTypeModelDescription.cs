namespace AllInOne.WebApi.Areas.HelpPage.ModelDescriptions
{
    using System.Collections.ObjectModel;

    public class EnumTypeModelDescription : ModelDescription
    {
        public Collection<EnumValueDescription> Values { get; private set; }

        public EnumTypeModelDescription()
        {
            this.Values = new Collection<EnumValueDescription>();
        }
    }
}
