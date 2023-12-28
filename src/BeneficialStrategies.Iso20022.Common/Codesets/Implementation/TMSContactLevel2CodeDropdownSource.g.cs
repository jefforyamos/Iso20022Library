﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TMSContactLevel2Code.  ISO2002 ID# _cNM_kIqKEeSRT5rEzcAHEw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Urgency of the command.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITMSContactLevel2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_cNM_kIqKEeSRT5rEzcAHEw")]
public partial class TMSContactLevel2CodeDropdownSource : EnumMetadataManager<TMSContactLevel2Code,ITMSContactLevel2CodeDropdownRow,TMSContactLevel2CodeDropdownRow>
{
    public TMSContactLevel2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TMSContactLevel2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}