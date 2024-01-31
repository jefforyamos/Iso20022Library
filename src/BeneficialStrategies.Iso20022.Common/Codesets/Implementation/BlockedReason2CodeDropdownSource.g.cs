﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BlockedReason2Code.  ISO2002 ID# _lXE7oFsMEeaY86V9afpFqA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason an account is blocked.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBlockedReason2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_lXE7oFsMEeaY86V9afpFqA")]
public partial class BlockedReason2CodeDropdownSource : EnumMetadataManager<BlockedReason2Code,IBlockedReason2CodeDropdownRow,BlockedReason2CodeDropdownRow>
{
    public BlockedReason2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new BlockedReason2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
