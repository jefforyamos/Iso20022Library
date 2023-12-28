﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RepoCallAcknowledgementReason1Code.  ISO2002 ID# _ZwscANp-Ed-ak6NoX_4Aeg_1866536533.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies additional information about the repurchase agreement call processed instruction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRepoCallAcknowledgementReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZwscANp-Ed-ak6NoX_4Aeg_1866536533")]
public partial class RepoCallAcknowledgementReason1CodeDropdownSource : EnumMetadataManager<RepoCallAcknowledgementReason1Code,IRepoCallAcknowledgementReason1CodeDropdownRow,RepoCallAcknowledgementReason1CodeDropdownRow>
{
    public RepoCallAcknowledgementReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RepoCallAcknowledgementReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
