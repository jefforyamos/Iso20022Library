﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionChangeTypeFormat8Choice.  ISO2002 ID# _c5V6a5KQEeWHWpTQn1FFVg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a standard code or proprietary code to specify the change type of a corporate action event.
/// </summary>
[KnownType(typeof(CorporateActionChangeTypeFormat8Choice.Code))]
[KnownType(typeof(CorporateActionChangeTypeFormat8Choice.Proprietary))]
public abstract partial record CorporateActionChangeTypeFormat8Choice_ : IIsoXmlSerilizable<CorporateActionChangeTypeFormat8Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CorporateActionChangeTypeFormat8Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => CorporateActionChangeTypeFormat8Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => CorporateActionChangeTypeFormat8Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CorporateActionChangeTypeFormat8Choice choice.")
        };
    }
}
