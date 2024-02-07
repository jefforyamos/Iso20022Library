﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionRate116.  ISO2002 ID# _YXgYFV99Ee262vCSVgjImg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies security rate details.
/// </summary>
public partial record CorporateActionRate116
     : IIsoXmlSerilizable<CorporateActionRate116>
{
    #nullable enable
    
    /// <summary>
    /// Quantity of additional intermediate securities/new equities awarded for a given quantity of securities derived from subscription.
    /// </summary>
    public RatioFormat23Choice_? AdditionalQuantityForSubscribedResultantSecurities { get; init; } 
    /// <summary>
    /// Quantity of additional securities for a given quantity of underlying securities where underlying securities are not exchanged or debited, for example, 1 for 1: 1 new equity credited for every 1 underlying equity = 2 resulting equities.
    /// </summary>
    public RatioFormat23Choice_? AdditionalQuantityForExistingSecurities { get; init; } 
    /// <summary>
    /// Quantity of new securities for a given quantity of underlying securities, where the underlying securities will be exchanged or debited, for example, 2 for 1: 2 new equities credited for every 1 underlying equity debited = 2 resulting equities.
    /// </summary>
    public RatioFormat24Choice_? NewToOld { get; init; } 
    /// <summary>
    /// Rate used to determine the cash consideration split across outturn settlement transactions that are the result of a transformation of the parent transaction.
    /// </summary>
    public IsoPercentageRate? TransformationRate { get; init; } 
    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    public RateAndAmountFormat46Choice_? ChargesFees { get; init; } 
    /// <summary>
    /// Percentage of fiscal tax to apply.
    /// </summary>
    public RateFormat3Choice_? FiscalStamp { get; init; } 
    /// <summary>
    /// Rate applicable to the event announced, for example, redemption rate for a redemption event.
    /// </summary>
    public RateFormat3Choice_? ApplicableRate { get; init; } 
    /// <summary>
    /// Amount of money per equity allocated as the result of a tax credit.
    /// </summary>
    public RateFormat21Choice_? TaxCreditRate { get; init; } 
    /// <summary>
    /// Rate of financial transaction tax.
    /// </summary>
    public RateFormat3Choice_? FinancialTransactionTaxRate { get; init; } 
    /// <summary>
    /// Percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    public RateAndAmountFormat47Choice_? WithholdingTaxRate { get; init; } 
    /// <summary>
    /// Rate at which the income will be withheld by a jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate (TAXR) levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    public RateAndAmountFormat47Choice_? SecondLevelTax { get; init; } 
    
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
        if (AdditionalQuantityForSubscribedResultantSecurities is RatioFormat23Choice_ AdditionalQuantityForSubscribedResultantSecuritiesValue)
        {
            writer.WriteStartElement(null, "AddtlQtyForSbcbdRsltntScties", xmlNamespace );
            AdditionalQuantityForSubscribedResultantSecuritiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalQuantityForExistingSecurities is RatioFormat23Choice_ AdditionalQuantityForExistingSecuritiesValue)
        {
            writer.WriteStartElement(null, "AddtlQtyForExstgScties", xmlNamespace );
            AdditionalQuantityForExistingSecuritiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NewToOld is RatioFormat24Choice_ NewToOldValue)
        {
            writer.WriteStartElement(null, "NewToOd", xmlNamespace );
            NewToOldValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransformationRate is IsoPercentageRate TransformationRateValue)
        {
            writer.WriteStartElement(null, "TrfrmatnRate", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(TransformationRateValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (ChargesFees is RateAndAmountFormat46Choice_ ChargesFeesValue)
        {
            writer.WriteStartElement(null, "ChrgsFees", xmlNamespace );
            ChargesFeesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FiscalStamp is RateFormat3Choice_ FiscalStampValue)
        {
            writer.WriteStartElement(null, "FsclStmp", xmlNamespace );
            FiscalStampValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ApplicableRate is RateFormat3Choice_ ApplicableRateValue)
        {
            writer.WriteStartElement(null, "AplblRate", xmlNamespace );
            ApplicableRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TaxCreditRate is RateFormat21Choice_ TaxCreditRateValue)
        {
            writer.WriteStartElement(null, "TaxCdtRate", xmlNamespace );
            TaxCreditRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FinancialTransactionTaxRate is RateFormat3Choice_ FinancialTransactionTaxRateValue)
        {
            writer.WriteStartElement(null, "FinTxTaxRate", xmlNamespace );
            FinancialTransactionTaxRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (WithholdingTaxRate is RateAndAmountFormat47Choice_ WithholdingTaxRateValue)
        {
            writer.WriteStartElement(null, "WhldgTaxRate", xmlNamespace );
            WithholdingTaxRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecondLevelTax is RateAndAmountFormat47Choice_ SecondLevelTaxValue)
        {
            writer.WriteStartElement(null, "ScndLvlTax", xmlNamespace );
            SecondLevelTaxValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionRate116 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
