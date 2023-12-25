﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for InvestorRestrictionTypeCode.  ISO2002 ID# _adQAAtp-Ed-ak6NoX_4Aeg_935487797.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies to whom or what the restriction applies.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="InvestorRestrictionTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IInvestorRestrictionTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_adQAAtp-Ed-ak6NoX_4Aeg_935487797")]
public partial class InvestorRestrictionTypeCodeDropdownRow : EnumMetadataItem<InvestorRestrictionTypeCode>, IInvestorRestrictionTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies to whom or what the restriction applies.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public InvestorRestrictionTypeCodeDropdownRow(InvestorRestrictionTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
