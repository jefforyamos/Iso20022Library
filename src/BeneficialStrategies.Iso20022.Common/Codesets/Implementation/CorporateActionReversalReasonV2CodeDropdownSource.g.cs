﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionReversalReasonV2Code.  ISO2002 ID# _DUt1SjQVEe2o-K1dwNg8Gg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// The reason why a reversal of payment is taking place in corporate action processing.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionReversalReasonV2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_DUt1SjQVEe2o-K1dwNg8Gg")]
public partial class CorporateActionReversalReasonV2CodeDropdownSource : EnumMetadataManager<CorporateActionReversalReasonV2Code,ICorporateActionReversalReasonV2CodeDropdownRow,CorporateActionReversalReasonV2CodeDropdownRow>
{
    public CorporateActionReversalReasonV2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionReversalReasonV2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}