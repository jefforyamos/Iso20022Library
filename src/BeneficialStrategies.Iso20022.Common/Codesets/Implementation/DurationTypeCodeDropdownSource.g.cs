﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DurationTypeCode.  ISO2002 ID# _SuhYsA3eEeW9YKj3GUmIEw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the duration of the delivery period.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDurationTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_SuhYsA3eEeW9YKj3GUmIEw")]
public partial class DurationTypeCodeDropdownSource : EnumMetadataManager<DurationTypeCode,IDurationTypeCodeDropdownRow,DurationTypeCodeDropdownRow>
{
    public DurationTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DurationTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
