﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Priority4Code.  ISO2002 ID# _jc3ekMmJEeWAGphE2LvqeA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the priority level of an event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPriority4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_jc3ekMmJEeWAGphE2LvqeA")]
public partial class Priority4CodeDropdownSource : EnumMetadataManager<Priority4Code,IPriority4CodeDropdownRow,Priority4CodeDropdownRow>
{
    public Priority4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Priority4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}