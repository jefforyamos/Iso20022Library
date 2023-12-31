﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExposureType10Code.  ISO2002 ID# _0bOh5Re2EeyPHpqpKwtFdw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification of the type of the transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExposureType10CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_0bOh5Re2EeyPHpqpKwtFdw")]
public partial class ExposureType10CodeDropdownSource : EnumMetadataManager<ExposureType10Code,IExposureType10CodeDropdownRow,ExposureType10CodeDropdownRow>
{
    public ExposureType10CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExposureType10CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
