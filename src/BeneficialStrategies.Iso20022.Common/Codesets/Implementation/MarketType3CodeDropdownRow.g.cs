﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for MarketType3Code.  ISO2002 ID# _aUdQZ9p-Ed-ak6NoX_4Aeg_986076424.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of market in which transactions take place, for example, primary or secondary.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="MarketType3CodeDropdownSource"/>.
/// Implements <seealso cref="IMarketType3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aUdQZ9p-Ed-ak6NoX_4Aeg_986076424")]
public partial class MarketType3CodeDropdownRow : EnumMetadataItem<MarketType3Code>, IMarketType3CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of market in which transactions take place, for example, primary or secondary.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public MarketType3CodeDropdownRow(MarketType3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
