﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ResolutionSubStatusCode.  ISO2002 ID# _vmscgDUGEe2tRf29bleifQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the sub-status of a resolution.  
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ResolutionSubStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IResolutionSubStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_vmscgDUGEe2tRf29bleifQ")]
public partial class ResolutionSubStatusCodeDropdownRow : EnumMetadataItem<ResolutionSubStatusCode>, IResolutionSubStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the sub-status of a resolution.  
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ResolutionSubStatusCodeDropdownRow(ResolutionSubStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
