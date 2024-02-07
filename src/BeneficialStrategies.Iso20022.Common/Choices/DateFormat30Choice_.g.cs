﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DateFormat30Choice.  ISO2002 ID# _X1sw4UECEeWVgfuHGaKtRQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between an ISODate format or a date code.
/// </summary>
[KnownType(typeof(DateFormat30Choice.Date))]
[KnownType(typeof(DateFormat30Choice.DateCode))]
public abstract partial record DateFormat30Choice_ : IIsoXmlSerilizable<DateFormat30Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static DateFormat30Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Dt" => DateFormat30Choice.Date.Deserialize(elementWithPayload),
             "DtCd" => DateFormat30Choice.DateCode.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid DateFormat30Choice choice.")
        };
    }
}
