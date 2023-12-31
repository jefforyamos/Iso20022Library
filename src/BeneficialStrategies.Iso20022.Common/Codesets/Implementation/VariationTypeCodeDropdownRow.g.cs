﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for VariationTypeCode.  ISO2002 ID# _aqnvkHynEeGWJuGCfvwOsQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of variation.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="VariationTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IVariationTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aqnvkHynEeGWJuGCfvwOsQ")]
public partial class VariationTypeCodeDropdownRow : EnumMetadataItem<VariationTypeCode>, IVariationTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of variation.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public VariationTypeCodeDropdownRow(VariationTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
