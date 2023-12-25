﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for InvestmentFundPlanTypeCode.  ISO2002 ID# _sH2IUF9BEeicg40_9gK9vQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifes a type of investment fund plan.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="InvestmentFundPlanTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IInvestmentFundPlanTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_sH2IUF9BEeicg40_9gK9vQ")]
public partial class InvestmentFundPlanTypeCodeDropdownRow : EnumMetadataItem<InvestmentFundPlanTypeCode>, IInvestmentFundPlanTypeCodeDropdownRow
{
    /// <summary>
    /// Specifes a type of investment fund plan.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public InvestmentFundPlanTypeCodeDropdownRow(InvestmentFundPlanTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
