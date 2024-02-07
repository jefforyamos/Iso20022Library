﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TradeData34Choice.  ISO2002 ID# _Ap4T0cK3EeuFNp8LZAnorg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Set of data concerning the reporting trade.
/// </summary>
[KnownType(typeof(TradeData34Choice.DataSetAction))]
[KnownType(typeof(TradeData34Choice.Report))]
public abstract partial record TradeData34Choice_ : IIsoXmlSerilizable<TradeData34Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static TradeData34Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "DataSetActn" => TradeData34Choice.DataSetAction.Deserialize(elementWithPayload),
             "Rpt" => TradeData34Choice.Report.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid TradeData34Choice choice.")
        };
    }
}
