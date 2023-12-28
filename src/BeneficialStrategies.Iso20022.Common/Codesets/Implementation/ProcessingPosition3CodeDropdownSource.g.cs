﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ProcessingPosition3Code.  ISO2002 ID# _aK655tp-Ed-ak6NoX_4Aeg_-1877116911.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the processing position.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IProcessingPosition3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aK655tp-Ed-ak6NoX_4Aeg_-1877116911")]
public partial class ProcessingPosition3CodeDropdownSource : EnumMetadataManager<ProcessingPosition3Code,IProcessingPosition3CodeDropdownRow,ProcessingPosition3CodeDropdownRow>
{
    public ProcessingPosition3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ProcessingPosition3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}