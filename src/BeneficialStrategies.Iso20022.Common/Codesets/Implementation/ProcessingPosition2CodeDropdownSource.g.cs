﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ProcessingPosition2Code.  ISO2002 ID# _aK654dp-Ed-ak6NoX_4Aeg_-853418510.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the processing position.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IProcessingPosition2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aK654dp-Ed-ak6NoX_4Aeg_-853418510")]
public partial class ProcessingPosition2CodeDropdownSource : EnumMetadataManager<ProcessingPosition2Code,IProcessingPosition2CodeDropdownRow,ProcessingPosition2CodeDropdownRow>
{
    public ProcessingPosition2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ProcessingPosition2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
