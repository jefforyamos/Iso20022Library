﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateAction12.  ISO2002 ID# _QTHDhSHjEeOQ7qT4JUI53A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action event.
/// </summary>
public partial record CorporateAction12
{
    #nullable enable
    
    /// <summary>
    /// Provides information about the dates related to a corporate action event.
    /// </summary>
    public CorporateActionDate27? DateDetails { get; init; } 
    /// <summary>
    /// Provides information about the periods related to a corporate action event.
    /// </summary>
    public CorporateActionPeriod10? PeriodDetails { get; init; } 
    /// <summary>
    /// Provides information about rates and amounts related to a corporate action event.
    /// </summary>
    public CorporateActionRate43? RateAndAmountDetails { get; init; } 
    /// <summary>
    /// Provides information about the prices related to a corporate action event.
    /// </summary>
    public CorporateActionPrice42? PriceDetails { get; init; } 
    /// <summary>
    /// Provides information about securities quantity linked to a corporate action.
    /// </summary>
    public CorporateActionQuantity5? SecuritiesQuantity { get; init; } 
    /// <summary>
    /// Number of days used for calculating the accrued interest amount.
    /// </summary>
    public IsoMax3Number? InterestAccruedNumberOfDays { get; init; } 
    /// <summary>
    /// Number of the coupon attached/associated with a security.
    /// </summary>
    public IIdentificationFormat1Choice? CouponNumber { get; init;  } // Warning: Don't know multiplicity.
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
    public IDividendTypeFormat5Choice? DividendType { get; init; } 
    /// <summary>
    /// Specifies the conversion type of an instrument.
    /// </summary>
    public IConversionTypeFormat1Choice? ConversionType { get; init; } 
    /// <summary>
    /// Specifies the conditions in which the instructions and/or payment of the proceeds occurs.
    /// </summary>
    public IDistributionTypeFormat4Choice? OccurrenceType { get; init; } 
    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    public IOfferTypeFormat5Choice? OfferType { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies whether terms of the event allow resale of the rights.
    /// </summary>
    public IRenounceableEntitlementStatusTypeFormat1Choice? RenounceableEntitlementStatusType { get; init; } 
    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    public ICorporateActionEventStageFormat5Choice? EventStage { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the type of the additional business process linked to a corporate action event such as a claim compensation or tax refund.
    /// </summary>
    public IAdditionalBusinessProcessFormat1Choice? AdditionalBusinessProcessIndicator { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the type of change announced.
    /// </summary>
    public ICorporateActionChangeTypeFormat1Choice? ChangeType { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Type of intermediates securities distribution.
    /// </summary>
    public IIntermediateSecuritiesDistributionTypeFormat9Choice? IntermediateSecuritiesDistributionType { get; init; } 
    /// <summary>
    /// Specifies whether the capital gain is in the scope of the EU Savings directive for the income realised upon the sale, refund or redemption of shares and units (.) (Article 6(1d)).
    /// </summary>
    public ICapitalGainFormat1Choice? CapitalGainInOutIndicator { get; init; } 
    /// <summary>
    /// Specifies whether the financial instrument calculates the taxable income per dividend/taxable income per share.
    /// </summary>
    public ITaxableIncomePerShareCalculatedFormat1Choice? TaxableIncomePerShareCalculated { get; init; } 
    /// <summary>
    /// Specifies the effect on the holdings of electing a corporate action option.
    /// </summary>
    public IElectionTypeFormat1Choice? ElectionType { get; init; } 
    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    public ILotteryTypeFormat1Choice? LotteryType { get; init; } 
    /// <summary>
    /// Specifies the certification format required, this is, physical or electronic format.
    /// </summary>
    public ICertificationTypeFormat1Choice? CertificationType { get; init; } 
    /// <summary>
    /// Specifies the type of consent announced.
    /// </summary>
    public IConsentTypeFormat1Choice? ConsentType { get; init; } 
    /// <summary>
    /// Specifies the type of information event.
    /// </summary>
    public IInformationTypeFormat1Choice? InformationType { get; init; } 
    /// <summary>
    /// New company's place of incorporation.
    /// </summary>
    public IsoMax350Text? NewPlaceOfIncorporation { get; init; } 
    /// <summary>
    /// Provides additional information. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    public CorporateActionNarrative24? AdditionalInformation { get; init; } 
    
    #nullable disable
}
