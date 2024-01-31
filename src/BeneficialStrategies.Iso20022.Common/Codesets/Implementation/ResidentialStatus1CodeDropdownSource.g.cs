﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ResidentialStatus1Code.  ISO2002 ID# _ZUrOZtp-Ed-ak6NoX_4Aeg_-1428222113.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the residential status of an individual.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IResidentialStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZUrOZtp-Ed-ak6NoX_4Aeg_-1428222113")]
public partial class ResidentialStatus1CodeDropdownSource : EnumMetadataManager<ResidentialStatus1Code,IResidentialStatus1CodeDropdownRow,ResidentialStatus1CodeDropdownRow>
{
    public ResidentialStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ResidentialStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
