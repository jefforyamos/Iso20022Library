﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AwaitingAffirmationReason1Code.  ISO2002 ID# __0Jx09ojEeC60axPepSq7g_-961152106.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction has an awaiting affirmation status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAwaitingAffirmationReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__0Jx09ojEeC60axPepSq7g_-961152106")]
public partial class AwaitingAffirmationReason1CodeDropdownSource : EnumMetadataManager<AwaitingAffirmationReason1Code,IAwaitingAffirmationReason1CodeDropdownRow,AwaitingAffirmationReason1CodeDropdownRow>
{
    public AwaitingAffirmationReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AwaitingAffirmationReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
