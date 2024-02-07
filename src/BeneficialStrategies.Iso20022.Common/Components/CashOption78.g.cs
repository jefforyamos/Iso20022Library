﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashOption78.  ISO2002 ID# _CFYgkRe-EeyroI8qKgB7Mg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the cash option.
/// </summary>
public partial record CashOption78
     : IIsoXmlSerilizable<CashOption78>
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the cash payment occurs or will occur in advance of receipt of proceeds from the issuer and based on a contractual agreement established with the account servicer or upon receipt of proceeds from the issuer.
    /// </summary>
    public Payment1Code? ContractualPaymentIndicator { get; init; } 
    /// <summary>
    /// Specifies information regarding outturn resources that cannot be processed by the Central Securities Depository (CSD). Special delivery instruction is required from the account owner for the corporate action outcome to be credited.
    /// </summary>
    public NonEligibleProceedsIndicator3Choice_? NonEligibleProceedsIndicator { get; init; } 
    /// <summary>
    /// Proceeds are taxable according to the information provided by the issuer / offeror.
    /// </summary>
    public IssuerOfferorTaxabilityIndicator1Choice_? IssuerOfferorTaxabilityIndicator { get; init; } 
    /// <summary>
    /// Specifies the type of income.|The lists of income type codes to be used, are available on the SMPG website at www.smpg.info.
    /// </summary>
    public GenericIdentification30? IncomeType { get; init; } 
    /// <summary>
    /// Type of income to be used under another tax regime.
    /// </summary>
    public GenericIdentification30? OtherIncomeType { get; init; } 
    /// <summary>
    /// Specifies the basis for the reduced rate of withholding.
    /// </summary>
    public GenericIdentification30? ExemptionType { get; init; } 
    /// <summary>
    /// Indicates the country from which the income originates.
    /// </summary>
    public CountryCode? CountryOfIncomeSource { get; init; } 
    /// <summary>
    /// Identification of the account in which cash is maintained.
    /// </summary>
    public CashAccountIdentification5Choice_? CashAccountIdentification { get; init; } 
    /// <summary>
    /// Provides information about the amounts related to a cash movement.
    /// </summary>
    public CorporateActionAmounts55? AmountDetails { get; init; } 
    /// <summary>
    /// Provides information about the dates related to a cash movement.
    /// </summary>
    public required CorporateActionDate62 DateDetails { get; init; } 
    /// <summary>
    /// Exchange rate between the amount and the resulting amount.
    /// </summary>
    public ForeignExchangeTerms24? ForeignExchangeDetails { get; init; } 
    /// <summary>
    /// Provides information about the corporate action option.
    /// </summary>
    public Rate36? RateAndAmountDetails { get; init; } 
    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    public PriceDetails27? PriceDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "CdtDbtInd", xmlNamespace );
        writer.WriteValue(CreditDebitIndicator.ToString()); // Enum value
        writer.WriteEndElement();
        if (ContractualPaymentIndicator is Payment1Code ContractualPaymentIndicatorValue)
        {
            writer.WriteStartElement(null, "CtrctlPmtInd", xmlNamespace );
            writer.WriteValue(ContractualPaymentIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (NonEligibleProceedsIndicator is NonEligibleProceedsIndicator3Choice_ NonEligibleProceedsIndicatorValue)
        {
            writer.WriteStartElement(null, "NonElgblPrcdsInd", xmlNamespace );
            NonEligibleProceedsIndicatorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IssuerOfferorTaxabilityIndicator is IssuerOfferorTaxabilityIndicator1Choice_ IssuerOfferorTaxabilityIndicatorValue)
        {
            writer.WriteStartElement(null, "IssrOfferrTaxbltyInd", xmlNamespace );
            IssuerOfferorTaxabilityIndicatorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IncomeType is GenericIdentification30 IncomeTypeValue)
        {
            writer.WriteStartElement(null, "IncmTp", xmlNamespace );
            IncomeTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherIncomeType is GenericIdentification30 OtherIncomeTypeValue)
        {
            writer.WriteStartElement(null, "OthrIncmTp", xmlNamespace );
            OtherIncomeTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ExemptionType is GenericIdentification30 ExemptionTypeValue)
        {
            writer.WriteStartElement(null, "XmptnTp", xmlNamespace );
            ExemptionTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CountryOfIncomeSource is CountryCode CountryOfIncomeSourceValue)
        {
            writer.WriteStartElement(null, "CtryOfIncmSrc", xmlNamespace );
            writer.WriteValue(CountryOfIncomeSourceValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CashAccountIdentification is CashAccountIdentification5Choice_ CashAccountIdentificationValue)
        {
            writer.WriteStartElement(null, "CshAcctId", xmlNamespace );
            CashAccountIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AmountDetails is CorporateActionAmounts55 AmountDetailsValue)
        {
            writer.WriteStartElement(null, "AmtDtls", xmlNamespace );
            AmountDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "DtDtls", xmlNamespace );
        DateDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ForeignExchangeDetails is ForeignExchangeTerms24 ForeignExchangeDetailsValue)
        {
            writer.WriteStartElement(null, "FXDtls", xmlNamespace );
            ForeignExchangeDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RateAndAmountDetails is Rate36 RateAndAmountDetailsValue)
        {
            writer.WriteStartElement(null, "RateAndAmtDtls", xmlNamespace );
            RateAndAmountDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PriceDetails is PriceDetails27 PriceDetailsValue)
        {
            writer.WriteStartElement(null, "PricDtls", xmlNamespace );
            PriceDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CashOption78 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
