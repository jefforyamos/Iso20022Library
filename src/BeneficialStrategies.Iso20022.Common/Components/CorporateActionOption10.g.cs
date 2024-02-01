﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionOption10.  ISO2002 ID# _UEzQMtp-Ed-ak6NoX_4Aeg_-682473212.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action option.
/// </summary>
public partial record CorporateActionOption10
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    public required IsoExact3NumericText OptionNumber { get; init; } 
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    public required CorporateActionOption2Choice_ OptionType { get; init; } 
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    public FractionDispositionType1Choice_? FractionDisposition { get; init; } 
    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    public OfferTypeFormat1Choice_[] OfferType { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    public OptionFeaturesFormat2Choice_[] OptionFeatures { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the type of intermediates securities distribution.
    /// </summary>
    public IntermediateSecuritiesDistributionTypeFormat2Choice_? IntermediateSecuritiesDistributionType { get; init; } 
    /// <summary>
    /// Specifies the status of the option.
    /// </summary>
    public OptionAvailabilityStatus1Choice_? OptionAvailabilityStatus { get; init; } 
    /// <summary>
    /// Type of certification which is required.
    /// </summary>
    public BeneficiaryCertificationType1Choice_[] CertificationType { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Holder of the security has to certify, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// </summary>
    public CountryCode[] NonDomicileCountry { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Country of domicile in which the Corporate Action option is valid. The holder of the security has to certify that it is domiciled in the country indicated.
    /// </summary>
    public CountryCode[] ValidDomicileCountry { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    public ActiveCurrencyCode? CurrencyOption { get; init; } 
    /// <summary>
    /// Indicates whether the corporate action movement is a default processing or a standing instruction.
    /// </summary>
    public required DefaultProcessingOrStandingInstruction1Choice_ DefaultProcessingOrStandingInstruction { get; init; } 
    /// <summary>
    /// Indicates whether redemption charges apply.
    /// </summary>
    public IsoYesNoIndicator? ChargesAppliedIndicator { get; init; } 
    /// <summary>
    /// Indicates whether or not certification is required from the account owner. |Yes: certification required |No: no certification required.
    /// </summary>
    public IsoYesNoIndicator? CertificationIndicator { get; init; } 
    /// <summary>
    /// Indicates whether withdrawal of instruction is allowed.
    /// </summary>
    public IsoYesNoIndicator? WithdrawalAllowedIndicator { get; init; } 
    /// <summary>
    /// Indicates whether change of instruction is allowed.
    /// </summary>
    public IsoYesNoIndicator? ChangeAllowedIndicator { get; init; } 
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    public SecurityIdentification11? SecurityIdentification { get; init; } 
    /// <summary>
    /// Provides information about the dates related to a corporate action option.
    /// </summary>
    public CorporateActionDate8? DateDetails { get; init; } 
    /// <summary>
    /// Provides information about the periods related to a corporate action option.
    /// </summary>
    public CorporateActionPeriod5? PeriodDetails { get; init; } 
    /// <summary>
    /// Provides information about rates and amounts related to a corporate action option.
    /// </summary>
    public CorporateActionRate5? RateAndAmountDetails { get; init; } 
    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    public CorporateActionPrice6? PriceDetails { get; init; } 
    /// <summary>
    /// Provides information about securities quantity related to a corporate action option.
    /// </summary>
    public SecuritiesOption1? SecuritiesQuantity { get; init; } 
    /// <summary>
    /// Provides information about securities movement related to a corporate action option.
    /// </summary>
    public SecuritiesOption4[] SecuritiesMovementDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides information about the cash movement linked to the corporate action option.
    /// </summary>
    public CashOption3[] CashMovementDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides additional information about the corporate action movement.
    /// </summary>
    public CorporateActionNarrative5? AdditionalInformation { get; init; } 
    
    #nullable disable
}
