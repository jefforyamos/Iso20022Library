﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ConditionallyAcceptedStatusReason1Code.  ISO2002 ID# _Vjk7Vtp-Ed-ak6NoX_4Aeg_-149220072.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a conditionally accepted status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IConditionallyAcceptedStatusReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Vjk7Vtp-Ed-ak6NoX_4Aeg_-149220072")]
public partial class ConditionallyAcceptedStatusReason1CodeDropdownSource : EnumMetadataManager<ConditionallyAcceptedStatusReason1Code,IConditionallyAcceptedStatusReason1CodeDropdownRow,ConditionallyAcceptedStatusReason1CodeDropdownRow>
{
    public ConditionallyAcceptedStatusReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ConditionallyAcceptedStatusReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}