using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Repository;

public class BusinessComponent : TopLevelDictionaryEntry
{
    public BusinessComponent(XElement xElement) : base(xElement)
    {

    }
}
