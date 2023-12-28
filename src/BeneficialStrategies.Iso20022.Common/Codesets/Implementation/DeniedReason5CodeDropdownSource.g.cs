﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DeniedReason5Code.  ISO2002 ID# _avbVJdp-Ed-ak6NoX_4Aeg_279829805.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the denied reason.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDeniedReason5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_avbVJdp-Ed-ak6NoX_4Aeg_279829805")]
public partial class DeniedReason5CodeDropdownSource : EnumMetadataManager<DeniedReason5Code,IDeniedReason5CodeDropdownRow,DeniedReason5CodeDropdownRow>
{
    public DeniedReason5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DeniedReason5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}