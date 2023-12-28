﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for InvestmentNeed2Code.  ISO2002 ID# _gKzBAKDtEequlaOyi6MUhw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies an investment need.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="InvestmentNeed2CodeDropdownSource"/>.
/// Implements <seealso cref="IInvestmentNeed2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_gKzBAKDtEequlaOyi6MUhw")]
public partial class InvestmentNeed2CodeDropdownRow : EnumMetadataItem<InvestmentNeed2Code>, IInvestmentNeed2CodeDropdownRow
{
    /// <summary>
    /// Specifies an investment need.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public InvestmentNeed2CodeDropdownRow(InvestmentNeed2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
