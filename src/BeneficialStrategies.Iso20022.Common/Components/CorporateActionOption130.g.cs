﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionOption130.  ISO2002 ID# _nfk0v4cQEeavwKddCbm3hg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action option.
/// </summary>
[DataContract]
[XmlType]
public partial record CorporateActionOption130
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [DataMember]
    public required IsoExact3NumericText OptionNumber { get; init; } 
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [DataMember]
    public required CorporateActionOption18Choice_ OptionType { get; init; } 
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [DataMember]
    public FractionDispositionType26Choice_? FractionDisposition { get; init; } 
    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    [DataMember]
    public ValueList<OfferTypeFormat10Choice_> OfferType { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    [DataMember]
    public ValueList<OptionFeaturesFormat22Choice_> OptionFeatures { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the status of the option.
    /// </summary>
    [DataMember]
    public OptionAvailabilityStatus3Choice_? OptionAvailabilityStatus { get; init; } 
    /// <summary>
    /// Indicates the type of certification/breakdown.
    /// </summary>
    [DataMember]
    public ValueList<BeneficiaryCertificationType9Choice_> CertificationBreakdownType { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Holder of the security has to certify, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// </summary>
    [DataMember]
    public ValueList<CountryCode> NonDomicileCountry { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Country of domicile in which the Corporate Action option is valid. The holder of the security has to certify that it is domiciled in the country indicated.
    /// </summary>
    [DataMember]
    public ValueList<CountryCode> ValidDomicileCountry { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    [DataMember]
    public ActiveCurrencyCode? CurrencyOption { get; init; } 
    /// <summary>
    /// Indicates whether the corporate action movement is a default processing or a standing instruction.
    /// </summary>
    [DataMember]
    public required DefaultProcessingOrStandingInstruction1Choice_ DefaultProcessingOrStandingInstruction { get; init; } 
    /// <summary>
    /// Indicates whether charges apply to the holder, for instance redemption charges.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? ChargesAppliedIndicator { get; init; } 
    /// <summary>
    /// Whether or not certification/breakdown is required from the account owner. 
    /// Yes: certification required 
    /// No: no certification required.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? CertificationBreakdownIndicator { get; init; } 
    /// <summary>
    /// Indicates whether withdrawal of instruction is allowed.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? WithdrawalAllowedIndicator { get; init; } 
    /// <summary>
    /// Indicates whether change of instruction is allowed.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? ChangeAllowedIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the option, different from the default one, shall be applied by the account owner.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? AppliedOptionIndicator { get; init; } 
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [DataMember]
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Provides information about the dates related to a corporate action option.
    /// </summary>
    [DataMember]
    public CorporateActionDate48? DateDetails { get; init; } 
    /// <summary>
    /// Provides information about the periods related to a corporate action option.
    /// </summary>
    [DataMember]
    public CorporateActionPeriod7? PeriodDetails { get; init; } 
    /// <summary>
    /// Provides information about rates and amounts related to a corporate action option.
    /// </summary>
    [DataMember]
    public CorporateActionRate80? RateAndAmountDetails { get; init; } 
    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [DataMember]
    public CorporateActionPrice58? PriceDetails { get; init; } 
    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    [DataMember]
    public SecuritiesOption51? SecuritiesQuantity { get; init; } 
    /// <summary>
    /// Provides information about the securities movement linked to the corporate action option.
    /// </summary>
    [DataMember]
    public ValueList<SecuritiesOption59> SecuritiesMovementDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides information about the cash movement linked to the corporate action option.
    /// </summary>
    [DataMember]
    public ValueList<CashOption50> CashMovementDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [DataMember]
    public CorporateActionNarrative29? AdditionalInformation { get; init; } 
    
    #nullable disable
}
