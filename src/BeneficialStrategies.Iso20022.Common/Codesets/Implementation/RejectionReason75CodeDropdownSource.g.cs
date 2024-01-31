﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectionReason75Code.  ISO2002 ID# _W6dCZitXEeyhipY4f42fZQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the settlement instruction has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectionReason75CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_W6dCZitXEeyhipY4f42fZQ")]
public partial class RejectionReason75CodeDropdownSource : EnumMetadataManager<RejectionReason75Code,IRejectionReason75CodeDropdownRow,RejectionReason75CodeDropdownRow>
{
    public RejectionReason75CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectionReason75CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
