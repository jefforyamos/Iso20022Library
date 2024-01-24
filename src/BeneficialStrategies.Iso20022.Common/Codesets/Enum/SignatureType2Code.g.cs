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
    /// Technical signature that includes algorithms and private key and public key information. Used to sign and verify the contents of a message.
    /// Encoded/decoded by serializers as "DIGI".
    /// </summary>
    [EnumMember(Value = "DIGI")]
    [IsoId("_r15dAV-dEeavlvCtut5bgg")]
    [Description(@"Technical signature that includes algorithms and private key and public key information. Used to sign and verify the contents of a message.")]
    Digital = SignatureTypeV2Code.Digital, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Copy of a physical or original signature in an electronic format.
    /// Encoded/decoded by serializers as "ELEC".
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_sBDkIV-dEeavlvCtut5bgg")]
    [Description(@"Copy of a physical or original signature in an electronic format.")]
    Electronic = SignatureTypeV2Code.Electronic, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No signature.
    /// Encoded/decoded by serializers as "NONE".
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_sEVhoV-dEeavlvCtut5bgg")]
    [Description(@"No signature.")]
    None = SignatureTypeV2Code.None, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Written signature. May also be known as a physical or wet signature.
    /// Encoded/decoded by serializers as "ORIG".
    /// </summary>
    [EnumMember(Value = "ORIG")]
    [IsoId("_sJGF0V-dEeavlvCtut5bgg")]
    [Description(@"Written signature. May also be known as a physical or wet signature.")]
    Original = SignatureTypeV2Code.Original, // same ordinal as derivation source for type conversions
    
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


