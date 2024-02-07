﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateType47Choice.  ISO2002 ID# _cj-uN5KQEeWHWpTQn1FFVg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a standard code or proprietary code to specify a rate type.
/// </summary>
[KnownType(typeof(RateType47Choice.Code))]
[KnownType(typeof(RateType47Choice.Proprietary))]
public abstract partial record RateType47Choice_ : IIsoXmlSerilizable<RateType47Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RateType47Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => RateType47Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => RateType47Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RateType47Choice choice.")
        };
    }
}
