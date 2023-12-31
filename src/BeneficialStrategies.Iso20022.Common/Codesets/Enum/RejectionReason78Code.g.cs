﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason78Code.  ISO2002 ID# _5q004QaYEe2-DuDrUXkg2w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5q004QaYEe2-DuDrUXkg2w")]
[Description(@"Specifies the reason why the instruction/cancellation request has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason78Code
{
    /// <summary>
    /// Agreement start date is missing or invalid.
    /// Encoded/decoded by serializers as "AgreementStartDate".
    /// </summary>
    [EnumMember(Value = "ASTM")]
    [IsoId("_0JI4gQaZEe2u7bd67K_0bA")]
    [Description(@"Agreement start date is missing or invalid.")]
    AgreementStartDate,
    
    /// <summary>
    /// Unrecognised or invalid type of order.
    /// Encoded/decoded by serializers as "TypeOfOrderRejection".
    /// </summary>
    [EnumMember(Value = "BUSE")]
    [IsoId("_0JI4gwaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid type of order.")]
    TypeOfOrderRejection,
    
    /// <summary>
    /// Unrecognised or invalid transaction call delay.
    /// Encoded/decoded by serializers as "TransactionCallDelay".
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("_0JI4hQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid transaction call delay.")]
    TransactionCallDelay,
    
    /// <summary>
    /// Unrecognised or invalid commercialisation contract.
    /// Encoded/decoded by serializers as "CommercializationContractRejection".
    /// </summary>
    [EnumMember(Value = "COMC")]
    [IsoId("_0JI4hwaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid commercialisation contract.")]
    CommercializationContractRejection,
    
    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as "SettlementDateRejection".
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_0JI4iQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDateRejection,
    
    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as "DealPrice".
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_0JI4iwaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice,
    
    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as "SettlementAmountRejection".
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_0JI4jQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    SettlementAmountRejection,
    
    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as "QuantityRejection".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_0JI4jwaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection,
    
    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as "InvalidSecurity".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_0JI4kQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity,
    
    /// <summary>
    /// Unrecognised or invalid trade date or requested trade date or future trade date.
    /// Encoded/decoded by serializers as "TradeDate".
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_0JI4kwaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid trade date or requested trade date or future trade date.")]
    TradeDate,
    
    /// <summary>
    /// Unrecognised or invalid fee or commission.
    /// Encoded/decoded by serializers as "FeeCommissionRejection".
    /// </summary>
    [EnumMember(Value = "FEEE")]
    [IsoId("_0JI4lQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid fee or commission.")]
    FeeCommissionRejection,
    
    /// <summary>
    /// Unrecognised or invalid forfeit amount.
    /// Encoded/decoded by serializers as "ForfeitAmount".
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_0JI4lwaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid forfeit amount.")]
    ForfeitAmount,
    
    /// <summary>
    /// Unrecognised or invalid client of delivering or receiving party 2.
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty3".
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_0JI4mQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid client of delivering or receiving party 2.")]
    ReceivingDeliveringParty3,
    
    /// <summary>
    /// Unrecognised, invalid or missing common reference.
    /// Encoded/decoded by serializers as "CommonReferenceRejection".
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_0JI4mwaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised, invalid or missing common reference.")]
    CommonReferenceRejection,
    
    /// <summary>
    /// Unrecognised or invalid service level agreement pre-agreed narrative information.
    /// Encoded/decoded by serializers as "NarrativeInformationRejection".
    /// </summary>
    [EnumMember(Value = "INNA")]
    [IsoId("_0JI4nQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid service level agreement pre-agreed narrative information.")]
    NarrativeInformationRejection,
    
    /// <summary>
    /// See narrative field for reason.
    /// Encoded/decoded by serializers as "NarrativeReason".
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_0JI4nwaZEe2u7bd67K_0bA")]
    [Description(@"See narrative field for reason.")]
    NarrativeReason,
    
    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as "SettlementAmountCurrencyRejection".
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_0JI4oQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrencyRejection,
    
    /// <summary>
    /// Order entry date is missing.
    /// Encoded/decoded by serializers as "OrderDateNotProvided".
    /// </summary>
    [EnumMember(Value = "ODNP")]
    [IsoId("_0JI4owaZEe2u7bd67K_0bA")]
    [Description(@"Order entry date is missing.")]
    OrderDateNotProvided,
    
    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as "PlaceOfTrade".
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_0JI4pQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade,
    
    /// <summary>
    /// Quantity unit type is not provided.
    /// Encoded/decoded by serializers as "QuantityUnitType".
    /// </summary>
    [EnumMember(Value = "QUNP")]
    [IsoId("_0JI4pwaZEe2u7bd67K_0bA")]
    [Description(@"Quantity unit type is not provided.")]
    QuantityUnitType,
    
    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as "ReferenceRejection".
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_0JI4qQaZEe2u7bd67K_0bA")]
    [Description(@"Instruction has a reference identical to another previously received instruction.")]
    ReferenceRejection,
    
    /// <summary>
    /// Unrecognised or invalid closing closing amount.
    /// Encoded/decoded by serializers as "ClosingTransactionAmount".
    /// </summary>
    [EnumMember(Value = "CTRA")]
    [IsoId("_0JI4qwaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid closing closing amount.")]
    ClosingTransactionAmount,
    
    /// <summary>
    /// Unrecognised or invalid repurchase rate.
    /// Encoded/decoded by serializers as "RepurchaseRate".
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_0JI4rQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid repurchase rate.")]
    RepurchaseRate,
    
    /// <summary>
    /// Unrecognised or invalid premium amount.
    /// Encoded/decoded by serializers as "PremiumAmount".
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("_0JI4rwaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid premium amount.")]
    PremiumAmount,
    
    /// <summary>
    /// Unrecognised or invalid repurchase rate type.
    /// Encoded/decoded by serializers as "RepurchaseRateType".
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("_0JI4sQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid repurchase rate type.")]
    RepurchaseRateType,
    
    /// <summary>
    /// Unrecognised or invalid spread rate.
    /// Encoded/decoded by serializers as "SpreadRate".
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("_0JI4swaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid spread rate.")]
    SpreadRate,
    
    /// <summary>
    /// Unrecognised or invalid message sender's safekeeping account.
    /// Encoded/decoded by serializers as "SafekeepingAccountRejection".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_0JI4tQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection,
    
    /// <summary>
    /// Unrecognised or invalid settlement transaction type.
    /// Encoded/decoded by serializers as "SettlementTransactionRejection".
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_0JI4twaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid settlement transaction type.")]
    SettlementTransactionRejection,
    
    /// <summary>
    /// Unrecognised or invalid settlement system/method instructed.
    /// Encoded/decoded by serializers as "SettlementSystemMethodRejection".
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_0JI4uQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid settlement system/method instructed.")]
    SettlementSystemMethodRejection,
    
    /// <summary>
    /// Unrecognised or invalid closing date/time.
    /// Encoded/decoded by serializers as "ClosingDateTimeRejection".
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_0JI4uwaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid closing date/time.")]
    ClosingDateTimeRejection,
    
    /// <summary>
    /// A message with the same Transaction Notice Reference, Market Member, and Intermediary has already been processed.
    /// Encoded/decoded by serializers as "TransactionNoticeAlreadyAcceptedOrRejected".
    /// </summary>
    [EnumMember(Value = "TNAR")]
    [IsoId("_0JI4vQaZEe2u7bd67K_0bA")]
    [Description(@"A message with the same Transaction Notice Reference, Market Member, and Intermediary has already been processed.")]
    TransactionNoticeAlreadyAcceptedOrRejected,
    
    /// <summary>
    /// The combination of the Transaction Notice Reference, Market Member, and Intermediary is unknown.
    /// Encoded/decoded by serializers as "TransactionNoticeIDUnknown".
    /// </summary>
    [EnumMember(Value = "TNIU")]
    [IsoId("_0JI4vwaZEe2u7bd67K_0bA")]
    [Description(@"The combination of the Transaction Notice Reference, Market Member, and Intermediary is unknown.")]
    TransactionNoticeIDUnknown,
    
    /// <summary>
    /// Market member executed the order exceeding the requested quantity.
    /// Encoded/decoded by serializers as "TradedQuantityHigherThanOriginalOrderQuantity".
    /// </summary>
    [EnumMember(Value = "TQHI")]
    [IsoId("_0JI4wQaZEe2u7bd67K_0bA")]
    [Description(@"Market member executed the order exceeding the requested quantity.")]
    TradedQuantityHigherThanOriginalOrderQuantity,
    
    /// <summary>
    /// Traded securities quantity not provided.
    /// Encoded/decoded by serializers as "TradedSecuritiesQuantity".
    /// </summary>
    [EnumMember(Value = "TQNP")]
    [IsoId("_0JI4wwaZEe2u7bd67K_0bA")]
    [Description(@"Traded securities quantity not provided.")]
    TradedSecuritiesQuantity,
    
    /// <summary>
    /// Unrecognised or invalid tax status of the securities instructed.
    /// Encoded/decoded by serializers as "TaxStatusRejection".
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_0JI4xQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid tax status of the securities instructed.")]
    TaxStatusRejection,
    
    /// <summary>
    /// Linked reference is unknown.
    /// Encoded/decoded by serializers as "InvalidReference".
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_0JI4xwaZEe2u7bd67K_0bA")]
    [Description(@"Linked reference is unknown.")]
    InvalidReference,
    
    /// <summary>
    /// Unrecognised or invalid variable rate support (repurchase agreement).
    /// Encoded/decoded by serializers as "VariableRateSupportRejection".
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("_0JI4yQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid variable rate support (repurchase agreement).")]
    VariableRateSupportRejection,
    
    /// <summary>
    /// Instruction is irrevocable.
    /// Encoded/decoded by serializers as "InstructionIrrevocable".
    /// </summary>
    [EnumMember(Value = "INIR")]
    [IsoId("_0JI4ywaZEe2u7bd67K_0bA")]
    [Description(@"Instruction is irrevocable.")]
    InstructionIrrevocable,
    
    /// <summary>
    /// Unrecognised option number.
    /// Encoded/decoded by serializers as "OptionNumberRejection".
    /// </summary>
    [EnumMember(Value = "OPNM")]
    [IsoId("_0JI4zQaZEe2u7bd67K_0bA")]
    [Description(@"Unrecognised option number.")]
    OptionNumberRejection,
    
    /// <summary>
    /// Invalid option type.
    /// Encoded/decoded by serializers as "InvalidOptionType".
    /// </summary>
    [EnumMember(Value = "OPTY")]
    [IsoId("_0JI4zwaZEe2u7bd67K_0bA")]
    [Description(@"Invalid option type.")]
    InvalidOptionType,
    
    /// <summary>
    /// Financial instrument's symbol has not been recognized.
    /// Encoded/decoded by serializers as "UnknownSymbol".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_0JI40QaZEe2u7bd67K_0bA")]
    [Description(@"Financial instrument's symbol has not been recognized.")]
    UnknownSymbol,
    
    /// <summary>
    /// Countervalue of the order exceeds the allowed trading limit or quote exceeds limit.
    /// Encoded/decoded by serializers as "ExceedsLimit".
    /// </summary>
    [EnumMember(Value = "EXLI")]
    [IsoId("_0JI40waZEe2u7bd67K_0bA")]
    [Description(@"Countervalue of the order exceeds the allowed trading limit or quote exceeds limit.")]
    ExceedsLimit,
    
    /// <summary>
    /// Price does not comply with the financial instrument's characteristics.
    /// Encoded/decoded by serializers as "InvalidPrice".
    /// </summary>
    [EnumMember(Value = "INPR")]
    [IsoId("_0JI41QaZEe2u7bd67K_0bA")]
    [Description(@"Price does not comply with the financial instrument's characteristics.")]
    InvalidPrice,
    
    /// <summary>
    /// Price in the execution exceeds the order price.
    /// Encoded/decoded by serializers as "PriceExceeds".
    /// </summary>
    [EnumMember(Value = "PRIC")]
    [IsoId("_0JI41waZEe2u7bd67K_0bA")]
    [Description(@"Price in the execution exceeds the order price.")]
    PriceExceeds,
    
    /// <summary>
    /// Quantity in the execution exceeds the ordered quantity.
    /// Encoded/decoded by serializers as "QuantityExceeds".
    /// </summary>
    [EnumMember(Value = "EQTY")]
    [IsoId("_0JI42QaZEe2u7bd67K_0bA")]
    [Description(@"Quantity in the execution exceeds the ordered quantity.")]
    QuantityExceeds,
    
    /// <summary>
    /// Order is for the wrong side.
    /// Encoded/decoded by serializers as "WrongSide".
    /// </summary>
    [EnumMember(Value = "SIDE")]
    [IsoId("_0JI42waZEe2u7bd67K_0bA")]
    [Description(@"Order is for the wrong side.")]
    WrongSide,
    
    /// <summary>
    /// Primarily used when the Notice of Execution received by the buy-side contains fees, gross trade amount, net trade amount, etc., values that differ from the buy-side's calculations. Buy-side may reject the trade if they feel that the difference in calculations is too high.
    /// Encoded/decoded by serializers as "CalculationDifference".
    /// </summary>
    [EnumMember(Value = "CADI")]
    [IsoId("_0JI43QaZEe2u7bd67K_0bA")]
    [Description(@"Primarily used when the Notice of Execution received by the buy-side contains fees, gross trade amount, net trade amount, etc., values that differ from the buy-side's calculations. Buy-side may reject the trade if they feel that the difference in calculations is too high.")]
    CalculationDifference,
    
    /// <summary>
    /// Deal or exposure is unknown.
    /// Encoded/decoded by serializers as "UnknownDealExposure".
    /// </summary>
    [EnumMember(Value = "CPTY")]
    [IsoId("_0JI43waZEe2u7bd67K_0bA")]
    [Description(@"Deal or exposure is unknown.")]
    UnknownDealExposure,
    
    /// <summary>
    /// Party does not agree with the call amount.
    /// Encoded/decoded by serializers as "DisagreeWithCallAmount".
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_0JI44QaZEe2u7bd67K_0bA")]
    [Description(@"Party does not agree with the call amount.")]
    DisagreeWithCallAmount,
    
    /// <summary>
    /// Party does not agree with the exposure amount.
    /// Encoded/decoded by serializers as "DisagreeWithExposureAmount".
    /// </summary>
    [EnumMember(Value = "DISE")]
    [IsoId("_0JI44waZEe2u7bd67K_0bA")]
    [Description(@"Party does not agree with the exposure amount.")]
    DisagreeWithExposureAmount,
    
    /// <summary>
    /// Resulting amount must be filled in as exchange rate is present.
    /// Encoded/decoded by serializers as "MissingResultingAmount".
    /// </summary>
    [EnumMember(Value = "RESU")]
    [IsoId("_0JI45QaZEe2u7bd67K_0bA")]
    [Description(@"Resulting amount must be filled in as exchange rate is present.")]
    MissingResultingAmount,
    
    /// <summary>
    /// Resulting amount is not allowed without an exchange rate.
    /// Encoded/decoded by serializers as "MissingExchangeRate".
    /// </summary>
    [EnumMember(Value = "XRAT")]
    [IsoId("_0JI45waZEe2u7bd67K_0bA")]
    [Description(@"Resulting amount is not allowed without an exchange rate.")]
    MissingExchangeRate,
    
    /// <summary>
    /// Accrued interest is not applicable for this type of security.
    /// Encoded/decoded by serializers as "UnexpectedAccruedInterest".
    /// </summary>
    [EnumMember(Value = "ACRU")]
    [IsoId("_0JI46QaZEe2u7bd67K_0bA")]
    [Description(@"Accrued interest is not applicable for this type of security.")]
    UnexpectedAccruedInterest,
    
    /// <summary>
    /// Gross amount is less than net amount.
    /// Encoded/decoded by serializers as "GrossAmountLessThanNetAmount".
    /// </summary>
    [EnumMember(Value = "GAMN")]
    [IsoId("_0JI46waZEe2u7bd67K_0bA")]
    [Description(@"Gross amount is less than net amount.")]
    GrossAmountLessThanNetAmount,
    
    /// <summary>
    /// One option must be marked as the default.
    /// Encoded/decoded by serializers as "MissingDefaultOption".
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_0JI47QaZEe2u7bd67K_0bA")]
    [Description(@"One option must be marked as the default.")]
    MissingDefaultOption,
    
    /// <summary>
    /// Validation of the advice/instruction/request failed.
    /// Encoded/decoded by serializers as "FailedValidation".
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_0JI47waZEe2u7bd67K_0bA")]
    [Description(@"Validation of the advice/instruction/request failed.")]
    FailedValidation,
    
    /// <summary>
    /// Message details specified in the instruction/request are inconsistent with those that were specified in the relating original message.
    /// Encoded/decoded by serializers as "InvalidDetails".
    /// </summary>
    [EnumMember(Value = "INDT")]
    [IsoId("_0JI48QaZEe2u7bd67K_0bA")]
    [Description(@"Message details specified in the instruction/request are inconsistent with those that were specified in the relating original message.")]
    InvalidDetails,
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_0JI48waZEe2u7bd67K_0bA")]
    [Description(@"Other. See Narrative.")]
    Other,
    
    /// <summary>
    /// Unrecognised or invalid depository.
    /// Encoded/decoded by serializers as "ReceivingDeliveringDepository".
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_kuiDUQanEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid depository.")]
    ReceivingDeliveringDepository,
    
    /// <summary>
    /// Unrecognised or invalid client of delivering or receiving party 1.
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty2".
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_RtJAkQaoEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid client of delivering or receiving party 1.")]
    ReceivingDeliveringParty2,
    
    /// <summary>
    /// Unrecognised or invalid participant of delivering or receiving depository.
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty1".
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_aAjBMQaoEe2u7bd67K_0bA")]
    [Description(@"Unrecognised or invalid participant of delivering or receiving depository.")]
    ReceivingDeliveringParty1,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason78CodeMetadataExtensions
{
    private static readonly RejectionReason78CodeDropdownSource _dropdownSource = new RejectionReason78CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason78CodeDropdownRow GetMetadata(this RejectionReason78Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


