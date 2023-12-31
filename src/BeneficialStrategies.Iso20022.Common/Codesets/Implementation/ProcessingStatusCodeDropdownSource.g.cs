﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ProcessingStatusCode.  ISO2002 ID# _aLN009p-Ed-ak6NoX_4Aeg_-1445203123.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the processing status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IProcessingStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aLN009p-Ed-ak6NoX_4Aeg_-1445203123")]
public partial class ProcessingStatusCodeDropdownSource : EnumMetadataManager<ProcessingStatusCode,IProcessingStatusCodeDropdownRow,ProcessingStatusCodeDropdownRow>
{
    public ProcessingStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ProcessingStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
