﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionInitiatorCode.  ISO2002 ID# _jfoDtmzfEemD24gVaMSpeA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the transaction initiator.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionInitiatorCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_jfoDtmzfEemD24gVaMSpeA")]
public partial class TransactionInitiatorCodeDropdownSource : EnumMetadataManager<TransactionInitiatorCode,ITransactionInitiatorCodeDropdownRow,TransactionInitiatorCodeDropdownRow>
{
    public TransactionInitiatorCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionInitiatorCodeDropdownRow(enumValue, memberInfo))
    {
    }
}