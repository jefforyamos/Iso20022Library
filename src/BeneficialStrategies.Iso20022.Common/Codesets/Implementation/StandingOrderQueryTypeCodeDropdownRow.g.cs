﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for StandingOrderQueryTypeCode.  ISO2002 ID# _8NxfVaMgEeCJ6YNENx4h-w_73506953.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the query type for standing orders queries, that identifies the predefined key attributes expected in the response to the query.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="StandingOrderQueryTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IStandingOrderQueryTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8NxfVaMgEeCJ6YNENx4h-w_73506953")]
public partial class StandingOrderQueryTypeCodeDropdownRow : EnumMetadataItem<StandingOrderQueryTypeCode>, IStandingOrderQueryTypeCodeDropdownRow
{
    /// <summary>
    /// Defines the query type for standing orders queries, that identifies the predefined key attributes expected in the response to the query.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public StandingOrderQueryTypeCodeDropdownRow(StandingOrderQueryTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}