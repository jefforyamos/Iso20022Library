﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReservationStatus1Code.  ISO2002 ID# _8J5r8KMgEeCJ6YNENx4h-w_-308307214.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the current status of a limit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8J5r8KMgEeCJ6YNENx4h-w_-308307214")]
[Description(@"Specifies the current status of a limit.")]
[DerivedFrom(typeof(ReservationStatusCode))]
public enum ReservationStatus1Code
{
    /// <summary>
    /// Reservation is currently in effect.
    /// Encoded/decoded by serializers as "Enabled".
    /// </summary>
    [EnumMember(Value = "ENAB")]
    [IsoId("_8J5r8aMgEeCJ6YNENx4h-w_312799950")]
    [Description(@"Reservation is currently in effect.")]
    Enabled,
    
    /// <summary>
    /// Reservation is not currently in effect.|.
    /// Encoded/decoded by serializers as "Disabled".
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_8J5r8qMgEeCJ6YNENx4h-w_898746976")]
    [Description(@"Reservation is not currently in effect.|.")]
    Disabled,
    
    /// <summary>
    /// Reservation has been deleted or suspended.
    /// Encoded/decoded by serializers as "Deleted".
    /// </summary>
    [EnumMember(Value = "DELD")]
    [IsoId("_8J5r86MgEeCJ6YNENx4h-w_-173258083")]
    [Description(@"Reservation has been deleted or suspended.")]
    Deleted,
    
    /// <summary>
    /// Reservation has been asked for and is not yet enabled.|.
    /// Encoded/decoded by serializers as "Requested".
    /// </summary>
    [EnumMember(Value = "REQD")]
    [IsoId("_8J5r9KMgEeCJ6YNENx4h-w_280829186")]
    [Description(@"Reservation has been asked for and is not yet enabled.|.")]
    Requested,
    
    /// <summary>
    /// Reservation is blocked or frozen due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy.
    /// Encoded/decoded by serializers as "Blocked".
    /// </summary>
    [EnumMember(Value = "BLKD")]
    [IsoId("_8J5r9aMgEeCJ6YNENx4h-w_-1729127672")]
    [Description(@"Reservation is blocked or frozen due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy.")]
    Blocked,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReservationStatus1CodeMetadataExtensions
{
    private static readonly ReservationStatus1CodeDropdownSource _dropdownSource = new ReservationStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReservationStatus1CodeDropdownRow GetMetadata(this ReservationStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


