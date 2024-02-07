﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DateCode3Choice.  ISO2002 ID# _Q48_SNp-Ed-ak6NoX_4Aeg_1411669579.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a code or a proprietary code for a date code.
/// </summary>
[KnownType(typeof(DateCode3Choice.Code))]
[KnownType(typeof(DateCode3Choice.Proprietary))]
public abstract partial record DateCode3Choice_ : IIsoXmlSerilizable<DateCode3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static DateCode3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => DateCode3Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => DateCode3Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid DateCode3Choice choice.")
        };
    }
}
