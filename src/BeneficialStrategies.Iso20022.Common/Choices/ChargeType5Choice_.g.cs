﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ChargeType5Choice.  ISO2002 ID# _KJb5gDh5EeaH-93K5JKmzw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for the type of charge.
/// </summary>
[KnownType(typeof(ChargeType5Choice.Code))]
[KnownType(typeof(ChargeType5Choice.Proprietary))]
public abstract partial record ChargeType5Choice_ : IIsoXmlSerilizable<ChargeType5Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static ChargeType5Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => ChargeType5Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => ChargeType5Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid ChargeType5Choice choice.")
        };
    }
}
