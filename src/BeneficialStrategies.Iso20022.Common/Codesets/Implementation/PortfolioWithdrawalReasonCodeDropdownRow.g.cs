﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PortfolioWithdrawalReasonCode.  ISO2002 ID# _BNVEUE7bEeifNrXGwadPmg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a reason for a withdrawal from the investment product.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PortfolioWithdrawalReasonCodeDropdownSource"/>.
/// Implements <seealso cref="IPortfolioWithdrawalReasonCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_BNVEUE7bEeifNrXGwadPmg")]
public partial class PortfolioWithdrawalReasonCodeDropdownRow : EnumMetadataItem<PortfolioWithdrawalReasonCode>, IPortfolioWithdrawalReasonCodeDropdownRow
{
    /// <summary>
    /// Specifies a reason for a withdrawal from the investment product.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PortfolioWithdrawalReasonCodeDropdownRow(PortfolioWithdrawalReasonCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
