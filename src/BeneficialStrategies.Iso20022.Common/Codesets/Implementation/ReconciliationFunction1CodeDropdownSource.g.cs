﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ReconciliationFunction1Code.  ISO2002 ID# _rWAiEC7OEemIy6A-26wnAg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the message is a request for totals or to convey totals. 
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IReconciliationFunction1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_rWAiEC7OEemIy6A-26wnAg")]
public partial class ReconciliationFunction1CodeDropdownSource : EnumMetadataManager<ReconciliationFunction1Code,IReconciliationFunction1CodeDropdownRow,ReconciliationFunction1CodeDropdownRow>
{
    public ReconciliationFunction1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ReconciliationFunction1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
