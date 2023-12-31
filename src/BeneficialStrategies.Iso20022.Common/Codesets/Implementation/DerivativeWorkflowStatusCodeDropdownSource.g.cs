﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DerivativeWorkflowStatusCode.  ISO2002 ID# _12FfkzL3EeKU9IrkkToqcw_-117083409.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of exchange's notice of change on a derivative.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDerivativeWorkflowStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_12FfkzL3EeKU9IrkkToqcw_-117083409")]
public partial class DerivativeWorkflowStatusCodeDropdownSource : EnumMetadataManager<DerivativeWorkflowStatusCode,IDerivativeWorkflowStatusCodeDropdownRow,DerivativeWorkflowStatusCodeDropdownRow>
{
    public DerivativeWorkflowStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DerivativeWorkflowStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
