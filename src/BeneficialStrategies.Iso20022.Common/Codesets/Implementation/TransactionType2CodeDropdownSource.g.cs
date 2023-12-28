﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionType2Code.  ISO2002 ID# _Yuh0Zdp-Ed-ak6NoX_4Aeg_-872010891.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yuh0Zdp-Ed-ak6NoX_4Aeg_-872010891")]
public partial class TransactionType2CodeDropdownSource : EnumMetadataManager<TransactionType2Code,ITransactionType2CodeDropdownRow,TransactionType2CodeDropdownRow>
{
    public TransactionType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}