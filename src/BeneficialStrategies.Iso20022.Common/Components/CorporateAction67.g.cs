﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateAction67.  ISO2002 ID# _p4QGUzi7Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action event.
/// </summary>
public partial record CorporateAction67
{
    #nullable enable
    
    /// <summary>
    /// Provides information about the dates related to a corporate action event.
    /// </summary>
    public CorporateActionDate74? DateDetails { get; init; } 
    /// <summary>
    /// Provides information about the periods related to a corporate action event.
    /// </summary>
    public CorporateActionPeriod15? PeriodDetails { get; init; } 
    /// <summary>
    /// Provides information about rates and amounts related to a corporate action event.
    /// </summary>
    public CorporateActionRate110? RateAndAmountDetails { get; init; } 
    /// <summary>
    /// Provides information about the prices related to a corporate action event.
    /// </summary>
    public CorporateActionPrice80? PriceDetails { get; init; } 
    /// <summary>
    /// Provides information about securities quantity linked to a corporate action.
    /// </summary>
    public CorporateActionQuantity14? SecuritiesQuantity { get; init; } 
    /// <summary>
    /// Number of days used for calculating the accrued interest amount.
    /// </summary>
    public IsoMax3Number? InterestAccruedNumberOfDays { get; init; } 
    /// <summary>
    /// Number of the coupon attached/associated with a security.
    /// </summary>
    public IIdentificationFormat4Choice? CouponNumber { get; init;  } // Warning: Don't know multiplicity.
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
    /// Indicates whether restrictions apply to the corporate action event or not.
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
    /// Indicates whether the announcement was initiated by the first intermediary in the custody chain in accordance with SRD II.
    /// </summary>
    public IsoYesNoIndicator? ShareholderRightsDirectiveIndicator { get; init; } 
    /// <summary>
    /// Specifies the conditions in which a dividend is paid.
    /// </summary>
    public IDividendTypeFormat10Choice? DividendType { get; init; } 
    /// <summary>
    /// Specifies whether the event is an interim or a final event in a series of predefined or planned events of the same type and for the same underlying instrument.
    /// </summary>
    public IEventSequenceTypeFormat2Choice? EventSequenceType { get; init; } 
    /// <summary>
    /// Specifies the conditions in which the instructions and/or payment of the proceeds occurs.
    /// </summary>
    public IDistributionTypeFormat8Choice? OccurrenceType { get; init; } 
    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    public IOfferTypeFormat13Choice? OfferType { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies whether terms of the event allow resale of the rights.
    /// </summary>
    public IRenounceableEntitlementStatusTypeFormat4Choice? RenounceableEntitlementStatusType { get; init; } 
    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    public ICorporateActionEventStageFormat20Choice? EventStage { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the type of the additional business process linked to the corporate action event such as a claim compensation or tax refund.
    /// </summary>
    public IAdditionalBusinessProcessFormat22Choice? AdditionalBusinessProcessIndicator { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the type of change announced.
    /// </summary>
    public ICorporateActionChangeTypeFormat8Choice? ChangeType { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Type of intermediates securities distribution.
    /// </summary>
    public IIntermediateSecuritiesDistributionTypeFormat18Choice? IntermediateSecuritiesDistributionType { get; init; } 
    /// <summary>
    /// Specifies whether the capital gain is in the scope of the EU Savings directive for the income realised upon the sale, refund or redemption of shares and units (.) (Article 6(1d)).
    /// </summary>
    public ICapitalGainFormat4Choice? CapitalGainInOutIndicator { get; init; } 
    /// <summary>
    /// Specifies whether the financial instrument calculates the taxable income per dividend/taxable income per share.
    /// </summary>
    public ITaxableIncomePerShareCalculatedFormat4Choice? TaxableIncomePerShareCalculated { get; init; } 
    /// <summary>
    /// Specifies the effect on the holdings of electing a corporate action option.
    /// </summary>
    public IElectionTypeFormat4Choice? ElectionType { get; init; } 
    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    public ILotteryTypeFormat5Choice? LotteryType { get; init; } 
    /// <summary>
    /// Specifies the certification format required, this is, physical or electronic format.
    /// </summary>
    public ICertificationTypeFormat4Choice? CertificationType { get; init; } 
    /// <summary>
    /// Specifies the type of consent announced.
    /// </summary>
    public IConsentTypeFormat5Choice? ConsentType { get; init; } 
    /// <summary>
    /// Specifies the type of information event.
    /// </summary>
    public IInformationTypeFormat5Choice? InformationType { get; init; } 
    /// <summary>
    /// Specifies the tax regulation being attributed to the non-distributed proceeds event or to any other event.
    /// </summary>
    public GenericIdentification47? TaxOnNonDistributedProceedsIndicator { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// New company's place of incorporation.
    /// </summary>
    public IsoRestrictedFINXMax350Text? NewPlaceOfIncorporation { get; init; } 
    /// <summary>
    /// Provides additional information. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    public CorporateActionNarrative54? AdditionalInformation { get; init; } 
    
    #nullable disable
}
