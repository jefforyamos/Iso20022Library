﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PartyType7Code.  ISO2002 ID# _cUMkAAyHEeKa_56Jbsi1RQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Party that communicate with a POI component (Point of Interaction), using a communication device.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PartyType7CodeDropdownSource"/>.
/// Implements <seealso cref="IPartyType7CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_cUMkAAyHEeKa_56Jbsi1RQ")]
public partial class PartyType7CodeDropdownRow : EnumMetadataItem<PartyType7Code>, IPartyType7CodeDropdownRow
{
    /// <summary>
    /// Party that communicate with a POI component (Point of Interaction), using a communication device.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PartyType7CodeDropdownRow(PartyType7Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}