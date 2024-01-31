﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionMandatoryVoluntary1Code.  ISO2002 ID# _bKsU0dp-Ed-ak6NoX_4Aeg_-2134886943.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the event is mandatory, mandatory with options or voluntary.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionMandatoryVoluntary1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bKsU0dp-Ed-ak6NoX_4Aeg_-2134886943")]
public partial class CorporateActionMandatoryVoluntary1CodeDropdownSource : EnumMetadataManager<CorporateActionMandatoryVoluntary1Code,ICorporateActionMandatoryVoluntary1CodeDropdownRow,CorporateActionMandatoryVoluntary1CodeDropdownRow>
{
    public CorporateActionMandatoryVoluntary1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionMandatoryVoluntary1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
