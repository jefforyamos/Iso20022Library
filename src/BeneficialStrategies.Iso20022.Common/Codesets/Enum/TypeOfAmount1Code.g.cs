﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfAmount1Code.  ISO2002 ID# _TUJ9MwEcEeCQm6a_G2yO_w_-427781044.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Qualifies the amount associated with the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TUJ9MwEcEeCQm6a_G2yO_w_-427781044")]
[Description(@"Qualifies the amount associated with the transaction.")]
[DerivedFrom(typeof(TypeOfAmountCode))]
public enum TypeOfAmount1Code
{
    /// <summary>
    /// Actual amount.
    /// Encoded/decoded by serializers as "ACTL".
    /// </summary>
    [EnumMember(Value = "ACTL")]
    [IsoId("_TUJ9NAEcEeCQm6a_G2yO_w_1589618959")]
    [Description(@"Actual amount.")]
    Actual = TypeOfAmountCode.Actual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Estimated amount (the final amount could be above or below).
    /// Encoded/decoded by serializers as "ESTM".
    /// </summary>
    [EnumMember(Value = "ESTM")]
    [IsoId("_TUJ9NQEcEeCQm6a_G2yO_w_-630255646")]
    [Description(@"Estimated amount (the final amount could be above or below).")]
    Estimated = TypeOfAmountCode.Estimated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maximum amount (the final amount must be less or equal).
    /// Encoded/decoded by serializers as "MAXI".
    /// </summary>
    [EnumMember(Value = "MAXI")]
    [IsoId("_TUJ9NgEcEeCQm6a_G2yO_w_1200667523")]
    [Description(@"Maximum amount (the final amount must be less or equal).")]
    Maximum = TypeOfAmountCode.Maximum, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Default amount.
    /// Encoded/decoded by serializers as "DFLT".
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_TUJ9NwEcEeCQm6a_G2yO_w_-1157074600")]
    [Description(@"Default amount.")]
    Default = TypeOfAmountCode.Default, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Replacement amount.
    /// Encoded/decoded by serializers as "RPLT".
    /// </summary>
    [EnumMember(Value = "RPLT")]
    [IsoId("_TUJ9OAEcEeCQm6a_G2yO_w_-952745682")]
    [Description(@"Replacement amount.")]
    Replacement = TypeOfAmountCode.Replacement, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeOfAmount1CodeMetadataExtensions
{
    private static readonly TypeOfAmount1CodeDropdownSource _dropdownSource = new TypeOfAmount1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeOfAmount1CodeDropdownRow GetMetadata(this TypeOfAmount1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


