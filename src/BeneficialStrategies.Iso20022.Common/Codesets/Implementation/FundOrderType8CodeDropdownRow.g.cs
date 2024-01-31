﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FundOrderType8Code.  ISO2002 ID# _y8_NwEcuEeam48hW0M8V2Q.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the category of the investment fund order.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FundOrderType8CodeDropdownSource"/>.
/// Implements <seealso cref="IFundOrderType8CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_y8_NwEcuEeam48hW0M8V2Q")]
public partial class FundOrderType8CodeDropdownRow : EnumMetadataItem<FundOrderType8Code>, IFundOrderType8CodeDropdownRow
{
    /// <summary>
    /// Specifies the category of the investment fund order.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FundOrderType8CodeDropdownRow(FundOrderType8Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
