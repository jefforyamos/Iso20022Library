﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CardholderVerificationCapability3Code.  ISO2002 ID# _n75oUIn7EeShMpas3885ww.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Customer authentication capabilities available on an ATM.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CardholderVerificationCapability3CodeDropdownSource"/>.
/// Implements <seealso cref="ICardholderVerificationCapability3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_n75oUIn7EeShMpas3885ww")]
public partial class CardholderVerificationCapability3CodeDropdownRow : EnumMetadataItem<CardholderVerificationCapability3Code>, ICardholderVerificationCapability3CodeDropdownRow
{
    /// <summary>
    /// Customer authentication capabilities available on an ATM.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CardholderVerificationCapability3CodeDropdownRow(CardholderVerificationCapability3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}