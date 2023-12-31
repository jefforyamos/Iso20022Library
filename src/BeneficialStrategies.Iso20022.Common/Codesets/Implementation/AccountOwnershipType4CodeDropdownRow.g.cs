﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AccountOwnershipType4Code.  ISO2002 ID# _o23nwL-GEeWfsa741pI6WA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of account ownership.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AccountOwnershipType4CodeDropdownSource"/>.
/// Implements <seealso cref="IAccountOwnershipType4CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_o23nwL-GEeWfsa741pI6WA")]
public partial class AccountOwnershipType4CodeDropdownRow : EnumMetadataItem<AccountOwnershipType4Code>, IAccountOwnershipType4CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of account ownership.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AccountOwnershipType4CodeDropdownRow(AccountOwnershipType4Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
