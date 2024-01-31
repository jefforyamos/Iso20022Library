﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SecurityStatus2Code.  ISO2002 ID# _haryw2liEeGaMcKyqKNRfQ_-633101692.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the security.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISecurityStatus2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_haryw2liEeGaMcKyqKNRfQ_-633101692")]
public partial class SecurityStatus2CodeDropdownSource : EnumMetadataManager<SecurityStatus2Code,ISecurityStatus2CodeDropdownRow,SecurityStatus2CodeDropdownRow>
{
    public SecurityStatus2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SecurityStatus2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
