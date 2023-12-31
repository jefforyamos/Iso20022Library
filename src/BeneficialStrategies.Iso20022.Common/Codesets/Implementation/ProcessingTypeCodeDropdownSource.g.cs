﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ProcessingTypeCode.  ISO2002 ID# _8JmxAKMgEeCJ6YNENx4h-w_1084364172.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of processing restrictions the central system must apply.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IProcessingTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8JmxAKMgEeCJ6YNENx4h-w_1084364172")]
public partial class ProcessingTypeCodeDropdownSource : EnumMetadataManager<ProcessingTypeCode,IProcessingTypeCodeDropdownRow,ProcessingTypeCodeDropdownRow>
{
    public ProcessingTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ProcessingTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
