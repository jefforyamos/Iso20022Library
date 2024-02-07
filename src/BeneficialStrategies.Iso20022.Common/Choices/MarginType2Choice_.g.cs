﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for MarginType2Choice.  ISO2002 ID# _JT728I1rEeet3cKIYK84nw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the type of margin, for example, initial margin, variation margin, initial deposit or coupon margin.
/// </summary>
[KnownType(typeof(MarginType2Choice.Code))]
[KnownType(typeof(MarginType2Choice.Proprietary))]
public abstract partial record MarginType2Choice_ : IIsoXmlSerilizable<MarginType2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static MarginType2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => MarginType2Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => MarginType2Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid MarginType2Choice choice.")
        };
    }
}
