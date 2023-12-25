﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CardDepositTypeCode.  ISO2002 ID# _nVXTF9CHEei_pMueJh_zOA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Contains the type of deposit
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CardDepositTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ICardDepositTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_nVXTF9CHEei_pMueJh_zOA")]
public partial class CardDepositTypeCodeDropdownRow : EnumMetadataItem<CardDepositTypeCode>, ICardDepositTypeCodeDropdownRow
{
    /// <summary>
    /// Contains the type of deposit
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CardDepositTypeCodeDropdownRow(CardDepositTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
