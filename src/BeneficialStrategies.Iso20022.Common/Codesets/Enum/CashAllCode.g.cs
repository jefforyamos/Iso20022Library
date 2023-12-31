﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CashAllCode.  ISO2002 ID# _7bsNUM4EEeiAhd-njDxLnA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if all assets are encashed and transferred as cash.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7bsNUM4EEeiAhd-njDxLnA")]
[Description(@"Specifies if all assets are encashed and transferred as cash.")]
[Derivations(typeof(CashAll1Code))]
// External derivations that should be provided by the proper interface are: 
public enum CashAllCode
{
    /// <summary>
    /// All assets in a portfolio should be liquidated and transferred as cash.
    /// Encoded/decoded by serializers as "LIQU".
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_GH54Ys4FEeiAhd-njDxLnA")]
    [Description(@"All assets in a portfolio should be liquidated and transferred as cash.")]
    LiquidatedTransferAsCash,
    
    /// <summary>
    /// All assets in a portfolio should not be liquidated and transferred as cash.
    /// Encoded/decoded by serializers as "NLIQ".
    /// </summary>
    [EnumMember(Value = "NLIQ")]
    [IsoId("_GH54Y84FEeiAhd-njDxLnA")]
    [Description(@"All assets in a portfolio should not be liquidated and transferred as cash.")]
    NotLiquidatedTransferAsCash,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CashAllCodeMetadataExtensions
{
    private static readonly CashAllCodeDropdownSource _dropdownSource = new CashAllCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICashAllCodeDropdownRow GetMetadata(this CashAllCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


