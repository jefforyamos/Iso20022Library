﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalAuthenticationChannel1Code.  ISO2002 ID# _5C8hAZdfEea1K6JAcAwoVg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the transaction authentication channel, as published in an external authentication channel code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalAuthenticationChannel1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_5C8hAZdfEea1K6JAcAwoVg")]
public partial class ExternalAuthenticationChannel1CodeDropdownSource : EnumMetadataManager<ExternalAuthenticationChannel1Code,IExternalAuthenticationChannel1CodeDropdownRow,ExternalAuthenticationChannel1CodeDropdownRow>
{
    public ExternalAuthenticationChannel1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalAuthenticationChannel1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}