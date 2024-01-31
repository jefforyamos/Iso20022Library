﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for InvestmentFundFeeCode.  ISO2002 ID# _GX-V4DiAEeaH-93K5JKmzw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of service for which a fee is asked or paid.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="InvestmentFundFeeCodeDropdownSource"/>.
/// Implements <seealso cref="IInvestmentFundFeeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_GX-V4DiAEeaH-93K5JKmzw")]
public partial class InvestmentFundFeeCodeDropdownRow : EnumMetadataItem<InvestmentFundFeeCode>, IInvestmentFundFeeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of service for which a fee is asked or paid.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public InvestmentFundFeeCodeDropdownRow(InvestmentFundFeeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
