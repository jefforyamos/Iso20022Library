﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionEnvironment1Code.  ISO2002 ID# _TUAMPgEcEeCQm6a_G2yO_w_704662992.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the environment of the transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionEnvironment1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TUAMPgEcEeCQm6a_G2yO_w_704662992")]
public partial class TransactionEnvironment1CodeDropdownSource : EnumMetadataManager<TransactionEnvironment1Code,ITransactionEnvironment1CodeDropdownRow,TransactionEnvironment1CodeDropdownRow>
{
    public TransactionEnvironment1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionEnvironment1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
