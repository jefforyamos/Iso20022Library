﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectionReason33Choice.  ISO2002 ID# _8NoLbZNLEeWGlc8L7oPDIg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the rejection reason.
/// </summary>
[KnownType(typeof(RejectionReason33Choice.Code))]
[KnownType(typeof(RejectionReason33Choice.Proprietary))]
public abstract partial record RejectionReason33Choice_ : IIsoXmlSerilizable<RejectionReason33Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RejectionReason33Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => RejectionReason33Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => RejectionReason33Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RejectionReason33Choice choice.")
        };
    }
}
