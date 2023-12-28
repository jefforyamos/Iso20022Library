﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectedStatusReason9Code.  ISO2002 ID# _ZfG8yNp-Ed-ak6NoX_4Aeg_-2116539809.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Reason for which an instruction, request, report message is rejected.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectedStatusReason9CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZfG8yNp-Ed-ak6NoX_4Aeg_-2116539809")]
public partial class RejectedStatusReason9CodeDropdownSource : EnumMetadataManager<RejectedStatusReason9Code,IRejectedStatusReason9CodeDropdownRow,RejectedStatusReason9CodeDropdownRow>
{
    public RejectedStatusReason9CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectedStatusReason9CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
