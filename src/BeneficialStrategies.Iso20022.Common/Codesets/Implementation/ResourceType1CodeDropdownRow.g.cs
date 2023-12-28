﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ResourceType1Code.  ISO2002 ID# _8wnVAC8CEeu125Ip9zFcsQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of resource.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ResourceType1CodeDropdownSource"/>.
/// Implements <seealso cref="IResourceType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8wnVAC8CEeu125Ip9zFcsQ")]
public partial class ResourceType1CodeDropdownRow : EnumMetadataItem<ResourceType1Code>, IResourceType1CodeDropdownRow
{
    /// <summary>
    /// Type of resource.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ResourceType1CodeDropdownRow(ResourceType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}