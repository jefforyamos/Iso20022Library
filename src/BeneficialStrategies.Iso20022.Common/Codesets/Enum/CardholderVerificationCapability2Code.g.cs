﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardholderVerificationCapability2Code.  ISO2002 ID# _juNaIHr4EeSZrs_hiwNOWA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Cardholder verification capabilities by the terminal. 
/// It correspond to the ISO 8583, field number 22-2 for the versions 87 and 93, and 27-2 for the version 2003.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_juNaIHr4EeSZrs_hiwNOWA")]
[Description(@"Cardholder verification capabilities by the terminal.  It correspond to the ISO 8583, field number 22-2 for the versions 87 and 93, and 27-2 for the version 2003.")]
[DerivedFrom(typeof(CardholderVerificationCapabilityCode))]
public enum CardholderVerificationCapability2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountDigitalSignature".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_oXmnIXr4EeSZrs_hiwNOWA")]
    [Description(@"??")]
    AccountDigitalSignature,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CardholderData".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o1Ks4Xr4EeSZrs_hiwNOWA")]
    [Description(@"??")]
    CardholderData,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ManualSignature".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o6OzEXr4EeSZrs_hiwNOWA")]
    [Description(@"??")]
    ManualSignature,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ManualVerification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o-aIcXr4EeSZrs_hiwNOWA")]
    [Description(@"??")]
    ManualVerification,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OfflineBiographics".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pEN1gXr4EeSZrs_hiwNOWA")]
    [Description(@"??")]
    OfflineBiographics,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OfflineBiometrics".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pJldsXr4EeSZrs_hiwNOWA")]
    [Description(@"??")]
    OfflineBiometrics,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OfflineDigitalSignature".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pOzU4Xr4EeSZrs_hiwNOWA")]
    [Description(@"??")]
    OfflineDigitalSignature,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OfflinePINClear".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pWQAsXr4EeSZrs_hiwNOWA")]
    [Description(@"??")]
    OfflinePINClear,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OfflinePINEncrypted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pbd34Xr4EeSZrs_hiwNOWA")]
    [Description(@"??")]
    OfflinePINEncrypted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OnLinePIN".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pglBYXr4EeSZrs_hiwNOWA")]
    [Description(@"??")]
    OnLinePIN,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PKISignature".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pmGakXr4EeSZrs_hiwNOWA")]
    [Description(@"??")]
    PKISignature,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecureElectronicCommerce".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_prnMsXr4EeSZrs_hiwNOWA")]
    [Description(@"??")]
    SecureElectronicCommerce,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Unknown".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pwPOAXr4EeSZrs_hiwNOWA")]
    [Description(@"??")]
    Unknown,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OnLineBiometrics".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tV7gAS6qEeWc7f-D6ByqMg")]
    [Description(@"??")]
    OnLineBiometrics,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NoCapabilities".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tp5k4S6qEeWc7f-D6ByqMg")]
    [Description(@"??")]
    NoCapabilities,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uD1H0S6qEeWc7f-D6ByqMg")]
    [Description(@"??")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CardholderVerificationCapability2CodeMetadataExtensions
{
    private static readonly CardholderVerificationCapability2CodeDropdownSource _dropdownSource = new CardholderVerificationCapability2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICardholderVerificationCapability2CodeDropdownRow GetMetadata(this CardholderVerificationCapability2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


