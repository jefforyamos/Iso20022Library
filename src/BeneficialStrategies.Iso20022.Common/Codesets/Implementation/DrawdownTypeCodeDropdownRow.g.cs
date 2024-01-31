﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DrawdownTypeCode.  ISO2002 ID# _goS4AFNdEeijdq8ilaxyOA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of drawdown.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DrawdownTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IDrawdownTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_goS4AFNdEeijdq8ilaxyOA")]
public partial class DrawdownTypeCodeDropdownRow : EnumMetadataItem<DrawdownTypeCode>, IDrawdownTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies a type of drawdown.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DrawdownTypeCodeDropdownRow(DrawdownTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
