﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AddendumTaxTypeCode.  ISO2002 ID# _o7g-JvJ7EeiJn9rM2Znz2w.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the specific type of tax(es) applicable to a transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAddendumTaxTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_o7g-JvJ7EeiJn9rM2Znz2w")]
public partial class AddendumTaxTypeCodeDropdownSource : EnumMetadataManager<AddendumTaxTypeCode,IAddendumTaxTypeCodeDropdownRow,AddendumTaxTypeCodeDropdownRow>
{
    public AddendumTaxTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AddendumTaxTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
