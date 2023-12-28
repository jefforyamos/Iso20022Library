﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for GeneratedReason3Code.  ISO2002 ID# _OAFTICRjEeOCueHDQ36sww.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the transaction was generated.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IGeneratedReason3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_OAFTICRjEeOCueHDQ36sww")]
public partial class GeneratedReason3CodeDropdownSource : EnumMetadataManager<GeneratedReason3Code,IGeneratedReason3CodeDropdownRow,GeneratedReason3CodeDropdownRow>
{
    public GeneratedReason3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new GeneratedReason3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
