﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Period5Choice.  ISO2002 ID# _W6N3ca3NEeey8N0JWnVPUw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between date and date-time for the specification of a period.
/// </summary>
[KnownType(typeof(Period5Choice.FromDateTimeToDateTime))]
[KnownType(typeof(Period5Choice.FromDateToDate))]
public abstract partial record Period5Choice_ : IIsoXmlSerilizable<Period5Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static Period5Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "FrDtTmToDtTm" => Period5Choice.FromDateTimeToDateTime.Deserialize(elementWithPayload),
             "FrDtToDt" => Period5Choice.FromDateToDate.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid Period5Choice choice.")
        };
    }
}
