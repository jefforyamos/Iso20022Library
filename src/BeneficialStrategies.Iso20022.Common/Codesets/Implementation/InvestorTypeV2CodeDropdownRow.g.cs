﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for InvestorTypeV2Code.  ISO2002 ID# _I92ekLVMEeqkjqDuFVh1-A.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of investor.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="InvestorTypeV2CodeDropdownSource"/>.
/// Implements <seealso cref="IInvestorTypeV2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_I92ekLVMEeqkjqDuFVh1-A")]
public partial class InvestorTypeV2CodeDropdownRow : EnumMetadataItem<InvestorTypeV2Code>, IInvestorTypeV2CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of investor.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public InvestorTypeV2CodeDropdownRow(InvestorTypeV2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
