﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectionReason66Code.  ISO2002 ID# _K34k1RnyEeyroI8qKgB7Mg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction request has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectionReason66CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_K34k1RnyEeyroI8qKgB7Mg")]
public partial class RejectionReason66CodeDropdownSource : EnumMetadataManager<RejectionReason66Code,IRejectionReason66CodeDropdownRow,RejectionReason66CodeDropdownRow>
{
    public RejectionReason66CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectionReason66CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
