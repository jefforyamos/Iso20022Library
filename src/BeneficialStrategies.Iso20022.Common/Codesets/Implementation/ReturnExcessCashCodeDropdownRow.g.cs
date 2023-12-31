﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ReturnExcessCashCode.  ISO2002 ID# _F-c7MALdEeutW5-TpeYJhA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates if excess cash collateral in the currency is automatically returned as per the collateral provider’s Excess Cash Margin Instruction (colr.017).
/// 
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ReturnExcessCashCodeDropdownSource"/>.
/// Implements <seealso cref="IReturnExcessCashCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_F-c7MALdEeutW5-TpeYJhA")]
public partial class ReturnExcessCashCodeDropdownRow : EnumMetadataItem<ReturnExcessCashCode>, IReturnExcessCashCodeDropdownRow
{
    /// <summary>
    /// Indicates if excess cash collateral in the currency is automatically returned as per the collateral provider’s Excess Cash Margin Instruction (colr.017).
    /// 
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ReturnExcessCashCodeDropdownRow(ReturnExcessCashCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
