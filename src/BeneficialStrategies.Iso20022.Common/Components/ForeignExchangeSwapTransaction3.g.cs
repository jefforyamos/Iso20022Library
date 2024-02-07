﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ForeignExchangeSwapTransaction3.  ISO2002 ID# _r9-RMcEUEea7jLfvGi1PDw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of each individual foreign exchange swap transaction.
/// </summary>
public partial record ForeignExchangeSwapTransaction3
     : IIsoXmlSerilizable<ForeignExchangeSwapTransaction3>
{
    #nullable enable
    
    /// <summary>
    /// Defines the status of the reported transaction, that is details on whether the transaction is a new transaction, an amendment of a previously reported transaction, a cancellation of a previously reported transaction or a correction to a previously reported and rejected transaction.
    /// </summary>
    public required TransactionOperationType1Code ReportedTransactionStatus { get; init; } 
    /// <summary>
    /// Provides the novation status for the transaction.
    /// </summary>
    public NovationStatus1Code? NovationStatus { get; init; } 
    /// <summary>
    /// Unique and unambiguous legal entity identification of the branch of the reporting agent in which the transaction has been booked.
    /// Usage: This field must only be provided if the transaction has been conducted and booked by a branch of the reporting agent and only if this branch has its own LEI that the reporting agent can clearly identify. 
    /// Where the transaction has been booked by the head office or the reporting agent cannot be identified by a unique branch-specific LEI, the reporting agent must provide the LEI of the head office.
    /// </summary>
    public IsoLEIIdentifier? BranchIdentification { get; init; } 
    /// <summary>
    /// Unique transaction identifier will be created at the time a transaction is first executed, shared with all registered entities and counterparties involved in the transaction, and used to track that particular transaction during its lifetime.
    /// </summary>
    public IsoMax105Text? UniqueTransactionIdentifier { get; init; } 
    /// <summary>
    /// Internal unique transaction identifier used by the reporting agent for each transaction.
    /// </summary>
    public required IsoMax105Text ProprietaryTransactionIdentification { get; init; } 
    /// <summary>
    /// Original proprietary transaction identifier used by the reporting agent to indicate the proprietary transaction identification of the transaction which is novated.
    /// </summary>
    public IsoMax105Text? RelatedProprietaryTransactionIdentification { get; init; } 
    /// <summary>
    /// Internal unique proprietary transaction identifier as assigned by the counterparty of the reporting agent for each transaction.
    /// </summary>
    public IsoMax105Text? CounterpartyProprietaryTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the counterparty of the reporting agent for the reported transaction.
    /// </summary>
    public required CounterpartyIdentification3Choice_ CounterpartyIdentification { get; init; } 
    /// <summary>
    /// Date and time on which the parties entered into the reported transaction.
    /// Usage: when time is available, it must be reported.
    /// It is to be reported with only the date when the time of the transaction is not available. 
    /// The reported time is the execution time when available or otherwise the time at which the transaction entered the trading system of the reporting agent.
    /// </summary>
    public required DateAndDateTimeChoice_ TradeDate { get; init; } 
    /// <summary>
    /// Date on which one party sells to the other a specified amount of a specified currency against payment of an agreed amount of a specified different currency based on an agreed foreign exchange rate known as foreign exchange spot rate.
    /// </summary>
    public required IsoISODate SpotValueDate { get; init; } 
    /// <summary>
    /// Date on which the foreign exchange swap transaction expires and the currency sold on the value date is repurchased.
    /// </summary>
    public required IsoISODate MaturityDate { get; init; } 
    /// <summary>
    /// Defines whether the amount of money reported under the transaction nominal amount is bought or sold on the spot value date.
    /// </summary>
    public required SecuritiesTransactionType15Code TransactionType { get; init; } 
    /// <summary>
    /// Specifies the nominal amount of the foreign exchange swap, that is the amount bought/sold on the spot value date and reported as an absolute value.
    /// </summary>
    public required IsoActiveCurrencyAndAmount TransactionNominalAmount { get; init; } 
    /// <summary>
    /// Provides the details of the foreign exchange transaction.
    /// </summary>
    public required ForeignExchange1 ForeignExchange { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init; } 
    
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
        writer.WriteStartElement(null, "RptdTxSts", xmlNamespace );
        writer.WriteValue(ReportedTransactionStatus.ToString()); // Enum value
        writer.WriteEndElement();
        if (NovationStatus is NovationStatus1Code NovationStatusValue)
        {
            writer.WriteStartElement(null, "NvtnSts", xmlNamespace );
            writer.WriteValue(NovationStatusValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (BranchIdentification is IsoLEIIdentifier BranchIdentificationValue)
        {
            writer.WriteStartElement(null, "BrnchId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoLEIIdentifier(BranchIdentificationValue)); // data type LEIIdentifier System.String
            writer.WriteEndElement();
        }
        if (UniqueTransactionIdentifier is IsoMax105Text UniqueTransactionIdentifierValue)
        {
            writer.WriteStartElement(null, "UnqTxIdr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax105Text(UniqueTransactionIdentifierValue)); // data type Max105Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PrtryTxId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax105Text(ProprietaryTransactionIdentification)); // data type Max105Text System.String
        writer.WriteEndElement();
        if (RelatedProprietaryTransactionIdentification is IsoMax105Text RelatedProprietaryTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "RltdPrtryTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax105Text(RelatedProprietaryTransactionIdentificationValue)); // data type Max105Text System.String
            writer.WriteEndElement();
        }
        if (CounterpartyProprietaryTransactionIdentification is IsoMax105Text CounterpartyProprietaryTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "CtrPtyPrtryTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax105Text(CounterpartyProprietaryTransactionIdentificationValue)); // data type Max105Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CtrPtyId", xmlNamespace );
        CounterpartyIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TradDt", xmlNamespace );
        TradeDate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SpotValDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(SpotValueDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        writer.WriteStartElement(null, "MtrtyDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(MaturityDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TxTp", xmlNamespace );
        writer.WriteValue(TransactionType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TxNmnlAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(TransactionNominalAmount)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "FX", xmlNamespace );
        ForeignExchange.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ForeignExchangeSwapTransaction3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
