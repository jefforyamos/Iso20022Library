﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Reporting2Code.  ISO2002 ID# _ZTMAotp-Ed-ak6NoX_4Aeg_-582451382.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies information with regards to reporting.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IReporting2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZTMAotp-Ed-ak6NoX_4Aeg_-582451382")]
public partial class Reporting2CodeDropdownSource : EnumMetadataManager<Reporting2Code,IReporting2CodeDropdownRow,Reporting2CodeDropdownRow>
{
    public Reporting2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Reporting2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
