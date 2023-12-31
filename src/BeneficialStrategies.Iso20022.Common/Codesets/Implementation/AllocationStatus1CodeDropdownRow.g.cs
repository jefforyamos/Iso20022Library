﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AllocationStatus1Code.  ISO2002 ID# _bopcJ9p-Ed-ak6NoX_4Aeg_1464332533.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of allocation of collateral to cover the instruction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AllocationStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IAllocationStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bopcJ9p-Ed-ak6NoX_4Aeg_1464332533")]
public partial class AllocationStatus1CodeDropdownRow : EnumMetadataItem<AllocationStatus1Code>, IAllocationStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of allocation of collateral to cover the instruction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AllocationStatus1CodeDropdownRow(AllocationStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
