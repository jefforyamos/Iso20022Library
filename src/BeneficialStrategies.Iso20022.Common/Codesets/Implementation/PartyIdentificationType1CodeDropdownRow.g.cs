﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PartyIdentificationType1Code.  ISO2002 ID# _0ZEJEIA2EeSUJZYcWGKkkw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies an alternative identification of a trading party, for example, trader code, trader name, short legal name of firm and so on.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PartyIdentificationType1CodeDropdownSource"/>.
/// Implements <seealso cref="IPartyIdentificationType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_0ZEJEIA2EeSUJZYcWGKkkw")]
public partial class PartyIdentificationType1CodeDropdownRow : EnumMetadataItem<PartyIdentificationType1Code>, IPartyIdentificationType1CodeDropdownRow
{
    /// <summary>
    /// Specifies an alternative identification of a trading party, for example, trader code, trader name, short legal name of firm and so on.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PartyIdentificationType1CodeDropdownRow(PartyIdentificationType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}