﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SoundFormatCode.  ISO2002 ID# _ADcV0N6_Eeiwsev40qZGEQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of sound to play.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISoundFormatCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ADcV0N6_Eeiwsev40qZGEQ")]
public partial class SoundFormatCodeDropdownSource : EnumMetadataManager<SoundFormatCode,ISoundFormatCodeDropdownRow,SoundFormatCodeDropdownRow>
{
    public SoundFormatCodeDropdownSource()
        : base( (enumValue, memberInfo) => new SoundFormatCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
