﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DataSetTypeCode.  ISO2002 ID# _ayQmsNp-Ed-ak6NoX_4Aeg_952185864.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of data set that is matched.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DataSetTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IDataSetTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ayQmsNp-Ed-ak6NoX_4Aeg_952185864")]
public partial class DataSetTypeCodeDropdownRow : EnumMetadataItem<DataSetTypeCode>, IDataSetTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of data set that is matched.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DataSetTypeCodeDropdownRow(DataSetTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
