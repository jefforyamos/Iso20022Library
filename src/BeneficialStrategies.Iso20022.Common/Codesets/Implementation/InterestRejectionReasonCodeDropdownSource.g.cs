﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InterestRejectionReasonCode.  ISO2002 ID# _YbKMdNp-Ed-ak6NoX_4Aeg_-1204468675.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether the interest request is rejected due a value date or an interest amount difference.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInterestRejectionReasonCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YbKMdNp-Ed-ak6NoX_4Aeg_-1204468675")]
public partial class InterestRejectionReasonCodeDropdownSource : EnumMetadataManager<InterestRejectionReasonCode,IInterestRejectionReasonCodeDropdownRow,InterestRejectionReasonCodeDropdownRow>
{
    public InterestRejectionReasonCodeDropdownSource()
        : base( (enumValue, memberInfo) => new InterestRejectionReasonCodeDropdownRow(enumValue, memberInfo))
    {
    }
}