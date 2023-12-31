﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AutoRouting1Code.  ISO2002 ID# _bj4Q5Np-Ed-ak6NoX_4Aeg_1039779413.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether an automatic routing system is involved.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAutoRouting1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bj4Q5Np-Ed-ak6NoX_4Aeg_1039779413")]
public partial class AutoRouting1CodeDropdownSource : EnumMetadataManager<AutoRouting1Code,IAutoRouting1CodeDropdownRow,AutoRouting1CodeDropdownRow>
{
    public AutoRouting1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AutoRouting1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
