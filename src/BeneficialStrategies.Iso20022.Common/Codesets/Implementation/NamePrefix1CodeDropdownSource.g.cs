﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for NamePrefix1Code.  ISO2002 ID# _aM_9hNp-Ed-ak6NoX_4Aeg_1660850708.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the terms used to formally address a person.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="INamePrefix1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aM_9hNp-Ed-ak6NoX_4Aeg_1660850708")]
public partial class NamePrefix1CodeDropdownSource : EnumMetadataManager<NamePrefix1Code,INamePrefix1CodeDropdownRow,NamePrefix1CodeDropdownRow>
{
    public NamePrefix1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new NamePrefix1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
