﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionEventType101Choice.  ISO2002 ID# __66qYQVUEeqjd8n6wD9JVw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the repair reason.
/// </summary>
[KnownType(typeof(CorporateActionEventType101Choice.Code))]
[KnownType(typeof(CorporateActionEventType101Choice.Proprietary))]
public abstract partial record CorporateActionEventType101Choice_ : IIsoXmlSerilizable<CorporateActionEventType101Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CorporateActionEventType101Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => CorporateActionEventType101Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => CorporateActionEventType101Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CorporateActionEventType101Choice choice.")
        };
    }
}
