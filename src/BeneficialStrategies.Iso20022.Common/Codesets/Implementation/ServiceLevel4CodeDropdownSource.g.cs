﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ServiceLevel4Code.  ISO2002 ID# _ZKjCBNp-Ed-ak6NoX_4Aeg_918510660.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the pre-agreed level of service between the parties.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IServiceLevel4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZKjCBNp-Ed-ak6NoX_4Aeg_918510660")]
public partial class ServiceLevel4CodeDropdownSource : EnumMetadataManager<ServiceLevel4Code,IServiceLevel4CodeDropdownRow,ServiceLevel4CodeDropdownRow>
{
    public ServiceLevel4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ServiceLevel4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
