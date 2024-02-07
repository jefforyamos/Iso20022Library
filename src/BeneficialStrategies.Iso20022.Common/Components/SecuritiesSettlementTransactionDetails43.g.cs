﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesSettlementTransactionDetails43.  ISO2002 ID# _fp1I-_fYEeiNZp_PtLohLw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the update(s) for the settlement transaction.
/// </summary>
public partial record SecuritiesSettlementTransactionDetails43
     : IIsoXmlSerilizable<SecuritiesSettlementTransactionDetails43>
{
    #nullable enable
    
    /// <summary>
    /// Provides settlement type and identification information.
    /// </summary>
    public SettlementTypeAndAdditionalParameters18? SettlementTypeAndAdditionalParameters { get; init; } 
    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    public Linkages48? Linkages { get; init; } 
    /// <summary>
    /// Details of the trade.
    /// </summary>
    public SecuritiesTradeDetails110? TradeDetails { get; init; } 
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    public SecurityIdentification20? FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Attributes defining a financial instrument.
    /// </summary>
    public FinancialInstrumentAttributes97? FinancialInstrumentAttributes { get; init; } 
    /// <summary>
    /// Details related to the account and quantity involved in the transaction.
    /// </summary>
    public QuantityAndAccount94? QuantityAndAccountDetails { get; init; } 
    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    public SettlementDetails179? SettlementParameters { get; init; } 
    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    public StandingSettlementInstruction17? StandingSettlementInstructionDetails { get; init; } 
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    public SettlementParties81? DeliveringSettlementParties { get; init; } 
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    public SettlementParties81? ReceivingSettlementParties { get; init; } 
    /// <summary>
    /// Cash parties involved in the transaction if different from the securities settlement parties.
    /// </summary>
    public CashParties38? CashParties { get; init; } 
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    public AmountAndDirection101? SettlementAmount { get; init; } 
    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    public OtherAmounts43? OtherAmounts { get; init; } 
    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    public OtherParties35? OtherBusinessParties { get; init; } 
    /// <summary>
    /// Provides information required for the registration or physical settlement.
    /// </summary>
    public RegistrationParameters7? AdditionalPhysicalOrRegistrationDetails { get; init; } 
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
        if (SettlementTypeAndAdditionalParameters is SettlementTypeAndAdditionalParameters18 SettlementTypeAndAdditionalParametersValue)
        {
            writer.WriteStartElement(null, "SttlmTpAndAddtlParams", xmlNamespace );
            SettlementTypeAndAdditionalParametersValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Linkages is Linkages48 LinkagesValue)
        {
            writer.WriteStartElement(null, "Lnkgs", xmlNamespace );
            LinkagesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TradeDetails is SecuritiesTradeDetails110 TradeDetailsValue)
        {
            writer.WriteStartElement(null, "TradDtls", xmlNamespace );
            TradeDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FinancialInstrumentIdentification is SecurityIdentification20 FinancialInstrumentIdentificationValue)
        {
            writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
            FinancialInstrumentIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FinancialInstrumentAttributes is FinancialInstrumentAttributes97 FinancialInstrumentAttributesValue)
        {
            writer.WriteStartElement(null, "FinInstrmAttrbts", xmlNamespace );
            FinancialInstrumentAttributesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (QuantityAndAccountDetails is QuantityAndAccount94 QuantityAndAccountDetailsValue)
        {
            writer.WriteStartElement(null, "QtyAndAcctDtls", xmlNamespace );
            QuantityAndAccountDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementParameters is SettlementDetails179 SettlementParametersValue)
        {
            writer.WriteStartElement(null, "SttlmParams", xmlNamespace );
            SettlementParametersValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (StandingSettlementInstructionDetails is StandingSettlementInstruction17 StandingSettlementInstructionDetailsValue)
        {
            writer.WriteStartElement(null, "StgSttlmInstrDtls", xmlNamespace );
            StandingSettlementInstructionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeliveringSettlementParties is SettlementParties81 DeliveringSettlementPartiesValue)
        {
            writer.WriteStartElement(null, "DlvrgSttlmPties", xmlNamespace );
            DeliveringSettlementPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReceivingSettlementParties is SettlementParties81 ReceivingSettlementPartiesValue)
        {
            writer.WriteStartElement(null, "RcvgSttlmPties", xmlNamespace );
            ReceivingSettlementPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashParties is CashParties38 CashPartiesValue)
        {
            writer.WriteStartElement(null, "CshPties", xmlNamespace );
            CashPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementAmount is AmountAndDirection101 SettlementAmountValue)
        {
            writer.WriteStartElement(null, "SttlmAmt", xmlNamespace );
            SettlementAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherAmounts is OtherAmounts43 OtherAmountsValue)
        {
            writer.WriteStartElement(null, "OthrAmts", xmlNamespace );
            OtherAmountsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherBusinessParties is OtherParties35 OtherBusinessPartiesValue)
        {
            writer.WriteStartElement(null, "OthrBizPties", xmlNamespace );
            OtherBusinessPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalPhysicalOrRegistrationDetails is RegistrationParameters7 AdditionalPhysicalOrRegistrationDetailsValue)
        {
            writer.WriteStartElement(null, "AddtlPhysOrRegnDtls", xmlNamespace );
            AdditionalPhysicalOrRegistrationDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecuritiesSettlementTransactionDetails43 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
