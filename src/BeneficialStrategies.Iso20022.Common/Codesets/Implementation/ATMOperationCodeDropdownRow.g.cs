﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ATMOperationCode.  ISO2002 ID# _VNYCoOhAEeSbwP3G-MV9YA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of logical or physical operation on an ATM.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ATMOperationCodeDropdownSource"/>.
/// Implements <seealso cref="IATMOperationCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VNYCoOhAEeSbwP3G-MV9YA")]
public partial class ATMOperationCodeDropdownRow : EnumMetadataItem<ATMOperationCode>, IATMOperationCodeDropdownRow
{
    /// <summary>
    /// Type of logical or physical operation on an ATM.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ATMOperationCodeDropdownRow(ATMOperationCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}