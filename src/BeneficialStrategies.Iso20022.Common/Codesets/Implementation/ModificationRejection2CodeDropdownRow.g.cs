﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ModificationRejection2Code.  ISO2002 ID# _aMHMs9p-Ed-ak6NoX_4Aeg_-2138458517.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for rejecting a modification reject.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ModificationRejection2CodeDropdownSource"/>.
/// Implements <seealso cref="IModificationRejection2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aMHMs9p-Ed-ak6NoX_4Aeg_-2138458517")]
public partial class ModificationRejection2CodeDropdownRow : EnumMetadataItem<ModificationRejection2Code>, IModificationRejection2CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason for rejecting a modification reject.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ModificationRejection2CodeDropdownRow(ModificationRejection2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}