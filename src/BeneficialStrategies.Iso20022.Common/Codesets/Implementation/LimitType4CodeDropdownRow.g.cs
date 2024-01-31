﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for LimitType4Code.  ISO2002 ID# _jPdhsO5NEeCisYr99QEiWA_1476260679.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of risk management limit.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="LimitType4CodeDropdownSource"/>.
/// Implements <seealso cref="ILimitType4CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_jPdhsO5NEeCisYr99QEiWA_1476260679")]
public partial class LimitType4CodeDropdownRow : EnumMetadataItem<LimitType4Code>, ILimitType4CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of risk management limit.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public LimitType4CodeDropdownRow(LimitType4Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
