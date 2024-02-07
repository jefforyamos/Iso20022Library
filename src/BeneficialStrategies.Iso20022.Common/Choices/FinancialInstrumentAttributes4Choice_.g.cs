﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FinancialInstrumentAttributes4Choice.  ISO2002 ID# _F042MZ3CEeuwmdq0KtnICg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the attributes of the financial instrument.
/// </summary>
[KnownType(typeof(FinancialInstrumentAttributes4Choice.Identification))]
[KnownType(typeof(FinancialInstrumentAttributes4Choice.Other))]
public abstract partial record FinancialInstrumentAttributes4Choice_ : IIsoXmlSerilizable<FinancialInstrumentAttributes4Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static FinancialInstrumentAttributes4Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Id" => FinancialInstrumentAttributes4Choice.Identification.Deserialize(elementWithPayload),
             "Othr" => FinancialInstrumentAttributes4Choice.Other.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid FinancialInstrumentAttributes4Choice choice.")
        };
    }
}
