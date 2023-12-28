﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CarRentalActivity1Code.  ISO2002 ID# _nyCBAFyrEeeve7Je9cXtkQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of car rental activity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nyCBAFyrEeeve7Je9cXtkQ")]
[Description(@"Type of car rental activity.")]
[DerivedFrom(typeof(CarRentalActivityCode))]
public enum CarRentalActivity1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CarSharing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_rkPHUVyrEeeve7Je9cXtkQ")]
    [Description(@"??")]
    CarSharing,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Global".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_rxoDEVyrEeeve7Je9cXtkQ")]
    [Description(@"??")]
    Global,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Individual".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_r-kS4lyrEeeve7Je9cXtkQ")]
    [Description(@"??")]
    Individual,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PeerToPeer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_sQko4lyrEeeve7Je9cXtkQ")]
    [Description(@"??")]
    PeerToPeer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6MeY4fSrEeife6veM7daYw")]
    [Description(@"??")]
    OtherPrivate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6RrpAfSrEeife6veM7daYw")]
    [Description(@"??")]
    OtherNational,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6TUAsfSrEeife6veM7daYw")]
    [Description(@"??")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CarRentalActivity1CodeMetadataExtensions
{
    private static readonly CarRentalActivity1CodeDropdownSource _dropdownSource = new CarRentalActivity1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICarRentalActivity1CodeDropdownRow GetMetadata(this CarRentalActivity1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


