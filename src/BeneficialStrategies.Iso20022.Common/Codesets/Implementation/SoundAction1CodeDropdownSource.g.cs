﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SoundAction1Code.  ISO2002 ID# _pB5s0N6-Eeiwsev40qZGEQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of action to perform on the sound.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISoundAction1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_pB5s0N6-Eeiwsev40qZGEQ")]
public partial class SoundAction1CodeDropdownSource : EnumMetadataManager<SoundAction1Code,ISoundAction1CodeDropdownRow,SoundAction1CodeDropdownRow>
{
    public SoundAction1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SoundAction1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
