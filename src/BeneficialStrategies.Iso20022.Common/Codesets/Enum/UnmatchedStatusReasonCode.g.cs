﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UnmatchedStatusReasonCode.  ISO2002 ID# _906Z0J7MEee23OmtkkcE3A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction/instruction is unmatched, as published in an external cancellation reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_906Z0J7MEee23OmtkkcE3A")]
[Description(@"Specifies the reason the transaction/instruction is unmatched, as published in an external cancellation reason code set.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(UnmatchedStatusReason1Code))]
public enum UnmatchedStatusReasonCode
{
    /// <summary>
    /// Matching instruction from the counterparty could not be found.
    /// Encoded/decoded by serializers as "CMIS".
    /// </summary>
    [EnumMember(Value = "CMIS")]
    [IsoId("_Y7f5aNp-Ed-ak6NoX_4Aeg_689720527")]
    [Description(@"Matching instruction from the counterparty could not be found.")]
    MatchingInstructionNotFound,
    
    /// <summary>
    /// Counterparty disagrees with the settlement date/time.
    /// Encoded/decoded by serializers as "DDAT".
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_Y7f5adp-Ed-ak6NoX_4Aeg_689720528")]
    [Description(@"Counterparty disagrees with the settlement date/time.")]
    DisagreementSettlementDate,
    
    /// <summary>
    /// Counterparty expects a delivery not a receipt, or counterparty expects a receipt not a delivery.
    /// Encoded/decoded by serializers as "DELN".
    /// </summary>
    [EnumMember(Value = "DELN")]
    [IsoId("_Y7pDUNp-Ed-ak6NoX_4Aeg_689720529")]
    [Description(@"Counterparty expects a delivery not a receipt, or counterparty expects a receipt not a delivery.")]
    DisagreementDirectionOfTrade,
    
    /// <summary>
    /// Counterparty disagrees with the place of settlement.
    /// Encoded/decoded by serializers as "DEPT".
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_Y7pDUdp-Ed-ak6NoX_4Aeg_689720530")]
    [Description(@"Counterparty disagrees with the place of settlement.")]
    DisagreementPlaceOfSettlement,
    
    /// <summary>
    /// Counterparty disagrees with the settlement amount.
    /// Encoded/decoded by serializers as "DMON".
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_Y7pDUtp-Ed-ak6NoX_4Aeg_689720531")]
    [Description(@"Counterparty disagrees with the settlement amount.")]
    DisagreementSettlementAmount,
    
    /// <summary>
    /// Counterparty disagrees with the deal price.
    /// Encoded/decoded by serializers as "DDEA".
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_Y7pDU9p-Ed-ak6NoX_4Aeg_689720539")]
    [Description(@"Counterparty disagrees with the deal price.")]
    DisagreementDealPrice,
    
    /// <summary>
    /// Counterparty disagrees with the quantity of the financial instrument.
    /// Encoded/decoded by serializers as "DQUA".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_Y7pDVNp-Ed-ak6NoX_4Aeg_689720540")]
    [Description(@"Counterparty disagrees with the quantity of the financial instrument.")]
    DisagreementQuantity,
    
    /// <summary>
    /// Repurchase call delay does not match.
    /// Encoded/decoded by serializers as "CADE".
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("_Y7pDVdp-Ed-ak6NoX_4Aeg_689720541")]
    [Description(@"Repurchase call delay does not match.")]
    DisagreementRepurchaseCallDelay,
    
    /// <summary>
    /// Settlement transaction type does not match.
    /// Encoded/decoded by serializers as "SETR".
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_Y7pDVtp-Ed-ak6NoX_4Aeg_689720542")]
    [Description(@"Settlement transaction type does not match.")]
    DisagreementSettlementTransaction,
    
    /// <summary>
    /// Counterparty disagrees with the security/issue, for example, ISIN or a financial instrument attribute differs.
    /// Encoded/decoded by serializers as "DSEC".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_Y7pDV9p-Ed-ak6NoX_4Aeg_689720543")]
    [Description(@"Counterparty disagrees with the security/issue, for example, ISIN or a financial instrument attribute differs.")]
    DisagreementSecurity,
    
    /// <summary>
    /// Variable rate support does not match.
    /// Encoded/decoded by serializers as "VASU".
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("_Y7pDWNp-Ed-ak6NoX_4Aeg_689720544")]
    [Description(@"Variable rate support does not match.")]
    DisagreementVariableRateSupport,
    
    /// <summary>
    /// Counterparty does not recognise the transaction.
    /// Encoded/decoded by serializers as "DTRA".
    /// </summary>
    [EnumMember(Value = "DTRA")]
    [IsoId("_Y7pDWdp-Ed-ak6NoX_4Aeg_689720553")]
    [Description(@"Counterparty does not recognise the transaction.")]
    NotRecognised,
    
    /// <summary>
    /// Repurchase spread rate does not match.
    /// Encoded/decoded by serializers as "RSPR".
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("_Y7y0UNp-Ed-ak6NoX_4Aeg_689720554")]
    [Description(@"Repurchase spread rate does not match.")]
    DisagreementRepurchaseSpreadRate,
    
    /// <summary>
    /// Repurchase rate does not match.
    /// Encoded/decoded by serializers as "REPO".
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_Y7y0Udp-Ed-ak6NoX_4Aeg_689720555")]
    [Description(@"Repurchase rate does not match.")]
    DisagreementRepurchaseRate,
    
    /// <summary>
    /// Counterparty's instruction was too late.
    /// Encoded/decoded by serializers as "CLAT".
    /// </summary>
    [EnumMember(Value = "CLAT")]
    [IsoId("_Y7y0Utp-Ed-ak6NoX_4Aeg_689720556")]
    [Description(@"Counterparty's instruction was too late.")]
    CounterpartyTooLateForMatching,
    
    /// <summary>
    /// Repurchase rate type does not match.
    /// Encoded/decoded by serializers as "RERT".
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("_Y7y0U9p-Ed-ak6NoX_4Aeg_689720557")]
    [Description(@"Repurchase rate type does not match.")]
    DisagreementRepurchaseRateType,
    
    /// <summary>
    /// Repurchase amount does not match.
    /// Encoded/decoded by serializers as "REPA".
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("_Y7y0VNp-Ed-ak6NoX_4Aeg_689720558")]
    [Description(@"Repurchase amount does not match.")]
    DisagreementRepurchaseAmount,
    
    /// <summary>
    /// Repurchase premium amount does not match.
    /// Encoded/decoded by serializers as "REPP".
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("_Y7y0Vdp-Ed-ak6NoX_4Aeg_689720559")]
    [Description(@"Repurchase premium amount does not match.")]
    DisagreementRepurchasePremiumAmount,
    
    /// <summary>
    /// Counterparty's instructions is for physical settlement, and yours is not, or vice versa.
    /// Encoded/decoded by serializers as "PHYS".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_Y7y0Vtp-Ed-ak6NoX_4Aeg_689720560")]
    [Description(@"Counterparty's instructions is for physical settlement, and yours is not, or vice versa.")]
    DisagreementPhysicalSettlement,
    
    /// <summary>
    /// Counterparty disagrees with the common reference.
    /// Encoded/decoded by serializers as "IIND".
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_Y7y0V9p-Ed-ak6NoX_4Aeg_689720561")]
    [Description(@"Counterparty disagrees with the common reference.")]
    DisagreementCommonReference,
    
    /// <summary>
    /// Counterparty's instructions is for free settlement, and yours is for settlement against payment, or vice versa.
    /// Encoded/decoded by serializers as "FRAP".
    /// </summary>
    [EnumMember(Value = "FRAP")]
    [IsoId("_Y7y0WNp-Ed-ak6NoX_4Aeg_689720562")]
    [Description(@"Counterparty's instructions is for free settlement, and yours is for settlement against payment, or vice versa.")]
    DisagreementPaymentCode,
    
    /// <summary>
    /// Place of trade does not match.
    /// Encoded/decoded by serializers as "PLCE".
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_Y7y0Wdp-Ed-ak6NoX_4Aeg_689720570")]
    [Description(@"Place of trade does not match.")]
    DisagreementPlaceOfTrade,
    
    /// <summary>
    /// Instruction is a possible duplicate.
    /// Encoded/decoded by serializers as "PODU".
    /// </summary>
    [EnumMember(Value = "PODU")]
    [IsoId("_Y77-QNp-Ed-ak6NoX_4Aeg_689720571")]
    [Description(@"Instruction is a possible duplicate.")]
    PossibleDuplicateInstruction,
    
    /// <summary>
    /// Repurchase forfeit amount does not match.
    /// Encoded/decoded by serializers as "FORF".
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_Y77-Qdp-Ed-ak6NoX_4Aeg_689720572")]
    [Description(@"Repurchase forfeit amount does not match.")]
    DisagreementForfeitRepurchaseamount,
    
    /// <summary>
    /// Discrepancies exist in the registration details linked to the transaction.
    /// Encoded/decoded by serializers as "REGD".
    /// </summary>
    [EnumMember(Value = "REGD")]
    [IsoId("_Y77-Qtp-Ed-ak6NoX_4Aeg_689720573")]
    [Description(@"Discrepancies exist in the registration details linked to the transaction.")]
    DisagreementRegistrationDetails,
    
    /// <summary>
    /// Counterparty indicates a settlement via RTGS system and you indicate non-RTGS settlement, or vice versa.
    /// Encoded/decoded by serializers as "RTGS".
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_Y77-Q9p-Ed-ak6NoX_4Aeg_689720574")]
    [Description(@"Counterparty indicates a settlement via RTGS system and you indicate non-RTGS settlement, or vice versa.")]
    DisagreementRTGSSystem,
    
    /// <summary>
    /// Counterparty indicated an incorrect delivery or receiving agent.
    /// Encoded/decoded by serializers as "ICAG".
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_Y77-RNp-Ed-ak6NoX_4Aeg_689720575")]
    [Description(@"Counterparty indicated an incorrect delivery or receiving agent.")]
    IncorrectAgent,
    
    /// <summary>
    /// Counterparty has cancelled the transaction/instruction.
    /// Encoded/decoded by serializers as "CPCA".
    /// </summary>
    [EnumMember(Value = "CPCA")]
    [IsoId("_Y77-Rdp-Ed-ak6NoX_4Aeg_689720584")]
    [Description(@"Counterparty has cancelled the transaction/instruction.")]
    CounterpartyCancelledInstruction,
    
    /// <summary>
    /// Counterparty disagrees on the amount of charges.
    /// Encoded/decoded by serializers as "CHAR".
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_Y77-Rtp-Ed-ak6NoX_4Aeg_689720585")]
    [Description(@"Counterparty disagrees on the amount of charges.")]
    DisagreementChargesAmount,
    
    /// <summary>
    /// Instruction indicates an incorrect buyer (receiver) or seller (deliverer).
    /// Encoded/decoded by serializers as "IEXE".
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_Y77-R9p-Ed-ak6NoX_4Aeg_689720586")]
    [Description(@"Instruction indicates an incorrect buyer (receiver) or seller (deliverer).")]
    IncorrectBuyerOrSeller,
    
    /// <summary>
    /// Counterparty disagrees with the currency of the settlement amount.
    /// Encoded/decoded by serializers as "NCRR".
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_Y77-SNp-Ed-ak6NoX_4Aeg_689720587")]
    [Description(@"Counterparty disagrees with the currency of the settlement amount.")]
    DisagreementCurrencySettlementAmount,
    
    /// <summary>
    /// Matching process has not yet started.
    /// Encoded/decoded by serializers as "NMAS".
    /// </summary>
    [EnumMember(Value = "NMAS")]
    [IsoId("_Y77-Sdp-Ed-ak6NoX_4Aeg_689720588")]
    [Description(@"Matching process has not yet started.")]
    NoMatchingStarted,
    
    /// <summary>
    /// Safekeeping account used as a matching criteria on the market concerned does not match.
    /// Encoded/decoded by serializers as "SAFE".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_Y77-Stp-Ed-ak6NoX_4Aeg_689720589")]
    [Description(@"Safekeeping account used as a matching criteria on the market concerned does not match.")]
    DisagreementSafekeepingAccount,
    
    /// <summary>
    /// Counterparty disagrees with the trade date.
    /// Encoded/decoded by serializers as "DTRD".
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_Y8FvQNp-Ed-ak6NoX_4Aeg_689720590")]
    [Description(@"Counterparty disagrees with the trade date.")]
    DisagreementTradeDate,
    
    /// <summary>
    /// Instruction received too late for matching.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_Y8FvQdp-Ed-ak6NoX_4Aeg_689720591")]
    [Description(@"Instruction received too late for matching.")]
    YourInstructionTooLateForMatching,
    
    /// <summary>
    /// Closing date/time does not match.
    /// Encoded/decoded by serializers as "TERM".
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_Y8FvQtp-Ed-ak6NoX_4Aeg_689720592")]
    [Description(@"Closing date/time does not match.")]
    DisagreementClosingDateTime,
    
    /// <summary>
    /// Incorrect delivering or receiving custodian.
    /// Encoded/decoded by serializers as "ICUS".
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_Y8FvQ9p-Ed-ak6NoX_4Aeg_689720593")]
    [Description(@"Incorrect delivering or receiving custodian.")]
    DisagreementReceivingOrDeliveringCustodian,
    
}
