﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionReversalReasonCode.  ISO2002 ID# _bS5OlNp-Ed-ak6NoX_4Aeg_-778821731.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// The reason why a reversal of payment is taking place in corporate action processing.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionReversalReasonCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bS5OlNp-Ed-ak6NoX_4Aeg_-778821731")]
public partial class CorporateActionReversalReasonCodeDropdownSource : EnumMetadataManager<CorporateActionReversalReasonCode,ICorporateActionReversalReasonCodeDropdownRow,CorporateActionReversalReasonCodeDropdownRow>
{
    public CorporateActionReversalReasonCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionReversalReasonCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
