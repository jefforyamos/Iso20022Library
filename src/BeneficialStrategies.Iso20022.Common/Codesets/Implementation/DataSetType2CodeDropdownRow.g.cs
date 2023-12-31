﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DataSetType2Code.  ISO2002 ID# _ayG1stp-Ed-ak6NoX_4Aeg_597609092.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of data set that is matched.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DataSetType2CodeDropdownSource"/>.
/// Implements <seealso cref="IDataSetType2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ayG1stp-Ed-ak6NoX_4Aeg_597609092")]
public partial class DataSetType2CodeDropdownRow : EnumMetadataItem<DataSetType2Code>, IDataSetType2CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of data set that is matched.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DataSetType2CodeDropdownRow(DataSetType2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
