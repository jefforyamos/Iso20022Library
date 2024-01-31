﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AccountOwnershipType4Code.  ISO2002 ID# _o23nwL-GEeWfsa741pI6WA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of account ownership.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_o23nwL-GEeWfsa741pI6WA")]
[Description(@"Specifies the type of account ownership.")]
[DerivedFrom(typeof(AccountOwnershipTypeCode))]
public enum AccountOwnershipType4Code
{
    /// <summary>
    /// Account owner is an unincorporated partnership or is of sole proprietorship.
    /// Encoded/decoded by serializers as "UNCO".
    /// </summary>
    [EnumMember(Value = "UNCO")]
    [IsoId("_rwGesb-GEeWfsa741pI6WA")]
    [Description(@"Account owner is an unincorporated partnership or is of sole proprietorship.")]
    Unincorporated = AccountOwnershipTypeCode.Unincorporated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account owner is a limited partnership or is of sole proprietorship.
    /// Encoded/decoded by serializers as "LIPA".
    /// </summary>
    [EnumMember(Value = "LIPA")]
    [IsoId("_sGHyAb-GEeWfsa741pI6WA")]
    [Description(@"Account owner is a limited partnership or is of sole proprietorship.")]
    LimitedPartnership = AccountOwnershipTypeCode.LimitedPartnership, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Entrepreneurial account.
    /// Encoded/decoded by serializers as "ENTR".
    /// </summary>
    [EnumMember(Value = "ENTR")]
    [IsoId("_tFMpYb-GEeWfsa741pI6WA")]
    [Description(@"Entrepreneurial account.")]
    Entrepreneurial = AccountOwnershipTypeCode.Entrepreneurial, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account owner is a corporate.
    /// Encoded/decoded by serializers as "CORP".
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_u-TgEb-GEeWfsa741pI6WA")]
    [Description(@"Account owner is a corporate.")]
    Corporation = AccountOwnershipTypeCode.Corporation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Minor's account, registered in the minor's name. Since the minor cannot legally own property, the custodian of the account maintains control of the account.
    /// Encoded/decoded by serializers as "CUST".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_vLsb0b-GEeWfsa741pI6WA")]
    [Description(@"Minor's account, registered in the minor's name. Since the minor cannot legally own property, the custodian of the account maintains control of the account.")]
    CustodialAccount = AccountOwnershipTypeCode.CustodialAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account owner is an entity located in the European Union which can be considered neither as a legal entity (for example, company, corporate), nor as an individual person, nor as a UCITS (Undertakings for Collective Investment of Transferable Securities) fund.
    /// Encoded/decoded by serializers as "EURE".
    /// </summary>
    [EnumMember(Value = "EURE")]
    [IsoId("_vczZ8b-GEeWfsa741pI6WA")]
    [Description(@"Account owner is an entity located in the European Union which can be considered neither as a legal entity (for example, company, corporate), nor as an individual person, nor as a UCITS (Undertakings for Collective Investment of Transferable Securities) fund.")]
    EUResidualEntity = AccountOwnershipTypeCode.EUResidualEntity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account owner is a contractual business organisation in which two or more individuals agree to pool their funds to manage and operate a business.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_vrO3gb-GEeWfsa741pI6WA")]
    [Description(@"Account owner is a contractual business organisation in which two or more individuals agree to pool their funds to manage and operate a business.")]
    FormalPartnership = AccountOwnershipTypeCode.FormalPartnership, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account owner is an organisation which is engaged as a trustee for individuals or businesses in the administration of services such as stock transfer, registration, trust funds.
    /// Encoded/decoded by serializers as "TRUS".
    /// </summary>
    [EnumMember(Value = "TRUS")]
    [IsoId("_v7dE0b-GEeWfsa741pI6WA")]
    [Description(@"Account owner is an organisation which is engaged as a trustee for individuals or businesses in the administration of services such as stock transfer, registration, trust funds.")]
    FormalTrust = AccountOwnershipTypeCode.FormalTrust, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account owner is a government organisation.
    /// Encoded/decoded by serializers as "GOVO".
    /// </summary>
    [EnumMember(Value = "GOVO")]
    [IsoId("_wJ4iYb-GEeWfsa741pI6WA")]
    [Description(@"Account owner is a government organisation.")]
    GovernmentOrganisation = AccountOwnershipTypeCode.GovernmentOrganisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Two or more individuals of legal age own shares of the same account.
    /// Encoded/decoded by serializers as "JOIT".
    /// </summary>
    [EnumMember(Value = "JOIT")]
    [IsoId("_wYdw8b-GEeWfsa741pI6WA")]
    [Description(@"Two or more individuals of legal age own shares of the same account.")]
    JointAccount = AccountOwnershipTypeCode.JointAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Two or more individuals of legal age own shares of the same account. Upon the death of one of the account owners, the respective percentage of the ownership is transferred to the deceased's estate.
    /// Encoded/decoded by serializers as "COMO".
    /// </summary>
    [EnumMember(Value = "COMO")]
    [IsoId("_whi0cb-GEeWfsa741pI6WA")]
    [Description(@"Two or more individuals of legal age own shares of the same account. Upon the death of one of the account owners, the respective percentage of the ownership is transferred to the deceased's estate.")]
    JointAccountInCommon = AccountOwnershipTypeCode.JointAccountInCommon, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Two or more individuals own shares of the same account. Upon the death of one of the account owners, the entire account ownership is passed onto the surviving owners.
    /// Encoded/decoded by serializers as "JOIN".
    /// </summary>
    [EnumMember(Value = "JOIN")]
    [IsoId("_w4mpkb-GEeWfsa741pI6WA")]
    [Description(@"Two or more individuals own shares of the same account. Upon the death of one of the account owners, the entire account ownership is passed onto the surviving owners.")]
    JointAccountWithSurvivorshipRights = AccountOwnershipTypeCode.JointAccountWithSurvivorshipRights, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is for a limited liability company.
    /// Encoded/decoded by serializers as "LLCO".
    /// </summary>
    [EnumMember(Value = "LLCO")]
    [IsoId("_ybsM8b-GEeWfsa741pI6WA")]
    [Description(@"Account is for a limited liability company.")]
    LimitedLiabilityCompany = AccountOwnershipTypeCode.LimitedLiabilityCompany, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account owner is a person or firm into whose name securities or other properties are transferred in order to facilitate transactions whilst leaving the customer as the actual owner.
    /// Encoded/decoded by serializers as "NOMI".
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_yu4Osb-GEeWfsa741pI6WA")]
    [Description(@"Account owner is a person or firm into whose name securities or other properties are transferred in order to facilitate transactions whilst leaving the customer as the actual owner.")]
    Nominee = AccountOwnershipTypeCode.Nominee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account owner is an association that is given tax-free status due to the nature of their activities such as charity organisation.
    /// Encoded/decoded by serializers as "NFPO".
    /// </summary>
    [EnumMember(Value = "NFPO")]
    [IsoId("_y7Ooob-GEeWfsa741pI6WA")]
    [Description(@"Account owner is an association that is given tax-free status due to the nature of their activities such as charity organisation.")]
    NonProfitOrganisation = AccountOwnershipTypeCode.NonProfitOrganisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account owner is another type of non individual organisation.
    /// Encoded/decoded by serializers as "ONIS".
    /// </summary>
    [EnumMember(Value = "ONIS")]
    [IsoId("_zUhSYb-GEeWfsa741pI6WA")]
    [Description(@"Account owner is another type of non individual organisation.")]
    OtherNonIndividual = AccountOwnershipTypeCode.OtherNonIndividual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is for a registered investment company.
    /// Encoded/decoded by serializers as "RGIC".
    /// </summary>
    [EnumMember(Value = "RGIC")]
    [IsoId("_zjjM4b-GEeWfsa741pI6WA")]
    [Description(@"Account is for a registered investment company.")]
    RegisteredInvestmentCompany = AccountOwnershipTypeCode.RegisteredInvestmentCompany, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account has only one individual owner.
    /// Encoded/decoded by serializers as "SIGL".
    /// </summary>
    [EnumMember(Value = "SIGL")]
    [IsoId("_zvv10b-GEeWfsa741pI6WA")]
    [Description(@"Account has only one individual owner.")]
    SingleOwnerAccount = AccountOwnershipTypeCode.SingleOwnerAccount, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AccountOwnershipType4CodeMetadataExtensions
{
    private static readonly AccountOwnershipType4CodeDropdownSource _dropdownSource = new AccountOwnershipType4CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAccountOwnershipType4CodeDropdownRow GetMetadata(this AccountOwnershipType4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


