﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionActivityCode.  ISO2002 ID# _YrP25tp-Ed-ak6NoX_4Aeg_-41180042.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of activity to which this transaction relates.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionActivityCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YrP25tp-Ed-ak6NoX_4Aeg_-41180042")]
public partial class TransactionActivityCodeDropdownSource : EnumMetadataManager<TransactionActivityCode,ITransactionActivityCodeDropdownRow,TransactionActivityCodeDropdownRow>
{
    public TransactionActivityCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionActivityCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
