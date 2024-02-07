﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for BlockedStatusReason2Choice.  ISO2002 ID# _8TcccV1LEeagR5I1rq5oaw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for a blocked status reason.
/// </summary>
[KnownType(typeof(BlockedStatusReason2Choice.NoSpecifiedReason))]
[KnownType(typeof(BlockedStatusReason2Choice.Reason))]
public abstract partial record BlockedStatusReason2Choice_ : IIsoXmlSerilizable<BlockedStatusReason2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static BlockedStatusReason2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => BlockedStatusReason2Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => BlockedStatusReason2Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid BlockedStatusReason2Choice choice.")
        };
    }
}
