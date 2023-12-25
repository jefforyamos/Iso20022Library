﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ResidentialStatusCode.  ISO2002 ID# _ZU0_Ydp-Ed-ak6NoX_4Aeg_-1411597800.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the residential status of an individual.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IResidentialStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZU0_Ydp-Ed-ak6NoX_4Aeg_-1411597800")]
public partial class ResidentialStatusCodeDropdownSource : EnumMetadataManager<ResidentialStatusCode,IResidentialStatusCodeDropdownRow,ResidentialStatusCodeDropdownRow>
{
    public ResidentialStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ResidentialStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
