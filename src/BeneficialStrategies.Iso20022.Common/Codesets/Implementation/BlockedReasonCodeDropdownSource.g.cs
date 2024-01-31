﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BlockedReasonCode.  ISO2002 ID# _iybhYxHaEeKVqeHljBM1MQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason an account is blocked.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBlockedReasonCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_iybhYxHaEeKVqeHljBM1MQ")]
public partial class BlockedReasonCodeDropdownSource : EnumMetadataManager<BlockedReasonCode,IBlockedReasonCodeDropdownRow,BlockedReasonCodeDropdownRow>
{
    public BlockedReasonCodeDropdownSource()
        : base( (enumValue, memberInfo) => new BlockedReasonCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
