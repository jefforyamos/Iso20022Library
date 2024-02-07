﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DeniedStatus10Choice.  ISO2002 ID# _gvJOR1hgEeS8HfHHd4stCA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies whether the status is provided with a reason or not.
/// </summary>
[KnownType(typeof(DeniedStatus10Choice.NoSpecifiedReason))]
[KnownType(typeof(DeniedStatus10Choice.Reason))]
public abstract partial record DeniedStatus10Choice_ : IIsoXmlSerilizable<DeniedStatus10Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static DeniedStatus10Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => DeniedStatus10Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => DeniedStatus10Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid DeniedStatus10Choice choice.")
        };
    }
}
