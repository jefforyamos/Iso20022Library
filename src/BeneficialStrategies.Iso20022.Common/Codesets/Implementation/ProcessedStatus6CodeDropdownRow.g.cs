﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ProcessedStatus6Code.  ISO2002 ID# _aKxI4tp-Ed-ak6NoX_4Aeg_983077435.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the processing status of a deactivation instruction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ProcessedStatus6CodeDropdownSource"/>.
/// Implements <seealso cref="IProcessedStatus6CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aKxI4tp-Ed-ak6NoX_4Aeg_983077435")]
public partial class ProcessedStatus6CodeDropdownRow : EnumMetadataItem<ProcessedStatus6Code>, IProcessedStatus6CodeDropdownRow
{
    /// <summary>
    /// Specifies the processing status of a deactivation instruction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ProcessedStatus6CodeDropdownRow(ProcessedStatus6Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
