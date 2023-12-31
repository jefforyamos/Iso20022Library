﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CompensationMethod1Code.  ISO2002 ID# _6Vm_x5qlEeGSON8vddiWzQ_2080901699.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines if and how charges and taxes due are paid to the financial institution.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CompensationMethod1CodeDropdownSource"/>.
/// Implements <seealso cref="ICompensationMethod1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_6Vm_x5qlEeGSON8vddiWzQ_2080901699")]
public partial class CompensationMethod1CodeDropdownRow : EnumMetadataItem<CompensationMethod1Code>, ICompensationMethod1CodeDropdownRow
{
    /// <summary>
    /// Defines if and how charges and taxes due are paid to the financial institution.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CompensationMethod1CodeDropdownRow(CompensationMethod1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
