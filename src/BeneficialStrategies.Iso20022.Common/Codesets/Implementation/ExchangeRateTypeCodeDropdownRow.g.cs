﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExchangeRateTypeCode.  ISO2002 ID# _ak11w9p-Ed-ak6NoX_4Aeg_-83850044.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code used to define the type of the currency exchange.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExchangeRateTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IExchangeRateTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ak11w9p-Ed-ak6NoX_4Aeg_-83850044")]
public partial class ExchangeRateTypeCodeDropdownRow : EnumMetadataItem<ExchangeRateTypeCode>, IExchangeRateTypeCodeDropdownRow
{
    /// <summary>
    /// Code used to define the type of the currency exchange.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExchangeRateTypeCodeDropdownRow(ExchangeRateTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
