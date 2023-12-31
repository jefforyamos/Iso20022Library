﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for NonTradingDayReason1Code.  ISO2002 ID# _dktzIGw5EeWD9e8QDBgUOw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason capturing a non trading day.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="INonTradingDayReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_dktzIGw5EeWD9e8QDBgUOw")]
public partial class NonTradingDayReason1CodeDropdownSource : EnumMetadataManager<NonTradingDayReason1Code,INonTradingDayReason1CodeDropdownRow,NonTradingDayReason1CodeDropdownRow>
{
    public NonTradingDayReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new NonTradingDayReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
