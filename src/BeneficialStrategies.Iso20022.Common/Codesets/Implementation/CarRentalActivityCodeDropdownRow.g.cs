﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CarRentalActivityCode.  ISO2002 ID# _S_0LwFyqEeeve7Je9cXtkQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Activity type assigned to a car rental company.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CarRentalActivityCodeDropdownSource"/>.
/// Implements <seealso cref="ICarRentalActivityCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_S_0LwFyqEeeve7Je9cXtkQ")]
public partial class CarRentalActivityCodeDropdownRow : EnumMetadataItem<CarRentalActivityCode>, ICarRentalActivityCodeDropdownRow
{
    /// <summary>
    /// Activity type assigned to a car rental company.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CarRentalActivityCodeDropdownRow(CarRentalActivityCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}