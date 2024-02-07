﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DateFormat48Choice.  ISO2002 ID# _lFUvAckbEee7W-rN1yqPMg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between an ISODate or ISODateTime format or a date code.
/// </summary>
[KnownType(typeof(DateFormat48Choice.Date))]
[KnownType(typeof(DateFormat48Choice.DateCode))]
public abstract partial record DateFormat48Choice_ : IIsoXmlSerilizable<DateFormat48Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static DateFormat48Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Dt" => DateFormat48Choice.Date.Deserialize(elementWithPayload),
             "DtCd" => DateFormat48Choice.DateCode.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid DateFormat48Choice choice.")
        };
    }
}
