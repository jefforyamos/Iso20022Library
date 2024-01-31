﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CompanyLinkCode.  ISO2002 ID# _FFnMsCCaEeWJd9HF2tO7BA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of links to a company.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FFnMsCCaEeWJd9HF2tO7BA")]
[Description(@"Specifies the type of links to a company.")]
[Derivations(typeof(CompanyLink1Code))]
public enum CompanyLinkCode
{
    /// <summary>
    /// Employee, operator or agent of the broker.
    /// Encoded/decoded by serializers as "BROK".
    /// </summary>
    [EnumMember(Value = "BROK")]
    [IsoId("_OnADYCCaEeWJd9HF2tO7BA")]
    [Description(@"Employee, operator or agent of the broker.")]
    Broker,
    
    /// <summary>
    /// Autonomous agent accredited by the broker.
    /// Encoded/decoded by serializers as "AGEN".
    /// </summary>
    [EnumMember(Value = "AGEN")]
    [IsoId("_R5XzECCaEeWJd9HF2tO7BA")]
    [Description(@"Autonomous agent accredited by the broker.")]
    Agent,
    
    /// <summary>
    /// Brokerage partner or shareholder, individual or entity who holds a direct or an indirect control function and the holder of a management or an administration position.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_UNsmICCaEeWJd9HF2tO7BA")]
    [Description(@"Brokerage partner or shareholder, individual or entity who holds a direct or an indirect control function and the holder of a management or an administration position.")]
    BrokeragePartner,
    
    /// <summary>
    /// Spouse or partner and child of an employee, operator or agent of the broker; agent of the broker; brokerage partners or shareholders; individual or entity who holds a direct or an indirect control function and the holder of a management or an administration position.
    /// Encoded/decoded by serializers as "RELA".
    /// </summary>
    [EnumMember(Value = "RELA")]
    [IsoId("_Ykp_UCCaEeWJd9HF2tO7BA")]
    [Description(@"Spouse or partner and child of an employee, operator or agent of the broker; agent of the broker; brokerage partners or shareholders; individual or entity who holds a direct or an indirect control function and the holder of a management or an administration position.")]
    Relative,
    
    /// <summary>
    /// Parent company of the broker.
    /// Encoded/decoded by serializers as "PCOM".
    /// </summary>
    [EnumMember(Value = "PCOM")]
    [IsoId("_bt9SkCCaEeWJd9HF2tO7BA")]
    [Description(@"Parent company of the broker.")]
    ParentCompany,
    
    /// <summary>
    /// Member broker of a financial conglomerate (person is a board member, director, officer and employee of a member company of the conglomerate).
    /// Encoded/decoded by serializers as "MEMB".
    /// </summary>
    [EnumMember(Value = "MEMB")]
    [IsoId("_gmiyICCaEeWJd9HF2tO7BA")]
    [Description(@"Member broker of a financial conglomerate (person is a board member, director, officer and employee of a member company of the conglomerate).")]
    MemberBroker,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CompanyLinkCodeMetadataExtensions
{
    private static readonly CompanyLinkCodeDropdownSource _dropdownSource = new CompanyLinkCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICompanyLinkCodeDropdownRow GetMetadata(this CompanyLinkCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


