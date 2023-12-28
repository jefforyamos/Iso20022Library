﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for KeyUsageCode.  ISO2002 ID# _KSSY6H1DEeCF8NjrBemJWQ_-383369433.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Allowed usages of the key.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="KeyUsageCodeDropdownSource"/>.
/// Implements <seealso cref="IKeyUsageCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KSSY6H1DEeCF8NjrBemJWQ_-383369433")]
public partial class KeyUsageCodeDropdownRow : EnumMetadataItem<KeyUsageCode>, IKeyUsageCodeDropdownRow
{
    /// <summary>
    /// Allowed usages of the key.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public KeyUsageCodeDropdownRow(KeyUsageCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}