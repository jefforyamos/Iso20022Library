﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ServiceRequestStatus1Code.  ISO2002 ID# _BrhagPF6EemQ7oqCO5NTQw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a service request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BrhagPF6EemQ7oqCO5NTQw")]
[Description(@"Specifies the status of a service request.")]
[DerivedFrom(typeof(ServiceRequestStatusCode))]
public enum ServiceRequestStatus1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Accepted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_PZY4sfF6EemQ7oqCO5NTQw")]
    [Description(@"??")]
    Accepted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Rejected".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_PtECofF6EemQ7oqCO5NTQw")]
    [Description(@"??")]
    Rejected,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ServiceRequestStatus1CodeMetadataExtensions
{
    private static readonly ServiceRequestStatus1CodeDropdownSource _dropdownSource = new ServiceRequestStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IServiceRequestStatus1CodeDropdownRow GetMetadata(this ServiceRequestStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


