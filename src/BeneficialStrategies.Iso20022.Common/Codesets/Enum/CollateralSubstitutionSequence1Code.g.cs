﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralSubstitutionSequence1Code.  ISO2002 ID# _Yb5zVtp-Ed-ak6NoX_4Aeg_811875689.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether the collateral substitution request is new or updated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yb5zVtp-Ed-ak6NoX_4Aeg_811875689")]
[Description(@"Indicates whether the collateral substitution request is new or updated.")]
[DerivedFrom(typeof(CollateralSubstitutionSequenceCode))]
public enum CollateralSubstitutionSequence1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Initial".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Yb5zV9p-Ed-ak6NoX_4Aeg_1315111868")]
    [Description(@"??")]
    Initial,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Updated".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YcDkUNp-Ed-ak6NoX_4Aeg_-1512706665")]
    [Description(@"??")]
    Updated,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CollateralSubstitutionSequence1CodeMetadataExtensions
{
    private static readonly CollateralSubstitutionSequence1CodeDropdownSource _dropdownSource = new CollateralSubstitutionSequence1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICollateralSubstitutionSequence1CodeDropdownRow GetMetadata(this CollateralSubstitutionSequence1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


