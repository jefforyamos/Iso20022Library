﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DTCUnallocatedAdjustmentReasonV2Code.  ISO2002 ID# _n3w1hsMQEee-Vv_OVx0uAQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// DTC Unallocated reason codes for payment adjustments.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_n3w1hsMQEee-Vv_OVx0uAQ")]
[Description(@"DTC Unallocated reason codes for payment adjustments.")]
public enum DTCUnallocatedAdjustmentReasonV2Code
{
    /// <summary>
    /// Company is taking a 30 day grace period.
    /// </summary>
    [EnumMember(Value = "SAGA")]
    [IsoId("_n3w1i8MQEee-Vv_OVx0uAQ")]
    [Description(@"Company is taking a 30 day grace period.")]
    SAGA,
    
    /// <summary>
    /// Rate is not final. Rate is approximate.
    /// </summary>
    [EnumMember(Value = "APRR")]
    [IsoId("_n3xcc8MQEee-Vv_OVx0uAQ")]
    [Description(@"Rate is not final. Rate is approximate.")]
    APRR,
    
    /// <summary>
    /// Incorrect announcement.
    /// </summary>
    [EnumMember(Value = "ANNG")]
    [IsoId("_n3w1kcMQEee-Vv_OVx0uAQ")]
    [Description(@"Incorrect announcement.")]
    ANNG,
    
    /// <summary>
    /// Incorrect payable date.
    /// </summary>
    [EnumMember(Value = "BDPD")]
    [IsoId("_n3w1oMMQEee-Vv_OVx0uAQ")]
    [Description(@"Incorrect payable date.")]
    BDPD,
    
    /// <summary>
    /// Cash rate for allocation is zero.
    /// </summary>
    [EnumMember(Value = "CSHR")]
    [IsoId("_n3w1kMMQEee-Vv_OVx0uAQ")]
    [Description(@"Cash rate for allocation is zero.")]
    CSHR,
    
    /// <summary>
    /// Cash rate for allocation is zero.
    /// </summary>
    [EnumMember(Value = "CSHU")]
    [IsoId("_n3w1ncMQEee-Vv_OVx0uAQ")]
    [Description(@"Cash rate for allocation is zero.")]
    CSHU,
    
    /// <summary>
    /// Payment is conditional and conditions have not been met yet.
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("_n3xcdsMQEee-Vv_OVx0uAQ")]
    [Description(@"Payment is conditional and conditions have not been met yet.")]
    COND,
    
    /// <summary>
    /// Issue is in default.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_n3w1ksMQEee-Vv_OVx0uAQ")]
    [Description(@"Issue is in default.")]
    DFLT,
    
    /// <summary>
    /// Funds were not received by the agent.
    /// </summary>
    [EnumMember(Value = "ANFI")]
    [IsoId("_n3w1ocMQEee-Vv_OVx0uAQ")]
    [Description(@"Funds were not received by the agent.")]
    ANFI,
    
    /// <summary>
    /// Reason is due to holiday in country of origin.
    /// </summary>
    [EnumMember(Value = "HICO")]
    [IsoId("_n3w1isMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to holiday in country of origin.")]
    HICO,
    
    /// <summary>
    /// Reason is due to insufficient funds received from the agent.
    /// </summary>
    [EnumMember(Value = "MASF")]
    [IsoId("_n3xccsMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to insufficient funds received from the agent.")]
    MASF,
    
    /// <summary>
    /// Reason is due to issue that was not funded.
    /// </summary>
    [EnumMember(Value = "ISNF")]
    [IsoId("_n3w1h8MQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to issue that was not funded.")]
    ISNF,
    
    /// <summary>
    /// Reason is due to issue that is not maturing.
    /// </summary>
    [EnumMember(Value = "NMAT")]
    [IsoId("_n3xccMMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to issue that is not maturing.")]
    NMAT,
    
    /// <summary>
    /// Issues funded and/or identified after the cycle cut off.
    /// </summary>
    [EnumMember(Value = "LFID")]
    [IsoId("_n3w1lcMQEee-Vv_OVx0uAQ")]
    [Description(@"Issues funded and/or identified after the cycle cut off.")]
    LFID,
    
    /// <summary>
    /// Reason is due to items pending.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_n3w1nsMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to items pending.")]
    PEND,
    
    /// <summary>
    /// Issue is being liquidated.
    /// </summary>
    [EnumMember(Value = "LIQD")]
    [IsoId("_n3w1msMQEee-Vv_OVx0uAQ")]
    [Description(@"Issue is being liquidated.")]
    LIQD,
    
    /// <summary>
    /// Notional balance principal will not be paid.
    /// </summary>
    [EnumMember(Value = "NOTL")]
    [IsoId("_n3w1jMMQEee-Vv_OVx0uAQ")]
    [Description(@"Notional balance principal will not be paid.")]
    NOTL,
    
    /// <summary>
    /// Reserved for new user defined reason codes.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_n3w1icMQEee-Vv_OVx0uAQ")]
    [Description(@"Reserved for new user defined reason codes.")]
    OTHR,
    
    /// <summary>
    /// Reason is due paid upon receipt of check.
    /// </summary>
    [EnumMember(Value = "PCHK")]
    [IsoId("_n3w1n8MQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due paid upon receipt of check.")]
    PCHK,
    
    /// <summary>
    /// Reason is due to pending conversion of funds.
    /// </summary>
    [EnumMember(Value = "RRFX")]
    [IsoId("_n3w1lMMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to pending conversion of funds.")]
    RRFX,
    
    /// <summary>
    /// Reason is due to recapitalisation and issue not funded.
    /// </summary>
    [EnumMember(Value = "RCNF")]
    [IsoId("_n3w1jsMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to recapitalisation and issue not funded.")]
    RCNF,
    
    /// <summary>
    /// Reason is that due to redemption of rates, issue was not funded.
    /// </summary>
    [EnumMember(Value = "RRNF")]
    [IsoId("_n3w1m8MQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is that due to redemption of rates, issue was not funded.")]
    RRNF,
    
    /// <summary>
    /// Reason is due to released pledge position.
    /// </summary>
    [EnumMember(Value = "RPLG")]
    [IsoId("_n3w1mcMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to released pledge position.")]
    RPLG,
    
    /// <summary>
    /// Reason is that due to sale of asset, issue was not funded.
    /// </summary>
    [EnumMember(Value = "SANF")]
    [IsoId("_n3w1mMMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is that due to sale of asset, issue was not funded.")]
    SANF,
    
    /// <summary>
    /// Reason is due to same day position capture.
    /// </summary>
    [EnumMember(Value = "SDPC")]
    [IsoId("_n3w1nMMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to same day position capture.")]
    SDPC,
    
    /// <summary>
    /// Reason is due to special distribution and the issue was not funded.
    /// </summary>
    [EnumMember(Value = "SPNF")]
    [IsoId("_n3xcccMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to special distribution and the issue was not funded.")]
    SPNF,
    
    /// <summary>
    /// Specific issues have been suppressed.
    /// </summary>
    [EnumMember(Value = "PUVF")]
    [IsoId("_n3w1osMQEee-Vv_OVx0uAQ")]
    [Description(@"Specific issues have been suppressed.")]
    PUVF,
    
    /// <summary>
    /// Reason is due to a call rescinded.
    /// </summary>
    [EnumMember(Value = "RESC")]
    [IsoId("_n3w1jcMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to a call rescinded.")]
    RESC,
    
    /// <summary>
    /// Reason is due to a CD accelerated maturity.
    /// </summary>
    [EnumMember(Value = "ERLY")]
    [IsoId("_n3w1j8MQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to a CD accelerated maturity.")]
    ERLY,
    
    /// <summary>
    /// Reason is due to a CHIPS Payment.
    /// </summary>
    [EnumMember(Value = "CHIP")]
    [IsoId("_n3xcd8MQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to a CHIPS Payment.")]
    CHIP,
    
    /// <summary>
    /// Reason is due to a five day grace period.
    /// </summary>
    [EnumMember(Value = "FVDG")]
    [IsoId("_n3w1lsMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to a five day grace period.")]
    FVDG,
    
    /// <summary>
    /// Reason is due to a failed bank; Federal Deposit Insurance Corporation assumed.
    /// </summary>
    [EnumMember(Value = "FDIC")]
    [IsoId("_n3w1iMMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to a failed bank; Federal Deposit Insurance Corporation assumed.")]
    FDIC,
    
    /// <summary>
    /// Reason is due to pledged position.
    /// </summary>
    [EnumMember(Value = "PLEG")]
    [IsoId("_n3xcdMMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to pledged position.")]
    PLEG,
    
    /// <summary>
    /// Reason is due to maturity for stock payment option.
    /// </summary>
    [EnumMember(Value = "MSTK")]
    [IsoId("_n3xcdcMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to maturity for stock payment option.")]
    MSTK,
    
    /// <summary>
    /// Reason is due to a church bond not funded.
    /// </summary>
    [EnumMember(Value = "CHBD")]
    [IsoId("_n3w1k8MQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to a church bond not funded.")]
    CHBD,
    
    /// <summary>
    /// Reason is due to funds held at Chase for official foreign asset control.
    /// </summary>
    [EnumMember(Value = "OFAC")]
    [IsoId("_n3w1l8MQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to funds held at Chase for official foreign asset control.")]
    OFAC,
    
    /// <summary>
    /// Reason is due to a Canadian depository inventory.
    /// </summary>
    [EnumMember(Value = "CDIN")]
    [IsoId("_n3xceMMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to a Canadian depository inventory.")]
    CDIN,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DTCUnallocatedAdjustmentReasonV2CodeMetadataExtensions
{
    private static readonly DTCUnallocatedAdjustmentReasonV2CodeDropdownSource _dropdownSource = new DTCUnallocatedAdjustmentReasonV2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDTCUnallocatedAdjustmentReasonV2CodeDropdownRow GetMetadata(this DTCUnallocatedAdjustmentReasonV2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


