﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FundOrderType3Code.  ISO2002 ID# _atCvhdp-Ed-ak6NoX_4Aeg_1398779632.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the category of the investment fund order.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FundOrderType3CodeDropdownSource"/>.
/// Implements <seealso cref="IFundOrderType3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_atCvhdp-Ed-ak6NoX_4Aeg_1398779632")]
public partial class FundOrderType3CodeDropdownRow : EnumMetadataItem<FundOrderType3Code>, IFundOrderType3CodeDropdownRow
{
    /// <summary>
    /// Specifies the category of the investment fund order.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FundOrderType3CodeDropdownRow(FundOrderType3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
