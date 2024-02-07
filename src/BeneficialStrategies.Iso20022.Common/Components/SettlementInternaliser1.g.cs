﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementInternaliser1.  ISO2002 ID# _x6_YcO3mEeaWjpoyrnG6Rw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the submitting entity and Settlement Internaliser of the report.
/// </summary>
public partial record SettlementInternaliser1
     : IIsoXmlSerilizable<SettlementInternaliser1>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the submitting entity and settlement Internaliser of the report.
    /// </summary>
    public required SettlementInternaliserIdentification1 Identification { get; init; } 
    /// <summary>
    /// Overall aggregated total value and volume of 
    /// - settled and failed and total of internalised settlement instructions, and
    /// - failed rate of internalised settlement instructions
    /// performed during the period covered by the report, for all financial instruments, types of transactions, types of clients and cash transfers.
    /// </summary>
    public required InternalisationData1 OverallTotal { get; init; } 
    /// <summary>
    /// Classification of a financial instrument according to the categories defined in the relevant legislation.
    /// </summary>
    public required SettlementInternaliserFinancialInstrument1 FinancialInstrument { get; init; } 
    /// <summary>
    /// Classification of securities movements according to the categories defined in the relevant legislation.
    /// </summary>
    public required SettlementInternaliserTransactionType1 TransactionType { get; init; } 
    /// <summary>
    /// Classification of a settlement internaliser's clients as referred to in the relevant legislation.
    /// </summary>
    public required SettlementInternaliserClientType1 ClientType { get; init; } 
    /// <summary>
    /// Covers cash payments related to securities transactions.
    /// </summary>
    public required InternalisationData1 TotalCashTransfer { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "OvrllTtl", xmlNamespace );
        OverallTotal.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "FinInstrm", xmlNamespace );
        FinancialInstrument.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TxTp", xmlNamespace );
        TransactionType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ClntTp", xmlNamespace );
        ClientType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TtlCshTrf", xmlNamespace );
        TotalCashTransfer.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static SettlementInternaliser1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
