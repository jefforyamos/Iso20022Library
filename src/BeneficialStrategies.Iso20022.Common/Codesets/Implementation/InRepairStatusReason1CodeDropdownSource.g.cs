﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InRepairStatusReason1Code.  ISO2002 ID# _aWsFBdp-Ed-ak6NoX_4Aeg_2109635063.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a In Repair status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInRepairStatusReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aWsFBdp-Ed-ak6NoX_4Aeg_2109635063")]
public partial class InRepairStatusReason1CodeDropdownSource : EnumMetadataManager<InRepairStatusReason1Code,IInRepairStatusReason1CodeDropdownRow,InRepairStatusReason1CodeDropdownRow>
{
    public InRepairStatusReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new InRepairStatusReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
