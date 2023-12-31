﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PINRequestType1Code.  ISO2002 ID# _VB20AN7AEeiwsev40qZGEQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of PIN Service.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPINRequestType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VB20AN7AEeiwsev40qZGEQ")]
public partial class PINRequestType1CodeDropdownSource : EnumMetadataManager<PINRequestType1Code,IPINRequestType1CodeDropdownRow,PINRequestType1CodeDropdownRow>
{
    public PINRequestType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PINRequestType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
