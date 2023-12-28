﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InputSource1Code.  ISO2002 ID# _m9EHgMmMEeWAGphE2LvqeA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the input source for the generation of the file.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInputSource1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_m9EHgMmMEeWAGphE2LvqeA")]
public partial class InputSource1CodeDropdownSource : EnumMetadataManager<InputSource1Code,IInputSource1CodeDropdownRow,InputSource1CodeDropdownRow>
{
    public InputSource1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new InputSource1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}