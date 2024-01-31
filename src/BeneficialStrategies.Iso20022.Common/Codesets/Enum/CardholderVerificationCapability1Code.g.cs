﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardholderVerificationCapability1Code.  ISO2002 ID# _TSg-dAEcEeCQm6a_G2yO_w_-949484223.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Cardholder verification capabilities of the POI (Personal Identification Number) performing the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TSg-dAEcEeCQm6a_G2yO_w_-949484223")]
[Description(@"Cardholder verification capabilities of the POI (Personal Identification Number) performing the transaction.")]
[DerivedFrom(typeof(CardholderVerificationCapabilityCode))]
public enum CardholderVerificationCapability1Code
{
    /// <summary>
    /// Manual signature verification.
    /// Encoded/decoded by serializers as "MNSG".
    /// </summary>
    [EnumMember(Value = "MNSG")]
    [IsoId("_TSg-dQEcEeCQm6a_G2yO_w_-1880835422")]
    [Description(@"Manual signature verification.")]
    ManualSignature = CardholderVerificationCapabilityCode.ManualSignature, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Online PIN (Personal Identification Number).
    /// Encoded/decoded by serializers as "NPIN".
    /// </summary>
    [EnumMember(Value = "NPIN")]
    [IsoId("_TSg-dgEcEeCQm6a_G2yO_w_-1195154328")]
    [Description(@"Online PIN (Personal Identification Number).")]
    OnLinePIN = CardholderVerificationCapabilityCode.OnLinePIN, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offline PIN in clear (Personal Identification Number).
    /// Encoded/decoded by serializers as "FCPN".
    /// </summary>
    [EnumMember(Value = "FCPN")]
    [IsoId("_TSg-dwEcEeCQm6a_G2yO_w_-870036821")]
    [Description(@"Offline PIN in clear (Personal Identification Number).")]
    OfflinePINClear = CardholderVerificationCapabilityCode.OfflinePINClear, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offline PIN encrypted (Personal Identification Number).
    /// Encoded/decoded by serializers as "FEPN".
    /// </summary>
    [EnumMember(Value = "FEPN")]
    [IsoId("_TSg-eAEcEeCQm6a_G2yO_w_207983517")]
    [Description(@"Offline PIN encrypted (Personal Identification Number).")]
    OfflinePINEncrypted = CardholderVerificationCapabilityCode.OfflinePINEncrypted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offline digital signature analysis.
    /// Encoded/decoded by serializers as "FDSG".
    /// </summary>
    [EnumMember(Value = "FDSG")]
    [IsoId("_TSg-eQEcEeCQm6a_G2yO_w_2145208690")]
    [Description(@"Offline digital signature analysis.")]
    OfflineDigitalSignature = CardholderVerificationCapabilityCode.OfflineDigitalSignature, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offline biometrics.
    /// Encoded/decoded by serializers as "FBIO".
    /// </summary>
    [EnumMember(Value = "FBIO")]
    [IsoId("_TSg-egEcEeCQm6a_G2yO_w_169997474")]
    [Description(@"Offline biometrics.")]
    OfflineBiometrics = CardholderVerificationCapabilityCode.OfflineBiometrics, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other manual verification, for example passport or drivers license.
    /// Encoded/decoded by serializers as "MNVR".
    /// </summary>
    [EnumMember(Value = "MNVR")]
    [IsoId("_TSg-ewEcEeCQm6a_G2yO_w_-584752400")]
    [Description(@"Other manual verification, for example passport or drivers license.")]
    ManualVerification = CardholderVerificationCapabilityCode.ManualVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offline biographics.
    /// Encoded/decoded by serializers as "FBIG".
    /// </summary>
    [EnumMember(Value = "FBIG")]
    [IsoId("_TSg-fAEcEeCQm6a_G2yO_w_176012753")]
    [Description(@"Offline biographics.")]
    OfflineBiographics = CardholderVerificationCapabilityCode.OfflineBiographics, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account based digital signature.
    /// Encoded/decoded by serializers as "APKI".
    /// </summary>
    [EnumMember(Value = "APKI")]
    [IsoId("_TSg-fQEcEeCQm6a_G2yO_w_-141763908")]
    [Description(@"Account based digital signature.")]
    AccountDigitalSignature = CardholderVerificationCapabilityCode.AccountDigitalSignature, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PKI (Public Key Infrastructure) based digital signature.
    /// Encoded/decoded by serializers as "PKIS".
    /// </summary>
    [EnumMember(Value = "PKIS")]
    [IsoId("_TSg-fgEcEeCQm6a_G2yO_w_1795461265")]
    [Description(@"PKI (Public Key Infrastructure) based digital signature.")]
    PKISignature = CardholderVerificationCapabilityCode.PKISignature, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cardholder authentication data.
    /// Encoded/decoded by serializers as "CHDT".
    /// </summary>
    [EnumMember(Value = "CHDT")]
    [IsoId("_TSg-fwEcEeCQm6a_G2yO_w_-1833944105")]
    [Description(@"Cardholder authentication data.")]
    CardholderData = CardholderVerificationCapabilityCode.CardholderData, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Three domain secure (three domain secure authentication of the cardholder).
    /// Encoded/decoded by serializers as "SCEC".
    /// </summary>
    [EnumMember(Value = "SCEC")]
    [IsoId("_TSg-gAEcEeCQm6a_G2yO_w_2143246530")]
    [Description(@"Three domain secure (three domain secure authentication of the cardholder).")]
    SecureElectronicCommerce = CardholderVerificationCapabilityCode.SecureElectronicCommerce, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CardholderVerificationCapability1CodeMetadataExtensions
{
    private static readonly CardholderVerificationCapability1CodeDropdownSource _dropdownSource = new CardholderVerificationCapability1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICardholderVerificationCapability1CodeDropdownRow GetMetadata(this CardholderVerificationCapability1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


