﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OptionStyle2Code.  ISO2002 ID# _aQIxFtp-Ed-ak6NoX_4Aeg_-1177091144.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines how an option can be exercised.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOptionStyle2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aQIxFtp-Ed-ak6NoX_4Aeg_-1177091144")]
public partial class OptionStyle2CodeDropdownSource : EnumMetadataManager<OptionStyle2Code,IOptionStyle2CodeDropdownRow,OptionStyle2CodeDropdownRow>
{
    public OptionStyle2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OptionStyle2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
