﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExecutionTimeLimitCode.  ISO2002 ID# _ak_mydp-Ed-ak6NoX_4Aeg_1584923071.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates from/until when an order must be executed.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExecutionTimeLimitCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ak_mydp-Ed-ak6NoX_4Aeg_1584923071")]
public partial class ExecutionTimeLimitCodeDropdownSource : EnumMetadataManager<ExecutionTimeLimitCode,IExecutionTimeLimitCodeDropdownRow,ExecutionTimeLimitCodeDropdownRow>
{
    public ExecutionTimeLimitCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExecutionTimeLimitCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
