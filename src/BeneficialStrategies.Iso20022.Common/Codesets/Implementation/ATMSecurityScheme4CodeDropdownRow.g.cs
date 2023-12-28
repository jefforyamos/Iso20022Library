﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ATMSecurityScheme4Code.  ISO2002 ID# _bbRtkV2ZEeekzJIz1JxYSQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Key exchange security schemes implemented in the hardware security module of the ATM.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ATMSecurityScheme4CodeDropdownSource"/>.
/// Implements <seealso cref="IATMSecurityScheme4CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bbRtkV2ZEeekzJIz1JxYSQ")]
public partial class ATMSecurityScheme4CodeDropdownRow : EnumMetadataItem<ATMSecurityScheme4Code>, IATMSecurityScheme4CodeDropdownRow
{
    /// <summary>
    /// Key exchange security schemes implemented in the hardware security module of the ATM.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ATMSecurityScheme4CodeDropdownRow(ATMSecurityScheme4Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}