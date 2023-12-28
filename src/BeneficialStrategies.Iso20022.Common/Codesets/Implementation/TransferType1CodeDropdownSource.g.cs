﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransferType1Code.  ISO2002 ID# _YvbMR9p-Ed-ak6NoX_4Aeg_-1593227544.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the financial instrument is transferred as an asset or as cash.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransferType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YvbMR9p-Ed-ak6NoX_4Aeg_-1593227544")]
public partial class TransferType1CodeDropdownSource : EnumMetadataManager<TransferType1Code,ITransferType1CodeDropdownRow,TransferType1CodeDropdownRow>
{
    public TransferType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransferType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
