﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BatchManagementType2Code.  ISO2002 ID# _EEiRcJb0Eeuc6pwKtqbEVQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of batch management activity.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBatchManagementType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_EEiRcJb0Eeuc6pwKtqbEVQ")]
public partial class BatchManagementType2CodeDropdownSource : EnumMetadataManager<BatchManagementType2Code,IBatchManagementType2CodeDropdownRow,BatchManagementType2CodeDropdownRow>
{
    public BatchManagementType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new BatchManagementType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
