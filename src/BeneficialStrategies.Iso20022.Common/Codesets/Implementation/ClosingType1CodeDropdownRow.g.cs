﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ClosingType1Code.  ISO2002 ID# _KgvwANonEeCWg-hsBVGrDA_-669343258.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the timing or method for terminating the agreement - for repos.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ClosingType1CodeDropdownSource"/>.
/// Implements <seealso cref="IClosingType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KgvwANonEeCWg-hsBVGrDA_-669343258")]
public partial class ClosingType1CodeDropdownRow : EnumMetadataItem<ClosingType1Code>, IClosingType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the timing or method for terminating the agreement - for repos.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ClosingType1CodeDropdownRow(ClosingType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
