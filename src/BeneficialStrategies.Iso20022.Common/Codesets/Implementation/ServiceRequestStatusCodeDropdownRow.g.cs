﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ServiceRequestStatusCode.  ISO2002 ID# _eXhhcvF5EemQ7oqCO5NTQw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a service request.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ServiceRequestStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IServiceRequestStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_eXhhcvF5EemQ7oqCO5NTQw")]
public partial class ServiceRequestStatusCodeDropdownRow : EnumMetadataItem<ServiceRequestStatusCode>, IServiceRequestStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the status of a service request.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ServiceRequestStatusCodeDropdownRow(ServiceRequestStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
