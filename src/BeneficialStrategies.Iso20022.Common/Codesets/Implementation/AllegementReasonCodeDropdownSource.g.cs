﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AllegementReasonCode.  ISO2002 ID# __0Jx0dojEeC60axPepSq7g_-2133812073.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction has an allegement status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAllegementReasonCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__0Jx0dojEeC60axPepSq7g_-2133812073")]
public partial class AllegementReasonCodeDropdownSource : EnumMetadataManager<AllegementReasonCode,IAllegementReasonCodeDropdownRow,AllegementReasonCodeDropdownRow>
{
    public AllegementReasonCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AllegementReasonCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
