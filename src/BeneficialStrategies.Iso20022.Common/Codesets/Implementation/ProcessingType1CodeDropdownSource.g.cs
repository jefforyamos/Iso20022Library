﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ProcessingType1Code.  ISO2002 ID# _8JT2IaMgEeCJ6YNENx4h-w_-880711812.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of processing restrictions the central system must apply.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IProcessingType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8JT2IaMgEeCJ6YNENx4h-w_-880711812")]
public partial class ProcessingType1CodeDropdownSource : EnumMetadataManager<ProcessingType1Code,IProcessingType1CodeDropdownRow,ProcessingType1CodeDropdownRow>
{
    public ProcessingType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ProcessingType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
