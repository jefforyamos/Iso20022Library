﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DetailAmount2Code.  ISO2002 ID# _fca5gFjpEeiTlKUpxxSxEw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of detail amount.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DetailAmount2CodeDropdownSource"/>.
/// Implements <seealso cref="IDetailAmount2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_fca5gFjpEeiTlKUpxxSxEw")]
public partial class DetailAmount2CodeDropdownRow : EnumMetadataItem<DetailAmount2Code>, IDetailAmount2CodeDropdownRow
{
    /// <summary>
    /// Type of detail amount.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DetailAmount2CodeDropdownRow(DetailAmount2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}