﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CancellationStatus3Choice.  ISO2002 ID# _UUAJ0dp-Ed-ak6NoX_4Aeg_305134914.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies whether the status is provided with a reason or not.
/// </summary>
[KnownType(typeof(CancellationStatus3Choice.NoSpecifiedReason))]
[KnownType(typeof(CancellationStatus3Choice.Reason))]
public abstract partial record CancellationStatus3Choice_ : IIsoXmlSerilizable<CancellationStatus3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CancellationStatus3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => CancellationStatus3Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => CancellationStatus3Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CancellationStatus3Choice choice.")
        };
    }
}
