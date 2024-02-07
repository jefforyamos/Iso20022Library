﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionEventType74Choice.  ISO2002 ID# _HU3Tc5SfEeeh5JjedkaA_g.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between formats to express the corporate event type.
/// </summary>
[KnownType(typeof(CorporateActionEventType74Choice.Code))]
[KnownType(typeof(CorporateActionEventType74Choice.Proprietary))]
public abstract partial record CorporateActionEventType74Choice_ : IIsoXmlSerilizable<CorporateActionEventType74Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CorporateActionEventType74Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => CorporateActionEventType74Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => CorporateActionEventType74Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CorporateActionEventType74Choice choice.")
        };
    }
}
