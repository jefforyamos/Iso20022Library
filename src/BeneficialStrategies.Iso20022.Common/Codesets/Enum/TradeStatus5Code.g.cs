﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradeStatus5Code.  ISO2002 ID# _csiU4JK1EeKOmdt7wkELkg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a trade in a central matching and settlement system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_csiU4JK1EeKOmdt7wkELkg")]
[Description(@"Specifies the status of a trade in a central matching and settlement system.")]
[DerivedFrom(typeof(TradeStatusCode))]
public enum TradeStatus5Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Invalid".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_sFFzQZK1EeKOmdt7wkELkg")]
    [Description(@"??")]
    Invalid,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Matched".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_sUSF0ZK1EeKOmdt7wkELkg")]
    [Description(@"??")]
    Matched,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Amended".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_sg8o0ZK1EeKOmdt7wkELkg")]
    [Description(@"??")]
    Amended,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementMaturePending".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_syY-IZK1EeKOmdt7wkELkg")]
    [Description(@"??")]
    SettlementMaturePending,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotAuthorised".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tgbv4ZK1EeKOmdt7wkELkg")]
    [Description(@"??")]
    NotAuthorised,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Rejected".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uXbCQZK1EeKOmdt7wkELkg")]
    [Description(@"??")]
    Rejected,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Rescinded".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ufxF8ZK1EeKOmdt7wkELkg")]
    [Description(@"??")]
    Rescinded,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Settled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_vBJUsZK1EeKOmdt7wkELkg")]
    [Description(@"??")]
    Settled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementMemberAuthorised".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_x-GOAZK1EeKOmdt7wkELkg")]
    [Description(@"??")]
    SettlementMemberAuthorised,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementMemberNotAuthorised".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_yVCuYZK1EeKOmdt7wkELkg")]
    [Description(@"??")]
    SettlementMemberNotAuthorised,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Split".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_yva9QZK1EeKOmdt7wkELkg")]
    [Description(@"??")]
    Split,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Suspended".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zVamQZK1EeKOmdt7wkELkg")]
    [Description(@"??")]
    Suspended,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Unmatched".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zofTQZK1EeKOmdt7wkELkg")]
    [Description(@"??")]
    Unmatched,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SettlementMature".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_JAhRweKMEeKM3LYZSgb7xw")]
    [Description(@"??")]
    SettlementMature,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TradeStatus5CodeMetadataExtensions
{
    private static readonly TradeStatus5CodeDropdownSource _dropdownSource = new TradeStatus5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITradeStatus5CodeDropdownRow GetMetadata(this TradeStatus5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


