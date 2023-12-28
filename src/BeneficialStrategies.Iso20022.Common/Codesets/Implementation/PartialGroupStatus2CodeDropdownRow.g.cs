﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PartialGroupStatus2Code.  ISO2002 ID# _YY7X2Np-Ed-ak6NoX_4Aeg_-1454361450.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the status of a single payment transaction or of a group of payment transactions.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PartialGroupStatus2CodeDropdownSource"/>.
/// Implements <seealso cref="IPartialGroupStatus2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YY7X2Np-Ed-ak6NoX_4Aeg_-1454361450")]
public partial class PartialGroupStatus2CodeDropdownRow : EnumMetadataItem<PartialGroupStatus2Code>, IPartialGroupStatus2CodeDropdownRow
{
    /// <summary>
    /// Indicates the status of a single payment transaction or of a group of payment transactions.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PartialGroupStatus2CodeDropdownRow(PartialGroupStatus2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
