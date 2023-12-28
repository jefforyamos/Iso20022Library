﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Priority2Code.  ISO2002 ID# _aKLTBNp-Ed-ak6NoX_4Aeg_-581472374.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the priority level of an event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPriority2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aKLTBNp-Ed-ak6NoX_4Aeg_-581472374")]
public partial class Priority2CodeDropdownSource : EnumMetadataManager<Priority2Code,IPriority2CodeDropdownRow,Priority2CodeDropdownRow>
{
    public Priority2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Priority2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}