﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardholderVerificationCapability1Code.  ISO2002 ID# _TSg-dAEcEeCQm6a_G2yO_w_-949484223.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

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
    /// ??
    /// Encoded/decoded by serializers as "ManualSignature".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TSg-dQEcEeCQm6a_G2yO_w_-1880835422")]
    [Description(@"??")]
    ManualSignature,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OnLinePIN".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TSg-dgEcEeCQm6a_G2yO_w_-1195154328")]
    [Description(@"??")]
    OnLinePIN,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OfflinePINClear".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TSg-dwEcEeCQm6a_G2yO_w_-870036821")]
    [Description(@"??")]
    OfflinePINClear,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OfflinePINEncrypted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TSg-eAEcEeCQm6a_G2yO_w_207983517")]
    [Description(@"??")]
    OfflinePINEncrypted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OfflineDigitalSignature".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TSg-eQEcEeCQm6a_G2yO_w_2145208690")]
    [Description(@"??")]
    OfflineDigitalSignature,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OfflineBiometrics".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TSg-egEcEeCQm6a_G2yO_w_169997474")]
    [Description(@"??")]
    OfflineBiometrics,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ManualVerification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TSg-ewEcEeCQm6a_G2yO_w_-584752400")]
    [Description(@"??")]
    ManualVerification,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OfflineBiographics".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TSg-fAEcEeCQm6a_G2yO_w_176012753")]
    [Description(@"??")]
    OfflineBiographics,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountDigitalSignature".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TSg-fQEcEeCQm6a_G2yO_w_-141763908")]
    [Description(@"??")]
    AccountDigitalSignature,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PKISignature".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TSg-fgEcEeCQm6a_G2yO_w_1795461265")]
    [Description(@"??")]
    PKISignature,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CardholderData".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TSg-fwEcEeCQm6a_G2yO_w_-1833944105")]
    [Description(@"??")]
    CardholderData,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecureElectronicCommerce".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TSg-gAEcEeCQm6a_G2yO_w_2143246530")]
    [Description(@"??")]
    SecureElectronicCommerce,
    
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


