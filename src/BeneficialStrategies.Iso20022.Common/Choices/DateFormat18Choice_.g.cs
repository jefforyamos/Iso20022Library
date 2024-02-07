﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DateFormat18Choice.  ISO2002 ID# _QhuyIeENEd-qUMZtd_eZuQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the value of a date.
/// </summary>
[KnownType(typeof(DateFormat18Choice.Date))]
[KnownType(typeof(DateFormat18Choice.NotSpecifiedDate))]
public abstract partial record DateFormat18Choice_ : IIsoXmlSerilizable<DateFormat18Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static DateFormat18Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Dt" => DateFormat18Choice.Date.Deserialize(elementWithPayload),
             "NotSpcfdDt" => DateFormat18Choice.NotSpecifiedDate.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid DateFormat18Choice choice.")
        };
    }
}
