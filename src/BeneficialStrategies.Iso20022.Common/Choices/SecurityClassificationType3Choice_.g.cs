﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecurityClassificationType3Choice.  ISO2002 ID# _R_yWIf35EeimOuZbLgw0bg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a CFI code and an other type of identification for the classification of a financial instrument.
/// </summary>
[KnownType(typeof(SecurityClassificationType3Choice.CFI))]
[KnownType(typeof(SecurityClassificationType3Choice.AlternateClassification))]
public abstract partial record SecurityClassificationType3Choice_ : IIsoXmlSerilizable<SecurityClassificationType3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static SecurityClassificationType3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "CFI" => SecurityClassificationType3Choice.CFI.Deserialize(elementWithPayload),
             "AltrnClssfctn" => SecurityClassificationType3Choice.AlternateClassification.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid SecurityClassificationType3Choice choice.")
        };
    }
}
