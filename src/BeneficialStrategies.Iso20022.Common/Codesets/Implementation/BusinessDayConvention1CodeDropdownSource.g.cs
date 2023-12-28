﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BusinessDayConvention1Code.  ISO2002 ID# _bVIDNdp-Ed-ak6NoX_4Aeg_1684551992.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates how a date is adjusted when it falls on a non-business day.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBusinessDayConvention1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bVIDNdp-Ed-ak6NoX_4Aeg_1684551992")]
public partial class BusinessDayConvention1CodeDropdownSource : EnumMetadataManager<BusinessDayConvention1Code,IBusinessDayConvention1CodeDropdownRow,BusinessDayConvention1CodeDropdownRow>
{
    public BusinessDayConvention1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new BusinessDayConvention1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}