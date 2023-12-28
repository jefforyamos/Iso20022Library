﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ServiceLevel3Code.  ISO2002 ID# _VwsKQNp-Ed-ak6NoX_4Aeg_-228092499.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the pre-agreed level of service between the parties.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IServiceLevel3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VwsKQNp-Ed-ak6NoX_4Aeg_-228092499")]
public partial class ServiceLevel3CodeDropdownSource : EnumMetadataManager<ServiceLevel3Code,IServiceLevel3CodeDropdownRow,ServiceLevel3CodeDropdownRow>
{
    public ServiceLevel3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ServiceLevel3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
