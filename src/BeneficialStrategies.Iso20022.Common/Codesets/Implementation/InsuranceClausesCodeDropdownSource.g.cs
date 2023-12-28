﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InsuranceClausesCode.  ISO2002 ID# _aZEqotp-Ed-ak6NoX_4Aeg_976637789.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// List of standards insurance clauses. (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInsuranceClausesCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aZEqotp-Ed-ak6NoX_4Aeg_976637789")]
public partial class InsuranceClausesCodeDropdownSource : EnumMetadataManager<InsuranceClausesCode,IInsuranceClausesCodeDropdownRow,InsuranceClausesCodeDropdownRow>
{
    public InsuranceClausesCodeDropdownSource()
        : base( (enumValue, memberInfo) => new InsuranceClausesCodeDropdownRow(enumValue, memberInfo))
    {
    }
}