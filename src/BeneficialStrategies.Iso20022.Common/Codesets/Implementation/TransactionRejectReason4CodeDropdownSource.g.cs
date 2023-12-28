﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionRejectReason4Code.  ISO2002 ID# _Ytochtp-Ed-ak6NoX_4Aeg_702218812.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a transaction to be rejected or returned by an instructed agent or somebody acting on behalf of an instructed agent.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionRejectReason4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Ytochtp-Ed-ak6NoX_4Aeg_702218812")]
public partial class TransactionRejectReason4CodeDropdownSource : EnumMetadataManager<TransactionRejectReason4Code,ITransactionRejectReason4CodeDropdownRow,TransactionRejectReason4CodeDropdownRow>
{
    public TransactionRejectReason4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionRejectReason4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
