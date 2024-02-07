﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ChargeType3Choice.  ISO2002 ID# _tjJEUVkyEeGeoaLUQk__nA_-594962709.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the charge type.
/// </summary>
[KnownType(typeof(ChargeType3Choice.Code))]
[KnownType(typeof(ChargeType3Choice.Proprietary))]
public abstract partial record ChargeType3Choice_ : IIsoXmlSerilizable<ChargeType3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static ChargeType3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => ChargeType3Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => ChargeType3Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid ChargeType3Choice choice.")
        };
    }
}
