﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BalanceTransferWindow1Code.  ISO2002 ID# _K2bYsH6qEeePx-IqKegQ8Q.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the processing window in which the balance transfer will be processed on the switch date.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBalanceTransferWindow1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_K2bYsH6qEeePx-IqKegQ8Q")]
public partial class BalanceTransferWindow1CodeDropdownSource : EnumMetadataManager<BalanceTransferWindow1Code,IBalanceTransferWindow1CodeDropdownRow,BalanceTransferWindow1CodeDropdownRow>
{
    public BalanceTransferWindow1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new BalanceTransferWindow1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
