﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionGroupStatus2Code.  ISO2002 ID# _YrjY5dp-Ed-ak6NoX_4Aeg_14174870.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a group of payment transactions.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionGroupStatus2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YrjY5dp-Ed-ak6NoX_4Aeg_14174870")]
public partial class TransactionGroupStatus2CodeDropdownSource : EnumMetadataManager<TransactionGroupStatus2Code,ITransactionGroupStatus2CodeDropdownRow,TransactionGroupStatus2CodeDropdownRow>
{
    public TransactionGroupStatus2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionGroupStatus2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
