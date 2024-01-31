﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MemberType1Code.  ISO2002 ID# _aLqgx9p-Ed-ak6NoX_4Aeg_977880707.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the membership of a party in a system. A system may recognise different types of membership, with different related rights and obligations.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMemberType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aLqgx9p-Ed-ak6NoX_4Aeg_977880707")]
public partial class MemberType1CodeDropdownSource : EnumMetadataManager<MemberType1Code,IMemberType1CodeDropdownRow,MemberType1CodeDropdownRow>
{
    public MemberType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MemberType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
