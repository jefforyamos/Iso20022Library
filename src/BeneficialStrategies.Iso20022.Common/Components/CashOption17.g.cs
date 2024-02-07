﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashOption17.  ISO2002 ID# _azKAMfo0EeCfbIXrKCjG0g.
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
public partial record CashOption17
     : IIsoXmlSerilizable<CashOption17>
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Specifies information regarding outturn resources that cannot be processed by the Central Securities Depository (CSD). Special delivery instruction is required from the account owner for the corporate action outcome to be credited.
    /// </summary>
    public NonEligibleProceedsIndicator1Choice_? NonEligibleProceedsIndicator { get; init; } 
    /// <summary>
    /// Proceeds are taxable according to the information provided by the issuer / offeror.
    /// </summary>
    public IssuerTaxability1Code? IssuerOfferorTaxabilityIndicator { get; init; } 
    /// <summary>
    /// Specifies the type of income.|The lists of income type codes to be used, are available on the SMPG website at www.smpg.info.
    /// </summary>
    public GenericIdentification20? IncomeType { get; init; } 
    /// <summary>
    /// Identification of the account in which cash is maintained.
    /// </summary>
    public CashAccountIdentification5Choice_? CashAccountIdentification { get; init; } 
    /// <summary>
    /// Provides information about the amounts related to a cash movement.
    /// </summary>
    public CorporateActionAmounts15? AmountDetails { get; init; } 
    /// <summary>
    /// Provides information about the dates related to a cash movement.
    /// </summary>
    public required CorporateActionDate23 DateDetails { get; init; } 
    /// <summary>
    /// Exchange rate between the amount and the resulting amount.
    /// </summary>
    public ForeignExchangeTerms13? ForeignExchangeDetails { get; init; } 
    /// <summary>
    /// Provides information about the corporate action option.
    /// </summary>
    public RateDetails3? RateAndAmountDetails { get; init; } 
    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    public PriceDetails6? PriceDetails { get; init; } 
    
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
        if (NonEligibleProceedsIndicator is NonEligibleProceedsIndicator1Choice_ NonEligibleProceedsIndicatorValue)
        {
            writer.WriteStartElement(null, "NonElgblPrcdsInd", xmlNamespace );
            NonEligibleProceedsIndicatorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IssuerOfferorTaxabilityIndicator is IssuerTaxability1Code IssuerOfferorTaxabilityIndicatorValue)
        {
            writer.WriteStartElement(null, "IssrOfferrTaxbltyInd", xmlNamespace );
            writer.WriteValue(IssuerOfferorTaxabilityIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (IncomeType is GenericIdentification20 IncomeTypeValue)
        {
            writer.WriteStartElement(null, "IncmTp", xmlNamespace );
            IncomeTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashAccountIdentification is CashAccountIdentification5Choice_ CashAccountIdentificationValue)
        {
            writer.WriteStartElement(null, "CshAcctId", xmlNamespace );
            CashAccountIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AmountDetails is CorporateActionAmounts15 AmountDetailsValue)
        {
            writer.WriteStartElement(null, "AmtDtls", xmlNamespace );
            AmountDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "DtDtls", xmlNamespace );
        DateDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ForeignExchangeDetails is ForeignExchangeTerms13 ForeignExchangeDetailsValue)
        {
            writer.WriteStartElement(null, "FXDtls", xmlNamespace );
            ForeignExchangeDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RateAndAmountDetails is RateDetails3 RateAndAmountDetailsValue)
        {
            writer.WriteStartElement(null, "RateAndAmtDtls", xmlNamespace );
            RateAndAmountDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PriceDetails is PriceDetails6 PriceDetailsValue)
        {
            writer.WriteStartElement(null, "PricDtls", xmlNamespace );
            PriceDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CashOption17 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
