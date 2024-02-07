﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesSettlementTransactionDetails9.  ISO2002 ID# _w_5WkQ0BEeKd14R19frrfQ.
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
public partial record SecuritiesSettlementTransactionDetails9
     : IIsoXmlSerilizable<SecuritiesSettlementTransactionDetails9>
{
    #nullable enable
    
    /// <summary>
    /// Provides settlement type and identification information.
    /// </summary>
    public SettlementTypeAndAdditionalParameters6? SettlementTypeAndAdditionalParameters { get; init; } 
    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    public Linkages21? Linkages { get; init; } 
    /// <summary>
    /// Details of the trade.
    /// </summary>
    public SecuritiesTradeDetails25? TradeDetails { get; init; } 
    /// <summary>
    /// Attributes defining a financial instrument.
    /// </summary>
    public FinancialInstrumentAttributes35? FinancialInstrumentAttributes { get; init; } 
    /// <summary>
    /// Details related to the account and quantity involved in the transaction.
    /// </summary>
    public QuantityAndAccount29? QuantityAndAccountDetails { get; init; } 
    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    public SettlementDetails50? SettlementParameters { get; init; } 
    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    public StandingSettlementInstruction4? StandingSettlementInstructionDetails { get; init; } 
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    public SettlementParties26? DeliveringSettlementParties { get; init; } 
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    public SettlementParties26? ReceivingSettlementParties { get; init; } 
    /// <summary>
    /// Cash parties involved in the transaction if different for the securities settlement parties.
    /// </summary>
    public CashParties17? CashParties { get; init; } 
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    public AmountAndDirection32? SettlementAmount { get; init; } 
    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    public OtherAmounts14? OtherAmounts { get; init; } 
    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    public OtherParties19? OtherBusinessParties { get; init; } 
    /// <summary>
    /// Provides information required for the registration or physical settlement.
    /// </summary>
    public RegistrationParameters1? AdditionalPhysicalOrRegistrationDetails { get; init; } 
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
        if (SettlementTypeAndAdditionalParameters is SettlementTypeAndAdditionalParameters6 SettlementTypeAndAdditionalParametersValue)
        {
            writer.WriteStartElement(null, "SttlmTpAndAddtlParams", xmlNamespace );
            SettlementTypeAndAdditionalParametersValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Linkages is Linkages21 LinkagesValue)
        {
            writer.WriteStartElement(null, "Lnkgs", xmlNamespace );
            LinkagesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TradeDetails is SecuritiesTradeDetails25 TradeDetailsValue)
        {
            writer.WriteStartElement(null, "TradDtls", xmlNamespace );
            TradeDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FinancialInstrumentAttributes is FinancialInstrumentAttributes35 FinancialInstrumentAttributesValue)
        {
            writer.WriteStartElement(null, "FinInstrmAttrbts", xmlNamespace );
            FinancialInstrumentAttributesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (QuantityAndAccountDetails is QuantityAndAccount29 QuantityAndAccountDetailsValue)
        {
            writer.WriteStartElement(null, "QtyAndAcctDtls", xmlNamespace );
            QuantityAndAccountDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementParameters is SettlementDetails50 SettlementParametersValue)
        {
            writer.WriteStartElement(null, "SttlmParams", xmlNamespace );
            SettlementParametersValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (StandingSettlementInstructionDetails is StandingSettlementInstruction4 StandingSettlementInstructionDetailsValue)
        {
            writer.WriteStartElement(null, "StgSttlmInstrDtls", xmlNamespace );
            StandingSettlementInstructionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeliveringSettlementParties is SettlementParties26 DeliveringSettlementPartiesValue)
        {
            writer.WriteStartElement(null, "DlvrgSttlmPties", xmlNamespace );
            DeliveringSettlementPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReceivingSettlementParties is SettlementParties26 ReceivingSettlementPartiesValue)
        {
            writer.WriteStartElement(null, "RcvgSttlmPties", xmlNamespace );
            ReceivingSettlementPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashParties is CashParties17 CashPartiesValue)
        {
            writer.WriteStartElement(null, "CshPties", xmlNamespace );
            CashPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementAmount is AmountAndDirection32 SettlementAmountValue)
        {
            writer.WriteStartElement(null, "SttlmAmt", xmlNamespace );
            SettlementAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherAmounts is OtherAmounts14 OtherAmountsValue)
        {
            writer.WriteStartElement(null, "OthrAmts", xmlNamespace );
            OtherAmountsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherBusinessParties is OtherParties19 OtherBusinessPartiesValue)
        {
            writer.WriteStartElement(null, "OthrBizPties", xmlNamespace );
            OtherBusinessPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalPhysicalOrRegistrationDetails is RegistrationParameters1 AdditionalPhysicalOrRegistrationDetailsValue)
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
    public static SecuritiesSettlementTransactionDetails9 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
