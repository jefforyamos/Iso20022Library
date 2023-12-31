﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AccountOwnershipType6Code.  ISO2002 ID# _NptcQDOQEeqjy7_SkdcoGg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of account ownership.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NptcQDOQEeqjy7_SkdcoGg")]
[Description(@"Specifies the type of account ownership.")]
[DerivedFrom(typeof(AccountOwnershipTypeCode))]
public enum AccountOwnershipType6Code
{
    /// <summary>
    /// A person has bare ownership on the asset.
    /// Encoded/decoded by serializers as "BareOwner".
    /// </summary>
    [EnumMember(Value = "BOWN")]
    [IsoId("_QtJ_ITOQEeqjy7_SkdcoGg")]
    [Description(@"A person has bare ownership on the asset.")]
    BareOwner,
    
    /// <summary>
    /// Account owner is a corporate.
    /// Encoded/decoded by serializers as "Corporation".
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_QxoPcTOQEeqjy7_SkdcoGg")]
    [Description(@"Account owner is a corporate.")]
    Corporation,
    
    /// <summary>
    /// Minor's account, registered in the minor's name. Since the minor cannot legally own property, the custodian of the account maintains control of the account.
    /// Encoded/decoded by serializers as "CustodialAccount".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_Q3OhITOQEeqjy7_SkdcoGg")]
    [Description(@"Minor's account, registered in the minor's name. Since the minor cannot legally own property, the custodian of the account maintains control of the account.")]
    CustodialAccount,
    
    /// <summary>
    /// Entrepreneurial account.
    /// Encoded/decoded by serializers as "Entrepreneurial".
    /// </summary>
    [EnumMember(Value = "ENTR")]
    [IsoId("_Q76z4TOQEeqjy7_SkdcoGg")]
    [Description(@"Entrepreneurial account.")]
    Entrepreneurial,
    
    /// <summary>
    /// Account owner is an entity located in the European Union which can be considered neither as a legal entity (for example, company, corporate), nor as an individual person, nor as a UCITS (Undertakings for Collective Investment of Transferable Securities) fund.
    /// Encoded/decoded by serializers as "EUResidualEntity".
    /// </summary>
    [EnumMember(Value = "EURE")]
    [IsoId("_Q_tHsTOQEeqjy7_SkdcoGg")]
    [Description(@"Account owner is an entity located in the European Union which can be considered neither as a legal entity (for example, company, corporate), nor as an individual person, nor as a UCITS (Undertakings for Collective Investment of Transferable Securities) fund.")]
    EUResidualEntity,
    
    /// <summary>
    /// Account owner is a contractual business organisation in which two or more individuals agree to pool their funds to manage and operate a business.
    /// Encoded/decoded by serializers as "FormalPartnership".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_RD65UTOQEeqjy7_SkdcoGg")]
    [Description(@"Account owner is a contractual business organisation in which two or more individuals agree to pool their funds to manage and operate a business.")]
    FormalPartnership,
    
    /// <summary>
    /// Account owner is an organisation which is engaged as a trustee for individuals or businesses in the administration of services such as stock transfer, registration, trust funds.
    /// Encoded/decoded by serializers as "FormalTrust".
    /// </summary>
    [EnumMember(Value = "TRUS")]
    [IsoId("_RIfQQDOQEeqjy7_SkdcoGg")]
    [Description(@"Account owner is an organisation which is engaged as a trustee for individuals or businesses in the administration of services such as stock transfer, registration, trust funds.")]
    FormalTrust,
    
    /// <summary>
    /// Account owner is a government organisation.
    /// Encoded/decoded by serializers as "GovernmentOrganisation".
    /// </summary>
    [EnumMember(Value = "GOVO")]
    [IsoId("_RMpXgTOQEeqjy7_SkdcoGg")]
    [Description(@"Account owner is a government organisation.")]
    GovernmentOrganisation,
    
    /// <summary>
    /// Two or more individuals of legal age own shares of the same account.
    /// Encoded/decoded by serializers as "JointAccount".
    /// </summary>
    [EnumMember(Value = "JOIT")]
    [IsoId("_RRcX8TOQEeqjy7_SkdcoGg")]
    [Description(@"Two or more individuals of legal age own shares of the same account.")]
    JointAccount,
    
    /// <summary>
    /// Two or more individuals of legal age own shares of the same account. Upon the death of one of the account owners, the respective percentage of the ownership is transferred to the deceased's estate.
    /// Encoded/decoded by serializers as "JointAccountInCommon".
    /// </summary>
    [EnumMember(Value = "COMO")]
    [IsoId("_RViNwTOQEeqjy7_SkdcoGg")]
    [Description(@"Two or more individuals of legal age own shares of the same account. Upon the death of one of the account owners, the respective percentage of the ownership is transferred to the deceased's estate.")]
    JointAccountInCommon,
    
    /// <summary>
    /// Two or more individuals own shares of the same account. Upon the death of one of the account owners, the entire account ownership is passed onto the surviving owners.
    /// Encoded/decoded by serializers as "JointAccountWithSurvivorshipRights".
    /// </summary>
    [EnumMember(Value = "JOIN")]
    [IsoId("_RZgHwTOQEeqjy7_SkdcoGg")]
    [Description(@"Two or more individuals own shares of the same account. Upon the death of one of the account owners, the entire account ownership is passed onto the surviving owners.")]
    JointAccountWithSurvivorshipRights,
    
    /// <summary>
    /// Account is for a limited liability company.
    /// Encoded/decoded by serializers as "LimitedLiabilityCompany".
    /// </summary>
    [EnumMember(Value = "LLCO")]
    [IsoId("_RdyK0TOQEeqjy7_SkdcoGg")]
    [Description(@"Account is for a limited liability company.")]
    LimitedLiabilityCompany,
    
    /// <summary>
    /// Account owner is a limited partnership or is of sole proprietorship.
    /// Encoded/decoded by serializers as "LimitedPartnership".
    /// </summary>
    [EnumMember(Value = "LIPA")]
    [IsoId("_RiZlETOQEeqjy7_SkdcoGg")]
    [Description(@"Account owner is a limited partnership or is of sole proprietorship.")]
    LimitedPartnership,
    
    /// <summary>
    /// Account owner is a person or firm into whose name securities or other properties are transferred in order to facilitate transactions whilst leaving the customer as the actual owner.
    /// Encoded/decoded by serializers as "Nominee".
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_RmkTYTOQEeqjy7_SkdcoGg")]
    [Description(@"Account owner is a person or firm into whose name securities or other properties are transferred in order to facilitate transactions whilst leaving the customer as the actual owner.")]
    Nominee,
    
    /// <summary>
    /// Account owner is an association that is given tax-free status due to the nature of their activities such as charity organisation.
    /// Encoded/decoded by serializers as "NonProfitOrganisation".
    /// </summary>
    [EnumMember(Value = "NFPO")]
    [IsoId("_Rri6ATOQEeqjy7_SkdcoGg")]
    [Description(@"Account owner is an association that is given tax-free status due to the nature of their activities such as charity organisation.")]
    NonProfitOrganisation,
    
    /// <summary>
    /// Account owner is another type of non individual organisation.
    /// Encoded/decoded by serializers as "OtherNonIndividual".
    /// </summary>
    [EnumMember(Value = "ONIS")]
    [IsoId("_RwJGITOQEeqjy7_SkdcoGg")]
    [Description(@"Account owner is another type of non individual organisation.")]
    OtherNonIndividual,
    
    /// <summary>
    /// A person has full ownership on the asset. 
    /// Encoded/decoded by serializers as "Owner".
    /// </summary>
    [EnumMember(Value = "OWNR")]
    [IsoId("_R0faoTOQEeqjy7_SkdcoGg")]
    [Description(@"A person has full ownership on the asset. ")]
    Owner,
    
    /// <summary>
    /// Account is for a registered investment company.
    /// Encoded/decoded by serializers as "RegisteredInvestmentCompany".
    /// </summary>
    [EnumMember(Value = "RGIC")]
    [IsoId("_R4tzUTOQEeqjy7_SkdcoGg")]
    [Description(@"Account is for a registered investment company.")]
    RegisteredInvestmentCompany,
    
    /// <summary>
    /// Account has only one individual owner.
    /// Encoded/decoded by serializers as "SingleOwnerAccount".
    /// </summary>
    [EnumMember(Value = "SIGL")]
    [IsoId("_R87k8TOQEeqjy7_SkdcoGg")]
    [Description(@"Account has only one individual owner.")]
    SingleOwnerAccount,
    
    /// <summary>
    /// Account owner is an unincorporated partnership or is of sole proprietorship.
    /// Encoded/decoded by serializers as "Unincorporated".
    /// </summary>
    [EnumMember(Value = "UNCO")]
    [IsoId("_SBpF0TOQEeqjy7_SkdcoGg")]
    [Description(@"Account owner is an unincorporated partnership or is of sole proprietorship.")]
    Unincorporated,
    
    /// <summary>
    /// The person is ...
    /// Encoded/decoded by serializers as "Usufructuary".
    /// </summary>
    [EnumMember(Value = "USUF")]
    [IsoId("_SFqqMTOQEeqjy7_SkdcoGg")]
    [Description(@"The person is ...")]
    Usufructuary,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AccountOwnershipType6CodeMetadataExtensions
{
    private static readonly AccountOwnershipType6CodeDropdownSource _dropdownSource = new AccountOwnershipType6CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAccountOwnershipType6CodeDropdownRow GetMetadata(this AccountOwnershipType6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


