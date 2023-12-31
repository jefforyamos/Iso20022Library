﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ResolutionTypeCode.  ISO2002 ID# _ZU-JVtp-Ed-ak6NoX_4Aeg_861792439.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of resolution.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IResolutionTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZU-JVtp-Ed-ak6NoX_4Aeg_861792439")]
public partial class ResolutionTypeCodeDropdownSource : EnumMetadataManager<ResolutionTypeCode,IResolutionTypeCodeDropdownRow,ResolutionTypeCodeDropdownRow>
{
    public ResolutionTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ResolutionTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
