﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionOption46Choice.  ISO2002 ID# _ZHey_x9REeuFz_FaCzCLgQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a standard code or a proprietary code to specify the type of corporate action options.
/// </summary>
[KnownType(typeof(CorporateActionOption46Choice.Code))]
[KnownType(typeof(CorporateActionOption46Choice.Proprietary))]
public abstract partial record CorporateActionOption46Choice_ : IIsoXmlSerilizable<CorporateActionOption46Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CorporateActionOption46Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => CorporateActionOption46Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => CorporateActionOption46Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CorporateActionOption46Choice choice.")
        };
    }
}
