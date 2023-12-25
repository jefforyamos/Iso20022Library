﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for StatusSubTypeCode.  ISO2002 ID# _T_BfoB3cEeKXIbeXfdPzuw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the sub status of the trade notification.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IStatusSubTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_T_BfoB3cEeKXIbeXfdPzuw")]
public partial class StatusSubTypeCodeDropdownSource : EnumMetadataManager<StatusSubTypeCode,IStatusSubTypeCodeDropdownRow,StatusSubTypeCodeDropdownRow>
{
    public StatusSubTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new StatusSubTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
