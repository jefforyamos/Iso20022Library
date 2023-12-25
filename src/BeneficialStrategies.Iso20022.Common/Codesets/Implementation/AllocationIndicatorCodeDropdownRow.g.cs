﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AllocationIndicatorCode.  ISO2002 ID# _jsRFAyjnEeK1Sbo8NpBROA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the trade is a pre-allocation or a post-allocation trade, or whether the trade is unallocated.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AllocationIndicatorCodeDropdownSource"/>.
/// Implements <seealso cref="IAllocationIndicatorCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_jsRFAyjnEeK1Sbo8NpBROA")]
public partial class AllocationIndicatorCodeDropdownRow : EnumMetadataItem<AllocationIndicatorCode>, IAllocationIndicatorCodeDropdownRow
{
    /// <summary>
    /// Specifies whether the trade is a pre-allocation or a post-allocation trade, or whether the trade is unallocated.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AllocationIndicatorCodeDropdownRow(AllocationIndicatorCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
