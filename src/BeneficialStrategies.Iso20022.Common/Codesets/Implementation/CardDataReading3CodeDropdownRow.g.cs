﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CardDataReading3Code.  ISO2002 ID# _GvpZEHr4EeSZrs_hiwNOWA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Card writing capabilities of the terminal performing the transaction. 
/// It correspond to the ISO 8583, field number 22-10 for the version 93, and 27-8_9 for the version 2003.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CardDataReading3CodeDropdownSource"/>.
/// Implements <seealso cref="ICardDataReading3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_GvpZEHr4EeSZrs_hiwNOWA")]
public partial class CardDataReading3CodeDropdownRow : EnumMetadataItem<CardDataReading3Code>, ICardDataReading3CodeDropdownRow
{
    /// <summary>
    /// Card writing capabilities of the terminal performing the transaction. 
    /// It correspond to the ISO 8583, field number 22-10 for the version 93, and 27-8_9 for the version 2003.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CardDataReading3CodeDropdownRow(CardDataReading3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
