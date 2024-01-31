﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionReturnReason1Code.  ISO2002 ID# _Vw_FMdp-Ed-ak6NoX_4Aeg_1585481359.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a transaction to be rejected or returned by an instructed agent or somebody acting on behalf of an instructed agent.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionReturnReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Vw_FMdp-Ed-ak6NoX_4Aeg_1585481359")]
public partial class TransactionReturnReason1CodeDropdownSource : EnumMetadataManager<TransactionReturnReason1Code,ITransactionReturnReason1CodeDropdownRow,TransactionReturnReason1CodeDropdownRow>
{
    public TransactionReturnReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionReturnReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
