﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectedStatusReason10Code.  ISO2002 ID# _ZdBSFNp-Ed-ak6NoX_4Aeg_-344862454.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a rejected status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectedStatusReason10CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZdBSFNp-Ed-ak6NoX_4Aeg_-344862454")]
public partial class RejectedStatusReason10CodeDropdownSource : EnumMetadataManager<RejectedStatusReason10Code,IRejectedStatusReason10CodeDropdownRow,RejectedStatusReason10CodeDropdownRow>
{
    public RejectedStatusReason10CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectedStatusReason10CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
