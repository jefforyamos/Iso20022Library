﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectionReason73Code.  ISO2002 ID# _gtthpCtWEeyhipY4f42fZQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the settlement instruction has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectionReason73CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_gtthpCtWEeyhipY4f42fZQ")]
public partial class RejectionReason73CodeDropdownSource : EnumMetadataManager<RejectionReason73Code,IRejectionReason73CodeDropdownRow,RejectionReason73CodeDropdownRow>
{
    public RejectionReason73CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectionReason73CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
