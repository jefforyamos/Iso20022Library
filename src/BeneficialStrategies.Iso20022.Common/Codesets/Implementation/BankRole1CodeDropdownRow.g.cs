﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BankRole1Code.  ISO2002 ID# _Mn3W4NNtEeKdOs2hjJ_3WQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role of the bank in the transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BankRole1CodeDropdownSource"/>.
/// Implements <seealso cref="IBankRole1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Mn3W4NNtEeKdOs2hjJ_3WQ")]
public partial class BankRole1CodeDropdownRow : EnumMetadataItem<BankRole1Code>, IBankRole1CodeDropdownRow
{
    /// <summary>
    /// Specifies the role of the bank in the transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BankRole1CodeDropdownRow(BankRole1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
