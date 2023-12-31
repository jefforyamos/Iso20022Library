﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ShareRankingCode.  ISO2002 ID# _ZOkmaNp-Ed-ak6NoX_4Aeg_1801695812.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the shares are ranking for dividend or pari passu.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IShareRankingCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZOkmaNp-Ed-ak6NoX_4Aeg_1801695812")]
public partial class ShareRankingCodeDropdownSource : EnumMetadataManager<ShareRankingCode,IShareRankingCodeDropdownRow,ShareRankingCodeDropdownRow>
{
    public ShareRankingCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ShareRankingCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
