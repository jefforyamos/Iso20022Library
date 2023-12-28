﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RepurchaseType3Code.  ISO2002 ID# _ZTosldp-Ed-ak6NoX_4Aeg_561015299.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of repurchase transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZTosldp-Ed-ak6NoX_4Aeg_561015299")]
[Description(@"Specifies the type of repurchase transaction.")]
[DerivedFrom(typeof(RepurchaseTypeCode))]
public enum RepurchaseType3Code
{
    /// <summary>
    /// Relates to a Swap/Substitution.
    /// Encoded/decoded by serializers as "Swap".
    /// </summary>
    [EnumMember(Value = "CADJ")]
    [IsoId("_ZTosltp-Ed-ak6NoX_4Aeg_561015301")]
    [Description(@"Relates to a Swap/Substitution.")]
    Swap,
    
    /// <summary>
    /// Relates to a change in the closing or maturity date.
    /// Encoded/decoded by serializers as "RepurchaseCall".
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_ZTosl9p-Ed-ak6NoX_4Aeg_561015330")]
    [Description(@"Relates to a change in the closing or maturity date.")]
    RepurchaseCall,
    
    /// <summary>
    /// Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.
    /// Encoded/decoded by serializers as "Pairoff".
    /// </summary>
    [EnumMember(Value = "PAIR")]
    [IsoId("_ZTosmNp-Ed-ak6NoX_4Aeg_561015331")]
    [Description(@"Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.")]
    Pairoff,
    
    /// <summary>
    /// Is part of a pair-off.
    /// Encoded/decoded by serializers as "RepoRate".
    /// </summary>
    [EnumMember(Value = "RATE")]
    [IsoId("_ZTosmdp-Ed-ak6NoX_4Aeg_561015360")]
    [Description(@"Is part of a pair-off.")]
    RepoRate,
    
    /// <summary>
    /// Relates to a repo rollover of a position extending the closing or maturity date.
    /// Encoded/decoded by serializers as "Rollover".
    /// </summary>
    [EnumMember(Value = "ROLP")]
    [IsoId("_ZTx2gNp-Ed-ak6NoX_4Aeg_561015361")]
    [Description(@"Relates to a repo rollover of a position extending the closing or maturity date.")]
    Rollover,
    
    /// <summary>
    /// Relates to a repo rollover of a position extending the closing or maturity date.
    /// Encoded/decoded by serializers as "TopUp".
    /// </summary>
    [EnumMember(Value = "TOPU")]
    [IsoId("_ZTx2gdp-Ed-ak6NoX_4Aeg_561015362")]
    [Description(@"Relates to a repo rollover of a position extending the closing or maturity date.")]
    TopUp,
    
    /// <summary>
    /// Relates to a repo rollover of a position extending the closing or maturity date.
    /// Encoded/decoded by serializers as "Withdrawal".
    /// </summary>
    [EnumMember(Value = "WTHD")]
    [IsoId("_ZTx2gtp-Ed-ak6NoX_4Aeg_561015608")]
    [Description(@"Relates to a repo rollover of a position extending the closing or maturity date.")]
    Withdrawal,
    
    /// <summary>
    /// Relates to a principal adjustment.
    /// Encoded/decoded by serializers as "PrincipalExposureAdjustment".
    /// </summary>
    [EnumMember(Value = "PADJ")]
    [IsoId("_ZTx2g9p-Ed-ak6NoX_4Aeg_777121086")]
    [Description(@"Relates to a principal adjustment.")]
    PrincipalExposureAdjustment,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RepurchaseType3CodeMetadataExtensions
{
    private static readonly RepurchaseType3CodeDropdownSource _dropdownSource = new RepurchaseType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRepurchaseType3CodeDropdownRow GetMetadata(this RepurchaseType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


