﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ServicePaymentMethodCode.  ISO2002 ID# _6WDrtJqlEeGSON8vddiWzQ_387174603.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the method for the payment of the tax applied on the services.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ServicePaymentMethodCodeDropdownSource"/>.
/// Implements <seealso cref="IServicePaymentMethodCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_6WDrtJqlEeGSON8vddiWzQ_387174603")]
public partial class ServicePaymentMethodCodeDropdownRow : EnumMetadataItem<ServicePaymentMethodCode>, IServicePaymentMethodCodeDropdownRow
{
    /// <summary>
    /// Defines the method for the payment of the tax applied on the services.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ServicePaymentMethodCodeDropdownRow(ServicePaymentMethodCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
