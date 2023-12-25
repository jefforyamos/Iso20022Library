﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ChargeBearerCode.  ISO2002 ID# _a8F4Itp-Ed-ak6NoX_4Aeg_-746027402.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies which party(ies) will pay charges due for processing of the payment transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ChargeBearerCodeDropdownSource"/>.
/// Implements <seealso cref="IChargeBearerCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a8F4Itp-Ed-ak6NoX_4Aeg_-746027402")]
public partial class ChargeBearerCodeDropdownRow : EnumMetadataItem<ChargeBearerCode>, IChargeBearerCodeDropdownRow
{
    /// <summary>
    /// Specifies which party(ies) will pay charges due for processing of the payment transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ChargeBearerCodeDropdownRow(ChargeBearerCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
