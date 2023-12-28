﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TelephonyCallTypeCode.  ISO2002 ID# __R_VYPfFEei89sMSHxl1ew.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the call type
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITelephonyCallTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__R_VYPfFEei89sMSHxl1ew")]
public partial class TelephonyCallTypeCodeDropdownSource : EnumMetadataManager<TelephonyCallTypeCode,ITelephonyCallTypeCodeDropdownRow,TelephonyCallTypeCodeDropdownRow>
{
    public TelephonyCallTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TelephonyCallTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}