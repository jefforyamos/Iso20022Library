﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransferStatus3Code.  ISO2002 ID# _pHI5gBwfEeOIveEnnb_1-A.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the transfer or settlement instruction status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransferStatus3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_pHI5gBwfEeOIveEnnb_1-A")]
public partial class TransferStatus3CodeDropdownSource : EnumMetadataManager<TransferStatus3Code,ITransferStatus3CodeDropdownRow,TransferStatus3CodeDropdownRow>
{
    public TransferStatus3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransferStatus3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
