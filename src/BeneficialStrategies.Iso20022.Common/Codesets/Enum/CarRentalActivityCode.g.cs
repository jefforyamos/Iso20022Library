﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CarRentalActivityCode.  ISO2002 ID# _S_0LwFyqEeeve7Je9cXtkQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Activity type assigned to a car rental company.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_S_0LwFyqEeeve7Je9cXtkQ")]
[Description(@"Activity type assigned to a car rental company.")]
[Derivations(typeof(CarRentalActivity1Code))]
public enum CarRentalActivityCode
{
    /// <summary>
    /// Company specialised in car sharing activities.
    /// Encoded/decoded by serializers as "CARS".
    /// </summary>
    [EnumMember(Value = "CARS")]
    [IsoId("_cjkZ8FyqEeeve7Je9cXtkQ")]
    [Description(@"Company specialised in car sharing activities.")]
    CarSharing,
    
    /// <summary>
    /// Global car rental activities.
    /// Encoded/decoded by serializers as "GLBL".
    /// </summary>
    [EnumMember(Value = "GLBL")]
    [IsoId("_9x18sFyqEeeve7Je9cXtkQ")]
    [Description(@"Global car rental activities.")]
    Global,
    
    /// <summary>
    /// Individual renting a car.
    /// Encoded/decoded by serializers as "INDV".
    /// </summary>
    [EnumMember(Value = "INDV")]
    [IsoId("_DkIrcFyrEeeve7Je9cXtkQ")]
    [Description(@"Individual renting a car.")]
    Individual,
    
    /// <summary>
    /// Peer to peer car rental activities.
    /// Encoded/decoded by serializers as "PETP".
    /// </summary>
    [EnumMember(Value = "PETP")]
    [IsoId("_JWJGUFyrEeeve7Je9cXtkQ")]
    [Description(@"Peer to peer car rental activities.")]
    PeerToPeer,
    
    /// <summary>
    /// Other type of car rental activity.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Vyq4cFyrEeeve7Je9cXtkQ")]
    [Description(@"Other type of car rental activity.")]
    Other,
    
    /// <summary>
    /// Other National
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_wGMFYPSrEeife6veM7daYw")]
    [Description(@"Other National")]
    OtherNational,
    
    /// <summary>
    /// Other Private
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_zQjIkPSrEeife6veM7daYw")]
    [Description(@"Other Private")]
    OtherPrivate,
    
}
