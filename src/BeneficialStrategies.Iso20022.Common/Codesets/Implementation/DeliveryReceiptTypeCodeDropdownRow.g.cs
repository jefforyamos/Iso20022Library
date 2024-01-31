﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DeliveryReceiptTypeCode.  ISO2002 ID# _azTIgNp-Ed-ak6NoX_4Aeg_-314094989.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how the transaction is to be settled.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DeliveryReceiptTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IDeliveryReceiptTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_azTIgNp-Ed-ak6NoX_4Aeg_-314094989")]
public partial class DeliveryReceiptTypeCodeDropdownRow : EnumMetadataItem<DeliveryReceiptTypeCode>, IDeliveryReceiptTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies how the transaction is to be settled.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DeliveryReceiptTypeCodeDropdownRow(DeliveryReceiptTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
