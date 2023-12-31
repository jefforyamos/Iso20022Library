﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ReinvestmentTypeCode.  ISO2002 ID# _mPNa4I68EeaxxtxaoOwzAg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides details on the  type of the cash reinvestment in a given currency.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IReinvestmentTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_mPNa4I68EeaxxtxaoOwzAg")]
public partial class ReinvestmentTypeCodeDropdownSource : EnumMetadataManager<ReinvestmentTypeCode,IReinvestmentTypeCodeDropdownRow,ReinvestmentTypeCodeDropdownRow>
{
    public ReinvestmentTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ReinvestmentTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
