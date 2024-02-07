﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Period7Choice.  ISO2002 ID# _VEuSoTwGEemGDJYTly2NCA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between date and date-time for the specification of a period.
/// </summary>
[KnownType(typeof(Period7Choice.FromDateTimeToDateTime))]
[KnownType(typeof(Period7Choice.FromDateToDate))]
public abstract partial record Period7Choice_ : IIsoXmlSerilizable<Period7Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static Period7Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "FrDtTmToDtTm" => Period7Choice.FromDateTimeToDateTime.Deserialize(elementWithPayload),
             "FrDtToDt" => Period7Choice.FromDateToDate.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid Period7Choice choice.")
        };
    }
}
