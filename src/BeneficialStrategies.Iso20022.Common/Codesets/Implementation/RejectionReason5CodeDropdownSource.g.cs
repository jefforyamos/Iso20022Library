﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectionReason5Code.  ISO2002 ID# _ZlEa09p-Ed-ak6NoX_4Aeg_2116688390.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectionReason5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZlEa09p-Ed-ak6NoX_4Aeg_2116688390")]
public partial class RejectionReason5CodeDropdownSource : EnumMetadataManager<RejectionReason5Code,IRejectionReason5CodeDropdownRow,RejectionReason5CodeDropdownRow>
{
    public RejectionReason5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectionReason5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
