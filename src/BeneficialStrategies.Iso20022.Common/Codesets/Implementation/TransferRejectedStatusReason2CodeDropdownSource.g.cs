﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransferRejectedStatusReason2Code.  ISO2002 ID# _YurlZ9p-Ed-ak6NoX_4Aeg_-1737790311.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a transfer or settlement instruction rejected status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransferRejectedStatusReason2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YurlZ9p-Ed-ak6NoX_4Aeg_-1737790311")]
public partial class TransferRejectedStatusReason2CodeDropdownSource : EnumMetadataManager<TransferRejectedStatusReason2Code,ITransferRejectedStatusReason2CodeDropdownRow,TransferRejectedStatusReason2CodeDropdownRow>
{
    public TransferRejectedStatusReason2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransferRejectedStatusReason2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
