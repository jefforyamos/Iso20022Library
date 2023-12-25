﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CardAccountTypeCode.  ISO2002 ID# _TV8F7AEcEeCQm6a_G2yO_w_398677392.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of cardholder account used for the transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CardAccountTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ICardAccountTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TV8F7AEcEeCQm6a_G2yO_w_398677392")]
public partial class CardAccountTypeCodeDropdownRow : EnumMetadataItem<CardAccountTypeCode>, ICardAccountTypeCodeDropdownRow
{
    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CardAccountTypeCodeDropdownRow(CardAccountTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
