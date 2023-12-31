﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AgreementFrameworkCode.  ISO2002 ID# _YbdHZdp-Ed-ak6NoX_4Aeg_630710567.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the agreement type details for the margin call.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAgreementFrameworkCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YbdHZdp-Ed-ak6NoX_4Aeg_630710567")]
public partial class AgreementFrameworkCodeDropdownSource : EnumMetadataManager<AgreementFrameworkCode,IAgreementFrameworkCodeDropdownRow,AgreementFrameworkCodeDropdownRow>
{
    public AgreementFrameworkCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AgreementFrameworkCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
