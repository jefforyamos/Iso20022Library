﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AccountingStatus1Code.  ISO2002 ID# _d8OH0CDEEeWPMvNwVtiMsA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the accounting status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AccountingStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IAccountingStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_d8OH0CDEEeWPMvNwVtiMsA")]
public partial class AccountingStatus1CodeDropdownRow : EnumMetadataItem<AccountingStatus1Code>, IAccountingStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the accounting status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AccountingStatus1CodeDropdownRow(AccountingStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
