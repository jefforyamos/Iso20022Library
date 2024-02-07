﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionRate98.  ISO2002 ID# _BgTvg-XsEemEj48jhmlA0Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies rates.
/// </summary>
public partial record CorporateActionRate98
     : IIsoXmlSerilizable<CorporateActionRate98>
{
    #nullable enable
    
    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    public GrossDividendRateFormat35Choice_? GrossDividendRate { get; init; } 
    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    public NetDividendRateFormat37Choice_? NetDividendRate { get; init; } 
    /// <summary>
    /// Public index rate applied to the amount paid to adjust it to inflation.
    /// </summary>
    public RateAndAmountFormat39Choice_? IndexFactor { get; init; } 
    /// <summary>
    /// Actual interest rate used for the payment of the interest for the specified interest period.
    /// </summary>
    public InterestRateUsedForPaymentFormat7Choice_? InterestRateUsedForPayment { get; init; } 
    /// <summary>
    /// A maximum percentage of shares available through the over subscription privilege, usually a percentage of the basic subscription shares, for example, an account owner subscribing to 100 shares may over subscribe to a maximum of 50 additional shares when the over subscription maximum is 50 percent.
    /// </summary>
    public IsoPercentageRate? MaximumAllowedOversubscriptionRate { get; init; } 
    /// <summary>
    /// Percentage of securities accepted by the offeror/issuer.
    /// </summary>
    public IsoPercentageRate? ProrationRate { get; init; } 
    /// <summary>
    /// Percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    public RateAndAmountFormat40Choice_? WithholdingTaxRate { get; init; } 
    /// <summary>
    /// Rate at which the income will be withheld by a jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate (TAXR) levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    public RateAndAmountFormat40Choice_? SecondLevelTax { get; init; } 
    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    public RateAndAmountFormat39Choice_? AdditionalTax { get; init; } 
    /// <summary>
    /// Amount included in the dividend/NAV that is identified as gains directly or indirectly derived from interest payments, for example, in the context of the EU Savings directive.
    /// </summary>
    public RateTypeAndAmountAndStatus26? TaxableIncomePerDividendShare { get; init; } 
    
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
        if (GrossDividendRate is GrossDividendRateFormat35Choice_ GrossDividendRateValue)
        {
            writer.WriteStartElement(null, "GrssDvddRate", xmlNamespace );
            GrossDividendRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NetDividendRate is NetDividendRateFormat37Choice_ NetDividendRateValue)
        {
            writer.WriteStartElement(null, "NetDvddRate", xmlNamespace );
            NetDividendRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IndexFactor is RateAndAmountFormat39Choice_ IndexFactorValue)
        {
            writer.WriteStartElement(null, "IndxFctr", xmlNamespace );
            IndexFactorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InterestRateUsedForPayment is InterestRateUsedForPaymentFormat7Choice_ InterestRateUsedForPaymentValue)
        {
            writer.WriteStartElement(null, "IntrstRateUsdForPmt", xmlNamespace );
            InterestRateUsedForPaymentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MaximumAllowedOversubscriptionRate is IsoPercentageRate MaximumAllowedOversubscriptionRateValue)
        {
            writer.WriteStartElement(null, "MaxAllwdOvrsbcptRate", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(MaximumAllowedOversubscriptionRateValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (ProrationRate is IsoPercentageRate ProrationRateValue)
        {
            writer.WriteStartElement(null, "PrratnRate", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(ProrationRateValue)); // data type PercentageRate System.Decimal
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
        if (AdditionalTax is RateAndAmountFormat39Choice_ AdditionalTaxValue)
        {
            writer.WriteStartElement(null, "AddtlTax", xmlNamespace );
            AdditionalTaxValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TaxableIncomePerDividendShare is RateTypeAndAmountAndStatus26 TaxableIncomePerDividendShareValue)
        {
            writer.WriteStartElement(null, "TaxblIncmPerDvddShr", xmlNamespace );
            TaxableIncomePerDividendShareValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionRate98 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
