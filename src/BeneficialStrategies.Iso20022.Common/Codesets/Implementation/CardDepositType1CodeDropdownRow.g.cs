﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CardDepositType1Code.  ISO2002 ID# _355HIC7TEemIy6A-26wnAg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Contains the type of deposit.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CardDepositType1CodeDropdownSource"/>.
/// Implements <seealso cref="ICardDepositType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_355HIC7TEemIy6A-26wnAg")]
public partial class CardDepositType1CodeDropdownRow : EnumMetadataItem<CardDepositType1Code>, ICardDepositType1CodeDropdownRow
{
    /// <summary>
    /// Contains the type of deposit.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CardDepositType1CodeDropdownRow(CardDepositType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
