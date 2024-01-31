﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ReconciliationImpact1Code.  ISO2002 ID# _-kRtwC7OEemIy6A-26wnAg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reconciliation credit or debit indicator.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IReconciliationImpact1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-kRtwC7OEemIy6A-26wnAg")]
public partial class ReconciliationImpact1CodeDropdownSource : EnumMetadataManager<ReconciliationImpact1Code,IReconciliationImpact1CodeDropdownRow,ReconciliationImpact1CodeDropdownRow>
{
    public ReconciliationImpact1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ReconciliationImpact1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
