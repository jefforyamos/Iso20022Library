﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OptionEventType1Code.  ISO2002 ID# _DbpVoMR1EeOg-a7zWL_U0A.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of event for an option.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOptionEventType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_DbpVoMR1EeOg-a7zWL_U0A")]
public partial class OptionEventType1CodeDropdownSource : EnumMetadataManager<OptionEventType1Code,IOptionEventType1CodeDropdownRow,OptionEventType1CodeDropdownRow>
{
    public OptionEventType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OptionEventType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
