﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for StandingOrderQueryTypeCode.  ISO2002 ID# _8NxfVaMgEeCJ6YNENx4h-w_73506953.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the query type for standing orders queries, that identifies the predefined key attributes expected in the response to the query.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IStandingOrderQueryTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8NxfVaMgEeCJ6YNENx4h-w_73506953")]
public partial class StandingOrderQueryTypeCodeDropdownSource : EnumMetadataManager<StandingOrderQueryTypeCode,IStandingOrderQueryTypeCodeDropdownRow,StandingOrderQueryTypeCodeDropdownRow>
{
    public StandingOrderQueryTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new StandingOrderQueryTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
