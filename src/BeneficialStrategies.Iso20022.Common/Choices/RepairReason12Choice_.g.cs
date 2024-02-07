﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RepairReason12Choice.  ISO2002 ID# _ja_PsTw5EeW3QqUkIQtIUA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the repair reason.
/// </summary>
[KnownType(typeof(RepairReason12Choice.Code))]
[KnownType(typeof(RepairReason12Choice.Proprietary))]
public abstract partial record RepairReason12Choice_ : IIsoXmlSerilizable<RepairReason12Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RepairReason12Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => RepairReason12Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => RepairReason12Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RepairReason12Choice choice.")
        };
    }
}
