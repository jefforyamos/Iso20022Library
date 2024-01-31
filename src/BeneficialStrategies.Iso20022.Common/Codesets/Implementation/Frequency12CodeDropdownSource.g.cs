﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Frequency12Code.  ISO2002 ID# _FLwRoOkXEemeDPHh-U9b6w.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regularity of an event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFrequency12CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_FLwRoOkXEemeDPHh-U9b6w")]
public partial class Frequency12CodeDropdownSource : EnumMetadataManager<Frequency12Code,IFrequency12CodeDropdownRow,Frequency12CodeDropdownRow>
{
    public Frequency12CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Frequency12CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
