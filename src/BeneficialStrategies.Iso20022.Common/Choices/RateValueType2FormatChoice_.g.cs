﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateValueType2FormatChoice.  ISO2002 ID# _Rn5I5Np-Ed-ak6NoX_4Aeg_-1085531011.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats to express the value of a rate.
/// </summary>
[KnownType(typeof(RateValueType2FormatChoice.Code))]
[KnownType(typeof(RateValueType2FormatChoice.Proprietary))]
public abstract partial record RateValueType2FormatChoice_ : IIsoXmlSerilizable<RateValueType2FormatChoice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RateValueType2FormatChoice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => RateValueType2FormatChoice.Code.Deserialize(elementWithPayload),
             "Prtry" => RateValueType2FormatChoice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RateValueType2FormatChoice choice.")
        };
    }
}
