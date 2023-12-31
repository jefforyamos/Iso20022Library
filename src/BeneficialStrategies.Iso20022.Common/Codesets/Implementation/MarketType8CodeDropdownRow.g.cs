﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for MarketType8Code.  ISO2002 ID# _90JVoDzyEeWLuazO9XdCTg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of place where a trade was executed, a price was sourced from, an instrument is listed.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="MarketType8CodeDropdownSource"/>.
/// Implements <seealso cref="IMarketType8CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_90JVoDzyEeWLuazO9XdCTg")]
public partial class MarketType8CodeDropdownRow : EnumMetadataItem<MarketType8Code>, IMarketType8CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of place where a trade was executed, a price was sourced from, an instrument is listed.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public MarketType8CodeDropdownRow(MarketType8Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
