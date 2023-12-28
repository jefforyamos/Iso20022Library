﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ResolutionType1Code.  ISO2002 ID# _ZU-JUtp-Ed-ak6NoX_4Aeg_1068245890.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of resolution.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZU-JUtp-Ed-ak6NoX_4Aeg_1068245890")]
[Description(@"Specifies the type of resolution.")]
[DerivedFrom(typeof(ResolutionTypeCode))]
public enum ResolutionType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Extraordinary".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZU-JU9p-Ed-ak6NoX_4Aeg_1357307111")]
    [Description(@"??")]
    Extraordinary,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Ordinary".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZU-JVNp-Ed-ak6NoX_4Aeg_1357307136")]
    [Description(@"??")]
    Ordinary,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Special".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZU-JVdp-Ed-ak6NoX_4Aeg_-689950721")]
    [Description(@"??")]
    Special,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ResolutionType1CodeMetadataExtensions
{
    private static readonly ResolutionType1CodeDropdownSource _dropdownSource = new ResolutionType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IResolutionType1CodeDropdownRow GetMetadata(this ResolutionType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

