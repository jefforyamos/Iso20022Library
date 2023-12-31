﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalBenchmarkCurveName1Code.  ISO2002 ID# _ZJ3hsDNnEe2UWZuK9pqFtg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external benchmark curve name code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalBenchmarkCurveName1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZJ3hsDNnEe2UWZuK9pqFtg")]
public partial class ExternalBenchmarkCurveName1CodeDropdownSource : EnumMetadataManager<ExternalBenchmarkCurveName1Code,IExternalBenchmarkCurveName1CodeDropdownRow,ExternalBenchmarkCurveName1CodeDropdownRow>
{
    public ExternalBenchmarkCurveName1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalBenchmarkCurveName1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
