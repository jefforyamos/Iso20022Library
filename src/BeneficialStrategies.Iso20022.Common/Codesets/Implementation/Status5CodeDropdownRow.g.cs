﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Status5Code.  ISO2002 ID# _Yaalktp-Ed-ak6NoX_4Aeg_-277478982.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an instruction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Status5CodeDropdownSource"/>.
/// Implements <seealso cref="IStatus5CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yaalktp-Ed-ak6NoX_4Aeg_-277478982")]
public partial class Status5CodeDropdownRow : EnumMetadataItem<Status5Code>, IStatus5CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of an instruction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Status5CodeDropdownRow(Status5Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
