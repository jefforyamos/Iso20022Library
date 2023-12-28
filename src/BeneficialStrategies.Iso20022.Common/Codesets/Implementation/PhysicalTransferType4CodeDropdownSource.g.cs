﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PhysicalTransferType4Code.  ISO2002 ID# _nzrsQIBAEeall68-KLgmUw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the asset delivery type when the financial instrument is settled.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPhysicalTransferType4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_nzrsQIBAEeall68-KLgmUw")]
public partial class PhysicalTransferType4CodeDropdownSource : EnumMetadataManager<PhysicalTransferType4Code,IPhysicalTransferType4CodeDropdownRow,PhysicalTransferType4CodeDropdownRow>
{
    public PhysicalTransferType4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PhysicalTransferType4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}