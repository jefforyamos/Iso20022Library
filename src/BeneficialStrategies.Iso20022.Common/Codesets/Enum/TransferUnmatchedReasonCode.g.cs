﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransferUnmatchedReasonCode.  ISO2002 ID# _Y8FvRNp-Ed-ak6NoX_4Aeg_-12808488.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction, transfer or settlement instruction is unmatched.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y8FvRNp-Ed-ak6NoX_4Aeg_-12808488")]
[Description(@"Specifies the reason the transaction, transfer or settlement instruction is unmatched.")]
[Derivations(typeof(TransferUnmatchedReason1Code),typeof(TransferUnmatchedReason2Code),typeof(TransferUnmatchedReason3Code))]
public enum TransferUnmatchedReasonCode
{
    /// <summary>
    /// No potential match has been found.
    /// Encoded/decoded by serializers as "CMIS".
    /// </summary>
    [EnumMember(Value = "CMIS")]
    [IsoId("_Y8FvRdp-Ed-ak6NoX_4Aeg_13972700")]
    [Description(@"No potential match has been found.")]
    NoMatch,
    
    /// <summary>
    /// Settlement date or transfer date does not match.
    /// Encoded/decoded by serializers as "DDAT".
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_Y8FvRtp-Ed-ak6NoX_4Aeg_13973120")]
    [Description(@"Settlement date or transfer date does not match.")]
    SettlementDate,
    
    /// <summary>
    /// Direction of transaction does not match: delivery instead of receipt or vice versa.
    /// Encoded/decoded by serializers as "DELN".
    /// </summary>
    [EnumMember(Value = "DELN")]
    [IsoId("_Y8FvR9p-Ed-ak6NoX_4Aeg_13973155")]
    [Description(@"Direction of transaction does not match: delivery instead of receipt or vice versa.")]
    TransactionDirection,
    
    /// <summary>
    /// Place of settlement does not match.
    /// Encoded/decoded by serializers as "DEPT".
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_Y8FvSNp-Ed-ak6NoX_4Aeg_13973198")]
    [Description(@"Place of settlement does not match.")]
    SettlementPlace,
    
    /// <summary>
    /// Settlement amount does not match.
    /// Encoded/decoded by serializers as "DMON".
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_Y8FvSdp-Ed-ak6NoX_4Aeg_13973233")]
    [Description(@"Settlement amount does not match.")]
    SettlementAmount,
    
    /// <summary>
    /// Deal price does not match.
    /// Encoded/decoded by serializers as "DDEA".
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_Y8PgQNp-Ed-ak6NoX_4Aeg_13973510")]
    [Description(@"Deal price does not match.")]
    DealPrice,
    
    /// <summary>
    /// Financial instrument quantity does not match.
    /// Encoded/decoded by serializers as "DQUA".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_Y8PgQdp-Ed-ak6NoX_4Aeg_13973545")]
    [Description(@"Financial instrument quantity does not match.")]
    FinancialInstrumentQuantity,
    
    /// <summary>
    /// Repurchase call delay does not match.
    /// Encoded/decoded by serializers as "CADE".
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("_Y8PgQtp-Ed-ak6NoX_4Aeg_13973587")]
    [Description(@"Repurchase call delay does not match.")]
    RepurchaseCallDelay,
    
    /// <summary>
    /// Settlement transaction type does not match.
    /// Encoded/decoded by serializers as "SETR".
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_Y8PgQ9p-Ed-ak6NoX_4Aeg_13973647")]
    [Description(@"Settlement transaction type does not match.")]
    SettlementTransaction,
    
    /// <summary>
    /// Financial instrument identification does not match or a financial instrument attribute differs.
    /// Encoded/decoded by serializers as "DSEC".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_Y8PgRNp-Ed-ak6NoX_4Aeg_13973682")]
    [Description(@"Financial instrument identification does not match or a financial instrument attribute differs.")]
    FinancialInstrument,
    
    /// <summary>
    /// Variable rate support does not match.
    /// Encoded/decoded by serializers as "VASU".
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("_Y8PgRdp-Ed-ak6NoX_4Aeg_13973990")]
    [Description(@"Variable rate support does not match.")]
    VariableRateSupport,
    
    /// <summary>
    /// Counterparty does not recognise the transaction.
    /// Encoded/decoded by serializers as "DTRA".
    /// </summary>
    [EnumMember(Value = "DTRA")]
    [IsoId("_Y8PgRtp-Ed-ak6NoX_4Aeg_13974033")]
    [Description(@"Counterparty does not recognise the transaction.")]
    NotRecognised,
    
    /// <summary>
    /// Repurchase spread rate does not match.
    /// Encoded/decoded by serializers as "RSPR".
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("_Y8PgR9p-Ed-ak6NoX_4Aeg_13974085")]
    [Description(@"Repurchase spread rate does not match.")]
    RepurchaseSpreadRate,
    
    /// <summary>
    /// Repurchase rate does not match.
    /// Encoded/decoded by serializers as "REPO".
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_Y8PgSNp-Ed-ak6NoX_4Aeg_13974145")]
    [Description(@"Repurchase rate does not match.")]
    RepurchaseRate,
    
    /// <summary>
    /// Counterparty's instruction was too late for matching.
    /// Encoded/decoded by serializers as "CLAT".
    /// </summary>
    [EnumMember(Value = "CLAT")]
    [IsoId("_Y8PgSdp-Ed-ak6NoX_4Aeg_13974205")]
    [Description(@"Counterparty's instruction was too late for matching.")]
    CounterpartyTooLateForMatching,
    
    /// <summary>
    /// Repurchase rate type does not match.
    /// Encoded/decoded by serializers as "RERT".
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("_Y8YqMNp-Ed-ak6NoX_4Aeg_13974560")]
    [Description(@"Repurchase rate type does not match.")]
    RepurchaseRateType,
    
    /// <summary>
    /// Repurchase amount does not match.
    /// Encoded/decoded by serializers as "REPA".
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("_Y8YqMdp-Ed-ak6NoX_4Aeg_13974612")]
    [Description(@"Repurchase amount does not match.")]
    RepurchaseAmount,
    
    /// <summary>
    /// Repurchase premium amount does not match.
    /// Encoded/decoded by serializers as "REPP".
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("_Y8YqMtp-Ed-ak6NoX_4Aeg_13974920")]
    [Description(@"Repurchase premium amount does not match.")]
    RepurchasePremiumAmount,
    
    /// <summary>
    /// Settlement does not match: counterparty's instruction is for physical settlement, your instruction is not, or vice versa.
    /// Encoded/decoded by serializers as "PHYS".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_Y8YqM9p-Ed-ak6NoX_4Aeg_13974980")]
    [Description(@"Settlement does not match: counterparty's instruction is for physical settlement, your instruction is not, or vice versa.")]
    PhysicalSettlement,
    
    /// <summary>
    /// Common reference does not match.
    /// Encoded/decoded by serializers as "IIND".
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_Y8YqNNp-Ed-ak6NoX_4Aeg_13975034")]
    [Description(@"Common reference does not match.")]
    CommonReference,
    
    /// <summary>
    /// Payment code does not match. The counterparty's instruction is for free settlement, and yours is for settlement against payment, or vice versa.
    /// Encoded/decoded by serializers as "FRAP".
    /// </summary>
    [EnumMember(Value = "FRAP")]
    [IsoId("_Y8YqNdp-Ed-ak6NoX_4Aeg_13975094")]
    [Description(@"Payment code does not match. The counterparty's instruction is for free settlement, and yours is for settlement against payment, or vice versa.")]
    PaymentCode,
    
    /// <summary>
    /// Place of trade does not match.
    /// Encoded/decoded by serializers as "PLCE".
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_Y8YqNtp-Ed-ak6NoX_4Aeg_13975154")]
    [Description(@"Place of trade does not match.")]
    PlaceOfTrade,
    
    /// <summary>
    /// Instruction has not been matched: it is a possible duplicate instruction.
    /// Encoded/decoded by serializers as "PODU".
    /// </summary>
    [EnumMember(Value = "PODU")]
    [IsoId("_Y8YqN9p-Ed-ak6NoX_4Aeg_13975448")]
    [Description(@"Instruction has not been matched: it is a possible duplicate instruction.")]
    Duplicate,
    
    /// <summary>
    /// Repurchase forfeit amount does not match.
    /// Encoded/decoded by serializers as "FORF".
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_Y8YqONp-Ed-ak6NoX_4Aeg_13975508")]
    [Description(@"Repurchase forfeit amount does not match.")]
    ForfeitRepurchaseAmount,
    
    /// <summary>
    /// Registration details do not match. A discrepancy exists in the registration details linked to the transaction.
    /// Encoded/decoded by serializers as "REGD".
    /// </summary>
    [EnumMember(Value = "REGD")]
    [IsoId("_Y8YqOdp-Ed-ak6NoX_4Aeg_14895557")]
    [Description(@"Registration details do not match. A discrepancy exists in the registration details linked to the transaction.")]
    RegistrationDetails,
    
    /// <summary>
    /// RTGS system does not match. Counterparty indicates a settlement via RTGS system and you indicate non-RTGS settlement, or vice versa.
    /// Encoded/decoded by serializers as "RTGS".
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_Y8ibMNp-Ed-ak6NoX_4Aeg_14895610")]
    [Description(@"RTGS system does not match. Counterparty indicates a settlement via RTGS system and you indicate non-RTGS settlement, or vice versa.")]
    RTGSSystem,
    
    /// <summary>
    /// Delivery or receiving agent does not match.
    /// Encoded/decoded by serializers as "ICAG".
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_Y8ibMdp-Ed-ak6NoX_4Aeg_14895670")]
    [Description(@"Delivery or receiving agent does not match.")]
    IncorrectAgent,
    
    /// <summary>
    /// Counterparty has cancelled the transaction/instruction.
    /// Encoded/decoded by serializers as "CPCA".
    /// </summary>
    [EnumMember(Value = "CPCA")]
    [IsoId("_Y8ibMtp-Ed-ak6NoX_4Aeg_14895747")]
    [Description(@"Counterparty has cancelled the transaction/instruction.")]
    CounterpartyCancelled,
    
    /// <summary>
    /// Charges amount does not match.
    /// Encoded/decoded by serializers as "CHAR".
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_Y8ibM9p-Ed-ak6NoX_4Aeg_14895807")]
    [Description(@"Charges amount does not match.")]
    ChargesAmount,
    
    /// <summary>
    /// Buyer (receiver) or seller (deliverer) does not match.
    /// Encoded/decoded by serializers as "IEXE".
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_Y8ibNNp-Ed-ak6NoX_4Aeg_14896102")]
    [Description(@"Buyer (receiver) or seller (deliverer) does not match.")]
    BuyerOrSeller,
    
    /// <summary>
    /// Currency of settlement amount does not match.
    /// Encoded/decoded by serializers as "NCRR".
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_Y8ibNdp-Ed-ak6NoX_4Aeg_14896179")]
    [Description(@"Currency of settlement amount does not match.")]
    CurrencySettlementAmount,
    
    /// <summary>
    /// Matching process has not yet started.
    /// Encoded/decoded by serializers as "NMAS".
    /// </summary>
    [EnumMember(Value = "NMAS")]
    [IsoId("_Y8ibNtp-Ed-ak6NoX_4Aeg_14896239")]
    [Description(@"Matching process has not yet started.")]
    NoMatchingStarted,
    
    /// <summary>
    /// Safekeeping account used as a matching criteria on the market concerned does not match.
    /// Encoded/decoded by serializers as "SAFE".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_Y8ibN9p-Ed-ak6NoX_4Aeg_14896565")]
    [Description(@"Safekeeping account used as a matching criteria on the market concerned does not match.")]
    SafekeepingAccount,
    
    /// <summary>
    /// Trade date does not match.
    /// Encoded/decoded by serializers as "DTRD".
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_Y8ibONp-Ed-ak6NoX_4Aeg_14896642")]
    [Description(@"Trade date does not match.")]
    TradeDate,
    
    /// <summary>
    /// Instruction received too late for matching.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_Y8ibOdp-Ed-ak6NoX_4Aeg_14896720")]
    [Description(@"Instruction received too late for matching.")]
    TooLateForMatching,
    
    /// <summary>
    /// Closing date/time does not match.
    /// Encoded/decoded by serializers as "TERM".
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_Y8ibOtp-Ed-ak6NoX_4Aeg_14896797")]
    [Description(@"Closing date/time does not match.")]
    ClosingDateTime,
    
    /// <summary>
    /// Delivering or receiving custodian does not match.
    /// Encoded/decoded by serializers as "ICUS".
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_Y8sMMNp-Ed-ak6NoX_4Aeg_14897092")]
    [Description(@"Delivering or receiving custodian does not match.")]
    ReceivingOrDeliveringCustodian,
    
    /// <summary>
    /// Another unmatched reason.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Y8sMMdp-Ed-ak6NoX_4Aeg_-1019055938")]
    [Description(@"Another unmatched reason.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransferUnmatchedReasonCodeMetadataExtensions
{
    private static readonly TransferUnmatchedReasonCodeDropdownSource _dropdownSource = new TransferUnmatchedReasonCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransferUnmatchedReasonCodeDropdownRow GetMetadata(this TransferUnmatchedReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


