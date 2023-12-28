﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExchangeRateType2Code.  ISO2002 ID# _YuZqcIZ3Eeufof77RM8ObQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code used to define the type of the currency exchange.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExchangeRateType2CodeDropdownSource"/>.
/// Implements <seealso cref="IExchangeRateType2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YuZqcIZ3Eeufof77RM8ObQ")]
public partial class ExchangeRateType2CodeDropdownRow : EnumMetadataItem<ExchangeRateType2Code>, IExchangeRateType2CodeDropdownRow
{
    /// <summary>
    /// Code used to define the type of the currency exchange.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExchangeRateType2CodeDropdownRow(ExchangeRateType2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}