﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExecutionTimeLimit1Code.  ISO2002 ID# _ak11x9p-Ed-ak6NoX_4Aeg_1168575945.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates from/until when an order must be executed.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExecutionTimeLimit1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ak11x9p-Ed-ak6NoX_4Aeg_1168575945")]
public partial class ExecutionTimeLimit1CodeDropdownSource : EnumMetadataManager<ExecutionTimeLimit1Code,IExecutionTimeLimit1CodeDropdownRow,ExecutionTimeLimit1CodeDropdownRow>
{
    public ExecutionTimeLimit1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExecutionTimeLimit1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
