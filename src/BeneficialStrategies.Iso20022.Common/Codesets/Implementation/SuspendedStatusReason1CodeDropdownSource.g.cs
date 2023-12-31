﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SuspendedStatusReason1Code.  ISO2002 ID# _ZQzbA9p-Ed-ak6NoX_4Aeg_689720893.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction/instruction is suspended.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISuspendedStatusReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZQzbA9p-Ed-ak6NoX_4Aeg_689720893")]
public partial class SuspendedStatusReason1CodeDropdownSource : EnumMetadataManager<SuspendedStatusReason1Code,ISuspendedStatusReason1CodeDropdownRow,SuspendedStatusReason1CodeDropdownRow>
{
    public SuspendedStatusReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SuspendedStatusReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
