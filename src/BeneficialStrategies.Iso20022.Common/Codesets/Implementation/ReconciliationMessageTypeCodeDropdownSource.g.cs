﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ReconciliationMessageTypeCode.  ISO2002 ID# _E0Tvl8yyEeiqqJhU2tqK8A.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the reconciliation type
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IReconciliationMessageTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_E0Tvl8yyEeiqqJhU2tqK8A")]
public partial class ReconciliationMessageTypeCodeDropdownSource : EnumMetadataManager<ReconciliationMessageTypeCode,IReconciliationMessageTypeCodeDropdownRow,ReconciliationMessageTypeCodeDropdownRow>
{
    public ReconciliationMessageTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ReconciliationMessageTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
