﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardholderVerificationCapability3Code.  ISO2002 ID# _n75oUIn7EeShMpas3885ww.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Customer authentication capabilities available on an ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_n75oUIn7EeShMpas3885ww")]
[Description(@"Customer authentication capabilities available on an ATM.")]
[DerivedFrom(typeof(CardholderVerificationCapabilityCode))]
public enum CardholderVerificationCapability3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OnLinePIN".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uI4vAYn7EeShMpas3885ww")]
    [Description(@"??")]
    OnLinePIN,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OfflinePINClear".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_v1O8EYn7EeShMpas3885ww")]
    [Description(@"??")]
    OfflinePINClear,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OfflinePINEncrypted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_v7pGEYn7EeShMpas3885ww")]
    [Description(@"??")]
    OfflinePINEncrypted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OfflineDigitalSignature".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_xFjUcYn7EeShMpas3885ww")]
    [Description(@"??")]
    OfflineDigitalSignature,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OfflineBiometrics".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_x1FT8Yn7EeShMpas3885ww")]
    [Description(@"??")]
    OfflineBiometrics,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OfflineBiographics".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_x6xsQYn7EeShMpas3885ww")]
    [Description(@"??")]
    OfflineBiographics,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PKISignature".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ylWTQYn7EeShMpas3885ww")]
    [Description(@"??")]
    PKISignature,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PersonalCode".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zQIVoYn7EeShMpas3885ww")]
    [Description(@"??")]
    PersonalCode,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CardholderVerificationCapability3CodeMetadataExtensions
{
    private static readonly CardholderVerificationCapability3CodeDropdownSource _dropdownSource = new CardholderVerificationCapability3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICardholderVerificationCapability3CodeDropdownRow GetMetadata(this CardholderVerificationCapability3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


