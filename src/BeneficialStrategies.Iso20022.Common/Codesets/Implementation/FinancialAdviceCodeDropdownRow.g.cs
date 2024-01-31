﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FinancialAdviceCode.  ISO2002 ID# _an-pVNp-Ed-ak6NoX_4Aeg_610878701.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if advice has been received from an independent financial advisor.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FinancialAdviceCodeDropdownSource"/>.
/// Implements <seealso cref="IFinancialAdviceCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_an-pVNp-Ed-ak6NoX_4Aeg_610878701")]
public partial class FinancialAdviceCodeDropdownRow : EnumMetadataItem<FinancialAdviceCode>, IFinancialAdviceCodeDropdownRow
{
    /// <summary>
    /// Specifies if advice has been received from an independent financial advisor.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FinancialAdviceCodeDropdownRow(FinancialAdviceCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
