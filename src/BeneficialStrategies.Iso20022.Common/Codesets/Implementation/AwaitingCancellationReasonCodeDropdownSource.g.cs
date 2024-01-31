﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AwaitingCancellationReasonCode.  ISO2002 ID# __0Ti09ojEeC60axPepSq7g_-1282873817.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction has a awaiting cancellation status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAwaitingCancellationReasonCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__0Ti09ojEeC60axPepSq7g_-1282873817")]
public partial class AwaitingCancellationReasonCodeDropdownSource : EnumMetadataManager<AwaitingCancellationReasonCode,IAwaitingCancellationReasonCodeDropdownRow,AwaitingCancellationReasonCodeDropdownRow>
{
    public AwaitingCancellationReasonCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AwaitingCancellationReasonCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
