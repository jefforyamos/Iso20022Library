﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesOption57.  ISO2002 ID# _ctf2zZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action security option.
/// </summary>
public partial record SecuritiesOption57
     : IIsoXmlSerilizable<SecuritiesOption57>
{
    #nullable enable
    
    /// <summary>
    /// Provides description of the financial instrument related to securities movement.
    /// </summary>
    public required FinancialInstrumentAttributes71 SecurityDetails { get; init; } 
    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Specifies that the security identified is a temporary security identification used for processing reasons, for example, contra security used in the US.
    /// </summary>
    public TemporaryFinancialInstrumentIndicator4Choice_? TemporaryFinancialInstrumentIndicator { get; init; } 
    /// <summary>
    /// Specifies information regarding outturn resources that cannot be processed by the Central Securities Depository (CSD). Special delivery instruction is required from the account owner for the corporate action outcome to be credited.
    /// </summary>
    public NonEligibleProceedsIndicator4Choice_? NonEligibleProceedsIndicator { get; init; } 
    /// <summary>
    /// Proceeds are taxable according to the information provided by the issuer / offeror.
    /// </summary>
    public GenericIdentification47? IssuerOfferorTaxabilityIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the securities are newly issued or not.
    /// </summary>
    public NewSecuritiesIssuanceType5Code? NewSecuritiesIssuanceIndicator { get; init; } 
    /// <summary>
    /// Specifies the type of income.|The lists of income type codes to be used, are available on the SMPG website at www.smpg.info.
    /// </summary>
    public GenericIdentification47? IncomeType { get; init; } 
    /// <summary>
    /// Specifies the basis for the reduced rate of withholding.
    /// </summary>
    public GenericIdentification47? ExemptionType { get; init; } 
    /// <summary>
    /// Quantity of securities based on the terms of the corporate action event and balance of underlying securities entitled to the account owner. (This quantity can be positive or negative).
    /// </summary>
    public Quantity10Choice_? EntitledQuantity { get; init; } 
    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    public SafekeepingPlaceFormat17Choice_? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Indicates the country from which the income originates.
    /// </summary>
    public CountryCode? CountryOfIncomeSource { get; init; } 
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    public FractionDispositionType31Choice_? FractionDisposition { get; init; } 
    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    public ActiveCurrencyCode? CurrencyOption { get; init; } 
    /// <summary>
    /// Period during which intermediate or outturn securities are tradable in a secondary market.
    /// </summary>
    public Period3Choice_? TradingPeriod { get; init; } 
    /// <summary>
    /// Provides information about the dates related to securities movement.
    /// </summary>
    public required SecurityDate14 DateDetails { get; init; } 
    /// <summary>
    /// Provides information about the rates related to securities movement.
    /// </summary>
    public CorporateActionRate77? RateDetails { get; init; } 
    /// <summary>
    /// Provides information about the prices related to securities movement.
    /// </summary>
    public CorporateActionPrice66? PriceDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "SctyDtls", xmlNamespace );
        SecurityDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CdtDbtInd", xmlNamespace );
        writer.WriteValue(CreditDebitIndicator.ToString()); // Enum value
        writer.WriteEndElement();
        if (TemporaryFinancialInstrumentIndicator is TemporaryFinancialInstrumentIndicator4Choice_ TemporaryFinancialInstrumentIndicatorValue)
        {
            writer.WriteStartElement(null, "TempFinInstrmInd", xmlNamespace );
            TemporaryFinancialInstrumentIndicatorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NonEligibleProceedsIndicator is NonEligibleProceedsIndicator4Choice_ NonEligibleProceedsIndicatorValue)
        {
            writer.WriteStartElement(null, "NonElgblPrcdsInd", xmlNamespace );
            NonEligibleProceedsIndicatorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IssuerOfferorTaxabilityIndicator is GenericIdentification47 IssuerOfferorTaxabilityIndicatorValue)
        {
            writer.WriteStartElement(null, "IssrOfferrTaxbltyInd", xmlNamespace );
            IssuerOfferorTaxabilityIndicatorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NewSecuritiesIssuanceIndicator is NewSecuritiesIssuanceType5Code NewSecuritiesIssuanceIndicatorValue)
        {
            writer.WriteStartElement(null, "NewSctiesIssncInd", xmlNamespace );
            writer.WriteValue(NewSecuritiesIssuanceIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (IncomeType is GenericIdentification47 IncomeTypeValue)
        {
            writer.WriteStartElement(null, "IncmTp", xmlNamespace );
            IncomeTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ExemptionType is GenericIdentification47 ExemptionTypeValue)
        {
            writer.WriteStartElement(null, "XmptnTp", xmlNamespace );
            ExemptionTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EntitledQuantity is Quantity10Choice_ EntitledQuantityValue)
        {
            writer.WriteStartElement(null, "EntitldQty", xmlNamespace );
            EntitledQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SafekeepingPlace is SafekeepingPlaceFormat17Choice_ SafekeepingPlaceValue)
        {
            writer.WriteStartElement(null, "SfkpgPlc", xmlNamespace );
            SafekeepingPlaceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CountryOfIncomeSource is CountryCode CountryOfIncomeSourceValue)
        {
            writer.WriteStartElement(null, "CtryOfIncmSrc", xmlNamespace );
            writer.WriteValue(CountryOfIncomeSourceValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (FractionDisposition is FractionDispositionType31Choice_ FractionDispositionValue)
        {
            writer.WriteStartElement(null, "FrctnDspstn", xmlNamespace );
            FractionDispositionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CurrencyOption is ActiveCurrencyCode CurrencyOptionValue)
        {
            writer.WriteStartElement(null, "CcyOptn", xmlNamespace );
            writer.WriteValue(CurrencyOptionValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (TradingPeriod is Period3Choice_ TradingPeriodValue)
        {
            writer.WriteStartElement(null, "TradgPrd", xmlNamespace );
            TradingPeriodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "DtDtls", xmlNamespace );
        DateDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (RateDetails is CorporateActionRate77 RateDetailsValue)
        {
            writer.WriteStartElement(null, "RateDtls", xmlNamespace );
            RateDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PriceDetails is CorporateActionPrice66 PriceDetailsValue)
        {
            writer.WriteStartElement(null, "PricDtls", xmlNamespace );
            PriceDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecuritiesOption57 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
