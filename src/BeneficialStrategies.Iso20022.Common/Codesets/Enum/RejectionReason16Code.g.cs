﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason16Code.  ISO2002 ID# _ZhMndNp-Ed-ak6NoX_4Aeg_-1511478406.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZhMndNp-Ed-ak6NoX_4Aeg_-1511478406")]
[Description(@"Specifies the reason why the instruction/cancellation request has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV2Code))]
public enum RejectionReason16Code
{
    /// <summary>
    /// Linked reference is unknown.
    /// Encoded/decoded by serializers as "InvalidReference".
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_ZhMnddp-Ed-ak6NoX_4Aeg_133789029")]
    [Description(@"Linked reference is unknown.")]
    InvalidReference,
    
    /// <summary>
    /// Unrecognised or invalid message sender's safekeeping account.
    /// Encoded/decoded by serializers as "SafekeepingAccountRejection".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_ZhMndtp-Ed-ak6NoX_4Aeg_1786416537")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection,
    
    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as "QuantityRejection".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_ZhMnd9p-Ed-ak6NoX_4Aeg_1494458799")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection,
    
    /// <summary>
    /// Transaction/instruction received after the account servicer's specified deadline.
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_ZhMneNp-Ed-ak6NoX_4Aeg_1672577471")]
    [Description(@"Transaction/instruction received after the account servicer's specified deadline.")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// Not possible to use the RTGS system instructed (NRTG or YRTG).
    /// Encoded/decoded by serializers as "ImpossibleToUseTheRTGSSystemInstructed".
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_ZhMnedp-Ed-ak6NoX_4Aeg_-863283324")]
    [Description(@"Not possible to use the RTGS system instructed (NRTG or YRTG).")]
    ImpossibleToUseTheRTGSSystemInstructed,
    
    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as "SettlementAmountCurrencyRejection".
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_ZhVxYNp-Ed-ak6NoX_4Aeg_789344184")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrencyRejection,
    
    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as "InvalidSecurity".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_ZhVxYdp-Ed-ak6NoX_4Aeg_-1860355677")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity,
    
    /// <summary>
    /// Address details are incorrect or cannot be recognised.
    /// Encoded/decoded by serializers as "AddressDetailsRejection".
    /// </summary>
    [EnumMember(Value = "DADR")]
    [IsoId("_ZhVxYtp-Ed-ak6NoX_4Aeg_-207728169")]
    [Description(@"Address details are incorrect or cannot be recognised.")]
    AddressDetailsRejection,
    
    /// <summary>
    /// Instruction is irrevocable.
    /// Encoded/decoded by serializers as "InstructionIrrevocable".
    /// </summary>
    [EnumMember(Value = "INIR")]
    [IsoId("_ZhVxY9p-Ed-ak6NoX_4Aeg_-499685907")]
    [Description(@"Instruction is irrevocable.")]
    InstructionIrrevocable,
    
    /// <summary>
    /// Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required.
    /// Encoded/decoded by serializers as "OptionCancelled".
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_ZhVxZNp-Ed-ak6NoX_4Aeg_-321567235")]
    [Description(@"Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required.")]
    OptionCancelled,
    
    /// <summary>
    /// Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option.
    /// Encoded/decoded by serializers as "OptionInactive".
    /// </summary>
    [EnumMember(Value = "INTV")]
    [IsoId("_ZhVxZdp-Ed-ak6NoX_4Aeg_1437539266")]
    [Description(@"Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option.")]
    OptionInactive,
    
    /// <summary>
    /// For tax reclaim, the reclaim is invalid for the tax authorities.
    /// Encoded/decoded by serializers as "InvalidForTaxAuthorities".
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_ZhfiYNp-Ed-ak6NoX_4Aeg_-1496758260")]
    [Description(@"For tax reclaim, the reclaim is invalid for the tax authorities.")]
    InvalidForTaxAuthorities,
    
    /// <summary>
    /// Reclaim is refused by the tax authorities.
    /// Encoded/decoded by serializers as "RefusedByTaxAuthorities".
    /// </summary>
    [EnumMember(Value = "REFT")]
    [IsoId("_ZhfiYdp-Ed-ak6NoX_4Aeg_440466913")]
    [Description(@"Reclaim is refused by the tax authorities.")]
    RefusedByTaxAuthorities,
    
    /// <summary>
    /// Physical settlement is impossible for the instructed financial instrument.
    /// Encoded/decoded by serializers as "PhysicalSettlementImpossible".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_ZhfiYtp-Ed-ak6NoX_4Aeg_2093094421")]
    [Description(@"Physical settlement is impossible for the instructed financial instrument.")]
    PhysicalSettlementImpossible,
    
    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as "ReferenceRejection".
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_ZhfiY9p-Ed-ak6NoX_4Aeg_1801136683")]
    [Description(@"Instruction has a reference identical to another previously received instruction.")]
    ReferenceRejection,
    
    /// <summary>
    /// Instructed position exceeds the eligible balance.
    /// Encoded/decoded by serializers as "LackofSecurities".
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_ZhfiZNp-Ed-ak6NoX_4Aeg_1979255355")]
    [Description(@"Instructed position exceeds the eligible balance.")]
    LackofSecurities,
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_ZhfiZdp-Ed-ak6NoX_4Aeg_-556605440")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// Mismatch between option number and option type.
    /// Encoded/decoded by serializers as "Mismatch".
    /// </summary>
    [EnumMember(Value = "NMTY")]
    [IsoId("_ZhfiZtp-Ed-ak6NoX_4Aeg_1173060769")]
    [Description(@"Mismatch between option number and option type.")]
    Mismatch,
    
    /// <summary>
    /// Unrecognised option number.
    /// Encoded/decoded by serializers as "OptionNumberRejection".
    /// </summary>
    [EnumMember(Value = "OPNM")]
    [IsoId("_ZhfiZ9p-Ed-ak6NoX_4Aeg_881103031")]
    [Description(@"Unrecognised option number.")]
    OptionNumberRejection,
    
    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as "SettlementAmountRejection".
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_ZhfiaNp-Ed-ak6NoX_4Aeg_1059221703")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    SettlementAmountRejection,
    
    /// <summary>
    /// Invalid option type.
    /// Encoded/decoded by serializers as "InvalidOptionType".
    /// </summary>
    [EnumMember(Value = "OPTY")]
    [IsoId("_Zhfiadp-Ed-ak6NoX_4Aeg_-1476639092")]
    [Description(@"Invalid option type.")]
    InvalidOptionType,
    
    /// <summary>
    /// Cancellation request was rejected since the instruction has already been cancelled.
    /// Encoded/decoded by serializers as "RejectedSinceAlreadyCancelled".
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("_ZhpTYNp-Ed-ak6NoX_4Aeg_-1435916625")]
    [Description(@"Cancellation request was rejected since the instruction has already been cancelled.")]
    RejectedSinceAlreadyCancelled,
    
    /// <summary>
    /// Cancellation request has been rejected because the instruction process is in progress or has been processed.
    /// Encoded/decoded by serializers as "RejectedSinceInProgress".
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_ZhpTYdp-Ed-ak6NoX_4Aeg_-1727874363")]
    [Description(@"Cancellation request has been rejected because the instruction process is in progress or has been processed.")]
    RejectedSinceInProgress,
    
    /// <summary>
    /// Unrecognised event number.
    /// Encoded/decoded by serializers as "UnrecognisedIdentification".
    /// </summary>
    [EnumMember(Value = "EVNM")]
    [IsoId("_ZhpTYtp-Ed-ak6NoX_4Aeg_-1549755691")]
    [Description(@"Unrecognised event number.")]
    UnrecognisedIdentification,
    
    /// <summary>
    /// Missing statutes or commercial register or other legal documents.
    /// Encoded/decoded by serializers as "MissingStatutes".
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_ZhpTY9p-Ed-ak6NoX_4Aeg_209350810")]
    [Description(@"Missing statutes or commercial register or other legal documents.")]
    MissingStatutes,
    
    /// <summary>
    /// Financial instrument has not been stamped and/or duly signed.
    /// Encoded/decoded by serializers as "NotStampedOrSigned".
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_ZhpTZNp-Ed-ak6NoX_4Aeg_1861978318")]
    [Description(@"Financial instrument has not been stamped and/or duly signed.")]
    NotStampedOrSigned,
    
    /// <summary>
    /// Registration request does not have a valid signature of the owner of the financial instrument.
    /// Encoded/decoded by serializers as "InvalidSignature".
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_ZhpTZdp-Ed-ak6NoX_4Aeg_1570020580")]
    [Description(@"Registration request does not have a valid signature of the owner of the financial instrument.")]
    InvalidSignature,
    
    /// <summary>
    /// Unrecognised or invalid shareholder number.
    /// Encoded/decoded by serializers as "ShareholderNumberRejection".
    /// </summary>
    [EnumMember(Value = "SHAR")]
    [IsoId("_ZhpTZtp-Ed-ak6NoX_4Aeg_1748139252")]
    [Description(@"Unrecognised or invalid shareholder number.")]
    ShareholderNumberRejection,
    
    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as "MinimumSettlementQuantity".
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_ZhpTZ9p-Ed-ak6NoX_4Aeg_-787721543")]
    [Description(@"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.")]
    MinimumSettlementQuantity,
    
    /// <summary>
    /// More than one instruction match the criteria.
    /// Encoded/decoded by serializers as "NoMatch".
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("_ZhpTaNp-Ed-ak6NoX_4Aeg_864905965")]
    [Description(@"More than one instruction match the criteria.")]
    NoMatch,
    
    /// <summary>
    /// Missing legal power for transfer.
    /// Encoded/decoded by serializers as "MissingLegalPower".
    /// </summary>
    [EnumMember(Value = "MLEG")]
    [IsoId("_ZhpTadp-Ed-ak6NoX_4Aeg_572948227")]
    [Description(@"Missing legal power for transfer.")]
    MissingLegalPower,
    
    /// <summary>
    /// Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.
    /// Encoded/decoded by serializers as "ProcessingBatchRejection".
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_ZhpTatp-Ed-ak6NoX_4Aeg_751066899")]
    [Description(@"Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.")]
    ProcessingBatchRejection,
    
    /// <summary>
    /// Unrecognised or invalid transaction call delay.
    /// Encoded/decoded by serializers as "TransactionCallDelay".
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("_ZhydUNp-Ed-ak6NoX_4Aeg_-1784793896")]
    [Description(@"Unrecognised or invalid transaction call delay.")]
    TransactionCallDelay,
    
    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as "CashAccount".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_ZhydUdp-Ed-ak6NoX_4Aeg_-132166388")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount,
    
    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as "DealPrice".
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_ZhydUtp-Ed-ak6NoX_4Aeg_-424124126")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice,
    
    /// <summary>
    /// Type of ownership indicated is not correct.
    /// Encoded/decoded by serializers as "TypeOfOwnershipRejection".
    /// </summary>
    [EnumMember(Value = "OWNT")]
    [IsoId("_ZhydU9p-Ed-ak6NoX_4Aeg_1513101047")]
    [Description(@"Type of ownership indicated is not correct.")]
    TypeOfOwnershipRejection,
    
    /// <summary>
    /// Instruction could not be found.
    /// Encoded/decoded by serializers as "NotFoundRejection".
    /// </summary>
    [EnumMember(Value = "NRGN")]
    [IsoId("_ZhydVNp-Ed-ak6NoX_4Aeg_-1129238741")]
    [Description(@"Instruction could not be found.")]
    NotFoundRejection,
    
    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as "MultipleSettlementQuantity".
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_ZhydVdp-Ed-ak6NoX_4Aeg_-1421196479")]
    [Description(@"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.")]
    MultipleSettlementQuantity,
    
    /// <summary>
    /// Registration request to be completed by the buyer and to be forwarded to the issuer is wrong. You have used the registration request of a different issuer/registrar.
    /// Encoded/decoded by serializers as "WrongRegistrationRequest".
    /// </summary>
    [EnumMember(Value = "REQW")]
    [IsoId("_ZhydVtp-Ed-ak6NoX_4Aeg_-1243077807")]
    [Description(@"Registration request to be completed by the buyer and to be forwarded to the issuer is wrong. You have used the registration request of a different issuer/registrar.")]
    WrongRegistrationRequest,
    
    /// <summary>
    /// Unrecognised or invalid tax status of the securities instructed.
    /// Encoded/decoded by serializers as "TaxStatusRejection".
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_ZhydV9p-Ed-ak6NoX_4Aeg_516028694")]
    [Description(@"Unrecognised or invalid tax status of the securities instructed.")]
    TaxStatusRejection,
    
    /// <summary>
    /// Unrecognised or invalid termination transaction amount.
    /// Encoded/decoded by serializers as "TerminationTransactionAmount".
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("_ZhydWNp-Ed-ak6NoX_4Aeg_-2126311094")]
    [Description(@"Unrecognised or invalid termination transaction amount.")]
    TerminationTransactionAmount,
    
    /// <summary>
    /// Unrecognised or invalid repurchase rate.
    /// Encoded/decoded by serializers as "RepurchaseRate".
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_ZhydWdp-Ed-ak6NoX_4Aeg_1876698464")]
    [Description(@"Unrecognised or invalid repurchase rate.")]
    RepurchaseRate,
    
    /// <summary>
    /// Unrecognised or invalid premium amount.
    /// Encoded/decoded by serializers as "PremiumAmount".
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("_Zh8OUNp-Ed-ak6NoX_4Aeg_2054817136")]
    [Description(@"Unrecognised or invalid premium amount.")]
    PremiumAmount,
    
    /// <summary>
    /// Registration reason indicated is not correct.
    /// Encoded/decoded by serializers as "DisagreementInRegistrationReason".
    /// </summary>
    [EnumMember(Value = "RREA")]
    [IsoId("_Zh8OUdp-Ed-ak6NoX_4Aeg_-481043659")]
    [Description(@"Registration reason indicated is not correct.")]
    DisagreementInRegistrationReason,
    
    /// <summary>
    /// Registration request to be completed by the buyer and to be forwarded to the issuer is missing.
    /// Encoded/decoded by serializers as "MissingRegistrationRequest".
    /// </summary>
    [EnumMember(Value = "REQM")]
    [IsoId("_Zh8OUtp-Ed-ak6NoX_4Aeg_1171583849")]
    [Description(@"Registration request to be completed by the buyer and to be forwarded to the issuer is missing.")]
    MissingRegistrationRequest,
    
    /// <summary>
    /// Unrecognised or invalid repurchase rate type.
    /// Encoded/decoded by serializers as "RepurchaseRateType".
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("_Zh8OU9p-Ed-ak6NoX_4Aeg_879626111")]
    [Description(@"Unrecognised or invalid repurchase rate type.")]
    RepurchaseRateType,
    
    /// <summary>
    /// Unrecognised or invalid spread rate.
    /// Encoded/decoded by serializers as "SpreadRate".
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("_Zh8OVNp-Ed-ak6NoX_4Aeg_1057744783")]
    [Description(@"Unrecognised or invalid spread rate.")]
    SpreadRate,
    
    /// <summary>
    /// Unrecognised or invalid settlement system/method instructed.
    /// Encoded/decoded by serializers as "SettlementSystemMethodRejection".
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_Zh8OVdp-Ed-ak6NoX_4Aeg_-1478116012")]
    [Description(@"Unrecognised or invalid settlement system/method instructed.")]
    SettlementSystemMethodRejection,
    
    /// <summary>
    /// Unrecognised or invalid trade date or requested trade date or future trade date.
    /// Encoded/decoded by serializers as "TradeDate".
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_Zh8OVtp-Ed-ak6NoX_4Aeg_174511496")]
    [Description(@"Unrecognised or invalid trade date or requested trade date or future trade date.")]
    TradeDate,
    
    /// <summary>
    /// Unrecognised, invalid or missing common reference.
    /// Encoded/decoded by serializers as "CommonReferenceRejection".
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_Zh8OV9p-Ed-ak6NoX_4Aeg_-117446242")]
    [Description(@"Unrecognised, invalid or missing common reference.")]
    CommonReferenceRejection,
    
    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as "PlaceOfTrade".
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_Zh8OWNp-Ed-ak6NoX_4Aeg_1819778931")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade,
    
    /// <summary>
    /// Unrecognised or invalid service level agreement pre-agreed narrative information.
    /// Encoded/decoded by serializers as "NarrativeInformationRejection".
    /// </summary>
    [EnumMember(Value = "INNA")]
    [IsoId("_Zh8OWdp-Ed-ak6NoX_4Aeg_-822560857")]
    [Description(@"Unrecognised or invalid service level agreement pre-agreed narrative information.")]
    NarrativeInformationRejection,
    
    /// <summary>
    /// Insufficient collateral proposed.
    /// Encoded/decoded by serializers as "InsufficientCollateral".
    /// </summary>
    [EnumMember(Value = "ICOL")]
    [IsoId("_Zh8OWtp-Ed-ak6NoX_4Aeg_-936399923")]
    [Description(@"Insufficient collateral proposed.")]
    InsufficientCollateral,
    
    /// <summary>
    /// Unrecognised or invalid business partner number.
    /// Encoded/decoded by serializers as "BusinessPartnerNumberRejection".
    /// </summary>
    [EnumMember(Value = "BPAR")]
    [IsoId("_ZiFYQNp-Ed-ak6NoX_4Aeg_822706578")]
    [Description(@"Unrecognised or invalid business partner number.")]
    BusinessPartnerNumberRejection,
    
    /// <summary>
    /// Unrecognised or invalid bank reference number.
    /// Encoded/decoded by serializers as "BankReferenceNumberRejection".
    /// </summary>
    [EnumMember(Value = "BREF")]
    [IsoId("_ZiFYQdp-Ed-ak6NoX_4Aeg_-1819633210")]
    [Description(@"Unrecognised or invalid bank reference number.")]
    BankReferenceNumberRejection,
    
    /// <summary>
    /// Unrecognised or invalid type of order.
    /// Encoded/decoded by serializers as "TypeOfOrderRejection".
    /// </summary>
    [EnumMember(Value = "BUSE")]
    [IsoId("_ZiFYQtp-Ed-ak6NoX_4Aeg_-2111590948")]
    [Description(@"Unrecognised or invalid type of order.")]
    TypeOfOrderRejection,
    
    /// <summary>
    /// Corporate action pending on the financial instrument instructed.
    /// Encoded/decoded by serializers as "CorporateActionRejection".
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("_ZiFYQ9p-Ed-ak6NoX_4Aeg_-1933472276")]
    [Description(@"Corporate action pending on the financial instrument instructed.")]
    CorporateActionRejection,
    
    /// <summary>
    /// Impossible standing arrangements override instruction for the cash settlement system.
    /// Encoded/decoded by serializers as "ImpossibleCashSettlementSystem".
    /// </summary>
    [EnumMember(Value = "CASY")]
    [IsoId("_ZiFYRNp-Ed-ak6NoX_4Aeg_-174365775")]
    [Description(@"Impossible standing arrangements override instruction for the cash settlement system.")]
    ImpossibleCashSettlementSystem,
    
    /// <summary>
    /// Unrecognised or invalid commercialisation contract.
    /// Encoded/decoded by serializers as "CommercializationContractRejection".
    /// </summary>
    [EnumMember(Value = "COMC")]
    [IsoId("_ZiFYRdp-Ed-ak6NoX_4Aeg_1478261733")]
    [Description(@"Unrecognised or invalid commercialisation contract.")]
    CommercializationContractRejection,
    
    /// <summary>
    /// Concentration limit was exceeded.
    /// Encoded/decoded by serializers as "ConcentrationLimitExceeded".
    /// </summary>
    [EnumMember(Value = "CONL")]
    [IsoId("_ZiFYRtp-Ed-ak6NoX_4Aeg_1186303995")]
    [Description(@"Concentration limit was exceeded.")]
    ConcentrationLimitExceeded,
    
    /// <summary>
    /// Deal or exposure is unknown.
    /// Encoded/decoded by serializers as "UnknownDealExposure".
    /// </summary>
    [EnumMember(Value = "CPTY")]
    [IsoId("_ZiFYR9p-Ed-ak6NoX_4Aeg_1364422667")]
    [Description(@"Deal or exposure is unknown.")]
    UnknownDealExposure,
    
    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as "SettlementDateRejection".
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_ZiFYSNp-Ed-ak6NoX_4Aeg_-1171438128")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDateRejection,
    
    /// <summary>
    /// Party does not agree with the call amount.
    /// Encoded/decoded by serializers as "DisagreeWithCallAmount".
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_ZiFYSdp-Ed-ak6NoX_4Aeg_189231642")]
    [Description(@"Party does not agree with the call amount.")]
    DisagreeWithCallAmount,
    
    /// <summary>
    /// Party does not agree with the exposure amount.
    /// Encoded/decoded by serializers as "DisagreeWithExposureAmount".
    /// </summary>
    [EnumMember(Value = "DISE")]
    [IsoId("_ZiPJQNp-Ed-ak6NoX_4Aeg_367350314")]
    [Description(@"Party does not agree with the exposure amount.")]
    DisagreeWithExposureAmount,
    
    /// <summary>
    /// Disagreement between the data on the registration request and the order.
    /// Encoded/decoded by serializers as "RegistrationRequestDataAndOrderRejection".
    /// </summary>
    [EnumMember(Value = "DORD")]
    [IsoId("_ZiPJQdp-Ed-ak6NoX_4Aeg_2126456815")]
    [Description(@"Disagreement between the data on the registration request and the order.")]
    RegistrationRequestDataAndOrderRejection,
    
    /// <summary>
    /// Unrecognised or invalid fee or commission.
    /// Encoded/decoded by serializers as "FeeCommissionRejection".
    /// </summary>
    [EnumMember(Value = "FEEE")]
    [IsoId("_ZiPJQtp-Ed-ak6NoX_4Aeg_-515882973")]
    [Description(@"Unrecognised or invalid fee or commission.")]
    FeeCommissionRejection,
    
    /// <summary>
    /// Unrecognised or invalid settlement transaction type.
    /// Encoded/decoded by serializers as "SettlementTransactionRejection".
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_ZiPJQ9p-Ed-ak6NoX_4Aeg_-629722039")]
    [Description(@"Unrecognised or invalid settlement transaction type.")]
    SettlementTransactionRejection,
    
    /// <summary>
    /// Unrecognised or invalid closing date/time.
    /// Encoded/decoded by serializers as "ClosingDateTimeRejection".
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_ZiPJRNp-Ed-ak6NoX_4Aeg_1129384462")]
    [Description(@"Unrecognised or invalid closing date/time.")]
    ClosingDateTimeRejection,
    
    /// <summary>
    /// Unrecognised or invalid variable rate support (repurchase agreement).
    /// Encoded/decoded by serializers as "VariableRateSupportRejection".
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("_ZiPJRdp-Ed-ak6NoX_4Aeg_-1512955326")]
    [Description(@"Unrecognised or invalid variable rate support (repurchase agreement).")]
    VariableRateSupportRejection,
    
    /// <summary>
    /// Unrecognised, invalid or missing place of safekeeping.
    /// Encoded/decoded by serializers as "PlaceOfSafekeeping".
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_ZiPJRtp-Ed-ak6NoX_4Aeg_2046998221")]
    [Description(@"Unrecognised, invalid or missing place of safekeeping.")]
    PlaceOfSafekeeping,
    
    /// <summary>
    /// Required stamp duty information is missing.
    /// Encoded/decoded by serializers as "LackOfStampDuty".
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_ZiPJR9p-Ed-ak6NoX_4Aeg_1299808841")]
    [Description(@"Required stamp duty information is missing.")]
    LackOfStampDuty,
    
    /// <summary>
    /// Unrecognised or invalid forfeit amount.
    /// Encoded/decoded by serializers as "ForfeitAmount".
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_ZiPJSNp-Ed-ak6NoX_4Aeg_306486824")]
    [Description(@"Unrecognised or invalid forfeit amount.")]
    ForfeitAmount,
    
    /// <summary>
    /// Unrecognised or invalid client of delivering or receiving party 1.
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty2".
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_ZiPJSdp-Ed-ak6NoX_4Aeg_617520497")]
    [Description(@"Unrecognised or invalid client of delivering or receiving party 1.")]
    ReceivingDeliveringParty2,
    
    /// <summary>
    /// Unrecognised or invalid participant of delivering or receiving depository.
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty1".
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_ZiY6QNp-Ed-ak6NoX_4Aeg_-336051919")]
    [Description(@"Unrecognised or invalid participant of delivering or receiving depository.")]
    ReceivingDeliveringParty1,
    
    /// <summary>
    /// Unrecognised or invalid depository.
    /// Encoded/decoded by serializers as "ReceivingDeliveringDepository".
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_ZiY6Qdp-Ed-ak6NoX_4Aeg_-449890985")]
    [Description(@"Unrecognised or invalid depository.")]
    ReceivingDeliveringDepository,
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZiY6Qtp-Ed-ak6NoX_4Aeg_-1725833639")]
    [Description(@"Other. See Narrative.")]
    Other,
    
    /// <summary>
    /// Unrecognised or invalid client of delivering or receiving party 2.
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty3".
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_ZiY6Q9p-Ed-ak6NoX_4Aeg_-1400716132")]
    [Description(@"Unrecognised or invalid client of delivering or receiving party 2.")]
    ReceivingDeliveringParty3,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason16CodeMetadataExtensions
{
    private static readonly RejectionReason16CodeDropdownSource _dropdownSource = new RejectionReason16CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason16CodeDropdownRow GetMetadata(this RejectionReason16Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


