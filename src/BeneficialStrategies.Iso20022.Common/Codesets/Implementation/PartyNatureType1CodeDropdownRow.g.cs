﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PartyNatureType1Code.  ISO2002 ID# _eGrH8B3dEeWTa7N6lo4ufA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of a counterparty.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PartyNatureType1CodeDropdownSource"/>.
/// Implements <seealso cref="IPartyNatureType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_eGrH8B3dEeWTa7N6lo4ufA")]
public partial class PartyNatureType1CodeDropdownRow : EnumMetadataItem<PartyNatureType1Code>, IPartyNatureType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the nature of a counterparty.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PartyNatureType1CodeDropdownRow(PartyNatureType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
