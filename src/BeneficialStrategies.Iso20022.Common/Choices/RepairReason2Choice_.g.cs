﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RepairReason2Choice.  ISO2002 ID# _UWigcdp-Ed-ak6NoX_4Aeg_-1033470085.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the repair reason.
/// </summary>
[KnownType(typeof(RepairReason2Choice.Code))]
[KnownType(typeof(RepairReason2Choice.Proprietary))]
public abstract partial record RepairReason2Choice_ : IIsoXmlSerilizable<RepairReason2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RepairReason2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => RepairReason2Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => RepairReason2Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RepairReason2Choice choice.")
        };
    }
}
