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
    /// ??
    /// Encoded/decoded by serializers as "ContactIssuer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nHJlYZ1AEeeuzZPGP9QqVw")]
    [Description(@"??")]
    ContactIssuer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ContactIssuerSpecialConditions".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nR3AkZ1AEeeuzZPGP9QqVw")]
    [Description(@"??")]
    ContactIssuerSpecialConditions,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ContactAcquirer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_oM7hsZ1AEeeuzZPGP9QqVw")]
    [Description(@"??")]
    ContactAcquirer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ContactAcquirerSecurity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_oZbFkZ1AEeeuzZPGP9QqVw")]
    [Description(@"??")]
    ContactAcquirerSecurity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CaptureCard".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pwdJ8Z1AEeeuzZPGP9QqVw")]
    [Description(@"??")]
    CaptureCard,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CardholderVerification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_qebDMZ1AEeeuzZPGP9QqVw")]
    [Description(@"??")]
    CardholderVerification,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "VIPAccountManagement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_sG3nsZ1AEeeuzZPGP9QqVw")]
    [Description(@"??")]
    VIPAccountManagement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UpdateTrack".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tVHjgZ1AEeeuzZPGP9QqVw")]
    [Description(@"??")]
    UpdateTrack,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReEnterTransaction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uWb2kZ1AEeeuzZPGP9QqVw")]
    [Description(@"??")]
    ReEnterTransaction,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2qgToZ1CEeeuzZPGP9QqVw")]
    [Description(@"??")]
    OtherNational,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_21Nu0Z1CEeeuzZPGP9QqVw")]
    [Description(@"??")]
    OtherPrivate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Signature".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_q7b14J54EeqkBIJTZMHl2Q")]
    [Description(@"??")]
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

