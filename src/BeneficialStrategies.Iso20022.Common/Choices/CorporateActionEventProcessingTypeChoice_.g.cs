﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionEventProcessingTypeChoice.  ISO2002 ID# _Q4g6aNp-Ed-ak6NoX_4Aeg_944669894.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a standard code or a proprietary code for specifying the processing type of a corporate action event.
/// </summary>
[KnownType(typeof(CorporateActionEventProcessingTypeChoice.Code))]
[KnownType(typeof(CorporateActionEventProcessingTypeChoice.Proprietary))]
public abstract partial record CorporateActionEventProcessingTypeChoice_ : IIsoXmlSerilizable<CorporateActionEventProcessingTypeChoice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CorporateActionEventProcessingTypeChoice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => CorporateActionEventProcessingTypeChoice.Code.Deserialize(elementWithPayload),
             "Prtry" => CorporateActionEventProcessingTypeChoice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CorporateActionEventProcessingTypeChoice choice.")
        };
    }
}
