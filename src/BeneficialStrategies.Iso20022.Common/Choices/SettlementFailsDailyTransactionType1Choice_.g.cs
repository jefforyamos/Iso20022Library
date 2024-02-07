﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlementFailsDailyTransactionType1Choice.  ISO2002 ID# _9tfhEzOYEeqBfed1bmSPqg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the transaction type as defined in the relevant regulation or explicit no data report.
/// </summary>
[KnownType(typeof(SettlementFailsDailyTransactionType1Choice.DataSetAction))]
[KnownType(typeof(SettlementFailsDailyTransactionType1Choice.Data))]
public abstract partial record SettlementFailsDailyTransactionType1Choice_ : IIsoXmlSerilizable<SettlementFailsDailyTransactionType1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static SettlementFailsDailyTransactionType1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "DataSetActn" => SettlementFailsDailyTransactionType1Choice.DataSetAction.Deserialize(elementWithPayload),
             "Data" => SettlementFailsDailyTransactionType1Choice.Data.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid SettlementFailsDailyTransactionType1Choice choice.")
        };
    }
}
