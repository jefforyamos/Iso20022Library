﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AccountType1Code.  ISO2002 ID# _brn3ptp-Ed-ak6NoX_4Aeg_-1407974386.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of account.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AccountType1CodeDropdownSource"/>.
/// Implements <seealso cref="IAccountType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_brn3ptp-Ed-ak6NoX_4Aeg_-1407974386")]
public partial class AccountType1CodeDropdownRow : EnumMetadataItem<AccountType1Code>, IAccountType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of account.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AccountType1CodeDropdownRow(AccountType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
