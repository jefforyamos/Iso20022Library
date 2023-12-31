﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for IssuerCode.  ISO2002 ID# _VsEwBdp-Ed-ak6NoX_4Aeg_335333174.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the institution issuing a proprietary code.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IIssuerCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VsEwBdp-Ed-ak6NoX_4Aeg_335333174")]
public partial class IssuerCodeDropdownSource : EnumMetadataManager<IssuerCode,IIssuerCodeDropdownRow,IssuerCodeDropdownRow>
{
    public IssuerCodeDropdownSource()
        : base( (enumValue, memberInfo) => new IssuerCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
