﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectionReason46Code.  ISO2002 ID# _1hMokYlpEeavwKddCbm3hg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction request has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectionReason46CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1hMokYlpEeavwKddCbm3hg")]
public partial class RejectionReason46CodeDropdownSource : EnumMetadataManager<RejectionReason46Code,IRejectionReason46CodeDropdownRow,RejectionReason46CodeDropdownRow>
{
    public RejectionReason46CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectionReason46CodeDropdownRow(enumValue, memberInfo))
    {
    }
}