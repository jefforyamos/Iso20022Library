﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SignatureTypeV2Code.  ISO2002 ID# _HCtegF-cEeavlvCtut5bgg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of signature.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_HCtegF-cEeavlvCtut5bgg")]
[Description(@"Type of signature.")]
public enum SignatureTypeV2Code
{
    /// <summary>
    /// Written signature. May also be known as a physical or wet signature.
    /// Encoded/decoded by serializers as "ORIG".
    /// </summary>
    [EnumMember(Value = "ORIG")]
    [IsoId("_Pkt70F-cEeavlvCtut5bgg")]
    [Description(@"Written signature. May also be known as a physical or wet signature.")]
    Original,
    
    /// <summary>
    /// Technical signature that includes algorithms and private key and public key information. Used to sign and verify the contents of a message.
    /// Encoded/decoded by serializers as "DIGI".
    /// </summary>
    [EnumMember(Value = "DIGI")]
    [IsoId("_PrkKsF-cEeavlvCtut5bgg")]
    [Description(@"Technical signature that includes algorithms and private key and public key information. Used to sign and verify the contents of a message.")]
    Digital,
    
    /// <summary>
    /// Copy of a physical or original signature in an electronic format.
    /// Encoded/decoded by serializers as "ELEC".
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_PyQokF-cEeavlvCtut5bgg")]
    [Description(@"Copy of a physical or original signature in an electronic format.")]
    Electronic,
    
    /// <summary>
    /// No signature.
    /// Encoded/decoded by serializers as "NONE".
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_P4gagF-cEeavlvCtut5bgg")]
    [Description(@"No signature.")]
    None,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SignatureTypeV2CodeMetadataExtensions
{
    private static readonly SignatureTypeV2CodeDropdownSource _dropdownSource = new SignatureTypeV2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISignatureTypeV2CodeDropdownRow GetMetadata(this SignatureTypeV2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


