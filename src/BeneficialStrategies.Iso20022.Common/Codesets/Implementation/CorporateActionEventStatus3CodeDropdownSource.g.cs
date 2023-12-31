﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionEventStatus3Code.  ISO2002 ID# _bESK0tp-Ed-ak6NoX_4Aeg_2065210906.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the CA event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionEventStatus3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bESK0tp-Ed-ak6NoX_4Aeg_2065210906")]
public partial class CorporateActionEventStatus3CodeDropdownSource : EnumMetadataManager<CorporateActionEventStatus3Code,ICorporateActionEventStatus3CodeDropdownRow,CorporateActionEventStatus3CodeDropdownRow>
{
    public CorporateActionEventStatus3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionEventStatus3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
