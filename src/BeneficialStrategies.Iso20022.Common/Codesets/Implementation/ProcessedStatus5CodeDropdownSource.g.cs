﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ProcessedStatus5Code.  ISO2002 ID# _aKnX59p-Ed-ak6NoX_4Aeg_980305985.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the processing status of a request.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IProcessedStatus5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aKnX59p-Ed-ak6NoX_4Aeg_980305985")]
public partial class ProcessedStatus5CodeDropdownSource : EnumMetadataManager<ProcessedStatus5Code,IProcessedStatus5CodeDropdownRow,ProcessedStatus5CodeDropdownRow>
{
    public ProcessedStatus5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ProcessedStatus5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
