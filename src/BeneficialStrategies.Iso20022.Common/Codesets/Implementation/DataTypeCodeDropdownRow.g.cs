﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DataTypeCode.  ISO2002 ID# _9dkccEeAEeSzluxs8tdrVw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of data.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DataTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IDataTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_9dkccEeAEeSzluxs8tdrVw")]
public partial class DataTypeCodeDropdownRow : EnumMetadataItem<DataTypeCode>, IDataTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of data.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DataTypeCodeDropdownRow(DataTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}