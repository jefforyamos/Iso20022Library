﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ConditionallyAcceptedStatusReason2Code.  ISO2002 ID# _bA3DYdp-Ed-ak6NoX_4Aeg_-1241620271.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a conditionally accepted status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IConditionallyAcceptedStatusReason2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bA3DYdp-Ed-ak6NoX_4Aeg_-1241620271")]
public partial class ConditionallyAcceptedStatusReason2CodeDropdownSource : EnumMetadataManager<ConditionallyAcceptedStatusReason2Code,IConditionallyAcceptedStatusReason2CodeDropdownRow,ConditionallyAcceptedStatusReason2CodeDropdownRow>
{
    public ConditionallyAcceptedStatusReason2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ConditionallyAcceptedStatusReason2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}