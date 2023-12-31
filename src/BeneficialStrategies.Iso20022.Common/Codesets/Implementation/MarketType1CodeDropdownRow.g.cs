﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for MarketType1Code.  ISO2002 ID# _aUTfZNp-Ed-ak6NoX_4Aeg_2050093734.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of market in which transactions take place, eg, primary.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="MarketType1CodeDropdownSource"/>.
/// Implements <seealso cref="IMarketType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aUTfZNp-Ed-ak6NoX_4Aeg_2050093734")]
public partial class MarketType1CodeDropdownRow : EnumMetadataItem<MarketType1Code>, IMarketType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of market in which transactions take place, eg, primary.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public MarketType1CodeDropdownRow(MarketType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
