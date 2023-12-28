﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalProxyAccountTypeCode.  ISO2002 ID# _ioPgo3h3EeidzqjNEfehPg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external proxy account type code, as published in the proxy account type external code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalProxyAccountTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ioPgo3h3EeidzqjNEfehPg")]
public partial class ExternalProxyAccountTypeCodeDropdownSource : EnumMetadataManager<ExternalProxyAccountTypeCode,IExternalProxyAccountTypeCodeDropdownRow,ExternalProxyAccountTypeCodeDropdownRow>
{
    public ExternalProxyAccountTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalProxyAccountTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}