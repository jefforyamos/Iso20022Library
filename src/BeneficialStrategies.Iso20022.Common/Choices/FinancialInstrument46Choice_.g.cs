﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FinancialInstrument46Choice.  ISO2002 ID# _X1AUQ738EeWvRsMSLyTf-A.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies underlying instruments or index a derivative has.
/// </summary>
[KnownType(typeof(FinancialInstrument46Choice.ISIN))]
[KnownType(typeof(FinancialInstrument46Choice.Index))]
public abstract partial record FinancialInstrument46Choice_ : IIsoXmlSerilizable<FinancialInstrument46Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static FinancialInstrument46Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "ISIN" => FinancialInstrument46Choice.ISIN.Deserialize(elementWithPayload),
             "Indx" => FinancialInstrument46Choice.Index.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid FinancialInstrument46Choice choice.")
        };
    }
}
