﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralQualityTypeCode.  ISO2002 ID# _LBcKoC7YEea1cMkrGwA6Gg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the classification of the risk of the security used as collateral.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_LBcKoC7YEea1cMkrGwA6Gg")]
[Description(@"Specifies the classification of the risk of the security used as collateral.")]
[Derivations(typeof(CollateralQualityType1Code))]
public enum CollateralQualityTypeCode
{
    /// <summary>
    /// Security that is classified as investment grade according to external ratings.
    /// Encoded/decoded by serializers as "INVG".
    /// </summary>
    [EnumMember(Value = "INVG")]
    [IsoId("_TmHhcC7YEea1cMkrGwA6Gg")]
    [Description(@"Security that is classified as investment grade according to external ratings.")]
    InvestmentGrade,
    
    /// <summary>
    /// Security with a rating different than investment grade.
    /// Encoded/decoded by serializers as "NIVG".
    /// </summary>
    [EnumMember(Value = "NIVG")]
    [IsoId("_Tnv5IC7YEea1cMkrGwA6Gg")]
    [Description(@"Security with a rating different than investment grade.")]
    NonInvestmentGrade,
    
    /// <summary>
    /// Security without a rating assigned.
    /// Encoded/decoded by serializers as "NOTR".
    /// </summary>
    [EnumMember(Value = "NOTR")]
    [IsoId("_TpY34C7YEea1cMkrGwA6Gg")]
    [Description(@"Security without a rating assigned.")]
    NotRated,
    
    /// <summary>
    /// Collateral quality type is not applicable.
    /// Encoded/decoded by serializers as "NOAP".
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("_mr6hEMkVEeeiAIB1i4AlQw")]
    [Description(@"Collateral quality type is not applicable.")]
    NonApplicable,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CollateralQualityTypeCodeMetadataExtensions
{
    private static readonly CollateralQualityTypeCodeDropdownSource _dropdownSource = new CollateralQualityTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICollateralQualityTypeCodeDropdownRow GetMetadata(this CollateralQualityTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


