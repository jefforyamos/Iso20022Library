﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason76Code.  ISO2002 ID# _ydlncCtXEeyhipY4f42fZQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ydlncCtXEeyhipY4f42fZQ")]
[Description(@"Specifies the reason why the instruction/cancellation request has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason76Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidReference".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6AStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    InvalidReference,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SafekeepingAccountRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6AytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    SafekeepingAccountRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "QuantityRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6BStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    QuantityRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6BytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ImpossibleToUseTheRTGSSystemInstructed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6CStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ImpossibleToUseTheRTGSSystemInstructed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementAmountCurrencyRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6CytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    SettlementAmountCurrencyRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidSecurity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6DStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    InvalidSecurity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AddressDetailsRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6DytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    AddressDetailsRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InstructionIrrevocable".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6EStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    InstructionIrrevocable,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OptionCancelled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6EytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    OptionCancelled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OptionInactive".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6FStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    OptionInactive,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidForTaxAuthorities".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6FytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    InvalidForTaxAuthorities,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RefusedByTaxAuthorities".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6GStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    RefusedByTaxAuthorities,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PhysicalSettlementImpossible".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6GytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    PhysicalSettlementImpossible,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReferenceRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6HStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ReferenceRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LackofSecurities".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6HytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    LackofSecurities,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6IStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Mismatch".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6IytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    Mismatch,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OptionNumberRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6JStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    OptionNumberRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementAmountRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6JytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    SettlementAmountRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidOptionType".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6KStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    InvalidOptionType,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RejectedSinceAlreadyCancelled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6KytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    RejectedSinceAlreadyCancelled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RejectedSinceInProgress".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6LStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    RejectedSinceInProgress,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UnrecognisedIdentification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6LytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    UnrecognisedIdentification,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingStatutes".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6MStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    MissingStatutes,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotStampedOrSigned".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6MytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    NotStampedOrSigned,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidSignature".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6NStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    InvalidSignature,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ShareholderNumberRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6NytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ShareholderNumberRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MinimumSettlementQuantity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6OStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    MinimumSettlementQuantity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NoMatch".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6OytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    NoMatch,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingLegalPower".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6PStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    MissingLegalPower,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ProcessingBatchRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6PytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ProcessingBatchRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TransactionCallDelay".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6QStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    TransactionCallDelay,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CashAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6QytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    CashAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DealPrice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6RStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    DealPrice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TypeOfOwnershipRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6RytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    TypeOfOwnershipRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotFoundRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6SStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    NotFoundRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MultipleSettlementQuantity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6SytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    MultipleSettlementQuantity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WrongRegistrationRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6TStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    WrongRegistrationRequest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxStatusRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6TytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    TaxStatusRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TerminationTransactionAmount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6UStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    TerminationTransactionAmount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RepurchaseRate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6UytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    RepurchaseRate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PremiumAmount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6VStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    PremiumAmount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DisagreementInRegistrationReason".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6VytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    DisagreementInRegistrationReason,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingRegistrationRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6WStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    MissingRegistrationRequest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RepurchaseRateType".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6WytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    RepurchaseRateType,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SpreadRate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6XStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    SpreadRate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementSystemMethodRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6XytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    SettlementSystemMethodRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TradeDate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6YStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    TradeDate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CommonReferenceRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6YytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    CommonReferenceRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PlaceOfTrade".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6ZStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    PlaceOfTrade,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NarrativeInformationRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6ZytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    NarrativeInformationRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InsufficientCollateral".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6aStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    InsufficientCollateral,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BusinessPartnerNumberRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6aytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    BusinessPartnerNumberRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BankReferenceNumberRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6bStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    BankReferenceNumberRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TypeOfOrderRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6bytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    TypeOfOrderRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CorporateActionRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6cStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    CorporateActionRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ImpossibleCashSettlementSystem".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6cytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ImpossibleCashSettlementSystem,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CommercializationContractRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6dStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    CommercializationContractRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ConcentrationLimitExceeded".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6dytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ConcentrationLimitExceeded,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UnknownDealExposure".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6eStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    UnknownDealExposure,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementDateRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6eytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    SettlementDateRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DisagreeWithCallAmount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6fStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    DisagreeWithCallAmount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DisagreeWithExposureAmount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6fytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    DisagreeWithExposureAmount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RegistrationRequestDataAndOrderRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6gStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    RegistrationRequestDataAndOrderRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FeeCommissionRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6gytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    FeeCommissionRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementTransactionRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6hStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    SettlementTransactionRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ClosingDateTimeRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6hytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ClosingDateTimeRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "VariableRateSupportRejection".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6iStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    VariableRateSupportRejection,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PlaceOfSafekeeping".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6iytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    PlaceOfSafekeeping,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LackOfStampDuty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6jStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    LackOfStampDuty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ForfeitAmount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6jytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ForfeitAmount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty2".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6kStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ReceivingDeliveringParty2,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty1".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6kytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ReceivingDeliveringParty1,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReceivingDeliveringDepository".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6lStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ReceivingDeliveringDepository,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6lytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    Other,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty3".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6mStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    ReceivingDeliveringParty3,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidInvestorParty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6mytYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    InvalidInvestorParty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PlaceOfListing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6JH6nStYEeyF-PUIGuhxvA")]
    [Description(@"??")]
    PlaceOfListing,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason76CodeMetadataExtensions
{
    private static readonly RejectionReason76CodeDropdownSource _dropdownSource = new RejectionReason76CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason76CodeDropdownRow GetMetadata(this RejectionReason76Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

