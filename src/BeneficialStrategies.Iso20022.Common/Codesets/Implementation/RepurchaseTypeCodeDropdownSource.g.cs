﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RepurchaseTypeCode.  ISO2002 ID# _ZT7ngNp-Ed-ak6NoX_4Aeg_605345255.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Relates to a principal adjustment.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRepurchaseTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZT7ngNp-Ed-ak6NoX_4Aeg_605345255")]
public partial class RepurchaseTypeCodeDropdownSource : EnumMetadataManager<RepurchaseTypeCode,IRepurchaseTypeCodeDropdownRow,RepurchaseTypeCodeDropdownRow>
{
    public RepurchaseTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new RepurchaseTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
