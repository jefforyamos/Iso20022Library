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
    /// Linked reference is unknown.
    /// Encoded/decoded by serializers as "InvalidReference".
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_6JH6AStYEeyF-PUIGuhxvA")]
    [Description(@"Linked reference is unknown.")]
    InvalidReference,
    
    /// <summary>
    /// Unrecognised or invalid message sender's safekeeping account.
    /// Encoded/decoded by serializers as "SafekeepingAccountRejection".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_6JH6AytYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection,
    
    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as "QuantityRejection".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_6JH6BStYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection,
    
    /// <summary>
    /// Transaction/instruction received after the account servicer's specified deadline.
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_6JH6BytYEeyF-PUIGuhxvA")]
    [Description(@"Transaction/instruction received after the account servicer's specified deadline.")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// Not possible to use the RTGS system instructed (NRTG or YRTG).
    /// Encoded/decoded by serializers as "ImpossibleToUseTheRTGSSystemInstructed".
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_6JH6CStYEeyF-PUIGuhxvA")]
    [Description(@"Not possible to use the RTGS system instructed (NRTG or YRTG).")]
    ImpossibleToUseTheRTGSSystemInstructed,
    
    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as "SettlementAmountCurrencyRejection".
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_6JH6CytYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrencyRejection,
    
    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as "InvalidSecurity".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_6JH6DStYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity,
    
    /// <summary>
    /// Address details are incorrect or cannot be recognised.
    /// Encoded/decoded by serializers as "AddressDetailsRejection".
    /// </summary>
    [EnumMember(Value = "DADR")]
    [IsoId("_6JH6DytYEeyF-PUIGuhxvA")]
    [Description(@"Address details are incorrect or cannot be recognised.")]
    AddressDetailsRejection,
    
    /// <summary>
    /// Instruction is irrevocable.
    /// Encoded/decoded by serializers as "InstructionIrrevocable".
    /// </summary>
    [EnumMember(Value = "INIR")]
    [IsoId("_6JH6EStYEeyF-PUIGuhxvA")]
    [Description(@"Instruction is irrevocable.")]
    InstructionIrrevocable,
    
    /// <summary>
    /// Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required.
    /// Encoded/decoded by serializers as "OptionCancelled".
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_6JH6EytYEeyF-PUIGuhxvA")]
    [Description(@"Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required.")]
    OptionCancelled,
    
    /// <summary>
    /// Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option.
    /// Encoded/decoded by serializers as "OptionInactive".
    /// </summary>
    [EnumMember(Value = "INTV")]
    [IsoId("_6JH6FStYEeyF-PUIGuhxvA")]
    [Description(@"Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option.")]
    OptionInactive,
    
    /// <summary>
    /// For tax reclaim, the reclaim is invalid for the tax authorities.
    /// Encoded/decoded by serializers as "InvalidForTaxAuthorities".
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_6JH6FytYEeyF-PUIGuhxvA")]
    [Description(@"For tax reclaim, the reclaim is invalid for the tax authorities.")]
    InvalidForTaxAuthorities,
    
    /// <summary>
    /// Reclaim is refused by the tax authorities.
    /// Encoded/decoded by serializers as "RefusedByTaxAuthorities".
    /// </summary>
    [EnumMember(Value = "REFT")]
    [IsoId("_6JH6GStYEeyF-PUIGuhxvA")]
    [Description(@"Reclaim is refused by the tax authorities.")]
    RefusedByTaxAuthorities,
    
    /// <summary>
    /// Physical settlement is impossible for the instructed financial instrument.
    /// Encoded/decoded by serializers as "PhysicalSettlementImpossible".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_6JH6GytYEeyF-PUIGuhxvA")]
    [Description(@"Physical settlement is impossible for the instructed financial instrument.")]
    PhysicalSettlementImpossible,
    
    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as "ReferenceRejection".
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_6JH6HStYEeyF-PUIGuhxvA")]
    [Description(@"Instruction has a reference identical to another previously received instruction.")]
    ReferenceRejection,
    
    /// <summary>
    /// Instructed position exceeds the eligible balance.
    /// Encoded/decoded by serializers as "LackofSecurities".
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_6JH6HytYEeyF-PUIGuhxvA")]
    [Description(@"Instructed position exceeds the eligible balance.")]
    LackofSecurities,
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_6JH6IStYEeyF-PUIGuhxvA")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// Mismatch between option number and option type.
    /// Encoded/decoded by serializers as "Mismatch".
    /// </summary>
    [EnumMember(Value = "NMTY")]
    [IsoId("_6JH6IytYEeyF-PUIGuhxvA")]
    [Description(@"Mismatch between option number and option type.")]
    Mismatch,
    
    /// <summary>
    /// Unrecognised option number.
    /// Encoded/decoded by serializers as "OptionNumberRejection".
    /// </summary>
    [EnumMember(Value = "OPNM")]
    [IsoId("_6JH6JStYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised option number.")]
    OptionNumberRejection,
    
    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as "SettlementAmountRejection".
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_6JH6JytYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    SettlementAmountRejection,
    
    /// <summary>
    /// Invalid option type.
    /// Encoded/decoded by serializers as "InvalidOptionType".
    /// </summary>
    [EnumMember(Value = "OPTY")]
    [IsoId("_6JH6KStYEeyF-PUIGuhxvA")]
    [Description(@"Invalid option type.")]
    InvalidOptionType,
    
    /// <summary>
    /// Cancellation request was rejected since the instruction has already been cancelled.
    /// Encoded/decoded by serializers as "RejectedSinceAlreadyCancelled".
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("_6JH6KytYEeyF-PUIGuhxvA")]
    [Description(@"Cancellation request was rejected since the instruction has already been cancelled.")]
    RejectedSinceAlreadyCancelled,
    
    /// <summary>
    /// Cancellation request has been rejected because the instruction process is in progress or has been processed.
    /// Encoded/decoded by serializers as "RejectedSinceInProgress".
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_6JH6LStYEeyF-PUIGuhxvA")]
    [Description(@"Cancellation request has been rejected because the instruction process is in progress or has been processed.")]
    RejectedSinceInProgress,
    
    /// <summary>
    /// Unrecognised event number.
    /// Encoded/decoded by serializers as "UnrecognisedIdentification".
    /// </summary>
    [EnumMember(Value = "EVNM")]
    [IsoId("_6JH6LytYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised event number.")]
    UnrecognisedIdentification,
    
    /// <summary>
    /// Missing statutes or commercial register or other legal documents.
    /// Encoded/decoded by serializers as "MissingStatutes".
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_6JH6MStYEeyF-PUIGuhxvA")]
    [Description(@"Missing statutes or commercial register or other legal documents.")]
    MissingStatutes,
    
    /// <summary>
    /// Financial instrument has not been stamped and/or duly signed.
    /// Encoded/decoded by serializers as "NotStampedOrSigned".
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_6JH6MytYEeyF-PUIGuhxvA")]
    [Description(@"Financial instrument has not been stamped and/or duly signed.")]
    NotStampedOrSigned,
    
    /// <summary>
    /// Registration request does not have a valid signature of the owner of the financial instrument.
    /// Encoded/decoded by serializers as "InvalidSignature".
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_6JH6NStYEeyF-PUIGuhxvA")]
    [Description(@"Registration request does not have a valid signature of the owner of the financial instrument.")]
    InvalidSignature,
    
    /// <summary>
    /// Unrecognised, missing or invalid shareholder number.
    /// Encoded/decoded by serializers as "ShareholderNumberRejection".
    /// </summary>
    [EnumMember(Value = "SHAR")]
    [IsoId("_6JH6NytYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised, missing or invalid shareholder number.")]
    ShareholderNumberRejection,
    
    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as "MinimumSettlementQuantity".
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_6JH6OStYEeyF-PUIGuhxvA")]
    [Description(@"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.")]
    MinimumSettlementQuantity,
    
    /// <summary>
    /// More than one instruction match the criteria.
    /// Encoded/decoded by serializers as "NoMatch".
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("_6JH6OytYEeyF-PUIGuhxvA")]
    [Description(@"More than one instruction match the criteria.")]
    NoMatch,
    
    /// <summary>
    /// Missing legal power for transfer.
    /// Encoded/decoded by serializers as "MissingLegalPower".
    /// </summary>
    [EnumMember(Value = "MLEG")]
    [IsoId("_6JH6PStYEeyF-PUIGuhxvA")]
    [Description(@"Missing legal power for transfer.")]
    MissingLegalPower,
    
    /// <summary>
    /// Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.
    /// Encoded/decoded by serializers as "ProcessingBatchRejection".
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_6JH6PytYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.")]
    ProcessingBatchRejection,
    
    /// <summary>
    /// Unrecognised or invalid transaction call delay.
    /// Encoded/decoded by serializers as "TransactionCallDelay".
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("_6JH6QStYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid transaction call delay.")]
    TransactionCallDelay,
    
    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as "CashAccount".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_6JH6QytYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount,
    
    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as "DealPrice".
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_6JH6RStYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice,
    
    /// <summary>
    /// Type of ownership indicated is not correct.
    /// Encoded/decoded by serializers as "TypeOfOwnershipRejection".
    /// </summary>
    [EnumMember(Value = "OWNT")]
    [IsoId("_6JH6RytYEeyF-PUIGuhxvA")]
    [Description(@"Type of ownership indicated is not correct.")]
    TypeOfOwnershipRejection,
    
    /// <summary>
    /// Instruction could not be found.
    /// Encoded/decoded by serializers as "NotFoundRejection".
    /// </summary>
    [EnumMember(Value = "NRGN")]
    [IsoId("_6JH6SStYEeyF-PUIGuhxvA")]
    [Description(@"Instruction could not be found.")]
    NotFoundRejection,
    
    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as "MultipleSettlementQuantity".
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_6JH6SytYEeyF-PUIGuhxvA")]
    [Description(@"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.")]
    MultipleSettlementQuantity,
    
    /// <summary>
    /// Registration request to be completed by the buyer and to be forwarded to the issuer is wrong. You have used the registration request of a different issuer/registrar.
    /// Encoded/decoded by serializers as "WrongRegistrationRequest".
    /// </summary>
    [EnumMember(Value = "REQW")]
    [IsoId("_6JH6TStYEeyF-PUIGuhxvA")]
    [Description(@"Registration request to be completed by the buyer and to be forwarded to the issuer is wrong. You have used the registration request of a different issuer/registrar.")]
    WrongRegistrationRequest,
    
    /// <summary>
    /// Unrecognised or invalid tax status of the securities instructed.
    /// Encoded/decoded by serializers as "TaxStatusRejection".
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_6JH6TytYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid tax status of the securities instructed.")]
    TaxStatusRejection,
    
    /// <summary>
    /// Unrecognised or invalid termination transaction amount.
    /// Encoded/decoded by serializers as "TerminationTransactionAmount".
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("_6JH6UStYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid termination transaction amount.")]
    TerminationTransactionAmount,
    
    /// <summary>
    /// Unrecognised or invalid repurchase rate.
    /// Encoded/decoded by serializers as "RepurchaseRate".
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_6JH6UytYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid repurchase rate.")]
    RepurchaseRate,
    
    /// <summary>
    /// Unrecognised or invalid premium amount.
    /// Encoded/decoded by serializers as "PremiumAmount".
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("_6JH6VStYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid premium amount.")]
    PremiumAmount,
    
    /// <summary>
    /// Registration reason indicated is not correct.
    /// Encoded/decoded by serializers as "DisagreementInRegistrationReason".
    /// </summary>
    [EnumMember(Value = "RREA")]
    [IsoId("_6JH6VytYEeyF-PUIGuhxvA")]
    [Description(@"Registration reason indicated is not correct.")]
    DisagreementInRegistrationReason,
    
    /// <summary>
    /// Registration request to be completed by the buyer and to be forwarded to the issuer is missing.
    /// Encoded/decoded by serializers as "MissingRegistrationRequest".
    /// </summary>
    [EnumMember(Value = "REQM")]
    [IsoId("_6JH6WStYEeyF-PUIGuhxvA")]
    [Description(@"Registration request to be completed by the buyer and to be forwarded to the issuer is missing.")]
    MissingRegistrationRequest,
    
    /// <summary>
    /// Unrecognised or invalid repurchase rate type.
    /// Encoded/decoded by serializers as "RepurchaseRateType".
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("_6JH6WytYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid repurchase rate type.")]
    RepurchaseRateType,
    
    /// <summary>
    /// Unrecognised or invalid spread rate.
    /// Encoded/decoded by serializers as "SpreadRate".
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("_6JH6XStYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid spread rate.")]
    SpreadRate,
    
    /// <summary>
    /// Unrecognised or invalid settlement system/method instructed.
    /// Encoded/decoded by serializers as "SettlementSystemMethodRejection".
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_6JH6XytYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid settlement system/method instructed.")]
    SettlementSystemMethodRejection,
    
    /// <summary>
    /// Unrecognised or invalid trade date or requested trade date or future trade date.
    /// Encoded/decoded by serializers as "TradeDate".
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_6JH6YStYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid trade date or requested trade date or future trade date.")]
    TradeDate,
    
    /// <summary>
    /// Unrecognised, invalid or missing common reference.
    /// Encoded/decoded by serializers as "CommonReferenceRejection".
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_6JH6YytYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised, invalid or missing common reference.")]
    CommonReferenceRejection,
    
    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as "PlaceOfTrade".
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_6JH6ZStYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade,
    
    /// <summary>
    /// Unrecognised or invalid service level agreement pre-agreed narrative information.
    /// Encoded/decoded by serializers as "NarrativeInformationRejection".
    /// </summary>
    [EnumMember(Value = "INNA")]
    [IsoId("_6JH6ZytYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid service level agreement pre-agreed narrative information.")]
    NarrativeInformationRejection,
    
    /// <summary>
    /// Insufficient collateral proposed.
    /// Encoded/decoded by serializers as "InsufficientCollateral".
    /// </summary>
    [EnumMember(Value = "ICOL")]
    [IsoId("_6JH6aStYEeyF-PUIGuhxvA")]
    [Description(@"Insufficient collateral proposed.")]
    InsufficientCollateral,
    
    /// <summary>
    /// Unrecognised or invalid business partner number.
    /// Encoded/decoded by serializers as "BusinessPartnerNumberRejection".
    /// </summary>
    [EnumMember(Value = "BPAR")]
    [IsoId("_6JH6aytYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid business partner number.")]
    BusinessPartnerNumberRejection,
    
    /// <summary>
    /// Unrecognised or invalid bank reference number.
    /// Encoded/decoded by serializers as "BankReferenceNumberRejection".
    /// </summary>
    [EnumMember(Value = "BREF")]
    [IsoId("_6JH6bStYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid bank reference number.")]
    BankReferenceNumberRejection,
    
    /// <summary>
    /// Unrecognised or invalid type of order.
    /// Encoded/decoded by serializers as "TypeOfOrderRejection".
    /// </summary>
    [EnumMember(Value = "BUSE")]
    [IsoId("_6JH6bytYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid type of order.")]
    TypeOfOrderRejection,
    
    /// <summary>
    /// Corporate action pending on the financial instrument instructed.
    /// Encoded/decoded by serializers as "CorporateActionRejection".
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("_6JH6cStYEeyF-PUIGuhxvA")]
    [Description(@"Corporate action pending on the financial instrument instructed.")]
    CorporateActionRejection,
    
    /// <summary>
    /// Impossible standing arrangements override instruction for the cash settlement system.
    /// Encoded/decoded by serializers as "ImpossibleCashSettlementSystem".
    /// </summary>
    [EnumMember(Value = "CASY")]
    [IsoId("_6JH6cytYEeyF-PUIGuhxvA")]
    [Description(@"Impossible standing arrangements override instruction for the cash settlement system.")]
    ImpossibleCashSettlementSystem,
    
    /// <summary>
    /// Unrecognised or invalid commercialisation contract.
    /// Encoded/decoded by serializers as "CommercializationContractRejection".
    /// </summary>
    [EnumMember(Value = "COMC")]
    [IsoId("_6JH6dStYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid commercialisation contract.")]
    CommercializationContractRejection,
    
    /// <summary>
    /// Concentration limit was exceeded.
    /// Encoded/decoded by serializers as "ConcentrationLimitExceeded".
    /// </summary>
    [EnumMember(Value = "CONL")]
    [IsoId("_6JH6dytYEeyF-PUIGuhxvA")]
    [Description(@"Concentration limit was exceeded.")]
    ConcentrationLimitExceeded,
    
    /// <summary>
    /// Deal or exposure is unknown.
    /// Encoded/decoded by serializers as "UnknownDealExposure".
    /// </summary>
    [EnumMember(Value = "CPTY")]
    [IsoId("_6JH6eStYEeyF-PUIGuhxvA")]
    [Description(@"Deal or exposure is unknown.")]
    UnknownDealExposure,
    
    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as "SettlementDateRejection".
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_6JH6eytYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDateRejection,
    
    /// <summary>
    /// Party does not agree with the call amount.
    /// Encoded/decoded by serializers as "DisagreeWithCallAmount".
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_6JH6fStYEeyF-PUIGuhxvA")]
    [Description(@"Party does not agree with the call amount.")]
    DisagreeWithCallAmount,
    
    /// <summary>
    /// Party does not agree with the exposure amount.
    /// Encoded/decoded by serializers as "DisagreeWithExposureAmount".
    /// </summary>
    [EnumMember(Value = "DISE")]
    [IsoId("_6JH6fytYEeyF-PUIGuhxvA")]
    [Description(@"Party does not agree with the exposure amount.")]
    DisagreeWithExposureAmount,
    
    /// <summary>
    /// Disagreement between the data on the registration request and the order.
    /// Encoded/decoded by serializers as "RegistrationRequestDataAndOrderRejection".
    /// </summary>
    [EnumMember(Value = "DORD")]
    [IsoId("_6JH6gStYEeyF-PUIGuhxvA")]
    [Description(@"Disagreement between the data on the registration request and the order.")]
    RegistrationRequestDataAndOrderRejection,
    
    /// <summary>
    /// Unrecognised or invalid fee or commission.
    /// Encoded/decoded by serializers as "FeeCommissionRejection".
    /// </summary>
    [EnumMember(Value = "FEEE")]
    [IsoId("_6JH6gytYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid fee or commission.")]
    FeeCommissionRejection,
    
    /// <summary>
    /// Unrecognised or invalid settlement transaction type.
    /// Encoded/decoded by serializers as "SettlementTransactionRejection".
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_6JH6hStYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid settlement transaction type.")]
    SettlementTransactionRejection,
    
    /// <summary>
    /// Unrecognised or invalid closing date/time.
    /// Encoded/decoded by serializers as "ClosingDateTimeRejection".
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_6JH6hytYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid closing date/time.")]
    ClosingDateTimeRejection,
    
    /// <summary>
    /// Unrecognised or invalid variable rate support (repurchase agreement).
    /// Encoded/decoded by serializers as "VariableRateSupportRejection".
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("_6JH6iStYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid variable rate support (repurchase agreement).")]
    VariableRateSupportRejection,
    
    /// <summary>
    /// Unrecognised, invalid or missing place of safekeeping.
    /// Encoded/decoded by serializers as "PlaceOfSafekeeping".
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_6JH6iytYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised, invalid or missing place of safekeeping.")]
    PlaceOfSafekeeping,
    
    /// <summary>
    /// Required stamp duty information is missing.
    /// Encoded/decoded by serializers as "LackOfStampDuty".
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_6JH6jStYEeyF-PUIGuhxvA")]
    [Description(@"Required stamp duty information is missing.")]
    LackOfStampDuty,
    
    /// <summary>
    /// Unrecognised or invalid forfeit amount.
    /// Encoded/decoded by serializers as "ForfeitAmount".
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_6JH6jytYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid forfeit amount.")]
    ForfeitAmount,
    
    /// <summary>
    /// Unrecognised or invalid client of delivering or receiving party 1.
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty2".
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_6JH6kStYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid client of delivering or receiving party 1.")]
    ReceivingDeliveringParty2,
    
    /// <summary>
    /// Unrecognised or invalid participant of delivering or receiving depository.
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty1".
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_6JH6kytYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid participant of delivering or receiving depository.")]
    ReceivingDeliveringParty1,
    
    /// <summary>
    /// Unrecognised or invalid depository.
    /// Encoded/decoded by serializers as "ReceivingDeliveringDepository".
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_6JH6lStYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid depository.")]
    ReceivingDeliveringDepository,
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_6JH6lytYEeyF-PUIGuhxvA")]
    [Description(@"Other. See Narrative.")]
    Other,
    
    /// <summary>
    /// Unrecognised or invalid client of delivering or receiving party 2.
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty3".
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_6JH6mStYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid client of delivering or receiving party 2.")]
    ReceivingDeliveringParty3,
    
    /// <summary>
    /// Unrecognised or invalid investor party. May be used by an executing party to reject an instruction for an investor (or portfolio) for which it is not authorised to act.
    /// Encoded/decoded by serializers as "InvalidInvestorParty".
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_6JH6mytYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid investor party. May be used by an executing party to reject an instruction for an investor (or portfolio) for which it is not authorised to act.")]
    InvalidInvestorParty,
    
    /// <summary>
    /// Unrecognised or invalid place of listing. Used when the security identified is not listed on the market supplied.
    /// Encoded/decoded by serializers as "PlaceOfListing".
    /// </summary>
    [EnumMember(Value = "PLIS")]
    [IsoId("_6JH6nStYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid place of listing. Used when the security identified is not listed on the market supplied.")]
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


