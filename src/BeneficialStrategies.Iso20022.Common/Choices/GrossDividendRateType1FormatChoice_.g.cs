﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for GrossDividendRateType1FormatChoice.  ISO2002 ID# _RmjsKNp-Ed-ak6NoX_4Aeg_546925647.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats to express the type of gross dividend rate.
/// </summary>
[KnownType(typeof(GrossDividendRateType1FormatChoice.Code))]
[KnownType(typeof(GrossDividendRateType1FormatChoice.Proprietary))]
public abstract partial record GrossDividendRateType1FormatChoice_ : IIsoXmlSerilizable<GrossDividendRateType1FormatChoice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static GrossDividendRateType1FormatChoice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => GrossDividendRateType1FormatChoice.Code.Deserialize(elementWithPayload),
             "Prtry" => GrossDividendRateType1FormatChoice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid GrossDividendRateType1FormatChoice choice.")
        };
    }
}
