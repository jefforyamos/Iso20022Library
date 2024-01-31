﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DataModificationCode.  ISO2002 ID# _ax9Et9p-Ed-ak6NoX_4Aeg_1251381702.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specified the type of modification to be applied on a data set.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DataModificationCodeDropdownSource"/>.
/// Implements <seealso cref="IDataModificationCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ax9Et9p-Ed-ak6NoX_4Aeg_1251381702")]
public partial class DataModificationCodeDropdownRow : EnumMetadataItem<DataModificationCode>, IDataModificationCodeDropdownRow
{
    /// <summary>
    /// Specified the type of modification to be applied on a data set.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DataModificationCodeDropdownRow(DataModificationCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
