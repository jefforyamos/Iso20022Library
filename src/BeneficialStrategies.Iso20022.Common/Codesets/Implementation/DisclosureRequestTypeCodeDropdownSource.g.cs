﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DisclosureRequestTypeCode.  ISO2002 ID# _2Py7kEV2EemRx7jyevcLwg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of disclosure request.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDisclosureRequestTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_2Py7kEV2EemRx7jyevcLwg")]
public partial class DisclosureRequestTypeCodeDropdownSource : EnumMetadataManager<DisclosureRequestTypeCode,IDisclosureRequestTypeCodeDropdownRow,DisclosureRequestTypeCodeDropdownRow>
{
    public DisclosureRequestTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DisclosureRequestTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
