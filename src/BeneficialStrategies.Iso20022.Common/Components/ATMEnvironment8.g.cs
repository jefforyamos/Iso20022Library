﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMEnvironment8.  ISO2002 ID# _PfGckYtLEeSxlKlAGYErFg.
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
/// Environment of the key download.
/// </summary>
[IsoId("_PfGckYtLEeSxlKlAGYErFg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("ATM Environment")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMEnvironment8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMEnvironment8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMEnvironment8( AutomatedTellerMachine6 reqATM )
    {
        ATM = reqATM;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Acquirer of the ATM transaction, in charge of the funds settlement with the issuer.
    /// </summary>
    [IsoId("_PrddkYtLEeSxlKlAGYErFg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Acquirer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Acquirer7? Acquirer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Acquirer7? Acquirer { get; init; } 
    #else
    public Acquirer7? Acquirer { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the ATM manager.
    /// </summary>
    [IsoId("_Prddk4tLEeSxlKlAGYErFg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("ATM Manager Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ATMManagerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ATMManagerIdentification { get; init; } 
    #else
    public System.String? ATMManagerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Entity hosting the ATM terminal.
    /// </summary>
    [IsoId("_PrddlYtLEeSxlKlAGYErFg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Hosting Entity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TerminalHosting1? HostingEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalHosting1? HostingEntity { get; init; } 
    #else
    public TerminalHosting1? HostingEntity { get; set; } 
    #endif
    
    /// <summary>
    /// ATM information.
    /// </summary>
    [IsoId("_Prddl4tLEeSxlKlAGYErFg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("ATM")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AutomatedTellerMachine6 ATM { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public AutomatedTellerMachine6 ATM { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AutomatedTellerMachine6 ATM { get; init; } 
    #else
    public AutomatedTellerMachine6 ATM { get; set; } 
    #endif
    
    
    #nullable disable
    
}
