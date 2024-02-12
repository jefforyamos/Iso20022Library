﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionOption129.  ISO2002 ID# _mYTp8YcQEeavwKddCbm3hg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action option.
/// </summary>
[IsoId("_mYTp8YcQEeavwKddCbm3hg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Corporate Action Option")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionOption129
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionOption129 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionOption129( System.String reqOptionNumber,CorporateActionOption18Choice_ reqOptionType,DefaultProcessingOrStandingInstruction1Choice_ reqDefaultProcessingOrStandingInstruction )
    {
        OptionNumber = reqOptionNumber;
        OptionType = reqOptionType;
        DefaultProcessingOrStandingInstruction = reqDefaultProcessingOrStandingInstruction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_mv0LC4cQEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Option Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact3NumericText OptionNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String OptionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OptionNumber { get; init; } 
    #else
    public System.String OptionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_mv0LE4cQEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Option Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionOption18Choice_ OptionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CorporateActionOption18Choice_ OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption18Choice_ OptionType { get; init; } 
    #else
    public CorporateActionOption18Choice_ OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_mv0LG4cQEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Fraction Disposition")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FractionDispositionType26Choice_? FractionDisposition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FractionDispositionType26Choice_? FractionDisposition { get; init; } 
    #else
    public FractionDispositionType26Choice_? FractionDisposition { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    [IsoId("_mv0LI4cQEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Offer Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OfferTypeFormat10Choice_? OfferType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OfferTypeFormat10Choice_? OfferType { get; init; } 
    #else
    public OfferTypeFormat10Choice_? OfferType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    [IsoId("_mv0LK4cQEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Option Features")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionFeaturesFormat22Choice_? OptionFeatures { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionFeaturesFormat22Choice_? OptionFeatures { get; init; } 
    #else
    public OptionFeaturesFormat22Choice_? OptionFeatures { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of intermediates securities distribution.
    /// </summary>
    [IsoId("_mv0LM4cQEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Intermediate Securities Distribution Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IntermediateSecuritiesDistributionTypeFormat15Choice_? IntermediateSecuritiesDistributionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IntermediateSecuritiesDistributionTypeFormat15Choice_? IntermediateSecuritiesDistributionType { get; init; } 
    #else
    public IntermediateSecuritiesDistributionTypeFormat15Choice_? IntermediateSecuritiesDistributionType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the status of the option.
    /// </summary>
    [IsoId("_mv0LO4cQEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Option Availability Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionAvailabilityStatus3Choice_? OptionAvailabilityStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionAvailabilityStatus3Choice_? OptionAvailabilityStatus { get; init; } 
    #else
    public OptionAvailabilityStatus3Choice_? OptionAvailabilityStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the type of certification/breakdown.
    /// </summary>
    [IsoId("_mv0LQ4cQEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Certification Breakdown Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BeneficiaryCertificationType9Choice_? CertificationBreakdownType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BeneficiaryCertificationType9Choice_? CertificationBreakdownType { get; init; } 
    #else
    public BeneficiaryCertificationType9Choice_? CertificationBreakdownType { get; set; } 
    #endif
    
    /// <summary>
    /// Holder of the security has to certify, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// </summary>
    [IsoId("_mv0LS4cQEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Non Domicile Country")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? NonDomicileCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? NonDomicileCountry { get; init; } 
    #else
    public string? NonDomicileCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Country of domicile in which the Corporate Action option is valid. The holder of the security has to certify that it is domiciled in the country indicated.
    /// </summary>
    [IsoId("_mv0LU4cQEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Valid Domicile Country")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? ValidDomicileCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? ValidDomicileCountry { get; init; } 
    #else
    public string? ValidDomicileCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    [IsoId("_mv0LW4cQEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Currency Option")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? CurrencyOption { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CurrencyOption { get; init; } 
    #else
    public string? CurrencyOption { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the corporate action movement is a default processing or a standing instruction.
    /// </summary>
    [IsoId("_mv0LY4cQEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Default Processing Or Standing Instruction")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DefaultProcessingOrStandingInstruction1Choice_ DefaultProcessingOrStandingInstruction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public DefaultProcessingOrStandingInstruction1Choice_ DefaultProcessingOrStandingInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DefaultProcessingOrStandingInstruction1Choice_ DefaultProcessingOrStandingInstruction { get; init; } 
    #else
    public DefaultProcessingOrStandingInstruction1Choice_ DefaultProcessingOrStandingInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether redemption charges apply.
    /// </summary>
    [IsoId("_mv0La4cQEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Charges Applied Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ChargesAppliedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ChargesAppliedIndicator { get; init; } 
    #else
    public System.String? ChargesAppliedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not certification/breakdown is required from the account owner. 
    /// Yes: certification required 
    /// No: no certification required.
    /// </summary>
    [IsoId("_mv0Lc4cQEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Certification Breakdown Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CertificationBreakdownIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CertificationBreakdownIndicator { get; init; } 
    #else
    public System.String? CertificationBreakdownIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether withdrawal of instruction is allowed.
    /// </summary>
    [IsoId("_mv0Le4cQEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Withdrawal Allowed Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? WithdrawalAllowedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? WithdrawalAllowedIndicator { get; init; } 
    #else
    public System.String? WithdrawalAllowedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether change of instruction is allowed.
    /// </summary>
    [IsoId("_mv0Lg4cQEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Change Allowed Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ChangeAllowedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ChangeAllowedIndicator { get; init; } 
    #else
    public System.String? ChangeAllowedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the option, different from the default one, shall be applied by the account owner.
    /// </summary>
    [IsoId("_mv0Li4cQEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Applied Option Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AppliedOptionIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AppliedOptionIndicator { get; init; } 
    #else
    public System.String? AppliedOptionIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_mv0LjYcQEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Security Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification19? SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19? SecurityIdentification { get; init; } 
    #else
    public SecurityIdentification19? SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the dates related to a corporate action option.
    /// </summary>
    [IsoId("_mv0LlYcQEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Date Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionDate48? DateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionDate48? DateDetails { get; init; } 
    #else
    public CorporateActionDate48? DateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the periods related to a corporate action option.
    /// </summary>
    [IsoId("_mv0LnYcQEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Period Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionPeriod7? PeriodDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPeriod7? PeriodDetails { get; init; } 
    #else
    public CorporateActionPeriod7? PeriodDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about rates and amounts related to a corporate action option.
    /// </summary>
    [IsoId("_mv0LpYcQEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rate And Amount Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionRate81? RateAndAmountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionRate81? RateAndAmountDetails { get; init; } 
    #else
    public CorporateActionRate81? RateAndAmountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_mv0LrYcQEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Price Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionPrice58? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPrice58? PriceDetails { get; init; } 
    #else
    public CorporateActionPrice58? PriceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about securities quantity related to a corporate action option.
    /// </summary>
    [IsoId("_mv0LtYcQEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Securities Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesOption51? SecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesOption51? SecuritiesQuantity { get; init; } 
    #else
    public SecuritiesOption51? SecuritiesQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about securities movement related to a corporate action option.
    /// </summary>
    [IsoId("_mv0LvYcQEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Securities Movement Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesOption59? SecuritiesMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesOption59? SecuritiesMovementDetails { get; init; } 
    #else
    public SecuritiesOption59? SecuritiesMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the cash movement linked to the corporate action option.
    /// </summary>
    [IsoId("_mv0LxYcQEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cash Movement Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashOption51? CashMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashOption51? CashMovementDetails { get; init; } 
    #else
    public CashOption51? CashMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information about the corporate action movement.
    /// </summary>
    [IsoId("_mv0LzYcQEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionNarrative29? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionNarrative29? AdditionalInformation { get; init; } 
    #else
    public CorporateActionNarrative29? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
