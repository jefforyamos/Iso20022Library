﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DTCUnallocatedAdjustmentReason1Code.  ISO2002 ID# _-HWBAGiLEeOdXoiw6mfXMw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// DTC Unallocated reason codes for payment adjustments.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-HWBAGiLEeOdXoiw6mfXMw")]
[Description(@"DTC Unallocated reason codes for payment adjustments.")]
[DerivedFrom(typeof(DTCUnallocatedAdjustmentReasonCode))]
public enum DTCUnallocatedAdjustmentReason1Code
{
    /// <summary>
    /// Incorrect announcement.
    /// Encoded/decoded by serializers as "BadAnnouncement".
    /// </summary>
    [EnumMember(Value = "ANNG")]
    [IsoId("_O32pcWiPEeOdXoiw6mfXMw")]
    [Description(@"Incorrect announcement.")]
    BadAnnouncement,
    
    /// <summary>
    /// Incorrect payable date.
    /// Encoded/decoded by serializers as "BadPayableDate".
    /// </summary>
    [EnumMember(Value = "BDPD")]
    [IsoId("_O6PPEWiPEeOdXoiw6mfXMw")]
    [Description(@"Incorrect payable date.")]
    BadPayableDate,
    
    /// <summary>
    /// Cash rate for allocation is zero.
    /// Encoded/decoded by serializers as "CashRateUnknown".
    /// </summary>
    [EnumMember(Value = "CSHR")]
    [IsoId("_O8w-oWiPEeOdXoiw6mfXMw")]
    [Description(@"Cash rate for allocation is zero.")]
    CashRateUnknown,
    
    /// <summary>
    /// Cash rate for allocation is zero.
    /// Encoded/decoded by serializers as "CashRateZero".
    /// </summary>
    [EnumMember(Value = "CSHU")]
    [IsoId("_O_JkQWiPEeOdXoiw6mfXMw")]
    [Description(@"Cash rate for allocation is zero.")]
    CashRateZero,
    
    /// <summary>
    /// Payment is conditional and conditions have not been met yet.
    /// Encoded/decoded by serializers as "ConditionalPayment".
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("_PG4j8WiPEeOdXoiw6mfXMw")]
    [Description(@"Payment is conditional and conditions have not been met yet.")]
    ConditionalPayment,
    
    /// <summary>
    /// Issue is in default.
    /// Encoded/decoded by serializers as "Default".
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_PJRJkWiPEeOdXoiw6mfXMw")]
    [Description(@"Issue is in default.")]
    Default,
    
    /// <summary>
    /// Holiday in country of origin.
    /// Encoded/decoded by serializers as "HolidayInCountryOfOrigin".
    /// </summary>
    [EnumMember(Value = "HICO")]
    [IsoId("_PVm8cWiPEeOdXoiw6mfXMw")]
    [Description(@"Holiday in country of origin.")]
    HolidayInCountryOfOrigin,
    
    /// <summary>
    /// Insufficient funds were received from the agent.
    /// Encoded/decoded by serializers as "InsufficientFundsReceivedFromAgent".
    /// </summary>
    [EnumMember(Value = "MASF")]
    [IsoId("_PX_iEWiPEeOdXoiw6mfXMw")]
    [Description(@"Insufficient funds were received from the agent.")]
    InsufficientFundsReceivedFromAgent,
    
    /// <summary>
    /// Issue was not funded.
    /// Encoded/decoded by serializers as "IssueNotFunded".
    /// </summary>
    [EnumMember(Value = "ISNF")]
    [IsoId("_PfR10WiPEeOdXoiw6mfXMw")]
    [Description(@"Issue was not funded.")]
    IssueNotFunded,
    
    /// <summary>
    /// Issue is not maturing.
    /// Encoded/decoded by serializers as "IssueNotMaturing".
    /// </summary>
    [EnumMember(Value = "NMAT")]
    [IsoId("_Pmt6kWiPEeOdXoiw6mfXMw")]
    [Description(@"Issue is not maturing.")]
    IssueNotMaturing,
    
    /// <summary>
    /// Issues funded and/or identified after the cycle cut off.
    /// Encoded/decoded by serializers as "AfterCycleCutOff".
    /// </summary>
    [EnumMember(Value = "LFID")]
    [IsoId("_Pt3EYWiPEeOdXoiw6mfXMw")]
    [Description(@"Issues funded and/or identified after the cycle cut off.")]
    AfterCycleCutOff,
    
    /// <summary>
    /// Item is pending.
    /// Encoded/decoded by serializers as "ItemIsPending".
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_PwYz8WiPEeOdXoiw6mfXMw")]
    [Description(@"Item is pending.")]
    ItemIsPending,
    
    /// <summary>
    /// Funds were not received by the agent.
    /// Encoded/decoded by serializers as "FundsNotReceivedByAgent".
    /// </summary>
    [EnumMember(Value = "ANFI")]
    [IsoId("_QjuVYWiPEeOdXoiw6mfXMw")]
    [Description(@"Funds were not received by the agent.")]
    FundsNotReceivedByAgent,
    
    /// <summary>
    /// Issue is being liquidated.
    /// Encoded/decoded by serializers as "Liquidation".
    /// </summary>
    [EnumMember(Value = "LIQD")]
    [IsoId("_Q5cGsWiPEeOdXoiw6mfXMw")]
    [Description(@"Issue is being liquidated.")]
    Liquidation,
    
    /// <summary>
    /// Notional balance pincipal will not be paid.
    /// Encoded/decoded by serializers as "NotionalBalance".
    /// </summary>
    [EnumMember(Value = "NOTL")]
    [IsoId("_Q70sUWiPEeOdXoiw6mfXMw")]
    [Description(@"Notional balance pincipal will not be paid.")]
    NotionalBalance,
    
    /// <summary>
    /// Reserved for new user defined reason codes.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_RDHAEWiPEeOdXoiw6mfXMw")]
    [Description(@"Reserved for new user defined reason codes.")]
    Other,
    
    /// <summary>
    /// Paid upon receipt of check.
    /// Encoded/decoded by serializers as "PaidUponReceiptOfCheck".
    /// </summary>
    [EnumMember(Value = "PCHK")]
    [IsoId("_RKZ64WiPEeOdXoiw6mfXMw")]
    [Description(@"Paid upon receipt of check.")]
    PaidUponReceiptOfCheck,
    
    /// <summary>
    /// Pending conversion of funds.
    /// Encoded/decoded by serializers as "PendingConversionOfFunds".
    /// </summary>
    [EnumMember(Value = "RRFX")]
    [IsoId("_RMx5cWiPEeOdXoiw6mfXMw")]
    [Description(@"Pending conversion of funds.")]
    PendingConversionOfFunds,
    
    /// <summary>
    /// Recapitalization. Issue not funded.
    /// Encoded/decoded by serializers as "RecapitalizationNotFunded".
    /// </summary>
    [EnumMember(Value = "RCNF")]
    [IsoId("_RPKfEWiPEeOdXoiw6mfXMw")]
    [Description(@"Recapitalization. Issue not funded.")]
    RecapitalizationNotFunded,
    
    /// <summary>
    /// Redemption of rates. Issue not funded.
    /// Encoded/decoded by serializers as "RedemptionOfRatesNotYetFunded".
    /// </summary>
    [EnumMember(Value = "RRNF")]
    [IsoId("_RWcy0WiPEeOdXoiw6mfXMw")]
    [Description(@"Redemption of rates. Issue not funded.")]
    RedemptionOfRatesNotYetFunded,
    
    /// <summary>
    /// Released pledge position.
    /// Encoded/decoded by serializers as "ReleasedPledgePosition".
    /// </summary>
    [EnumMember(Value = "RPLG")]
    [IsoId("_SOGMgWiPEeOdXoiw6mfXMw")]
    [Description(@"Released pledge position.")]
    ReleasedPledgePosition,
    
    /// <summary>
    /// Sale of asset. Issue not funded.
    /// Encoded/decoded by serializers as "SaleOfAssetsNotYetFunded".
    /// </summary>
    [EnumMember(Value = "SANF")]
    [IsoId("_SQn8EWiPEeOdXoiw6mfXMw")]
    [Description(@"Sale of asset. Issue not funded.")]
    SaleOfAssetsNotYetFunded,
    
    /// <summary>
    /// Same day position capture.
    /// Encoded/decoded by serializers as "SameDayPositionCapture".
    /// </summary>
    [EnumMember(Value = "SDPC")]
    [IsoId("_STAhsWiPEeOdXoiw6mfXMw")]
    [Description(@"Same day position capture.")]
    SameDayPositionCapture,
    
    /// <summary>
    /// Special distribution. Issue not funded.
    /// Encoded/decoded by serializers as "SpecialDistributionNotYetFunded".
    /// </summary>
    [EnumMember(Value = "SPNF")]
    [IsoId("_SaJrgWiPEeOdXoiw6mfXMw")]
    [Description(@"Special distribution. Issue not funded.")]
    SpecialDistributionNotYetFunded,
    
    /// <summary>
    /// Specific issues have been suppressed.
    /// Encoded/decoded by serializers as "SpecificIssuesSuppressed".
    /// </summary>
    [EnumMember(Value = "PUVF")]
    [IsoId("_SchqEWiPEeOdXoiw6mfXMw")]
    [Description(@"Specific issues have been suppressed.")]
    SpecificIssuesSuppressed,
    
    /// <summary>
    /// Rate is not final. Rate is approximate.
    /// Encoded/decoded by serializers as "ApproximateRate".
    /// </summary>
    [EnumMember(Value = "APRR")]
    [IsoId("_Sjqz4WiPEeOdXoiw6mfXMw")]
    [Description(@"Rate is not final. Rate is approximate.")]
    ApproximateRate,
    
    /// <summary>
    /// Company is taking a 30 day grace period.
    /// Encoded/decoded by serializers as "GracePeriod".
    /// </summary>
    [EnumMember(Value = "SAGA")]
    [IsoId("_SmDZgWiPEeOdXoiw6mfXMw")]
    [Description(@"Company is taking a 30 day grace period.")]
    GracePeriod,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DTCUnallocatedAdjustmentReason1CodeMetadataExtensions
{
    private static readonly DTCUnallocatedAdjustmentReason1CodeDropdownSource _dropdownSource = new DTCUnallocatedAdjustmentReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDTCUnallocatedAdjustmentReason1CodeDropdownRow GetMetadata(this DTCUnallocatedAdjustmentReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


