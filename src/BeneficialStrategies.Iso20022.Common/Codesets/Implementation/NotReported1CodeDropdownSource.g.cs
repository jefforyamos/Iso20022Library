﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for NotReported1Code.  ISO2002 ID# _UzChQNGfEeaQk737TH1Fzw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a not reported value code.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="INotReported1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_UzChQNGfEeaQk737TH1Fzw")]
public partial class NotReported1CodeDropdownSource : EnumMetadataManager<NotReported1Code,INotReported1CodeDropdownRow,NotReported1CodeDropdownRow>
{
    public NotReported1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new NotReported1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
