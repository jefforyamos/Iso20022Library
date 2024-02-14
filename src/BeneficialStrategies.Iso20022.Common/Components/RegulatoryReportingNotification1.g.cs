﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RegulatoryReportingNotification1.  ISO2002 ID# _c-VXQDmyEeWDb47rJ6ki4Q.
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
/// Provides the details on the regulatory notification.
/// </summary>
[IsoId("_c-VXQDmyEeWDb47rJ6ki4Q")]
[DisplayName("Regulatory Reporting Notification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RegulatoryReportingNotification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RegulatoryReportingNotification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RegulatoryReportingNotification1( System.String reqTransactionNotificationIdentification,PartyIdentification77 reqAccountOwner,BranchAndFinancialInstitutionIdentification5 reqAccountServicer )
    {
        TransactionNotificationIdentification = reqTransactionNotificationIdentification;
        AccountOwner = reqAccountOwner;
        AccountServicer = reqAccountServicer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the transaction notification.
    /// </summary>
    [IsoId("_sv4yMTm3EeWDb47rJ6ki4Q")]
    [DisplayName("Transaction Notification Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxNtfctnId")]
    #endif
    [IsoXmlTag("TxNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransactionNotificationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransactionNotificationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionNotificationIdentification { get; init; } 
    #else
    public System.String TransactionNotificationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the cash account.
    /// </summary>
    [IsoId("_zGuYcjm3EeWDb47rJ6ki4Q")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification77 AccountOwner { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification77 AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification77 AccountOwner { get; init; } 
    #else
    public PartyIdentification77 AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_zGuYczm3EeWDb47rJ6ki4Q")]
    [DisplayName("Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcr")]
    #endif
    [IsoXmlTag("AcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification5 AccountServicer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification5 AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5 AccountServicer { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5 AccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Certificate against which all currency control transactions are registered.
    /// </summary>
    [IsoId("_YGMKUTm3EeWDb47rJ6ki4Q")]
    [DisplayName("Transaction Certificate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxCert")]
    #endif
    [IsoXmlTag("TxCert")]
    public TransactionCertificate1? TransactionCertificate { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _YGMKUTm3EeWDb47rJ6ki4Q
    
    
    #nullable disable
    
}
