﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BeneficiaryCertificationType3Code.  ISO2002 ID# _beD8wdp-Ed-ak6NoX_4Aeg_-1668346228.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of certification required.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBeneficiaryCertificationType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_beD8wdp-Ed-ak6NoX_4Aeg_-1668346228")]
public partial class BeneficiaryCertificationType3CodeDropdownSource : EnumMetadataManager<BeneficiaryCertificationType3Code,IBeneficiaryCertificationType3CodeDropdownRow,BeneficiaryCertificationType3CodeDropdownRow>
{
    public BeneficiaryCertificationType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new BeneficiaryCertificationType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
