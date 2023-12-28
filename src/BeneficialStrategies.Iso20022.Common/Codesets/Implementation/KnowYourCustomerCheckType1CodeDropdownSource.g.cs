﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for KnowYourCustomerCheckType1Code.  ISO2002 ID# _4-CwIBRxEeOKWo1NF21OVw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of Know Your Customer (KYC) or anti-money laundering due diligence to which the investor has been subjected.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IKnowYourCustomerCheckType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_4-CwIBRxEeOKWo1NF21OVw")]
public partial class KnowYourCustomerCheckType1CodeDropdownSource : EnumMetadataManager<KnowYourCustomerCheckType1Code,IKnowYourCustomerCheckType1CodeDropdownRow,KnowYourCustomerCheckType1CodeDropdownRow>
{
    public KnowYourCustomerCheckType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new KnowYourCustomerCheckType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
