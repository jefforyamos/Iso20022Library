﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ModelTypeCode.  ISO2002 ID# _0hGmQLC1EeaSl6vJk5Bd8w.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Categorisation of margin models used by central counterparties.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ModelTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IModelTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_0hGmQLC1EeaSl6vJk5Bd8w")]
public partial class ModelTypeCodeDropdownRow : EnumMetadataItem<ModelTypeCode>, IModelTypeCodeDropdownRow
{
    /// <summary>
    /// Categorisation of margin models used by central counterparties.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ModelTypeCodeDropdownRow(ModelTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
