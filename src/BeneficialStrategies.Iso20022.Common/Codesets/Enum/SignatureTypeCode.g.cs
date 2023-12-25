﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SignatureTypeCode.  ISO2002 ID# _ZPUNRtp-Ed-ak6NoX_4Aeg_1133516215.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of signature form.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZPUNRtp-Ed-ak6NoX_4Aeg_1133516215")]
[Description(@"Type of signature form.")]
public enum SignatureTypeCode
{
    /// <summary>
    /// The investor's written signature is required. Can also be known as physical or wet signature.
    /// </summary>
    [EnumMember(Value = "ORIG")]
    [IsoId("_ZPUNR9p-Ed-ak6NoX_4Aeg_1551868331")]
    [Description(@"The investor's written signature is required. Can also be known as physical or wet signature.")]
    ORIG,
    
    /// <summary>
    /// A technical signature that includes algorithms and private key and public key information. Used to sign and verify the contents of a message.
    /// </summary>
    [EnumMember(Value = "DIGI")]
    [IsoId("_ZPUNSNp-Ed-ak6NoX_4Aeg_1551868361")]
    [Description(@"A technical signature that includes algorithms and private key and public key information. Used to sign and verify the contents of a message.")]
    DIGI,
    
    /// <summary>
    /// A copy of a physical or original signature in an electronic format.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_ZPdXMNp-Ed-ak6NoX_4Aeg_1551868392")]
    [Description(@"A copy of a physical or original signature in an electronic format.")]
    ELEC,
    
    /// <summary>
    /// There is no signature required in any form.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_ZPdXMdp-Ed-ak6NoX_4Aeg_1551868393")]
    [Description(@"There is no signature required in any form.")]
    NONE,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SignatureTypeCodeMetadataExtensions
{
    private static readonly SignatureTypeCodeDropdownSource _dropdownSource = new SignatureTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISignatureTypeCodeDropdownRow GetMetadata(this SignatureTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


