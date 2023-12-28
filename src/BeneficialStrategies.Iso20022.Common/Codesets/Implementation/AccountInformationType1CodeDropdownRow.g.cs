﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AccountInformationType1Code.  ISO2002 ID# _I_zgUH6GEeSAlrUr1Vow5g.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of account information.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AccountInformationType1CodeDropdownSource"/>.
/// Implements <seealso cref="IAccountInformationType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_I_zgUH6GEeSAlrUr1Vow5g")]
public partial class AccountInformationType1CodeDropdownRow : EnumMetadataItem<AccountInformationType1Code>, IAccountInformationType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of account information.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AccountInformationType1CodeDropdownRow(AccountInformationType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}