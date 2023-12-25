﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PartyIdentificationTypeCode.  ISO2002 ID# _yG5lsEU8EeSGWeX3z5zSZQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies an alternative identification of a trading party, for example, trader code, trader name, short legal name of firm and so on.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PartyIdentificationTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IPartyIdentificationTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_yG5lsEU8EeSGWeX3z5zSZQ")]
public partial class PartyIdentificationTypeCodeDropdownRow : EnumMetadataItem<PartyIdentificationTypeCode>, IPartyIdentificationTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies an alternative identification of a trading party, for example, trader code, trader name, short legal name of firm and so on.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PartyIdentificationTypeCodeDropdownRow(PartyIdentificationTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
