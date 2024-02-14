﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RegisteredContractJournal1.  ISO2002 ID# _EQv5d9L3EeSDLevdaFPXHw.
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
/// Document that a user must file with an authorised servicer for each contract that involves foreign currency transactions with non residents.
/// </summary>
[IsoId("_EQv5d9L3EeSDLevdaFPXHw")]
[DisplayName("Registered Contract Journal")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RegisteredContractJournal1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RegisteredContractJournal1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RegisteredContractJournal1( BranchAndFinancialInstitutionIdentification5 reqRegistrationAgent,System.DateOnly reqClosureDate,ContractClosureReason1Choice_ reqClosureReason )
    {
        RegistrationAgent = reqRegistrationAgent;
        ClosureDate = reqClosureDate;
        ClosureReason = reqClosureReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Agent which registers the currency control contract.
    /// </summary>
    [IsoId("_wUci0dOVEeSQ_-lmj1tzfw")]
    [DisplayName("Registration Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnAgt")]
    #endif
    [IsoXmlTag("RegnAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification5 RegistrationAgent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification5 RegistrationAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5 RegistrationAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5 RegistrationAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Unique registered contract identification.
    /// </summary>
    [IsoId("_EQv5etL3EeSDLevdaFPXHw")]
    [DisplayName("Unique Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnqId")]
    #endif
    [IsoXmlTag("UnqId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification28? UniqueIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification28? UniqueIdentification { get; init; } 
    #else
    public DocumentIdentification28? UniqueIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date of closure of the registered contract.
    /// </summary>
    [IsoId("_O228gNL3EeSDLevdaFPXHw")]
    [DisplayName("Closure Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsrDt")]
    #endif
    [IsoXmlTag("ClsrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ClosureDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ClosureDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ClosureDate { get; init; } 
    #else
    public System.DateOnly ClosureDate { get; set; } 
    #endif
    
    /// <summary>
    /// Reason of closure 
    /// TBD - codes to be defined.
    /// </summary>
    [IsoId("_yo7RsNL3EeSDLevdaFPXHw")]
    [DisplayName("Closure Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsrRsn")]
    #endif
    [IsoXmlTag("ClsrRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContractClosureReason1Choice_ ClosureReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ContractClosureReason1Choice_ ClosureReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContractClosureReason1Choice_ ClosureReason { get; init; } 
    #else
    public ContractClosureReason1Choice_ ClosureReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
