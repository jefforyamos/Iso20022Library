﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TaxVoucher1.  ISO2002 ID# _UB00vtp-Ed-ak6NoX_4Aeg_2027853243.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the tax voucher.
/// </summary>
public partial record TaxVoucher1
     : IIsoXmlSerilizable<TaxVoucher1>
{
    #nullable enable
    
    /// <summary>
    /// Distribution rate per share.
    /// </summary>
    public required IsoBaseOneRate TaxVoucherRate { get; init; } 
    /// <summary>
    /// Amount of tax that have been previously paid.
    /// </summary>
    public required IsoActiveCurrencyAndAmount TaxCredit { get; init; } 
    /// <summary>
    /// Amount of tax that have been previously deducted.
    /// </summary>
    public required IsoActiveCurrencyAndAmount TaxDeduction { get; init; } 
    /// <summary>
    /// Cash amount before any deductions and allowances have been made.
    /// </summary>
    public required IsoActiveCurrencyAndAmount GrossAmount { get; init; } 
    /// <summary>
    /// Cash amount after any deductions and allowances have been made.
    /// </summary>
    public required IsoActiveCurrencyAndAmount NetAmount { get; init; } 
    /// <summary>
    /// Securities holding on record date.
    /// </summary>
    public required UnitOrFaceAmount1Choice_ RecordDateHolding { get; init; } 
    /// <summary>
    /// Applicable tax rate on the tax credit amount.
    /// </summary>
    public IsoPercentageRate? TaxCreditRate { get; init; } 
    /// <summary>
    /// Cash amount that will be withheld by a tax authority.
    /// </summary>
    public IsoActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; } 
    /// <summary>
    /// Rate of a cash distribution that wil be withheld by a tax authority.
    /// </summary>
    public IsoPercentageRate? WithholdingTaxRate { get; init; } 
    /// <summary>
    /// Cost per share of new shares allotted.
    /// </summary>
    public PriceValue1? ScripDividendReinvestmentPricePerShare { get; init; } 
    /// <summary>
    /// Cash amount retained from previous dividend or interest payment.
    /// </summary>
    public IsoActiveCurrencyAndAmount? CashAmountBroughtForward { get; init; } 
    /// <summary>
    /// Total cash amount required to purchase shares allotted.
    /// </summary>
    public PriceValue1? AllotedSharesCost { get; init; } 
    /// <summary>
    /// Cash amount carried forward to next dividend or interest payment.
    /// </summary>
    public IsoActiveCurrencyAndAmount? CashAmountCarriedForward { get; init; } 
    /// <summary>
    /// Where new securities are issued in lieu of a cash dividend, the notional tax is the tax on the amount of cash that would have been paid. For scrips only.
    /// </summary>
    public IsoActiveCurrencyAndAmount? NotionalTax { get; init; } 
    /// <summary>
    /// Amount of cash that would have been payable if the dividend had been taken in the form of cash rather than shares. For scrip only.
    /// </summary>
    public IsoActiveCurrencyAndAmount? NotionalDividendPayable { get; init; } 
    /// <summary>
    /// Date on which DRIP purchase completed.
    /// </summary>
    public IsoISODate? BargainDate { get; init; } 
    /// <summary>
    /// Settlement date of the DRIP purchase transaction.
    /// </summary>
    public IsoISODate? BargainSettlementDate { get; init; } 
    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    public IsoActiveCurrencyAndAmount? StampDutyAmount { get; init; } 
    /// <summary>
    /// Amount of charges/fees charged to the client.
    /// </summary>
    public IsoActiveCurrencyAndAmount? ChargeAmount { get; init; } 
    /// <summary>
    /// Amount due to the paying agent.
    /// </summary>
    public IsoActiveCurrencyAndAmount? CommissionAmount { get; init; } 
    /// <summary>
    /// Provides information about the foreign exchange transaction.
    /// </summary>
    public ForeignExchangeTerms9? ForeignExchangeDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "TaxVchrRate", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoBaseOneRate(TaxVoucherRate)); // data type BaseOneRate System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TaxCdt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(TaxCredit)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TaxDdctn", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(TaxDeduction)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "GrssAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(GrossAmount)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "NetAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(NetAmount)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RcrdDtHldg", xmlNamespace );
        RecordDateHolding.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (TaxCreditRate is IsoPercentageRate TaxCreditRateValue)
        {
            writer.WriteStartElement(null, "TaxCdtRate", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(TaxCreditRateValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (WithholdingTaxAmount is IsoActiveCurrencyAndAmount WithholdingTaxAmountValue)
        {
            writer.WriteStartElement(null, "WhldgTaxAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(WithholdingTaxAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (WithholdingTaxRate is IsoPercentageRate WithholdingTaxRateValue)
        {
            writer.WriteStartElement(null, "WhldgTaxRate", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(WithholdingTaxRateValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (ScripDividendReinvestmentPricePerShare is PriceValue1 ScripDividendReinvestmentPricePerShareValue)
        {
            writer.WriteStartElement(null, "ScripDvddRinvstmtPricPerShr", xmlNamespace );
            ScripDividendReinvestmentPricePerShareValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashAmountBroughtForward is IsoActiveCurrencyAndAmount CashAmountBroughtForwardValue)
        {
            writer.WriteStartElement(null, "CshAmtBrghtFwd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(CashAmountBroughtForwardValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (AllotedSharesCost is PriceValue1 AllotedSharesCostValue)
        {
            writer.WriteStartElement(null, "AlltdShrsCost", xmlNamespace );
            AllotedSharesCostValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashAmountCarriedForward is IsoActiveCurrencyAndAmount CashAmountCarriedForwardValue)
        {
            writer.WriteStartElement(null, "CshAmtCrrdFwd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(CashAmountCarriedForwardValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (NotionalTax is IsoActiveCurrencyAndAmount NotionalTaxValue)
        {
            writer.WriteStartElement(null, "NtnlTax", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(NotionalTaxValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (NotionalDividendPayable is IsoActiveCurrencyAndAmount NotionalDividendPayableValue)
        {
            writer.WriteStartElement(null, "NtnlDvddPybl", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(NotionalDividendPayableValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (BargainDate is IsoISODate BargainDateValue)
        {
            writer.WriteStartElement(null, "BrgnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(BargainDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (BargainSettlementDate is IsoISODate BargainSettlementDateValue)
        {
            writer.WriteStartElement(null, "BrgnSttlmDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(BargainSettlementDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (StampDutyAmount is IsoActiveCurrencyAndAmount StampDutyAmountValue)
        {
            writer.WriteStartElement(null, "StmpDtyAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(StampDutyAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ChargeAmount is IsoActiveCurrencyAndAmount ChargeAmountValue)
        {
            writer.WriteStartElement(null, "ChrgAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(ChargeAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (CommissionAmount is IsoActiveCurrencyAndAmount CommissionAmountValue)
        {
            writer.WriteStartElement(null, "ComssnAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(CommissionAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ForeignExchangeDetails is ForeignExchangeTerms9 ForeignExchangeDetailsValue)
        {
            writer.WriteStartElement(null, "FXDtls", xmlNamespace );
            ForeignExchangeDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TaxVoucher1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
