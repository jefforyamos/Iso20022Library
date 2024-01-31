﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ProcessedStatus3Code.  ISO2002 ID# _aKeN-Np-Ed-ak6NoX_4Aeg_969222817.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the processing status of an advice, a request or a movement.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IProcessedStatus3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aKeN-Np-Ed-ak6NoX_4Aeg_969222817")]
public partial class ProcessedStatus3CodeDropdownSource : EnumMetadataManager<ProcessedStatus3Code,IProcessedStatus3CodeDropdownRow,ProcessedStatus3CodeDropdownRow>
{
    public ProcessedStatus3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ProcessedStatus3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
