﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CommonFinancialInstrumentAttributes11.  ISO2002 ID# _QAKbh5JKEeuAlLVx8pyt3w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tangible items of value to a business.
/// </summary>
public partial record CommonFinancialInstrumentAttributes11
     : IIsoXmlSerilizable<CommonFinancialInstrumentAttributes11>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the status of the security within its lifecycle.
    /// </summary>
    public SecurityStatus3Choice_? SecurityStatus { get; init; } 
    /// <summary>
    /// Name of the security.
    /// </summary>
    public FinancialInstrumentName2? FinancialInstrumentName { get; init; } 
    /// <summary>
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? DenominationCurrency { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier of a certificate assigned by the issuer.
    /// </summary>
    public IsoMax35Text? CertificateNumber { get; init; } 
    /// <summary>
    /// Version number assigned to the contract associated with the security.
    /// </summary>
    public IsoNumber? ContractVersionNumber { get; init; } 
    /// <summary>
    /// Number of the coupon attached to the physical security.
    /// </summary>
    public IsoMax3NumericText? CouponAttachedNumber { get; init; } 
    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    public IsoMax15NumericText? TaxLotNumber { get; init; } 
    /// <summary>
    /// Number identifying a group of underlying assets assigned by the issuer of a factored security.
    /// </summary>
    public IsoMax15NumericText? PoolNumber { get; init; } 
    /// <summary>
    /// Indicates whether the derivative product is covered or not by an underlying financial instrument position.
    /// </summary>
    public IsoYesNoIndicator? CoveredIndicator { get; init; } 
    /// <summary>
    /// Specifies the regulatory restrictions applicable to a security.
    /// </summary>
    public LegalRestrictions4Choice_? LegalRestrictions { get; init; } 
    /// <summary>
    /// Position limits are created for the purpose of maintaining stable and fair markets. Contracts held by one individual investor with different brokers may be combined in order to gauge accurately the level of control held by one party. ||Each option and futures contract will have varying position limits.
    /// </summary>
    public FinancialInstrumentQuantity1Choice_? PositionLimit { get; init; } 
    /// <summary>
    /// Near-term position limit for the instrument.
    /// </summary>
    public FinancialInstrumentQuantity1Choice_? NearTermPositionLimit { get; init; } 
    /// <summary>
    /// Original Date/time at which the security is listed at the specific exchange or trading venue.
    /// </summary>
    public IsoISODate? ListingDate { get; init; } 
    /// <summary>
    /// Date/time at which positions are struck to note which parties are entitled to receive the entitlement to a corporate event or vote at a meeting.
    /// </summary>
    public IsoISODateTime? RecordDate { get; init; } 
    /// <summary>
    /// Date on which a privilege expires.
    /// </summary>
    public IsoISODate? ExpiryDate { get; init; } 
    /// <summary>
    /// Reason for which money is raised through the issuance of a security.
    /// </summary>
    public IsoMax256Text? Purpose { get; init; } 
    /// <summary>
    /// Information allowing the classification of a financial instrument, for example, with its ISO CFI (Classification of Financial Instrument) or product type.
    /// </summary>
    public ClassificationType2? ClassificationType { get; init; } 
    /// <summary>
    /// Details regarding the issuance of an asset.
    /// </summary>
    public Issuance6? Issuance { get; init; } 
    /// <summary>
    /// Market(s) on which the security is traded.
    /// </summary>
    public TradingParameters2? TradingMarket { get; init; } 
    /// <summary>
    /// Indicates the spread to benchmark details of an indication of interest.
    /// </summary>
    public BenchmarkCurve6? SpreadAndBenchmarkCurve { get; init; } 
    /// <summary>
    /// Represents the type of put.
    /// </summary>
    public PutType3Choice_? PutType { get; init; } 
    /// <summary>
    /// Represents the type of call.
    /// </summary>
    public CallType3Choice_? CallType { get; init; } 
    /// <summary>
    /// Indicates whether a security is interchangeable, ie, the security is allowed to be replaced by another security, without loss of value.
    /// </summary>
    public IsoYesNoIndicator? FungibleIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the details of the security are to be made available to the market, or kept private between ICSDs and agency network.
    /// </summary>
    public IsoYesNoIndicator? Confidential { get; init; } 
    /// <summary>
    /// The sale of securities directly to private persons, institutional investors, or both outside a public offering. Such non-public deals (often without a publicly available prospectus) closing through the ICSDs are placed directly with investors.
    /// </summary>
    public IsoYesNoIndicator? PrivatePlacement { get; init; } 
    /// <summary>
    /// Indicates whether the investor or the issuer has a conversion option.
    /// </summary>
    public IsoYesNoIndicator? ConvertibleIndicator { get; init; } 
    /// <summary>
    /// Period during which a convertible security may be converted according to the terms of the issue.
    /// </summary>
    public DateTimePeriod1? ConversionPeriod { get; init; } 
    /// <summary>
    /// Number of target securities for the conversion.
    /// </summary>
    public FinancialInstrumentQuantity1Choice_? ConversionRatioNumerator { get; init; } 
    /// <summary>
    /// Number of held securities for the conversion.
    /// </summary>
    public FinancialInstrumentQuantity1Choice_? ConversionRatioDenominator { get; init; } 
    /// <summary>
    /// Primary place of deposit.
    /// </summary>
    public PartyIdentification136? PrimaryPlaceOfDeposit { get; init; } 
    /// <summary>
    /// Indicates whether the notional amount value is to be traded in either an amount or in units.
    /// </summary>
    public UnitOrFaceAmount1Choice_? TradingMethod { get; init; } 
    /// <summary>
    /// Indicates the TEFRA rule under which the security is issued.
    /// </summary>
    public TEFRARules3Choice_? TEFRARule { get; init; } 
    /// <summary>
    /// Identifies the series number.
    /// </summary>
    public IsoMax16Text? SerieNumber { get; init; } 
    /// <summary>
    /// Identifier that links multiple security classes.
    /// </summary>
    public IsoMax16Text? Class { get; init; } 
    /// <summary>
    /// Amount or percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    public SecurityWithHoldingTax1? WithholdingTaxRegime { get; init; } 
    /// <summary>
    /// Status of payment of a security at a particular time.
    /// </summary>
    public SecuritiesPaymentStatus5Choice_? PaymentStatus { get; init; } 
    /// <summary>
    /// Indicates the physical form of the securities on the closing date.
    /// </summary>
    public InitialPhysicalForm4Choice_? InitialPhysicalForm { get; init; } 
    /// <summary>
    /// Indicates the physical form of the securities after the exchange of the initial certificate issued on the closing date.
    /// </summary>
    public InitialPhysicalForm3Choice_? AfterExchangePhysicalForm { get; init; } 
    /// <summary>
    /// Entity appointed by the ICSDs to provide safekeeping for securities in new global note (NGN) form.
    /// </summary>
    public PartyIdentification177Choice_? CommonSafekeeper { get; init; } 
    /// <summary>
    /// Indicates the type of redemption at maturity.
    /// </summary>
    public MaturityRedemptionType3Choice_? RedemptionType { get; init; } 
    /// <summary>
    /// ISO currency for the payment of the cash proceeds.
    /// </summary>
    public ActiveCurrencyCode? RedemptionPaymentCurrency { get; init; } 
    /// <summary>
    /// Regulatory restriction(s) linked to the security.
    /// </summary>
    public SecurityRestriction3? Restriction { get; init; } 
    /// <summary>
    /// Specifies the date from which the financial instrument identification is valid.
    /// </summary>
    public FinancialInstrumentIdentificationValidity3? FinancialInstrumentIdentificationValidity { get; init; } 
    /// <summary>
    /// Settlement of the securities in a securities transaction, that is, the instruction to deliver or receive securities, involving the payment of an amount of money or not.
    /// </summary>
    public SettlementInformation17? SettlementInformation { get; init; } 
    /// <summary>
    /// Indicates the form of the financial Instrument.
    /// </summary>
    public FinancialInstrumentForm2? FinancialInstrumentForm { get; init; } 
    /// <summary>
    /// Details (name, e-mail address and/or telephone number) of the person requesting the allocation of the ISIN used as a point of reference in case further clarifications are required.
    /// </summary>
    public Organisation38? ContactName { get; init; } 
    /// <summary>
    /// Entity appointed by the issuer to structure and lead the placement of a syndicated issue.
    /// </summary>
    public Organisation38? LeadManager { get; init; } 
    /// <summary>
    /// Main party appointed to distribute payment or securities on behalf of the issuer.
    /// </summary>
    public Organisation38? PrincipalPayingAgent { get; init; } 
    /// <summary>
    /// Additional party appointed to distribute payment or securities on behalf of the issuer.
    /// </summary>
    public Organisation38? PayingAgent { get; init; } 
    /// <summary>
    /// Entity appointed by the relevant clearing system as a depository for instruments issued in global or definitive form. The depository keeps the securities for safekeeping purposes on behalf of the clearing system(s).
    /// </summary>
    public Organisation38? Depository { get; init; } 
    /// <summary>
    /// Entity(ies), asset(s) or security(ies) on which the credit responsibility lies as identified in the documentation.
    /// </summary>
    public Organisation38? UnderlyingRisk { get; init; } 
    /// <summary>
    /// Defines how the CSD is linked to the security.
    /// </summary>
    public SecurityCSDLink7? SecurityCSDLink { get; init; } 
    
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
        if (SecurityStatus is SecurityStatus3Choice_ SecurityStatusValue)
        {
            writer.WriteStartElement(null, "SctySts", xmlNamespace );
            SecurityStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FinancialInstrumentName is FinancialInstrumentName2 FinancialInstrumentNameValue)
        {
            writer.WriteStartElement(null, "FinInstrmNm", xmlNamespace );
            FinancialInstrumentNameValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DenominationCurrency is ActiveOrHistoricCurrencyCode DenominationCurrencyValue)
        {
            writer.WriteStartElement(null, "DnmtnCcy", xmlNamespace );
            writer.WriteValue(DenominationCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CertificateNumber is IsoMax35Text CertificateNumberValue)
        {
            writer.WriteStartElement(null, "CertNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CertificateNumberValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ContractVersionNumber is IsoNumber ContractVersionNumberValue)
        {
            writer.WriteStartElement(null, "CtrctVrsnNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(ContractVersionNumberValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (CouponAttachedNumber is IsoMax3NumericText CouponAttachedNumberValue)
        {
            writer.WriteStartElement(null, "CpnAttchdNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax3NumericText(CouponAttachedNumberValue)); // data type Max3NumericText System.String
            writer.WriteEndElement();
        }
        if (TaxLotNumber is IsoMax15NumericText TaxLotNumberValue)
        {
            writer.WriteStartElement(null, "TaxLotNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax15NumericText(TaxLotNumberValue)); // data type Max15NumericText System.String
            writer.WriteEndElement();
        }
        if (PoolNumber is IsoMax15NumericText PoolNumberValue)
        {
            writer.WriteStartElement(null, "PoolNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax15NumericText(PoolNumberValue)); // data type Max15NumericText System.String
            writer.WriteEndElement();
        }
        if (CoveredIndicator is IsoYesNoIndicator CoveredIndicatorValue)
        {
            writer.WriteStartElement(null, "CvrdInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(CoveredIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (LegalRestrictions is LegalRestrictions4Choice_ LegalRestrictionsValue)
        {
            writer.WriteStartElement(null, "LglRstrctns", xmlNamespace );
            LegalRestrictionsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PositionLimit is FinancialInstrumentQuantity1Choice_ PositionLimitValue)
        {
            writer.WriteStartElement(null, "PosLmt", xmlNamespace );
            PositionLimitValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NearTermPositionLimit is FinancialInstrumentQuantity1Choice_ NearTermPositionLimitValue)
        {
            writer.WriteStartElement(null, "NearTermPosLmt", xmlNamespace );
            NearTermPositionLimitValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ListingDate is IsoISODate ListingDateValue)
        {
            writer.WriteStartElement(null, "ListgDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(ListingDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (RecordDate is IsoISODateTime RecordDateValue)
        {
            writer.WriteStartElement(null, "RcrdDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(RecordDateValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (ExpiryDate is IsoISODate ExpiryDateValue)
        {
            writer.WriteStartElement(null, "XpryDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(ExpiryDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (Purpose is IsoMax256Text PurposeValue)
        {
            writer.WriteStartElement(null, "Purp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax256Text(PurposeValue)); // data type Max256Text System.String
            writer.WriteEndElement();
        }
        if (ClassificationType is ClassificationType2 ClassificationTypeValue)
        {
            writer.WriteStartElement(null, "ClssfctnTp", xmlNamespace );
            ClassificationTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Issuance is Issuance6 IssuanceValue)
        {
            writer.WriteStartElement(null, "Issnc", xmlNamespace );
            IssuanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TradingMarket is TradingParameters2 TradingMarketValue)
        {
            writer.WriteStartElement(null, "TradgMkt", xmlNamespace );
            TradingMarketValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SpreadAndBenchmarkCurve is BenchmarkCurve6 SpreadAndBenchmarkCurveValue)
        {
            writer.WriteStartElement(null, "SprdAndBchmkCrv", xmlNamespace );
            SpreadAndBenchmarkCurveValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PutType is PutType3Choice_ PutTypeValue)
        {
            writer.WriteStartElement(null, "PutTp", xmlNamespace );
            PutTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CallType is CallType3Choice_ CallTypeValue)
        {
            writer.WriteStartElement(null, "CallTp", xmlNamespace );
            CallTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FungibleIndicator is IsoYesNoIndicator FungibleIndicatorValue)
        {
            writer.WriteStartElement(null, "FngbInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(FungibleIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (Confidential is IsoYesNoIndicator ConfidentialValue)
        {
            writer.WriteStartElement(null, "Cnfdtl", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(ConfidentialValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (PrivatePlacement is IsoYesNoIndicator PrivatePlacementValue)
        {
            writer.WriteStartElement(null, "PrvtPlcmnt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(PrivatePlacementValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (ConvertibleIndicator is IsoYesNoIndicator ConvertibleIndicatorValue)
        {
            writer.WriteStartElement(null, "ConvtblInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(ConvertibleIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (ConversionPeriod is DateTimePeriod1 ConversionPeriodValue)
        {
            writer.WriteStartElement(null, "ConvsPrd", xmlNamespace );
            ConversionPeriodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ConversionRatioNumerator is FinancialInstrumentQuantity1Choice_ ConversionRatioNumeratorValue)
        {
            writer.WriteStartElement(null, "ConvsRatioNmrtr", xmlNamespace );
            ConversionRatioNumeratorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ConversionRatioDenominator is FinancialInstrumentQuantity1Choice_ ConversionRatioDenominatorValue)
        {
            writer.WriteStartElement(null, "ConvsRatioDnmtr", xmlNamespace );
            ConversionRatioDenominatorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PrimaryPlaceOfDeposit is PartyIdentification136 PrimaryPlaceOfDepositValue)
        {
            writer.WriteStartElement(null, "PmryPlcOfDpst", xmlNamespace );
            PrimaryPlaceOfDepositValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TradingMethod is UnitOrFaceAmount1Choice_ TradingMethodValue)
        {
            writer.WriteStartElement(null, "TradgMtd", xmlNamespace );
            TradingMethodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TEFRARule is TEFRARules3Choice_ TEFRARuleValue)
        {
            writer.WriteStartElement(null, "TEFRARule", xmlNamespace );
            TEFRARuleValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SerieNumber is IsoMax16Text SerieNumberValue)
        {
            writer.WriteStartElement(null, "SrNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax16Text(SerieNumberValue)); // data type Max16Text System.String
            writer.WriteEndElement();
        }
        if (Class is IsoMax16Text ClassValue)
        {
            writer.WriteStartElement(null, "Clss", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax16Text(ClassValue)); // data type Max16Text System.String
            writer.WriteEndElement();
        }
        if (WithholdingTaxRegime is SecurityWithHoldingTax1 WithholdingTaxRegimeValue)
        {
            writer.WriteStartElement(null, "WhldgTaxRgm", xmlNamespace );
            WithholdingTaxRegimeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PaymentStatus is SecuritiesPaymentStatus5Choice_ PaymentStatusValue)
        {
            writer.WriteStartElement(null, "PmtSts", xmlNamespace );
            PaymentStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InitialPhysicalForm is InitialPhysicalForm4Choice_ InitialPhysicalFormValue)
        {
            writer.WriteStartElement(null, "InitlPhysForm", xmlNamespace );
            InitialPhysicalFormValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AfterExchangePhysicalForm is InitialPhysicalForm3Choice_ AfterExchangePhysicalFormValue)
        {
            writer.WriteStartElement(null, "AftrXchgPhysForm", xmlNamespace );
            AfterExchangePhysicalFormValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CommonSafekeeper is PartyIdentification177Choice_ CommonSafekeeperValue)
        {
            writer.WriteStartElement(null, "CmonSfkpr", xmlNamespace );
            CommonSafekeeperValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RedemptionType is MaturityRedemptionType3Choice_ RedemptionTypeValue)
        {
            writer.WriteStartElement(null, "RedTp", xmlNamespace );
            RedemptionTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RedemptionPaymentCurrency is ActiveCurrencyCode RedemptionPaymentCurrencyValue)
        {
            writer.WriteStartElement(null, "RedPmtCcy", xmlNamespace );
            writer.WriteValue(RedemptionPaymentCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Restriction is SecurityRestriction3 RestrictionValue)
        {
            writer.WriteStartElement(null, "Rstrctn", xmlNamespace );
            RestrictionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FinancialInstrumentIdentificationValidity is FinancialInstrumentIdentificationValidity3 FinancialInstrumentIdentificationValidityValue)
        {
            writer.WriteStartElement(null, "FinInstrmIdVldty", xmlNamespace );
            FinancialInstrumentIdentificationValidityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementInformation is SettlementInformation17 SettlementInformationValue)
        {
            writer.WriteStartElement(null, "SttlmInf", xmlNamespace );
            SettlementInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FinancialInstrumentForm is FinancialInstrumentForm2 FinancialInstrumentFormValue)
        {
            writer.WriteStartElement(null, "FinInstrmForm", xmlNamespace );
            FinancialInstrumentFormValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ContactName is Organisation38 ContactNameValue)
        {
            writer.WriteStartElement(null, "CtctNm", xmlNamespace );
            ContactNameValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LeadManager is Organisation38 LeadManagerValue)
        {
            writer.WriteStartElement(null, "LeadMgr", xmlNamespace );
            LeadManagerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PrincipalPayingAgent is Organisation38 PrincipalPayingAgentValue)
        {
            writer.WriteStartElement(null, "PrncplPngAgt", xmlNamespace );
            PrincipalPayingAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PayingAgent is Organisation38 PayingAgentValue)
        {
            writer.WriteStartElement(null, "PngAgt", xmlNamespace );
            PayingAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Depository is Organisation38 DepositoryValue)
        {
            writer.WriteStartElement(null, "Dpstry", xmlNamespace );
            DepositoryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UnderlyingRisk is Organisation38 UnderlyingRiskValue)
        {
            writer.WriteStartElement(null, "UndrlygRsk", xmlNamespace );
            UnderlyingRiskValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecurityCSDLink is SecurityCSDLink7 SecurityCSDLinkValue)
        {
            writer.WriteStartElement(null, "SctyCSDLk", xmlNamespace );
            SecurityCSDLinkValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CommonFinancialInstrumentAttributes11 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
