﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Garnishment2.  ISO2002 ID# _ncGuUbTREeeyuKckOGlwuA.
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
/// Provides remittance information about a payment for garnishment-related purposes.
/// </summary>
[IsoId("_ncGuUbTREeeyuKckOGlwuA")]
[DisplayName("Garnishment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Garnishment2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Garnishment2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Garnishment2( GarnishmentType1 reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of garnishment.
    /// </summary>
    [IsoId("_nkw7EbTREeeyuKckOGlwuA")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GarnishmentType1 Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GarnishmentType1 Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GarnishmentType1 Type { get; init; } 
    #else
    public GarnishmentType1 Type { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor, in this case, to the garnisher.
    /// </summary>
    [IsoId("_nkw7E7TREeeyuKckOGlwuA")]
    [DisplayName("Garnishee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Grnshee")]
    #endif
    [IsoXmlTag("Grnshee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification125? Garnishee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification125? Garnishee { get; init; } 
    #else
    public PartyIdentification125? Garnishee { get; set; } 
    #endif
    
    /// <summary>
    /// Party on the credit side of the transaction who administers the garnishment on behalf of the ultimate beneficiary.
    /// </summary>
    [IsoId("_nkw7FbTREeeyuKckOGlwuA")]
    [DisplayName("Garnishment Administrator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrnshmtAdmstr")]
    #endif
    [IsoXmlTag("GrnshmtAdmstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification125? GarnishmentAdministrator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification125? GarnishmentAdministrator { get; init; } 
    #else
    public PartyIdentification125? GarnishmentAdministrator { get; set; } 
    #endif
    
    /// <summary>
    /// Reference information that is specific to the agency receiving the garnishment.
    /// </summary>
    [IsoId("_nkw7F7TREeeyuKckOGlwuA")]
    [DisplayName("Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefNb")]
    #endif
    [IsoXmlTag("RefNb")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? ReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReferenceNumber { get; init; } 
    #else
    public System.String? ReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Date of payment which garnishment was taken from.
    /// </summary>
    [IsoId("_nkw7GbTREeeyuKckOGlwuA")]
    [DisplayName("Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dt")]
    #endif
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? Date { get; init; } 
    #else
    public System.DateOnly? Date { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money remitted for the referred document.
    /// </summary>
    [IsoId("_nkw7G7TREeeyuKckOGlwuA")]
    [DisplayName("Remitted Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmtdAmt")]
    #endif
    [IsoXmlTag("RmtdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? RemittedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? RemittedAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? RemittedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the person to whom the garnishment applies (that is, the ultimate debtor) has family medical insurance coverage available.
    /// </summary>
    [IsoId("_nkw7HbTREeeyuKckOGlwuA")]
    [DisplayName("Family Medical Insurance Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FmlyMdclInsrncInd")]
    #endif
    [IsoXmlTag("FmlyMdclInsrncInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? FamilyMedicalInsuranceIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FamilyMedicalInsuranceIndicator { get; init; } 
    #else
    public System.String? FamilyMedicalInsuranceIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the employment of the person to whom the garnishment applies (that is, the ultimate debtor) has been terminated.
    /// </summary>
    [IsoId("_nkxiIbTREeeyuKckOGlwuA")]
    [DisplayName("Employee Termination Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MplyeeTermntnInd")]
    #endif
    [IsoXmlTag("MplyeeTermntnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? EmployeeTerminationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EmployeeTerminationIndicator { get; init; } 
    #else
    public System.String? EmployeeTerminationIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
