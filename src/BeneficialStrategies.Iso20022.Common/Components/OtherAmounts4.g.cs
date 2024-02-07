﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OtherAmounts4.  ISO2002 ID# _STaLENp-Ed-ak6NoX_4Aeg_1354169516.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies other amounts pertaining to the transaction.
/// </summary>
public partial record OtherAmounts4
     : IIsoXmlSerilizable<OtherAmounts4>
{
    #nullable enable
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    public AmountAndDirection9? AccruedInterestAmount { get; init; } 
    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    public AmountAndDirection9? ChargesFees { get; init; } 
    /// <summary>
    /// Amount of country, national or federal tax charged by the jurisdiction in which the account servicer is located.
    /// </summary>
    public AmountAndDirection9? CountryNationalFederalTax { get; init; } 
    /// <summary>
    /// Principal amount of a trade (price multiplied by quantity).
    /// </summary>
    public AmountAndDirection9? TradeAmount { get; init; } 
    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    public AmountAndDirection9? ExecutingBrokerAmount { get; init; } 
    /// <summary>
    /// Amount of money defined as a discount on a new issue or on a tranche of an existing issue.
    /// </summary>
    public AmountAndDirection9? IssueDiscountAllowance { get; init; } 
    /// <summary>
    /// Amount of payment levy tax.
    /// </summary>
    public AmountAndDirection9? PaymentLevyTax { get; init; } 
    /// <summary>
    /// Tax charged by the jurisdiction in which the financial instrument settles.
    /// </summary>
    public AmountAndDirection9? LocalTax { get; init; } 
    /// <summary>
    /// Amount of commission paid to a local broker.
    /// </summary>
    public AmountAndDirection9? LocalBrokerCommission { get; init; } 
    /// <summary>
    /// Amount of money deposited by the trading party in a margin account.
    /// </summary>
    public AmountAndDirection9? Margin { get; init; } 
    /// <summary>
    /// An amount that is not indicated by a known business denomination.
    /// </summary>
    public AmountAndDirection9? Other { get; init; } 
    /// <summary>
    /// Amount of money paid for delivery by regular post mail.
    /// </summary>
    public AmountAndDirection9? PostageAmount { get; init; } 
    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, Securities and Exchange fees.
    /// </summary>
    public AmountAndDirection9? RegulatoryAmount { get; init; } 
    /// <summary>
    /// Amount of money (including insurance) paid for delivery by carrier.
    /// </summary>
    public AmountAndDirection9? ShippingAmount { get; init; } 
    /// <summary>
    /// Amount of drawdown or other reduction from or in addition to the deal price.
    /// </summary>
    public AmountAndDirection9? SpecialConcession { get; init; } 
    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    public AmountAndDirection9? StampDuty { get; init; } 
    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    public AmountAndDirection9? StockExchangeTax { get; init; } 
    /// <summary>
    /// Amount of tax levied on a transfer of ownership of financial instrument.
    /// </summary>
    public AmountAndDirection9? TransferTax { get; init; } 
    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    public AmountAndDirection9? TransactionTax { get; init; } 
    /// <summary>
    /// Amount of value-added tax.
    /// </summary>
    public AmountAndDirection9? ValueAddedTax { get; init; } 
    /// <summary>
    /// Amount of money that will be withheld by a tax authority.
    /// </summary>
    public AmountAndDirection9? WithholdingTax { get; init; } 
    /// <summary>
    /// Amount representing the difference between the cost and the current price of a security. In the context of securities settlement, it is the amount paid or received when the instructions are netted or paired off.
    /// </summary>
    public AmountAndDirection9? NetGainLoss { get; init; } 
    /// <summary>
    /// Amount of consumption tax.
    /// </summary>
    public AmountAndDirection9? ConsumptionTax { get; init; } 
    /// <summary>
    /// Amount of unpaid interest (on bonds which have defaulted and have subsequently |restructured), which is capitalized and added to the original principal amount of the bond.
    /// </summary>
    public AmountAndDirection9? AccruedCapitalisationAmount { get; init; } 
    /// <summary>
    /// Cost of the securities. May be requested in some countries for tax purposes.
    /// </summary>
    public AmountAndDirection9? BookValue { get; init; } 
    
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
        if (AccruedInterestAmount is AmountAndDirection9 AccruedInterestAmountValue)
        {
            writer.WriteStartElement(null, "AcrdIntrstAmt", xmlNamespace );
            AccruedInterestAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ChargesFees is AmountAndDirection9 ChargesFeesValue)
        {
            writer.WriteStartElement(null, "ChrgsFees", xmlNamespace );
            ChargesFeesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CountryNationalFederalTax is AmountAndDirection9 CountryNationalFederalTaxValue)
        {
            writer.WriteStartElement(null, "CtryNtlFdrlTax", xmlNamespace );
            CountryNationalFederalTaxValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TradeAmount is AmountAndDirection9 TradeAmountValue)
        {
            writer.WriteStartElement(null, "TradAmt", xmlNamespace );
            TradeAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ExecutingBrokerAmount is AmountAndDirection9 ExecutingBrokerAmountValue)
        {
            writer.WriteStartElement(null, "ExctgBrkrAmt", xmlNamespace );
            ExecutingBrokerAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IssueDiscountAllowance is AmountAndDirection9 IssueDiscountAllowanceValue)
        {
            writer.WriteStartElement(null, "IsseDscntAllwnc", xmlNamespace );
            IssueDiscountAllowanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PaymentLevyTax is AmountAndDirection9 PaymentLevyTaxValue)
        {
            writer.WriteStartElement(null, "PmtLevyTax", xmlNamespace );
            PaymentLevyTaxValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LocalTax is AmountAndDirection9 LocalTaxValue)
        {
            writer.WriteStartElement(null, "LclTax", xmlNamespace );
            LocalTaxValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LocalBrokerCommission is AmountAndDirection9 LocalBrokerCommissionValue)
        {
            writer.WriteStartElement(null, "LclBrkrComssn", xmlNamespace );
            LocalBrokerCommissionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Margin is AmountAndDirection9 MarginValue)
        {
            writer.WriteStartElement(null, "Mrgn", xmlNamespace );
            MarginValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Other is AmountAndDirection9 OtherValue)
        {
            writer.WriteStartElement(null, "Othr", xmlNamespace );
            OtherValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PostageAmount is AmountAndDirection9 PostageAmountValue)
        {
            writer.WriteStartElement(null, "PstgAmt", xmlNamespace );
            PostageAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RegulatoryAmount is AmountAndDirection9 RegulatoryAmountValue)
        {
            writer.WriteStartElement(null, "RgltryAmt", xmlNamespace );
            RegulatoryAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ShippingAmount is AmountAndDirection9 ShippingAmountValue)
        {
            writer.WriteStartElement(null, "ShppgAmt", xmlNamespace );
            ShippingAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SpecialConcession is AmountAndDirection9 SpecialConcessionValue)
        {
            writer.WriteStartElement(null, "SpclCncssn", xmlNamespace );
            SpecialConcessionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (StampDuty is AmountAndDirection9 StampDutyValue)
        {
            writer.WriteStartElement(null, "StmpDty", xmlNamespace );
            StampDutyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (StockExchangeTax is AmountAndDirection9 StockExchangeTaxValue)
        {
            writer.WriteStartElement(null, "StockXchgTax", xmlNamespace );
            StockExchangeTaxValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransferTax is AmountAndDirection9 TransferTaxValue)
        {
            writer.WriteStartElement(null, "TrfTax", xmlNamespace );
            TransferTaxValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransactionTax is AmountAndDirection9 TransactionTaxValue)
        {
            writer.WriteStartElement(null, "TxTax", xmlNamespace );
            TransactionTaxValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ValueAddedTax is AmountAndDirection9 ValueAddedTaxValue)
        {
            writer.WriteStartElement(null, "ValAddedTax", xmlNamespace );
            ValueAddedTaxValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (WithholdingTax is AmountAndDirection9 WithholdingTaxValue)
        {
            writer.WriteStartElement(null, "WhldgTax", xmlNamespace );
            WithholdingTaxValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NetGainLoss is AmountAndDirection9 NetGainLossValue)
        {
            writer.WriteStartElement(null, "NetGnLoss", xmlNamespace );
            NetGainLossValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ConsumptionTax is AmountAndDirection9 ConsumptionTaxValue)
        {
            writer.WriteStartElement(null, "CsmptnTax", xmlNamespace );
            ConsumptionTaxValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccruedCapitalisationAmount is AmountAndDirection9 AccruedCapitalisationAmountValue)
        {
            writer.WriteStartElement(null, "AcrdCptlstnAmt", xmlNamespace );
            AccruedCapitalisationAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BookValue is AmountAndDirection9 BookValueValue)
        {
            writer.WriteStartElement(null, "BookVal", xmlNamespace );
            BookValueValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static OtherAmounts4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
