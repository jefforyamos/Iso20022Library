﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectedStatusReason13Code.  ISO2002 ID# _AlouseijEeuLe8v4JEtDDg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a transfer or settlement instruction rejected status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectedStatusReason13CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_AlouseijEeuLe8v4JEtDDg")]
public partial class RejectedStatusReason13CodeDropdownSource : EnumMetadataManager<RejectedStatusReason13Code,IRejectedStatusReason13CodeDropdownRow,RejectedStatusReason13CodeDropdownRow>
{
    public RejectedStatusReason13CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectedStatusReason13CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
