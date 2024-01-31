﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for UnderlyingTypeCode.  ISO2002 ID# _Y2IRNdp-Ed-ak6NoX_4Aeg_-2038676269.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying financial instrument.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IUnderlyingTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Y2IRNdp-Ed-ak6NoX_4Aeg_-2038676269")]
public partial class UnderlyingTypeCodeDropdownSource : EnumMetadataManager<UnderlyingTypeCode,IUnderlyingTypeCodeDropdownRow,UnderlyingTypeCodeDropdownRow>
{
    public UnderlyingTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new UnderlyingTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
