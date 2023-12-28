﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SafekeepingPlace2Code.  ISO2002 ID# _Y-oF5Np-Ed-ak6NoX_4Aeg_1138474587.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of place of safekeeping.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISafekeepingPlace2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Y-oF5Np-Ed-ak6NoX_4Aeg_1138474587")]
public partial class SafekeepingPlace2CodeDropdownSource : EnumMetadataManager<SafekeepingPlace2Code,ISafekeepingPlace2CodeDropdownRow,SafekeepingPlace2CodeDropdownRow>
{
    public SafekeepingPlace2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SafekeepingPlace2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
