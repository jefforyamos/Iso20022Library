﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for UndertakingStatusCode.  ISO2002 ID# _uQUrMHykEeGWJuGCfvwOsQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the undertaking status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="UndertakingStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IUndertakingStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_uQUrMHykEeGWJuGCfvwOsQ")]
public partial class UndertakingStatusCodeDropdownRow : EnumMetadataItem<UndertakingStatusCode>, IUndertakingStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the undertaking status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public UndertakingStatusCodeDropdownRow(UndertakingStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
