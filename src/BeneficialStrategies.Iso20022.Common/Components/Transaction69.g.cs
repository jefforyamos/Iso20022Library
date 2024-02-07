﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transaction69.  ISO2002 ID# _j37IedByEeihG9bKfarOOA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the transaction.
/// </summary>
public partial record Transaction69
     : IIsoXmlSerilizable<Transaction69>
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as known by the account owner (or the instructing party managing the account).
    /// </summary>
    public required IsoMax35Text AccountOwnerTransactionIdentification { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction as known by the account servicer.
    /// </summary>
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the transaction assigned by the processor of the instruction other than the account owner, the account servicer and the market infrastructure.
    /// </summary>
    public IsoMax35Text? ProcessorTransactionIdentification { get; init; } 
    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
    /// </summary>
    public IsoMax52Text? TradeIdentification { get; init; } 
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    public IsoMax35Text? PoolIdentification { get; init; } 
    /// <summary>
    /// Unique reference agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    public IsoMax35Text? CommonIdentification { get; init; } 
    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    public IsoMax35Text? CorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Unique identification identifying the triparty collateral management transaction from the triparty-agent's/service-provider's point of view.
    /// </summary>
    public IsoMax35Text? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the client's point of view.
    /// </summary>
    public IsoMax35Text? ClientTripartyCollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification assigned to the instruction by the client.
    /// </summary>
    public IsoMax35Text? ClientCollateralInstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification assigned to the instruction by the triparty-agent/service-provider.
    /// </summary>
    public IsoMax35Text? TripartyAgentServiceProviderCollateralInstructionIdentification { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    public AdditionalReference10? ClientReference { get; init; } 
    /// <summary>
    /// Unique technical identifier for the instance of the leg within a switch.
    /// </summary>
    public IsoMax35Text? AccountOwnerLegIdentification { get; init; } 
    /// <summary>
    /// Unique identifier for the instance of the leg execution within a switch confirmation.
    /// </summary>
    public IsoMax35Text? AccountServicerLegIdentification { get; init; } 
    /// <summary>
    /// Identifies the details of the transaction.
    /// </summary>
    public TransactionDetails114? TransactionDetails { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
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
        writer.WriteStartElement(null, "AcctOwnrTxId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountOwnerTransactionIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (AccountServicerTransactionIdentification is IsoMax35Text AccountServicerTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "AcctSvcrTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountServicerTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (MarketInfrastructureTransactionIdentification is IsoMax35Text MarketInfrastructureTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "MktInfrstrctrTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MarketInfrastructureTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ProcessorTransactionIdentification is IsoMax35Text ProcessorTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "PrcrTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ProcessorTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TradeIdentification is IsoMax52Text TradeIdentificationValue)
        {
            writer.WriteStartElement(null, "TradId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax52Text(TradeIdentificationValue)); // data type Max52Text System.String
            writer.WriteEndElement();
        }
        if (PoolIdentification is IsoMax35Text PoolIdentificationValue)
        {
            writer.WriteStartElement(null, "PoolId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(PoolIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CommonIdentification is IsoMax35Text CommonIdentificationValue)
        {
            writer.WriteStartElement(null, "CmonId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CommonIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CorporateActionEventIdentification is IsoMax35Text CorporateActionEventIdentificationValue)
        {
            writer.WriteStartElement(null, "CorpActnEvtId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CorporateActionEventIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TripartyAgentServiceProviderCollateralTransactionIdentification is IsoMax35Text TripartyAgentServiceProviderCollateralTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "TrptyAgtSvcPrvdrCollTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TripartyAgentServiceProviderCollateralTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ClientTripartyCollateralTransactionIdentification is IsoMax35Text ClientTripartyCollateralTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "ClntTrptyCollTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ClientTripartyCollateralTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ClientCollateralInstructionIdentification is IsoMax35Text ClientCollateralInstructionIdentificationValue)
        {
            writer.WriteStartElement(null, "ClntCollInstrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ClientCollateralInstructionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TripartyAgentServiceProviderCollateralInstructionIdentification is IsoMax35Text TripartyAgentServiceProviderCollateralInstructionIdentificationValue)
        {
            writer.WriteStartElement(null, "TrptyAgtSvcPrvdrCollInstrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TripartyAgentServiceProviderCollateralInstructionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (MasterReference is IsoMax35Text MasterReferenceValue)
        {
            writer.WriteStartElement(null, "MstrRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MasterReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ClientReference is AdditionalReference10 ClientReferenceValue)
        {
            writer.WriteStartElement(null, "ClntRef", xmlNamespace );
            ClientReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountOwnerLegIdentification is IsoMax35Text AccountOwnerLegIdentificationValue)
        {
            writer.WriteStartElement(null, "AcctOwnrLegId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountOwnerLegIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (AccountServicerLegIdentification is IsoMax35Text AccountServicerLegIdentificationValue)
        {
            writer.WriteStartElement(null, "AcctSvcrLegId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountServicerLegIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TransactionDetails is TransactionDetails114 TransactionDetailsValue)
        {
            writer.WriteStartElement(null, "TxDtls", xmlNamespace );
            TransactionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Transaction69 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
