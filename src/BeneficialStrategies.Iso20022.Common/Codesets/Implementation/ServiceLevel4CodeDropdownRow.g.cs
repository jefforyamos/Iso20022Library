﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ServiceLevel4Code.  ISO2002 ID# _ZKjCBNp-Ed-ak6NoX_4Aeg_918510660.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the pre-agreed level of service between the parties.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ServiceLevel4CodeDropdownSource"/>.
/// Implements <seealso cref="IServiceLevel4CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZKjCBNp-Ed-ak6NoX_4Aeg_918510660")]
public partial class ServiceLevel4CodeDropdownRow : EnumMetadataItem<ServiceLevel4Code>, IServiceLevel4CodeDropdownRow
{
    /// <summary>
    /// Specifies the pre-agreed level of service between the parties.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ServiceLevel4CodeDropdownRow(ServiceLevel4Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
