﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for StandingOrderQueryType1Code.  ISO2002 ID# _8N7QVqMgEeCJ6YNENx4h-w_-234356258.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the query type for standing orders queries, that identifies the predefined key attributes expected in the response to the query.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IStandingOrderQueryType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8N7QVqMgEeCJ6YNENx4h-w_-234356258")]
public partial class StandingOrderQueryType1CodeDropdownSource : EnumMetadataManager<StandingOrderQueryType1Code,IStandingOrderQueryType1CodeDropdownRow,StandingOrderQueryType1CodeDropdownRow>
{
    public StandingOrderQueryType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new StandingOrderQueryType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
