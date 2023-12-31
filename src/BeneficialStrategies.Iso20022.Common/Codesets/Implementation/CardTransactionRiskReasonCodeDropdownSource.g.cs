﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CardTransactionRiskReasonCode.  ISO2002 ID# _1GyxYHsKEeSR68OJvMfxJQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Reason to indicate a certain level of risk for the transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICardTransactionRiskReasonCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1GyxYHsKEeSR68OJvMfxJQ")]
public partial class CardTransactionRiskReasonCodeDropdownSource : EnumMetadataManager<CardTransactionRiskReasonCode,ICardTransactionRiskReasonCodeDropdownRow,CardTransactionRiskReasonCodeDropdownRow>
{
    public CardTransactionRiskReasonCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CardTransactionRiskReasonCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
