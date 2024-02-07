﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transaction119.  ISO2002 ID# _2xlVEyAeEeuyDZ-ukt4YRg.
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
public partial record Transaction119
     : IIsoXmlSerilizable<Transaction119>
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as known by the account owner (or the instructing party managing the account).
    /// </summary>
    public required IsoRestrictedFINXMax16Text AccountOwnerTransactionIdentification { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction as known by the account servicer.
    /// </summary>
    public IsoRestrictedFINXMax16Text? AccountServicerTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    public IsoRestrictedFINXMax16Text? MarketInfrastructureTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the transaction assigned by the processor of the instruction other than the account owner, the account servicer and the market infrastructure.
    /// </summary>
    public IsoRestrictedFINXMax16Text? ProcessorTransactionIdentification { get; init; } 
    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
    /// </summary>
    public IsoRestrictedFINXMax52Text? TradeIdentification { get; init; } 
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    public IsoRestrictedFINXMax16Text? PoolIdentification { get; init; } 
    /// <summary>
    /// Unique reference agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    public IsoRestrictedFINXMax16Text? CommonIdentification { get; init; } 
    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    public IsoRestrictedFINXMax16Text? CorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Unique identification identifying the triparty collateral management transaction from the triparty-agent's/service-provider's point of view.
    /// </summary>
    public IsoRestrictedFINXMax16Text? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the client's point of view.
    /// </summary>
    public IsoRestrictedFINXMax16Text? ClientTripartyCollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification assigned to the instruction by the client.
    /// </summary>
    public IsoRestrictedFINXMax16Text? ClientCollateralInstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification assigned to the instruction by the triparty-agent/service-provider.
    /// </summary>
    public IsoRestrictedFINXMax16Text? TripartyAgentServiceProviderCollateralInstructionIdentification { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    public IsoRestrictedFINXMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    public AdditionalReference12? ClientReference { get; init; } 
    /// <summary>
    /// Unique technical identifier for the instance of the leg within a switch.
    /// </summary>
    public IsoRestrictedFINXMax35Text? AccountOwnerLegIdentification { get; init; } 
    /// <summary>
    /// Unique identifier for the instance of the leg execution within a switch confirmation.
    /// </summary>
    public IsoRestrictedFINXMax35Text? AccountServicerLegIdentification { get; init; } 
    /// <summary>
    /// Identifies the details of the transaction.
    /// </summary>
    public TransactionDetails145? TransactionDetails { get; init; } 
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
        writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(AccountOwnerTransactionIdentification)); // data type RestrictedFINXMax16Text System.String
        writer.WriteEndElement();
        if (AccountServicerTransactionIdentification is IsoRestrictedFINXMax16Text AccountServicerTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "AcctSvcrTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(AccountServicerTransactionIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (MarketInfrastructureTransactionIdentification is IsoRestrictedFINXMax16Text MarketInfrastructureTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "MktInfrstrctrTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(MarketInfrastructureTransactionIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (ProcessorTransactionIdentification is IsoRestrictedFINXMax16Text ProcessorTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "PrcrTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(ProcessorTransactionIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (TradeIdentification is IsoRestrictedFINXMax52Text TradeIdentificationValue)
        {
            writer.WriteStartElement(null, "TradId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax52Text(TradeIdentificationValue)); // data type RestrictedFINXMax52Text System.String
            writer.WriteEndElement();
        }
        if (PoolIdentification is IsoRestrictedFINXMax16Text PoolIdentificationValue)
        {
            writer.WriteStartElement(null, "PoolId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(PoolIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (CommonIdentification is IsoRestrictedFINXMax16Text CommonIdentificationValue)
        {
            writer.WriteStartElement(null, "CmonId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(CommonIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (CorporateActionEventIdentification is IsoRestrictedFINXMax16Text CorporateActionEventIdentificationValue)
        {
            writer.WriteStartElement(null, "CorpActnEvtId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(CorporateActionEventIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (TripartyAgentServiceProviderCollateralTransactionIdentification is IsoRestrictedFINXMax16Text TripartyAgentServiceProviderCollateralTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "TrptyAgtSvcPrvdrCollTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(TripartyAgentServiceProviderCollateralTransactionIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (ClientTripartyCollateralTransactionIdentification is IsoRestrictedFINXMax16Text ClientTripartyCollateralTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "ClntTrptyCollTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(ClientTripartyCollateralTransactionIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (ClientCollateralInstructionIdentification is IsoRestrictedFINXMax16Text ClientCollateralInstructionIdentificationValue)
        {
            writer.WriteStartElement(null, "ClntCollInstrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(ClientCollateralInstructionIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (TripartyAgentServiceProviderCollateralInstructionIdentification is IsoRestrictedFINXMax16Text TripartyAgentServiceProviderCollateralInstructionIdentificationValue)
        {
            writer.WriteStartElement(null, "TrptyAgtSvcPrvdrCollInstrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(TripartyAgentServiceProviderCollateralInstructionIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (MasterReference is IsoRestrictedFINXMax35Text MasterReferenceValue)
        {
            writer.WriteStartElement(null, "MstrRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax35Text(MasterReferenceValue)); // data type RestrictedFINXMax35Text System.String
            writer.WriteEndElement();
        }
        if (ClientReference is AdditionalReference12 ClientReferenceValue)
        {
            writer.WriteStartElement(null, "ClntRef", xmlNamespace );
            ClientReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountOwnerLegIdentification is IsoRestrictedFINXMax35Text AccountOwnerLegIdentificationValue)
        {
            writer.WriteStartElement(null, "AcctOwnrLegId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax35Text(AccountOwnerLegIdentificationValue)); // data type RestrictedFINXMax35Text System.String
            writer.WriteEndElement();
        }
        if (AccountServicerLegIdentification is IsoRestrictedFINXMax35Text AccountServicerLegIdentificationValue)
        {
            writer.WriteStartElement(null, "AcctSvcrLegId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax35Text(AccountServicerLegIdentificationValue)); // data type RestrictedFINXMax35Text System.String
            writer.WriteEndElement();
        }
        if (TransactionDetails is TransactionDetails145 TransactionDetailsValue)
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
    public static Transaction119 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
