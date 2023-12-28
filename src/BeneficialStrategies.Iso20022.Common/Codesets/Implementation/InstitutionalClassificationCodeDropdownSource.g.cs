﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InstitutionalClassificationCode.  ISO2002 ID# _Sn2ckFIhEeGxk_7PmgdPEg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// TSE/JASDEC extension codes for mergers.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInstitutionalClassificationCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Sn2ckFIhEeGxk_7PmgdPEg")]
public partial class InstitutionalClassificationCodeDropdownSource : EnumMetadataManager<InstitutionalClassificationCode,IInstitutionalClassificationCodeDropdownRow,InstitutionalClassificationCodeDropdownRow>
{
    public InstitutionalClassificationCodeDropdownSource()
        : base( (enumValue, memberInfo) => new InstitutionalClassificationCodeDropdownRow(enumValue, memberInfo))
    {
    }
}