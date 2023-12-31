﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DataType1Code.  ISO2002 ID# _X5YEEIAwEeSUJZYcWGKkkw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of data to indicate whether a trade is an option or resulted by an option exercise.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DataType1CodeDropdownSource"/>.
/// Implements <seealso cref="IDataType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_X5YEEIAwEeSUJZYcWGKkkw")]
public partial class DataType1CodeDropdownRow : EnumMetadataItem<DataType1Code>, IDataType1CodeDropdownRow
{
    /// <summary>
    /// Type of data to indicate whether a trade is an option or resulted by an option exercise.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DataType1CodeDropdownRow(DataType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
