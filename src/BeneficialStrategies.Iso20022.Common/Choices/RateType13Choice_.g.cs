﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateType13Choice.  ISO2002 ID# _Q2uKotp-Ed-ak6NoX_4Aeg_-94553220.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a standard code or proprietary code to specify a rate type.
/// </summary>
[KnownType(typeof(RateType13Choice.Code))]
[KnownType(typeof(RateType13Choice.Proprietary))]
public abstract partial record RateType13Choice_ : IIsoXmlSerilizable<RateType13Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RateType13Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => RateType13Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => RateType13Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RateType13Choice choice.")
        };
    }
}
