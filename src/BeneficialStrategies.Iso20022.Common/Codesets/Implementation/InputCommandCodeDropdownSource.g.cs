﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InputCommandCode.  ISO2002 ID# _jBTTwN6nEeiwsev40qZGEQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of requested input.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInputCommandCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_jBTTwN6nEeiwsev40qZGEQ")]
public partial class InputCommandCodeDropdownSource : EnumMetadataManager<InputCommandCode,IInputCommandCodeDropdownRow,InputCommandCodeDropdownRow>
{
    public InputCommandCodeDropdownSource()
        : base( (enumValue, memberInfo) => new InputCommandCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
