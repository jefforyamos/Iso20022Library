﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CardTransactionRiskReason1Code.  ISO2002 ID# _5YSw4HsMEeSR68OJvMfxJQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Reason to indicate a certain level of risk for the transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CardTransactionRiskReason1CodeDropdownSource"/>.
/// Implements <seealso cref="ICardTransactionRiskReason1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_5YSw4HsMEeSR68OJvMfxJQ")]
public partial class CardTransactionRiskReason1CodeDropdownRow : EnumMetadataItem<CardTransactionRiskReason1Code>, ICardTransactionRiskReason1CodeDropdownRow
{
    /// <summary>
    /// Reason to indicate a certain level of risk for the transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CardTransactionRiskReason1CodeDropdownRow(CardTransactionRiskReason1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}