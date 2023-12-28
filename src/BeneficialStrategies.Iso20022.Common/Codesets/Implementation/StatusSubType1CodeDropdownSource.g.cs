﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for StatusSubType1Code.  ISO2002 ID# _8VSYwB3cEeKXIbeXfdPzuw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the sub status of the trade notification.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IStatusSubType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8VSYwB3cEeKXIbeXfdPzuw")]
public partial class StatusSubType1CodeDropdownSource : EnumMetadataManager<StatusSubType1Code,IStatusSubType1CodeDropdownRow,StatusSubType1CodeDropdownRow>
{
    public StatusSubType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new StatusSubType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
