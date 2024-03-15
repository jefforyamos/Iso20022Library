﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RegulatoryReportingNotification2.  ISO2002 ID# _NcmF5249EeiU9cctagi5ow.
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
/// Provides details on the regulatory notification.
/// </summary>
[IsoId("_NcmF5249EeiU9cctagi5ow")]
[DisplayName("Regulatory Reporting Notification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RegulatoryReportingNotification2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RegulatoryReportingNotification2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RegulatoryReportingNotification2( System.String reqTransactionNotificationIdentification,PartyIdentification135 reqAccountOwner,BranchAndFinancialInstitutionIdentification6 reqAccountServicer )
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
    [IsoId("_Nl1hcW49EeiU9cctagi5ow")]
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
    [IsoId("_Nl1hc249EeiU9cctagi5ow")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification135 AccountOwner { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification135 AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification135 AccountOwner { get; init; } 
    #else
    public PartyIdentification135 AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_Nl1hdW49EeiU9cctagi5ow")]
    [DisplayName("Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcr")]
    #endif
    [IsoXmlTag("AcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification6 AccountServicer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification6 AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6 AccountServicer { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6 AccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Certificate against which all currency control transactions are registered.
    /// </summary>
    [IsoId("_Nl1hd249EeiU9cctagi5ow")]
    [DisplayName("Transaction Certificate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxCert")]
    #endif
    [IsoXmlTag("TxCert")]
    public ValueList<TransactionCertificate3> TransactionCertificate { get; init; } = new ValueList<TransactionCertificate3>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Nl1hd249EeiU9cctagi5ow
    
    
    #nullable disable
    
}
