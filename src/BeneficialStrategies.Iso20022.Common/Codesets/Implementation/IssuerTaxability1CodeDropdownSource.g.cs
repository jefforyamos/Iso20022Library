﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for IssuerTaxability1Code.  ISO2002 ID# _AwDc8PovEeCfbIXrKCjG0g.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the corporate action proceeds are taxable at issuer level.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IIssuerTaxability1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_AwDc8PovEeCfbIXrKCjG0g")]
public partial class IssuerTaxability1CodeDropdownSource : EnumMetadataManager<IssuerTaxability1Code,IIssuerTaxability1CodeDropdownRow,IssuerTaxability1CodeDropdownRow>
{
    public IssuerTaxability1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new IssuerTaxability1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}