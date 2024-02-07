﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DateCode19Choice.  ISO2002 ID# _KEW2E0EEEeWVgfuHGaKtRQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a code or a proprietary code for a date code.
/// </summary>
[KnownType(typeof(DateCode19Choice.Code))]
[KnownType(typeof(DateCode19Choice.Proprietary))]
public abstract partial record DateCode19Choice_ : IIsoXmlSerilizable<DateCode19Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static DateCode19Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => DateCode19Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => DateCode19Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid DateCode19Choice choice.")
        };
    }
}
