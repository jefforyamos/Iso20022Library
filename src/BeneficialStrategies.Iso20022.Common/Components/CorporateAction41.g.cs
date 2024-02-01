﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateAction41.  ISO2002 ID# _7ZeC0ZSfEeeh5JjedkaA_g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action event.
/// </summary>
public partial record CorporateAction41
{
    #nullable enable
    
    /// <summary>
    /// Provides information about the dates related to a corporate action event.
    /// </summary>
    public CorporateActionDate61? DateDetails { get; init; } 
    /// <summary>
    /// Provides information about the periods related to a corporate action event.
    /// </summary>
    public CorporateActionPeriod14? PeriodDetails { get; init; } 
    /// <summary>
    /// Provides information about rates and amounts related to a corporate action event.
    /// </summary>
    public CorporateActionRate91? RateAndAmountDetails { get; init; } 
    /// <summary>
    /// Provides information about the prices related to a corporate action event.
    /// </summary>
    public CorporateActionPrice57? PriceDetails { get; init; } 
    /// <summary>
    /// Provides information about securities quantity linked to a corporate action.
    /// </summary>
    public CorporateActionQuantity7? SecuritiesQuantity { get; init; } 
    /// <summary>
    /// Number of days used for calculating the accrued interest amount.
    /// </summary>
    public IsoMax3Number? InterestAccruedNumberOfDays { get; init; } 
    /// <summary>
    /// Number of the coupon attached/associated with a security.
    /// </summary>
    public IdentificationFormat3Choice_[] CouponNumber { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Indicates whether certification/breakdown is required. 
    /// Yes = certification required.
    /// No = no certification required.
    /// </summary>
    public IsoYesNoIndicator? CertificationBreakdownIndicator { get; init; } 
    /// <summary>
    /// Indicates whether charges apply to the holder, for instance redemption charges.
    /// </summary>
    public IsoYesNoIndicator? ChargesAppliedIndicator { get; init; } 
    /// <summary>
    /// Indicates whether there is restrictions apply to the corporate action event or not.|Yes = There is restrictions.|No = There is no restrictions.
    /// </summary>
    public IsoYesNoIndicator? RestrictionIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the holder is entitled to accrued interest.
    /// </summary>
    public IsoYesNoIndicator? AccruedInterestIndicator { get; init; } 
    /// <summary>
    /// Indicates whether a letter of guaranteed delivery can be submitted in order to participate in the offer on full eligible position. It is not intended for use in situations arising from failed or late trades.
    /// </summary>
    public IsoYesNoIndicator? LetterOfGuaranteedDeliveryIndicator { get; init; } 
    /// <summary>
    /// Specifies the conditions in which a dividend is paid.
    /// </summary>
    public DividendTypeFormat9Choice_? DividendType { get; init; } 
    /// <summary>
    /// Specifies the conversion type of an instrument.
    /// </summary>
    public ConversionTypeFormat3Choice_? ConversionType { get; init; } 
    /// <summary>
    /// Specifies the conditions in which the instructions and/or payment of the proceeds occurs.
    /// </summary>
    public DistributionTypeFormat7Choice_? OccurrenceType { get; init; } 
    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    public OfferTypeFormat10Choice_[] OfferType { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies whether terms of the event allow resale of the rights.
    /// </summary>
    public RenounceableEntitlementStatusTypeFormat3Choice_? RenounceableEntitlementStatusType { get; init; } 
    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    public CorporateActionEventStageFormat13Choice_[] EventStage { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the type of the additional business process linked to a corporate action event such as a claim compensation or tax refund.
    /// </summary>
    public AdditionalBusinessProcessFormat9Choice_[] AdditionalBusinessProcessIndicator { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the type of change announced.
    /// </summary>
    public CorporateActionChangeTypeFormat5Choice_[] ChangeType { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Type of intermediates securities distribution.
    /// </summary>
    public IntermediateSecuritiesDistributionTypeFormat15Choice_? IntermediateSecuritiesDistributionType { get; init; } 
    /// <summary>
    /// Specifies whether the capital gain is in the scope of the EU Savings directive for the income realised upon the sale, refund or redemption of shares and units (.) (Article 6(1d)).
    /// </summary>
    public CapitalGainFormat3Choice_? CapitalGainInOutIndicator { get; init; } 
    /// <summary>
    /// Specifies whether the financial instrument calculates the taxable income per dividend/taxable income per share.
    /// </summary>
    public TaxableIncomePerShareCalculatedFormat3Choice_? TaxableIncomePerShareCalculated { get; init; } 
    /// <summary>
    /// Specifies the effect on the holdings of electing a corporate action option.
    /// </summary>
    public ElectionTypeFormat3Choice_? ElectionType { get; init; } 
    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    public LotteryTypeFormat4Choice_? LotteryType { get; init; } 
    /// <summary>
    /// Specifies the certification format required, this is, physical or electronic format.
    /// </summary>
    public CertificationTypeFormat3Choice_? CertificationType { get; init; } 
    /// <summary>
    /// Specifies the type of consent announced.
    /// </summary>
    public ConsentTypeFormat4Choice_? ConsentType { get; init; } 
    /// <summary>
    /// Specifies the type of information event.
    /// </summary>
    public InformationTypeFormat4Choice_? InformationType { get; init; } 
    /// <summary>
    /// Specifies the tax regulation being attributed to the non-distributed proceeds event.
    /// </summary>
    public GenericIdentification30? TaxOnNonDistributedProceedsIndicator { get; init; } 
    /// <summary>
    /// New company's place of incorporation.
    /// </summary>
    public IsoMax350Text? NewPlaceOfIncorporation { get; init; } 
    /// <summary>
    /// Provides additional information. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    public CorporateActionNarrative26? AdditionalInformation { get; init; } 
    
    #nullable disable
}
