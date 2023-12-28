﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExPostCostCalculationBasis1Code.  ISO2002 ID# _2nZSYJ9XEeqxTNfi5y7ywQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a basis for ex post calculations.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2nZSYJ9XEeqxTNfi5y7ywQ")]
[Description(@"Specifies a basis for ex post calculations.")]
[DerivedFrom(typeof(ExPostCostCalculationBasisCode))]
public enum ExPostCostCalculationBasis1Code
{
    /// <summary>
    /// Basic for cost calculation is fixed, that is calendar year.
    /// Encoded/decoded by serializers as "FixedBasis".
    /// </summary>
    [EnumMember(Value = "FIXB")]
    [IsoId("_QMy0sbVQEeqkjqDuFVh1-A")]
    [Description(@"Basic for cost calculation is fixed, that is calendar year.")]
    FixedBasis,
    
    /// <summary>
    /// Basis for cost calculation is rolling, that is, the last twelve months.
    /// Encoded/decoded by serializers as "RollingBasis".
    /// </summary>
    [EnumMember(Value = "ROLL")]
    [IsoId("_QTDNsbVQEeqkjqDuFVh1-A")]
    [Description(@"Basis for cost calculation is rolling, that is, the last twelve months.")]
    RollingBasis,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExPostCostCalculationBasis1CodeMetadataExtensions
{
    private static readonly ExPostCostCalculationBasis1CodeDropdownSource _dropdownSource = new ExPostCostCalculationBasis1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExPostCostCalculationBasis1CodeDropdownRow GetMetadata(this ExPostCostCalculationBasis1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


