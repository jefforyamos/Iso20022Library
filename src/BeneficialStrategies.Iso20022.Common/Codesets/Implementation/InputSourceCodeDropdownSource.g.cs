﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InputSourceCode.  ISO2002 ID# _XuZk8MmMEeWAGphE2LvqeA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the input source for the generation of the file.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInputSourceCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_XuZk8MmMEeWAGphE2LvqeA")]
public partial class InputSourceCodeDropdownSource : EnumMetadataManager<InputSourceCode,IInputSourceCodeDropdownRow,InputSourceCodeDropdownRow>
{
    public InputSourceCodeDropdownSource()
        : base( (enumValue, memberInfo) => new InputSourceCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
