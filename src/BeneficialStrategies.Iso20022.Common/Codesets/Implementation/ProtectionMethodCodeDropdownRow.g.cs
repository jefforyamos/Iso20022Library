﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ProtectionMethodCode.  ISO2002 ID# _ar5eoJyAEeuo7tDc4CDHXg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Method used to protect the sensitive data.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ProtectionMethodCodeDropdownSource"/>.
/// Implements <seealso cref="IProtectionMethodCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ar5eoJyAEeuo7tDc4CDHXg")]
public partial class ProtectionMethodCodeDropdownRow : EnumMetadataItem<ProtectionMethodCode>, IProtectionMethodCodeDropdownRow
{
    /// <summary>
    /// Method used to protect the sensitive data.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ProtectionMethodCodeDropdownRow(ProtectionMethodCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}