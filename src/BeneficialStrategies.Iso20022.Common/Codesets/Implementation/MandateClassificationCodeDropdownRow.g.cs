﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for MandateClassificationCode.  ISO2002 ID# _zmsM1mVQEeacpJ-gG9kyUQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of direct debit amount, such as fixed or variable.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="MandateClassificationCodeDropdownSource"/>.
/// Implements <seealso cref="IMandateClassificationCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_zmsM1mVQEeacpJ-gG9kyUQ")]
public partial class MandateClassificationCodeDropdownRow : EnumMetadataItem<MandateClassificationCode>, IMandateClassificationCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of direct debit amount, such as fixed or variable.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public MandateClassificationCodeDropdownRow(MandateClassificationCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
