﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for POIComponentStatusCode.  ISO2002 ID# _d4opsAxwEeKa_56Jbsi1RQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Status of a component belonging to a POI Terminal (Point of Interaction).
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="POIComponentStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IPOIComponentStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_d4opsAxwEeKa_56Jbsi1RQ")]
public partial class POIComponentStatusCodeDropdownRow : EnumMetadataItem<POIComponentStatusCode>, IPOIComponentStatusCodeDropdownRow
{
    /// <summary>
    /// Status of a component belonging to a POI Terminal (Point of Interaction).
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public POIComponentStatusCodeDropdownRow(POIComponentStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
