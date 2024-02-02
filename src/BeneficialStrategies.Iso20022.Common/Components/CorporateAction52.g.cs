﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateAction52.  ISO2002 ID# _H39cwbXHEeiTob_PrFFUxA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action event.
/// </summary>
[DataContract]
[XmlType]
public partial record CorporateAction52
{
    #nullable enable
    
    /// <summary>
    /// Provides information about the dates related to a corporate action event.
    /// </summary>
    [DataMember]
    public CorporateActionDate61? DateDetails { get; init; } 
    /// <summary>
    /// Provides information about the periods related to a corporate action event.
    /// </summary>
    [DataMember]
    public CorporateActionPeriod14? PeriodDetails { get; init; } 
    /// <summary>
    /// Provides information about rates and amounts related to a corporate action event.
    /// </summary>
    [DataMember]
    public CorporateActionRate91? RateAndAmountDetails { get; init; } 
    /// <summary>
    /// Provides information about the prices related to a corporate action event.
    /// </summary>
    [DataMember]
    public CorporateActionPrice57? PriceDetails { get; init; } 
    /// <summary>
    /// Provides information about securities quantity linked to a corporate action.
    /// </summary>
    [DataMember]
    public CorporateActionQuantity7? SecuritiesQuantity { get; init; } 
    /// <summary>
    /// Number of days used for calculating the accrued interest amount.
    /// </summary>
    [DataMember]
    public IsoMax3Number? InterestAccruedNumberOfDays { get; init; } 
    /// <summary>
    /// Number of the coupon attached/associated with a security.
    /// </summary>
    [DataMember]
    public ValueList<IdentificationFormat3Choice_> CouponNumber { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Indicates whether certification/breakdown is required. 
    /// Yes = certification required.
    /// No = no certification required.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? CertificationBreakdownIndicator { get; init; } 
    /// <summary>
    /// Indicates whether charges apply to the holder, for instance redemption charges.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? ChargesAppliedIndicator { get; init; } 
    /// <summary>
    /// Indicates whether restrictions apply to the corporate action event or not.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? RestrictionIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the holder is entitled to accrued interest.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? AccruedInterestIndicator { get; init; } 
    /// <summary>
    /// Indicates whether a letter of guaranteed delivery can be submitted in order to participate in the offer on full eligible position. It is not intended for use in situations arising from failed or late trades.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? LetterOfGuaranteedDeliveryIndicator { get; init; } 
    /// <summary>
    /// Specifies the conditions in which a dividend is paid.
    /// </summary>
    [DataMember]
    public DividendTypeFormat9Choice_? DividendType { get; init; } 
    /// <summary>
    /// Specifies whether the event is an interim or a final event in a series of predefined or planned events of the same type and for the same underlying instrument.
    /// </summary>
    [DataMember]
    public EventSequenceTypeFormat1Choice_? EventSequenceType { get; init; } 
    /// <summary>
    /// Specifies the conditions in which the instructions and/or payment of the proceeds occurs.
    /// </summary>
    [DataMember]
    public DistributionTypeFormat7Choice_? OccurrenceType { get; init; } 
    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    [DataMember]
    public ValueList<OfferTypeFormat10Choice_> OfferType { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies whether terms of the event allow resale of the rights.
    /// </summary>
    [DataMember]
    public RenounceableEntitlementStatusTypeFormat3Choice_? RenounceableEntitlementStatusType { get; init; } 
    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    [DataMember]
    public ValueList<CorporateActionEventStageFormat13Choice_> EventStage { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the type of the additional business process linked to a corporate action event such as a claim compensation or tax refund.
    /// </summary>
    [DataMember]
    public ValueList<AdditionalBusinessProcessFormat9Choice_> AdditionalBusinessProcessIndicator { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the type of change announced.
    /// </summary>
    [DataMember]
    public ValueList<CorporateActionChangeTypeFormat5Choice_> ChangeType { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Type of intermediates securities distribution.
    /// </summary>
    [DataMember]
    public IntermediateSecuritiesDistributionTypeFormat15Choice_? IntermediateSecuritiesDistributionType { get; init; } 
    /// <summary>
    /// Specifies whether the capital gain is in the scope of the EU Savings directive for the income realised upon the sale, refund or redemption of shares and units (.) (Article 6(1d)).
    /// </summary>
    [DataMember]
    public CapitalGainFormat3Choice_? CapitalGainInOutIndicator { get; init; } 
    /// <summary>
    /// Specifies whether the financial instrument calculates the taxable income per dividend/taxable income per share.
    /// </summary>
    [DataMember]
    public TaxableIncomePerShareCalculatedFormat3Choice_? TaxableIncomePerShareCalculated { get; init; } 
    /// <summary>
    /// Specifies the effect on the holdings of electing a corporate action option.
    /// </summary>
    [DataMember]
    public ElectionTypeFormat3Choice_? ElectionType { get; init; } 
    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    [DataMember]
    public LotteryTypeFormat4Choice_? LotteryType { get; init; } 
    /// <summary>
    /// Specifies the certification format required, this is, physical or electronic format.
    /// </summary>
    [DataMember]
    public CertificationTypeFormat3Choice_? CertificationType { get; init; } 
    /// <summary>
    /// Specifies the type of consent announced.
    /// </summary>
    [DataMember]
    public ConsentTypeFormat4Choice_? ConsentType { get; init; } 
    /// <summary>
    /// Specifies the type of information event.
    /// </summary>
    [DataMember]
    public InformationTypeFormat4Choice_? InformationType { get; init; } 
    /// <summary>
    /// Specifies the tax regulation being attributed to the non-distributed proceeds event.
    /// </summary>
    [DataMember]
    public GenericIdentification30? TaxOnNonDistributedProceedsIndicator { get; init; } 
    /// <summary>
    /// New company's place of incorporation.
    /// </summary>
    [DataMember]
    public IsoMax350Text? NewPlaceOfIncorporation { get; init; } 
    /// <summary>
    /// Provides additional information. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    [DataMember]
    public CorporateActionNarrative26? AdditionalInformation { get; init; } 
    
    #nullable disable
}
