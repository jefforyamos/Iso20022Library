﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Operation1Code.  ISO2002 ID# _aO8eQ9p-Ed-ak6NoX_4Aeg_1634410135.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the relationship between two variables.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Operation1CodeDropdownSource"/>.
/// Implements <seealso cref="IOperation1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aO8eQ9p-Ed-ak6NoX_4Aeg_1634410135")]
public partial class Operation1CodeDropdownRow : EnumMetadataItem<Operation1Code>, IOperation1CodeDropdownRow
{
    /// <summary>
    /// Indicates the relationship between two variables.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Operation1CodeDropdownRow(Operation1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
