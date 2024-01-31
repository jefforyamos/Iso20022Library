﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for StoredValueAccountTypeCode.  ISO2002 ID# _gjAHYNtcEeipuvJHTHIw9A.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of stored value account.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="StoredValueAccountTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IStoredValueAccountTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_gjAHYNtcEeipuvJHTHIw9A")]
public partial class StoredValueAccountTypeCodeDropdownRow : EnumMetadataItem<StoredValueAccountTypeCode>, IStoredValueAccountTypeCodeDropdownRow
{
    /// <summary>
    /// Type of stored value account.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public StoredValueAccountTypeCodeDropdownRow(StoredValueAccountTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
