﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RepurchaseTypeCode.  ISO2002 ID# _ZT7ngNp-Ed-ak6NoX_4Aeg_605345255.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Relates to a principal adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZT7ngNp-Ed-ak6NoX_4Aeg_605345255")]
[Description(@"Relates to a principal adjustment.")]
public enum RepurchaseTypeCode
{
    /// <summary>
    /// Relates to a Swap/Substitution.
    /// Encoded/decoded by serializers as "CADJ".
    /// </summary>
    [EnumMember(Value = "CADJ")]
    [IsoId("_ZT7ngdp-Ed-ak6NoX_4Aeg_605345257")]
    [Description(@"Relates to a Swap/Substitution.")]
    Swap,
    
    /// <summary>
    /// Relates to a change in the closing or maturity date.
    /// Encoded/decoded by serializers as "CALL".
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_ZT7ngtp-Ed-ak6NoX_4Aeg_605345286")]
    [Description(@"Relates to a change in the closing or maturity date.")]
    RepurchaseCall,
    
    /// <summary>
    /// Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.
    /// Encoded/decoded by serializers as "PAIR".
    /// </summary>
    [EnumMember(Value = "PAIR")]
    [IsoId("_ZT7ng9p-Ed-ak6NoX_4Aeg_605345287")]
    [Description(@"Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.")]
    Pairoff,
    
    /// <summary>
    /// Is part of a pair-off.
    /// Encoded/decoded by serializers as "RATE".
    /// </summary>
    [EnumMember(Value = "RATE")]
    [IsoId("_ZT7nhNp-Ed-ak6NoX_4Aeg_605345316")]
    [Description(@"Is part of a pair-off.")]
    RepoRate,
    
    /// <summary>
    /// Relates to a repo rollover of a position extending the closing or maturity date.
    /// Encoded/decoded by serializers as "ROLP".
    /// </summary>
    [EnumMember(Value = "ROLP")]
    [IsoId("_ZT7nhdp-Ed-ak6NoX_4Aeg_605345317")]
    [Description(@"Relates to a repo rollover of a position extending the closing or maturity date.")]
    Rollover,
    
    /// <summary>
    /// Relates to a repo rollover of a position extending the closing or maturity date.
    /// Encoded/decoded by serializers as "TOPU".
    /// </summary>
    [EnumMember(Value = "TOPU")]
    [IsoId("_ZT7nhtp-Ed-ak6NoX_4Aeg_605345564")]
    [Description(@"Relates to a repo rollover of a position extending the closing or maturity date.")]
    TopUp,
    
    /// <summary>
    /// Relates to a repo rollover of a position extending the closing or maturity date.
    /// Encoded/decoded by serializers as "WTHD".
    /// </summary>
    [EnumMember(Value = "WTHD")]
    [IsoId("_ZT7nh9p-Ed-ak6NoX_4Aeg_605345565")]
    [Description(@"Relates to a repo rollover of a position extending the closing or maturity date.")]
    Withdrawal,
    
    /// <summary>
    /// Relates to a principal adjustment.
    /// Encoded/decoded by serializers as "PADJ".
    /// </summary>
    [EnumMember(Value = "PADJ")]
    [IsoId("_ZT7niNp-Ed-ak6NoX_4Aeg_690308694")]
    [Description(@"Relates to a principal adjustment.")]
    PrincipalExposureAdjustment,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RepurchaseTypeCodeMetadataExtensions
{
    private static readonly RepurchaseTypeCodeDropdownSource _dropdownSource = new RepurchaseTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRepurchaseTypeCodeDropdownRow GetMetadata(this RepurchaseTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


