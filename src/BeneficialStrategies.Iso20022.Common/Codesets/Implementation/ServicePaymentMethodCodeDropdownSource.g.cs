﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ServicePaymentMethodCode.  ISO2002 ID# _6WDrtJqlEeGSON8vddiWzQ_387174603.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the method for the payment of the tax applied on the services.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IServicePaymentMethodCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_6WDrtJqlEeGSON8vddiWzQ_387174603")]
public partial class ServicePaymentMethodCodeDropdownSource : EnumMetadataManager<ServicePaymentMethodCode,IServicePaymentMethodCodeDropdownRow,ServicePaymentMethodCodeDropdownRow>
{
    public ServicePaymentMethodCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ServicePaymentMethodCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
