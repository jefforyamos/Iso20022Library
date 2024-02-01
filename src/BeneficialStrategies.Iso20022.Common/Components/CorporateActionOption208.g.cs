﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionOption208.  ISO2002 ID# _p4Yp3Ti7Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action option.
/// </summary>
public partial record CorporateActionOption208
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    public required IsoExact3NumericText OptionNumber { get; init; } 
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    public required CorporateActionOption46Choice_ OptionType { get; init; } 
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    public FractionDispositionType31Choice_? FractionDisposition { get; init; } 
    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    public OfferTypeFormat13Choice_[] OfferType { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    public OptionFeaturesFormat26Choice_[] OptionFeatures { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the status of the option.
    /// </summary>
    public OptionAvailabilityStatus4Choice_? OptionAvailabilityStatus { get; init; } 
    /// <summary>
    /// Type of certification/breakdown.
    /// </summary>
    public BeneficiaryCertificationType12Choice_[] CertificationBreakdownType { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the type of acceptable bid range values.
    /// </summary>
    public BidRangeType1Choice_? BidRangeType { get; init; } 
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
    /// Indicates whether charges apply to the holder, for instance redemption charges.
    /// </summary>
    public IsoYesNoIndicator? ChargesAppliedIndicator { get; init; } 
    /// <summary>
    /// Indicates whether certification/breakdown is required from the account owner. 
    /// Yes: certification required 
    /// No: no certification required.
    /// </summary>
    public IsoYesNoIndicator? CertificationBreakdownIndicator { get; init; } 
    /// <summary>
    /// Indicates whether withdrawal of instruction is allowed.
    /// </summary>
    public IsoYesNoIndicator? WithdrawalAllowedIndicator { get; init; } 
    /// <summary>
    /// Indicates whether change of instruction is allowed.
    /// </summary>
    public IsoYesNoIndicator? ChangeAllowedIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the option, different from the default one, shall be applied by the account owner.
    /// </summary>
    public IsoYesNoIndicator? AppliedOptionIndicator { get; init; } 
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    public SecurityIdentification20? FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Provides information about the dates related to a corporate action option.
    /// </summary>
    public CorporateActionDate82? DateDetails { get; init; } 
    /// <summary>
    /// Provides information about the periods related to a corporate action option.
    /// </summary>
    public CorporateActionPeriod12? PeriodDetails { get; init; } 
    /// <summary>
    /// Provides information about rates and amounts related to a corporate action option.
    /// </summary>
    public CorporateActionRate111? RateAndAmountDetails { get; init; } 
    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    public CorporateActionPrice81? PriceDetails { get; init; } 
    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    public SecuritiesOption84? SecuritiesQuantity { get; init; } 
    /// <summary>
    /// Provides information about the securities movement linked to the corporate action option.
    /// </summary>
    public SecuritiesOption85[] SecuritiesMovementDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides information about the cash movement linked to the corporate action option.
    /// </summary>
    public CashOption82[] CashMovementDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides additional information.
    /// </summary>
    public CorporateActionNarrative48? AdditionalInformation { get; init; } 
    
    #nullable disable
}
