﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DeliverReturnCode.  ISO2002 ID# _YcMuRdp-Ed-ak6NoX_4Aeg_-662678761.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if the collateral is to be delivered or returned.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DeliverReturnCodeDropdownSource"/>.
/// Implements <seealso cref="IDeliverReturnCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YcMuRdp-Ed-ak6NoX_4Aeg_-662678761")]
public partial class DeliverReturnCodeDropdownRow : EnumMetadataItem<DeliverReturnCode>, IDeliverReturnCodeDropdownRow
{
    /// <summary>
    /// Specifies if the collateral is to be delivered or returned.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DeliverReturnCodeDropdownRow(DeliverReturnCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}