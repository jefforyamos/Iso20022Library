﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AuthorityExchangeReason1Code.  ISO2002 ID# _nq1NEB5REeWc9bJOIIhUUw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for the exchange with the national competent authority.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAuthorityExchangeReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_nq1NEB5REeWc9bJOIIhUUw")]
public partial class AuthorityExchangeReason1CodeDropdownSource : EnumMetadataManager<AuthorityExchangeReason1Code,IAuthorityExchangeReason1CodeDropdownRow,AuthorityExchangeReason1CodeDropdownRow>
{
    public AuthorityExchangeReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AuthorityExchangeReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
