﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for VariationType1Code.  ISO2002 ID# __JYLoHynEeGWJuGCfvwOsQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of variation.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="VariationType1CodeDropdownSource"/>.
/// Implements <seealso cref="IVariationType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__JYLoHynEeGWJuGCfvwOsQ")]
public partial class VariationType1CodeDropdownRow : EnumMetadataItem<VariationType1Code>, IVariationType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of variation.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public VariationType1CodeDropdownRow(VariationType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
