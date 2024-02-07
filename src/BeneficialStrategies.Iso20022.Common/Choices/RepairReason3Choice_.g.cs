﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RepairReason3Choice.  ISO2002 ID# _UYLfMNp-Ed-ak6NoX_4Aeg_-900951191.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the repair reason.
/// </summary>
[KnownType(typeof(RepairReason3Choice.Code))]
[KnownType(typeof(RepairReason3Choice.Proprietary))]
public abstract partial record RepairReason3Choice_ : IIsoXmlSerilizable<RepairReason3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RepairReason3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => RepairReason3Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => RepairReason3Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RepairReason3Choice choice.")
        };
    }
}
