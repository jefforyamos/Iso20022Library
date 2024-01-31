﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionIndividualStatus4Code.  ISO2002 ID# _PKmAgKEXEeaGKbT2u7DmyA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a single payment transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionIndividualStatus4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_PKmAgKEXEeaGKbT2u7DmyA")]
public partial class TransactionIndividualStatus4CodeDropdownSource : EnumMetadataManager<TransactionIndividualStatus4Code,ITransactionIndividualStatus4CodeDropdownRow,TransactionIndividualStatus4CodeDropdownRow>
{
    public TransactionIndividualStatus4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionIndividualStatus4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
