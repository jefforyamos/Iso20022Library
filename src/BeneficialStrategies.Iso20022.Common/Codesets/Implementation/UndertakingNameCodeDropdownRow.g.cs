﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for UndertakingNameCode.  ISO2002 ID# _aIyKoHyjEeGWJuGCfvwOsQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the named type of the undertaking.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="UndertakingNameCodeDropdownSource"/>.
/// Implements <seealso cref="IUndertakingNameCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aIyKoHyjEeGWJuGCfvwOsQ")]
public partial class UndertakingNameCodeDropdownRow : EnumMetadataItem<UndertakingNameCode>, IUndertakingNameCodeDropdownRow
{
    /// <summary>
    /// Specifies the named type of the undertaking.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public UndertakingNameCodeDropdownRow(UndertakingNameCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
