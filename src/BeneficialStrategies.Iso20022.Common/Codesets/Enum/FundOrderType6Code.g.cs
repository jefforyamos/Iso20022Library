﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FundOrderType6Code.  ISO2002 ID# _l7GIIBKuEeKj15WxqwlXPw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the category of the investment fund order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_l7GIIBKuEeKj15WxqwlXPw")]
[Description(@"Specifies the category of the investment fund order.")]
[DerivedFrom(typeof(FundOrderTypeCode))]
public enum FundOrderType6Code
{
    /// <summary>
    /// All type of orders.
    /// Encoded/decoded by serializers as "ALLL".
    /// </summary>
    [EnumMember(Value = "ALLL")]
    [IsoId("_oC2e0RKuEeKj15WxqwlXPw")]
    [Description(@"All type of orders.")]
    All = FundOrderTypeCode.All, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order is a redemption.
    /// Encoded/decoded by serializers as "REDM".
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_oh_48RKuEeKj15WxqwlXPw")]
    [Description(@"Investment fund order is a redemption.")]
    Redemption = FundOrderTypeCode.Redemption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order is a subscription.
    /// Encoded/decoded by serializers as "SUBS".
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_o6vJERKuEeKj15WxqwlXPw")]
    [Description(@"Investment fund order is a subscription.")]
    Subscription = FundOrderTypeCode.Subscription, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Switch out or switch from.
    /// Encoded/decoded by serializers as "SWII".
    /// </summary>
    [EnumMember(Value = "SWII")]
    [IsoId("_pct0wRKuEeKj15WxqwlXPw")]
    [Description(@"Switch out or switch from.")]
    SwitchFrom = FundOrderTypeCode.SwitchFrom, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Switch in or switch to.
    /// Encoded/decoded by serializers as "SWIO".
    /// </summary>
    [EnumMember(Value = "SWIO")]
    [IsoId("_pt_yARKuEeKj15WxqwlXPw")]
    [Description(@"Switch in or switch to.")]
    SwitchTo = FundOrderTypeCode.SwitchTo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer in.
    /// Encoded/decoded by serializers as "TRAI".
    /// </summary>
    [EnumMember(Value = "TRAI")]
    [IsoId("_p4ubURKuEeKj15WxqwlXPw")]
    [Description(@"Transfer in.")]
    TransferIn = FundOrderTypeCode.TransferIn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer out.
    /// Encoded/decoded by serializers as "TRAO".
    /// </summary>
    [EnumMember(Value = "TRAO")]
    [IsoId("_qBEfARKuEeKj15WxqwlXPw")]
    [Description(@"Transfer out.")]
    TransferOut = FundOrderTypeCode.TransferOut, // same ordinal as derivation source for type conversions
    
}
