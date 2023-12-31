﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for StatusSubType2Code.  ISO2002 ID# _EcL4QZU-EeaYkf5FCqYMeA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the sub status of the trade notification.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IStatusSubType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_EcL4QZU-EeaYkf5FCqYMeA")]
public partial class StatusSubType2CodeDropdownSource : EnumMetadataManager<StatusSubType2Code,IStatusSubType2CodeDropdownRow,StatusSubType2CodeDropdownRow>
{
    public StatusSubType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new StatusSubType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
