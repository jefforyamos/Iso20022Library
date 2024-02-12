﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason39Code.  ISO2002 ID# _2GP6USwwEeOEV5XHD-BKpw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2GP6USwwEeOEV5XHD-BKpw")]
[Description(@"Specifies the reason why the instruction/cancellation request has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV2Code))]
public enum RejectionReason39Code
{
    /// <summary>
    /// Linked reference is unknown.
    /// Encoded/decoded by serializers as "ULNK".
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_2fPpISwwEeOEV5XHD-BKpw")]
    [Description(@"Linked reference is unknown.")]
    InvalidReference = RejectionReasonV2Code.InvalidReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid message sender's safekeeping account.
    /// Encoded/decoded by serializers as "SAFE".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_2fPpIywwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonV2Code.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as "DQUA".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_2fPpJSwwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection = RejectionReasonV2Code.QuantityRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction/instruction received after the account servicer's specified deadline.
    /// Encoded/decoded by serializers as "ADEA".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_2fPpJywwEeOEV5XHD-BKpw")]
    [Description(@"Transaction/instruction received after the account servicer's specified deadline.")]
    AccountServicerDeadlineMissed = RejectionReasonV2Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Not possible to use the RTGS system instructed (NRTG or YRTG).
    /// Encoded/decoded by serializers as "RTGS".
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_2fPpKSwwEeOEV5XHD-BKpw")]
    [Description(@"Not possible to use the RTGS system instructed (NRTG or YRTG).")]
    ImpossibleToUseTheRTGSSystemInstructed = RejectionReasonV2Code.ImpossibleToUseTheRTGSSystemInstructed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as "NCRR".
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_2fPpKywwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrencyRejection = RejectionReasonV2Code.SettlementAmountCurrencyRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as "DSEC".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_2fPpLSwwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity = RejectionReasonV2Code.InvalidSecurity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Address details are incorrect or cannot be recognised.
    /// Encoded/decoded by serializers as "DADR".
    /// </summary>
    [EnumMember(Value = "DADR")]
    [IsoId("_2fPpLywwEeOEV5XHD-BKpw")]
    [Description(@"Address details are incorrect or cannot be recognised.")]
    AddressDetailsRejection = RejectionReasonV2Code.AddressDetailsRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is irrevocable.
    /// Encoded/decoded by serializers as "INIR".
    /// </summary>
    [EnumMember(Value = "INIR")]
    [IsoId("_2fPpMSwwEeOEV5XHD-BKpw")]
    [Description(@"Instruction is irrevocable.")]
    InstructionIrrevocable = RejectionReasonV2Code.InstructionIrrevocable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required.
    /// Encoded/decoded by serializers as "CANC".
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_2fPpMywwEeOEV5XHD-BKpw")]
    [Description(@"Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required.")]
    OptionCancelled = RejectionReasonV2Code.OptionCancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option.
    /// Encoded/decoded by serializers as "INTV".
    /// </summary>
    [EnumMember(Value = "INTV")]
    [IsoId("_2fPpNSwwEeOEV5XHD-BKpw")]
    [Description(@"Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option.")]
    OptionInactive = RejectionReasonV2Code.OptionInactive, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// For tax reclaim, the reclaim is invalid for the tax authorities.
    /// Encoded/decoded by serializers as "INVA".
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_2fPpNywwEeOEV5XHD-BKpw")]
    [Description(@"For tax reclaim, the reclaim is invalid for the tax authorities.")]
    InvalidForTaxAuthorities = RejectionReasonV2Code.InvalidForTaxAuthorities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reclaim is refused by the tax authorities.
    /// Encoded/decoded by serializers as "REFT".
    /// </summary>
    [EnumMember(Value = "REFT")]
    [IsoId("_2fPpOSwwEeOEV5XHD-BKpw")]
    [Description(@"Reclaim is refused by the tax authorities.")]
    RefusedByTaxAuthorities = RejectionReasonV2Code.RefusedByTaxAuthorities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Physical settlement is impossible for the instructed financial instrument.
    /// Encoded/decoded by serializers as "PHYS".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_2fPpOywwEeOEV5XHD-BKpw")]
    [Description(@"Physical settlement is impossible for the instructed financial instrument.")]
    PhysicalSettlementImpossible = RejectionReasonV2Code.PhysicalSettlementImpossible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as "REFE".
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_2fPpPSwwEeOEV5XHD-BKpw")]
    [Description(@"Instruction has a reference identical to another previously received instruction.")]
    ReferenceRejection = RejectionReasonV2Code.ReferenceRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instructed position exceeds the eligible balance.
    /// Encoded/decoded by serializers as "LACK".
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_2fPpPywwEeOEV5XHD-BKpw")]
    [Description(@"Instructed position exceeds the eligible balance.")]
    LackofSecurities = RejectionReasonV2Code.LackofSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_2fPpQSwwEeOEV5XHD-BKpw")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV2Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Mismatch between option number and option type.
    /// Encoded/decoded by serializers as "NMTY".
    /// </summary>
    [EnumMember(Value = "NMTY")]
    [IsoId("_2fPpQywwEeOEV5XHD-BKpw")]
    [Description(@"Mismatch between option number and option type.")]
    Mismatch = RejectionReasonV2Code.Mismatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised option number.
    /// Encoded/decoded by serializers as "OPNM".
    /// </summary>
    [EnumMember(Value = "OPNM")]
    [IsoId("_2fPpRSwwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised option number.")]
    OptionNumberRejection = RejectionReasonV2Code.OptionNumberRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as "DMON".
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_2fPpRywwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    SettlementAmountRejection = RejectionReasonV2Code.SettlementAmountRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid option type.
    /// Encoded/decoded by serializers as "OPTY".
    /// </summary>
    [EnumMember(Value = "OPTY")]
    [IsoId("_2fPpSSwwEeOEV5XHD-BKpw")]
    [Description(@"Invalid option type.")]
    InvalidOptionType = RejectionReasonV2Code.InvalidOptionType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request was rejected since the instruction has already been cancelled.
    /// Encoded/decoded by serializers as "DCAN".
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("_2fPpSywwEeOEV5XHD-BKpw")]
    [Description(@"Cancellation request was rejected since the instruction has already been cancelled.")]
    RejectedSinceAlreadyCancelled = RejectionReasonV2Code.RejectedSinceAlreadyCancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request has been rejected because the instruction process is in progress or has been processed.
    /// Encoded/decoded by serializers as "DPRG".
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_2fPpTSwwEeOEV5XHD-BKpw")]
    [Description(@"Cancellation request has been rejected because the instruction process is in progress or has been processed.")]
    RejectedSinceInProgress = RejectionReasonV2Code.RejectedSinceInProgress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised event number.
    /// Encoded/decoded by serializers as "EVNM".
    /// </summary>
    [EnumMember(Value = "EVNM")]
    [IsoId("_2fPpTywwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised event number.")]
    UnrecognisedIdentification = RejectionReasonV2Code.UnrecognisedIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Missing statutes or commercial register or other legal documents.
    /// Encoded/decoded by serializers as "STAT".
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_2fPpUSwwEeOEV5XHD-BKpw")]
    [Description(@"Missing statutes or commercial register or other legal documents.")]
    MissingStatutes = RejectionReasonV2Code.MissingStatutes, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial instrument has not been stamped and/or duly signed.
    /// Encoded/decoded by serializers as "STAM".
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_2fZaISwwEeOEV5XHD-BKpw")]
    [Description(@"Financial instrument has not been stamped and/or duly signed.")]
    NotStampedOrSigned = RejectionReasonV2Code.NotStampedOrSigned, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Registration request does not have a valid signature of the owner of the financial instrument.
    /// Encoded/decoded by serializers as "SIGN".
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_2fZaIywwEeOEV5XHD-BKpw")]
    [Description(@"Registration request does not have a valid signature of the owner of the financial instrument.")]
    InvalidSignature = RejectionReasonV2Code.InvalidSignature, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid shareholder number.
    /// Encoded/decoded by serializers as "SHAR".
    /// </summary>
    [EnumMember(Value = "SHAR")]
    [IsoId("_2fZaJSwwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid shareholder number.")]
    ShareholderNumberRejection = RejectionReasonV2Code.ShareholderNumberRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as "MINO".
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_2fZaJywwEeOEV5XHD-BKpw")]
    [Description(@"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.")]
    MinimumSettlementQuantity = RejectionReasonV2Code.MinimumSettlementQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// More than one instruction match the criteria.
    /// Encoded/decoded by serializers as "NRGM".
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("_2fZaKSwwEeOEV5XHD-BKpw")]
    [Description(@"More than one instruction match the criteria.")]
    NoMatch = RejectionReasonV2Code.NoMatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Missing legal power for transfer.
    /// Encoded/decoded by serializers as "MLEG".
    /// </summary>
    [EnumMember(Value = "MLEG")]
    [IsoId("_2fZaKywwEeOEV5XHD-BKpw")]
    [Description(@"Missing legal power for transfer.")]
    MissingLegalPower = RejectionReasonV2Code.MissingLegalPower, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.
    /// Encoded/decoded by serializers as "BATC".
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_2fZaLSwwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.")]
    ProcessingBatchRejection = RejectionReasonV2Code.ProcessingBatchRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid transaction call delay.
    /// Encoded/decoded by serializers as "CADE".
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("_2fZaLywwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid transaction call delay.")]
    TransactionCallDelay = RejectionReasonV2Code.TransactionCallDelay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_2fZaMSwwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount = RejectionReasonV2Code.CashAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as "DDEA".
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_2fZaMywwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice = RejectionReasonV2Code.DealPrice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type of ownership indicated is not correct.
    /// Encoded/decoded by serializers as "OWNT".
    /// </summary>
    [EnumMember(Value = "OWNT")]
    [IsoId("_2fZaNSwwEeOEV5XHD-BKpw")]
    [Description(@"Type of ownership indicated is not correct.")]
    TypeOfOwnershipRejection = RejectionReasonV2Code.TypeOfOwnershipRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction could not be found.
    /// Encoded/decoded by serializers as "NRGN".
    /// </summary>
    [EnumMember(Value = "NRGN")]
    [IsoId("_2fZaNywwEeOEV5XHD-BKpw")]
    [Description(@"Instruction could not be found.")]
    NotFoundRejection = RejectionReasonV2Code.NotFoundRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as "MUNO".
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_2fZaOSwwEeOEV5XHD-BKpw")]
    [Description(@"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.")]
    MultipleSettlementQuantity = RejectionReasonV2Code.MultipleSettlementQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Registration request to be completed by the buyer and to be forwarded to the issuer is wrong. You have used the registration request of a different issuer/registrar.
    /// Encoded/decoded by serializers as "REQW".
    /// </summary>
    [EnumMember(Value = "REQW")]
    [IsoId("_2fZaOywwEeOEV5XHD-BKpw")]
    [Description(@"Registration request to be completed by the buyer and to be forwarded to the issuer is wrong. You have used the registration request of a different issuer/registrar.")]
    WrongRegistrationRequest = RejectionReasonV2Code.WrongRegistrationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid tax status of the securities instructed.
    /// Encoded/decoded by serializers as "TXST".
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_2fZaPSwwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid tax status of the securities instructed.")]
    TaxStatusRejection = RejectionReasonV2Code.TaxStatusRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid termination transaction amount.
    /// Encoded/decoded by serializers as "REPA".
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("_2fZaPywwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid termination transaction amount.")]
    TerminationTransactionAmount = RejectionReasonV2Code.TerminationTransactionAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid repurchase rate.
    /// Encoded/decoded by serializers as "REPO".
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_2fZaQSwwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid repurchase rate.")]
    RepurchaseRate = RejectionReasonV2Code.RepurchaseRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid premium amount.
    /// Encoded/decoded by serializers as "REPP".
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("_2fZaQywwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid premium amount.")]
    PremiumAmount = RejectionReasonV2Code.PremiumAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Registration reason indicated is not correct.
    /// Encoded/decoded by serializers as "RREA".
    /// </summary>
    [EnumMember(Value = "RREA")]
    [IsoId("_2fZaRSwwEeOEV5XHD-BKpw")]
    [Description(@"Registration reason indicated is not correct.")]
    DisagreementInRegistrationReason = RejectionReasonV2Code.DisagreementInRegistrationReason, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Registration request to be completed by the buyer and to be forwarded to the issuer is missing.
    /// Encoded/decoded by serializers as "REQM".
    /// </summary>
    [EnumMember(Value = "REQM")]
    [IsoId("_2fZaRywwEeOEV5XHD-BKpw")]
    [Description(@"Registration request to be completed by the buyer and to be forwarded to the issuer is missing.")]
    MissingRegistrationRequest = RejectionReasonV2Code.MissingRegistrationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid repurchase rate type.
    /// Encoded/decoded by serializers as "RERT".
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("_2fZaSSwwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid repurchase rate type.")]
    RepurchaseRateType = RejectionReasonV2Code.RepurchaseRateType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid spread rate.
    /// Encoded/decoded by serializers as "RSPR".
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("_2fZaSywwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid spread rate.")]
    SpreadRate = RejectionReasonV2Code.SpreadRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement system/method instructed.
    /// Encoded/decoded by serializers as "SETS".
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_2fZaTSwwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid settlement system/method instructed.")]
    SettlementSystemMethodRejection = RejectionReasonV2Code.SettlementSystemMethodRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid trade date or requested trade date or future trade date.
    /// Encoded/decoded by serializers as "DTRD".
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_2fZaTywwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid trade date or requested trade date or future trade date.")]
    TradeDate = RejectionReasonV2Code.TradeDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised, invalid or missing common reference.
    /// Encoded/decoded by serializers as "IIND".
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_2fZaUSwwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised, invalid or missing common reference.")]
    CommonReferenceRejection = RejectionReasonV2Code.CommonReferenceRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as "PLCE".
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_2fZaUywwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade = RejectionReasonV2Code.PlaceOfTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid service level agreement pre-agreed narrative information.
    /// Encoded/decoded by serializers as "INNA".
    /// </summary>
    [EnumMember(Value = "INNA")]
    [IsoId("_2fZaVSwwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid service level agreement pre-agreed narrative information.")]
    NarrativeInformationRejection = RejectionReasonV2Code.NarrativeInformationRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient collateral proposed.
    /// Encoded/decoded by serializers as "ICOL".
    /// </summary>
    [EnumMember(Value = "ICOL")]
    [IsoId("_2fZaVywwEeOEV5XHD-BKpw")]
    [Description(@"Insufficient collateral proposed.")]
    InsufficientCollateral = RejectionReasonV2Code.InsufficientCollateral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid business partner number.
    /// Encoded/decoded by serializers as "BPAR".
    /// </summary>
    [EnumMember(Value = "BPAR")]
    [IsoId("_2fZaWSwwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid business partner number.")]
    BusinessPartnerNumberRejection = RejectionReasonV2Code.BusinessPartnerNumberRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid bank reference number.
    /// Encoded/decoded by serializers as "BREF".
    /// </summary>
    [EnumMember(Value = "BREF")]
    [IsoId("_2fZaWywwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid bank reference number.")]
    BankReferenceNumberRejection = RejectionReasonV2Code.BankReferenceNumberRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid type of order.
    /// Encoded/decoded by serializers as "BUSE".
    /// </summary>
    [EnumMember(Value = "BUSE")]
    [IsoId("_2fZaXSwwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid type of order.")]
    TypeOfOrderRejection = RejectionReasonV2Code.TypeOfOrderRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Corporate action pending on the financial instrument instructed.
    /// Encoded/decoded by serializers as "CAEV".
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("_2fZaXywwEeOEV5XHD-BKpw")]
    [Description(@"Corporate action pending on the financial instrument instructed.")]
    CorporateActionRejection = RejectionReasonV2Code.CorporateActionRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Impossible standing arrangements override instruction for the cash settlement system.
    /// Encoded/decoded by serializers as "CASY".
    /// </summary>
    [EnumMember(Value = "CASY")]
    [IsoId("_2fZaYSwwEeOEV5XHD-BKpw")]
    [Description(@"Impossible standing arrangements override instruction for the cash settlement system.")]
    ImpossibleCashSettlementSystem = RejectionReasonV2Code.ImpossibleCashSettlementSystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid commercialisation contract.
    /// Encoded/decoded by serializers as "COMC".
    /// </summary>
    [EnumMember(Value = "COMC")]
    [IsoId("_2fZaYywwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid commercialisation contract.")]
    CommercializationContractRejection = RejectionReasonV2Code.CommercializationContractRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Concentration limit was exceeded.
    /// Encoded/decoded by serializers as "CONL".
    /// </summary>
    [EnumMember(Value = "CONL")]
    [IsoId("_2fZaZSwwEeOEV5XHD-BKpw")]
    [Description(@"Concentration limit was exceeded.")]
    ConcentrationLimitExceeded = RejectionReasonV2Code.ConcentrationLimitExceeded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deal or exposure is unknown.
    /// Encoded/decoded by serializers as "CPTY".
    /// </summary>
    [EnumMember(Value = "CPTY")]
    [IsoId("_2fZaZywwEeOEV5XHD-BKpw")]
    [Description(@"Deal or exposure is unknown.")]
    UnknownDealExposure = RejectionReasonV2Code.UnknownDealExposure, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as "DDAT".
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_2fZaaSwwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDateRejection = RejectionReasonV2Code.SettlementDateRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party does not agree with the call amount.
    /// Encoded/decoded by serializers as "DISC".
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_2fZaaywwEeOEV5XHD-BKpw")]
    [Description(@"Party does not agree with the call amount.")]
    DisagreeWithCallAmount = RejectionReasonV2Code.DisagreeWithCallAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party does not agree with the exposure amount.
    /// Encoded/decoded by serializers as "DISE".
    /// </summary>
    [EnumMember(Value = "DISE")]
    [IsoId("_2fZabSwwEeOEV5XHD-BKpw")]
    [Description(@"Party does not agree with the exposure amount.")]
    DisagreeWithExposureAmount = RejectionReasonV2Code.DisagreeWithExposureAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Disagreement between the data on the registration request and the order.
    /// Encoded/decoded by serializers as "DORD".
    /// </summary>
    [EnumMember(Value = "DORD")]
    [IsoId("_2fZabywwEeOEV5XHD-BKpw")]
    [Description(@"Disagreement between the data on the registration request and the order.")]
    RegistrationRequestDataAndOrderRejection = RejectionReasonV2Code.RegistrationRequestDataAndOrderRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid fee or commission.
    /// Encoded/decoded by serializers as "FEEE".
    /// </summary>
    [EnumMember(Value = "FEEE")]
    [IsoId("_2fZacSwwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid fee or commission.")]
    FeeCommissionRejection = RejectionReasonV2Code.FeeCommissionRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid settlement transaction type.
    /// Encoded/decoded by serializers as "SETR".
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_2fZacywwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid settlement transaction type.")]
    SettlementTransactionRejection = RejectionReasonV2Code.SettlementTransactionRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid closing date/time.
    /// Encoded/decoded by serializers as "TERM".
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_2fZadSwwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid closing date/time.")]
    ClosingDateTimeRejection = RejectionReasonV2Code.ClosingDateTimeRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid variable rate support (repurchase agreement).
    /// Encoded/decoded by serializers as "VASU".
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("_2fZadywwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid variable rate support (repurchase agreement).")]
    VariableRateSupportRejection = RejectionReasonV2Code.VariableRateSupportRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised, invalid or missing place of safekeeping.
    /// Encoded/decoded by serializers as "INPS".
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_2fZaeSwwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised, invalid or missing place of safekeeping.")]
    PlaceOfSafekeeping = RejectionReasonV2Code.PlaceOfSafekeeping, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Required stamp duty information is missing.
    /// Encoded/decoded by serializers as "SDUT".
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_2fZaeywwEeOEV5XHD-BKpw")]
    [Description(@"Required stamp duty information is missing.")]
    LackOfStampDuty = RejectionReasonV2Code.LackOfStampDuty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid forfeit amount.
    /// Encoded/decoded by serializers as "FORF".
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_2fZafSwwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid forfeit amount.")]
    ForfeitAmount = RejectionReasonV2Code.ForfeitAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid client of delivering or receiving party 1.
    /// Encoded/decoded by serializers as "ICUS".
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_2fZafywwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid client of delivering or receiving party 1.")]
    ReceivingDeliveringParty2 = RejectionReasonV2Code.ReceivingDeliveringParty2, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid participant of delivering or receiving depository.
    /// Encoded/decoded by serializers as "ICAG".
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_2fZagSwwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid participant of delivering or receiving depository.")]
    ReceivingDeliveringParty1 = RejectionReasonV2Code.ReceivingDeliveringParty1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid depository.
    /// Encoded/decoded by serializers as "DEPT".
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_2fZagywwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid depository.")]
    ReceivingDeliveringDepository = RejectionReasonV2Code.ReceivingDeliveringDepository, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_2fZahSwwEeOEV5XHD-BKpw")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV2Code.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid client of delivering or receiving party 2.
    /// Encoded/decoded by serializers as "IEXE".
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_2fZahywwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid client of delivering or receiving party 2.")]
    ReceivingDeliveringParty3 = RejectionReasonV2Code.ReceivingDeliveringParty3, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid investor party. May be used by an executing party to reject an instruction for an investor (or portfolio) for which it is not authorised to act.
    /// Encoded/decoded by serializers as "INVE".
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_7GaokSwwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid investor party. May be used by an executing party to reject an instruction for an investor (or portfolio) for which it is not authorised to act.")]
    InvalidInvestorParty = RejectionReasonV2Code.InvalidInvestorParty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid place of listing. Used when the security identified is not listed on the market supplied.
    /// Encoded/decoded by serializers as "PLIS".
    /// </summary>
    [EnumMember(Value = "PLIS")]
    [IsoId("_8ORogSwwEeOEV5XHD-BKpw")]
    [Description(@"Unrecognised or invalid place of listing. Used when the security identified is not listed on the market supplied.")]
    PlaceOfListing = RejectionReasonV2Code.PlaceOfListing, // same ordinal as derivation source for type conversions
    
}
