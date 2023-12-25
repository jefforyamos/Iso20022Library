﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ContentTypeCode.  ISO2002 ID# _TWii2gEcEeCQm6a_G2yO_w_-608827804.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification of the type of protection for a protected data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TWii2gEcEeCQm6a_G2yO_w_-608827804")]
[Description(@"Identification of the type of protection for a protected data.")]
public enum ContentTypeCode
{
    /// <summary>
    /// Generic, non cryptographic, or unqualified data content - (ASN.1 Object Identifier: id-data).
    /// </summary>
    [EnumMember(Value = "DATA")]
    [IsoId("_TWii2wEcEeCQm6a_G2yO_w_-1529665547")]
    [Description(@"Generic, non cryptographic, or unqualified data content - (ASN.1 Object Identifier: id-data).")]
    DATA,
    
    /// <summary>
    /// Digital signature - (ASN.1 Object Identifier: id-signedData).
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_TWii3AEcEeCQm6a_G2yO_w_-488041433")]
    [Description(@"Digital signature - (ASN.1 Object Identifier: id-signedData).")]
    SIGN,
    
    /// <summary>
    /// Encrypted data, with encryption key - (ASN.1 Object Identifier: id-envelopedData).
    /// </summary>
    [EnumMember(Value = "EVLP")]
    [IsoId("_TWii3QEcEeCQm6a_G2yO_w_-1205844644")]
    [Description(@"Encrypted data, with encryption key - (ASN.1 Object Identifier: id-envelopedData).")]
    EVLP,
    
    /// <summary>
    /// Message digest - (ASN.1 Object Identifier: id-digestedData).
    /// </summary>
    [EnumMember(Value = "DGST")]
    [IsoId("_TWii3gEcEeCQm6a_G2yO_w_1140582150")]
    [Description(@"Message digest - (ASN.1 Object Identifier: id-digestedData).")]
    DGST,
    
    /// <summary>
    /// Encrypted data - (ASN.1 Object Identifier: id-encryptedData).
    /// </summary>
    [EnumMember(Value = "ECRP")]
    [IsoId("_TWii3wEcEeCQm6a_G2yO_w_-1129746596")]
    [Description(@"Encrypted data - (ASN.1 Object Identifier: id-encryptedData).")]
    ECRP,
    
    /// <summary>
    /// MAC (Message Authentication Code), with encryption key - (ASN.1 Object Identifier: id-ct-authData).
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_TWii4AEcEeCQm6a_G2yO_w_332278242")]
    [Description(@"MAC (Message Authentication Code), with encryption key - (ASN.1 Object Identifier: id-ct-authData).")]
    AUTH,
    
    /// <summary>
    /// General data encryption that conforms to the ISO 13492 standard.
    /// </summary>
    [EnumMember(Value = "IFSE")]
    [IsoId("_wF7KkD6NEeq_lLaSkIVjTQ")]
    [Description(@"General data encryption that conforms to the ISO 13492 standard.")]
    IFSE,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ContentTypeCodeMetadataExtensions
{
    private static readonly ContentTypeCodeDropdownSource _dropdownSource = new ContentTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IContentTypeCodeDropdownRow GetMetadata(this ContentTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


