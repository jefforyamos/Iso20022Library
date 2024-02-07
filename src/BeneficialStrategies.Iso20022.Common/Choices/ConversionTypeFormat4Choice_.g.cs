﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ConversionTypeFormat4Choice.  ISO2002 ID# _c5VTb5KQEeWHWpTQn1FFVg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a standard code or proprietary code to specify the type of conversion.
/// </summary>
[KnownType(typeof(ConversionTypeFormat4Choice.Code))]
[KnownType(typeof(ConversionTypeFormat4Choice.Proprietary))]
public abstract partial record ConversionTypeFormat4Choice_ : IIsoXmlSerilizable<ConversionTypeFormat4Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static ConversionTypeFormat4Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => ConversionTypeFormat4Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => ConversionTypeFormat4Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid ConversionTypeFormat4Choice choice.")
        };
    }
}
