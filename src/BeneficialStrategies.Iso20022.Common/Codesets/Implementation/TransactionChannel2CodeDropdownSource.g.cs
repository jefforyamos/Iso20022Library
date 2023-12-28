﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionChannel2Code.  ISO2002 ID# _y2ltsBRFEeOKWo1NF21OVw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of communication channel.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionChannel2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_y2ltsBRFEeOKWo1NF21OVw")]
public partial class TransactionChannel2CodeDropdownSource : EnumMetadataManager<TransactionChannel2Code,ITransactionChannel2CodeDropdownRow,TransactionChannel2CodeDropdownRow>
{
    public TransactionChannel2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionChannel2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
