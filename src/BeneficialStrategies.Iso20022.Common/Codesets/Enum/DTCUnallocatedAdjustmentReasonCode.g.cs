﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DTCUnallocatedAdjustmentReasonCode.  ISO2002 ID# _xv3G8GiLEeOdXoiw6mfXMw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// DTC Unallocated reason codes for payment adjustments.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xv3G8GiLEeOdXoiw6mfXMw")]
[Description(@"DTC Unallocated reason codes for payment adjustments.")]
[Derivations(typeof(DTCUnallocatedAdjustmentReason1Code),typeof(DTCUnallocatedAdjustmentReason2Code),typeof(DTCUnallocatedAdjustmentReason3Code))]
public enum DTCUnallocatedAdjustmentReasonCode
{
    /// <summary>
    /// Company is taking a 30 day grace period.
    /// Encoded/decoded by serializers as "SAGA".
    /// </summary>
    [EnumMember(Value = "SAGA")]
    [IsoId("_A8Y7gGiMEeOdXoiw6mfXMw")]
    [Description(@"Company is taking a 30 day grace period.")]
    GracePeriod,
    
    /// <summary>
    /// Rate is not final. Rate is approximate.
    /// Encoded/decoded by serializers as "APRR".
    /// </summary>
    [EnumMember(Value = "APRR")]
    [IsoId("_HLErUGiMEeOdXoiw6mfXMw")]
    [Description(@"Rate is not final. Rate is approximate.")]
    ApproximateRate,
    
    /// <summary>
    /// Incorrect announcement.
    /// Encoded/decoded by serializers as "ANNG".
    /// </summary>
    [EnumMember(Value = "ANNG")]
    [IsoId("_Q53E0GiMEeOdXoiw6mfXMw")]
    [Description(@"Incorrect announcement.")]
    BadAnnouncement,
    
    /// <summary>
    /// Incorrect payable date.
    /// Encoded/decoded by serializers as "BDPD".
    /// </summary>
    [EnumMember(Value = "BDPD")]
    [IsoId("_Q_X28GiMEeOdXoiw6mfXMw")]
    [Description(@"Incorrect payable date.")]
    BadPayableDate,
    
    /// <summary>
    /// Cash rate for allocation is zero.
    /// Encoded/decoded by serializers as "CSHR".
    /// </summary>
    [EnumMember(Value = "CSHR")]
    [IsoId("_REbWEGiMEeOdXoiw6mfXMw")]
    [Description(@"Cash rate for allocation is zero.")]
    CashRateUnknown,
    
    /// <summary>
    /// Cash rate for allocation is zero.
    /// Encoded/decoded by serializers as "CSHU".
    /// </summary>
    [EnumMember(Value = "CSHU")]
    [IsoId("_RJpNQGiMEeOdXoiw6mfXMw")]
    [Description(@"Cash rate for allocation is zero.")]
    CashRateZero,
    
    /// <summary>
    /// Payment is conditional and conditions have not been met yet.
    /// Encoded/decoded by serializers as "COND".
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("_RPJYUGiMEeOdXoiw6mfXMw")]
    [Description(@"Payment is conditional and conditions have not been met yet.")]
    ConditionalPayment,
    
    /// <summary>
    /// Issue is in default.
    /// Encoded/decoded by serializers as "DFLT".
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_RUM3cGiMEeOdXoiw6mfXMw")]
    [Description(@"Issue is in default.")]
    Default,
    
    /// <summary>
    /// Funds were not received by the agent.
    /// Encoded/decoded by serializers as "ANFI".
    /// </summary>
    [EnumMember(Value = "ANFI")]
    [IsoId("_RZQ9oGiMEeOdXoiw6mfXMw")]
    [Description(@"Funds were not received by the agent.")]
    FundsNotReceivedByAgent,
    
    /// <summary>
    /// Holiday in country of origin.
    /// Encoded/decoded by serializers as "HICO".
    /// </summary>
    [EnumMember(Value = "HICO")]
    [IsoId("_Ren-wGiMEeOdXoiw6mfXMw")]
    [Description(@"Holiday in country of origin.")]
    HolidayInCountryOfOrigin,
    
    /// <summary>
    /// Insufficient funds were received from the agent.
    /// Encoded/decoded by serializers as "MASF".
    /// </summary>
    [EnumMember(Value = "MASF")]
    [IsoId("_Rjrd4GiMEeOdXoiw6mfXMw")]
    [Description(@"Insufficient funds were received from the agent.")]
    InsufficientFundsReceivedFromAgent,
    
    /// <summary>
    /// Issue was not funded.
    /// Encoded/decoded by serializers as "ISNF".
    /// </summary>
    [EnumMember(Value = "ISNF")]
    [IsoId("_Rpo78GiMEeOdXoiw6mfXMw")]
    [Description(@"Issue was not funded.")]
    IssueNotFunded,
    
    /// <summary>
    /// Issue is not maturing.
    /// Encoded/decoded by serializers as "NMAT".
    /// </summary>
    [EnumMember(Value = "NMAT")]
    [IsoId("_RvSQ8GiMEeOdXoiw6mfXMw")]
    [Description(@"Issue is not maturing.")]
    IssueNotMaturing,
    
    /// <summary>
    /// Issues funded and/or identified after the cycle cut off.
    /// Encoded/decoded by serializers as "LFID".
    /// </summary>
    [EnumMember(Value = "LFID")]
    [IsoId("_R1PvAGiMEeOdXoiw6mfXMw")]
    [Description(@"Issues funded and/or identified after the cycle cut off.")]
    AfterCycleCutOff,
    
    /// <summary>
    /// Item is pending.
    /// Encoded/decoded by serializers as "PEND".
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_R6v6EGiMEeOdXoiw6mfXMw")]
    [Description(@"Item is pending.")]
    ItemIsPending,
    
    /// <summary>
    /// Issue is being liquidated.
    /// Encoded/decoded by serializers as "LIQD".
    /// </summary>
    [EnumMember(Value = "LIQD")]
    [IsoId("_R_9KMGiMEeOdXoiw6mfXMw")]
    [Description(@"Issue is being liquidated.")]
    Liquidation,
    
    /// <summary>
    /// Notional balance pincipal will not be paid.
    /// Encoded/decoded by serializers as "NOTL".
    /// </summary>
    [EnumMember(Value = "NOTL")]
    [IsoId("_SGDyMGiMEeOdXoiw6mfXMw")]
    [Description(@"Notional balance pincipal will not be paid.")]
    NotionalBalance,
    
    /// <summary>
    /// Reserved for new user defined reason codes.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_SL3fQGiMEeOdXoiw6mfXMw")]
    [Description(@"Reserved for new user defined reason codes.")]
    Other,
    
    /// <summary>
    /// Paid upon receipt of check.
    /// Encoded/decoded by serializers as "PCHK".
    /// </summary>
    [EnumMember(Value = "PCHK")]
    [IsoId("_SRg0QGiMEeOdXoiw6mfXMw")]
    [Description(@"Paid upon receipt of check.")]
    PaidUponReceiptOfCheck,
    
    /// <summary>
    /// Pending conversion of funds.
    /// Encoded/decoded by serializers as "RRFX".
    /// </summary>
    [EnumMember(Value = "RRFX")]
    [IsoId("_SW31YGiMEeOdXoiw6mfXMw")]
    [Description(@"Pending conversion of funds.")]
    PendingConversionOfFunds,
    
    /// <summary>
    /// Recapitalization. Issue not funded.
    /// Encoded/decoded by serializers as "RCNF".
    /// </summary>
    [EnumMember(Value = "RCNF")]
    [IsoId("_Sc0sYGiMEeOdXoiw6mfXMw")]
    [Description(@"Recapitalization. Issue not funded.")]
    RecapitalizationNotFunded,
    
    /// <summary>
    /// Redemption of rates. Issue not funded.
    /// Encoded/decoded by serializers as "RRNF".
    /// </summary>
    [EnumMember(Value = "RRNF")]
    [IsoId("_SioZcGiMEeOdXoiw6mfXMw")]
    [Description(@"Redemption of rates. Issue not funded.")]
    RedemptionOfRatesNotYetFunded,
    
    /// <summary>
    /// Released pledge position.
    /// Encoded/decoded by serializers as "RPLG".
    /// </summary>
    [EnumMember(Value = "RPLG")]
    [IsoId("_SxXZAGiMEeOdXoiw6mfXMw")]
    [Description(@"Released pledge position.")]
    ReleasedPledgePosition,
    
    /// <summary>
    /// Sale of asset. Issue not funded.
    /// Encoded/decoded by serializers as "SANF".
    /// </summary>
    [EnumMember(Value = "SANF")]
    [IsoId("_S3KfAGiMEeOdXoiw6mfXMw")]
    [Description(@"Sale of asset. Issue not funded.")]
    SaleOfAssetsNotYetFunded,
    
    /// <summary>
    /// Same day position capture.
    /// Encoded/decoded by serializers as "SDPC".
    /// </summary>
    [EnumMember(Value = "SDPC")]
    [IsoId("_S8-MEGiMEeOdXoiw6mfXMw")]
    [Description(@"Same day position capture.")]
    SameDayPositionCapture,
    
    /// <summary>
    /// Special distribution. Issue not funded.
    /// Encoded/decoded by serializers as "SPNF".
    /// </summary>
    [EnumMember(Value = "SPNF")]
    [IsoId("_TCx5IGiMEeOdXoiw6mfXMw")]
    [Description(@"Special distribution. Issue not funded.")]
    SpecialDistributionNotYetFunded,
    
    /// <summary>
    /// Specific issues have been suppressed.
    /// Encoded/decoded by serializers as "PUVF".
    /// </summary>
    [EnumMember(Value = "PUVF")]
    [IsoId("_TISEMGiMEeOdXoiw6mfXMw")]
    [Description(@"Specific issues have been suppressed.")]
    SpecificIssuesSuppressed,
    
    /// <summary>
    /// Call Rescinded.
    /// Encoded/decoded by serializers as "RESC".
    /// </summary>
    [EnumMember(Value = "RESC")]
    [IsoId("_M-MvkKIUEeS6IulNYwkZBg")]
    [Description(@"Call Rescinded.")]
    CallRescinded,
    
    /// <summary>
    /// CD Accelerated Maturity.
    /// Encoded/decoded by serializers as "ERLY".
    /// </summary>
    [EnumMember(Value = "ERLY")]
    [IsoId("_Yh5cQKIUEeS6IulNYwkZBg")]
    [Description(@"CD Accelerated Maturity.")]
    CDAcceleratedMaturity,
    
    /// <summary>
    /// CHIPS Payment.
    /// Encoded/decoded by serializers as "CHIP".
    /// </summary>
    [EnumMember(Value = "CHIP")]
    [IsoId("_lpbTMKIUEeS6IulNYwkZBg")]
    [Description(@"CHIPS Payment.")]
    CHIPSPayment,
    
    /// <summary>
    /// Five Day Grace Period.
    /// Encoded/decoded by serializers as "FVDG".
    /// </summary>
    [EnumMember(Value = "FVDG")]
    [IsoId("_v5hC8KIUEeS6IulNYwkZBg")]
    [Description(@"Five Day Grace Period.")]
    FiveDayGracePeriod,
    
    /// <summary>
    /// Failed Bank, FDIC Assumed.
    /// Encoded/decoded by serializers as "FDIC".
    /// </summary>
    [EnumMember(Value = "FDIC")]
    [IsoId("_5HP90KIUEeS6IulNYwkZBg")]
    [Description(@"Failed Bank, FDIC Assumed.")]
    FDIC,
    
    /// <summary>
    /// Pledged Position.
    /// Encoded/decoded by serializers as "PLEG".
    /// </summary>
    [EnumMember(Value = "PLEG")]
    [IsoId("_J63uMKIkEeS6IulNYwkZBg")]
    [Description(@"Pledged Position.")]
    PledgedPosition,
    
    /// <summary>
    /// Maturity for stock payment option.
    /// Encoded/decoded by serializers as "MSTK".
    /// </summary>
    [EnumMember(Value = "MSTK")]
    [IsoId("_gOgIUKIkEeS6IulNYwkZBg")]
    [Description(@"Maturity for stock payment option.")]
    MaturityForStockPaymentOption,
    
    /// <summary>
    /// Church bond not funded.
    /// Encoded/decoded by serializers as "CHBD".
    /// </summary>
    [EnumMember(Value = "CHBD")]
    [IsoId("_n01nkKIkEeS6IulNYwkZBg")]
    [Description(@"Church bond not funded.")]
    ChurchBondNotFunded,
    
    /// <summary>
    /// Funds held at Chase for OFAC.
    /// Encoded/decoded by serializers as "OFAC".
    /// </summary>
    [EnumMember(Value = "OFAC")]
    [IsoId("_vSQbYKIkEeS6IulNYwkZBg")]
    [Description(@"Funds held at Chase for OFAC.")]
    FundsHeldAtChaseForOFAC,
    
    /// <summary>
    /// Canadian depository inventory.
    /// Encoded/decoded by serializers as "CDIN".
    /// </summary>
    [EnumMember(Value = "CDIN")]
    [IsoId("_UgTloJEsEeajS_7NioJdVA")]
    [Description(@"Canadian depository inventory.")]
    CanadianDepositoryInventory,
    
}
