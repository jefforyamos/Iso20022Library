﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for IndependentAmountConventionTypeCode.  ISO2002 ID# _Yc8VItp-Ed-ak6NoX_4Aeg_-469659155.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Determines how the independent amount was applied in the margin calculation.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="IndependentAmountConventionTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IIndependentAmountConventionTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yc8VItp-Ed-ak6NoX_4Aeg_-469659155")]
public partial class IndependentAmountConventionTypeCodeDropdownRow : EnumMetadataItem<IndependentAmountConventionTypeCode>, IIndependentAmountConventionTypeCodeDropdownRow
{
    /// <summary>
    /// Determines how the independent amount was applied in the margin calculation.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public IndependentAmountConventionTypeCodeDropdownRow(IndependentAmountConventionTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
