﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ServiceLevelCode.  ISO2002 ID# _ZKjCBtp-Ed-ak6NoX_4Aeg_27077398.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the pre-agreed level of service between the parties.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IServiceLevelCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZKjCBtp-Ed-ak6NoX_4Aeg_27077398")]
public partial class ServiceLevelCodeDropdownSource : EnumMetadataManager<ServiceLevelCode,IServiceLevelCodeDropdownRow,ServiceLevelCodeDropdownRow>
{
    public ServiceLevelCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ServiceLevelCodeDropdownRow(enumValue, memberInfo))
    {
    }
}