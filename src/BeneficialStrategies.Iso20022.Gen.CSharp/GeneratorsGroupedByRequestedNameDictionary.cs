namespace BeneficialStrategies.Iso20022.Gen.CSharp;

public class GeneratorsGroupedByRequestedNameDictionary : Dictionary<string, IGenerate[]>
{
    public GeneratorsGroupedByRequestedNameDictionary() : base(StringComparer.InvariantCultureIgnoreCase)
    {
        this.Add("codeset", new IGenerate[]
        {
                new DropdownRowInterfaceGenerator(),
                new DropdownSourceInterfaceGenerator(),
                new CodesetEnumGenerator(),
                new DropdownSourceGenerator(),
                new DropdownRowGenerator(),
        });
        this.Add("doc", new IGenerate[]
        {
           //  new XmlBreakoutGenerator(), Needs work, enable after fixed.
        });

        this.Add("all", this.SelectMany(i => i.Value).ToArray());
    }
}
