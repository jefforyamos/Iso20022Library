﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for StandingOrderType1Code.  ISO2002 ID# _8OFBU6MgEeCJ6YNENx4h-w_-143150650.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of standing order, such as a user defined standing order or a predefined liquidity transfer.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IStandingOrderType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8OFBU6MgEeCJ6YNENx4h-w_-143150650")]
public partial class StandingOrderType1CodeDropdownSource : EnumMetadataManager<StandingOrderType1Code,IStandingOrderType1CodeDropdownRow,StandingOrderType1CodeDropdownRow>
{
    public StandingOrderType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new StandingOrderType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
