﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalTechnicalInputChannel1Code.  ISO2002 ID# _amolh9p-Ed-ak6NoX_4Aeg_-614400071.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the technical input channel, as published in an external technical input channel code list.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalTechnicalInputChannel1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_amolh9p-Ed-ak6NoX_4Aeg_-614400071")]
public partial class ExternalTechnicalInputChannel1CodeDropdownSource : EnumMetadataManager<ExternalTechnicalInputChannel1Code,IExternalTechnicalInputChannel1CodeDropdownRow,ExternalTechnicalInputChannel1CodeDropdownRow>
{
    public ExternalTechnicalInputChannel1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalTechnicalInputChannel1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
