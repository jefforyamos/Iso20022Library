﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AccountChoiceMethodCode.  ISO2002 ID# _IwRRkHs7EeSTS7uHCe8FPQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Method used by the cardholder and the terminal for the choice of the account.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AccountChoiceMethodCodeDropdownSource"/>.
/// Implements <seealso cref="IAccountChoiceMethodCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_IwRRkHs7EeSTS7uHCe8FPQ")]
public partial class AccountChoiceMethodCodeDropdownRow : EnumMetadataItem<AccountChoiceMethodCode>, IAccountChoiceMethodCodeDropdownRow
{
    /// <summary>
    /// Method used by the cardholder and the terminal for the choice of the account.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AccountChoiceMethodCodeDropdownRow(AccountChoiceMethodCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
