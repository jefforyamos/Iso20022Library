﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectedStatus54Choice.  ISO2002 ID# _NpuWOF99Ee262vCSVgjImg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a reason and no reason for the corporate action instruction processing rejected status.
/// </summary>
[KnownType(typeof(RejectedStatus54Choice.NoSpecifiedReason))]
[KnownType(typeof(RejectedStatus54Choice.Reason))]
public abstract partial record RejectedStatus54Choice_ : IIsoXmlSerilizable<RejectedStatus54Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RejectedStatus54Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => RejectedStatus54Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => RejectedStatus54Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RejectedStatus54Choice choice.")
        };
    }
}
