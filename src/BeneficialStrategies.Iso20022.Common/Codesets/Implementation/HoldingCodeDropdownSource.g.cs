﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for HoldingCode.  ISO2002 ID# _lwDTkxKfEeKj15WxqwlXPw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how the holding is blocked.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IHoldingCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_lwDTkxKfEeKj15WxqwlXPw")]
public partial class HoldingCodeDropdownSource : EnumMetadataManager<HoldingCode,IHoldingCodeDropdownRow,HoldingCodeDropdownRow>
{
    public HoldingCodeDropdownSource()
        : base( (enumValue, memberInfo) => new HoldingCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
