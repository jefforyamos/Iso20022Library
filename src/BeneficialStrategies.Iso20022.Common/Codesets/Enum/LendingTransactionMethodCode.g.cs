﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LendingTransactionMethodCode.  ISO2002 ID# __2_DY9ojEeC60axPepSq7g_1658762544.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Lending method applied to the securities financing contract.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__2_DY9ojEeC60axPepSq7g_1658762544")]
[Description(@"Lending method applied to the securities financing contract.")]
[Derivations(typeof(LendingTransactionMethod1Code))]
public enum LendingTransactionMethodCode
{
    /// <summary>
    /// Contract applies to a specific security only.
    /// Encoded/decoded by serializers as "ODTR".
    /// </summary>
    [EnumMember(Value = "ODTR")]
    [IsoId("__2_DZNojEeC60axPepSq7g_-1747965958")]
    [Description(@"Contract applies to a specific security only.")]
    OnDemandTrade,
    
    /// <summary>
    /// Contract applies to a number of different securities within the same pool/fund.
    /// Encoded/decoded by serializers as "EXTR".
    /// </summary>
    [EnumMember(Value = "EXTR")]
    [IsoId("__2_DZdojEeC60axPepSq7g_1202925115")]
    [Description(@"Contract applies to a number of different securities within the same pool/fund.")]
    ExclusiveTrade,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class LendingTransactionMethodCodeMetadataExtensions
{
    private static readonly LendingTransactionMethodCodeDropdownSource _dropdownSource = new LendingTransactionMethodCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ILendingTransactionMethodCodeDropdownRow GetMetadata(this LendingTransactionMethodCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


