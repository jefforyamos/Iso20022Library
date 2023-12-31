﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalStatusReason1Code.  ISO2002 ID# _amolhtp-Ed-ak6NoX_4Aeg_1672970561.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status reason, as published in an external status reason code list.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalStatusReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_amolhtp-Ed-ak6NoX_4Aeg_1672970561")]
public partial class ExternalStatusReason1CodeDropdownSource : EnumMetadataManager<ExternalStatusReason1Code,IExternalStatusReason1CodeDropdownRow,ExternalStatusReason1CodeDropdownRow>
{
    public ExternalStatusReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalStatusReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
