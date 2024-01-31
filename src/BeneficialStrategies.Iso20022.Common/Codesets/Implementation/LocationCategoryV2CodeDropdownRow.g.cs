﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for LocationCategoryV2Code.  ISO2002 ID# _TweHIFDdEeu8Rss-tto59A.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Location category code of the place where the merchant actually performed the transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="LocationCategoryV2CodeDropdownSource"/>.
/// Implements <seealso cref="ILocationCategoryV2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TweHIFDdEeu8Rss-tto59A")]
public partial class LocationCategoryV2CodeDropdownRow : EnumMetadataItem<LocationCategoryV2Code>, ILocationCategoryV2CodeDropdownRow
{
    /// <summary>
    /// Location category code of the place where the merchant actually performed the transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public LocationCategoryV2CodeDropdownRow(LocationCategoryV2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
