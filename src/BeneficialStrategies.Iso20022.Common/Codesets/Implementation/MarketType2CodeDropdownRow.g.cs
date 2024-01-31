﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for MarketType2Code.  ISO2002 ID# _aUdQYdp-Ed-ak6NoX_4Aeg_-922054322.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of market in which transactions take place, for example, primary.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="MarketType2CodeDropdownSource"/>.
/// Implements <seealso cref="IMarketType2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aUdQYdp-Ed-ak6NoX_4Aeg_-922054322")]
public partial class MarketType2CodeDropdownRow : EnumMetadataItem<MarketType2Code>, IMarketType2CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of market in which transactions take place, for example, primary.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public MarketType2CodeDropdownRow(MarketType2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
