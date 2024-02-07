﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesOption63.  ISO2002 ID# _9E4X0ZwsEeazcsnODTksnQ.
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
public partial record SecuritiesOption63
     : IIsoXmlSerilizable<SecuritiesOption63>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Specifies that the security identified is a temporary security identification used for processing reasons, for example, contra security used in the US.
    /// </summary>
    public TemporaryFinancialInstrumentIndicator4Choice_? TemporaryFinancialInstrumentIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the securities are newly issued or not.
    /// </summary>
    public NewSecuritiesIssuanceType6Code? NewSecuritiesIssuanceIndicator { get; init; } 
    /// <summary>
    /// Proceeds are taxable according to the information provided by the issuer / offeror.
    /// </summary>
    public IssuerOfferorTaxabilityIndicator1Choice_? IssuerOfferorTaxabilityIndicator { get; init; } 
    /// <summary>
    /// Specifies the type of income.|The lists of income type codes to be used, are available on the SMPG website at www.smpg.info.
    /// </summary>
    public GenericIdentification47? IncomeType { get; init; } 
    /// <summary>
    /// Specifies the basis for the reduced rate of withholding.
    /// </summary>
    public GenericIdentification47? ExemptionType { get; init; } 
    /// <summary>
    /// Indicates the country from which the income originates.
    /// </summary>
    public CountryCode? CountryOfIncomeSource { get; init; } 
    /// <summary>
    /// Quantity of securities that have been posted (credit or debit) to the safekeeping account.
    /// </summary>
    public required Quantity10Choice_ PostingQuantity { get; init; } 
    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    public SafekeepingPlaceFormat17Choice_? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    public FractionDispositionType30Choice_? FractionDisposition { get; init; } 
    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    public ActiveCurrencyCode? CurrencyOption { get; init; } 
    /// <summary>
    /// Provides information about the dates related to securities movement.
    /// </summary>
    public required SecurityDate13 DateDetails { get; init; } 
    /// <summary>
    /// Provides information about the rates related to securities movement.
    /// </summary>
    public CorporateActionRate75? RateDetails { get; init; } 
    /// <summary>
    /// Provides information about the prices related to securities movement.
    /// </summary>
    public CorporateActionPrice64? PriceDetails { get; init; } 
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    public SettlementParties61? ReceivingSettlementParties { get; init; } 
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    public SettlementParties61? DeliveringSettlementParties { get; init; } 
    
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
        writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
        FinancialInstrumentIdentification.Serialize(writer, xmlNamespace);
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
        if (NewSecuritiesIssuanceIndicator is NewSecuritiesIssuanceType6Code NewSecuritiesIssuanceIndicatorValue)
        {
            writer.WriteStartElement(null, "NewSctiesIssncInd", xmlNamespace );
            writer.WriteValue(NewSecuritiesIssuanceIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (IssuerOfferorTaxabilityIndicator is IssuerOfferorTaxabilityIndicator1Choice_ IssuerOfferorTaxabilityIndicatorValue)
        {
            writer.WriteStartElement(null, "IssrOfferrTaxbltyInd", xmlNamespace );
            IssuerOfferorTaxabilityIndicatorValue.Serialize(writer, xmlNamespace);
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
        if (CountryOfIncomeSource is CountryCode CountryOfIncomeSourceValue)
        {
            writer.WriteStartElement(null, "CtryOfIncmSrc", xmlNamespace );
            writer.WriteValue(CountryOfIncomeSourceValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PstngQty", xmlNamespace );
        PostingQuantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SafekeepingPlace is SafekeepingPlaceFormat17Choice_ SafekeepingPlaceValue)
        {
            writer.WriteStartElement(null, "SfkpgPlc", xmlNamespace );
            SafekeepingPlaceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FractionDisposition is FractionDispositionType30Choice_ FractionDispositionValue)
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
        writer.WriteStartElement(null, "DtDtls", xmlNamespace );
        DateDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (RateDetails is CorporateActionRate75 RateDetailsValue)
        {
            writer.WriteStartElement(null, "RateDtls", xmlNamespace );
            RateDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PriceDetails is CorporateActionPrice64 PriceDetailsValue)
        {
            writer.WriteStartElement(null, "PricDtls", xmlNamespace );
            PriceDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReceivingSettlementParties is SettlementParties61 ReceivingSettlementPartiesValue)
        {
            writer.WriteStartElement(null, "RcvgSttlmPties", xmlNamespace );
            ReceivingSettlementPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeliveringSettlementParties is SettlementParties61 DeliveringSettlementPartiesValue)
        {
            writer.WriteStartElement(null, "DlvrgSttlmPties", xmlNamespace );
            DeliveringSettlementPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecuritiesOption63 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
