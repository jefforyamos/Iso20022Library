﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for StandingOrderQueryType1Code.  ISO2002 ID# _8N7QVqMgEeCJ6YNENx4h-w_-234356258.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the query type for standing orders queries, that identifies the predefined key attributes expected in the response to the query.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="StandingOrderQueryType1CodeDropdownSource"/>.
/// Implements <seealso cref="IStandingOrderQueryType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8N7QVqMgEeCJ6YNENx4h-w_-234356258")]
public partial class StandingOrderQueryType1CodeDropdownRow : EnumMetadataItem<StandingOrderQueryType1Code>, IStandingOrderQueryType1CodeDropdownRow
{
    /// <summary>
    /// Defines the query type for standing orders queries, that identifies the predefined key attributes expected in the response to the query.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public StandingOrderQueryType1CodeDropdownRow(StandingOrderQueryType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
