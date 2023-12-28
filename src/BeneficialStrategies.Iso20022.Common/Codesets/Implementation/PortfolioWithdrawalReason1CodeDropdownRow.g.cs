﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PortfolioWithdrawalReason1Code.  ISO2002 ID# _LZZ2wE7bEeifNrXGwadPmg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a reason for a withdrawal from the investment product.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PortfolioWithdrawalReason1CodeDropdownSource"/>.
/// Implements <seealso cref="IPortfolioWithdrawalReason1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_LZZ2wE7bEeifNrXGwadPmg")]
public partial class PortfolioWithdrawalReason1CodeDropdownRow : EnumMetadataItem<PortfolioWithdrawalReason1Code>, IPortfolioWithdrawalReason1CodeDropdownRow
{
    /// <summary>
    /// Specifies a reason for a withdrawal from the investment product.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PortfolioWithdrawalReason1CodeDropdownRow(PortfolioWithdrawalReason1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}