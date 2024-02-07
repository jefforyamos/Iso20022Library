﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Period8Choice.  ISO2002 ID# _ctoHOP1cEeiAfJEqh4xF_Q.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between date and date-time for the specification of a period.
/// </summary>
[KnownType(typeof(Period8Choice.DateTime))]
[KnownType(typeof(Period8Choice.FromDateTime))]
[KnownType(typeof(Period8Choice.ToDateTime))]
[KnownType(typeof(Period8Choice.FromDateToDate))]
public abstract partial record Period8Choice_ : IIsoXmlSerilizable<Period8Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static Period8Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "DtTm" => Period8Choice.DateTime.Deserialize(elementWithPayload),
             "FrDtTm" => Period8Choice.FromDateTime.Deserialize(elementWithPayload),
             "ToDtTm" => Period8Choice.ToDateTime.Deserialize(elementWithPayload),
             "FrDtToDt" => Period8Choice.FromDateToDate.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid Period8Choice choice.")
        };
    }
}
