﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DataModification1Code.  ISO2002 ID# _ax9EsNp-Ed-ak6NoX_4Aeg_-457133032.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specified the type of modification to be applied on a data set.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DataModification1CodeDropdownSource"/>.
/// Implements <seealso cref="IDataModification1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ax9EsNp-Ed-ak6NoX_4Aeg_-457133032")]
public partial class DataModification1CodeDropdownRow : EnumMetadataItem<DataModification1Code>, IDataModification1CodeDropdownRow
{
    /// <summary>
    /// Specified the type of modification to be applied on a data set.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DataModification1CodeDropdownRow(DataModification1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
