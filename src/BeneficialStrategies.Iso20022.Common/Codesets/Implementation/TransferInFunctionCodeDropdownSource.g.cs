﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransferInFunctionCode.  ISO2002 ID# _cP0N0CVNEeWI0orciOKunQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the function of the transfer in.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransferInFunctionCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_cP0N0CVNEeWI0orciOKunQ")]
public partial class TransferInFunctionCodeDropdownSource : EnumMetadataManager<TransferInFunctionCode,ITransferInFunctionCodeDropdownRow,TransferInFunctionCodeDropdownRow>
{
    public TransferInFunctionCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransferInFunctionCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
