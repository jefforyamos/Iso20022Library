﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RateDetails27.  ISO2002 ID# _EKVJQYl3EeavwKddCbm3hg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the rates related to securities movement.
/// </summary>
public partial record RateDetails27
     : IIsoXmlSerilizable<RateDetails27>
{
    #nullable enable
    
    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    public RateAndAmountFormat39Choice_? AdditionalTax { get; init; } 
    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    public RateAndAmountFormat39Choice_? ChargesFees { get; init; } 
    /// <summary>
    /// Percentage of fiscal tax to apply.
    /// </summary>
    public IsoPercentageRate? FiscalStamp { get; init; } 
    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    public GrossDividendRateFormat22Choice_? GrossDividendRate { get; init; } 
    /// <summary>
    /// Cash rate made available, as an incentive, in addition to the solicitation fee, in order to encourage early participation in an offer.
    /// </summary>
    public SolicitationFeeRateFormat8Choice_? EarlySolicitationFeeRate { get; init; } 
    /// <summary>
    /// Cash rate made available in an event in order to encourage participation in the offer. As information, Payment is made to a third party who has solicited an entity to take part in the offer.
    /// </summary>
    public RateAndAmountFormat39Choice_? ThirdPartyIncentiveRate { get; init; } 
    /// <summary>
    /// Actual interest rate used for the payment of the interest for the specified interest period.
    /// </summary>
    public InterestRateUsedForPaymentFormat7Choice_? InterestRateUsedForPayment { get; init; } 
    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    public NetDividendRateFormat24Choice_? NetDividendRate { get; init; } 
    /// <summary>
    /// Rate per share to which a non-resident is entitled.
    /// </summary>
    public RateAndAmountFormat39Choice_? NonResidentRate { get; init; } 
    /// <summary>
    /// Rate applicable to the event announced, for example, redemption rate for a redemption event.
    /// </summary>
    public IsoPercentageRate? ApplicableRate { get; init; } 
    /// <summary>
    /// Rate of the cash premium made available if the securities holder consents or participates to an event, for example consent fees or solicitation fee.
    /// </summary>
    public SolicitationFeeRateFormat8Choice_? SolicitationFeeRate { get; init; } 
    /// <summary>
    /// Amount of money per equity allocated as the result of a tax credit.
    /// </summary>
    public TaxCreditRateFormat7Choice_? TaxCreditRate { get; init; } 
    /// <summary>
    /// Percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    public RateAndAmountFormat40Choice_? WithholdingTaxRate { get; init; } 
    /// <summary>
    /// Rate at which the income will be withheld by a jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate (TAXR) levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    public RateAndAmountFormat40Choice_? SecondLevelTax { get; init; } 
    /// <summary>
    /// Taxation applied on an amount clearly identified as an income.
    /// </summary>
    public RateAndAmountFormat39Choice_? TaxOnIncome { get; init; } 
    /// <summary>
    /// Taxation applied on an amount clearly identified as capital profits, capital gains.
    /// </summary>
    public IsoPercentageRate? TaxOnProfits { get; init; } 
    /// <summary>
    /// Percentage of cash that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    public IsoPercentageRate? TaxReclaimRate { get; init; } 
    /// <summary>
    /// Portion of the fund distribution which represents the average accrued income included in the purchase price for units bought during the account period.
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? EqualisationRate { get; init; } 
    
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
        if (AdditionalTax is RateAndAmountFormat39Choice_ AdditionalTaxValue)
        {
            writer.WriteStartElement(null, "AddtlTax", xmlNamespace );
            AdditionalTaxValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ChargesFees is RateAndAmountFormat39Choice_ ChargesFeesValue)
        {
            writer.WriteStartElement(null, "ChrgsFees", xmlNamespace );
            ChargesFeesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FiscalStamp is IsoPercentageRate FiscalStampValue)
        {
            writer.WriteStartElement(null, "FsclStmp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(FiscalStampValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (GrossDividendRate is GrossDividendRateFormat22Choice_ GrossDividendRateValue)
        {
            writer.WriteStartElement(null, "GrssDvddRate", xmlNamespace );
            GrossDividendRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EarlySolicitationFeeRate is SolicitationFeeRateFormat8Choice_ EarlySolicitationFeeRateValue)
        {
            writer.WriteStartElement(null, "EarlySlctnFeeRate", xmlNamespace );
            EarlySolicitationFeeRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ThirdPartyIncentiveRate is RateAndAmountFormat39Choice_ ThirdPartyIncentiveRateValue)
        {
            writer.WriteStartElement(null, "ThrdPtyIncntivRate", xmlNamespace );
            ThirdPartyIncentiveRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InterestRateUsedForPayment is InterestRateUsedForPaymentFormat7Choice_ InterestRateUsedForPaymentValue)
        {
            writer.WriteStartElement(null, "IntrstRateUsdForPmt", xmlNamespace );
            InterestRateUsedForPaymentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NetDividendRate is NetDividendRateFormat24Choice_ NetDividendRateValue)
        {
            writer.WriteStartElement(null, "NetDvddRate", xmlNamespace );
            NetDividendRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NonResidentRate is RateAndAmountFormat39Choice_ NonResidentRateValue)
        {
            writer.WriteStartElement(null, "NonResdtRate", xmlNamespace );
            NonResidentRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ApplicableRate is IsoPercentageRate ApplicableRateValue)
        {
            writer.WriteStartElement(null, "AplblRate", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(ApplicableRateValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (SolicitationFeeRate is SolicitationFeeRateFormat8Choice_ SolicitationFeeRateValue)
        {
            writer.WriteStartElement(null, "SlctnFeeRate", xmlNamespace );
            SolicitationFeeRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TaxCreditRate is TaxCreditRateFormat7Choice_ TaxCreditRateValue)
        {
            writer.WriteStartElement(null, "TaxCdtRate", xmlNamespace );
            TaxCreditRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (WithholdingTaxRate is RateAndAmountFormat40Choice_ WithholdingTaxRateValue)
        {
            writer.WriteStartElement(null, "WhldgTaxRate", xmlNamespace );
            WithholdingTaxRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecondLevelTax is RateAndAmountFormat40Choice_ SecondLevelTaxValue)
        {
            writer.WriteStartElement(null, "ScndLvlTax", xmlNamespace );
            SecondLevelTaxValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TaxOnIncome is RateAndAmountFormat39Choice_ TaxOnIncomeValue)
        {
            writer.WriteStartElement(null, "TaxOnIncm", xmlNamespace );
            TaxOnIncomeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TaxOnProfits is IsoPercentageRate TaxOnProfitsValue)
        {
            writer.WriteStartElement(null, "TaxOnPrfts", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(TaxOnProfitsValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (TaxReclaimRate is IsoPercentageRate TaxReclaimRateValue)
        {
            writer.WriteStartElement(null, "TaxRclmRate", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(TaxReclaimRateValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (EqualisationRate is IsoActiveCurrencyAnd13DecimalAmount EqualisationRateValue)
        {
            writer.WriteStartElement(null, "EqulstnRate", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAnd13DecimalAmount(EqualisationRateValue)); // data type ActiveCurrencyAnd13DecimalAmount System.Decimal
            writer.WriteEndElement();
        }
    }
    public static RateDetails27 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
