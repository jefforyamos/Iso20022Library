﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for MarketClientSideCode.  ISO2002 ID# _aUTfYdp-Ed-ak6NoX_4Aeg_-982611626.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if an instruction is for a market or client side transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="MarketClientSideCodeDropdownSource"/>.
/// Implements <seealso cref="IMarketClientSideCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aUTfYdp-Ed-ak6NoX_4Aeg_-982611626")]
public partial class MarketClientSideCodeDropdownRow : EnumMetadataItem<MarketClientSideCode>, IMarketClientSideCodeDropdownRow
{
    /// <summary>
    /// Specifies if an instruction is for a market or client side transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public MarketClientSideCodeDropdownRow(MarketClientSideCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
