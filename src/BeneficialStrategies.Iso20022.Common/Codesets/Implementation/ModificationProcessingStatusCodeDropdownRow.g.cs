﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ModificationProcessingStatusCode.  ISO2002 ID# _jQp0g-5NEeCisYr99QEiWA_266324205.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a cancellation request.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ModificationProcessingStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IModificationProcessingStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_jQp0g-5NEeCisYr99QEiWA_266324205")]
public partial class ModificationProcessingStatusCodeDropdownRow : EnumMetadataItem<ModificationProcessingStatusCode>, IModificationProcessingStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the status of a cancellation request.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ModificationProcessingStatusCodeDropdownRow(ModificationProcessingStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
