﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradeConfirmationTypeCode.  ISO2002 ID# _aR8RMQ26EeWmAKKPnqYEVQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the contract was electronically confirmed, non-electronically confirmed or remains unconfirmed.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradeConfirmationTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aR8RMQ26EeWmAKKPnqYEVQ")]
public partial class TradeConfirmationTypeCodeDropdownSource : EnumMetadataManager<TradeConfirmationTypeCode,ITradeConfirmationTypeCodeDropdownRow,TradeConfirmationTypeCodeDropdownRow>
{
    public TradeConfirmationTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradeConfirmationTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}