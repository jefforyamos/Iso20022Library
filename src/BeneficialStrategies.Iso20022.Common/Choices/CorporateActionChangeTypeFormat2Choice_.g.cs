﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionChangeTypeFormat2Choice.  ISO2002 ID# _Qzl-Itp-Ed-ak6NoX_4Aeg_-953922271.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a standard code or a proprietary code to specify a type of change.
/// </summary>
[KnownType(typeof(CorporateActionChangeTypeFormat2Choice.Code))]
[KnownType(typeof(CorporateActionChangeTypeFormat2Choice.Proprietary))]
public abstract partial record CorporateActionChangeTypeFormat2Choice_ : IIsoXmlSerilizable<CorporateActionChangeTypeFormat2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CorporateActionChangeTypeFormat2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => CorporateActionChangeTypeFormat2Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => CorporateActionChangeTypeFormat2Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CorporateActionChangeTypeFormat2Choice choice.")
        };
    }
}
