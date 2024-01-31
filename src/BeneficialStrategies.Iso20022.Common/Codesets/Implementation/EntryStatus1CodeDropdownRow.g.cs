﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for EntryStatus1Code.  ISO2002 ID# _ahauU9p-Ed-ak6NoX_4Aeg_-773188206.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an entry.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="EntryStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IEntryStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ahauU9p-Ed-ak6NoX_4Aeg_-773188206")]
public partial class EntryStatus1CodeDropdownRow : EnumMetadataItem<EntryStatus1Code>, IEntryStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of an entry.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public EntryStatus1CodeDropdownRow(EntryStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
