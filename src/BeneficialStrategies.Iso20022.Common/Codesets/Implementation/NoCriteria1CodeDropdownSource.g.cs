﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for NoCriteria1Code.  ISO2002 ID# _aNcpctp-Ed-ak6NoX_4Aeg_-849280423.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies that there is no criteria.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="INoCriteria1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aNcpctp-Ed-ak6NoX_4Aeg_-849280423")]
public partial class NoCriteria1CodeDropdownSource : EnumMetadataManager<NoCriteria1Code,INoCriteria1CodeDropdownRow,NoCriteria1CodeDropdownRow>
{
    public NoCriteria1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new NoCriteria1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
