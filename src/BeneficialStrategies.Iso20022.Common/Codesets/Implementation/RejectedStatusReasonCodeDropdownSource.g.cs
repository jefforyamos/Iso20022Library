﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectedStatusReasonCode.  ISO2002 ID# _ZfQtyNp-Ed-ak6NoX_4Aeg_99789863.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Cash settlement date is not recognised or is invalid.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectedStatusReasonCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZfQtyNp-Ed-ak6NoX_4Aeg_99789863")]
public partial class RejectedStatusReasonCodeDropdownSource : EnumMetadataManager<RejectedStatusReasonCode,IRejectedStatusReasonCodeDropdownRow,RejectedStatusReasonCodeDropdownRow>
{
    public RejectedStatusReasonCodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectedStatusReasonCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
