﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DeliveryTypeCode.  ISO2002 ID# _azv0c9p-Ed-ak6NoX_4Aeg_-799855242.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes the delivery or custody arrangement for the underlying securities.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DeliveryTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IDeliveryTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_azv0c9p-Ed-ak6NoX_4Aeg_-799855242")]
public partial class DeliveryTypeCodeDropdownRow : EnumMetadataItem<DeliveryTypeCode>, IDeliveryTypeCodeDropdownRow
{
    /// <summary>
    /// Describes the delivery or custody arrangement for the underlying securities.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DeliveryTypeCodeDropdownRow(DeliveryTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
