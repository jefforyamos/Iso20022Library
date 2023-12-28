﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for HoldingRejectionReason41Code.  ISO2002 ID# _0vNGYL3REeO2FLWuu_JIqg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the report item is rejected.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0vNGYL3REeO2FLWuu_JIqg")]
[Description(@"Specifies the reason the report item is rejected.")]
[DerivedFrom(typeof(RejectionReasonV2Code))]
public enum HoldingRejectionReason41Code
{
    /// <summary>
    /// Price does not comply with the financial instrument's characteristics.
    /// Encoded/decoded by serializers as "InvalidPrice".
    /// </summary>
    [EnumMember(Value = "INPR")]
    [IsoId("_-tIIEb3REeO2FLWuu_JIqg")]
    [Description(@"Price does not comply with the financial instrument's characteristics.")]
    InvalidPrice,
    
    /// <summary>
    /// Instruction contains an invalid message identification, identification is unknown.
    /// Encoded/decoded by serializers as "InvalidIdentification".
    /// </summary>
    [EnumMember(Value = "INID")]
    [IsoId("__3QY4b3REeO2FLWuu_JIqg")]
    [Description(@"Instruction contains an invalid message identification, identification is unknown.")]
    InvalidIdentification,
    
    /// <summary>
    /// Invalid agent identification supplied.
    /// Encoded/decoded by serializers as "InvalidAgent".
    /// </summary>
    [EnumMember(Value = "AGIN")]
    [IsoId("_Agvawb3SEeO2FLWuu_JIqg")]
    [Description(@"Invalid agent identification supplied.")]
    InvalidAgent,
    
    /// <summary>
    /// Intermediary is not recognised or is invalid.
    /// Encoded/decoded by serializers as "Intermediary".
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_Apz3Mb3SEeO2FLWuu_JIqg")]
    [Description(@"Intermediary is not recognised or is invalid.")]
    Intermediary,
    
    /// <summary>
    /// Instruction is rejected since the provided certification is incorrect or incomplete.
    /// Encoded/decoded by serializers as "IncorrectCertification".
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_C0-HMb3SEeO2FLWuu_JIqg")]
    [Description(@"Instruction is rejected since the provided certification is incorrect or incomplete.")]
    IncorrectCertification,
    
    /// <summary>
    /// Unrecognised or invalid business partner number.
    /// Encoded/decoded by serializers as "BusinessPartnerNumberRejection".
    /// </summary>
    [EnumMember(Value = "BPAR")]
    [IsoId("_GT99ob3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid business partner number.")]
    BusinessPartnerNumberRejection,
    
    /// <summary>
    /// Unrecognised or invalid bank reference number.
    /// Encoded/decoded by serializers as "BankReferenceNumberRejection".
    /// </summary>
    [EnumMember(Value = "BREF")]
    [IsoId("_GcLecb3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid bank reference number.")]
    BankReferenceNumberRejection,
    
    /// <summary>
    /// Address details are incorrect or cannot be recognised.
    /// Encoded/decoded by serializers as "AddressDetailsRejection".
    /// </summary>
    [EnumMember(Value = "DADR")]
    [IsoId("_HW7Pcb3SEeO2FLWuu_JIqg")]
    [Description(@"Address details are incorrect or cannot be recognised.")]
    AddressDetailsRejection,
    
    /// <summary>
    /// Unrecognised or invalid delivering custodian.
    /// Encoded/decoded by serializers as "DeliveringCustodian".
    /// </summary>
    [EnumMember(Value = "DCUS")]
    [IsoId("_JggyIb3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid delivering custodian.")]
    DeliveringCustodian,
    
    /// <summary>
    /// Incorrect activity type specified, for example, pre-release conversion.
    /// Encoded/decoded by serializers as "IncorrectActivityType".
    /// </summary>
    [EnumMember(Value = "IACT")]
    [IsoId("_MSB3gb3SEeO2FLWuu_JIqg")]
    [Description(@"Incorrect activity type specified, for example, pre-release conversion.")]
    IncorrectActivityType,
    
    /// <summary>
    /// For tax reclaim, the reclaim is invalid for the tax authorities.
    /// Encoded/decoded by serializers as "InvalidForTaxAuthorities".
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_NrMC0b3SEeO2FLWuu_JIqg")]
    [Description(@"For tax reclaim, the reclaim is invalid for the tax authorities.")]
    InvalidForTaxAuthorities,
    
    /// <summary>
    /// Message details specified in the instruction/request are inconsistent with those that were specified in the relating original message.
    /// Encoded/decoded by serializers as "InvalidDetails".
    /// </summary>
    [EnumMember(Value = "INDT")]
    [IsoId("_OBV5Ab3SEeO2FLWuu_JIqg")]
    [Description(@"Message details specified in the instruction/request are inconsistent with those that were specified in the relating original message.")]
    InvalidDetails,
    
    /// <summary>
    /// Invalid combination of corporate action option code and corporate action option number.
    /// Encoded/decoded by serializers as "InvalidOption".
    /// </summary>
    [EnumMember(Value = "OPTI")]
    [IsoId("_PLzhAb3SEeO2FLWuu_JIqg")]
    [Description(@"Invalid combination of corporate action option code and corporate action option number.")]
    InvalidOption,
    
    /// <summary>
    /// Invalid option type.
    /// Encoded/decoded by serializers as "InvalidOptionType".
    /// </summary>
    [EnumMember(Value = "OPTY")]
    [IsoId("_PUDeEb3SEeO2FLWuu_JIqg")]
    [Description(@"Invalid option type.")]
    InvalidOptionType,
    
    /// <summary>
    /// Details specified in the movement general information block are inconsistent with those that were specified in the relating original message.
    /// Encoded/decoded by serializers as "InvalidMovementInformation".
    /// </summary>
    [EnumMember(Value = "INMO")]
    [IsoId("_Pm7Wwb3SEeO2FLWuu_JIqg")]
    [Description(@"Details specified in the movement general information block are inconsistent with those that were specified in the relating original message.")]
    InvalidMovementInformation,
    
    /// <summary>
    /// Invalid or unrecognized modification request.
    /// Encoded/decoded by serializers as "InvalidModificationRequest".
    /// </summary>
    [EnumMember(Value = "INVM")]
    [IsoId("_QhoEcb3SEeO2FLWuu_JIqg")]
    [Description(@"Invalid or unrecognized modification request.")]
    InvalidModificationRequest,
    
    /// <summary>
    /// Underlying security identification does not correspond with the corporate action reference supplied.
    /// Encoded/decoded by serializers as "InvalidUnderlyingSecurity".
    /// </summary>
    [EnumMember(Value = "INUS")]
    [IsoId("_RYkTgb3SEeO2FLWuu_JIqg")]
    [Description(@"Underlying security identification does not correspond with the corporate action reference supplied.")]
    InvalidUnderlyingSecurity,
    
    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as "InvalidSecurity".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_SZUl4b3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity,
    
    /// <summary>
    /// Period ending date or code is missing.
    /// Encoded/decoded by serializers as "MissingPeriodEndDate".
    /// </summary>
    [EnumMember(Value = "ENDP")]
    [IsoId("_UJ8O8b3SEeO2FLWuu_JIqg")]
    [Description(@"Period ending date or code is missing.")]
    MissingPeriodEndDate,
    
    /// <summary>
    /// Period starting date or code is missing.
    /// Encoded/decoded by serializers as "MissingPeriodStartDate".
    /// </summary>
    [EnumMember(Value = "STAR")]
    [IsoId("_UREKob3SEeO2FLWuu_JIqg")]
    [Description(@"Period starting date or code is missing.")]
    MissingPeriodStartDate,
    
    /// <summary>
    /// Second option is mandatory.
    /// Encoded/decoded by serializers as "MissingOption".
    /// </summary>
    [EnumMember(Value = "SECO")]
    [IsoId("_UtH0gb3SEeO2FLWuu_JIqg")]
    [Description(@"Second option is mandatory.")]
    MissingOption,
    
    /// <summary>
    /// No holding for the specified underlying security.
    /// Encoded/decoded by serializers as "NoHolding".
    /// </summary>
    [EnumMember(Value = "NOHO")]
    [IsoId("_WYejEb3SEeO2FLWuu_JIqg")]
    [Description(@"No holding for the specified underlying security.")]
    NoHolding,
    
    /// <summary>
    /// Referred instrument does not exist in combination with the mentioned market.
    /// Encoded/decoded by serializers as "NoInstrumentMarket".
    /// </summary>
    [EnumMember(Value = "NINS")]
    [IsoId("_XEXYsb3SEeO2FLWuu_JIqg")]
    [Description(@"Referred instrument does not exist in combination with the mentioned market.")]
    NoInstrumentMarket,
    
    /// <summary>
    /// Instruction type is not applicable for mandatory events.
    /// Encoded/decoded by serializers as "NotApplicable".
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("_X5PyQb3SEeO2FLWuu_JIqg")]
    [Description(@"Instruction type is not applicable for mandatory events.")]
    NotApplicable,
    
    /// <summary>
    /// Permission to be processed is not granted.
    /// Encoded/decoded by serializers as "NotAuthorised".
    /// </summary>
    [EnumMember(Value = "NAUT")]
    [IsoId("_YCOIEb3SEeO2FLWuu_JIqg")]
    [Description(@"Permission to be processed is not granted.")]
    NotAuthorised,
    
    /// <summary>
    /// Party is not defined as an agent.
    /// Encoded/decoded by serializers as "NotDefinedAgent".
    /// </summary>
    [EnumMember(Value = "AGID")]
    [IsoId("_YcozMb3SEeO2FLWuu_JIqg")]
    [Description(@"Party is not defined as an agent.")]
    NotDefinedAgent,
    
    /// <summary>
    /// Disperse security is not eligible in the (ICSD) service provider owner.
    /// Encoded/decoded by serializers as "NotEligibleDisperseSecurity".
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_ZjjX8b3SEeO2FLWuu_JIqg")]
    [Description(@"Disperse security is not eligible in the (ICSD) service provider owner.")]
    NotEligibleDisperseSecurity,
    
    /// <summary>
    /// Unable to identify correspondent bank.
    /// Encoded/decoded by serializers as "NotIdentifiedCorrespondentBank".
    /// </summary>
    [EnumMember(Value = "CORR")]
    [IsoId("_aa4Bgb3SEeO2FLWuu_JIqg")]
    [Description(@"Unable to identify correspondent bank.")]
    NotIdentifiedCorrespondentBank,
    
    /// <summary>
    /// Unrecognised, invalid or missing place of safekeeping.
    /// Encoded/decoded by serializers as "PlaceOfSafekeeping".
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_cO3usb3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised, invalid or missing place of safekeeping.")]
    PlaceOfSafekeeping,
    
    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as "PlaceOfTrade".
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_ca9C4b3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade,
    
    /// <summary>
    /// Price in the execution exceeds the order price.
    /// Encoded/decoded by serializers as "PriceExceeds".
    /// </summary>
    [EnumMember(Value = "PRIC")]
    [IsoId("_c4fTcb3SEeO2FLWuu_JIqg")]
    [Description(@"Price in the execution exceeds the order price.")]
    PriceExceeds,
    
    /// <summary>
    /// Receiving agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as "ReceivingAgent".
    /// </summary>
    [EnumMember(Value = "IVAG")]
    [IsoId("_e0fGEb3SEeO2FLWuu_JIqg")]
    [Description(@"Receiving agent is not recognised or is invalid.")]
    ReceivingAgent,
    
    /// <summary>
    /// Quantity unit type is not provided.
    /// Encoded/decoded by serializers as "QuantityUnitType".
    /// </summary>
    [EnumMember(Value = "QUNP")]
    [IsoId("_fA3VMb3SEeO2FLWuu_JIqg")]
    [Description(@"Quantity unit type is not provided.")]
    QuantityUnitType,
    
    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as "QuantityRejection".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_fSR1Ub3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection,
    
    /// <summary>
    /// Quantity in the execution exceeds the ordered quantity.
    /// Encoded/decoded by serializers as "QuantityExceeds".
    /// </summary>
    [EnumMember(Value = "EQTY")]
    [IsoId("_fdpX0b3SEeO2FLWuu_JIqg")]
    [Description(@"Quantity in the execution exceeds the ordered quantity.")]
    QuantityExceeds,
    
    /// <summary>
    /// Unrecognised or invalid depository.
    /// Encoded/decoded by serializers as "ReceivingDeliveringDepository".
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_gtVeEb3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid depository.")]
    ReceivingDeliveringDepository,
    
    /// <summary>
    /// Unrecognised or invalid receiving agent.
    /// Encoded/decoded by serializers as "ReceivingCustodian".
    /// </summary>
    [EnumMember(Value = "RCUS")]
    [IsoId("_g_2KYb3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid receiving agent.")]
    ReceivingCustodian,
    
    /// <summary>
    /// Unrecognised or invalid message sender's safekeeping account.
    /// Encoded/decoded by serializers as "SafekeepingAccountRejection".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_iSqdIb3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection,
    
    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as "SettlementAmountRejection".
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_kPevIb3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    SettlementAmountRejection,
    
    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as "SettlementAmountCurrencyRejection".
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_kX9Vsb3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrencyRejection,
    
    /// <summary>
    /// Traded securities quantity not provided.
    /// Encoded/decoded by serializers as "TradedSecuritiesQuantity".
    /// </summary>
    [EnumMember(Value = "TQNP")]
    [IsoId("_m9_j0b3SEeO2FLWuu_JIqg")]
    [Description(@"Traded securities quantity not provided.")]
    TradedSecuritiesQuantity,
    
    /// <summary>
    /// Unrecognised or invalid settlement transaction type.
    /// Encoded/decoded by serializers as "SettlementTransactionRejection".
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_pKFn8b3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid settlement transaction type.")]
    SettlementTransactionRejection,
    
    /// <summary>
    /// Financial instrument's symbol has not been recognized.
    /// Encoded/decoded by serializers as "UnknownSymbol".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_rGPyob3SEeO2FLWuu_JIqg")]
    [Description(@"Financial instrument's symbol has not been recognized.")]
    UnknownSymbol,
    
    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as "DealPrice".
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_t1Sy0b3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice,
    
    /// <summary>
    /// Unrecognised or invalid closing date/time.
    /// Encoded/decoded by serializers as "ClosingDateTimeRejection".
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_vEOEEb3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid closing date/time.")]
    ClosingDateTimeRejection,
    
    /// <summary>
    /// Linked reference is unknown.
    /// Encoded/decoded by serializers as "InvalidReference".
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_AMmhUb3TEeO2FLWuu_JIqg")]
    [Description(@"Linked reference is unknown.")]
    InvalidReference,
    
    /// <summary>
    /// See narrative field for reason.
    /// Encoded/decoded by serializers as "NarrativeReason".
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_GgCOQb3TEeO2FLWuu_JIqg")]
    [Description(@"See narrative field for reason.")]
    NarrativeReason,
    
    /// <summary>
    /// Instruction could not be found.
    /// Encoded/decoded by serializers as "NotFoundRejection".
    /// </summary>
    [EnumMember(Value = "NRGN")]
    [IsoId("_JdT3sb3TEeO2FLWuu_JIqg")]
    [Description(@"Instruction could not be found.")]
    NotFoundRejection,
    
    /// <summary>
    /// Instruction aims at using an invalid balance.
    /// Encoded/decoded by serializers as "InvalidBalance".
    /// </summary>
    [EnumMember(Value = "INVB")]
    [IsoId("_ftvpsUlFEeSxKv6IjBzDlA")]
    [Description(@"Instruction aims at using an invalid balance.")]
    InvalidBalance,
    
    /// <summary>
    /// Transaction/instruction received after the account servicer's specified deadline.
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_-6ckEUr3EeSHP9pzU4nIpA")]
    [Description(@"Transaction/instruction received after the account servicer's specified deadline.")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as "CashAccount".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_IQqskUr4EeSHP9pzU4nIpA")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount,
    
    /// <summary>
    /// Unrecognised or invalid commercialisation contract.
    /// Encoded/decoded by serializers as "CommercializationContractRejection".
    /// </summary>
    [EnumMember(Value = "COMC")]
    [IsoId("_TDt_cUr4EeSHP9pzU4nIpA")]
    [Description(@"Unrecognised or invalid commercialisation contract.")]
    CommercializationContractRejection,
    
    /// <summary>
    /// Concentration limit was exceeded.
    /// Encoded/decoded by serializers as "ConcentrationLimitExceeded".
    /// </summary>
    [EnumMember(Value = "CONL")]
    [IsoId("_mhjRIUr4EeSHP9pzU4nIpA")]
    [Description(@"Concentration limit was exceeded.")]
    ConcentrationLimitExceeded,
    
    /// <summary>
    /// Insufficient balance.
    /// Encoded/decoded by serializers as "InsufficientBalance".
    /// </summary>
    [EnumMember(Value = "INHO")]
    [IsoId("_C7apsUr5EeSHP9pzU4nIpA")]
    [Description(@"Insufficient balance.")]
    InsufficientBalance,
    
    /// <summary>
    /// Insufficient collateral proposed.
    /// Encoded/decoded by serializers as "InsufficientCollateral".
    /// </summary>
    [EnumMember(Value = "ICOL")]
    [IsoId("_GKgb4Ur5EeSHP9pzU4nIpA")]
    [Description(@"Insufficient collateral proposed.")]
    InsufficientCollateral,
    
    /// <summary>
    /// Unrecognised or invalid investor party. May be used by an executing party to reject an instruction for an investor (or portfolio) for which it is not authorised to act.
    /// Encoded/decoded by serializers as "InvalidInvestorParty".
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_bIJTcUr5EeSHP9pzU4nIpA")]
    [Description(@"Unrecognised or invalid investor party. May be used by an executing party to reject an instruction for an investor (or portfolio) for which it is not authorised to act.")]
    InvalidInvestorParty,
    
    /// <summary>
    /// Invalid or unrecognized lot number.
    /// Encoded/decoded by serializers as "InvalidLotNumber".
    /// </summary>
    [EnumMember(Value = "INVN")]
    [IsoId("_izP98Ur5EeSHP9pzU4nIpA")]
    [Description(@"Invalid or unrecognized lot number.")]
    InvalidLotNumber,
    
    /// <summary>
    /// Invalid or unrecognized link.
    /// Encoded/decoded by serializers as "InvalidLink".
    /// </summary>
    [EnumMember(Value = "INVL")]
    [IsoId("_jXZM0Ur5EeSHP9pzU4nIpA")]
    [Description(@"Invalid or unrecognized link.")]
    InvalidLink,
    
    /// <summary>
    /// Account servicer validation rule rejection.
    /// Encoded/decoded by serializers as "InvalidRule".
    /// </summary>
    [EnumMember(Value = "VALR")]
    [IsoId("_52CkIUr5EeSHP9pzU4nIpA")]
    [Description(@"Account servicer validation rule rejection.")]
    InvalidRule,
    
    /// <summary>
    /// Investor name and address is not recognised.
    /// Encoded/decoded by serializers as "InvestorNameAddressUnknown".
    /// </summary>
    [EnumMember(Value = "INUK")]
    [IsoId("_E7iR4Ur6EeSHP9pzU4nIpA")]
    [Description(@"Investor name and address is not recognised.")]
    InvestorNameAddressUnknown,
    
    /// <summary>
    /// Instruction/Request arrives too late.
    /// Encoded/decoded by serializers as "Late".
    /// </summary>
    [EnumMember(Value = "LATT")]
    [IsoId("_Oa020Ur6EeSHP9pzU4nIpA")]
    [Description(@"Instruction/Request arrives too late.")]
    Late,
    
    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as "MinimumSettlementQuantity".
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_gV4HIUr6EeSHP9pzU4nIpA")]
    [Description(@"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.")]
    MinimumSettlementQuantity,
    
    /// <summary>
    /// Rejected due to missing beneficiary owner details.
    /// Encoded/decoded by serializers as "MissingBeneficiaryOwnerDetails".
    /// </summary>
    [EnumMember(Value = "BOIS")]
    [IsoId("_jPGXAUr6EeSHP9pzU4nIpA")]
    [Description(@"Rejected due to missing beneficiary owner details.")]
    MissingBeneficiaryOwnerDetails,
    
    /// <summary>
    /// Certification has not been filled in.
    /// Encoded/decoded by serializers as "MissingCertification".
    /// </summary>
    [EnumMember(Value = "MCER")]
    [IsoId("_kd8vwUr6EeSHP9pzU4nIpA")]
    [Description(@"Certification has not been filled in.")]
    MissingCertification,
    
    /// <summary>
    /// Missing or invalid power of attorney.
    /// Encoded/decoded by serializers as "MissingOrInvalidPOA".
    /// </summary>
    [EnumMember(Value = "IPOA")]
    [IsoId("_qjcHUUr6EeSHP9pzU4nIpA")]
    [Description(@"Missing or invalid power of attorney.")]
    MissingOrInvalidPOA,
    
    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as "MultipleSettlementQuantity".
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_zPQA4Ur6EeSHP9pzU4nIpA")]
    [Description(@"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.")]
    MultipleSettlementQuantity,
    
    /// <summary>
    /// Unrecognised or invalid service level agreement pre-agreed narrative information.
    /// Encoded/decoded by serializers as "NarrativeInformationRejection".
    /// </summary>
    [EnumMember(Value = "INNA")]
    [IsoId("_3uiPoUr6EeSHP9pzU4nIpA")]
    [Description(@"Unrecognised or invalid service level agreement pre-agreed narrative information.")]
    NarrativeInformationRejection,
    
    /// <summary>
    /// Requested financial instrument is not available.
    /// Encoded/decoded by serializers as "NoInventory".
    /// </summary>
    [EnumMember(Value = "NINV")]
    [IsoId("_8njNAUr6EeSHP9pzU4nIpA")]
    [Description(@"Requested financial instrument is not available.")]
    NoInventory,
    
    /// <summary>
    /// Security is not eligible.
    /// Encoded/decoded by serializers as "NonEligibleSecurity".
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_BRi28Ur7EeSHP9pzU4nIpA")]
    [Description(@"Security is not eligible.")]
    NonEligibleSecurity,
    
    /// <summary>
    /// Period ending date is before period starting date.
    /// Encoded/decoded by serializers as "PeriodEndDateBeforeStartDate".
    /// </summary>
    [EnumMember(Value = "PERI")]
    [IsoId("_gD5w4Ur7EeSHP9pzU4nIpA")]
    [Description(@"Period ending date is before period starting date.")]
    PeriodEndDateBeforeStartDate,
    
    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as "ReferenceRejection".
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_AoqckUr8EeSHP9pzU4nIpA")]
    [Description(@"Instruction has a reference identical to another previously received instruction.")]
    ReferenceRejection,
    
    /// <summary>
    /// Several messages with the same identification.
    /// Encoded/decoded by serializers as "SameIdentification".
    /// </summary>
    [EnumMember(Value = "SAID")]
    [IsoId("_fUxkkUr8EeSHP9pzU4nIpA")]
    [Description(@"Several messages with the same identification.")]
    SameIdentification,
    
    /// <summary>
    /// Type of ownership indicated is not correct.
    /// Encoded/decoded by serializers as "TypeOfOwnershipRejection".
    /// </summary>
    [EnumMember(Value = "OWNT")]
    [IsoId("_47XkQUr8EeSHP9pzU4nIpA")]
    [Description(@"Type of ownership indicated is not correct.")]
    TypeOfOwnershipRejection,
    
    /// <summary>
    /// Reason is not available or unknown.
    /// Encoded/decoded by serializers as "NotAvailable".
    /// </summary>
    [EnumMember(Value = "NTAV")]
    [IsoId("_y7FrwSlGEeWwYv6HydV_vw")]
    [Description(@"Reason is not available or unknown.")]
    NotAvailable,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class HoldingRejectionReason41CodeMetadataExtensions
{
    private static readonly HoldingRejectionReason41CodeDropdownSource _dropdownSource = new HoldingRejectionReason41CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IHoldingRejectionReason41CodeDropdownRow GetMetadata(this HoldingRejectionReason41Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


