﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectedConfirmationStatusReason1Code.  ISO2002 ID# _ZbYTUdp-Ed-ak6NoX_4Aeg_2141876808.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a confirmation rejected status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectedConfirmationStatusReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZbYTUdp-Ed-ak6NoX_4Aeg_2141876808")]
public partial class RejectedConfirmationStatusReason1CodeDropdownSource : EnumMetadataManager<RejectedConfirmationStatusReason1Code,IRejectedConfirmationStatusReason1CodeDropdownRow,RejectedConfirmationStatusReason1CodeDropdownRow>
{
    public RejectedConfirmationStatusReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectedConfirmationStatusReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
