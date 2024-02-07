﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CancelledReason12Choice.  ISO2002 ID# _eoqj8UHTEeasdbKMiqizqA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between formats for a cancelled reason.
/// </summary>
[KnownType(typeof(CancelledReason12Choice.Code))]
[KnownType(typeof(CancelledReason12Choice.Proprietary))]
[KnownType(typeof(CancelledReason12Choice.NoSpecifiedReason))]
public abstract partial record CancelledReason12Choice_ : IIsoXmlSerilizable<CancelledReason12Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CancelledReason12Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => CancelledReason12Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => CancelledReason12Choice.Proprietary.Deserialize(elementWithPayload),
             "NoSpcfdRsn" => CancelledReason12Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CancelledReason12Choice choice.")
        };
    }
}
