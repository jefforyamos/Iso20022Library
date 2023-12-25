﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for HoldingAccountLevelCode.  ISO2002 ID# _SvcYkU1pEeSvz4A_x0ui8g.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the level of the safekeeping holding account.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IHoldingAccountLevelCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_SvcYkU1pEeSvz4A_x0ui8g")]
public partial class HoldingAccountLevelCodeDropdownSource : EnumMetadataManager<HoldingAccountLevelCode,IHoldingAccountLevelCodeDropdownRow,HoldingAccountLevelCodeDropdownRow>
{
    public HoldingAccountLevelCodeDropdownSource()
        : base( (enumValue, memberInfo) => new HoldingAccountLevelCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
