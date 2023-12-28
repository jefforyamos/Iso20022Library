﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for LocationCategory4Code.  ISO2002 ID# _3eb_cFDdEeu8Rss-tto59A.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the type of integration of the POI terminal in the sale environment.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="LocationCategory4CodeDropdownSource"/>.
/// Implements <seealso cref="ILocationCategory4CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_3eb_cFDdEeu8Rss-tto59A")]
public partial class LocationCategory4CodeDropdownRow : EnumMetadataItem<LocationCategory4Code>, ILocationCategory4CodeDropdownRow
{
    /// <summary>
    /// Indicates the type of integration of the POI terminal in the sale environment.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public LocationCategory4CodeDropdownRow(LocationCategory4Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
