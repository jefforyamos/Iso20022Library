﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RepairStatus14Choice.  ISO2002 ID# _iYMV4Tw5EeW3QqUkIQtIUA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies whether the status is provided with a reason or not.
/// </summary>
[KnownType(typeof(RepairStatus14Choice.NoSpecifiedReason))]
[KnownType(typeof(RepairStatus14Choice.Reason))]
public abstract partial record RepairStatus14Choice_ : IIsoXmlSerilizable<RepairStatus14Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RepairStatus14Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => RepairStatus14Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => RepairStatus14Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RepairStatus14Choice choice.")
        };
    }
}
