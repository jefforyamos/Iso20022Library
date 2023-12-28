﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for HolderTypeCode.  ISO2002 ID# _KdDVkE4SEeiQHa-q1Uephw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of holder.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="HolderTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IHolderTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KdDVkE4SEeiQHa-q1Uephw")]
public partial class HolderTypeCodeDropdownRow : EnumMetadataItem<HolderTypeCode>, IHolderTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies a type of holder.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public HolderTypeCodeDropdownRow(HolderTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}