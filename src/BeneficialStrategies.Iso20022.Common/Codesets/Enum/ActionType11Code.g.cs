﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ActionType11Code.  ISO2002 ID# _aDorwJ1AEeeuzZPGP9QqVw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Action associated with a result.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aDorwJ1AEeeuzZPGP9QqVw")]
[Description(@"Action associated with a result.")]
[DerivedFrom(typeof(ActionTypeCode))]
public enum ActionType11Code
{
    /// <summary>
    /// Contact card issuer.
    /// Encoded/decoded by serializers as "ContactIssuer".
    /// </summary>
    [EnumMember(Value = "CNTI")]
    [IsoId("_nHJlYZ1AEeeuzZPGP9QqVw")]
    [Description(@"Contact card issuer.")]
    ContactIssuer,
    
    /// <summary>
    /// Refer to card issuer's special conditions.
    /// Encoded/decoded by serializers as "ContactIssuerSpecialConditions".
    /// </summary>
    [EnumMember(Value = "CNIS")]
    [IsoId("_nR3AkZ1AEeeuzZPGP9QqVw")]
    [Description(@"Refer to card issuer's special conditions.")]
    ContactIssuerSpecialConditions,
    
    /// <summary>
    /// Contact acquirer.
    /// Encoded/decoded by serializers as "ContactAcquirer".
    /// </summary>
    [EnumMember(Value = "CNTA")]
    [IsoId("_oM7hsZ1AEeeuzZPGP9QqVw")]
    [Description(@"Contact acquirer.")]
    ContactAcquirer,
    
    /// <summary>
    /// Card acceptor to call acquirer's security department.
    /// Encoded/decoded by serializers as "ContactAcquirerSecurity".
    /// </summary>
    [EnumMember(Value = "CNAS")]
    [IsoId("_oZbFkZ1AEeeuzZPGP9QqVw")]
    [Description(@"Card acceptor to call acquirer's security department.")]
    ContactAcquirerSecurity,
    
    /// <summary>
    /// Capture the card.
    /// Encoded/decoded by serializers as "CaptureCard".
    /// </summary>
    [EnumMember(Value = "CPTR")]
    [IsoId("_pwdJ8Z1AEeeuzZPGP9QqVw")]
    [Description(@"Capture the card.")]
    CaptureCard,
    
    /// <summary>
    /// Additional verification of cardholder required.
    /// Encoded/decoded by serializers as "CardholderVerification".
    /// </summary>
    [EnumMember(Value = "CHDV")]
    [IsoId("_qebDMZ1AEeeuzZPGP9QqVw")]
    [Description(@"Additional verification of cardholder required.")]
    CardholderVerification,
    
    /// <summary>
    /// Manage account as a VIP one.
    /// Encoded/decoded by serializers as "VIPAccountManagement".
    /// </summary>
    [EnumMember(Value = "VIPM")]
    [IsoId("_sG3nsZ1AEeeuzZPGP9QqVw")]
    [Description(@"Manage account as a VIP one.")]
    VIPAccountManagement,
    
    /// <summary>
    /// Track provided in the response must be updated on the card.
    /// Encoded/decoded by serializers as "UpdateTrack".
    /// </summary>
    [EnumMember(Value = "TRCK")]
    [IsoId("_tVHjgZ1AEeeuzZPGP9QqVw")]
    [Description(@"Track provided in the response must be updated on the card.")]
    UpdateTrack,
    
    /// <summary>
    /// Transaction to be re-entered.
    /// Encoded/decoded by serializers as "ReEnterTransaction".
    /// </summary>
    [EnumMember(Value = "TRXR")]
    [IsoId("_uWb2kZ1AEeeuzZPGP9QqVw")]
    [Description(@"Transaction to be re-entered.")]
    ReEnterTransaction,
    
    /// <summary>
    /// Other action defined at national level.
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_2qgToZ1CEeeuzZPGP9QqVw")]
    [Description(@"Other action defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other action defined at private level
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_21Nu0Z1CEeeuzZPGP9QqVw")]
    [Description(@"Other action defined at private level")]
    OtherPrivate,
    
    /// <summary>
    /// Signature required.
    /// Encoded/decoded by serializers as "Signature".
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_q7b14J54EeqkBIJTZMHl2Q")]
    [Description(@"Signature required.")]
    Signature,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ActionType11CodeMetadataExtensions
{
    private static readonly ActionType11CodeDropdownSource _dropdownSource = new ActionType11CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IActionType11CodeDropdownRow GetMetadata(this ActionType11Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


