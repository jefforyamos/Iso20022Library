using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Repository;

public class UnrecognizedDictionaryEntry : TopLevelDictionaryEntry
{
    public UnrecognizedDictionaryEntry(XElement xElement) : base(xElement)
    {

    }
}

