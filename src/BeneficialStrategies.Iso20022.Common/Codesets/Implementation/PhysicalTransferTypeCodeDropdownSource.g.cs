﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PhysicalTransferTypeCode.  ISO2002 ID# _XGHPAPrqEeCJc7cZxzE2fg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the financial instrument is to be physically delivered or is a dematerialised transfer.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPhysicalTransferTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_XGHPAPrqEeCJc7cZxzE2fg")]
public partial class PhysicalTransferTypeCodeDropdownSource : EnumMetadataManager<PhysicalTransferTypeCode,IPhysicalTransferTypeCodeDropdownRow,PhysicalTransferTypeCodeDropdownRow>
{
    public PhysicalTransferTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new PhysicalTransferTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
