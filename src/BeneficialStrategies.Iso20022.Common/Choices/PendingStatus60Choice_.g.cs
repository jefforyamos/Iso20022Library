﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PendingStatus60Choice.  ISO2002 ID# _Pl8f8wVSEeqjd8n6wD9JVw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a reason or no reason for the corporate action instruction processing pending status.
/// </summary>
[KnownType(typeof(PendingStatus60Choice.NoSpecifiedReason))]
[KnownType(typeof(PendingStatus60Choice.Reason))]
public abstract partial record PendingStatus60Choice_ : IIsoXmlSerilizable<PendingStatus60Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PendingStatus60Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => PendingStatus60Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => PendingStatus60Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PendingStatus60Choice choice.")
        };
    }
}
