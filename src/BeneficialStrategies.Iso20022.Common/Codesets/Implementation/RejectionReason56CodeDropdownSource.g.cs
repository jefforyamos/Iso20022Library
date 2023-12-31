﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectionReason56Code.  ISO2002 ID# _ReBJIe6BEeqc-LCjwLsUVg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction request has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectionReason56CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ReBJIe6BEeqc-LCjwLsUVg")]
public partial class RejectionReason56CodeDropdownSource : EnumMetadataManager<RejectionReason56Code,IRejectionReason56CodeDropdownRow,RejectionReason56CodeDropdownRow>
{
    public RejectionReason56CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectionReason56CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
