﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectionReason14Choice.  ISO2002 ID# _omJ5wSwtEeOEV5XHD-BKpw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the rejection reason.
/// </summary>
[KnownType(typeof(RejectionReason14Choice.Code))]
[KnownType(typeof(RejectionReason14Choice.Proprietary))]
public abstract partial record RejectionReason14Choice_ : IIsoXmlSerilizable<RejectionReason14Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RejectionReason14Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => RejectionReason14Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => RejectionReason14Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RejectionReason14Choice choice.")
        };
    }
}
