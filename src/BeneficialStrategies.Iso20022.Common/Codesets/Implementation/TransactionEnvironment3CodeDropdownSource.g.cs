﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionEnvironment3Code.  ISO2002 ID# _3dTnsHsIEeSR68OJvMfxJQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the entity hosting the terminal performing the transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionEnvironment3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_3dTnsHsIEeSR68OJvMfxJQ")]
public partial class TransactionEnvironment3CodeDropdownSource : EnumMetadataManager<TransactionEnvironment3Code,ITransactionEnvironment3CodeDropdownRow,TransactionEnvironment3CodeDropdownRow>
{
    public TransactionEnvironment3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionEnvironment3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}