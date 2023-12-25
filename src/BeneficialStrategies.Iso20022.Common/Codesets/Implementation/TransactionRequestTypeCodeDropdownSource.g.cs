﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionRequestTypeCode.  ISO2002 ID# _0-HZ0GKCEeGByYwyG-c4ow.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of information request related to a transaction number.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionRequestTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_0-HZ0GKCEeGByYwyG-c4ow")]
public partial class TransactionRequestTypeCodeDropdownSource : EnumMetadataManager<TransactionRequestTypeCode,ITransactionRequestTypeCodeDropdownRow,TransactionRequestTypeCodeDropdownRow>
{
    public TransactionRequestTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionRequestTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
