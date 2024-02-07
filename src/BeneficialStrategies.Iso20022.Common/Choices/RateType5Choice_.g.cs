﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateType5Choice.  ISO2002 ID# _Quh39Np-Ed-ak6NoX_4Aeg_996830238.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a code and or a data source scheme to determine the rate.
/// </summary>
[KnownType(typeof(RateType5Choice.Code))]
[KnownType(typeof(RateType5Choice.Proprietary))]
public abstract partial record RateType5Choice_ : IIsoXmlSerilizable<RateType5Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RateType5Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => RateType5Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => RateType5Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RateType5Choice choice.")
        };
    }
}
