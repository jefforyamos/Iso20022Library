﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FinancialAssetTypeCategoryCode.  ISO2002 ID# _m9ZG0PNBEeCuA5Tr22BnwA_-207567627.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Categorization of financial asset type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_m9ZG0PNBEeCuA5Tr22BnwA_-207567627")]
[Description(@"Categorization of financial asset type.")]
[Derivations(typeof(FinancialAssetTypeCategory1Code))]
// External derivations that should be provided by the proper interface are: 
public enum FinancialAssetTypeCategoryCode
{
    /// <summary>
    /// Balance attributed to equities.
    /// Encoded/decoded by serializers as "EQTY".
    /// </summary>
    [EnumMember(Value = "EQTY")]
    [IsoId("_m9ZG0fNBEeCuA5Tr22BnwA_1512048060")]
    [Description(@"Balance attributed to equities.")]
    Equities,
    
    /// <summary>
    /// Balance attributed to debt instruments.
    /// Encoded/decoded by serializers as "DEBT".
    /// </summary>
    [EnumMember(Value = "DEBT")]
    [IsoId("_m9ZG0vNBEeCuA5Tr22BnwA_-1310716183")]
    [Description(@"Balance attributed to debt instruments.")]
    DebtInstruments,
    
    /// <summary>
    /// Balance attributed to entitlements.
    /// Encoded/decoded by serializers as "ENTL".
    /// </summary>
    [EnumMember(Value = "ENTL")]
    [IsoId("_m9ZG0_NBEeCuA5Tr22BnwA_-492039069")]
    [Description(@"Balance attributed to entitlements.")]
    Entitlements,
    
    /// <summary>
    /// Balance attributed to derivatives.
    /// Encoded/decoded by serializers as "DERV".
    /// </summary>
    [EnumMember(Value = "DERV")]
    [IsoId("_m9ZG1PNBEeCuA5Tr22BnwA_2127191488")]
    [Description(@"Balance attributed to derivatives.")]
    Derivatives,
    
    /// <summary>
    /// Balance attributed to money market instruments.
    /// Encoded/decoded by serializers as "MMKT".
    /// </summary>
    [EnumMember(Value = "MMKT")]
    [IsoId("_m9ZG1fNBEeCuA5Tr22BnwA_-1923244113")]
    [Description(@"Balance attributed to money market instruments.")]
    MoneyMarket,
    
    /// <summary>
    /// Other financial asset type balance according to a different classification, which is not explictly defined.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_m9i30PNBEeCuA5Tr22BnwA_-878884426")]
    [Description(@"Other financial asset type balance according to a different classification, which is not explictly defined.")]
    Others,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FinancialAssetTypeCategoryCodeMetadataExtensions
{
    private static readonly FinancialAssetTypeCategoryCodeDropdownSource _dropdownSource = new FinancialAssetTypeCategoryCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFinancialAssetTypeCategoryCodeDropdownRow GetMetadata(this FinancialAssetTypeCategoryCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


