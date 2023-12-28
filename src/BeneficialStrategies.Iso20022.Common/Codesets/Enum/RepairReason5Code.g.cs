﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RepairReason5Code.  ISO2002 ID# _ZuT2adp-Ed-ak6NoX_4Aeg_1118630481.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the securities financing instruction has a repair status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZuT2adp-Ed-ak6NoX_4Aeg_1118630481")]
[Description(@"Specifies the reason why the securities financing instruction has a repair status.")]
[DerivedFrom(typeof(RepairReasonV2Code))]
public enum RepairReason5Code
{
    /// <summary>
    /// Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.
    /// Encoded/decoded by serializers as "ProcessingBatch".
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("_ZudAUNp-Ed-ak6NoX_4Aeg_-1531069380")]
    [Description(@"Unrecognised or invalid processing batch, that is, daytime/real-time while only possible to settle in overnight batch.")]
    ProcessingBatch,
    
    /// <summary>
    /// Corporate action pending on the financial instrument instructed.
    /// Encoded/decoded by serializers as "CorporateAction".
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("_ZudAUdp-Ed-ak6NoX_4Aeg_121558128")]
    [Description(@"Corporate action pending on the financial instrument instructed.")]
    CorporateAction,
    
    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as "CashAccount".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_ZudAUtp-Ed-ak6NoX_4Aeg_-170399610")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount,
    
    /// <summary>
    /// Impossible standing arrangements override instruction for the cash settlement system.
    /// Encoded/decoded by serializers as "ImpossibleCashSettlementSystem".
    /// </summary>
    [EnumMember(Value = "CASY")]
    [IsoId("_ZudAU9p-Ed-ak6NoX_4Aeg_7719062")]
    [Description(@"Impossible standing arrangements override instruction for the cash settlement system.")]
    ImpossibleCashSettlementSystem,
    
    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as "SettlementDate".
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_ZudAVNp-Ed-ak6NoX_4Aeg_1766825563")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDate,
    
    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as "DealPrice".
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_ZudAVdp-Ed-ak6NoX_4Aeg_-875514225")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice,
    
    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as "SettlementAmount".
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_ZudAVtp-Ed-ak6NoX_4Aeg_-1167471963")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    SettlementAmount,
    
    /// <summary>
    /// Unrecognised or invalid settlement quantity.
    /// Encoded/decoded by serializers as "Quantity".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_ZudAV9p-Ed-ak6NoX_4Aeg_-989353291")]
    [Description(@"Unrecognised or invalid settlement quantity.")]
    Quantity,
    
    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as "Security".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_ZudAWNp-Ed-ak6NoX_4Aeg_769753210")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    Security,
    
    /// <summary>
    /// Unrecognised or invalid trade date.
    /// Encoded/decoded by serializers as "TradeDate".
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_ZudAWdp-Ed-ak6NoX_4Aeg_-1872586578")]
    [Description(@"Unrecognised or invalid trade date.")]
    TradeDate,
    
    /// <summary>
    /// Unrecognised, invalid or missing common reference.
    /// Encoded/decoded by serializers as "CommonReference".
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_ZumxUNp-Ed-ak6NoX_4Aeg_2130422980")]
    [Description(@"Unrecognised, invalid or missing common reference.")]
    CommonReference,
    
    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as "MinimumSettlementQuantity".
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_ZumxUdp-Ed-ak6NoX_4Aeg_-1986425644")]
    [Description(@"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.")]
    MinimumSettlementQuantity,
    
    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as "MultipleSettlementQuantity".
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_ZumxUtp-Ed-ak6NoX_4Aeg_-227319143")]
    [Description(@"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.")]
    MultipleSettlementQuantity,
    
    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as "SettlementAmountCurrency".
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_ZumxU9p-Ed-ak6NoX_4Aeg_1425308365")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrency,
    
    /// <summary>
    /// Physical settlement is impossible for the instructed financial instrument.
    /// Encoded/decoded by serializers as "PhysicalSettlementImpossible".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_ZumxVNp-Ed-ak6NoX_4Aeg_1133350627")]
    [Description(@"Physical settlement is impossible for the instructed financial instrument.")]
    PhysicalSettlementImpossible,
    
    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as "PlaceOfTrade".
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_ZumxVdp-Ed-ak6NoX_4Aeg_1311469299")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade,
    
    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as "Reference".
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_ZumxVtp-Ed-ak6NoX_4Aeg_-1224391496")]
    [Description(@"Instruction has a reference identical to another previously received instruction.")]
    Reference,
    
    /// <summary>
    /// Impossible to use the RTGS system instructed (NRTG or YRTG).
    /// Encoded/decoded by serializers as "ImpossibleToUseTheRTGSSystemInstructed".
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_ZumxV9p-Ed-ak6NoX_4Aeg_428236012")]
    [Description(@"Impossible to use the RTGS system instructed (NRTG or YRTG).")]
    ImpossibleToUseTheRTGSSystemInstructed,
    
    /// <summary>
    /// Unrecognised or invalid message sender's safekeeping account.
    /// Encoded/decoded by serializers as "SafekeepingAccount".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_ZumxWNp-Ed-ak6NoX_4Aeg_136278274")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccount,
    
    /// <summary>
    /// Unrecognised or invalid settlement transaction type.
    /// Encoded/decoded by serializers as "SettlementTransaction".
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_ZumxWdp-Ed-ak6NoX_4Aeg_314396946")]
    [Description(@"Unrecognised or invalid settlement transaction type.")]
    SettlementTransaction,
    
    /// <summary>
    /// Unrecognised or invalid settlement system/method instructed.
    /// Encoded/decoded by serializers as "SettlementSystemMethod".
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("_ZumxWtp-Ed-ak6NoX_4Aeg_2073503447")]
    [Description(@"Unrecognised or invalid settlement system/method instructed.")]
    SettlementSystemMethod,
    
    /// <summary>
    /// Unrecognised or invalid tax status of the securities instructed.
    /// Encoded/decoded by serializers as "TaxStatus".
    /// </summary>
    [EnumMember(Value = "TXST")]
    [IsoId("_ZuwiUNp-Ed-ak6NoX_4Aeg_-568836341")]
    [Description(@"Unrecognised or invalid tax status of the securities instructed.")]
    TaxStatus,
    
    /// <summary>
    /// Unrecognised, invalid or missing Place of Safekeeping.
    /// Encoded/decoded by serializers as "PlaceOfSafekeeping".
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_ZuwiUdp-Ed-ak6NoX_4Aeg_-860794079")]
    [Description(@"Unrecognised, invalid or missing Place of Safekeeping.")]
    PlaceOfSafekeeping,
    
    /// <summary>
    /// Required stamp duty information is missing.
    /// Encoded/decoded by serializers as "StampDuty".
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("_ZuwiUtp-Ed-ak6NoX_4Aeg_-682675407")]
    [Description(@"Required stamp duty information is missing.")]
    StampDuty,
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZuwiU9p-Ed-ak6NoX_4Aeg_1076431094")]
    [Description(@"Other. See Narrative.")]
    Other,
    
    /// <summary>
    /// Client of delivering or receiving party 2 mismatch.
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty3".
    /// </summary>
    [EnumMember(Value = "IEXE")]
    [IsoId("_ZuwiVNp-Ed-ak6NoX_4Aeg_-1679747760")]
    [Description(@"Client of delivering or receiving party 2 mismatch.")]
    ReceivingDeliveringParty3,
    
    /// <summary>
    /// Participant of delivering or receiving depository mismatch.
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty1".
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_ZuwiVdp-Ed-ak6NoX_4Aeg_1440028511")]
    [Description(@"Participant of delivering or receiving depository mismatch.")]
    ReceivingDeliveringParty1,
    
    /// <summary>
    /// Depository mismatch.
    /// Encoded/decoded by serializers as "ReceivingDeliveringDepository".
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_ZuwiVtp-Ed-ak6NoX_4Aeg_734913896")]
    [Description(@"Depository mismatch.")]
    ReceivingDeliveringDepository,
    
    /// <summary>
    /// Client of delivering or receiving party 1 mismatch.
    /// Encoded/decoded by serializers as "ReceivingDeliveringParty2".
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_ZuwiV9p-Ed-ak6NoX_4Aeg_-1914785965")]
    [Description(@"Client of delivering or receiving party 1 mismatch.")]
    ReceivingDeliveringParty2,
    
    /// <summary>
    /// Unrecognised or invalid termination transaction amount.
    /// Encoded/decoded by serializers as "TerminationTransactionAmount".
    /// </summary>
    [EnumMember(Value = "REPA")]
    [IsoId("_ZuwiWNp-Ed-ak6NoX_4Aeg_851101673")]
    [Description(@"Unrecognised or invalid termination transaction amount.")]
    TerminationTransactionAmount,
    
    /// <summary>
    /// Unrecognised or invalid transaction call delay.
    /// Encoded/decoded by serializers as "TransactionCallDelay".
    /// </summary>
    [EnumMember(Value = "CADE")]
    [IsoId("_ZuwiWdp-Ed-ak6NoX_4Aeg_737262607")]
    [Description(@"Unrecognised or invalid transaction call delay.")]
    TransactionCallDelay,
    
    /// <summary>
    /// Unrecognised or invalid repurchase rate type.
    /// Encoded/decoded by serializers as "RepurchaseRateType".
    /// </summary>
    [EnumMember(Value = "RERT")]
    [IsoId("_Zu5sQNp-Ed-ak6NoX_4Aeg_-145970680")]
    [Description(@"Unrecognised or invalid repurchase rate type.")]
    RepurchaseRateType,
    
    /// <summary>
    /// Unrecognised or invalid spread rate.
    /// Encoded/decoded by serializers as "SpreadRate".
    /// </summary>
    [EnumMember(Value = "RSPR")]
    [IsoId("_Zu5sQdp-Ed-ak6NoX_4Aeg_-259809746")]
    [Description(@"Unrecognised or invalid spread rate.")]
    SpreadRate,
    
    /// <summary>
    /// Unrecognised or invalid variable rate support (repurchase agreement).
    /// Encoded/decoded by serializers as "VariableRateSupport".
    /// </summary>
    [EnumMember(Value = "VASU")]
    [IsoId("_Zu5sQtp-Ed-ak6NoX_4Aeg_-1143043033")]
    [Description(@"Unrecognised or invalid variable rate support (repurchase agreement).")]
    VariableRateSupport,
    
    /// <summary>
    /// Unrecognised or invalid repurchase rate.
    /// Encoded/decoded by serializers as "RepurchaseRate".
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_Zu5sQ9p-Ed-ak6NoX_4Aeg_-1256882099")]
    [Description(@"Unrecognised or invalid repurchase rate.")]
    RepurchaseRate,
    
    /// <summary>
    /// Unrecognised or invalid premium amount.
    /// Encoded/decoded by serializers as "PremiumAmount".
    /// </summary>
    [EnumMember(Value = "REPP")]
    [IsoId("_Zu5sRNp-Ed-ak6NoX_4Aeg_-2140115386")]
    [Description(@"Unrecognised or invalid premium amount.")]
    PremiumAmount,
    
    /// <summary>
    /// Unrecognised or invalid closing date/time.
    /// Encoded/decoded by serializers as "ClosingDateTime".
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_Zu5sRdp-Ed-ak6NoX_4Aeg_2041012844")]
    [Description(@"Unrecognised or invalid closing date/time.")]
    ClosingDateTime,
    
    /// <summary>
    /// Unrecognised or invalid forfeit amount.
    /// Encoded/decoded by serializers as "ForfeitAmount".
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_Zu5sRtp-Ed-ak6NoX_4Aeg_1157779557")]
    [Description(@"Unrecognised or invalid forfeit amount.")]
    ForfeitAmount,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RepairReason5CodeMetadataExtensions
{
    private static readonly RepairReason5CodeDropdownSource _dropdownSource = new RepairReason5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRepairReason5CodeDropdownRow GetMetadata(this RepairReason5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


