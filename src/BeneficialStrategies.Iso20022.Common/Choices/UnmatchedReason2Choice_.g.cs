﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UnmatchedReason2Choice.  ISO2002 ID# _UXSHU9p-Ed-ak6NoX_4Aeg_-1156614721.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the statement query unmatched reason.
/// </summary>
[KnownType(typeof(UnmatchedReason2Choice.Code))]
[KnownType(typeof(UnmatchedReason2Choice.Proprietary))]
public abstract partial record UnmatchedReason2Choice_ : IIsoXmlSerilizable<UnmatchedReason2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static UnmatchedReason2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => UnmatchedReason2Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => UnmatchedReason2Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid UnmatchedReason2Choice choice.")
        };
    }
}
