﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ServiceLevel2Code.  ISO2002 ID# _ZKjCAdp-Ed-ak6NoX_4Aeg_757139681.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the pre-agreed level of service between the parties.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IServiceLevel2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZKjCAdp-Ed-ak6NoX_4Aeg_757139681")]
public partial class ServiceLevel2CodeDropdownSource : EnumMetadataManager<ServiceLevel2Code,IServiceLevel2CodeDropdownRow,ServiceLevel2CodeDropdownRow>
{
    public ServiceLevel2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ServiceLevel2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
