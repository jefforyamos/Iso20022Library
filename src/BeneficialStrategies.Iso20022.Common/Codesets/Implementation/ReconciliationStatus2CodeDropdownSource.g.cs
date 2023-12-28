﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ReconciliationStatus2Code.  ISO2002 ID# _y7hV0T5zEe2Z1_pdMHu4SA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicator if reconciliation of derivatives for which all the reconcilable fields are within the allowed tolerances.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IReconciliationStatus2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_y7hV0T5zEe2Z1_pdMHu4SA")]
public partial class ReconciliationStatus2CodeDropdownSource : EnumMetadataManager<ReconciliationStatus2Code,IReconciliationStatus2CodeDropdownRow,ReconciliationStatus2CodeDropdownRow>
{
    public ReconciliationStatus2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ReconciliationStatus2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
