﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SignatureType2Code.  ISO2002 ID# _kjV1YF-dEeavlvCtut5bgg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of signature.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kjV1YF-dEeavlvCtut5bgg")]
[Description(@"Type of signature.")]
[DerivedFrom(typeof(SignatureTypeV2Code))]
public enum SignatureType2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Digital".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_r15dAV-dEeavlvCtut5bgg")]
    [Description(@"??")]
    Digital,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Electronic".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_sBDkIV-dEeavlvCtut5bgg")]
    [Description(@"??")]
    Electronic,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "None".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_sEVhoV-dEeavlvCtut5bgg")]
    [Description(@"??")]
    None,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Original".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_sJGF0V-dEeavlvCtut5bgg")]
    [Description(@"??")]
    Original,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SignatureType2CodeMetadataExtensions
{
    private static readonly SignatureType2CodeDropdownSource _dropdownSource = new SignatureType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISignatureType2CodeDropdownRow GetMetadata(this SignatureType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


