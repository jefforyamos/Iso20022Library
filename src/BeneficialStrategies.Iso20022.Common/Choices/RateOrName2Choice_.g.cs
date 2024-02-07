﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateOrName2Choice.  ISO2002 ID# _XO3Ydtp-Ed-ak6NoX_4Aeg_-1773453138.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a percentage rate or a rate name.
/// </summary>
[KnownType(typeof(RateOrName2Choice.Rate))]
[KnownType(typeof(RateOrName2Choice.RateName))]
public abstract partial record RateOrName2Choice_ : IIsoXmlSerilizable<RateOrName2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RateOrName2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Rate" => RateOrName2Choice.Rate.Deserialize(elementWithPayload),
             "RateNm" => RateOrName2Choice.RateName.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RateOrName2Choice choice.")
        };
    }
}
