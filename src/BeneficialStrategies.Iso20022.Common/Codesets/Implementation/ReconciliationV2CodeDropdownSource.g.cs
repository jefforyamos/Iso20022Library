﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ReconciliationV2Code.  ISO2002 ID# _FZQwYHhCEeu3kecHd7QKUQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the process type used for the trade repository reconciliation.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IReconciliationV2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_FZQwYHhCEeu3kecHd7QKUQ")]
public partial class ReconciliationV2CodeDropdownSource : EnumMetadataManager<ReconciliationV2Code,IReconciliationV2CodeDropdownRow,ReconciliationV2CodeDropdownRow>
{
    public ReconciliationV2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ReconciliationV2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
