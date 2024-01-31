﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CarRentalActivity1Code.  ISO2002 ID# _nyCBAFyrEeeve7Je9cXtkQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Company specialised in car sharing activities.
    /// Encoded/decoded by serializers as "CARS".
    /// </summary>
    [EnumMember(Value = "CARS")]
    [IsoId("_rkPHUVyrEeeve7Je9cXtkQ")]
    [Description(@"Company specialised in car sharing activities.")]
    CarSharing = CarRentalActivityCode.CarSharing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Global car rental activities.
    /// Encoded/decoded by serializers as "GLBL".
    /// </summary>
    [EnumMember(Value = "GLBL")]
    [IsoId("_rxoDEVyrEeeve7Je9cXtkQ")]
    [Description(@"Global car rental activities.")]
    Global = CarRentalActivityCode.Global, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Individual renting a car.
    /// Encoded/decoded by serializers as "INDV".
    /// </summary>
    [EnumMember(Value = "INDV")]
    [IsoId("_r-kS4lyrEeeve7Je9cXtkQ")]
    [Description(@"Individual renting a car.")]
    Individual = CarRentalActivityCode.Individual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Peer to peer car rental activities.
    /// Encoded/decoded by serializers as "PETP".
    /// </summary>
    [EnumMember(Value = "PETP")]
    [IsoId("_sQko4lyrEeeve7Je9cXtkQ")]
    [Description(@"Peer to peer car rental activities.")]
    PeerToPeer = CarRentalActivityCode.PeerToPeer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other Private
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_6MeY4fSrEeife6veM7daYw")]
    [Description(@"Other Private")]
    OtherPrivate = CarRentalActivityCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other National
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_6RrpAfSrEeife6veM7daYw")]
    [Description(@"Other National")]
    OtherNational = CarRentalActivityCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of car rental activity.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_6TUAsfSrEeife6veM7daYw")]
    [Description(@"Other type of car rental activity.")]
    Other = CarRentalActivityCode.Other, // same ordinal as derivation source for type conversions
    
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


