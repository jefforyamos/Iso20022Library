﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountManagementMessageReference4.  ISO2002 ID# _Fl7lsVSfEeatgN-VQ0eFlQ.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the references of an account management instruction message.
/// </summary>
[IsoId("_Fl7lsVSfEeatgN-VQ0eFlQ")]
[DisplayName("Account Management Message Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountManagementMessageReference4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountManagementMessageReference4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountManagementMessageReference4( AccountManagementType3Code reqStatusRequestType )
    {
        StatusRequestType = reqStatusRequestType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to a linked message.
    /// </summary>
    [IsoId("_F-U3mVSfEeatgN-VQ0eFlQ")]
    [DisplayName("Linked Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkdRef")]
    #endif
    [IsoXmlTag("LkdRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LinkedMessage4Choice_? LinkedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LinkedMessage4Choice_? LinkedReference { get; init; } 
    #else
    public LinkedMessage4Choice_? LinkedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Type of account management instruction for which the status is requested or a request to know the status of the account.
    /// </summary>
    [IsoId("_F-U3m1SfEeatgN-VQ0eFlQ")]
    [DisplayName("Status Request Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsReqTp")]
    #endif
    [IsoXmlTag("StsReqTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountManagementType3Code StatusRequestType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountManagementType3Code StatusRequestType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountManagementType3Code StatusRequestType { get; init; } 
    #else
    public AccountManagementType3Code StatusRequestType { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of the account opening or account modification instruction at application level.
    /// </summary>
    [IsoId("_F-U3nVSfEeatgN-VQ0eFlQ")]
    [DisplayName("Account Application Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctApplId")]
    #endif
    [IsoXmlTag("AcctApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountApplicationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountApplicationIdentification { get; init; } 
    #else
    public System.String? AccountApplicationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Account to which the account opening is related.
    /// </summary>
    [IsoId("_F-U3n1SfEeatgN-VQ0eFlQ")]
    [DisplayName("Existing Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExstgAcctId")]
    #endif
    [IsoXmlTag("ExstgAcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Account23? ExistingAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Account23? ExistingAccountIdentification { get; init; } 
    #else
    public Account23? ExistingAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Account information for which the status of an account management instruction is requested.
    /// </summary>
    [IsoId("_F-U3oVSfEeatgN-VQ0eFlQ")]
    [DisplayName("Investment Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcct")]
    #endif
    [IsoXmlTag("InvstmtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccount53? InvestmentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount53? InvestmentAccount { get; init; } 
    #else
    public InvestmentAccount53? InvestmentAccount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
