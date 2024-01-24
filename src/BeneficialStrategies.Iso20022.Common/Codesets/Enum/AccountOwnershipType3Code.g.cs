﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AccountOwnershipType3Code.  ISO2002 ID# _bq4QxNp-Ed-ak6NoX_4Aeg_2099855130.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of account ownership.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bq4QxNp-Ed-ak6NoX_4Aeg_2099855130")]
[Description(@"Specifies the type of account ownership.")]
[DerivedFrom(typeof(AccountOwnershipTypeCode))]
public enum AccountOwnershipType3Code
{
    /// <summary>
    /// Two or more individuals own shares of the same account. Upon the death of one of the account owners, the entire account ownership is passed onto the surviving owners.
    /// Encoded/decoded by serializers as "JOIN".
    /// </summary>
    [EnumMember(Value = "JOIN")]
    [IsoId("_bq4Qxdp-Ed-ak6NoX_4Aeg_2099855486")]
    [Description(@"Two or more individuals own shares of the same account. Upon the death of one of the account owners, the entire account ownership is passed onto the surviving owners.")]
    JointAccountWithSurvivorshipRights = AccountOwnershipTypeCode.JointAccountWithSurvivorshipRights, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Two or more individuals of legal age own shares of the same account. Upon the death of one of the account owners, the respective percentage of the ownership is transferred to the deceased's estate.
    /// Encoded/decoded by serializers as "COMO".
    /// </summary>
    [EnumMember(Value = "COMO")]
    [IsoId("_bq4Qxtp-Ed-ak6NoX_4Aeg_2099855521")]
    [Description(@"Two or more individuals of legal age own shares of the same account. Upon the death of one of the account owners, the respective percentage of the ownership is transferred to the deceased's estate.")]
    JointAccountInCommon = AccountOwnershipTypeCode.JointAccountInCommon, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Minor's account, registered in the minor's name. Since the minor cannot legally own property, the custodian of the account maintains control of the account.
    /// Encoded/decoded by serializers as "CUST".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_bq4Qx9p-Ed-ak6NoX_4Aeg_2099855581")]
    [Description(@"Minor's account, registered in the minor's name. Since the minor cannot legally own property, the custodian of the account maintains control of the account.")]
    CustodialAccount = AccountOwnershipTypeCode.CustodialAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account has only one individual owner.
    /// Encoded/decoded by serializers as "SIGL".
    /// </summary>
    [EnumMember(Value = "SIGL")]
    [IsoId("_bq4QyNp-Ed-ak6NoX_4Aeg_2099855889")]
    [Description(@"Account has only one individual owner.")]
    SingleOwnerAccount = AccountOwnershipTypeCode.SingleOwnerAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Two or more individuals of legal age own shares of the same account.
    /// Encoded/decoded by serializers as "JOIT".
    /// </summary>
    [EnumMember(Value = "JOIT")]
    [IsoId("_brCBwNp-Ed-ak6NoX_4Aeg_181255040")]
    [Description(@"Two or more individuals of legal age own shares of the same account.")]
    JointAccount = AccountOwnershipTypeCode.JointAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account owner is a corporate.
    /// Encoded/decoded by serializers as "CORP".
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_brCBwdp-Ed-ak6NoX_4Aeg_184025538")]
    [Description(@"Account owner is a corporate.")]
    Corporation = AccountOwnershipTypeCode.Corporation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account owner is a contractual business organisation in which two or more individuals agree to pool their funds to manage and operate a business.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_brCBwtp-Ed-ak6NoX_4Aeg_185874053")]
    [Description(@"Account owner is a contractual business organisation in which two or more individuals agree to pool their funds to manage and operate a business.")]
    FormalPartnership = AccountOwnershipTypeCode.FormalPartnership, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account owner is an organisation which is engaged as a trustee for individuals or businesses in the administration of services such as stock transfer, registration, trust funds.
    /// Encoded/decoded by serializers as "TRUS".
    /// </summary>
    [EnumMember(Value = "TRUS")]
    [IsoId("_brCBw9p-Ed-ak6NoX_4Aeg_188642210")]
    [Description(@"Account owner is an organisation which is engaged as a trustee for individuals or businesses in the administration of services such as stock transfer, registration, trust funds.")]
    FormalTrust = AccountOwnershipTypeCode.FormalTrust, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account owner is a person or firm into whose name securities or other properties are transferred in order to facilitate transactions whilst leaving the customer as the actual owner.
    /// Encoded/decoded by serializers as "NOMI".
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_brCBxNp-Ed-ak6NoX_4Aeg_196954909")]
    [Description(@"Account owner is a person or firm into whose name securities or other properties are transferred in order to facilitate transactions whilst leaving the customer as the actual owner.")]
    Nominee = AccountOwnershipTypeCode.Nominee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account owner is an association that is given tax-free status due to the nature of their activities such as charity organisation.
    /// Encoded/decoded by serializers as "NFPO".
    /// </summary>
    [EnumMember(Value = "NFPO")]
    [IsoId("_brCBxdp-Ed-ak6NoX_4Aeg_199723984")]
    [Description(@"Account owner is an association that is given tax-free status due to the nature of their activities such as charity organisation.")]
    NonProfitOrganisation = AccountOwnershipTypeCode.NonProfitOrganisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account owner is another type of non individual organisation.
    /// Encoded/decoded by serializers as "ONIS".
    /// </summary>
    [EnumMember(Value = "ONIS")]
    [IsoId("_brCBxtp-Ed-ak6NoX_4Aeg_201571149")]
    [Description(@"Account owner is another type of non individual organisation.")]
    OtherNonIndividual = AccountOwnershipTypeCode.OtherNonIndividual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account owner is an entity located in the European Union which can be considered neither as a legal entity (for example, company, corporate), nor as an individual person, nor as a UCITS (Undertakings for Collective Investment of Transferable Securities) fund.
    /// Encoded/decoded by serializers as "EURE".
    /// </summary>
    [EnumMember(Value = "EURE")]
    [IsoId("_brCBx9p-Ed-ak6NoX_4Aeg_439840483")]
    [Description(@"Account owner is an entity located in the European Union which can be considered neither as a legal entity (for example, company, corporate), nor as an individual person, nor as a UCITS (Undertakings for Collective Investment of Transferable Securities) fund.")]
    EUResidualEntity = AccountOwnershipTypeCode.EUResidualEntity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account owner is a government organisation.
    /// Encoded/decoded by serializers as "GOVO".
    /// </summary>
    [EnumMember(Value = "GOVO")]
    [IsoId("_brCByNp-Ed-ak6NoX_4Aeg_441689293")]
    [Description(@"Account owner is a government organisation.")]
    GovernmentOrganisation = AccountOwnershipTypeCode.GovernmentOrganisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is for a limited liability company.
    /// Encoded/decoded by serializers as "LLCO".
    /// </summary>
    [EnumMember(Value = "LLCO")]
    [IsoId("_brCBydp-Ed-ak6NoX_4Aeg_446303985")]
    [Description(@"Account is for a limited liability company.")]
    LimitedLiabilityCompany = AccountOwnershipTypeCode.LimitedLiabilityCompany, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is for a registered investment company.
    /// Encoded/decoded by serializers as "RGIC".
    /// </summary>
    [EnumMember(Value = "RGIC")]
    [IsoId("_brCBytp-Ed-ak6NoX_4Aeg_487862475")]
    [Description(@"Account is for a registered investment company.")]
    RegisteredInvestmentCompany = AccountOwnershipTypeCode.RegisteredInvestmentCompany, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AccountOwnershipType3CodeMetadataExtensions
{
    private static readonly AccountOwnershipType3CodeDropdownSource _dropdownSource = new AccountOwnershipType3CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAccountOwnershipType3CodeDropdownRow GetMetadata(this AccountOwnershipType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


