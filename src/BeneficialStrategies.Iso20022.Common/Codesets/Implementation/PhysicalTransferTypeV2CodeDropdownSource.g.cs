﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PhysicalTransferTypeV2Code.  ISO2002 ID# _jiYPJYBAEeall68-KLgmUw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the financial instrument is to be physically delivered or is a dematerilized transfer.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPhysicalTransferTypeV2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_jiYPJYBAEeall68-KLgmUw")]
public partial class PhysicalTransferTypeV2CodeDropdownSource : EnumMetadataManager<PhysicalTransferTypeV2Code,IPhysicalTransferTypeV2CodeDropdownRow,PhysicalTransferTypeV2CodeDropdownRow>
{
    public PhysicalTransferTypeV2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PhysicalTransferTypeV2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
