﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionEventStatus2Code.  ISO2002 ID# _bEJA59p-Ed-ak6NoX_4Aeg_2035657818.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the CA option.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionEventStatus2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bEJA59p-Ed-ak6NoX_4Aeg_2035657818")]
public partial class CorporateActionEventStatus2CodeDropdownSource : EnumMetadataManager<CorporateActionEventStatus2Code,ICorporateActionEventStatus2CodeDropdownRow,CorporateActionEventStatus2CodeDropdownRow>
{
    public CorporateActionEventStatus2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionEventStatus2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}