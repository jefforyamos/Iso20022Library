﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionType1Code.  ISO2002 ID# _YuYqcdp-Ed-ak6NoX_4Aeg_451159608.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YuYqcdp-Ed-ak6NoX_4Aeg_451159608")]
public partial class TransactionType1CodeDropdownSource : EnumMetadataManager<TransactionType1Code,ITransactionType1CodeDropdownRow,TransactionType1CodeDropdownRow>
{
    public TransactionType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
