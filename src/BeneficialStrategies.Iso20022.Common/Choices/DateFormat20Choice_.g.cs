﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DateFormat20Choice.  ISO2002 ID# _lH2aRfZFEd-2Jsl2KtUQCw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between an ISODate or ISODateTime format or a date code or a date code and a time.
/// </summary>
[KnownType(typeof(DateFormat20Choice.Date))]
[KnownType(typeof(DateFormat20Choice.DateCodeAndTime))]
[KnownType(typeof(DateFormat20Choice.DateCode))]
public abstract partial record DateFormat20Choice_ : IIsoXmlSerilizable<DateFormat20Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static DateFormat20Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Dt" => DateFormat20Choice.Date.Deserialize(elementWithPayload),
             "DtCdAndTm" => DateFormat20Choice.DateCodeAndTime.Deserialize(elementWithPayload),
             "DtCd" => DateFormat20Choice.DateCode.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid DateFormat20Choice choice.")
        };
    }
}
