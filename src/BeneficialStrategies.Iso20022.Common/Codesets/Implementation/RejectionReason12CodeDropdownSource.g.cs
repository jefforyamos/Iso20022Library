﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectionReason12Code.  ISO2002 ID# _ZgmKgdp-Ed-ak6NoX_4Aeg_1795040901.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason of a rejection of a deactivation instruction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectionReason12CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZgmKgdp-Ed-ak6NoX_4Aeg_1795040901")]
public partial class RejectionReason12CodeDropdownSource : EnumMetadataManager<RejectionReason12Code,IRejectionReason12CodeDropdownRow,RejectionReason12CodeDropdownRow>
{
    public RejectionReason12CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectionReason12CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
