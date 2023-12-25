﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for GenderCode.  ISO2002 ID# _atyWZ9p-Ed-ak6NoX_4Aeg_275832843.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the gender of a person.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IGenderCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_atyWZ9p-Ed-ak6NoX_4Aeg_275832843")]
public partial class GenderCodeDropdownSource : EnumMetadataManager<GenderCode,IGenderCodeDropdownRow,GenderCodeDropdownRow>
{
    public GenderCodeDropdownSource()
        : base( (enumValue, memberInfo) => new GenderCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
