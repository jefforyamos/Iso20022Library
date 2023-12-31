﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PartiallySettledStatusReason1Code.  ISO2002 ID# _ZxSR59p-Ed-ak6NoX_4Aeg_-674686926.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a partially settled status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPartiallySettledStatusReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZxSR59p-Ed-ak6NoX_4Aeg_-674686926")]
public partial class PartiallySettledStatusReason1CodeDropdownSource : EnumMetadataManager<PartiallySettledStatusReason1Code,IPartiallySettledStatusReason1CodeDropdownRow,PartiallySettledStatusReason1CodeDropdownRow>
{
    public PartiallySettledStatusReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PartiallySettledStatusReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
