﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AccountingStatusCode.  ISO2002 ID# _Kl0T0CDEEeWPMvNwVtiMsA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the accounting status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AccountingStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IAccountingStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Kl0T0CDEEeWPMvNwVtiMsA")]
public partial class AccountingStatusCodeDropdownRow : EnumMetadataItem<AccountingStatusCode>, IAccountingStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the accounting status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AccountingStatusCodeDropdownRow(AccountingStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
