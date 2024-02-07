﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AcknowledgedAcceptedStatus14Choice.  ISO2002 ID# _0jYTAQlIEeGATtfOBToyew_1285673408.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies whether the status is provided with a reason or not.
/// </summary>
[KnownType(typeof(AcknowledgedAcceptedStatus14Choice.NoSpecifiedReason))]
[KnownType(typeof(AcknowledgedAcceptedStatus14Choice.Reason))]
public abstract partial record AcknowledgedAcceptedStatus14Choice_ : IIsoXmlSerilizable<AcknowledgedAcceptedStatus14Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static AcknowledgedAcceptedStatus14Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => AcknowledgedAcceptedStatus14Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => AcknowledgedAcceptedStatus14Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid AcknowledgedAcceptedStatus14Choice choice.")
        };
    }
}
