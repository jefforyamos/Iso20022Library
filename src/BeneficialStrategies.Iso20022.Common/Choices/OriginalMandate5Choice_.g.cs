﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for OriginalMandate5Choice.  ISO2002 ID# _yur0cZR8EeazAtAtDSg0Nw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the mandate that is being accepted.
/// </summary>
[KnownType(typeof(OriginalMandate5Choice.OriginalMandateIdentification))]
[KnownType(typeof(OriginalMandate5Choice.OriginalMandate))]
public abstract partial record OriginalMandate5Choice_ : IIsoXmlSerilizable<OriginalMandate5Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static OriginalMandate5Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "OrgnlMndtId" => OriginalMandate5Choice.OriginalMandateIdentification.Deserialize(elementWithPayload),
             "OrgnlMndt" => OriginalMandate5Choice.OriginalMandate.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid OriginalMandate5Choice choice.")
        };
    }
}
