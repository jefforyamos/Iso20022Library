﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalReturnReason1Code.  ISO2002 ID# _amolg9p-Ed-ak6NoX_4Aeg_1571382159.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the return reason, as published in an external return reason code list.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalReturnReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_amolg9p-Ed-ak6NoX_4Aeg_1571382159")]
public partial class ExternalReturnReason1CodeDropdownSource : EnumMetadataManager<ExternalReturnReason1Code,IExternalReturnReason1CodeDropdownRow,ExternalReturnReason1CodeDropdownRow>
{
    public ExternalReturnReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalReturnReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
