﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransferUnmatchedReason3Code.  ISO2002 ID# _qfeCYJM5EemKz5EOjv82iQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction, transfer or settlement instruction is unmatched.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransferUnmatchedReason3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_qfeCYJM5EemKz5EOjv82iQ")]
public partial class TransferUnmatchedReason3CodeDropdownSource : EnumMetadataManager<TransferUnmatchedReason3Code,ITransferUnmatchedReason3CodeDropdownRow,TransferUnmatchedReason3CodeDropdownRow>
{
    public TransferUnmatchedReason3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransferUnmatchedReason3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}