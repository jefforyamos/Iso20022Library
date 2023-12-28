﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransferInFunction1Code.  ISO2002 ID# _iCdscCVOEeWI0orciOKunQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the function of the transfer in.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransferInFunction1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_iCdscCVOEeWI0orciOKunQ")]
public partial class TransferInFunction1CodeDropdownSource : EnumMetadataManager<TransferInFunction1Code,ITransferInFunction1CodeDropdownRow,TransferInFunction1CodeDropdownRow>
{
    public TransferInFunction1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransferInFunction1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
