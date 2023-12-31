﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AccountLevel2Code.  ISO2002 ID# _6Uas9pqlEeGSON8vddiWzQ_-1016370047.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the level of an account within the account hierarchy.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AccountLevel2CodeDropdownSource"/>.
/// Implements <seealso cref="IAccountLevel2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_6Uas9pqlEeGSON8vddiWzQ_-1016370047")]
public partial class AccountLevel2CodeDropdownRow : EnumMetadataItem<AccountLevel2Code>, IAccountLevel2CodeDropdownRow
{
    /// <summary>
    /// Defines the level of an account within the account hierarchy.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AccountLevel2CodeDropdownRow(AccountLevel2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
