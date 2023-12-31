﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DebtInstrumentSeniorityTypeCode.  ISO2002 ID# _Uq4csc4tEeSc85GUbgBycw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the seniority type of a specific debt instrument.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DebtInstrumentSeniorityTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IDebtInstrumentSeniorityTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Uq4csc4tEeSc85GUbgBycw")]
public partial class DebtInstrumentSeniorityTypeCodeDropdownRow : EnumMetadataItem<DebtInstrumentSeniorityTypeCode>, IDebtInstrumentSeniorityTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the seniority type of a specific debt instrument.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DebtInstrumentSeniorityTypeCodeDropdownRow(DebtInstrumentSeniorityTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
