﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Algorithm24Code.  ISO2002 ID# _2gn1EQxkEeqEbo60f0v6aw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Cryptographic algorithms for the protection of transported keys.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Algorithm24CodeDropdownSource"/>.
/// Implements <seealso cref="IAlgorithm24CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_2gn1EQxkEeqEbo60f0v6aw")]
public partial class Algorithm24CodeDropdownRow : EnumMetadataItem<Algorithm24Code>, IAlgorithm24CodeDropdownRow
{
    /// <summary>
    /// Cryptographic algorithms for the protection of transported keys.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Algorithm24CodeDropdownRow(Algorithm24Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
