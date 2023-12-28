﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SpecialCollateralCode.  ISO2002 ID# _Q4dpgJf_EeSfnc-VXAEapg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the collateral type against which all repurchase agreements are conducted.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Q4dpgJf_EeSfnc-VXAEapg")]
[Description(@"Specifies the collateral type against which all repurchase agreements are conducted.")]
[Derivations(typeof(SpecialCollateral1Code),typeof(SpecialCollateral2Code))]
// External derivations that should be provided by the proper interface are: 
public enum SpecialCollateralCode
{
    /// <summary>
    /// Identifies that all repurchase agreements are conducted against general collateral.
    /// Encoded/decoded by serializers as "GENE".
    /// </summary>
    [EnumMember(Value = "GENE")]
    [IsoId("_TACaAJf_EeSfnc-VXAEapg")]
    [Description(@"Identifies that all repurchase agreements are conducted against general collateral.")]
    GeneralCollateral,
    
    /// <summary>
    /// Identifies that all repurchase agreements are conducted against special collateral.
    /// Encoded/decoded by serializers as "SPEC".
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("_Tb3aYJf_EeSfnc-VXAEapg")]
    [Description(@"Identifies that all repurchase agreements are conducted against special collateral.")]
    SpecialCollateral,
    
    /// <summary>
    /// Identifies that this is a securities lending transaction, made of repurchase agreements and reverse repurchase agreements versus cash.
    /// Encoded/decoded by serializers as "MRRP".
    /// </summary>
    [EnumMember(Value = "MRRP")]
    [IsoId("_UKZfkMEaEea7jLfvGi1PDw")]
    [Description(@"Identifies that this is a securities lending transaction, made of repurchase agreements and reverse repurchase agreements versus cash.")]
    MatchedAndReverseRepurchaseAgreement,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SpecialCollateralCodeMetadataExtensions
{
    private static readonly SpecialCollateralCodeDropdownSource _dropdownSource = new SpecialCollateralCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISpecialCollateralCodeDropdownRow GetMetadata(this SpecialCollateralCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


