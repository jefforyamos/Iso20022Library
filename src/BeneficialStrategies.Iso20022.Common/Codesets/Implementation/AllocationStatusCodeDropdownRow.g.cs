﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AllocationStatusCode.  ISO2002 ID# _boymEtp-Ed-ak6NoX_4Aeg_-1844046552.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of allocation of collateral to cover the instruction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AllocationStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IAllocationStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_boymEtp-Ed-ak6NoX_4Aeg_-1844046552")]
public partial class AllocationStatusCodeDropdownRow : EnumMetadataItem<AllocationStatusCode>, IAllocationStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the status of allocation of collateral to cover the instruction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AllocationStatusCodeDropdownRow(AllocationStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
