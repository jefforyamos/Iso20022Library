﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DerivativeWorkflowStatus1Code.  ISO2002 ID# _12PQkjL3EeKU9IrkkToqcw_-742843847.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of exchange's notice of change on a derivative.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDerivativeWorkflowStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_12PQkjL3EeKU9IrkkToqcw_-742843847")]
public partial class DerivativeWorkflowStatus1CodeDropdownSource : EnumMetadataManager<DerivativeWorkflowStatus1Code,IDerivativeWorkflowStatus1CodeDropdownRow,DerivativeWorkflowStatus1CodeDropdownRow>
{
    public DerivativeWorkflowStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DerivativeWorkflowStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
