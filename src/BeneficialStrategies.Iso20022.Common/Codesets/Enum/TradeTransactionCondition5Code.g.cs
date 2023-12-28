﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradeTransactionCondition5Code.  ISO2002 ID# _Y_FjgEc9EeaBWtcfqEyXyw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the conditions under which the order/trade is to be/was executed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y_FjgEc9EeaBWtcfqEyXyw")]
[Description(@"Specifies the conditions under which the order/trade is to be/was executed.")]
[DerivedFrom(typeof(TradeTransactionConditionCode))]
public enum TradeTransactionCondition5Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ExCoupon".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_iNUDEV-mEeavlvCtut5bgg")]
    [Description(@"??")]
    ExCoupon,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CumCoupon".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_iYxsMV-mEeavlvCtut5bgg")]
    [Description(@"??")]
    CumCoupon,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TradeTransactionCondition5CodeMetadataExtensions
{
    private static readonly TradeTransactionCondition5CodeDropdownSource _dropdownSource = new TradeTransactionCondition5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITradeTransactionCondition5CodeDropdownRow GetMetadata(this TradeTransactionCondition5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

