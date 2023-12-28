﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ServiceTaxDesignationCode.  ISO2002 ID# _6WNctpqlEeGSON8vddiWzQ_739430745.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the taxable status of the service.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ServiceTaxDesignationCodeDropdownSource"/>.
/// Implements <seealso cref="IServiceTaxDesignationCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_6WNctpqlEeGSON8vddiWzQ_739430745")]
public partial class ServiceTaxDesignationCodeDropdownRow : EnumMetadataItem<ServiceTaxDesignationCode>, IServiceTaxDesignationCodeDropdownRow
{
    /// <summary>
    /// Defines the taxable status of the service.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ServiceTaxDesignationCodeDropdownRow(ServiceTaxDesignationCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}