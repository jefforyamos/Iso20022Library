﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SettledStatusReason1Code.  ISO2002 ID# _ZKsL8dp-Ed-ak6NoX_4Aeg_228584754.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a partially settled status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISettledStatusReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZKsL8dp-Ed-ak6NoX_4Aeg_228584754")]
public partial class SettledStatusReason1CodeDropdownSource : EnumMetadataManager<SettledStatusReason1Code,ISettledStatusReason1CodeDropdownRow,SettledStatusReason1CodeDropdownRow>
{
    public SettledStatusReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SettledStatusReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
