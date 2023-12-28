﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FundOrderType2Code.  ISO2002 ID# _VkUiNtp-Ed-ak6NoX_4Aeg_281815183.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the category of the investment fund order.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FundOrderType2CodeDropdownSource"/>.
/// Implements <seealso cref="IFundOrderType2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VkUiNtp-Ed-ak6NoX_4Aeg_281815183")]
public partial class FundOrderType2CodeDropdownRow : EnumMetadataItem<FundOrderType2Code>, IFundOrderType2CodeDropdownRow
{
    /// <summary>
    /// Specifies the category of the investment fund order.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FundOrderType2CodeDropdownRow(FundOrderType2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
