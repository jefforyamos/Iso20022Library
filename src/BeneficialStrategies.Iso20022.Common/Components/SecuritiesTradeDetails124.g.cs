﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesTradeDetails124.  ISO2002 ID# _wKmLSyAZEeu4a6pNulzZ4Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the securities trade.
/// </summary>
public partial record SecuritiesTradeDetails124
     : IIsoXmlSerilizable<SecuritiesTradeDetails124>
{
    #nullable enable
    
    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    public PlaceOfTradeIdentification2? PlaceOfTrade { get; init; } 
    /// <summary>
    /// Infrastructure which may be a component of a clearing house and which facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
    /// </summary>
    public PlaceOfClearingIdentification2? PlaceOfClearing { get; init; } 
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    public TradeDate9Choice_? TradeDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    public SettlementDate20Choice_? SettlementDate { get; init; } 
    /// <summary>
    /// Date and time at which a transaction is completed and cleared, that is, payment is effected and securities are delivered.
    /// </summary>
    public required SettlementDate22Choice_ EffectiveSettlementDate { get; init; } 
    /// <summary>
    /// Specifies the price of the traded financial instrument.|This is the deal price of the individual trade transaction. |If there is only one trade transaction for the execution of the trade, then the deal price could equal the executed trade price (unless, for example, the price includes commissions or rounding, or some other factor has been applied to the deal price or the executed trade price, or both).
    /// </summary>
    public Price11? DealPrice { get; init; } 
    /// <summary>
    /// Specifies that a trade is to be reported to a third party.
    /// </summary>
    public Reporting9Choice_? Reporting { get; init; } 
    /// <summary>
    /// Number of days on which the interest rate accrues (daily accrual note).
    /// </summary>
    public IsoMax3Number? NumberOfDaysAccrued { get; init; } 
    /// <summary>
    /// Indicates the conditions under which the order/trade is to be/was executed.
    /// </summary>
    public TradeTransactionCondition6Choice_? TradeTransactionCondition { get; init; } 
    /// <summary>
    /// Specifies the role of the investor in the transaction.
    /// </summary>
    public InvestorCapacity5Choice_? InvestorCapacity { get; init; } 
    /// <summary>
    /// Specifies the role of the trading party in the transaction.
    /// </summary>
    public TradeOriginator4Choice_? TradeOriginatorRole { get; init; } 
    /// <summary>
    /// Provides additional settlement processing information which cannot be included within the structured fields of the message.
    /// </summary>
    public IsoRestrictedFINXMax350Text? SettlementInstructionProcessingAdditionalDetails { get; init; } 
    /// <summary>
    /// Provides additional details pertaining to foreign exchange instructions.
    /// </summary>
    public IsoRestrictedFINXMax350Text? FXAdditionalDetails { get; init; } 
    
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
        if (PlaceOfTrade is PlaceOfTradeIdentification2 PlaceOfTradeValue)
        {
            writer.WriteStartElement(null, "PlcOfTrad", xmlNamespace );
            PlaceOfTradeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PlaceOfClearing is PlaceOfClearingIdentification2 PlaceOfClearingValue)
        {
            writer.WriteStartElement(null, "PlcOfClr", xmlNamespace );
            PlaceOfClearingValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TradeDate is TradeDate9Choice_ TradeDateValue)
        {
            writer.WriteStartElement(null, "TradDt", xmlNamespace );
            TradeDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementDate is SettlementDate20Choice_ SettlementDateValue)
        {
            writer.WriteStartElement(null, "SttlmDt", xmlNamespace );
            SettlementDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "FctvSttlmDt", xmlNamespace );
        EffectiveSettlementDate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (DealPrice is Price11 DealPriceValue)
        {
            writer.WriteStartElement(null, "DealPric", xmlNamespace );
            DealPriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Reporting is Reporting9Choice_ ReportingValue)
        {
            writer.WriteStartElement(null, "Rptg", xmlNamespace );
            ReportingValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NumberOfDaysAccrued is IsoMax3Number NumberOfDaysAccruedValue)
        {
            writer.WriteStartElement(null, "NbOfDaysAcrd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax3Number(NumberOfDaysAccruedValue)); // data type Max3Number System.UInt64
            writer.WriteEndElement();
        }
        if (TradeTransactionCondition is TradeTransactionCondition6Choice_ TradeTransactionConditionValue)
        {
            writer.WriteStartElement(null, "TradTxCond", xmlNamespace );
            TradeTransactionConditionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InvestorCapacity is InvestorCapacity5Choice_ InvestorCapacityValue)
        {
            writer.WriteStartElement(null, "InvstrCpcty", xmlNamespace );
            InvestorCapacityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TradeOriginatorRole is TradeOriginator4Choice_ TradeOriginatorRoleValue)
        {
            writer.WriteStartElement(null, "TradOrgtrRole", xmlNamespace );
            TradeOriginatorRoleValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementInstructionProcessingAdditionalDetails is IsoRestrictedFINXMax350Text SettlementInstructionProcessingAdditionalDetailsValue)
        {
            writer.WriteStartElement(null, "SttlmInstrPrcgAddtlDtls", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax350Text(SettlementInstructionProcessingAdditionalDetailsValue)); // data type RestrictedFINXMax350Text System.String
            writer.WriteEndElement();
        }
        if (FXAdditionalDetails is IsoRestrictedFINXMax350Text FXAdditionalDetailsValue)
        {
            writer.WriteStartElement(null, "FxAddtlDtls", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax350Text(FXAdditionalDetailsValue)); // data type RestrictedFINXMax350Text System.String
            writer.WriteEndElement();
        }
    }
    public static SecuritiesTradeDetails124 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
