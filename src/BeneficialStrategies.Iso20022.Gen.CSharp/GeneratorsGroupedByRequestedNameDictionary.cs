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
                new XmlBreakoutGenerator(),
        });
        this.Add("doc", new IGenerate[]
        {
            new XmlBreakoutGenerator(),
        });

        this.Add("all", this.SelectMany(i => i.Value).ToArray());
    }
}
