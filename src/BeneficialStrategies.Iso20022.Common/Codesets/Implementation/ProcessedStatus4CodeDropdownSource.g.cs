﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ProcessedStatus4Code.  ISO2002 ID# _aKnX49p-Ed-ak6NoX_4Aeg_1007090482.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the processing status of the standing instruction cancellation request.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IProcessedStatus4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aKnX49p-Ed-ak6NoX_4Aeg_1007090482")]
public partial class ProcessedStatus4CodeDropdownSource : EnumMetadataManager<ProcessedStatus4Code,IProcessedStatus4CodeDropdownRow,ProcessedStatus4CodeDropdownRow>
{
    public ProcessedStatus4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ProcessedStatus4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}