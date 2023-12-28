﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ReconciliationCategoryCode.  ISO2002 ID# _tJKXo8yrEeiqqJhU2tqK8A.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Contains the reconciliation category
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IReconciliationCategoryCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_tJKXo8yrEeiqqJhU2tqK8A")]
public partial class ReconciliationCategoryCodeDropdownSource : EnumMetadataManager<ReconciliationCategoryCode,IReconciliationCategoryCodeDropdownRow,ReconciliationCategoryCodeDropdownRow>
{
    public ReconciliationCategoryCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ReconciliationCategoryCodeDropdownRow(enumValue, memberInfo))
    {
    }
}