﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for LevelOfControlCode.  ISO2002 ID# _Y7LFQCDDEeWPMvNwVtiMsA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the level of control.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ILevelOfControlCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Y7LFQCDDEeWPMvNwVtiMsA")]
public partial class LevelOfControlCodeDropdownSource : EnumMetadataManager<LevelOfControlCode,ILevelOfControlCodeDropdownRow,LevelOfControlCodeDropdownRow>
{
    public LevelOfControlCodeDropdownSource()
        : base( (enumValue, memberInfo) => new LevelOfControlCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
