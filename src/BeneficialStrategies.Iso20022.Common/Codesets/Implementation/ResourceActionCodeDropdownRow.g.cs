﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ResourceActionCode.  ISO2002 ID# _LI9QYC7_Eeu125Ip9zFcsQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of action to perform on a media resource.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ResourceActionCodeDropdownSource"/>.
/// Implements <seealso cref="IResourceActionCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_LI9QYC7_Eeu125Ip9zFcsQ")]
public partial class ResourceActionCodeDropdownRow : EnumMetadataItem<ResourceActionCode>, IResourceActionCodeDropdownRow
{
    /// <summary>
    /// Type of action to perform on a media resource.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ResourceActionCodeDropdownRow(ResourceActionCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
