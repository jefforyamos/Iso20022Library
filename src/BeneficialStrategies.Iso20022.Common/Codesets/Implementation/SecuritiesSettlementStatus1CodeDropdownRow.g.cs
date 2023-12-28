﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SecuritiesSettlementStatus1Code.  ISO2002 ID# _ZFx2xdp-Ed-ak6NoX_4Aeg_1485379028.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the status of settlement of an instruction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SecuritiesSettlementStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="ISecuritiesSettlementStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZFx2xdp-Ed-ak6NoX_4Aeg_1485379028")]
public partial class SecuritiesSettlementStatus1CodeDropdownRow : EnumMetadataItem<SecuritiesSettlementStatus1Code>, ISecuritiesSettlementStatus1CodeDropdownRow
{
    /// <summary>
    /// Provides the status of settlement of an instruction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SecuritiesSettlementStatus1CodeDropdownRow(SecuritiesSettlementStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}