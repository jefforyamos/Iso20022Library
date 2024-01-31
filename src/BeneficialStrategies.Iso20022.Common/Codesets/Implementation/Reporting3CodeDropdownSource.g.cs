﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Reporting3Code.  ISO2002 ID# _4mWQgNB4EeihG9bKfarOOA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies to which institution the reporting must be done.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IReporting3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_4mWQgNB4EeihG9bKfarOOA")]
public partial class Reporting3CodeDropdownSource : EnumMetadataManager<Reporting3Code,IReporting3CodeDropdownRow,Reporting3CodeDropdownRow>
{
    public Reporting3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Reporting3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
