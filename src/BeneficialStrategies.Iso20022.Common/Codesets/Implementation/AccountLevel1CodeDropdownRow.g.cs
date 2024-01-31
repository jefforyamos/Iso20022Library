﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AccountLevel1Code.  ISO2002 ID# _6Uas85qlEeGSON8vddiWzQ_44836722.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the level of an account within the account hierarchy.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AccountLevel1CodeDropdownSource"/>.
/// Implements <seealso cref="IAccountLevel1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_6Uas85qlEeGSON8vddiWzQ_44836722")]
public partial class AccountLevel1CodeDropdownRow : EnumMetadataItem<AccountLevel1Code>, IAccountLevel1CodeDropdownRow
{
    /// <summary>
    /// Defines the level of an account within the account hierarchy.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AccountLevel1CodeDropdownRow(AccountLevel1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
