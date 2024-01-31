﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SettlingCapacity2Code.  ISO2002 ID# _4R0NYCW2EeOslcz0TJwprQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role of the party in the settlement of the transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SettlingCapacity2CodeDropdownSource"/>.
/// Implements <seealso cref="ISettlingCapacity2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_4R0NYCW2EeOslcz0TJwprQ")]
public partial class SettlingCapacity2CodeDropdownRow : EnumMetadataItem<SettlingCapacity2Code>, ISettlingCapacity2CodeDropdownRow
{
    /// <summary>
    /// Specifies the role of the party in the settlement of the transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SettlingCapacity2CodeDropdownRow(SettlingCapacity2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
