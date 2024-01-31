﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for KeyUsage1Code.  ISO2002 ID# _KSJO8H1DEeCF8NjrBemJWQ_1886720027.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Allowed usages of the key.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="KeyUsage1CodeDropdownSource"/>.
/// Implements <seealso cref="IKeyUsage1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KSJO8H1DEeCF8NjrBemJWQ_1886720027")]
public partial class KeyUsage1CodeDropdownRow : EnumMetadataItem<KeyUsage1Code>, IKeyUsage1CodeDropdownRow
{
    /// <summary>
    /// Allowed usages of the key.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public KeyUsage1CodeDropdownRow(KeyUsage1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
