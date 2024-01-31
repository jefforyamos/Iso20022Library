﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ChequeDeliveryCode.  ISO2002 ID# _a-oOxdp-Ed-ak6NoX_4Aeg_337061457.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the method to be used in delivering a cheque to a party.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ChequeDeliveryCodeDropdownSource"/>.
/// Implements <seealso cref="IChequeDeliveryCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a-oOxdp-Ed-ak6NoX_4Aeg_337061457")]
public partial class ChequeDeliveryCodeDropdownRow : EnumMetadataItem<ChequeDeliveryCode>, IChequeDeliveryCodeDropdownRow
{
    /// <summary>
    /// Specifies the method to be used in delivering a cheque to a party.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ChequeDeliveryCodeDropdownRow(ChequeDeliveryCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
