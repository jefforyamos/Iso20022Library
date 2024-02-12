﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IdentificationInformation2.  ISO2002 ID# _tpQTY1kyEeGeoaLUQk__nA_1045933986.
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
/// Provides the details of the identification information.
/// </summary>
[IsoId("_tpQTY1kyEeGeoaLUQk__nA_1045933986")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Identification Information")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IdentificationInformation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Account owner that owes an amount of money or to whom an amount of money is due.
    /// </summary>
    [IsoId("_tpQTZFkyEeGeoaLUQk__nA_-243096105")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Party")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? Party { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? Party { get; init; } 
    #else
    public PartyIdentification43? Party { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of a party.
    /// </summary>
    [IsoId("_tpZdUFkyEeGeoaLUQk__nA_920996143")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentification4Choice_? Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification4Choice_? Account { get; init; } 
    #else
    public AccountIdentification4Choice_? Account { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution servicing an account for a party.
    /// </summary>
    [IsoId("_tpZdUVkyEeGeoaLUQk__nA_-1232417062")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Agent")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? Agent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? Agent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? Agent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
