﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SpecialCollateral1Code.  ISO2002 ID# _crADcJf_EeSfnc-VXAEapg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the collateral type against which all repurchase agreements are conducted.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_crADcJf_EeSfnc-VXAEapg")]
[Description(@"Specifies the collateral type against which all repurchase agreements are conducted.")]
[DerivedFrom(typeof(SpecialCollateralCode))]
public enum SpecialCollateral1Code
{
    /// <summary>
    /// Identifies that all repurchase agreements are conducted against general collateral.
    /// Encoded/decoded by serializers as "GENE".
    /// </summary>
    [EnumMember(Value = "GENE")]
    [IsoId("_gWcacZf_EeSfnc-VXAEapg")]
    [Description(@"Identifies that all repurchase agreements are conducted against general collateral.")]
    GeneralCollateral = SpecialCollateralCode.GeneralCollateral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies that all repurchase agreements are conducted against special collateral.
    /// Encoded/decoded by serializers as "SPEC".
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("_gb8lgZf_EeSfnc-VXAEapg")]
    [Description(@"Identifies that all repurchase agreements are conducted against special collateral.")]
    SpecialCollateral = SpecialCollateralCode.SpecialCollateral, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SpecialCollateral1CodeMetadataExtensions
{
    private static readonly SpecialCollateral1CodeDropdownSource _dropdownSource = new SpecialCollateral1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISpecialCollateral1CodeDropdownRow GetMetadata(this SpecialCollateral1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


